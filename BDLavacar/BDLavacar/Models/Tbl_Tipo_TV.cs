//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BDLavacar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Tipo_TV
    {
        public Tbl_Tipo_TV()
        {
            this.Tbl_Vehiculo_V = new HashSet<Tbl_Vehiculo_V>();
        }
    
        public int Id_Tipo_TV { get; set; }
        public string Tipo_TV { get; set; }
    
        public virtual ICollection<Tbl_Vehiculo_V> Tbl_Vehiculo_V { get; set; }
    }
}
