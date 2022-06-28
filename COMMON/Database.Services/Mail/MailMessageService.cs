// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ARCHIVE.COMMON.Entities;
using AutoMapper;
using DATABASE.DTOModels.Mail;
using DATABASE.Entities.Mail;
using DATABASE.Services;
using Newtonsoft.Json;

namespace COMMON.Database.Services.Mail
{
    public class MailMessageService : IMailMessageService
    {
        private readonly IMapper _mapper;
        private readonly IDBReadService _reader;
        private readonly IDBWriteService _writer;

        public MailMessageService(IMapper mapper, IDBReadService reader, IDBWriteService writer)
        {
            _mapper = mapper;
            _reader = reader;
            _writer = writer;
        }

        public async Task AddOrUpdateAsync(MailMessageDTO mailMessage)
        {
            if (mailMessage.Id == 0)
                _writer.Add(_mapper.Map<MailMessage>(mailMessage));
            else
                _writer.Update(_mapper.Map<MailMessage>(mailMessage));

            await _writer.SaveChangesAsync();
        }

        public async Task<IEnumerable<MailMessageDTO>> GetReadyToSendAsync()
        {
            var items = await _reader.GetAsync<MailMessage>(x => !x.SentOn.HasValue);
            return _mapper.Map<List<MailMessageDTO>>(items);
        }

        public async Task ToQueue(List<string> recipients, string subject, string text, List<DocFile> files)
        {
            await AddOrUpdateAsync(new MailMessageDTO
            {
                Recipients = JsonConvert.SerializeObject(recipients),
                CreatedOn = DateTime.UtcNow,
                Subject = subject,
                Text = text,
                Files = (files ?? new List<DocFile>())
                    .Select(x => new MailMessageFileDTO
                    {
                        DocFile = _mapper.Map<DocFileDTO>(x),
                    })
                    .ToList()
            });
        }
    }
}
