//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHA_CUNG_CAP
    {
        public NHA_CUNG_CAP()
        {
            this.DON_DAT_HANG = new HashSet<DON_DAT_HANG>();
            this.PHIEU_NHAP_HANG = new HashSet<PHIEU_NHAP_HANG>();
        }
    
        public int MANCC { get; set; }
        public string TENNCC { get; set; }
        public string DIACHI { get; set; }
        public string SDT { get; set; }
        public bool TRANGTHAIXOA { get; set; }
    
        public virtual ICollection<DON_DAT_HANG> DON_DAT_HANG { get; set; }
        public virtual ICollection<PHIEU_NHAP_HANG> PHIEU_NHAP_HANG { get; set; }
    }
}
