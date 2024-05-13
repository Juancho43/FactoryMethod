using Interfaz_de_empresas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_de_empresas.ClasesConcretas
{
    public class Programmer : IEmployee
    {
        private String FullName;
        public Programmer(String FullName)
        {
            this.FullName = FullName;
        }

        public void doWork()
        {
            Console.WriteLine($"Soy {FullName} y estoy programando.");
        }

        public override String ToString()
        {
            return "\nI'm " + FullName + " a programmer.";
        }
    }
}
