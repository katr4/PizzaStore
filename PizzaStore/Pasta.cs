using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class Pasta : MenuItem
    {
        private bool _hasGluten;
        public Pasta(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool hasGluten) : base(number, name, description, price, type, isVegan, isOrganic)
        {
            _hasGluten = hasGluten;
        }
        public bool HasGluten
        {
            get { return _hasGluten; }
            set { _hasGluten = value; }
        }

        public override string PrintInfo()
        {
            return $"{Type} \t{Number} {Name} \nDescription: {Description} Price: {Price} kr. \nIs vegan {IsVegan} Is organic {IsOrganic} Has gluten {_hasGluten}";
        }
        public override string ToString()
        {
            return $"{Type} {Number} {Name} Description {Description} Price {Price} kr. Is vegan {IsVegan} Is organic {IsOrganic} Is deep pan {_hasGluten}";
        }
    }
}
