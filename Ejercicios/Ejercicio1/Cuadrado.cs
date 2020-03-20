using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Ejercicio1
{
    public class Cuadrado : Figura
    {
        int lado;

        public Cuadrado(int lado)
        {
            this.lado = lado;
        }

        public override int area()
        {
            return (this.lado * this.lado);
        }

        public override int perimetro()
        {
            return (this.lado * 4);
        }
    }
}