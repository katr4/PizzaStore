using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaStore;

namespace UnitTestPizzaStore
{
    [TestClass]
    public class MenuCatalogTest
    {
        [TestMethod]
        public void AddPastaTest()
        {
            //Arrange - her sætter vi tingene op
            IMenuCatalog c = new MenuCatalog();

            int numberBefore = c.Count;
            IMenuItem i = new Pasta(1, "Pasta", "A type of pasta", 10, MenuType.Pasta, true, false, true);
            
            //Act - her udføres en handling
            c.Add(i);
            int numberAfter = c.Count;

            //Assert - her tjekkes om resultatet er som forventet
            Assert.AreEqual(numberBefore+1, numberAfter);
        }
        [TestMethod]
        public void AddPizzaTest()
        {
            //Arrange - her sætter vi tingene op
            IMenuCatalog c = new MenuCatalog();

            int numberBefore = c.Count;
            IMenuItem i = new Pizza(1, "Pizza", "A type of pizza", 10, MenuType.Pizza, true, false, true);

            //Act - her udføres en handling
            c.Add(i);
            int numberAfter = c.Count;

            //Assert - her tjekkes om resultatet er som forventet
            Assert.AreEqual(numberBefore + 1, numberAfter);
        }
        [TestMethod]
        public void AddBeverageTest()
        {
            //Arrange - her sætter vi tingene op
            IMenuCatalog c = new MenuCatalog();

            int numberBefore = c.Count;
            IMenuItem i = new Beverage(1, "Drink", "A type of beverage", 10, MenuType.SoftDrink, true, false, false);

            //Act - her udføres en handling
            c.Add(i);
            int numberAfter = c.Count;

            //Assert - her tjekkes om resultatet er som forventet
            Assert.AreEqual(numberBefore + 1, numberAfter);
        }
        [TestMethod]
        public void AddToppingTest()
        {
            //Arrange - her sætter vi tingene op
            IMenuCatalog c = new MenuCatalog();

            int numberBefore = c.Count;
            IMenuItem i = new Topping(1, "Topping", "A type of topping", 10, MenuType.Topping, true, false, false);

            //Act - her udføres en handling
            c.Add(i);
            int numberAfter = c.Count;

            //Assert - her tjekkes om resultatet er som forventet
            Assert.AreEqual(numberBefore + 1, numberAfter);
        }
        [TestMethod]
        [ExpectedException(typeof(MenuItemNumberExist))]
        public void AddNumberAlreadyUsed()
        {
            //Arrange - her sætter vi tingene op
            IMenuCatalog c = new MenuCatalog();

            IMenuItem i = new Pasta(1, "Pasta", "A type of pasta", 10, MenuType.Pasta, true, false, true);
            IMenuItem i2 = new Pasta(1, "CopyPasta", "A duplicate type of pasta", 10, MenuType.Pasta, true, false, true);

            //Act - her udføres en handling
            c.Add(i);
            c.Add(i2);
            
            //Assert - her tjekkes om resultatet er som forventet
        }

        [TestMethod]
        public void DeletePastaTest()
        {
            //Arrange - her sætter vi tingene op
            IMenuCatalog c = new MenuCatalog();
            IMenuItem i = new Pasta(1, "Pasta", "A type of pasta", 10, MenuType.Pasta, true, false, true);

            //Act - her udføres en handling
            c.Add(i);
            int numberBefore = c.Count;
            c.Delete(i.Number);
            int numberAfter = c.Count;

            //Assert - her tjekkes om resultatet er som forventet
            Assert.AreEqual(numberBefore - 1, numberAfter);
        }
        [TestMethod]
        public void DeletePizzaTest()
        {
            //Arrange - her sætter vi tingene op
            IMenuCatalog c = new MenuCatalog();
            IMenuItem i = new Pizza(1, "Pizza", "A type of pizza", 10, MenuType.Pizza, true, false, true);

            //Act - her udføres en handling
            c.Add(i);
            int numberBefore = c.Count;
            c.Delete(i.Number);
            int numberAfter = c.Count;

            //Assert - her tjekkes om resultatet er som forventet
            Assert.AreEqual(numberBefore - 1, numberAfter);
        }
        [TestMethod]
        public void DeleteBeverageTest()
        {
            //Arrange - her sætter vi tingene op
            IMenuCatalog c = new MenuCatalog();
            IMenuItem i = new Beverage(1, "Drink", "A type of beverage", 10, MenuType.SoftDrink, true, false, false);

            //Act - her udføres en handling
            c.Add(i);
            int numberBefore = c.Count;
            c.Delete(i.Number);
            int numberAfter = c.Count;

            //Assert - her tjekkes om resultatet er som forventet
            Assert.AreEqual(numberBefore - 1, numberAfter);
        }
        [TestMethod]
        public void DeleteToppingTest()
        {
            //Arrange - her sætter vi tingene op
            IMenuCatalog c = new MenuCatalog();
            IMenuItem i = new Topping(1, "Topping", "A type of topping", 10, MenuType.Topping, true, false, false);

            //Act - her udføres en handling
            c.Add(i);
            int numberBefore = c.Count;
            c.Delete(i.Number);
            int numberAfter = c.Count;

            //Assert - her tjekkes om resultatet er som forventet
            Assert.AreEqual(numberBefore - 1, numberAfter);
        }
        [TestMethod]
        [ExpectedException(typeof(MenuItemNumberDoesntExist))]
        public void DeleteNumberNeverUsed()
        {
            //Arrange - her sætter vi tingene op
            IMenuCatalog c = new MenuCatalog();


            //Act - her udføres en handling
            c.Delete(1);

            //Assert - her tjekkes om resultatet er som forventet
        }
    }
}
