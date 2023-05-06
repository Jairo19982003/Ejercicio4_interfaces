using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_interfaces.MisInterfaces
{
    internal interface IPersona
    {
        String Name { get; set; }
        int Edad { get; }

        void Edad();
        void Name();

        internal class Persona : IPersona
        {
            private int edad;

            public string Name { get; set; }
            public int Edad => edad;

            public void DecirMiNombre()
            {
                Console.WriteLine($"Hola, soy {Name}, y tengo {Edad} años");
            }

            public void CumplirAños()
            {
                edad++;
            }

            void IPersona.Name()
            {
                Console.WriteLine($"Mi nombre es: {Name}");
            }
        }
    }
}






