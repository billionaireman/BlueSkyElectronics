using System;
using System.Collections.Generic;

namespace BlueSkyElectronics.Models
{
    public partial class TStatesElectronicFiling
    {
        public int Id { get; set; }
        public int StateId { get; set; }
        public string Url { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public bool Deleted { get; set; }
        public short? AmendmentTypesAccepted { get; set; }
        public int? ElectronicFilingType { get; set; }

        public virtual TStates State { get; set; }
    }
}
