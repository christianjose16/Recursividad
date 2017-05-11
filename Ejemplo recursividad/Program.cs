using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejemplo_recursividad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al ejempo de recursividad");

            Persona persona = new Persona();
            persona.NacePersona("Anakyn", 1, 0);//nombre Anakyn Cui 1 cui: 0
            persona.NacePersona("Luke", 2, 1);// nombre Luke Cui 2 cui: 1
            persona.NacePersona("Ben", 3,2);// nombre Ben Cui 2 cui: 2
            persona.MuestraArbol();        
            Console.Read();
        }
    }
}
