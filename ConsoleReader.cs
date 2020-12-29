using System;
using System.Collections.Generic;

namespace Shop_2
{
    public class ConsoleReader : IReader
    {
        public List<string> Read()
        {
            List<string> lines = new List<string>();
            string action = Console.ReadLine();
            lines.Add(action);
            return lines;
        }
    }
}
