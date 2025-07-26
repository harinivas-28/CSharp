using System; // we can use classes from the System namespace

namespace HelloWorld // namespace is a container for classes and other namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write(" This will print on the same line");
            Console.WriteLine(3 + 3);
            // This is a single line comment
            /* This is a
             multi line
            comment */

            // Variable's
            int n = 12; // 4 bytes
            double d = 12.5D; // 8 bytes
            long l = 12345567788L; // 8 bytes
            char c = 'a'; // 2bytes
            string s = "Harinivas"; // 2 bytes per character
            bool b = true; // 1 byte
            float f = 12.5F; // 4 bytes
            Console.WriteLine(n + d);
            // displaying variables are as same as in java
            int x = 5, y = 10, z = 15;
            int m, r, o;
            m = r = o = 50;
            // user input
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age);
            // operators are similar to java
            // C# Math
            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Min(5, 10));
            Console.WriteLine("Sqrt of 64 is: " + Math.Sqrt(64));
            Console.WriteLine(Math.Abs(-4.7));
            Console.WriteLine(Math.Round(9.99));
            // Strings
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine(txt.Length);
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());
            Console.WriteLine(string.Concat(txt, name));
            // String interpolation
            string printName = $"My name is: {txt} {name}";
            Console.WriteLine(printName);
            Console.WriteLine("First Character in name: " + name[0]);
            Console.WriteLine(name.IndexOf("i"));
            string name2 = "John Doe";
            int charPos = name2.IndexOf("D");
            string lastName = name2.Substring(charPos);
            Console.WriteLine(lastName);
            // special characters are same as in java
            // Booleans
            bool isCSharpFun = true;
            Console.WriteLine(isCSharpFun);
            if (age > 18 && age < 100) 
            {
                Console.WriteLine("Can Vote!");
            } else if (age>100){
                Console.WriteLine("Die Bro!");
            } else {
                Console.WriteLine("Cannot Vote!");
            }
            // ternary is similar in java
            string result = (age > 18) ? "Can Vote" : "Cannot Vote";
            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("Other days");
                    break;
            }
            // while and for loops are same as in the java;
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach(string i in cars){
                Console.WriteLine(i);
            }
            // loop control statements like break and continue are similar to java
            // ARRAYS
            string[] names;
            //names = {"Volvo", "BMW","Ford", "Mazda"}; This is Wrong
            names = new string[] { "Volvo", "BMW", "Ford", "Mazda" };
            int[] nums = { 1, 2, 4 };
            Console.WriteLine(string.Join(", ", nums)); // 1, 2, 3

        }
    }
}