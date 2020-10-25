using System;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            int dotIndex = path.IndexOf('.');
            int lastSeparatorIndex = path.LastIndexOf("\\");

            string fileExtension = path.Substring(dotIndex + 1);

            string withoutExt = path.Remove(dotIndex);

            string fileName = withoutExt.Substring(lastSeparatorIndex + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
