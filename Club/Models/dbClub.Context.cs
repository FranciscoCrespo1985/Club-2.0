﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Club.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbClub : DbContext
    {
        public dbClub()
            : base("name=dbClub")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<ACTIVIDAD> ACTIVIDAD { get; set; }
        public virtual DbSet<ACTIVIDAD_TIPO> ACTIVIDAD_TIPO { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<HORARIO> HORARIO { get; set; }
        public virtual DbSet<LOCACION> LOCACION { get; set; }
        public virtual DbSet<PROFESOR> PROFESOR { get; set; }
        public virtual DbSet<SOCIO> SOCIO { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<INSCRIPCION_SOCIO> INSCRIPCION_SOCIO { get; set; }
        public virtual DbSet<SV_ACTIVIDAD> SV_ACTIVIDAD { get; set; }
        public virtual DbSet<SV_USER_INSCRIPCION> SV_USER_INSCRIPCION { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
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
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<SP_GET_USER_INSCRIPCION_Result> SP_GET_USER_INSCRIPCION(string iD_SOCIO)
        {
            var iD_SOCIOParameter = iD_SOCIO != null ?
                new ObjectParameter("ID_SOCIO", iD_SOCIO) :
                new ObjectParameter("ID_SOCIO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GET_USER_INSCRIPCION_Result>("SP_GET_USER_INSCRIPCION", iD_SOCIOParameter);
        }
    
        public virtual int SP_INSCRIPCION(string iD_SOCIO, Nullable<int> iD_ACTIVIDAD, Nullable<System.DateTime> fECHA_INSCRIPCION)
        {
            var iD_SOCIOParameter = iD_SOCIO != null ?
                new ObjectParameter("ID_SOCIO", iD_SOCIO) :
                new ObjectParameter("ID_SOCIO", typeof(string));
    
            var iD_ACTIVIDADParameter = iD_ACTIVIDAD.HasValue ?
                new ObjectParameter("ID_ACTIVIDAD", iD_ACTIVIDAD) :
                new ObjectParameter("ID_ACTIVIDAD", typeof(int));
    
            var fECHA_INSCRIPCIONParameter = fECHA_INSCRIPCION.HasValue ?
                new ObjectParameter("FECHA_INSCRIPCION", fECHA_INSCRIPCION) :
                new ObjectParameter("FECHA_INSCRIPCION", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INSCRIPCION", iD_SOCIOParameter, iD_ACTIVIDADParameter, fECHA_INSCRIPCIONParameter);
        }
    
        public virtual int SP_INSCRIPCION_BAJA(string iD_SOCIO, Nullable<int> iD_ACTIVIDAD, Nullable<System.DateTime> fECHA_INSCRIPCION)
        {
            var iD_SOCIOParameter = iD_SOCIO != null ?
                new ObjectParameter("ID_SOCIO", iD_SOCIO) :
                new ObjectParameter("ID_SOCIO", typeof(string));
    
            var iD_ACTIVIDADParameter = iD_ACTIVIDAD.HasValue ?
                new ObjectParameter("ID_ACTIVIDAD", iD_ACTIVIDAD) :
                new ObjectParameter("ID_ACTIVIDAD", typeof(int));
    
            var fECHA_INSCRIPCIONParameter = fECHA_INSCRIPCION.HasValue ?
                new ObjectParameter("FECHA_INSCRIPCION", fECHA_INSCRIPCION) :
                new ObjectParameter("FECHA_INSCRIPCION", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INSCRIPCION_BAJA", iD_SOCIOParameter, iD_ACTIVIDADParameter, fECHA_INSCRIPCIONParameter);
        }
    }
}