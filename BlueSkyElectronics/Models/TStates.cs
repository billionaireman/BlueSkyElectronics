using System;
using System.Collections.Generic;

namespace BlueSkyElectronics.Models
{
    public partial class TStates
    {
        public TStates()
        {
            TStatesElectronicFiling = new HashSet<TStatesElectronicFiling>();
        }

        public int StateId { get; set; }
        public string StCode { get; set; }
        public string StName { get; set; }
        public string AddrContact { get; set; }
        public string AddrLine1 { get; set; }
        public string AddrLine2 { get; set; }
        public string AddrCity { get; set; }
        public string AddrState { get; set; }
        public string AddrZipcode { get; set; }
        public string AddrCountry { get; set; }
        public byte? StFund { get; set; }
        public byte? StPortfolio { get; set; }
        public byte? StClass { get; set; }
        public byte? StProspectus { get; set; }
        public byte? StNofiling { get; set; }
        public string Acptbatchcheck { get; set; }
        public string OvrContact { get; set; }
        public string OvrAddrLine1 { get; set; }
        public string OvrAddrLine2 { get; set; }
        public string OvrAddrCity { get; set; }
        public string OvrAddrState { get; set; }
        public string OvrAddrZipcode { get; set; }
        public string OvrAddrCountry { get; set; }
        public string FilingRulePages { get; set; }
        public string Discrepancies { get; set; }
        public string CheckPayee { get; set; }
        public string ConPermit { get; set; }
        public string ConDuplicateNf { get; set; }
        public string ConStampedRcpt { get; set; }
        public string ConDuplicate { get; set; }
        public int? SignatureId { get; set; }
        public int? FeePaymentId { get; set; }
        public string AccptElecFiling { get; set; }
        public string DiscParValue { get; set; }
        public string Addr1Phone { get; set; }
        public string Addr1Fax { get; set; }
        public string Addr1Email { get; set; }
        public int? U2DesigneeId { get; set; }
        public string U2Designee { get; set; }

        public virtual ICollection<TStatesElectronicFiling> TStatesElectronicFiling { get; set; }
    }
}
