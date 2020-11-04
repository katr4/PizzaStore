using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class MenuItemNumberDoesntExist : Exception
    {
        // Hvis der fjernes et MenuItem til MenuCataloget,
        // som har et nummer, som ikke eksisterer skal
        // der kastes en exception af typen MenuItemNumberDoesntExist
        public MenuItemNumberDoesntExist()
        {
        }

        public MenuItemNumberDoesntExist(string message)
            : base(message)
        {
        }
    }
}
