using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Complex
    {
        public double Real { get; set; }
        public double Imag { get; set; }

        //Сложение
        public void Add(Complex x)
        {
            Real += x.Real;
            Imag += x.Imag;
        }

        //Вычитание
        public void Substract(Complex x)
        {
            Real -= x.Real;
            Imag -= x.Imag;
        }

        //Умнножение
        public void Multiply(Complex x)
        {
            Real *= x.Real;
            Imag *= x.Imag;
        }

        //Деление
        public void Divide(Complex x)
        {
            Real /= x.Real;
            Imag /= x.Imag;
        }
    }
}
