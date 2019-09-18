using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petals
{
    static class Program
    {
        /// <summary>
        /// Written by Andrew Miller
        /// Last updated 4 September 2019
        /// Petals Around The Rose
        /// CIS 151 102
        /// Professor Riley
        /// Provides a graphical interface for users to play petals arounds the rose to try to discover the secret of the rose. Users must play nice, no exceptions!
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Petals());
        }
    }
}
