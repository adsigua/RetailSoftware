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
    public partial class AccountsSubMenuForm : Form
    {
        private SubMenu subMenu;
        public AccountsSubMenuForm()
        {
            InitializeComponent();
        }
        public AccountsSubMenuForm(MainForm mainForm)
        {
            InitializeComponent();
            subMenu = new SubMenu(tblpSubFormAccounts, mainForm);
        }

        private void subMenu_Clicked(object sender, EventArgs e)
        {
            subMenu.CheckSubMenu((CheckBox)sender);
        }

        private void SubMenuForm_Resize(object sender, EventArgs e)
        {
            subMenu.ResizeSubMenu();
        }
    }
}
