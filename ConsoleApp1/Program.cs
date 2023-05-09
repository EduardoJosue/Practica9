using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee;
using Departamento;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Departament Ventas = new Departament(1,true, 9000);
            Departament RH = new Departament(2, false, 0);

            Empleado Paco = new Empleado(5000, new DateTime(2009, 3, 17), Ventas);
            Empleado Excel = new Empleado(4000, new DateTime(2005,1, 1), RH);

            Console.WriteLine("El sueldo de Paco es: "+ Paco.GetTotalSalary(0.20f));
            Console.WriteLine("El sueldo de Excel es: "+ Excel.GetTotalSalary(new DateTime(2023,04,27),1.5f));
        }
    }
}
