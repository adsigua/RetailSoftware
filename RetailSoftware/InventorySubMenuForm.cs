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
    public partial class InventorySubMenuForm : SubMenuForm
    {
        public InventorySubMenuForm()
        {
            InitializeComponent();
        }

        public InventorySubMenuForm(MainForm mf)
        {
            InitializeComponent();

            mainForm = mf;
            subMenuButtons = ControlHandler.GetChildControls(tblpSubFormInventory, typeof(CheckBox))
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
            CheckSubMenu((CheckBox)sender);
        }

    }
}
