
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
    
public partial class sp_RetornaVistaClientes_Result
{

    public Nullable<int> Id_Cliente_P { get; set; }

    public string Cedula_P { get; set; }

    public string Genero_P { get; set; }

    public string Fecha_Nacimiento_P { get; set; }

    public string Nombre_P { get; set; }

    public string PApellido { get; set; }

    public string SApellido { get; set; }

    public string Correo_P { get; set; }

    public Nullable<int> Id_Provincia_P { get; set; }

    public Nullable<int> Id_Canton_P { get; set; }

    public Nullable<int> Id_Tipo_P { get; set; }

    public Nullable<int> Id_Distrito_P { get; set; }

    public Nullable<int> Id_TipoPersona_TP { get; set; }

    public string Tipo_TP { get; set; }

    public Nullable<int> Id_Factura_F { get; set; }

    public Nullable<int> Id_Vehiculo_F { get; set; }

    public Nullable<int> Id_Persona_F { get; set; }

    public Nullable<int> Total_F { get; set; }

    public string Fecha_F { get; set; }

    public Nullable<int> Id_Factura_FVS { get; set; }

    public Nullable<int> Cantidad_FVS { get; set; }

    public Nullable<int> Id_Servicio_FVS { get; set; }

    public Nullable<int> Monto_FVS { get; set; }

    public string Estado_FVS { get; set; }

    public Nullable<int> Id_Servicio_S { get; set; }

    public string Codigo_S { get; set; }

    public string Descripcion_S { get; set; }

    public Nullable<int> Precio_S { get; set; }

    public string Tipo_S { get; set; }

    public Nullable<int> Id_Vehiculo_V { get; set; }

    public string Placa_V { get; set; }

    public Nullable<int> Id_Marca_V { get; set; }

    public Nullable<int> Id_Tipo_V { get; set; }

    public Nullable<int> Numero_Puertas_V { get; set; }

    public Nullable<int> Numero_Ruedas_V { get; set; }

    public Nullable<int> Id_Usuarios_SG { get; set; }

    public string Usuario_SG { get; set; }

    public string Contraseña_SG { get; set; }

    public Nullable<int> Id_Cliente_SG { get; set; }

    public Nullable<System.DateTime> UltimaFecha_SG { get; set; }

    public Nullable<int> Id_Marca_MV { get; set; }

    public string Codigo_MV { get; set; }

    public string Tipo_MV { get; set; }

    public Nullable<int> Id_Pais_MV { get; set; }

}

}
