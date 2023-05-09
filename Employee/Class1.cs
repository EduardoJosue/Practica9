using Departamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Empleado
    {
        public int fixedSalary; //Salario fijo
        public DateTime workingFrom; // fecha donde empieza a jalar 
        public Departament departamento; // Dept para el que trabaja 
     
        public Empleado(int fixedSalary, DateTime workingFrom, Departament departamento)
        {
            this.fixedSalary = fixedSalary;
            this.workingFrom = workingFrom;
            this.departamento = departamento;
        }
        double GetAllowance()
        {
            DateTime cuttOfDay = new DateTime(2014,03,31);

            return GetAllowance(cuttOfDay);
        }
        double GetAllowance(DateTime cuttOfDay) 
        {
            TimeSpan days = cuttOfDay - workingFrom;
            int x = days.Days/365;

            if (x < 5)
            {
                return 0.05* fixedSalary;
            }
            else if (x<10 && x>=5)
            {
                return 0.10 * fixedSalary; 
            }
            else if(x<15 && x>=10) 
            {
                return 0.15 * fixedSalary;
            }
            else if( x>=15)
            {
                return 0.20 * fixedSalary;
            }
            else 
            { 
                return 0; 
            }
        }
        public double GetTotalSalary(DateTime cuttOfDay, float multiplyFactory)
        {
            return fixedSalary + GetAllowance(cuttOfDay) +departamento.GetIncentive(multiplyFactory);
        }   //Salario + complemento de salary basandose en su antiguedad + Extra por productividad 

        public double GetTotalSalary(float multiplyFactory)
        {
            return fixedSalary + GetAllowance() + departamento.GetIncentive(multiplyFactory);
        }
    }
}
