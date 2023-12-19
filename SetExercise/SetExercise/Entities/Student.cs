using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetExercise.Entities
{
    internal class Student
    {
        public int Id { get; set; }


        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Student)) return false;

            Student other = obj as Student;
            return Id.Equals(other.Id); ;
        }
    }
}
