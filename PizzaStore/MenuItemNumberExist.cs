using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class MenuItemNumberExist : Exception
    {
        // Hvis der tilføjes et MenuItem til MenuCataloget,
        // som har et nummer, som allerede eksisterer
        // skal der kastes en exception af typen MenuItemNumberExist
        public MenuItemNumberExist()
        {
        }

        public MenuItemNumberExist(string message)
            : base(message)
        {
        }

    }
}
