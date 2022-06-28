// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DATABASE.Entities.Mail
{
    public class MailMessage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public string Recipients { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public DateTime? SentOn { get; set; }

        public ICollection<MailMessageFile> Files { get; set; }
    }
}
