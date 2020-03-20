using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Ejercicio1
{
    class Triangulo : Figura
    {
        int lado;
        int lado2;
        int lado3;

        public Triangulo(int lado, int lado2, int lado3)
        {
            this.lado = lado;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public override int perimetro()
        {
            return (this.lado + this.lado2 + this.lado3);
        }
        public override int area()
        {
            int s = this.perimetro() / 2;
            int res = s * (s - this.lado) * (s - this.lado2) * (s - this.lado3);
            double raizd = Math.Sqrt(res);
            int raiz = (int)raizd;
            return raiz;
        }

    }
}
