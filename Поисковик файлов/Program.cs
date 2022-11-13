using System.Text.Json;
using System.Text.Json.Serialization;
namespace Поисковик_файлов
{
    internal class Program
    {
        public static string FileName;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь файла, который вы хотите октрыть");
            Console.WriteLine("----------------------------------------------");
            string text = Console.ReadLine();
            FileName = text;
            if (System.IO.File.Exists(Convert.ToString(Path.GetFullPath(text))) == false)
                Console.WriteLine("Не найден файл");
            Console.WriteLine(File.ReadAllText(text));
            Class1.Vivod();
        }
    }
}