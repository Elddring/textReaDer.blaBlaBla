using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;
using Поисковик_файлов;

namespace MyNamespace
{
    public class Class1_Vivoda
    {

        public static ConsoleKeyInfo key;
        private static bool exit_the_loop = false;
        public static bool Deserealize = false;
        public static string deser = null;
        public static Figure_changes xml12;
        public static List<Figure_changes> FormFactor = new List<Figure_changes>();
        public static XmlSerializer xml = new XmlSerializer(typeof(List<Figure_changes>));

        public static Figure_changes figure1 = new Figure_changes();
        public static Figure_changes figure2 = new Figure_changes();
        public static int position = 3;
        public static int positionLR = 0;
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
                FormFactor = JsonConvert.DeserializeObject<List<Figure_changes>>(File.ReadAllText(Program.FileName));
            }
            if (deser == "xt")
            {
                Console.WriteLine(File.ReadAllText(Program.FileName));
                
                figure1.Name1 = File.ReadLines(Program.FileName).Skip(0).Take(1).First();
                figure1.length1 = (File.ReadLines(Program.FileName).Skip(1).Take(1).First());
                figure1.wight1 = (File.ReadLines(Program.FileName).Skip(2).Take(1).First());
               
                figure2.Name1 = File.ReadLines(Program.FileName).Skip(3).Take(1).First();
                figure2.length1 = (File.ReadLines(Program.FileName).Skip(4).Take(1).First());
                figure2.wight1 = (File.ReadLines(Program.FileName).Skip(5).Take(1).First());

                FormFactor.Add(figure1);
                FormFactor.Add(figure2);
            }
            if (deser == "ml")
            {
               /* XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

                // десериализуем объект
                using (FileStream fs = new FileStream(Program.FileName, FileMode.OpenOrCreate))
                {
                    Person? person = xmlSerializer.Deserialize(fs) as Person;
                    Console.WriteLine($"Name: {person?.Name}  Age: {person?.Age}");
                }*/

                using (FileStream cw = new FileStream(Program.FileName, FileMode.Open))
                {
                    FormFactor = (List<Figure_changes>)xml.Deserialize(cw);
                }
                foreach (var item in FormFactor)
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
                    selector();
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
                    xml.Serialize(cw, FormFactor);
                }
                string ficha = File.ReadAllText("ficha.xml");
                File.WriteAllText(wayFile, ficha);
                File.Delete("ficha.xml");
            }
            if (s == "xt")
            {
                string full = null;
                foreach (Figure_changes nadoelo in FormFactor)
                {
                    full += $"{nadoelo.Name1}\n{nadoelo.length1}\n{nadoelo.wight1}\n";
                }
                File.WriteAllText(wayFile, full);
            }
        }
        public static void selector()
        {
            int a = 0;
            while (1 != 0)
            {
                a = 0;
                Console.SetCursorPosition(positionLR, position);
                ConsoleKeyInfo key = Console.ReadKey();
                Console.SetCursorPosition(14, position);
                Console.Write("  ");

                if (key.Key == ConsoleKey.UpArrow)
                {
                    position = position - 1;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    position = position + 1;
                }
                if (position == 0)
                {
                    position = position + 1;
                }
                if (position >= 10)
                {
                    position = 9;
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
                if (position == 3)
                {
                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.SetCursorPosition(20, position);
                        figure1.Name1 = Console.ReadLine();

                    }
                }
                if (position == 4)
                {
                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.SetCursorPosition(20, position);
                        figure1.wight1 = (Console.ReadLine());

                    }
                }
                if (position == 5)
                {
                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.SetCursorPosition(20, position);
                        figure1.length1 = (Console.ReadLine());

                    }
                }
                if (position == 6)
                {
                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.SetCursorPosition(20, position);
                        figure2.Name1 = Console.ReadLine();

                    }
                }
                if (position == 7)
                {
                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.SetCursorPosition(20, position);
                        figure2.wight1 = (Console.ReadLine());

                    }
                }
                if (position == 8)
                {
                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.SetCursorPosition(20, position);
                        figure2.length1 = (Console.ReadLine());

                    }
                }

                if (key.Key == ConsoleKey.Escape)
                {
                    FormFactor.Add(figure1);
                    FormFactor.Add(figure2);
                    break;
                }
            }
        }
    }
}

