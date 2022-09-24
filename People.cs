using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
//todo : change to abstract class
namespace prn_lab1
{

    public class People
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
            set { _birthday = value; }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                Regex re = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                     @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                string s = value;
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

        override public string ToString() { return ""; }
        public int getAge() { return 0; }
        public void inputPeople()
        {
            System.Console.Write("Enter IDCard: ");
            IDCard = Console.ReadLine();
            System.Console.Write("Enter full name: ");
            FullName = Console.ReadLine();
            //todo input birthday
            System.Console.Write("Enter email address: ");
            Email = Console.ReadLine();

        }
        // public abstract void printInfo();
    }
}