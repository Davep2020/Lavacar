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
    
    public partial class Tbl_MarcaVehiculo_MV
    {
        public Tbl_MarcaVehiculo_MV()
        {
            this.Tbl_Vehiculo_V = new HashSet<Tbl_Vehiculo_V>();
        }
    
        public int Id_Marca_MV { get; set; }
        public string Codigo_MV { get; set; }
        public string Tipo_MV { get; set; }
        public int Id_Pais_MV { get; set; }
    
        public virtual Tbl_PaisFabricacion_PF Tbl_PaisFabricacion_PF { get; set; }
        public virtual ICollection<Tbl_Vehiculo_V> Tbl_Vehiculo_V { get; set; }
    }
}
