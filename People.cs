using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prn_lab1
{
    public abstract class People
    {
        private int _idCard;
        public int IDCard
        {
            get { return _idCard; }
            set { _idCard = value; }
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




        override public string ToString() { return "People"; }
        public int getAge() { return 0; }
        public void inputPeople() { }
        public abstract void printInfo();
    }
}