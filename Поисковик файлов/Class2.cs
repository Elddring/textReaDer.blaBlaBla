using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Поисковик_файлов
{
   

    public class Figure_changes
    {

        public string Name1 { get; set; }
        public string wight1 { get; set; }
        public string length1 { get; set; }
        
        public void WriteFigure()
        {
            using (StreamWriter sw = File.AppendText(Program.FileName))
            {
                sw.WriteLine(this.Name1);
                sw.WriteLine(this.wight1);
                sw.WriteLine(this.length1);
            }
        }
        /*public Figure_changes(string name1, string Wight1, string Length1)
        {
            Name1 = name1;
            wight1 = Wight1;
            length1 = Length1;
        }*/

    }

}
public class Person
{
    public string Name { get; set; } = "Undefined";
    public string Age { get; set; } = "sdjfhjshd";

    public Person() { }
    public Person(string name, string age)
    {
        Name = name;
        Age = age;
    }
}