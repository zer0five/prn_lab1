using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace prn_lab1
{
    public class Student: People
    {
        private string _rollNo;
        public string RollNo
        {
            get { return _rollNo; }
            set { 

                //* Validate RollNo
                Regex regex = new Regex(@"^A12\d{2}[1-9]$");

                string s = value.Trim();

                while(!regex.IsMatch(s))
                {
                    System.Console.Write("Invalid RollNo, please try again (A12001 - A12999): ");
                    s = Console.ReadLine().Trim();

                }
                _rollNo = s; }
        }
        
        private string _classNo;
        public string ClassNo
        {
            get { return _classNo; }
            set { 

                //* Validate ClassNo
                Regex regex = new Regex(@"^(CP|DI|DM)(?:19\d{2}|20[01][0-9]|202[01]|2022)(0[1-9]|1[012])(G|H|J|I|K|F|M)\d{2}$");

                string v = value.Trim();
                
                while(!regex.IsMatch(v))
                {
                    System.Console.Write("Invalid ClassNo, please try again: ");
                    v = Console.ReadLine();
                } 
                
                _classNo = v;
                }
        }

        // public override void printInfo()
        // {
            
        // }

        public double getAvgMark() {return 0;}

        public void inputStudent() {
            System.Console.Write("Enter RollNo: ");
            RollNo = Console.ReadLine();
            System.Console.Write("Enter ClassNo: ");
            ClassNo = Console.ReadLine();
        }
    }
}