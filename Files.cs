using System.IO;
using System.Runtime.InteropServices.Marshalling;

namespace Program
{
    public class Files
    {
        public Files()
        {
            string writeText = "Hello World!";
            File.WriteAllText("filename.txt", writeText);

            string readText = File.ReadAllText("filename.txt");
            Console.WriteLine(readText);

            File.Create("example.txt").Close();
            File.WriteAllText("example.txt", "Hello, C# File Handling");
            File.AppendAllText("example.txt", "\nThis is appended line.");
            string content = File.ReadAllText("example.txt");
            Console.WriteLine(content);

            using StreamWriter writer = new("example2.txt");
            writer.WriteLine("Line 1");
            writer.WriteLine("Line 2");
            writer.Close();
            using StreamReader reader = new("example2.txt");
            string? line;
            try
            {
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                reader.Close();
            }
            FileInfo file = new("example3.txt");
            using StreamWriter writer2 = file.CreateText();
            writer2.WriteLine("Using FileInfo to write");
            writer2.Close();
            
            string path = "myfile.txt";
            File.WriteAllText(path, "Hello World!\n");
            File.AppendAllText(path, "Appending a second line.\n");
            string[] lines = File.ReadAllLines(path);
            foreach (string l in lines)
            {
                Console.WriteLine(l);
            }
            if (File.Exists(path))
                Console.WriteLine("File exists");
            File.Delete(path);
            Console.WriteLine("File deleted.");
        }
    }
}