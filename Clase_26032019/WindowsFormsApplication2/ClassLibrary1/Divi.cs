using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Divi
    {
        private double d1, d2,resultado;

        public double D1
        {
            get
            {
                return d1;
            }

            set
            {
                d1 = value;
            }
        }

        public double D2
        {
            get
            {
                return d2;
            }

            set
            {
                d2 = value;
            }
        }

        public double Resultado
        {
            get
            {
                return resultado;
            }

            set
            {
                resultado = value;
            }
        }

        public Divi()
        {
            this.d1 = 0;
            this.d2 = 0;
        }

        public double Calcular()
        {
            resultado = (d1 / d2);
            return resultado;
        }
    }
}
