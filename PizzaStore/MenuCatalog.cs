using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace PizzaStore
{
    public class MenuCatalog : IMenuCatalog
    {

        private Dictionary<int, IMenuItem> _menu;


        public MenuCatalog()
        {
            _menu = new Dictionary<int, IMenuItem>();
        }

        public int Count
        {
            get { return _menu.Count; }
        }

        public void Add(IMenuItem aMenuItems)
        {
            if (_menu.ContainsKey(aMenuItems.Number))
                throw new MenuItemNumberExist("This number already exists.");
            if (!_menu.ContainsKey(aMenuItems.Number))
                _menu.Add(aMenuItems.Number, aMenuItems);
        }

        public IMenuItem Search(int number)
        {
            foreach (KeyValuePair<int, IMenuItem> p in _menu)
            {
                if (p.Key == number)
                {
                    return p.Value;
                }
            }

            return null;
        }

        public void Delete(int number)
        {
            if (!_menu.ContainsKey(number))
            {
                throw new MenuItemNumberDoesntExist("The number you wish to delete doesn't exist.");
            }
            if (_menu.ContainsKey(number))
            {
                _menu.Remove(number);
            }
        }

        public void PrintPizzasMenu()
        {
            foreach (KeyValuePair<int, IMenuItem> p in _menu)
            {
                if (p.Value is Pizza)
                    Console.WriteLine("Pizza in menu: " + p.Value);
            }

            Console.WriteLine();
        }

        public void PrintBeveragesMenu()
        {
            foreach (KeyValuePair<int, IMenuItem> b in _menu)
            {
                if (b.Value is Beverage)
                    Console.WriteLine("Drinks in menu: " + b.Value);
            }

            Console.WriteLine();
        }

        public void PrintToppingsMenu()
        {
            foreach (KeyValuePair<int, IMenuItem> t in _menu)
            {
                if (t.Value is Topping)
                    Console.WriteLine("Toppings in menu: " + t.Value);
            }

            Console.WriteLine();
        }

        public void PrintPastaMenu()
        {
            foreach (KeyValuePair<int, IMenuItem> a in _menu)
            {
                if (a.Value is Pasta)
                    Console.WriteLine("Pasta in menu: " + a.Value);
            }

            Console.WriteLine();
        }

        public void PrintAll()
        {
            foreach (KeyValuePair<int, IMenuItem> a in _menu)
            {
                Console.WriteLine(a.Value.PrintInfo());
            }

            Console.WriteLine();
        }

        public void Update(int number, IMenuItem theMenuItem)
        {
            if (_menu.ContainsKey(number))
            {
                _menu[number] = theMenuItem;
            }
        }

        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            List<IMenuItem> returnList = new List<IMenuItem>();

            foreach (KeyValuePair<int, IMenuItem> v in _menu)
            {
                if (v.Value.IsVegan)
                    returnList.Add(v.Value);
            }

            return returnList;
        }

        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            List<IMenuItem> returnList = new List<IMenuItem>();

            foreach (KeyValuePair<int, IMenuItem> o in _menu)
            {
                if (o.Value.IsOrganic)
                    returnList.Add(o.Value);
            }

            return returnList;
        }

        public IMenuItem MostExpensiveMenuItem1()
        {
            IMenuItem mE = _menu[1];
            for (int i = 1; i < _menu.Count; ++i)
            {
                if (_menu.ContainsKey(i))
                {
                    IMenuItem nE = _menu[i];
                    if (nE.Price > mE.Price)
                        mE = nE;
                }

            }

            return mE;
        }
        public IMenuItem MostExpensiveMenuItem()
        {
            IMenuItem mE = _menu[1];
            foreach (KeyValuePair<int, IMenuItem> m in _menu)
            {
                //IMenuItem nE = _menu[m];
                if (m.Value.Price > mE.Price)
                    mE = m.Value;
            }

            return mE;
        }
    }


}



