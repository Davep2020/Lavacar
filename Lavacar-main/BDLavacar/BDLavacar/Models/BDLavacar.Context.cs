﻿

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
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;


public partial class bdlavacarEntities2 : DbContext
{
    public bdlavacarEntities2()
        : base("name=bdlavacarEntities2")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public DbSet<Canton> Canton { get; set; }

    public DbSet<Distrito> Distrito { get; set; }

    public DbSet<Provincia> Provincia { get; set; }

    public DbSet<Tbl_MarcaVehiculo_MV> Tbl_MarcaVehiculo_MV { get; set; }

    public DbSet<Tbl_PaisFabricacion_PF> Tbl_PaisFabricacion_PF { get; set; }

    public DbSet<Tbl_Persona_P> Tbl_Persona_P { get; set; }

    public DbSet<Tbl_Seguridad_SG> Tbl_Seguridad_SG { get; set; }

    public DbSet<Tbl_Servicio_S> Tbl_Servicio_S { get; set; }

    public DbSet<Tbl_Tipo_TV> Tbl_Tipo_TV { get; set; }

    public DbSet<Tbl_TipoPersona_TP> Tbl_TipoPersona_TP { get; set; }

    public DbSet<Tbl_Vehiculo_V> Tbl_Vehiculo_V { get; set; }

    public DbSet<TblFactura_F> TblFactura_F { get; set; }

    public DbSet<Tbl_FacturaServicioVehiculo_FSV> Tbl_FacturaServicioVehiculo_FSV { get; set; }


    public virtual ObjectResult<RetornaCantones_Result> RetornaCantones(string nombre, Nullable<int> id_Provincia)
    {

        var nombreParameter = nombre != null ?
            new ObjectParameter("nombre", nombre) :
            new ObjectParameter("nombre", typeof(string));


        var id_ProvinciaParameter = id_Provincia.HasValue ?
            new ObjectParameter("id_Provincia", id_Provincia) :
            new ObjectParameter("id_Provincia", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RetornaCantones_Result>("RetornaCantones", nombreParameter, id_ProvinciaParameter);
    }


    public virtual ObjectResult<RetornaCantonesID_Result> RetornaCantonesID(Nullable<int> id_Canton)
    {

        var id_CantonParameter = id_Canton.HasValue ?
            new ObjectParameter("id_Canton", id_Canton) :
            new ObjectParameter("id_Canton", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RetornaCantonesID_Result>("RetornaCantonesID", id_CantonParameter);
    }


    public virtual ObjectResult<RetornaProvincias_Result> RetornaProvincias(string nombre)
    {

        var nombreParameter = nombre != null ?
            new ObjectParameter("nombre", nombre) :
            new ObjectParameter("nombre", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RetornaProvincias_Result>("RetornaProvincias", nombreParameter);
    }


    public virtual int sp_EliminaCanton(Nullable<int> id_Canton)
    {

        var id_CantonParameter = id_Canton.HasValue ?
            new ObjectParameter("id_Canton", id_Canton) :
            new ObjectParameter("id_Canton", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminaCanton", id_CantonParameter);
    }


    public virtual int sp_EliminaMarcaVehiculo(Nullable<int> idMarcaVehiculo)
    {

        var idMarcaVehiculoParameter = idMarcaVehiculo.HasValue ?
            new ObjectParameter("idMarcaVehiculo", idMarcaVehiculo) :
            new ObjectParameter("idMarcaVehiculo", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminaMarcaVehiculo", idMarcaVehiculoParameter);
    }


    public virtual int sp_EliminaPaisFabricante(Nullable<int> idPais)
    {

        var idPaisParameter = idPais.HasValue ?
            new ObjectParameter("idPais", idPais) :
            new ObjectParameter("idPais", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminaPaisFabricante", idPaisParameter);
    }


    public virtual int sp_EliminaPersona(Nullable<int> id_Cliente_P)
    {

        var id_Cliente_PParameter = id_Cliente_P.HasValue ?
            new ObjectParameter("Id_Cliente_P", id_Cliente_P) :
            new ObjectParameter("Id_Cliente_P", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminaPersona", id_Cliente_PParameter);
    }


    public virtual int sp_EliminarPreFactura(Nullable<int> idfactura)
    {

        var idfacturaParameter = idfactura.HasValue ?
            new ObjectParameter("idfactura", idfactura) :
            new ObjectParameter("idfactura", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminarPreFactura", idfacturaParameter);
    }


    public virtual int sp_EliminaServicio(Nullable<int> id_Servicio_S)
    {

        var id_Servicio_SParameter = id_Servicio_S.HasValue ?
            new ObjectParameter("Id_Servicio_S", id_Servicio_S) :
            new ObjectParameter("Id_Servicio_S", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminaServicio", id_Servicio_SParameter);
    }


    public virtual int sp_EliminaTipoVehiculo(Nullable<int> idTipoVehiculo)
    {

        var idTipoVehiculoParameter = idTipoVehiculo.HasValue ?
            new ObjectParameter("idTipoVehiculo", idTipoVehiculo) :
            new ObjectParameter("idTipoVehiculo", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminaTipoVehiculo", idTipoVehiculoParameter);
    }


    public virtual int sp_EliminaVehiculo(Nullable<int> idVehiculo)
    {

        var idVehiculoParameter = idVehiculo.HasValue ?
            new ObjectParameter("idVehiculo", idVehiculo) :
            new ObjectParameter("idVehiculo", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminaVehiculo", idVehiculoParameter);
    }


    public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
    }


    public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
    }


    public virtual int sp_InsertaCanton(Nullable<int> id_Provincia, string nombre, Nullable<int> id_CantonInec)
    {

        var id_ProvinciaParameter = id_Provincia.HasValue ?
            new ObjectParameter("id_Provincia", id_Provincia) :
            new ObjectParameter("id_Provincia", typeof(int));


        var nombreParameter = nombre != null ?
            new ObjectParameter("nombre", nombre) :
            new ObjectParameter("nombre", typeof(string));


        var id_CantonInecParameter = id_CantonInec.HasValue ?
            new ObjectParameter("id_CantonInec", id_CantonInec) :
            new ObjectParameter("id_CantonInec", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertaCanton", id_ProvinciaParameter, nombreParameter, id_CantonInecParameter);
    }


    public virtual int sp_InsertaMarcaVehiculo(string tipoVehiculo, string codigo, Nullable<int> idPais)
    {

        var tipoVehiculoParameter = tipoVehiculo != null ?
            new ObjectParameter("tipoVehiculo", tipoVehiculo) :
            new ObjectParameter("tipoVehiculo", typeof(string));


        var codigoParameter = codigo != null ?
            new ObjectParameter("codigo", codigo) :
            new ObjectParameter("codigo", typeof(string));


        var idPaisParameter = idPais.HasValue ?
            new ObjectParameter("idPais", idPais) :
            new ObjectParameter("idPais", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertaMarcaVehiculo", tipoVehiculoParameter, codigoParameter, idPaisParameter);
    }


    public virtual int sp_InsertaPaisFabricante(string nombre, string codigo)
    {

        var nombreParameter = nombre != null ?
            new ObjectParameter("nombre", nombre) :
            new ObjectParameter("nombre", typeof(string));


        var codigoParameter = codigo != null ?
            new ObjectParameter("codigo", codigo) :
            new ObjectParameter("codigo", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertaPaisFabricante", nombreParameter, codigoParameter);
    }


    public virtual int sp_InsertarPersona(string cedula, string genero, string fecha, string nombre, string pnombre, string snombre, string correo, Nullable<int> idProvincia, Nullable<int> idCanton, Nullable<int> idDistrito, Nullable<int> tipo)
    {

        var cedulaParameter = cedula != null ?
            new ObjectParameter("cedula", cedula) :
            new ObjectParameter("cedula", typeof(string));


        var generoParameter = genero != null ?
            new ObjectParameter("Genero", genero) :
            new ObjectParameter("Genero", typeof(string));


        var fechaParameter = fecha != null ?
            new ObjectParameter("fecha", fecha) :
            new ObjectParameter("fecha", typeof(string));


        var nombreParameter = nombre != null ?
            new ObjectParameter("nombre", nombre) :
            new ObjectParameter("nombre", typeof(string));


        var pnombreParameter = pnombre != null ?
            new ObjectParameter("Pnombre", pnombre) :
            new ObjectParameter("Pnombre", typeof(string));


        var snombreParameter = snombre != null ?
            new ObjectParameter("Snombre", snombre) :
            new ObjectParameter("Snombre", typeof(string));


        var correoParameter = correo != null ?
            new ObjectParameter("correo", correo) :
            new ObjectParameter("correo", typeof(string));


        var idProvinciaParameter = idProvincia.HasValue ?
            new ObjectParameter("idProvincia", idProvincia) :
            new ObjectParameter("idProvincia", typeof(int));


        var idCantonParameter = idCanton.HasValue ?
            new ObjectParameter("idCanton", idCanton) :
            new ObjectParameter("idCanton", typeof(int));


        var idDistritoParameter = idDistrito.HasValue ?
            new ObjectParameter("idDistrito", idDistrito) :
            new ObjectParameter("idDistrito", typeof(int));


        var tipoParameter = tipo.HasValue ?
            new ObjectParameter("tipo", tipo) :
            new ObjectParameter("tipo", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertarPersona", cedulaParameter, generoParameter, fechaParameter, nombreParameter, pnombreParameter, snombreParameter, correoParameter, idProvinciaParameter, idCantonParameter, idDistritoParameter, tipoParameter);
    }


    public virtual int sp_InsertaServicio(string codigo_S, string descripcion_S, Nullable<int> precio_S, string tipo_S)
    {

        var codigo_SParameter = codigo_S != null ?
            new ObjectParameter("Codigo_S", codigo_S) :
            new ObjectParameter("Codigo_S", typeof(string));


        var descripcion_SParameter = descripcion_S != null ?
            new ObjectParameter("Descripcion_S", descripcion_S) :
            new ObjectParameter("Descripcion_S", typeof(string));


        var precio_SParameter = precio_S.HasValue ?
            new ObjectParameter("Precio_S", precio_S) :
            new ObjectParameter("Precio_S", typeof(int));


        var tipo_SParameter = tipo_S != null ?
            new ObjectParameter("Tipo_S", tipo_S) :
            new ObjectParameter("Tipo_S", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertaServicio", codigo_SParameter, descripcion_SParameter, precio_SParameter, tipo_SParameter);
    }


    public virtual int sp_InsertaServicioFactura(Nullable<int> idfactura, Nullable<int> cantidad, Nullable<int> servicio)
    {

        var idfacturaParameter = idfactura.HasValue ?
            new ObjectParameter("idfactura", idfactura) :
            new ObjectParameter("idfactura", typeof(int));


        var cantidadParameter = cantidad.HasValue ?
            new ObjectParameter("Cantidad", cantidad) :
            new ObjectParameter("Cantidad", typeof(int));


        var servicioParameter = servicio.HasValue ?
            new ObjectParameter("Servicio", servicio) :
            new ObjectParameter("Servicio", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertaServicioFactura", idfacturaParameter, cantidadParameter, servicioParameter);
    }


    public virtual int sp_InsertaTipoVehiculo(string tipoVehiculo, string codigo)
    {

        var tipoVehiculoParameter = tipoVehiculo != null ?
            new ObjectParameter("tipoVehiculo", tipoVehiculo) :
            new ObjectParameter("tipoVehiculo", typeof(string));


        var codigoParameter = codigo != null ?
            new ObjectParameter("codigo", codigo) :
            new ObjectParameter("codigo", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertaTipoVehiculo", tipoVehiculoParameter, codigoParameter);
    }


    public virtual int sp_InsertaVehiculo(string placa, Nullable<int> idMarca, Nullable<int> idTipoVehiculo, Nullable<int> puertas, Nullable<int> ruedas)
    {

        var placaParameter = placa != null ?
            new ObjectParameter("placa", placa) :
            new ObjectParameter("placa", typeof(string));


        var idMarcaParameter = idMarca.HasValue ?
            new ObjectParameter("idMarca", idMarca) :
            new ObjectParameter("idMarca", typeof(int));


        var idTipoVehiculoParameter = idTipoVehiculo.HasValue ?
            new ObjectParameter("idTipoVehiculo", idTipoVehiculo) :
            new ObjectParameter("idTipoVehiculo", typeof(int));


        var puertasParameter = puertas.HasValue ?
            new ObjectParameter("puertas", puertas) :
            new ObjectParameter("puertas", typeof(int));


        var ruedasParameter = ruedas.HasValue ?
            new ObjectParameter("ruedas", ruedas) :
            new ObjectParameter("ruedas", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertaVehiculo", placaParameter, idMarcaParameter, idTipoVehiculoParameter, puertasParameter, ruedasParameter);
    }


    public virtual int sp_ModificaCanton(Nullable<int> id_Canton, Nullable<int> id_Provincia, string nombre, Nullable<int> id_CantonInec)
    {

        var id_CantonParameter = id_Canton.HasValue ?
            new ObjectParameter("id_Canton", id_Canton) :
            new ObjectParameter("id_Canton", typeof(int));


        var id_ProvinciaParameter = id_Provincia.HasValue ?
            new ObjectParameter("id_Provincia", id_Provincia) :
            new ObjectParameter("id_Provincia", typeof(int));


        var nombreParameter = nombre != null ?
            new ObjectParameter("nombre", nombre) :
            new ObjectParameter("nombre", typeof(string));


        var id_CantonInecParameter = id_CantonInec.HasValue ?
            new ObjectParameter("id_CantonInec", id_CantonInec) :
            new ObjectParameter("id_CantonInec", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ModificaCanton", id_CantonParameter, id_ProvinciaParameter, nombreParameter, id_CantonInecParameter);
    }


    public virtual int sp_ModificaClientes(Nullable<int> id_Cliente_P, Nullable<int> cedula_P, string genero_P, string fecha_Nacimiento_P, string nombre_P, string pNombre_P, string sNombre_P, string correo_P, Nullable<int> id_Provincia_P, Nullable<int> id_Canton_P, Nullable<int> id_Tipo_P, Nullable<int> id_Distrito_P)
    {

        var id_Cliente_PParameter = id_Cliente_P.HasValue ?
            new ObjectParameter("Id_Cliente_P", id_Cliente_P) :
            new ObjectParameter("Id_Cliente_P", typeof(int));


        var cedula_PParameter = cedula_P.HasValue ?
            new ObjectParameter("Cedula_P", cedula_P) :
            new ObjectParameter("Cedula_P", typeof(int));


        var genero_PParameter = genero_P != null ?
            new ObjectParameter("Genero_P", genero_P) :
            new ObjectParameter("Genero_P", typeof(string));


        var fecha_Nacimiento_PParameter = fecha_Nacimiento_P != null ?
            new ObjectParameter("Fecha_Nacimiento_P", fecha_Nacimiento_P) :
            new ObjectParameter("Fecha_Nacimiento_P", typeof(string));


        var nombre_PParameter = nombre_P != null ?
            new ObjectParameter("Nombre_P", nombre_P) :
            new ObjectParameter("Nombre_P", typeof(string));


        var pNombre_PParameter = pNombre_P != null ?
            new ObjectParameter("PNombre_P", pNombre_P) :
            new ObjectParameter("PNombre_P", typeof(string));


        var sNombre_PParameter = sNombre_P != null ?
            new ObjectParameter("SNombre_P", sNombre_P) :
            new ObjectParameter("SNombre_P", typeof(string));


        var correo_PParameter = correo_P != null ?
            new ObjectParameter("Correo_P", correo_P) :
            new ObjectParameter("Correo_P", typeof(string));


        var id_Provincia_PParameter = id_Provincia_P.HasValue ?
            new ObjectParameter("Id_Provincia_P", id_Provincia_P) :
            new ObjectParameter("Id_Provincia_P", typeof(int));


        var id_Canton_PParameter = id_Canton_P.HasValue ?
            new ObjectParameter("Id_Canton_P", id_Canton_P) :
            new ObjectParameter("Id_Canton_P", typeof(int));


        var id_Tipo_PParameter = id_Tipo_P.HasValue ?
            new ObjectParameter("Id_Tipo_P", id_Tipo_P) :
            new ObjectParameter("Id_Tipo_P", typeof(int));


        var id_Distrito_PParameter = id_Distrito_P.HasValue ?
            new ObjectParameter("Id_Distrito_P", id_Distrito_P) :
            new ObjectParameter("Id_Distrito_P", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ModificaClientes", id_Cliente_PParameter, cedula_PParameter, genero_PParameter, fecha_Nacimiento_PParameter, nombre_PParameter, pNombre_PParameter, sNombre_PParameter, correo_PParameter, id_Provincia_PParameter, id_Canton_PParameter, id_Tipo_PParameter, id_Distrito_PParameter);
    }


    public virtual int sp_ModificaMarcaVehiculo(Nullable<int> idMarcaVehiculo, Nullable<int> idPaisFabricacion, string marcaVehiculo, string codigo)
    {

        var idMarcaVehiculoParameter = idMarcaVehiculo.HasValue ?
            new ObjectParameter("idMarcaVehiculo", idMarcaVehiculo) :
            new ObjectParameter("idMarcaVehiculo", typeof(int));


        var idPaisFabricacionParameter = idPaisFabricacion.HasValue ?
            new ObjectParameter("idPaisFabricacion", idPaisFabricacion) :
            new ObjectParameter("idPaisFabricacion", typeof(int));


        var marcaVehiculoParameter = marcaVehiculo != null ?
            new ObjectParameter("marcaVehiculo", marcaVehiculo) :
            new ObjectParameter("marcaVehiculo", typeof(string));


        var codigoParameter = codigo != null ?
            new ObjectParameter("codigo", codigo) :
            new ObjectParameter("codigo", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ModificaMarcaVehiculo", idMarcaVehiculoParameter, idPaisFabricacionParameter, marcaVehiculoParameter, codigoParameter);
    }


    public virtual int sp_ModificaPaisFabricante(Nullable<int> id_Pais, string codigo, string pais)
    {

        var id_PaisParameter = id_Pais.HasValue ?
            new ObjectParameter("id_Pais", id_Pais) :
            new ObjectParameter("id_Pais", typeof(int));


        var codigoParameter = codigo != null ?
            new ObjectParameter("codigo", codigo) :
            new ObjectParameter("codigo", typeof(string));


        var paisParameter = pais != null ?
            new ObjectParameter("pais", pais) :
            new ObjectParameter("pais", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ModificaPaisFabricante", id_PaisParameter, codigoParameter, paisParameter);
    }


    public virtual int sp_ModificaServicio(Nullable<int> id_Servicio_S, string codigo_S, string descripcion_S, Nullable<int> precio_S, string tipo_S)
    {

        var id_Servicio_SParameter = id_Servicio_S.HasValue ?
            new ObjectParameter("Id_Servicio_S", id_Servicio_S) :
            new ObjectParameter("Id_Servicio_S", typeof(int));


        var codigo_SParameter = codigo_S != null ?
            new ObjectParameter("Codigo_S", codigo_S) :
            new ObjectParameter("Codigo_S", typeof(string));


        var descripcion_SParameter = descripcion_S != null ?
            new ObjectParameter("Descripcion_S", descripcion_S) :
            new ObjectParameter("Descripcion_S", typeof(string));


        var precio_SParameter = precio_S.HasValue ?
            new ObjectParameter("Precio_S", precio_S) :
            new ObjectParameter("Precio_S", typeof(int));


        var tipo_SParameter = tipo_S != null ?
            new ObjectParameter("Tipo_S", tipo_S) :
            new ObjectParameter("Tipo_S", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ModificaServicio", id_Servicio_SParameter, codigo_SParameter, descripcion_SParameter, precio_SParameter, tipo_SParameter);
    }


    public virtual int sp_ModificaTipoVehiculo(Nullable<int> idTipoVehiculo, string tipoVehiculo, string codigo)
    {

        var idTipoVehiculoParameter = idTipoVehiculo.HasValue ?
            new ObjectParameter("idTipoVehiculo", idTipoVehiculo) :
            new ObjectParameter("idTipoVehiculo", typeof(int));


        var tipoVehiculoParameter = tipoVehiculo != null ?
            new ObjectParameter("tipoVehiculo", tipoVehiculo) :
            new ObjectParameter("tipoVehiculo", typeof(string));


        var codigoParameter = codigo != null ?
            new ObjectParameter("codigo", codigo) :
            new ObjectParameter("codigo", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ModificaTipoVehiculo", idTipoVehiculoParameter, tipoVehiculoParameter, codigoParameter);
    }


    public virtual int sp_ModificaVehiculo(Nullable<int> idVehiculo, string placa, Nullable<int> idMarca, Nullable<int> idTipo, Nullable<int> puertas, Nullable<int> ruedas)
    {

        var idVehiculoParameter = idVehiculo.HasValue ?
            new ObjectParameter("idVehiculo", idVehiculo) :
            new ObjectParameter("idVehiculo", typeof(int));


        var placaParameter = placa != null ?
            new ObjectParameter("placa", placa) :
            new ObjectParameter("placa", typeof(string));


        var idMarcaParameter = idMarca.HasValue ?
            new ObjectParameter("idMarca", idMarca) :
            new ObjectParameter("idMarca", typeof(int));


        var idTipoParameter = idTipo.HasValue ?
            new ObjectParameter("idTipo", idTipo) :
            new ObjectParameter("idTipo", typeof(int));


        var puertasParameter = puertas.HasValue ?
            new ObjectParameter("puertas", puertas) :
            new ObjectParameter("puertas", typeof(int));


        var ruedasParameter = ruedas.HasValue ?
            new ObjectParameter("ruedas", ruedas) :
            new ObjectParameter("ruedas", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ModificaVehiculo", idVehiculoParameter, placaParameter, idMarcaParameter, idTipoParameter, puertasParameter, ruedasParameter);
    }


    public virtual ObjectResult<sp_MuestraVehiculo_Result> sp_MuestraVehiculo(string marca)
    {

        var marcaParameter = marca != null ?
            new ObjectParameter("marca", marca) :
            new ObjectParameter("marca", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_MuestraVehiculo_Result>("sp_MuestraVehiculo", marcaParameter);
    }


    public virtual int sp_RegistraFacturas(Nullable<int> vehiculo, Nullable<int> persona)
    {

        var vehiculoParameter = vehiculo.HasValue ?
            new ObjectParameter("Vehiculo", vehiculo) :
            new ObjectParameter("Vehiculo", typeof(int));


        var personaParameter = persona.HasValue ?
            new ObjectParameter("Persona", persona) :
            new ObjectParameter("Persona", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_RegistraFacturas", vehiculoParameter, personaParameter);
    }


    public virtual ObjectResult<sp_ReporteServicioscliente_Result> sp_ReporteServicioscliente()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ReporteServicioscliente_Result>("sp_ReporteServicioscliente");
    }


    public virtual ObjectResult<sp_ReporteServiciosvehiculo_Result> sp_ReporteServiciosvehiculo()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ReporteServiciosvehiculo_Result>("sp_ReporteServiciosvehiculo");
    }


    public virtual ObjectResult<sp_ReporteVehiculoscliente_Result> sp_ReporteVehiculoscliente()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ReporteVehiculoscliente_Result>("sp_ReporteVehiculoscliente");
    }


    public virtual ObjectResult<sp_RetornaClientes_Result> sp_RetornaClientes()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaClientes_Result>("sp_RetornaClientes");
    }


    public virtual ObjectResult<sp_RetornaClientesID_Result> sp_RetornaClientesID(Nullable<int> id_Cliente_P)
    {

        var id_Cliente_PParameter = id_Cliente_P.HasValue ?
            new ObjectParameter("Id_Cliente_P", id_Cliente_P) :
            new ObjectParameter("Id_Cliente_P", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaClientesID_Result>("sp_RetornaClientesID", id_Cliente_PParameter);
    }


    public virtual ObjectResult<sp_RetornaClientesPreFactura_Result> sp_RetornaClientesPreFactura()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaClientesPreFactura_Result>("sp_RetornaClientesPreFactura");
    }


    public virtual ObjectResult<sp_RetornaCuenta_Result> sp_RetornaCuenta(Nullable<int> idCliente)
    {

        var idClienteParameter = idCliente.HasValue ?
            new ObjectParameter("idCliente", idCliente) :
            new ObjectParameter("idCliente", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaCuenta_Result>("sp_RetornaCuenta", idClienteParameter);
    }


    public virtual ObjectResult<sp_RetornaDistritos_Result> sp_RetornaDistritos(string nombre, Nullable<int> id_Canton)
    {

        var nombreParameter = nombre != null ?
            new ObjectParameter("nombre", nombre) :
            new ObjectParameter("nombre", typeof(string));


        var id_CantonParameter = id_Canton.HasValue ?
            new ObjectParameter("id_Canton", id_Canton) :
            new ObjectParameter("id_Canton", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaDistritos_Result>("sp_RetornaDistritos", nombreParameter, id_CantonParameter);
    }


    public virtual ObjectResult<sp_RetornaFacturaFinal_Result> sp_RetornaFacturaFinal()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaFacturaFinal_Result>("sp_RetornaFacturaFinal");
    }


    public virtual ObjectResult<sp_RetornaFacturaID_Result> sp_RetornaFacturaID(Nullable<int> iDfACTURA)
    {

        var iDfACTURAParameter = iDfACTURA.HasValue ?
            new ObjectParameter("IDfACTURA", iDfACTURA) :
            new ObjectParameter("IDfACTURA", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaFacturaID_Result>("sp_RetornaFacturaID", iDfACTURAParameter);
    }


    public virtual ObjectResult<sp_RetornaFacturaNULL_Result> sp_RetornaFacturaNULL()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaFacturaNULL_Result>("sp_RetornaFacturaNULL");
    }


    public virtual ObjectResult<sp_RetornaFacturas_Result> sp_RetornaFacturas()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaFacturas_Result>("sp_RetornaFacturas");
    }


    public virtual ObjectResult<sp_RetornaLogueo_Result> sp_RetornaLogueo(string usuario, string contrasena)
    {

        var usuarioParameter = usuario != null ?
            new ObjectParameter("Usuario", usuario) :
            new ObjectParameter("Usuario", typeof(string));


        var contrasenaParameter = contrasena != null ?
            new ObjectParameter("contrasena", contrasena) :
            new ObjectParameter("contrasena", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaLogueo_Result>("sp_RetornaLogueo", usuarioParameter, contrasenaParameter);
    }


    public virtual ObjectResult<sp_RetornaMarcaVehiculo_Result> sp_RetornaMarcaVehiculo(string marcaVehiculo, string codigo)
    {

        var marcaVehiculoParameter = marcaVehiculo != null ?
            new ObjectParameter("marcaVehiculo", marcaVehiculo) :
            new ObjectParameter("marcaVehiculo", typeof(string));


        var codigoParameter = codigo != null ?
            new ObjectParameter("codigo", codigo) :
            new ObjectParameter("codigo", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaMarcaVehiculo_Result>("sp_RetornaMarcaVehiculo", marcaVehiculoParameter, codigoParameter);
    }


    public virtual ObjectResult<sp_RetornaMarcaVehiculo_ID_Result> sp_RetornaMarcaVehiculo_ID(Nullable<int> idMarca)
    {

        var idMarcaParameter = idMarca.HasValue ?
            new ObjectParameter("idMarca", idMarca) :
            new ObjectParameter("idMarca", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaMarcaVehiculo_ID_Result>("sp_RetornaMarcaVehiculo_ID", idMarcaParameter);
    }


    public virtual ObjectResult<sp_RetornaPaisFabricante_Result> sp_RetornaPaisFabricante(string nombre, string codigo)
    {

        var nombreParameter = nombre != null ?
            new ObjectParameter("nombre", nombre) :
            new ObjectParameter("nombre", typeof(string));


        var codigoParameter = codigo != null ?
            new ObjectParameter("codigo", codigo) :
            new ObjectParameter("codigo", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaPaisFabricante_Result>("sp_RetornaPaisFabricante", nombreParameter, codigoParameter);
    }


    public virtual ObjectResult<sp_RetornaPaisFabricante_ID_Result> sp_RetornaPaisFabricante_ID(Nullable<int> idPais)
    {

        var idPaisParameter = idPais.HasValue ?
            new ObjectParameter("idPais", idPais) :
            new ObjectParameter("idPais", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaPaisFabricante_ID_Result>("sp_RetornaPaisFabricante_ID", idPaisParameter);
    }


    public virtual ObjectResult<sp_RetornaPreFacturaID_Result> sp_RetornaPreFacturaID(Nullable<int> iDfACTURA)
    {

        var iDfACTURAParameter = iDfACTURA.HasValue ?
            new ObjectParameter("IDfACTURA", iDfACTURA) :
            new ObjectParameter("IDfACTURA", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaPreFacturaID_Result>("sp_RetornaPreFacturaID", iDfACTURAParameter);
    }


    public virtual ObjectResult<sp_RetornaServicioID_Result> sp_RetornaServicioID(Nullable<int> id_Servicio_S)
    {

        var id_Servicio_SParameter = id_Servicio_S.HasValue ?
            new ObjectParameter("Id_Servicio_S", id_Servicio_S) :
            new ObjectParameter("Id_Servicio_S", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaServicioID_Result>("sp_RetornaServicioID", id_Servicio_SParameter);
    }


    public virtual ObjectResult<sp_RetornaServicios_Result> sp_RetornaServicios()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaServicios_Result>("sp_RetornaServicios");
    }


    public virtual ObjectResult<sp_RetornaTipoPersona_Result> sp_RetornaTipoPersona()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaTipoPersona_Result>("sp_RetornaTipoPersona");
    }


    public virtual ObjectResult<sp_RetornaTipoVehiculo_Result> sp_RetornaTipoVehiculo(string tipoVehiculo, string codigo)
    {

        var tipoVehiculoParameter = tipoVehiculo != null ?
            new ObjectParameter("tipoVehiculo", tipoVehiculo) :
            new ObjectParameter("tipoVehiculo", typeof(string));


        var codigoParameter = codigo != null ?
            new ObjectParameter("codigo", codigo) :
            new ObjectParameter("codigo", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaTipoVehiculo_Result>("sp_RetornaTipoVehiculo", tipoVehiculoParameter, codigoParameter);
    }


    public virtual ObjectResult<sp_RetornaTipoVehiculo_ID_Result> sp_RetornaTipoVehiculo_ID(Nullable<int> idTipo)
    {

        var idTipoParameter = idTipo.HasValue ?
            new ObjectParameter("idTipo", idTipo) :
            new ObjectParameter("idTipo", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaTipoVehiculo_ID_Result>("sp_RetornaTipoVehiculo_ID", idTipoParameter);
    }


    public virtual ObjectResult<sp_RetornaVehiculo_Result> sp_RetornaVehiculo(string placa)
    {

        var placaParameter = placa != null ?
            new ObjectParameter("placa", placa) :
            new ObjectParameter("placa", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaVehiculo_Result>("sp_RetornaVehiculo", placaParameter);
    }


    public virtual ObjectResult<sp_RetornaVehiculo_ID_Result> sp_RetornaVehiculo_ID(Nullable<int> idVehiculo)
    {

        var idVehiculoParameter = idVehiculo.HasValue ?
            new ObjectParameter("idVehiculo", idVehiculo) :
            new ObjectParameter("idVehiculo", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaVehiculo_ID_Result>("sp_RetornaVehiculo_ID", idVehiculoParameter);
    }


    public virtual ObjectResult<sp_RetornaVehiculoUI_Result> sp_RetornaVehiculoUI()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaVehiculoUI_Result>("sp_RetornaVehiculoUI");
    }


    public virtual ObjectResult<sp_ReporteServiciosclienteID_Result> sp_ReporteServiciosclienteID(string correo)
    {

        var correoParameter = correo != null ?
            new ObjectParameter("correo", correo) :
            new ObjectParameter("correo", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ReporteServiciosclienteID_Result>("sp_ReporteServiciosclienteID", correoParameter);
    }


    public virtual ObjectResult<sp_ReporteServiciosvehiculoID_Result> sp_ReporteServiciosvehiculoID(string correo)
    {

        var correoParameter = correo != null ?
            new ObjectParameter("correo", correo) :
            new ObjectParameter("correo", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ReporteServiciosvehiculoID_Result>("sp_ReporteServiciosvehiculoID", correoParameter);
    }


    public virtual ObjectResult<sp_ReporteVehiculosclienteID_Result> sp_ReporteVehiculosclienteID(string correo)
    {

        var correoParameter = correo != null ?
            new ObjectParameter("correo", correo) :
            new ObjectParameter("correo", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ReporteVehiculosclienteID_Result>("sp_ReporteVehiculosclienteID", correoParameter);
    }


    public virtual ObjectResult<sp_RetornaVistaClientes_Result> sp_RetornaVistaClientes(string correo)
    {

        var correoParameter = correo != null ?
            new ObjectParameter("correo", correo) :
            new ObjectParameter("correo", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaVistaClientes_Result>("sp_RetornaVistaClientes", correoParameter);
    }

}

}

