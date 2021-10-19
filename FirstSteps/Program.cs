using System;
using System.Numerics;

namespace FirstSteps
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Variables();*/

            /* OperatorsAndExpressions();*/


            /* InputOutput();*/

            Arrays();
            



        }


        static void Variables()
        {

            byte centuries = 20;    
            ushort years = 2000;
            uint days = 730480;
            ulong hours = 17531520; 
            Console.WriteLine("{0} centuries is {1} years," +
                              " or {2} days, or {3} hours.",
                              centuries, years, days, hours);

            float floatPI = 3.141592653589793238f;
            double doublePI = 3.141592653589793238;
            Console.WriteLine("Float PI is: {0}", floatPI);
            Console.WriteLine("Double PI is: {0}", doublePI);

            double a = 1.0f;
            double b = 0.33f;
            double sum = 1.33f;
            bool equal = (a + b == sum); 
            Console.WriteLine("a+b={0}  sum={1}  equal={2}",
                              a + b, sum, equal);

            int first = 1;
            int second = 2;
            bool greaterAB = (first > second);
            Console.WriteLine(greaterAB); 
            bool equalA1 = (first == 1);
            Console.WriteLine(equalA1);

            char symbol = 'a';
            Console.WriteLine("The code of '{0}' is: {1}",
                symbol, (int)symbol);

            symbol = 'b';
            Console.WriteLine("The code of '{0}' is: {1}",
                symbol, (int)symbol);

            symbol = 'A';
            Console.WriteLine("The code of '{0}' is: {1}",
                symbol, (int)symbol);

            symbol = '0';
            Console.WriteLine("The code of '{0}' is: {1}",
                symbol, (int)symbol);

            string firstName = "Ivan";
            string lastName = "Ivanov";
            Console.WriteLine("Hello, {0}!\n", firstName);

            string fullName = firstName + " " + lastName;
            Console.WriteLine("Your full name is {0}.",
              fullName);


            object dataContainer = 5;
            Console.Write("The value of dataContainer is: ");
            Console.WriteLine(dataContainer);

            dataContainer = "Five";
            Console.Write("The value of dataContainer is: ");
            Console.WriteLine(dataContainer);

            int num = new int(); // num = 0

            int? someInteger = null;
            Console.WriteLine(
              "This is the integer with Null value -> "
                + someInteger);
            someInteger = 5;
            Console.WriteLine(
              "This is the integer with value 5 -> "
                + someInteger);

        }


        static void OperatorsAndExpressions()
        {

            ushort a = 3;                // 00000000 00000011
            ushort b = 5;                // 00000000 00000101
            Console.WriteLine(a | b);   // 00000000 00000111
            Console.WriteLine(a & b);   // 00000000 00000001
            Console.WriteLine(a ^ b);   // 00000000 00000110
            Console.WriteLine(~a & b);   // 00000000 00000100
            Console.WriteLine(a << 1);  // 00000000 00000110
            Console.WriteLine(a >> 1);  // 00000000 00000001

        }


        static void InputOutput()
        {
            string name = "Peter";
            int age = 18;
            string town = "Sofia";

            Console.Write("{0} is {1} years old from {2}.",
                          name, age, town);


            Console.Write("This is on the same line!");

            Console.WriteLine("Next sentence will be" +
                              " on a new line.");

            Console.WriteLine("Bye, bye, {0} from {1}.",
                              name, town);

            int a = 2;
            int b = 3;
            Console.Write("{0} + {1} =", a, b);
            Console.WriteLine(" {0}", a + b);


            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);


            float pi = 3.14159206f;
            Console.WriteLine("{0:F2}", pi); // 3,14

            Console.WriteLine("Bye – Bye!");

            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello, {0} {1}!", firstName, lastName);


            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", c, d, c + d);
            Console.WriteLine("{0} * {1} = {2}", c, d, c * d);

            float f = float.Parse(Console.ReadLine());
            Console.WriteLine("{0} * {1} / {2} = {3}",
                          c, d, f, c * d / f);


            Console.Write("Please enter your first name: ");
            string firstN = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            string lastN = Console.ReadLine();

            Console.WriteLine("Hello, {0} {1}!", firstN, lastN);


            string str = Console.ReadLine();
            int number;

            if (int.TryParse(str, out number))
            {
                Console.WriteLine("Valid number: {0}", number);
            }
            else
            {
                Console.WriteLine("Invalid number: {0}", str);
            }


        }

        
        static void Arrays()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            // Get array size
            int length = array.Length;

            // Declare and create the reversed array
            int[] reversed = new int[length];

            // Initialize the reversed array
            for (int index = 0; index < length; index++)
            {
                reversed[length - index - 1] = array[index];
            }
        }

     

    }
}
