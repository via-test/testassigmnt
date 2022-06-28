// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.ComponentModel.DataAnnotations;
using ARCHIVE.COMMON.Entities;

namespace DATABASE.DTOModels.Mail
{
    public class MailMessageFileDTO
    {
        public long Id { get; set; }

        [Required]
        public long MailRecordId { get; set; }

        [Required]
        public long DocFileId { get; set; }

        public DocFileDTO DocFile { get; set; }
    }
}
