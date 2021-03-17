using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SP_Execute.Data.Services.SP_Execute.Repository;

namespace SP_Execute.Services.Calls
{
    public class ThisServices
    {
        ExecuteSP _manejoExecuterRepository = new ExecuteSP();

        public string ExecuterSP()
        {
            string message = _manejoExecuterRepository.Executer();
            return message;
        }

        public string GetErrorProcess()
        {
            string message = _manejoExecuterRepository.GetError();
            return message;
        }
    }
}
