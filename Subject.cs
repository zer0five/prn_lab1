using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prn_lab1
{
    public abstract class Subject
    {
        private string _SubjectCode;
        public string SubjectCode
        {
            get { return _SubjectCode; }
            set
            {
                if (_SubjectCode.Length == 6)
                {
                    _SubjectCode = value;
                }
                else
                {
                    // TODO: sai thi nhap lai
                }
            }
        }
        private string _SubjectName;
        public string SubjectName
        {
            get { return _SubjectName; }
            set
            {
                if (_SubjectName.Length <= 50)
                {
                    _SubjectName = value;
                }
                else
                {
                    // TODO nhieu hon 50 kitu nhap lai
                }
            }
        }
        private int _Theory;
        public int Theory
        {
            get { return _Theory; }
            set
            {
                if (_Theory <= 100 && _Theory >= 0)
                {
                    _Theory = value;
                }else{
                    //TODO theory phai trong khoang 0-100
                }
            }
        }

        private int _Pratice;
        public int Pratice
        {
            get { return _Pratice; }
            set { if (_Pratice <= 100 && _Pratice >= 0)
                {
                    _Pratice = value;
                }else{
                    //TODO pratice phai trong khoang 0-100
                } }
        }



        public int getTotalLessons()
        {
            return Theory + Pratice;
        }
        public override string ToString()
        {
            return
        $"{SubjectCode} {SubjectName} {Theory} {Pratice}";
        }
        public void inputSubject() {
           System.Console.WriteLine("Enter subject code");
           SubjectCode = System.Console.ReadLine();
           System.Console.WriteLine("Enter subject name");
           SubjectName = System.Console.ReadLine();
           System.Console.WriteLine("Enter theory");
           Theory = Convert.ToInt32(Console.ReadLine());
           System.Console.WriteLine("Enter pratice");
           Pratice = Convert.ToInt32(Console.ReadLine());

         }
        public void printInfo(){
            System.Console.WriteLine(this);
        }



    }

}