using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace prn_lab1
{

    public abstract class People
    {
        private string _idCard;
        public string IDCard
        {
            get { return _idCard; }
            set
            {
                Regex regex = new Regex(@"\d{9,9}");
                string s = value;

                while (!regex.IsMatch(s))
                {
                    System.Console.Write("Invalid IDCard, please try again: ");
                    s = Console.ReadLine();
                }
                _idCard = s;
            }

        }

        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
        private DateTime _birthday;
        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public People(string iDCard, string fullName, DateTime birthday, string email, string phone)
        {

            IDCard = iDCard;
            FullName = fullName;
            Birthday = birthday;
            Email = email;
            Phone = phone;
        }

        public People()
        {
        }

        override public string ToString() { return "People"; }
        public int getAge() { return 0; }
        public void inputPeople()
        {
            System.Console.WriteLine("Enter IDCard");
            IDCard = Console.ReadLine();

        }
        public abstract void printInfo();
    }
}