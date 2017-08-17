using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Robin Singh
 * Date: August 17,2017
 * StudentID: 300930741
 * Description:
 * Version:
 */

namespace COMP123_S2017_FinalExam_StudentID2
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PickHighestCardForm());
        }
    }
}
