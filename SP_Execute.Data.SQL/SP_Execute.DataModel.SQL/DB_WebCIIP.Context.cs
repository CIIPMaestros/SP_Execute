﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SP_Execute.Data.SQL.SP_Execute.DataModel.SQL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DB_WebCIIPEntities : DbContext
    {
        public DB_WebCIIPEntities()
            : base("name=DB_WebCIIPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MAE_CATEGORIAS> MAE_CATEGORIAS { get; set; }
        public virtual DbSet<MAE_CURSOS> MAE_CURSOS { get; set; }
        public virtual DbSet<MAE_CURSOS_HORARIOS> MAE_CURSOS_HORARIOS { get; set; }
        public virtual DbSet<MAE_CURSOS_LANZAMIENTOS> MAE_CURSOS_LANZAMIENTOS { get; set; }
        public virtual DbSet<MAE_CURSOS_PUNTUACION> MAE_CURSOS_PUNTUACION { get; set; }
        public virtual DbSet<MAE_DEPARTAMENTOS> MAE_DEPARTAMENTOS { get; set; }
        public virtual DbSet<MAE_ROLES> MAE_ROLES { get; set; }
        public virtual DbSet<MAE_TABLAS> MAE_TABLAS { get; set; }
        public virtual DbSet<MAE_TUTOR> MAE_TUTOR { get; set; }
        public virtual DbSet<MKT_DOCENTE_CURSO> MKT_DOCENTE_CURSO { get; set; }
        public virtual DbSet<MKT_DOCENTES> MKT_DOCENTES { get; set; }
        public virtual DbSet<PRV_DOCENTE_SEGUIMIENTO> PRV_DOCENTE_SEGUIMIENTO { get; set; }
        public virtual DbSet<SEG_CURSOS_USUARIOS_LINKS> SEG_CURSOS_USUARIOS_LINKS { get; set; }
        public virtual DbSet<SEG_USUARIOS> SEG_USUARIOS { get; set; }
        public virtual DbSet<SEG_USUARIOS_LINKS> SEG_USUARIOS_LINKS { get; set; }
        public virtual DbSet<MAE_CURSOS_HORARIOS_temp> MAE_CURSOS_HORARIOS_temp { get; set; }
        public virtual DbSet<MKT_DOCENTE_CURSO_TEMP> MKT_DOCENTE_CURSO_TEMP { get; set; }
        public virtual DbSet<SEG_CURSOS_USUARIOS_LINKS_TEMP> SEG_CURSOS_USUARIOS_LINKS_TEMP { get; set; }
        public virtual DbSet<SEG_USUARIOS_LINKS_TEMP> SEG_USUARIOS_LINKS_TEMP { get; set; }
    
        public virtual ObjectResult<Sp_Crear_Lanzamientos_By_Curso_Result> Sp_Crear_Lanzamientos_By_Curso(Nullable<int> cUR_ID)
        {
            var cUR_IDParameter = cUR_ID.HasValue ?
                new ObjectParameter("CUR_ID", cUR_ID) :
                new ObjectParameter("CUR_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Crear_Lanzamientos_By_Curso_Result>("Sp_Crear_Lanzamientos_By_Curso", cUR_IDParameter);
        }
    
        public virtual int Sp_Crear_Lanzamientos_Masivo(Nullable<int> vAR1, Nullable<int> vAR2)
        {
            var vAR1Parameter = vAR1.HasValue ?
                new ObjectParameter("VAR1", vAR1) :
                new ObjectParameter("VAR1", typeof(int));
    
            var vAR2Parameter = vAR2.HasValue ?
                new ObjectParameter("VAR2", vAR2) :
                new ObjectParameter("VAR2", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_Crear_Lanzamientos_Masivo", vAR1Parameter, vAR2Parameter);
        }
    }
}
