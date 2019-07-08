using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanAmortization
{
    static class ProjectTwo
    {
        /// <summary>
        ///  Michael Zulfekar (N00929403)
        ///  Project Two
        ///  Due Date: 10/30/18
        ///  
        /// The purpose of this assigment is to write an application
        /// that outputs our value to a listbox.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoanCalc());
        }
    }
}
