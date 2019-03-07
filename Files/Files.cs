using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Createfile();
        }
        public static string Createfile()
        {
            string fileName = "This is a text file";
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine("This is a text file");
                }
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = sr.ReadLine();
                    while (s != null)
                    {
                        Console.WriteLine(s);
                        s = sr.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return fileName;
        }
    }
}

