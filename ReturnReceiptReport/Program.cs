using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReturnReceiptReport
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GUI());

            // Run report from last month
            new ReceiptReportRunner().RunReportGivenDate(DateTime.Now.AddMonths(-1), DateTime.Now);
        }
    }
}
