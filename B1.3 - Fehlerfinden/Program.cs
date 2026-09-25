using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1._3___Fehlerfinden
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int _firstRandomNumber;
            int _secondRandomNumber; // float falsch, da Ganzzahl benötigt wird
            Random _rng = new Random();  // is muss "=" sein

            Console.WriteLine("Hallo!"); // "Goodbye!" falsch 

            _firstRandomNumber = _rng.Next(0, 11); // 10 muss möglich sein darum auf 11 erhöhen
            _secondRandomNumber = _rng.Next(0, 11); // falscher Wertebereich (0 anstatt -5)

            int _sum = _firstRandomNumber + _secondRandomNumber; // "integer" falsch

            if (_sum > 10) // vorher < 10
            {
                Console.WriteLine("The sum is greater than 10!");    //WriteLines muss "WriteLine" sein
            }
            else
            {
                Console.WriteLine("The sum is less than or equal to 10!"); // Write muss "WriteLine" sein und sum kann kleiner oder "gleich" sein
            }

            bool _shouldNotRepeat = false;   //wrong muss "false" sein

            Console.WriteLine("Do you want to add the sum and its operands? Type exactly 'Yes' or 'No':");

            while (!_shouldNotRepeat)
            {
                string _input = Console.ReadLine();    //Readkey muss "ReadLine" sein readkey liest nur den ersten tastendruck

                if (_input == "Yes")
                {
                    _shouldNotRepeat = true;
                    _sum = _sum + _firstRandomNumber + _secondRandomNumber;
                }
                else if (_input == "No")
                {
                    return;    //make _shouldNotRepeat wäre einfach _shouldNotRepeat wird aber nicht unbedingt benötigt hier
                }
                else
                {
                    Console.WriteLine("Please enter exactly 'Yes' or 'No'.");
                    Console.WriteLine("Do you want to add the sum and its operands? Type exactly 'Yes' or 'No':");
                }
            }

            if (_sum > 15) // vorher > 51
            {
                Console.WriteLine("The new sum is greater than 15!");   //Write muss "WriteLine" sein
            }
            else // else anstatt "else do"
            {
                Console.WriteLine("The new sum is less than or equal to 15!");   //konsole.schreibzeile muss ""Console.WriteLine sein
            }
        }
    }            // { muss "}" sein
}