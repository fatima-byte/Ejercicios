using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Ejercicio1
{
    class Rectangulo : Figura
    {
        int lado;
        int lado2;

        public Rectangulo(int lado, int lado2)
        {
            this.lado = lado;
            this.lado2 = lado2;
        }

        public override int area()
        {
            return (this.lado * this.lado2);
        }

        public override int perimetro()
        {
            return ((this.lado * 2)+(this.lado2 * 2));
        }
    }
}
