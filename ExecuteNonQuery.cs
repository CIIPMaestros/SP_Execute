using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SP_Execute.Services.Calls;

namespace SP_Execute
{
    public partial class ExecuteNonQuery : Form
    {
        public static DateTime ThisTime = new DateTime();
        public static DateTime CompareTime;
        public static ThisServices _manejoExecuterServices = new ThisServices();
        static int Times = 1;
        static int Errors = 0;
        public ExecuteNonQuery()
        {
            InitializeComponent();
        }

        private void ExecuteNonQuery_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            do
            {
                ThisTime = DateTime.Now;
                CompareTime = DateTime.Parse("23:00:00");
                if (ThisTime > CompareTime)
                {
                    lblData.Text = _manejoExecuterServices.ExecuterSP();
                    Times++;
                    txtExec.Text = Times.ToString();

                    if (!String.IsNullOrEmpty(_manejoExecuterServices.GetErrorProcess()))
                    {
                        Errors++;
                        lblErrors.Text = Errors.ToString();
                    }
                }
            } while (Times > 0);
        }
    }
}
