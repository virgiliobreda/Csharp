using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoVetores
{
    internal class Estudante
    {
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }

        public Estudante(string name, string email)
        {
            StudentName = name;
            StudentEmail = email;
        }

        public override string ToString()
        {
            return StudentName + ',' + StudentEmail;
        }
    }
}
