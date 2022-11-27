/*using MyNamespace;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Поисковик_файлов
{
    public class perekluch
    {

        public static int position = 3;
        public static int positionLR = 0;
        public static void selector()
        {
            int a = 0;
            while (1 != 0)
            {
                List<string> FranchecoPetrarko = new List<string>();
                Figure_changes temp = new Figure_changes();
                do
                {
                    a++;
                    for (int i = 0; i < FranchecoPetrarko.Count; i++)
                    {
                        string? item = FranchecoPetrarko[i];
                        FranchecoPetrarko.Remove(item);
                    }
                } while (a != 5);
                a = 0;
                FranchecoPetrarko.Add(temp.Name1);
                FranchecoPetrarko.Add(temp.wight1);
                FranchecoPetrarko.Add(temp.length1);
                FranchecoPetrarko.Add(temp.Name2);
                FranchecoPetrarko.Add(temp.wight2);
                FranchecoPetrarko.Add(temp.length2);
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
                if (position ==3)
                {
                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("Введите наименование первой фигуры: ");
                        Console.SetCursorPosition(0, position);
                        temp.Name1 = Console.ReadLine();
                        
                    }
                }
                if (position == 4)
                {
                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.SetCursorPosition(0, position);
                        temp.wight1 = (Console.ReadLine());
                        
                    }
                }
                if (position == 5)
                {
                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.SetCursorPosition(0, position);
                        temp.length1 = (Console.ReadLine());
                        
                    }
                }
                if (position == 6)
                {
                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("Введите наименование второй фигуры: ");
                        Console.SetCursorPosition(0, position);
                        temp.Name2 = Console.ReadLine();
                        
                    }
                }
                if (position == 7)
                {
                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.SetCursorPosition(0, position);
                        temp.wight2 = (Console.ReadLine());
                        
                    }
                }
                if (position == 8)
                {
                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.SetCursorPosition(0, position);
                        temp.length2 = (Console.ReadLine());
                        
                    }
                }

                if (key.Key == ConsoleKey.Escape)
                {
                    foreach (object o in FranchecoPetrarko)
                    {
                        Console.WriteLine(o);
                    }
                    Console.Clear();
                    temp.WriteFigure(Program.FileName);
                    break;
                }
            }
        }

    }
}
*/