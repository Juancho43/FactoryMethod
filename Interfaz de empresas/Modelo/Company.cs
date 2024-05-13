using Interfaz_de_empresas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_de_empresas.Modelo
{
    public abstract class Company
    {      
        public Company() { }
        public abstract void GetEmployees();
        public abstract void CreateSoftware();
        public abstract void HireEmployee(IEmployee employee);
        
    }
}
