using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;
using VirtualModeTreeListView.Model;
namespace rtv
{
    static class Program
    {
        /// <summary>
        /// entry point
        /// </summary>
        [STAThread]
        static void Main()
        {
            IModel mModel = new Model.Model();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(mModel));
        }
    }
}
