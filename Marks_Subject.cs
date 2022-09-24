using System;
using System.Text.RegularExpressions;


namespace prn_lab1
{
    public class Marks_Subject : Marks, IMarks
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
        
         private string _StudentName;
        public string StudentName
        {
            get { return _StudentName; }
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

                _StudentName = s;
            }
        }

        private string _subject;
        public string Subject
        {
            get { return _subject; }
            set { 
                  
                    //* Validate Subject
                    Regex regex = new Regex(@"^[a-zA-Z\s]*$");
    
                    string s = value.Trim();
    
                    while(!regex.IsMatch(s))
                    {
                        System.Console.Write("Invalid Subject, please try again: ");
                        s = Console.ReadLine().Trim();
    
                    }
                    _subject = s; }
        }
        
        private int _testTime;
        public int TestTime
        {
            get { return _testTime; }
            set { 
                while(value < 1 || value > 4)
                {
                    System.Console.Write("Invalid TestTime, please try again (1 - 4): ");
                    value = Convert.ToInt32(Console.ReadLine());
                }
                _testTime = value; }
        }
        public Marks_Subject() { }
        public Marks_Subject(int Mark, int PassLevel){
            this.Mark = Mark;
            this.PassLevel = PassLevel;
        }
        

        public override bool getBonus()
        {
            throw new NotImplementedException();
        }

        public void inputMarks()
        {
            throw new NotImplementedException();
        }

        public void printMarks()
        {
            throw new NotImplementedException();
        }
    }
}