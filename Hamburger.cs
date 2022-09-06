using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace OrderIn
{
    [Serializable]
    class Hamburger: Main_course
    {

        protected String _cookingLevel;
        protected String _typeOfHamburger;
        public Hamburger( string if_veg, string size, string cookingLevel, string typeOfHamburger)
        {

            _size = size;
            _cookingLevel = cookingLevel;
            _typeOfHamburger = typeOfHamburger;
            _Type = if_veg;
            _foodName = "Hamburger";
            //regular hamburger
            if (if_veg== "no" && _size == "200 gr" && _typeOfHamburger=="Beef")
            {
                _price = 60;
            }

            if (if_veg == "no" && _size == "300 gr" && _typeOfHamburger == "Beef")
            {
                _price = 70;
            }
            if (if_veg == "no" && _size == "400 gr" && _typeOfHamburger == "Beef")
            {
                _price = 80;
            }

            if (if_veg == "no" && _size == "200 gr" && _typeOfHamburger == "Lamb")
            {
                _price = 65;
            }
            if (if_veg == "no" && _size == "300 gr" && _typeOfHamburger == "Lamb")
            {
                _price = 75;
            }
            if (if_veg == "no" && _size == "400 gr" && _typeOfHamburger == "Lamb")
            {
                _price = 85;
            }

            //vegan hamburger

            if (if_veg == "yes" && _size == "200 gr" && _typeOfHamburger == "Mushroom")
            {
                _price = 40;
            }
            if (if_veg == "yes" && _size == "300 gr" && _typeOfHamburger == "Mushroom")
            {
                _price = 50;
            }
            if (if_veg == "yes" && _size == "400 gr" && _typeOfHamburger == "Mushroom")
            {
                _price = 60;
            }

            if (if_veg == "yes" && _size == "200 gr" && _typeOfHamburger == "Vegi-mix")
            {
                _price = 45;
            }
            if (if_veg == "yes" && _size == "300 gr" && _typeOfHamburger == "Vegi-mix")
            {
                _price = 55;
            }
            if (if_veg == "yes" && _size == "200 gr" && _typeOfHamburger == "Vegi-mix")
            {
                _price = 65;
            }
        }

        public override string print()
        {
            string print_hamburger;
            print_hamburger = _foodName + " - " + _typeOfHamburger + " " + _size + " " + _cookingLevel;
            return print_hamburger;
        }
    }
}
