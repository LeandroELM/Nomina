using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina2
{
    public class HourlyEmplopyee : Empleado
    {
        private decimal wage;
        private decimal hour;
        public HourlyEmplopyee(string firstName, string lastName, string socialSecurityNumber,decimal hourlywage,decimal hourworked) : base(firstName, lastName, socialSecurityNumber)
        {
            wage = hourlywage;
            hour = hourworked;
        }

        public decimal Wage 
        { 
            get => wage;


            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                      value, $"{nameof(wage)} debe ser mayor a cero");
                }
                wage = value;
            }
            
        }
        public decimal Hour 
        { 
            get => hour;


            set 
            {
                if (value < 0 || value > 160)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(hour)} must be >= 0 and <= 160");
                    hour = value;
                }
            }
        }

        public override decimal Ingresos()
        {
            throw new NotImplementedException();
        }
    }
}
