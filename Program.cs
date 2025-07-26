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

        }
    }
}