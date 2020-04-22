using System;

namespace Regex_validate_PIN_code
{
//    ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.
//If the function is passed a valid PIN string, return true, else return false.
    class Program
    {
        static void Main(string[] args)
        {
            string pin = "1234566";
            bool value=true;
            
            for (int i = 0; i < pin.Length; i++)
            {
                if (!Char.IsDigit(pin, i))
                {
                   value = false;
                    break;
                }
                
            }
            if (pin.Length != 4 && pin.Length != 6)
            {
                value = false;
            }
            Console.WriteLine(value);
        }
    }
}
