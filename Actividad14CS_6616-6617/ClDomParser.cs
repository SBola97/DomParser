using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Data;

namespace Actividad14CS_6616_6617
{
    class ClDomParser
    {
        FileStream direccion;
        public ClDomParser(string direc)
        {
            this.direccion = new FileStream(direc,FileMode.Open,FileAccess.Read);
        }

        public void Leer()
        {
            XmlDocument Doc = new XmlDocument();
            Doc.Load(direccion);
            XmlNodeList raiz = Doc.DocumentElement.SelectNodes("jugador");
            Console.WriteLine("Plantilla de jugadores: \n");
            foreach (XmlNode nodo in raiz)
            {
                //Console.WriteLine(nodo.SelectSingleNode("nombre").InnerText);
                Console.WriteLine("ID: "+nodo.Attributes.GetNamedItem("id").InnerText);
                Console.WriteLine("Nombre: "+nodo.ChildNodes.Item(0).InnerText);
                Console.WriteLine("Apellido: "+nodo.ChildNodes.Item(1).InnerText);
                Console.WriteLine("Posición: "+nodo.ChildNodes.Item(2).InnerText);
                Console.WriteLine("Edad:"+nodo.ChildNodes.Item(3).InnerText);
                Console.WriteLine("Partidos jugados:" + nodo.ChildNodes.Item(4).InnerText);
                Console.WriteLine("\n");
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Lista de jugadores en venta: \n");
            foreach (XmlNode nodo in raiz)
            {
                if (int.Parse(nodo.ChildNodes.Item(4).InnerText) < 7)  //Jugadores con menos de 7 partidos jugados
                {
                    Console.WriteLine("ID: " + nodo.Attributes.GetNamedItem("id").InnerText);
                    Console.WriteLine("Nombre: " + nodo.ChildNodes.Item(0).InnerText);
                    Console.WriteLine("Apellido: " + nodo.ChildNodes.Item(1).InnerText);
                    Console.WriteLine("Posición: " + nodo.ChildNodes.Item(2).InnerText);
                    Console.WriteLine("Edad:" + nodo.ChildNodes.Item(3).InnerText);
                    Console.WriteLine("Partidos jugados:" + nodo.ChildNodes.Item(4).InnerText);
                    Console.WriteLine("\n");
                }
            }
            Console.ReadLine();

        }
    }
}
