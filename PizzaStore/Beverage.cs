using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class Beverage : MenuItem
    {
        private bool _alcohol;
        public Beverage(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool alcohol) : base(number, name, description, price, type, isVegan, isOrganic)
        {
            _alcohol = alcohol;
        }
        public bool Alcohol
        {
            get { return _alcohol; }
            set { _alcohol = value; }
        }

        public override string PrintInfo()
        {
            return $"{Type} \t{Number} {Name} \nDescription: {Description} Price: {Price} kr. \nIs vegan {IsVegan} Is organic {IsOrganic} Is alcoholic {_alcohol}";
        }
        public override string ToString()
        {
            return $"{Type} {Number} {Name} Description {Description} Price {Price} kr. Is vegan {IsVegan} Is organic {IsOrganic} Is alcoholic {_alcohol}";
        }
    }
}
