//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewStoreSA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            this.Compras = new HashSet<Compras>();
            this.Ventas = new HashSet<Ventas>();
        }
    
        public int Id { get; set; }
        [Required]
        [Display (Name = "Ingrese el código de barras:")]
        public int c_barras { get; set; }
        [Display (Name = "Agregue una descripción del producto:")]
        public string description { get; set; }
        [Required]
        [Display (Name = "Ingrese una cantidad de productos actuales:")]
        public int cantidad { get; set; }
        [Required]
        [Display (Name = "Precio original:")]
        public double precio_costo { get; set; }
        [Display (Name = "Precio al mayorero 1")]
        public double precio_venta1 { get; set; }
        [Display (Name = "Precio al mayorero 2")]
        public double precio_venta2 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compras> Compras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ventas> Ventas { get; set; }
    }
}
