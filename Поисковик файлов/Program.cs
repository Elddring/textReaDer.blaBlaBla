using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
using MyNamespace;

namespace Поисковик_файлов
{
    public class Program
    {
        public static string FileName;
        static void Main(string[] args)
        {
            Chech();
        }
        public static void Chech() 
        {
            do
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Введите путь файла, который вы хотите октрыть    ");
                Thread.Sleep(2000);
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("----------------------------------------------   ");
                string text = Console.ReadLine();
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("                                                 ");
                FileName = text;
                if (System.IO.File.Exists(Convert.ToString(Path.GetFullPath(text))) == false)
                {
                    Console.SetCursorPosition(13, 1);
                    Console.WriteLine("Не найден файл");
                }
                if (System.IO.File.Exists(Convert.ToString(Path.GetFullPath(text))) == true)
                {

                    Class1_Vivoda.Vivod();
                }
            } while (true);
        }
    }
    
    
    
}