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
    
    public partial class sp_RetornaFacturaServicioID_Result
    {
        public int Id_Servicio_S { get; set; }
        public string Codigo_S { get; set; }
        public string Descripcion_S { get; set; }
        public int Precio_S { get; set; }
        public string Tipo_S { get; set; }
        public int Id_Factura_FVS { get; set; }
        public int Cantidad_FVS { get; set; }
        public Nullable<int> Id_Servicio_FVS { get; set; }
        public int Monto_FVS { get; set; }
        public string Estado_FVS { get; set; }
    }
}