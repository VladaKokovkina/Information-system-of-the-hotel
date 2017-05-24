using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_system_of_the_hotel
{
    class User
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public User(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public string getName()
        {
            return name;
        }

        public int getId()
        {
            return id;
        }
    }
}
