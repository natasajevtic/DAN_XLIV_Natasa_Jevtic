using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Zadatak_1.Models
{
    class Menu
    {
        /// <summary>
        /// This methods creates a list of data from view of menu.
        /// </summary>
        /// <returns></returns>
        public List<vwMenu> GetMenu()
        {
            try
            {
                using (PizzeriaEntities context = new PizzeriaEntities())
                {
                    List<vwMenu> menu = new List<vwMenu>();
                    menu = (from x in context.vwMenus select x).ToList();
                    return menu;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }
    }
}

