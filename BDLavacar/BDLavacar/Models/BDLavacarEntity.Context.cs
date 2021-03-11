﻿//------------------------------------------------------------------------------
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
    
    public partial class bdlavacarEntities : DbContext
    {
        public bdlavacarEntities()
            : base("name=bdlavacarEntities")
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
    
        public virtual int sp_EliminaTipoVehiculo(Nullable<int> idTipoVehiculo)
        {
            var idTipoVehiculoParameter = idTipoVehiculo.HasValue ?
                new ObjectParameter("idTipoVehiculo", idTipoVehiculo) :
                new ObjectParameter("idTipoVehiculo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminaTipoVehiculo", idTipoVehiculoParameter);
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
    
        public virtual int sp_ModificaMarcaVehiculo(Nullable<int> idMarcaVehiculo, string marcaVehiculo, string codigo)
        {
            var idMarcaVehiculoParameter = idMarcaVehiculo.HasValue ?
                new ObjectParameter("idMarcaVehiculo", idMarcaVehiculo) :
                new ObjectParameter("idMarcaVehiculo", typeof(int));
    
            var marcaVehiculoParameter = marcaVehiculo != null ?
                new ObjectParameter("marcaVehiculo", marcaVehiculo) :
                new ObjectParameter("marcaVehiculo", typeof(string));
    
            var codigoParameter = codigo != null ?
                new ObjectParameter("codigo", codigo) :
                new ObjectParameter("codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ModificaMarcaVehiculo", idMarcaVehiculoParameter, marcaVehiculoParameter, codigoParameter);
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
    
        public virtual ObjectResult<sp_RetornaPaisFabricante_ID_Result> sp_RetornaPaisFabricante_ID(Nullable<int> idPais)
        {
            var idPaisParameter = idPais.HasValue ?
                new ObjectParameter("idPais", idPais) :
                new ObjectParameter("idPais", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaPaisFabricante_ID_Result>("sp_RetornaPaisFabricante_ID", idPaisParameter);
        }
    
        public virtual ObjectResult<sp_RetornaMarcaVehiculo_ID_Result> sp_RetornaMarcaVehiculo_ID(Nullable<int> idMarca)
        {
            var idMarcaParameter = idMarca.HasValue ?
                new ObjectParameter("idMarca", idMarca) :
                new ObjectParameter("idMarca", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaMarcaVehiculo_ID_Result>("sp_RetornaMarcaVehiculo_ID", idMarcaParameter);
        }
    
        public virtual ObjectResult<sp_RetornaTipoVehiculo_ID_Result> sp_RetornaTipoVehiculo_ID(Nullable<int> idTipo)
        {
            var idTipoParameter = idTipo.HasValue ?
                new ObjectParameter("idTipo", idTipo) :
                new ObjectParameter("idTipo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_RetornaTipoVehiculo_ID_Result>("sp_RetornaTipoVehiculo_ID", idTipoParameter);
        }
    }
}