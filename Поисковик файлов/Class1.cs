using Newtonsoft.Json;
using System;
using Поисковик_файлов;
using static System.Net.Mime.MediaTypeNames;

namespace MyNamespace
{
    public class Class1_Vivoda
    {
        public static ConsoleKeyInfo key;
        private static bool exit_the_loop = false;
        public static bool Deserealize = false; 

        public static void Vivod()
        {
            /*if (Program.FileName.Substring(Program.FileName.Length - 2, 2) == "on" || Program.FileName.Substring(Program.FileName.Length - 2, 2) == "ml")
            {
                Deserealize = true;
            }*/
            Console.Clear();
            Console.WriteLine("Чтобы сохранить файл в одном из трёх форматов: json, txt, xml, нажмите F1. Чтобы закрыть программу нажмите ESC");
            Console.WriteLine("Для выхода в меню выбора файла, нажмите кнопку Backspase.");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(File.ReadAllText(Program.FileName));
           
            /*if (Deserealize = true)
            {

            }
            if (Deserealize = false)
            {
                Console.WriteLine(File.ReadAllText(Program.FileName));
            }*/
            Console.WriteLine(File.ReadAllText(Program.FileName));
            do
            {

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.F1)
                {
                    
                    Console.WriteLine("Введите путь файла(с расширением). Kуда вы хотите сохранить текст?");
                    Console.WriteLine("------------------------------------------------------------------");
                    string way = Console.ReadLine();
                    /*
                    perekluch.selector();*/
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
            /*Figure_changes figure1 = new Figure_changes();
            figure1.Name1 = File.ReadLines(Program.FileName).Skip(0).Take(1).First();
            figure1.length1 = (File.ReadLines(Program.FileName).Skip(1).Take(1).First());
            figure1.wight1 = (File.ReadLines(Program.FileName).Skip(2).Take(1).First());
            Figure_changes figure2 = new Figure_changes();
            figure2.Name2 = File.ReadLines(Program.FileName).Skip(3).Take(1).First();
            figure2.length2 = (File.ReadLines(Program.FileName).Skip(4).Take(1).First());
            figure2.wight2 = (File.ReadLines(Program.FileName).Skip(5).Take(1).First());*/

            /*List<Figure_changes> FormFactor = new List<Figure_changes>();
            FormFactor.Add(figure1);
            FormFactor.Add(figure2);
            string json = JsonConvert.SerializeObject(FormFactor);
            File.WriteAllText(wayFile, json);*/

            string data = File.ReadAllText(Program.FileName);
            Figure_changes figure = JsonConvert.DeserializeObject<Figure_changes>(data);

            Console.WriteLine(figure?.Name1);
            Console.WriteLine(figure?.length1);
            Console.WriteLine(figure?.wight1);
            string r = figure?.Name1 + figure?.length1 + figure?.wight1;

            File.WriteAllText(wayFile, r);
            if (Deserealize ==  true)
            {
                
            }

        }
    }
}

