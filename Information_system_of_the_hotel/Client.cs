using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_system_of_the_hotel
{
    class Client
    {
        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private string dob;

        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        private string passport;

        public string Passport
        {
            get { return passport; }
            set { passport = value; }
        }

        private string arrivalDate;

        public string ArrivalDate
        {
            get { return arrivalDate; }
            set { arrivalDate = value; }
        }

        private string depatureDate;

        public string DepatureDate
        {
            get { return depatureDate; }
            set { depatureDate = value; }
        }

        public Client(string _surname, string _name, string _gender, string _dob, string _passport, string _arrivalDate, string _depatureDate)
        {
            surname = _surname;
            name = _name;
            gender = _gender;
            dob = _dob;
            passport = _passport;
            arrivalDate = _arrivalDate;
            depatureDate = _depatureDate;
        }

        public string show()
        {
            return surname + " " + name + " " + gender + " " + dob + " " + passport + " " + arrivalDate + " " + depatureDate;
        }
    }
}
