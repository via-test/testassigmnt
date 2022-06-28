// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ARCHIVE.COMMON.Entities;
using AutoMapper;
using CloudArchive.Services;
using COMMON.Database.Services;
using Newtonsoft.Json;

namespace COMMON.Common.Services.Mail
{
    public class MailMessageQueueService : IMailMessageQueueService
    {
        private readonly IMailMessageService _mailService;
        private readonly IEmailService _emailSender;
        private readonly IMapper _mapper;

        public MailMessageQueueService(IMailMessageService mailService, IEmailService emailSender, IMapper mapper)
        {
            _mailService = mailService;
            _emailSender = emailSender;
            _mapper = mapper;
        }

        public async Task SendAllAsync()
        {
            var messages = await _mailService.GetReadyToSendAsync();
            foreach (var message in messages)
            {
                List<string> emails = JsonConvert.DeserializeObject<List<string>>(message.Subject);
                string subject = message.Subject;
                string text = message.Text;
                List<DocFile> files = _mapper.Map<List<DocFile>>(message.Files.ToList());
                await _emailSender.SendEmailAsync(emails, subject, text, files);

                message.SentOn = DateTime.UtcNow;
                await _mailService.AddOrUpdateAsync(message);
            }
        }
    }
}
