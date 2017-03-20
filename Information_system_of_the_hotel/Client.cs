﻿using System;
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

        private string patronymic;

        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }

        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private int dob;

        public int Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        private int passport;

        public int Passport
        {
            get { return passport; }
            set { passport = value; }
        }

        private int arrivaldate;

        public int Arrivaldate
        {
            get { return arrivaldate; }
            set { arrivaldate = value; }
        }

        private int depaturedate;

        public int Depaturedate
        {
            get { return depaturedate; }
            set { depaturedate = value; }
        }

        public Client(string _surname, string _name, string _patronymic, string _gender, int _dob, int _passport, int _arrivaldate, int _depaturedate)
        {
            surname = _surname;
            name = _name;
            patronymic = _patronymic;
            gender = _gender;
            dob = _dob;
            passport = _passport;
            arrivaldate = _arrivaldate;
            depaturedate = _depaturedate;
        }

        public string Show()
        {
            string st = "Фамилия:" + surname + "\n Имя:" + name + "\n Отчество:" + patronymic + "\n Год рождения:" + dob.ToString() + "\n Пол:" + gender + "\n Паспортные данные:" + passport.ToString() + "\n Дата въезда:" + arrivaldate.ToString() + "\n Дата выезда:" + depaturedate.ToString();
            return st;
        }
    }
}