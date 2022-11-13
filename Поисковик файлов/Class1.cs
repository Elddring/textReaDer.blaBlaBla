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

namespace Поисковик_файлов
{
    internal class Class1
    {
        public static ConsoleKeyInfo key;
        public static void Vivod()
        {
            Console.Clear();
            Console.WriteLine("Чтобы сохранить файл в одном из трёх форматов: json, txt, xml, нажмите F1. Чтобы закрыть программу нажмите ESC");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine(File.ReadAllText(Program.FileName));
            /**/

            do
            {
                
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.F1)
                {
                    Console.WriteLine("Введите путь файла(с расширением). Kуда вы хотите сохранить текст?");
                    Console.WriteLine("--------------------------------------------------------------");
                    ConvertToJson();
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
            } while (key.Key != ConsoleKey.Escape);
        }
        static void Tip()
        {
            string text2 = Console.ReadLine();
            Console.Clear();
        }
        public static void construktor() 
        {
            
        }
        public static void ConvertToJson()
        {
            /*_data.Add(new data(){Id = 1, SSN = 2, Message = "A Message"});*/
            Figure figure1 = new Figure();
            figure1.Name1 = File.ReadLines(Program.FileName).Skip(0).Take(1).First();
            figure1.length1 = Int32.Parse(File.ReadLines(Program.FileName).Skip(1).Take(1).First());
            figure1.wight1 = Int32.Parse(File.ReadLines(Program.FileName).Skip(2).Take(1).First());
            Figure figure2 = new Figure();
            figure2.Name2 = File.ReadLines(Program.FileName).Skip(3).Take(1).First();
            figure2.length2 = Int32.Parse(File.ReadLines(Program.FileName).Skip(4).Take(1).First());
            figure2.wight2 = Int32.Parse(File.ReadLines(Program.FileName).Skip(5).Take(1).First());

            List<Figure> FormFactor = new List<Figure>();
            FormFactor.Add(figure1);
            FormFactor.Add(figure2);
            string json = JsonConvert.SerializeObject(FormFactor);
            File.WriteAllText(@"C:\Users\LASHA\Desktop\jsondfsdf.json", json);

        }
        public static void CreatFile()
        {
        }
    }    
}
