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
    
    public partial class PRV_DOCENTE_SEGUIMIENTO
    {
        public int SGM_ID { get; set; }
        public int DOC_ID { get; set; }
        public Nullable<System.DateTime> SGM_FECHA_HORA { get; set; }
        public string SGM_TIP { get; set; }
        public string SGM_COMENTARIO { get; set; }
    
        public virtual MKT_DOCENTES MKT_DOCENTES { get; set; }
    }
}
