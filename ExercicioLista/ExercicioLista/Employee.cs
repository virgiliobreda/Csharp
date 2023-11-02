using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista
{
    internal class Employee
    {   
        public int Id { get; set; }
        public string Name { get; set; }

        public double Salary { get; private set; }


        // Construtores
        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }


        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
