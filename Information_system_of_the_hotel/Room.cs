using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_system_of_the_hotel
{
    [Serializable]
    
    class Room
    {
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private int pricePerDay;

        public int PricePerDay
        {
            get { return pricePerDay; }
            set { pricePerDay = value; }
        }

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public Room(string _type, int _pricePerDay, string _status)
        {
            type = _type;
            pricePerDay = _pricePerDay;
            status = _status;
        }

        public string Show()
        {
            string st = "Тип комнаты:" + type + "\n Цена за сутки:" + pricePerDay.ToString() + "\n Статус комнаты:" + status;
            return st;
        }

    }
}
