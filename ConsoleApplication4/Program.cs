using static System.ValueType;
using System;
using static System.Console;
using System.Text;
using System.Numerics;

namespace ConsoleApplication4
{
    /// <summary>
    /// C# Avançado
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            //SwitchOnEnumExample();

            Console.WriteLine("***** Fun with Methods *****");

            int ans;
            Add(90, 90, out ans);

            WriteLine("90 + 90 = {0}", ans);
            ReadLine();
        }

        //static int Main(string[] args)
        //{
        //    //// Display a message and wait for Enter key to be
        //    //Console.WriteLine("***** My First C# App *****");
        //    //Console.WriteLine("Hello World!");
        //    //Console.WriteLine();
        //    //Console.ReadLine();
        //    //// Return an arbitrary error code.
        //    //return -1;
        //    // Get arguments using System.Environment.
        //    string[] theArgs = Environment.GetCommandLineArgs();
        //    foreach (string arg in theArgs)
        //    {
        //        Console.WriteLine("Arg: {0}", arg);
        //        Console.ReadLine();
        //    }
        //    return -1;

        //}

        static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }
        static void ShowEnvironmentDetails()
        {

            foreach (string drive in Environment.GetLogicalDrives())
            {
                WriteLine("Drive: {0}", drive);
                WriteLine("OS: {0}", Environment.WorkingSet);
                WriteLine("Number of processors: {0}", Environment.ProcessorCount);
                WriteLine(".NET Version: {0}", Environment.Version);
                Beep();

            }
            ReadKey();
        }        static void GetUserData()
        {
            // Get name and age.
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string userAge = Console.ReadLine();
            // Change echo color, just for fun.
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            // Echo to the console.
            Console.WriteLine("Hello {0}! You are {1} yearsold.", userName, userAge);
            // Restore previous color.
            Console.ForegroundColor = prevColor;
        }        static void FormatNumericalData()
        {
            Console.WriteLine("The value 99999 in various formats: ");
            Console.WriteLine("c format: {0:c}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);
            // Notice that upper- or lowercasing for hex
            // determines if letters are upper- or lowercase.
            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);
        }        static void DisplayMessage()
        {
            // Using string.Format() to format a string literal.
            string userMessage = string.Format($"100000 in hex is {1000:x}");
            // You need to reference PresentationFramework.dll
            // in order to compile this line of code!
            System.Windows.MessageBox.Show(userMessage);
        }        static void NewingDataTypes()
        {
            Console.WriteLine("=> Using new to create variables: ");

            bool b = new bool(); // Set to false.
            int i = new int(); // Set to 0.
            double d = new double(); // Set to 0.  c
            DateTime dt = new DateTime(); // Set to 1 / 1 / 0001 12:00:00 AM 
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine();
        }        static void CharFunctionality()
        {
            Console.WriteLine("=> char type Functionality:");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit(’a’): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter(’a’): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There',5): {0} ", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine(@"char.IsWhiteSpace(’Hello There’,    6): {0} ", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
            Console.WriteLine();
        }

        static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using the StringBuilder:");
            StringBuilder sb = new StringBuilder("****Fantastic Games * ***");

            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deus Ex" + "2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", " Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
            Console.WriteLine();
        }        static void UseBigInteger()
        {
            Console.WriteLine("=> Use BigInteger:");
            BigInteger biggy = BigInteger.Parse("9999999999999999999999999999999999999999999999");
            Console.WriteLine("Value of biggy is {0}", biggy);
            Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
            Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
            BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("8888888888888888888888888888888888888888888"));
            Console.WriteLine("Value of reallyBig is {0}", reallyBig);
        }        static void SwitchOnEnumExample()
        {
            Console.Write("Enter your favorite day of the week: ");

            DayOfWeek favDay;
            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek),
               Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                return;
            }
            switch (favDay)
            {
                case DayOfWeek.Friday:
                    Console.WriteLine("Yes, Friday rules!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Another day, another dollar");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Great day indeed.");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Football!!");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Almost Friday...");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("At least it is not Monday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("A fine day.");
                    break;
            }
        }    }
}
