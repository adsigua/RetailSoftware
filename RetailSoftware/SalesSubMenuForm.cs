using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailPrototypeLibrary;

namespace RetailSoftware
{
    public partial class SalesSubMenuForm : Form
    {

        private SubMenu subMenu;

        public SalesSubMenuForm()
        {
            InitializeComponent();
        }

        public SalesSubMenuForm(MainForm mainForm)
        {
            subMenu = new SubMenu(tblpSubFormSales, mainForm);
            InitializeComponent();
        }
        
        private void subMenu_Clicked(object sender, EventArgs e)
        {
            subMenu.CheckSubMenu((CheckBox)sender);
        }

        private void SalesSubMenuForm_Resize(object sender, EventArgs e)
        {
            subMenu.ResizeSubMenu();
        }
    }
}
