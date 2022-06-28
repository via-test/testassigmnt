﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ARCHIVE.COMMON.Entities;

namespace DATABASE.Entities.Mail
{
    public class MailMessageFile
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public long MailRecordId { get; set; }

        public MailMessage MailRecord { get; set; }

        [Required]
        public long DocFileId { get; set; }

        public DocFile DocFile { get; set; }
    }
}
