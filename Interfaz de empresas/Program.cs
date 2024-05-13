using Interfaz_de_empresas;
using Interfaz_de_empresas.Modelo;
using System.Runtime.CompilerServices;

Console.WriteLine("Actividad Interfaces");

AppStatic.InstanciarTodo();
List<Company> companies = AppStatic.Companies;


foreach (Company company in companies)
{
    Console.WriteLine("Empresa: " + company.ToString());    
    Console.WriteLine("Empleados: ");
    company.GetEmployees();
    Console.WriteLine("\nCreando software...");
    company.CreateSoftware();
    Console.WriteLine("\n");

}
