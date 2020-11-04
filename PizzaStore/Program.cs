using System;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //ICustomer c1 = new Customer(123,"Poul","Vej 123", "1234 1234");

                //ICustomerCatalog catalog = new CustomerCatalog();
                //catalog.AddCustomer(c1);
                //catalog.PrintCustomerList();

                #region Created items

                IMenuItem p1 = new Pizza(1, "Margherita", "Tomato and cheese", 69, MenuType.Pizza, false, true, false);
                IMenuItem p2 = new Pizza(2, "Vesuvio", "Tomato, cheese and ham", 75, MenuType.Pizza, false, true, true);

                IMenuItem b1 = new Beverage(3, "Soda", "Choose between; cola, fanta, sprite", 25, MenuType.SoftDrink,
                    false, false, false);
                IMenuItem b2 = new Beverage(4, "Beer", "Choose between; weiss, classic, dark", 35,
                    MenuType.AlcoholicDrink, false, true, true);

                IMenuItem a1 = new Pasta(5, "Cabonara", "Cheese and bacon", 80, MenuType.Pasta, false, true, true);
                IMenuItem a2 = new Pasta(6, "Bolognese", "Beef", 79, MenuType.Pasta, false, true, false);

                IMenuItem t1 = new Topping(7, "Peperoni", "", 5, MenuType.Topping, false, false, false);
                IMenuItem t2 = new Topping(8, "Extra cheese", "", 4, MenuType.Topping, false, true, true);

                IMenuItem e1 = new Pizza(1, "Exception test", "This item is made solely to test exception", 1, MenuType.Pizza, false, true, false);


                #endregion

                IMenuCatalog menuCatalog = new MenuCatalog();

                menuCatalog.Add(p1);
                menuCatalog.Add(p2);
                menuCatalog.Add(b1);
                menuCatalog.Add(b2);
                menuCatalog.Add(a1);
                menuCatalog.Add(a2);
                menuCatalog.Add(t1);
                menuCatalog.Add(t2);

                string nNP = $"Most expensive: {menuCatalog.MostExpensiveMenuItem().Number} {menuCatalog.MostExpensiveMenuItem().Name} {menuCatalog.MostExpensiveMenuItem().Price} kr.";


                Console.WriteLine(nNP);


                menuCatalog.PrintAll();
                Console.WriteLine();

                menuCatalog.Search(1).PrintInfo();
                menuCatalog.Delete(2);
                menuCatalog.Delete(5);
                menuCatalog.Delete(7);
                menuCatalog.Update(6, new Pasta(6, "Test Update", "I'm testing the update function.", 0, MenuType.Pasta, true, false, false));
                menuCatalog.FindAllVegan(MenuType.Pasta);
                menuCatalog.FindAllOrganic(MenuType.Pizza);


                menuCatalog.PrintPizzasMenu();
                menuCatalog.PrintBeveragesMenu();
                menuCatalog.PrintToppingsMenu();
                menuCatalog.PrintPastaMenu();

                string nNP2 = $"Most expensive: {menuCatalog.MostExpensiveMenuItem().Number} {menuCatalog.MostExpensiveMenuItem().Name} {menuCatalog.MostExpensiveMenuItem().Price} kr.";
                Console.WriteLine(nNP2);

            }
            catch (MenuItemNumberExist m)
            {
                Console.WriteLine(m.Message + "Tried adding an item where it already exists.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong." + e.Message);
            }

            Console.WriteLine("Press return to end");
            Console.ReadLine();

        }
    }
}
