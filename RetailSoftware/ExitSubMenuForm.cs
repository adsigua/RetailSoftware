using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RetailSoftware
{
    public partial class ExitSubMenuForm : SubMenuForm
    {
        public ExitSubMenuForm()
        {
            InitializeComponent();
        }
        public ExitSubMenuForm(MainForm mf)
        {
            InitializeComponent();

            mainForm = mf;
            subMenuButtons = ControlHandler.GetChildControls(tblpSubFormExit, typeof(CheckBox))
                .Select(x => (CheckBox)x).ToList();
        }
        private void SubMenu_Resize(object sender, EventArgs e)
        {
            if (subMenuButtons != null)
            {
                ResizeSubMenu();
            }
        }

        private void SubMenu_Clicked(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Name == "btnExitProgram")
            {
                mainForm.closeProgram();
            }
            else
            {
                CheckSubMenu((CheckBox)sender);
            }
        }
    }
}
