// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DATABASE.DTOModels.Mail
{
    public class MailMessageDTO
    {
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

        public ICollection<MailMessageFileDTO> Files { get; set; }
    }
}
