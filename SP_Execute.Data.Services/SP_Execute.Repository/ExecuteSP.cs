using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SP_Execute.Data.SQL.SP_Execute.DataModel.SQL;

namespace SP_Execute.Data.Services.SP_Execute.Repository
{
    public class ExecuteSP
    {
        DB_WebCIIPEntities db = new DB_WebCIIPEntities();
        static string Error;
        
        public string Executer()
        {
            string DataMessage = "";
            try
            {
                db.Sp_Crear_Lanzamientos_Masivo(0, 0);
                DataMessage = "Ejecucion exitosa realizada a las: " + DateTime.Now.ToString();
            }catch(Exception e)
            {
                Error = "Error";
                DataMessage = "Parece que algo salio mal \n\r" + e.Message + "\r\n" + DateTime.Now.ToString();
            }

            return DataMessage;

        }

        public string GetError()
        {
            return Error;
        }
    }
}
