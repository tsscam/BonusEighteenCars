using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class CarClass
    {
        private string CarMake;
        private string CarModel;
        private int CarYear;
        private double CarPrice;

        public string CarMake1
        {
            get
            {
                return CarMake;
            }

            set
            {
                CarMake = value;
            }
        }

        public string CarModel1
        {
            get
            {
                return CarModel;
            }

            set
            {
                CarModel = value;
            }
        }

        public int CarYear1
        {
            get
            {
                return CarYear;
            }

            set
            {
                CarYear = value;
            }
        }

        public double CarPrice1
        {
            get
            {
                return CarPrice;
            }

            set
            {
                CarPrice = value;
            }
        }

        //Constructor 
        public CarClass(string CarMakeInput,string CarModelInput,
        int CarYearInput, double CarPriceInput)
    {
            CarMake1 = CarMakeInput;
            CarModel1 = CarModelInput;
            CarYear1 = CarYearInput;
            CarPrice1 = CarPriceInput;
    }
      

        public CarClass()
        {
            CarMake1 = "Dodge";
            CarModel1 = "Journey";
            CarYear1 = 2017;
            CarPrice1 = 23000;

        }
     
    
    }
}
