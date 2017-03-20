using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_system_of_the_hotel
{
    class Room
    {
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private int priceperday;

        public int Priceperday
        {
            get { return priceperday; }
            set { priceperday = value; }
        }

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public Room(string _type, int _priceperday, string _status)
        {
            type = _type;
            priceperday = _priceperday;
            status = _status;
        }

        public string Show()
        {
            string st = "Тип комнаты:" + type + "\n Цена за сутки:" + priceperday.ToString() + "\n Статус комнаты:" + status;
            return st;
        }

    }
}
