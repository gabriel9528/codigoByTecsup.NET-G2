﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Herencia
{
    public class Empleado : Persona
    {
        protected float sueldo;

        public float Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        new public void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Sueldo: " + Sueldo);
        }
    }
}
