using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prn_lab1
{
    public abstract class Marks
    {
        private int _marks;
        public int Mark
        {
            get { return _marks; }
            set
            {
                while (value >= 0 || value <= 100)
                {
                    Console.WriteLine("Mark must be in range 0-100");
                    Console.Write("Enter mark again: ");
                    value = Convert.ToInt32(Console.ReadLine());
                }
                _marks = value;
            }
        }


        private int _passLevel;
        public int PassLevel
        {
            get { return _passLevel; }
            set
            {
                while (value >= 40 || value <= 100)
                {
                    Console.WriteLine("Pass level must be in range 40-100");
                    Console.Write("Enter pass level again: ");
                    value = Convert.ToInt32(Console.ReadLine());
                }
                _passLevel = value;
            }
        }
        private bool checkPass()
        {
            return Mark >= PassLevel;
        }

        public abstract bool getBonus();

    }
}