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
    
    public partial class HOA_DON
    {
        public HOA_DON()
        {
            this.CHI_TIET_HOA_DON = new HashSet<CHI_TIET_HOA_DON>();
        }
    
        public int MAHD { get; set; }
        public System.DateTime NGAYLAP { get; set; }
        public int MANVLAP { get; set; }
        public int SOBAN { get; set; }
        public int TRANGTHAI { get; set; }
        public bool TRANGTHAIXOA { get; set; }
        public double TONGTIEN { get; set; }
    
        public virtual BAN BAN { get; set; }
        public virtual ICollection<CHI_TIET_HOA_DON> CHI_TIET_HOA_DON { get; set; }
        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
    }
}
