using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePOO1.Entities
{
    sealed class OutSourcedEmployee : Employee
    {
        public double AdditionalCharge { get; private set; }

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) 
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            double total;
            total = base.Payment();
            return total + (AdditionalCharge*1.1);
        }




    }
}
