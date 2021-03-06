//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicStore.WebUI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Album
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Album()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int AlbumID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public decimal GoogleRate { get; set; }
        public int ArtistID { get; set; }
        public int GenreID { get; set; }
        public string Description { get; set; }
        public string PhotoNr1 { get; set; }
        public string PhotoNr2 { get; set; }
        public string PhotoNr3 { get; set; }
        public string PhotoNr4 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
