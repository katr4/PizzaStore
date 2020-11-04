using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public abstract class MenuItem : IMenuItem
    {
        private int _number;
        private string _name;
        private string _description;
        private double _price;
        private MenuType _type;
        private bool _isVegan;
        private bool _isOrganic;

        public MenuItem(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic)
        {
            _number = number;
            _name = name;
            _description = description;
            _price = price;
            _type = type;
            _isVegan = isVegan;
            _isOrganic = isOrganic;
        }

        public int Number
        {
            get { return _number; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public MenuType Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public bool IsVegan
        {
            get { return _isVegan; }
            set { _isVegan = value; }
        }
        public bool IsOrganic
        {
            get { return _isOrganic; }
            set { _isOrganic = value; }
        }

        public virtual string PrintInfo()
        {
            return $"{_type} \t{_number} {_name} \nDescription: {_description} Price: {_price} kr. \nIs vegan {_isVegan} Is organic {_isOrganic}";
        }
        public override string ToString()
        {
            return $"{_type} {_number} {_name} Description {_description} Price {_price} kr. Is vegan {_isVegan} Is organic {_isOrganic}";
        }
    }
}
