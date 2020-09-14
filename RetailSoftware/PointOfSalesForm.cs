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
    public partial class PointOfSalesForm : Form
    {
        public PointOfSalesForm()
        {
            InitializeComponent();
            lbDate.Text = DateTime.Now.Date.ToString("yyyy, MMMM dd");
        }

        private void tbProductSearch_Click(object sender, EventArgs e)
        {
            tbProductSearch.Text = "";
        }
        private void tbProductSearch_Leave(object sender, EventArgs e)
        {
            tbProductSearch.Text = "Search";
        }

        private void PointOfSalesForm_Resize(object sender, EventArgs e)
        {
            ScaleControls();
        }


        void ScaleControls()
        {

            //Console.WriteLine(lbDate.Size);
            float newLabelFontSize = (this.ClientSize.Width*5/554)-0.5848f;
            float newTextBoxHeight = (this.ClientSize.Width * 2/277) + 3.332f;
            float newTextBoxFontSize = (this.ClientSize.Width * 2 / 277) + 3.332f;
            Font newLabelFont = new Font("Segoe UI", newLabelFontSize);
            Font newTBFont = new Font("Segoe UI", newTextBoxFontSize);

            lbDate.Font = newLabelFont;

            lbInvoiceNumber.Font = newLabelFont;
            tbInvoiceNumber.Font = newTBFont;
            tbInvoiceNumber.Height = (int)newTextBoxHeight;

            lbCustomerName.Font = newLabelFont;
            tbCustomerName.Font = newTBFont;
            tbCustomerName.Height = (int)newTextBoxHeight;


            Console.WriteLine(newTextBoxHeight);
        }

        private void lbCustomerName_Click(object sender, EventArgs e)
        {

        }
    }
}
