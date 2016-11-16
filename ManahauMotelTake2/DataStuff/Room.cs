//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManahauMotelTake2.DataStuff
{
    using System;
    using System.Collections.Generic;
    
    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            this.Joins = new HashSet<Join>();
        }
    
        public int RoomID { get; set; }
        public string Room_Name { get; set; }
        public string RoomType { get; set; }
        public Nullable<int> Double_Beds { get; set; }
        public Nullable<int> Single_Beds { get; set; }
        public Nullable<decimal> TariffSingle { get; set; }
        public Nullable<decimal> TariffCouple { get; set; }
        public Nullable<decimal> TariffExtraPeople { get; set; }
        public Nullable<int> ExtraBeds { get; set; }
        public string Overflow { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Join> Joins { get; set; }
    }
}
