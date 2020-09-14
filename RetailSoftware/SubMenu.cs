using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailPrototypeLibrary;

namespace RetailSoftware
{
    public class SubMenu
    {
        public SubMenu(Control parentCtr,MainForm mf)
        {
            mainForm = mf;
            subMenuButtons = ControlHandler.GetChildControls(parentCtr, typeof(CheckBox))
                .Select(x=> (CheckBox)x).ToList();
        }

        public MainForm mainForm { get; set; }

        public CheckBox currentSelectedCheckBox { get; set; }

        public List<CheckBox> subMenuButtons { get; set; }


        /// <summary>
        /// Handles toggle switching for submenus in the dashboard
        /// </summary>
        /// <param name="subMenuBtn"></param>
        public void CheckSubMenu(CheckBox subMenuBtn)
        {
            //CheckBox temp = currentSelectedCheckBox; 
            if (subMenuBtn.Checked)
            {
                if (currentSelectedCheckBox != subMenuBtn)
                {
                    if (currentSelectedCheckBox != null)
                    {
                        currentSelectedCheckBox.Checked = false;
                    }
                    currentSelectedCheckBox = subMenuBtn;
                    mainForm.SubMenuClicked(subMenuBtn);
                }
            }
            else
            {
                subMenuBtn.Checked = true;
            }

            //controlHandle.UpdateButtonGroup((CheckBox)sender,ref currentSelectedCheckBox,_mainForm);

        }

        public void ResizeSubMenu()
        {
            foreach(CheckBox subMenuBtn in subMenuButtons)
            {
                float newFontSize = SizeControl.GetSizeByWidth(8,12,mainForm.ClientSize.Width);
                foreach(CheckBox btn in subMenuButtons)
                {
                    btn.Font = new Font("Segoe UI", newFontSize);
                }
            }
        }
    }
}
