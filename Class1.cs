using Autodesk.AutoCAD.Runtime;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_DLL_Autocad_20_03_2023_
{
    public class Class1
    {
        [CommandMethod("WF_Form")]
        public void Demo()
        {
            WPF_form er = new WPF_form();
            er.Show();
        }
    }
}
