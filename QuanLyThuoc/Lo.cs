//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyThuoc
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lo
    {
        public string SoLo { get; set; }
        public string MaThuoc { get; set; }
        public Nullable<System.DateTime> NgaySanXuat { get; set; }
        public Nullable<System.DateTime> HanSuDung { get; set; }
    
        public virtual Thuoc Thuoc { get; set; }
    }
}
