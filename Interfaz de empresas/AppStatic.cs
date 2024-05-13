using Interfaz_de_empresas.ClasesConcretas;
using Interfaz_de_empresas.Interfaces;
using Interfaz_de_empresas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_de_empresas
{
    public static class AppStatic
    {
        public static List<Company> Companies = new List<Company>();
        public static List<IEmployee> Employees = new List<IEmployee>();


        public static void InstanciarTodo()
        {
            InstanciarEmpresas();
            InstanciarEmpleados();
        }

        private static void InstanciarEmpresas() {
            Companies.Add(new GameDevCompany("Electronic Ars"));
            Companies.Add(new OutSourcingCompany("Empresa 1"));
        }
        private static void InstanciarEmpleados()
        {
            Employees.Add(new Tester("Mauro"));
            Employees.Add(new Programmer("Santini"));
            Employees.Add(new Artist("DaVinci Leonardo"));
            Employees.Add(new Designer("DiCaprio"));

            Companies[0].HireEmployee(Employees[1]);
            Companies[0].HireEmployee(Employees[0]);
            Companies[1].HireEmployee(Employees[2]);
            Companies[1].HireEmployee(Employees[3]);
        }


    }
}
