using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina2
{
    public class EmpleadoAsalariado : Empleado
    {
        private decimal SalarioSemanal;
        public EmpleadoAsalariado(string firstName, string lastName, string socialSecurityNumber, decimal salarioSemanal) : base(firstName, lastName, socialSecurityNumber)
        {
            SalarioSemanal = salarioSemanal;
        }

        public decimal SalarioSemanal1
        {
            get 
            {
                return SalarioSemanal;
            }
            set 
            {
                if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(SalarioSemanal1)} no puede ser cero");
            }
        }

        public override decimal Ingresos() => SalarioSemanal;
        public override string ToString()
        {
            return $"Salario del empleado: {base.ToString() }\n" +
                $"Salario semanal";
        }

    }
}
