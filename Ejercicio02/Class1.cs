using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Class1
    {
         static void Main()
        {  /*Pedir por consola el nombre de la persona y el nombre de la ciudad donde reside y mostrar por pantalla, el siguiente mensaje "Hola " nombre " 
            bienvenido a " ciudad*/

            string name, city;

            Console.WriteLine("Estimado usuario, ingrese su nombre por favor :)");
            name = Console.ReadLine();

            Console.WriteLine("Ahora ingrese la ciudad en donde reside :)");
            city = Console.ReadLine();

            Console.WriteLine("Hola " + name + " Bienvenido a " + city);
            Console.ReadLine();
         }
    }
}
