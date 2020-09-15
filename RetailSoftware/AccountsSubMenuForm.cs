using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailSoftware
{
    public partial class AccountsSubMenuForm : SubMenuForm
    {
        public AccountsSubMenuForm()
        {
            InitializeComponent();
        }
        public AccountsSubMenuForm(MainForm mf)
        {
            InitializeComponent();

            mainForm = mf;
            subMenuButtons = ControlHandler.GetChildControls(tblpSubFormAccounts, typeof(CheckBox))
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
