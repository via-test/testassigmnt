﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.ComponentModel.DataAnnotations;

namespace ARCHIVE.COMMON.Entities
{
    public class MetadataExtended
    {
        public Int64 Id { get; set; }
        [MaxLength(100)]
        public string PackageID { get; set; }
        public string CardData { get; set; }
        public string TablePart { get; set; }
        [MaxLength(30)]
        public string Source { get; set; }
        [MaxLength(80)]
        public string DocNumber { get; set; }
        public DateTime? DocDate { get; set; }
        public double? Amount { get; set; }
        public double? AmountWOVAT { get; set; }
        public double? AmountToPay { get; set; }
        public double? VAT { get; set; }
        [MaxLength(3)]
        public string Currency { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public DateTime Modified { get; set; }
        public bool? UploadedTo1C { get; set; }
        [Required]
        [MaxLength(255)]
        public string ModifiedBy { get; set; }
        [MaxLength(255)]
        public string CreatedBy { get; set; }
        [MaxLength(255)]
        public string DeletedBy { get; set; }
        [MaxLength(150)]
        public string Ext_ID { get; set; }
        [MaxLength(80)]
        public string DocNumTaxInvoice { get; set; }
        public DateTime? DocDateTaxInvoice { get; set; }
        [MaxLength(80)]
        public string DocNumInvoice { get; set; }
        public DateTime? DocDateInvoice { get; set; }
        [MaxLength(200)]
        public string Operation { get; set; }
        public bool Signed { get; set; }
        public bool Paid { get; set; }
        [MaxLength(2000)]
        public string Comment { get; set; }
        public DateTime? PeriodFrom { get; set; }
        public DateTime? PeriodTo { get; set; }
        [MaxLength(200)]
        public string Reciever { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }
        [MaxLength(100)]
        public string Delivery { get; set; }
        [MaxLength(200)]
        public string Contact { get; set; }
        public DateTime? PaymentDate { get; set; }
        [MaxLength(50)]
        public string PaymentNumber { get; set; }
        [Required]
        public int? ClientId { get; set; }
        public Client Client { get; set; }
        [Required]
        public int DocTypeId { get; set; }
        public DocType DocType { get; set; }
        public int? ContractorId { get; set; }
        public Contractor Contractor { get; set; }
        public int? OrganizationId { get; set; }
        public Organization Organization { get; set; }
        public int? DocKindId { get; set; }
        public DocKind DocKind { get; set; }
        public int? ContractId { get; set; }
        public Contract Contract { get; set; }
        public int? ProjectId { get; set; }
        public Project Project { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeleteDate { get; set; }
        [MaxLength(50)]
        public string State { get; set; }
        [MaxLength(200)]
        public string EDIId { get; set; }
        [MaxLength(50)]
        public string EDIState { get; set; }
        [MaxLength(50)]
        public string EDIProvider { get; set; }
        public bool EDIProcessed { get; set; }
        public bool EdiNeedExport { get; set; }
        public bool EDILocalSigned { get; set; }
        public bool EDIIsIncoming { get; set; }
        [MaxLength(100)]
        public string NotifyUser { get; set; }

        public string String1 { get; set; }
        public string String2 { get; set; }
        public string String3 { get; set; }
        public string String4 { get; set; }
        public string String5 { get; set; }
        public string String6 { get; set; }
        public string String7 { get; set; }
        public string String8 { get; set; }
        public DateTime? Datetime1 { get; set; }
        public DateTime? Datetime2 { get; set; }
        public DateTime? Datetime3 { get; set; }
        public DateTime? Datetime4 { get; set; }
        public int? Int1 { get; set; }
        public int? Int2 { get; set; }
        public int? Int3 { get; set; }
        public int? Int4 { get; set; }
        public bool? Bool1 { get; set; }
        public bool? Bool2 { get; set; }
        public bool? Bool3 { get; set; }
        public bool? Bool4 { get; set; }
    }
}
