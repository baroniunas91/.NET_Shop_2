using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_2
{
    public class FilePrinter : IPrinter
    {
        public void Print(string text)
        {
            try
            {
                StreamWriter sw = new StreamWriter("../../../fileprinter/write.txt", true);
                sw.WriteLine(text);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
                throw;
            }
        }
    }
}
