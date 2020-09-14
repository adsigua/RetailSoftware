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
    public partial class PurhcaseSubMenuForm : Form
    {
        private SubMenu subMenu;
        public PurhcaseSubMenuForm()
        {
            InitializeComponent();
        }
        public PurhcaseSubMenuForm(MainForm mainForm)
        {
            InitializeComponent();
            subMenu = new SubMenu(tblpSubFormPurchase, mainForm);
        }

        private void subMenu_Clicked(object sender, EventArgs e)
        {
            subMenu.CheckSubMenu((CheckBox)sender);
        }

        private void tblpSubFormPurchase_Resize(object sender, EventArgs e)
        {
            subMenu.ResizeSubMenu();
        }
    }
}
