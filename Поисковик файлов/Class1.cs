using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Поисковик_файлов;
using static System.Net.Mime.MediaTypeNames;

namespace MyNamespace
{
    public class Class1_Vivoda
    {
        public static ConsoleKeyInfo key;
        private static bool exit_the_loop = false;
        public static bool Deserealize = false;
        public static string deser = null;
        public static Figure_changes xml1;
        public static List<Figure_changes> FormFactor = new List<Figure_changes>();
        public static List<Figure_changes> result;
        public static void Vivod()
        {
            Console.Clear();
            string text = File.ReadAllText(Program.FileName);
            
            Console.WriteLine("Чтобы сохранить файл в одном из трёх форматов: json, txt, xml, нажмите F1. Чтобы закрыть программу нажмите ESC");
            Console.WriteLine("Для выхода в меню выбора файла, нажмите кнопку Backspase.");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            
            //Условия десериализации
            if (deser == "on")
            {
                
                List<Figure_changes> deserialization = JsonConvert.DeserializeObject<List<Figure_changes>>(text);
                foreach (var item in deserialization)
                {
                    Console.WriteLine(item.Name1);
                    Console.WriteLine(item.wight1);
                    Console.WriteLine(item.length1);
                }
                result = JsonConvert.DeserializeObject<List<Figure_changes>>(File.ReadAllText(Program.FileName));
            }
            if (deser == "xt")
            {
                Console.WriteLine(File.ReadAllText(Program.FileName));
                Figure_changes figure1 = new Figure_changes();
                figure1.Name1 = File.ReadLines(Program.FileName).Skip(0).Take(1).First();
                figure1.length1 = (File.ReadLines(Program.FileName).Skip(1).Take(1).First());
                figure1.wight1 = (File.ReadLines(Program.FileName).Skip(2).Take(1).First());
                Figure_changes figure2 = new Figure_changes();
                figure2.Name1 = File.ReadLines(Program.FileName).Skip(3).Take(1).First();
                figure2.length1 = (File.ReadLines(Program.FileName).Skip(4).Take(1).First());
                figure2.wight1 = (File.ReadLines(Program.FileName).Skip(5).Take(1).First());
                FormFactor.Add(figure1);
                FormFactor.Add(figure2);
            }
            if (deser == "ml")
            {
                XmlSerializer xml = new XmlSerializer(typeof(Figure_changes));
                using (FileStream cw = new FileStream(Program.FileName, FileMode.Open))
                {
                    result = (List<Figure_changes>)xml.Deserialize(cw);
                }
                string vre = Convert.ToString(result);
                foreach (var item in result)
                {
                    Console.WriteLine(item.Name1);
                    Console.WriteLine(item.wight1);
                    Console.WriteLine(item.length1);
                }
            }

            //Действия с текстом
            do
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.F1)
                {
                    Console.WriteLine("Введите путь файла(с расширением). Kуда вы хотите сохранить текст?");
                    Console.WriteLine("------------------------------------------------------------------");
                    string way = Console.ReadLine();
                   /* perekluch.selector();*/
                    ConvertToJson(way);
                    exit_the_loop = true;
                }
                if (key.Key == ConsoleKey.Backspace)
                {
                    Console.Clear();
                    return;
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
            } while (exit_the_loop = false);
            Console.Clear();
            Program.Chech();
        }

        public static void ConvertToJson(string wayFile)
        {
            string s = wayFile;
            s = s.Substring(s.Length - 2, 2);
            if (s == "on")
            {
                string json = JsonConvert.SerializeObject(FormFactor);
                File.WriteAllText(wayFile, json);
            }
            if (s == "ml")
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Figure_changes>));
                using (FileStream cw = new FileStream("ficha.xml", FileMode.OpenOrCreate))
                {
                    xml.Serialize(cw, xml1);
                }
                string ficha = File.ReadAllText("ficha.xml");
                File.WriteAllText(wayFile, ficha);
                File.Delete("ficha.xml");


            }
            if (s == "xt")
            {
                string full = null;
                foreach (Figure_changes nadoelo in result)
                {
                    full += $"{nadoelo.Name1}\n{nadoelo.length1}\n{nadoelo.wight1}\n";
                }
                File.WriteAllText(wayFile, full);
            }
        }
    }
}

