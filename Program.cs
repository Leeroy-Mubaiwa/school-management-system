using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PindahFrame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          //  try
            {
                Application.Run(new AboutBoxPindah ());
            
          ////  catch (Exception ex){


             //   MessageBox.Show(ex.Message);
                /*Messa
                    
                geBox.Show("There was an error. Your software has crushed. But Your data is still there. So please call Customer Service at\n\n +263774454447 for quick replies \n\nor email : markmubaiwa@gmail.com", "" +
            "The Software has crushed", MessageBoxButtons.OK, MessageBoxIcon.Error);*/ }
        }
    }
}
