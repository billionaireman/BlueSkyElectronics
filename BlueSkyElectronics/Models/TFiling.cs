using System;
using System.Collections.Generic;

namespace BlueSkyElectronics.Models
{
    public partial class TFiling
    {
        public int FilingId { get; set; }
        public int? FilingNo { get; set; }
        public byte FilingTypeId { get; set; }
        public int StateId { get; set; }
        public int? SecurityId { get; set; }
        public string Prospectus { get; set; }
        public int? CheckId { get; set; }
        public string PermitNo { get; set; }
        public byte StatusId { get; set; }
        public DateTime FiledDate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string EffDateCode { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal? RegisteredAmt { get; set; }
        public decimal? SoldAmt { get; set; }
        public decimal? FilingFee { get; set; }
        public int? EnvelopeId { get; set; }
        public string Notes { get; set; }
        public string Deleted { get; set; }
        public string FilingCategoryCode { get; set; }
        public string FeeBasicCode { get; set; }
        public int? FilingRuleId { get; set; }
        public string Renewal { get; set; }
        public decimal? ChequeAmount { get; set; }
        public DateTime? SalesFromDate { get; set; }
        public DateTime? SalesToDate { get; set; }
    }
}
