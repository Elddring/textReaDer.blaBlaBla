using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
