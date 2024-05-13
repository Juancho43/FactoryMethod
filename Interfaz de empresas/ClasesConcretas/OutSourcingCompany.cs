using Interfaz_de_empresas.Interfaces;
using Interfaz_de_empresas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_de_empresas.ClasesConcretas
{
    public class OutSourcingCompany : Company
    {
        private String Name;
        private List<IEmployee> employees = new List<IEmployee>();

        public List<IEmployee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }
        
        public OutSourcingCompany(String name)
        {
            Name = name;
        }

        public override void HireEmployee(IEmployee employee)
        {
            Employees.Add(employee);
        }

        public override void GetEmployees()
        {
            foreach (IEmployee employee in Employees)
            {
                Console.WriteLine(employee);
            }
        }

        public override void CreateSoftware()
        {
            foreach (IEmployee employee in Employees)
            {
                employee.doWork();
            }
        }

        public override string ToString()
        {
            return $"{Name}";
        }

    }
}

