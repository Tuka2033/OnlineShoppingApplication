using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MathLib
{
    public class Complex
    {

        private int real;
        private int imag;

        public int Real
        {
            get { return real; }
            set { real = value; }
        }

        public int Imag
        {
            get { return imag; }
            set { real = imag; }
        }
        public Complex() { }
        public Complex(int r, int i)
        {
            real = r;
            imag = i;
        }

        public static Complex operator+ (Complex c1, Complex c2)
        {
            Complex temp = new Complex();
            temp.real = c1.real + c2.real;
            temp.imag = c1.imag + c2.imag;
            return temp;

        }
    }
}
