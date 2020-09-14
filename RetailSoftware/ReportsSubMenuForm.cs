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
    public partial class ReportsSubMenuForm : Form
    {
        private SubMenu subMenu;
        public ReportsSubMenuForm()
        {
            InitializeComponent();
        }
        public ReportsSubMenuForm(MainForm mainForm)
        {
            InitializeComponent();
            subMenu = new SubMenu(tblpSubFormReports, mainForm);
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

