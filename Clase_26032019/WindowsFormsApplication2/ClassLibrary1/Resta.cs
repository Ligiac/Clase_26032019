﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Resta
    {
       private double r1,r2,resultado;

        public double R1
        {
            get
            {
                return r1;
            }

            set
            {
                r1 = value;
            }
        }

        public double R2
        {
            get
            {
                return r2;
            }

            set
            {
                r2 = value;
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

        public Resta()
        {
            this.r1 = 0;
            this.r2 = 0;
        }

        public double Calcular()
        {
            resultado = r1 - r2;
            return resultado;
        }
    }
}
