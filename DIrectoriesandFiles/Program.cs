using System;
using System.IO;

namespace DIrectoriesandFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a directory path to get all file info");
            string path = Console.ReadLine();

            while (Directory.Exists(path) == false)
            {
                Console.WriteLine("Enter a path that exists");
                path = Console.ReadLine();
            }

            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            foreach (var files in directoryInfo.GetFiles())
            {
                Console.WriteLine(files.Name);
            }
        }


    }
}
