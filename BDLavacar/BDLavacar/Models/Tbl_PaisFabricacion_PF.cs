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
    
    public partial class Tbl_PaisFabricacion_PF
    {
        public Tbl_PaisFabricacion_PF()
        {
            this.Tbl_MarcaVehiculo_MV = new HashSet<Tbl_MarcaVehiculo_MV>();
        }
    
        public int Id_PaisFabricacion_PF { get; set; }
        public string Codigo_PF { get; set; }
        public string Pais_PF { get; set; }
    
        public virtual ICollection<Tbl_MarcaVehiculo_MV> Tbl_MarcaVehiculo_MV { get; set; }
    }
}
