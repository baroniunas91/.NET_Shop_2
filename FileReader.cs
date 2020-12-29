using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_2
{
    public class FileReader : IReader
    {
        private readonly string _fileName;
        public FileReader(string fileName)
        {
            _fileName = fileName;
        }
        public List<string> Read()
        {
            try
            {
                StreamReader sr = new StreamReader($"../../../fileprinter/{_fileName}", true);
                string line = sr.ReadLine();

                List<string> lines = new List<string>();

                while (line != null)
                {
                    lines.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                return lines;
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
