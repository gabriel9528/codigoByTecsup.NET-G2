﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Herencia
{
    public class Operacion
    {
        protected int valor1; 
        protected int valor2; 
        private int resultado; 

        public int Valor1
        {
            get { return valor1; }
            set { valor1 = value; }
        }

        public int Valor2
        {
            get { return valor2; }
            set { valor2 = value; }
        }

        public int Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }
    }
}
