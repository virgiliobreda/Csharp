using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{/// <summary>
/// Represents a Person
/// </summary>
    internal class PersonTest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Id for Person</param>
        /// <param name="name">Name for Person</param>
        public PersonTest(int id, string name)
        {
            Id = id;
            Name = name;
        }


        
    }
}
