using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoExercicio.Entities
{
    internal class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        OutsourceEmployee() { }
        public OutsourceEmployee(string name, int hours, double valuePerHour,double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.10 * AdditionalCharge;
        }


    }
}
