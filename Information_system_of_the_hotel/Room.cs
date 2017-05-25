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
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private int place;

        public int Place
        {
            get { return place; }
            set { place = value; }
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

        public Room(int _number, string _type, int _place, int _pricePerDay, string _status)
        {
            number = _number;
            type = _type;
            place = _place;
            pricePerDay = _pricePerDay;
            status = _status;
        }

        public string Show()
        {
            string st = "Номер комнаты:"+ number + "\n Тип комнаты:" + type + "\n Сколько мест в номере:"+ place + "\n Цена за сутки:" + pricePerDay.ToString() + "\n Статус комнаты:" + status;
            return st;
        }

    }
}
