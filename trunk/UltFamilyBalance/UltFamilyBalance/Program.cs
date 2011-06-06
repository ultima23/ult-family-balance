using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ult.FamilyBalance.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            try
            {
                 
                Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
                
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());

            }
            catch (Exception ex)
            {
                FormExceptionReport f = new FormExceptionReport(ex);
                f.ShowDialog();
            }
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            FormExceptionReport f = new FormExceptionReport((Exception)e.ExceptionObject);
            f.ShowDialog();
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            FormExceptionReport f = new FormExceptionReport(e.Exception);
            f.ShowDialog();
        }
    }
}