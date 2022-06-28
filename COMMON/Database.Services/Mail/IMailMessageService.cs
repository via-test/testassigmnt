// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Threading.Tasks;
using ARCHIVE.COMMON.Entities;
using DATABASE.DTOModels.Mail;

namespace COMMON.Database.Services
{
    public interface IMailMessageService
    {
        Task ToQueue(List<string> recipients, string subject, string text, List<DocFile> files);

        Task AddOrUpdateAsync(MailMessageDTO mailRecord);

        Task<IEnumerable<MailMessageDTO>> GetReadyToSendAsync();
    }
}
