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
    
    public partial class Tbl_TipoPersona_TP
    {
        public Tbl_TipoPersona_TP()
        {
            this.Tbl_Persona_P = new HashSet<Tbl_Persona_P>();
        }
    
        public int Id_TipoPersona_TP { get; set; }
        public string Tipo_TP { get; set; }
    
        public virtual ICollection<Tbl_Persona_P> Tbl_Persona_P { get; set; }
    }
}