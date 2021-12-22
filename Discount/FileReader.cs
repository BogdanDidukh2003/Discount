using System.IO;
using System.Linq;

namespace Discount
{
    public static class FileReader
    {
        public static string[] ReadFile(string path)
        {
            return File.ReadAllLines(path);
        }

        public static void WriteFile(string path, string data)
        {
            File.WriteAllText(path, data);
        }

        public static int[] ConvertStringToInt(string str)
        {
            return str.Split(' ').Select(int.Parse).ToArray();
        }
    }
}