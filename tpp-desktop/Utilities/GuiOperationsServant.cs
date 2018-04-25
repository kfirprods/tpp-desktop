using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Ice;

namespace tpp_desktop.Utilities
{
    public class GuiOperationsServant : Api.GuiOperationsDisp_
    {
        public override void ShowMessageBox(string text, Current current = null)
        {
            MessageBox.Show(text);
        }
    }
}
