//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotCommerce.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductVariant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductVariant()
        {
            this.Cart = new HashSet<Cart>();
        }
    
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int VariantId { get; set; }
        public string VariantTitle { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual Product Product { get; set; }
    }
}
