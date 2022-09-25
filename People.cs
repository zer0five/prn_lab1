using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
//todo : change to abstract class
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
                //validate idCard

                string s = value;

                while (s.Length != 9 || !s.All(char.IsDigit))
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
            set
            {
                //regex for letter
                Regex regex = new Regex(@"^[a-zA-Z\s]*$");
                //validate fullName

                string s = value.Trim();

                while (s.Length < 1 || s.Length > 50 || !regex.IsMatch(s))
                {
                    System.Console.Write("Invalid name, please try again: ");
                    s = Console.ReadLine().Trim();
                }

                _fullName = s;
            }
        }
        private DateTime _birthday;
        public DateTime Birthday
        {
            get { return _birthday; }
            set
            {

                while (true)
                {
                    if (value < new DateTime(1999, 1, 1) && value > DateTime.Today)
                    {
                        System.Console.Write("Invalid birthday, please try again: ");
                        


                    }
                }

            }
        }
        private string _address;

        public string Address
        {
            get { return _address; }
            set
            {
                //address not null
                string s = value;

                while (s.Length == 0)
                {
                    System.Console.Write("Address must not be empty: ");
                    s = Console.ReadLine().Trim();
                }
                _address = s;
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                //regex for email validate
                Regex re = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                     @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                string s = value;
                //validate email address
                while (!re.IsMatch(s) && s.Length > 0)
                {
                    System.Console.Write("Invalid email,please enter again: ");
                    s = Console.ReadLine().Trim();

                }


                _email = s;

            }
        }
        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set
            {

                string s = value;
                while (s.Length != 10 || !s.All(char.IsDigit) || !s.StartsWith("0"))
                {
                    System.Console.Write("Please enter valid phone number(e.g 0123456789): ");
                    s = Console.ReadLine().Trim();
                }
                _phone = s;
            }
        }

        public People(string iDCard, string fullName, DateTime birthday, string email, string phone, string address)
        {

            IDCard = iDCard;
            FullName = fullName;
            Birthday = birthday;
            Email = email;
            Phone = phone;
            Address = address;
        }

        public People()
        {
        }

        override public string ToString() { return ""; }
        public int getAge() { return 0; }
        public void inputPeople()
        {
            System.Console.Write("Enter IDCard: ");
            IDCard = Console.ReadLine();
            System.Console.Write("Enter full name: ");
            FullName = Console.ReadLine();
            //todo input birthday
            Birthday = DateTime.Parse(Console.ReadLine());
            System.Console.Write("Enter email address: ");
            Email = Console.ReadLine();
            //todo : adresss
            System.Console.Write("Enter address: ");
            Address = Console.ReadLine();
            System.Console.Write("Enter phone number (e.g 0123456789): ");
            Phone = Console.ReadLine();


        }
        // public abstract void printInfo();
    }
}