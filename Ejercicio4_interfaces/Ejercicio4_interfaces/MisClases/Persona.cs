using Ejercicio4_interfaces.MisInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;

namespace Ejercicio4_interfaces.MisClases
{
    internal class Persona : IPersona
    {
        public string Name { get; set; }
        public int Edad { get; private set; }

        public void cumplirAños()
        {
            Console.WriteLine($"Mi nombre es {Name} y tengo {Edad++} años");
        }

        public void DecirMiNombre()
        {
            Console.WriteLine($"Mi nombre es {Name}");
        }

        void IPersona.Edad()
        {
            throw new NotImplementedException();
        }

        void IPersona.Name()
        {
            Console.WriteLine("Mi Nombre es Jairo");
        }
    }
}