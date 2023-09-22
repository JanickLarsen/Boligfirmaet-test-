using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Boligfirmaet__test_.View
{
    /// <summary>
    /// Class <c>Gui</c> Displays to console window
    /// </summary>
    internal class Gui
    {
        public void DisplayTotelRenovationPrice(long price)
        {
            Console.WriteLine($"The Price for the Renovation: {price} Kr");
        }
    }
}
