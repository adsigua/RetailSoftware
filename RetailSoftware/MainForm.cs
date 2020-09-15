using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailPrototypeLibrary;

namespace RetailSoftware
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Current form shown in the Body Panel
        /// </summary>
        private Form currentBodyForm;
        /// <summary>
        /// Current Submenu open/active on the dashboard
        /// </summary>
        private Form currentSubMenuForm;
        private CheckBox currentMenuSelected;

        private List<CheckBox> dashBoardButtons;
        private List<Form> subMenuForms;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitControls();
            ResizeButtons();
            ShowLogin();
        }

        /// <summary>
        /// Initializes controls variables and caches them for later use
        /// </summary>
        private void InitControls()
        {
            InitDashBoardButtons();
        }

        private void InitDashBoardButtons()
        {
            dashBoardButtons = new List<CheckBox>();
            foreach (CheckBox btn in ControlHandler.GetChildControls(tblpDBButtons, typeof(CheckBox)))
            {
                dashBoardButtons.Add(btn);
            }
        }

        void MainForm_Resize(object sender, EventArgs e)
        {
            if (dashBoardButtons != null)
            {
                ResizeButtons();
            }
        }

        /// <summary>
        /// Maintains the aspect ratio of the main form window
        /// </summary>
        void ResizeWindow()
        {
            //Size newWindowsSize =  new Size(this.ClientSize.Width, (int)newWindowHeight);
            float newWindowHeight = (this.ClientSize.Width * 1049) / 1920;
            this.ClientSize = new Size(this.ClientSize.Width, (int)newWindowHeight);
            Console.WriteLine(this.ClientSize);
        }
        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            ResizeWindow();
        }

        /// <summary>
        /// Displays login form into the body panel
        /// </summary>
        void ShowLogin()
        {
            LoginForm loginForm = new LoginForm();
            openSubForm((Form)loginForm, this.panelBody);
        }

        /// <summary>
        /// Resizes the dashboard buttons font and icons, based from the window width
        /// uses ResizeIcon function
        /// </summary>
        void ResizeButtons()
        {
            //float newFontSize = (0.0055f * this.ClientSize.Width) + 4.2857f;
            //int newIconValue = (this.ClientSize.Width / 32) - 20;

            int currentWidth = this.ClientSize.Width;
            float newFontSize = SizeControl.GetSizeByWidth(10,14, currentWidth);
            Size newIconSize = SizeControl.GetIconSizeByWidth(20,40, currentWidth);
            Font newFont = new Font("Segoe UI", newFontSize);

            foreach(CheckBox btn in dashBoardButtons)
            {
                btn.Font = newFont;
                btn.Image = IconHolder.GetIcon(btn.Name, newIconSize);
            }
            //Console.WriteLine(newIconSize);
        }

        public void SubMenuClicked(Control ctr)
        {
            Form newForm = ControlHandler.GetFormByControl(ctr,this);
            if (currentBodyForm.Name != newForm.Name)
            {
                openSubForm(newForm, panelBody);
            }
        }

        private void btnDashBoard_Clicked(object sender, EventArgs e)
        {
            UpdateDashBoard((CheckBox)sender);
        }

        /// <summary>
        /// Updates dashboard buttons and submenu forms
        /// </summary>
        /// <param name="btnSender"></param>
        private void UpdateDashBoard(CheckBox btnSender)
        {
            if (currentSubMenuForm != null)
            {
                CloseSubMenu();
            }
            if (btnSender.Checked)
            {
                if (currentMenuSelected != null)
                {
                    currentMenuSelected.Checked = false;
                }
                currentMenuSelected = btnSender;
                openSubForm(ControlHandler.GetFormByControl(btnSender,this), this.panelDashBoardSubItems);
                MovePanelSubMenu(0, dashBoardButtons.IndexOf(btnSender));
            }
            else
            {
                currentMenuSelected = null;
            }
        }

        /// <summary>
        /// opens a subForm in the selected panel, clears selected panel first
        /// </summary>
        /// <param name="subForm"></param>
        /// <param name="parentControl"></param>
        private void openSubForm(Form subForm, Control parentControl)
        {
            parentControl.Controls.Clear();
            if (parentControl == this.panelBody)
            {
                currentBodyForm = subForm;
            }
            else
            {
                currentSubMenuForm = subForm;
            }
            subForm.Dock = DockStyle.Fill;
            subForm.TopLevel = false;
            subForm.TopMost = true;
            subForm.FormBorderStyle = FormBorderStyle.None;
            parentControl.Controls.Add(subForm);
            subForm.Show();
        }

        void InitializeSubMenu(Form subForm)
        {
            currentSubMenuForm = subForm;
        }

        void MovePanelSubMenu(int x,int y)
        {
            tblpDBButtons.SetCellPosition(panelDashBoardSubItems, new TableLayoutPanelCellPosition(x, y+1));
            SetButtonPanelSize(y);
        }


        void SetButtonPanelSize(int y)
        {
            float subMenuPercent = (float)ControlHandler.GetSubMenuHeight(y, this.ClientSize.Width) / tblpDBButtons.Size.Height * 100;
            float otherPercent = (100 - subMenuPercent) / 7;
            for (int i = 0; i < tblpDBButtons.RowStyles.Count; i++)
            {
                if (i == y+1)
                {
                    tblpDBButtons.RowStyles[i].Height = (subMenuPercent > 0) ? subMenuPercent : otherPercent;
                    continue;
                }
                tblpDBButtons.RowStyles[i].Height = otherPercent;
            }
        }

        void CloseSubMenu()
        {
            panelDashBoardSubItems.Controls.Clear();
            MovePanelSubMenu(0, 6);
            currentSubMenuForm.Close();
            currentSubMenuForm = null;
        }

        public void closeProgram()
        {
            Application.Exit();
        }


    }
}
