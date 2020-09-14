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
    public partial class ExitSubMenuForm : Form
    {
        private SubMenu subMenu;
        public ExitSubMenuForm()
        {
            InitializeComponent();
        }
        public ExitSubMenuForm(MainForm mainForm)
        {
            InitializeComponent();
            subMenu = new SubMenu(tblpSubFormExit, mainForm);
        }
        private void subMenu_Clicked(object sender, EventArgs e)
        {
            if( ((CheckBox)sender).Name== "btnExitProgram")
            {
                subMenu.mainForm.closeProgram();
            }
            subMenu.CheckSubMenu((CheckBox)sender);
        }

        private void SubMenuForm_Resize(object sender, EventArgs e)
        {
            subMenu.ResizeSubMenu();
        }
    }
}
