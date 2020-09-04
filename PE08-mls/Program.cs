using System;

namespace PE08_mls
{
    class Program
    {
        static void Main(string[] args)
        {

            // Math class work
            double sine30;
            double cos60;
            double powerEx;
            double maxInt;
            double rounded;


            sine30 = (30.0 * (Math.PI)) / 180;
            sine30 = Math.Sin(sine30);
            Console.WriteLine("The sine of 30 degrees is " + Math.Round(sine30,2)); 

            cos60 = (60.0 * (Math.PI)) / 180;
            cos60 = Math.Cos(cos60);
            Console.WriteLine("The cosine of 60 degrees is " + Math.Round(cos60,2));

            powerEx = Math.Pow(7.0, 6.0);
            Console.WriteLine("7 raised to the sixth power is " + powerEx);

            maxInt = Math.Max(9.0, 7.0);
            Console.WriteLine("The maximum number between 9.0 and 7.0 is " + maxInt);

            rounded = Math.Truncate(9876.432);
            Console.WriteLine("The integer part of the number 9876.432 is " + rounded);

            Console.WriteLine("\n\n");

            //String Class Work

            Console.WriteLine("Please enter a word to complete the sentence: ");
            string windows = "The user interface designers of Windows 10 should be " + Console.ReadLine();

            Console.WriteLine("There is a z at position " + windows.IndexOf('z'));

            Console.WriteLine("There is a s at position " + windows.IndexOf('s'));

            int number = windows.IndexOf(' ');
            number = number + windows.IndexOf(' ', number + 1);
            Console.WriteLine("The fourth word in the string is " + windows.Substring(windows.IndexOf(' ', number),9));

            Console.WriteLine("The length of the string is " + windows.Length);

            windows = windows.ToLower();
            Console.WriteLine("The string in all lowercase: " + windows);

            windows = windows.ToUpper();
            Console.WriteLine("The string in all uppercase: " + windows);

            //String Formatting work 

            const double TAX_RATE = .0825;
            int userPrice;
            double newPrice;

            Console.WriteLine("\n\nHow much are you willing to pay for a sub?");

            bool tryParse = int.TryParse(Console.ReadLine(), out userPrice);

            if (tryParse == true )
            {
                newPrice = ((userPrice + .12) * TAX_RATE) + (userPrice + .12);
                Console.WriteLine("The price of the sub would be: $" + Math.Round(newPrice,2));

                
            }
                

        }
    }
}
