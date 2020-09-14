using RetailSoftware.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailSoftware
{
    public static class IconHolder
    {
        /// <summary>
        /// Resizes the icons based on button name and size
        /// </summary>
        /// <param name="ctrName"></param>
        /// <param name="newSize"></param>
        /// <returns></returns>
        public static Image GetIcon(string ctrName, Size newSize)
        {
            Bitmap iconImage;
            switch (ctrName)
            {
                case "btnDBSales":
                    iconImage = Resources.icon_cart;
                    break;
                case "btnDBInventory":
                    iconImage = Resources.icon_box;
                    break;
                case "btnDBPurchase":
                    iconImage = Resources.icon_truck;
                    break;
                case "btnDBAccounts":
                    iconImage = Resources.icon_users;
                    break;
                case "btnDBReports":
                    iconImage = Resources.icon_chartBar;
                    break;
                case "btnDBSettings":
                    iconImage = Resources.icon_cog;
                    break;
                case "btnDBExit":
                    iconImage = Resources.icon_signOut;
                    break;
                default:
                    iconImage = Resources.icon_exclamationTriangle;
                    break;
            }
            return (Image)(new Bitmap(iconImage, newSize));
        } 
    }
}
