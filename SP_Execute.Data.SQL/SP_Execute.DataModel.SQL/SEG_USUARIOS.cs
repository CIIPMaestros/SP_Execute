//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class SEG_USUARIOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SEG_USUARIOS()
        {
            this.MKT_DOCENTE_CURSO = new HashSet<MKT_DOCENTE_CURSO>();
            this.SEG_CURSOS_USUARIOS_LINKS = new HashSet<SEG_CURSOS_USUARIOS_LINKS>();
            this.SEG_USUARIOS_LINKS = new HashSet<SEG_USUARIOS_LINKS>();
        }
    
        public int USU_ID { get; set; }
        public string USU_NOMBRES { get; set; }
        public string USU_APELLIDO { get; set; }
        public string USU_EMAIL { get; set; }
        public string USU_DIRECCION { get; set; }
        public string USU_CELULAR { get; set; }
        public int ROL_ID { get; set; }
        public string USU_ACTIVO { get; set; }
        public string USU_ID_ENCRIPTADO { get; set; }
        public string USU_CONTRASENA { get; set; }
    
        public virtual MAE_ROLES MAE_ROLES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MKT_DOCENTE_CURSO> MKT_DOCENTE_CURSO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_CURSOS_USUARIOS_LINKS> SEG_CURSOS_USUARIOS_LINKS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_USUARIOS_LINKS> SEG_USUARIOS_LINKS { get; set; }
    }
}
