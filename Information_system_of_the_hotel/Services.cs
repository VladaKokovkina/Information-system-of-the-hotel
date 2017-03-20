using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_system_of_the_hotel
{
    class Services
    {
        private string servicename;

        public string Servicename
        {
            get { return servicename; }
            set { servicename = value; }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public Services(string _servicename, int _price)
        {
            servicename = _servicename;
            price = _price;
        }

        public string Show()
        {
            string st = "Наименование услуги:" + servicename + "\n Цена за оказание услуги:" + price.ToString();
            return st;
        }
    }
}
