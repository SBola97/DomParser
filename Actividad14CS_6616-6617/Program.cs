using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad14CS_6616_6617
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\t\tPROGRAMA PARA LEER UN DOCUMENTO XML (DOM)\n\n");
            ClDomParser ObjParser = new ClDomParser("../../equipo.xml");
            ObjParser.Leer();
        }
    }
}
