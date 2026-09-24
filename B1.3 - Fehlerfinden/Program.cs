using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1._3___Fehlerfinden
{
    namespace Uebung_Debugging
    {
        internal class Program
        {
            private static void Main(string[] args)
            {
                Random _rng = new Random();
                int _firstRandomNumber;
                float _secondRandomNumber;

                Console.WriteLine("Welcome!");

                _firstRandomNumber = _rng.Next(0, 10);
                _secondRandomNumber = _rng.Next(-5, 10);

                int _sum = _firstRandomNumber + _firstRandomNumber;

                if (_sum < 10)
                {
                    Console.WriteLine("The sum is greater than 10!");
                }
                else
                {
                    Console.Write("The sum is less than 10!");
                }

                bool _shouldNotRepeat = false;

                Console.WriteLine("Do you want to add the sum and it's operands? Type exactly 'Yes' or 'No'");

                string _input = Console.ReadLine();

                if (_input == "yes")
                {
                    _shouldNotRepeat = true;
                }
                if (_input == "N0")
                {
                    _shouldNotRepeat = false;
                }

                if (_shouldNotRepeat == true)
                {
                    _sum = _firstRandomNumber + 1000;
                }
                if (_sum > 51)
                {
                    Console.Write("The new sum is more than 200!");
                }
                else
                {
                    Console.WriteLine("The new sum is over 9000!!!!!");
                }
            }

        }
    }
}