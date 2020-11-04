using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class Topping : MenuItem
    {
        private bool _isVegetarian;
        public Topping(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool isVegetarian) : base(number, name, description, price, type, isVegan, isOrganic)
        {
            _isVegetarian = isVegetarian;
        }
        public bool IsVegetarian
        {
            get { return _isVegetarian; }
            set { _isVegetarian = value; }
        }

        public override string PrintInfo()
        {
            return $"{Type} \t{Number} {Name} \nPrice: {Price} kr. \nIs vegan {IsVegan} Is organic {IsOrganic} Is vegetarian {_isVegetarian}";
        }
        public override string ToString()
        {
            return $"{Type} {Number} {Name} Price {Price} kr. Is vegan {IsVegan} Is organic {IsOrganic} Is vegetarian {_isVegetarian}";
        }
    }
}
