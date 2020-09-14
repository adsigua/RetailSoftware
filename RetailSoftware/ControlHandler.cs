using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailPrototypeLibrary;

namespace RetailSoftware
{
    public static class ControlHandler
    {
        /// <summary>
        /// Gets all the child controls of type 'type',
        /// returns ienumerable
        /// </summary>
        /// <param name="control"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IEnumerable<Control> GetChildControls(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetChildControls(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        public static Form GetFormByControl(Control ctr, MainForm mainForm)
        {
            switch (ctr.Name)
            {
                case "btnDBSales":
                    return new SalesSubMenuForm(mainForm);
                case "btnDBInventory":
                    return new InventorySubMenuForm(mainForm);
                case "btnDBPurchase":
                    return new PurhcaseSubMenuForm(mainForm);
                case "btnDBAccounts":
                    return new AccountsSubMenuForm(mainForm);
                case "btnDBReports":
                    return new ReportsSubMenuForm(mainForm);
                case "btnDBExit":
                    return new ExitSubMenuForm(mainForm);
                case "btnSubPOS":
                    return new PointOfSalesForm();
                default:
                    return new SalesSubMenuForm(mainForm);
            }
        }

        public static int GetSubMenuHeight(int dashBoardIndex, int currentWidth)
        {
            int numberSubItems = 3;
            if (dashBoardIndex == 1)
            {
                numberSubItems = 4;
            }else if (dashBoardIndex == 7)
            {
                numberSubItems = 0;
            }

            return numberSubItems * (int)SizeControl.GetSizeByWidth(27, 45, currentWidth);
        }
    }
}
