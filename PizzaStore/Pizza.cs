using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class Pizza :MenuItem
    {
        private bool _deepPan;
        public Pizza(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool deepPan) : base(number, name, description, price, type, isVegan, isOrganic)
        {
            _deepPan = deepPan;
        }
        public bool DeepPan
        {
            get { return _deepPan; }
            set { _deepPan = value; }
        }

        public override string PrintInfo()
        {
            return $"{Type} \t{Number} {Name} \nDescription: {Description} Price: {Price} kr. \nIs vegan {IsVegan} Is organic {IsOrganic} Is deep pan {_deepPan}";
        }
        public override string ToString()
        {
            return $"{Type} {Number} {Name} Description {Description} Price {Price} kr. Is vegan {IsVegan} Is organic {IsOrganic} Is deep pan {_deepPan}";
        }
    }
}
