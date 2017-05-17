using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_system_of_the_hotel
{
    [Serializable]

    class Services
    {
        private string serviceName;

        public string ServiceName
        {
            get { return serviceName; }
            set { serviceName = value; }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public Services(string _serviceName, int _price)
        {
            serviceName = _serviceName;
            price = _price;
        }

        public string Show()
        {
            string st = "Наименование услуги:" + serviceName + "\n Цена за оказание услуги:" + price.ToString();
            return st;
        }
    }
}
