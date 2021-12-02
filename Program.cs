using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexNumber
{
    class Program
    {
        struct ComplexNumber
        {
            public string name;
          public  double a;
          public  double b;
          public int i;

            public ComplexNumber(string name,double a,double b)
            {
                this.name = name;
                this.a = a;
                this.b = b;
                i = 1;
            }
            public static ComplexNumber operator +(ComplexNumber z1,ComplexNumber z2)
            {
                return new ComplexNumber("z",z1.a + z2.a, z1.b + z2.b);
            }
            public static ComplexNumber operator -(ComplexNumber z1,ComplexNumber z2)
            {
                return new ComplexNumber("z",z1.a - z2.a, z1.b - z2.b);
            }
            public static ComplexNumber operator *(ComplexNumber z1,ComplexNumber z2)
            {
                
                return new ComplexNumber("z",(z1.a*z2.a)-(z1.b+z2.b), (z1.a*z2.b)+(z1.b*z2.a));
            }
            public static ComplexNumber operator /(ComplexNumber z1,ComplexNumber z2)
            {

                return new ComplexNumber("z", ((z1.a * z2.a) + (z1.b * z2.b)) / (Math.Pow(z2.a, 2) + Math.Pow(z2.b, 2)), ((z2.a * z1.b) - (z1.a * z2.b)) / (Math.Pow(z2.a, 2) + Math.Pow(z2.b, 2)));
            }
          public override string ToString()
            {
                return $"{name}={a}+i*{b}";
            }
        }
        static void Main(string[] args)
        {
            ComplexNumber z=new ComplexNumber("z",3,5);
            ComplexNumber z1=new ComplexNumber("z",1,-6);
            ComplexNumber z2=new ComplexNumber();
            z2 = z + z1;
            Console.WriteLine(z2);
            z2 = z - z1;
            Console.WriteLine(z2);
            z2 = z * z1;
            Console.WriteLine(z2);
            z2 = z / z1;
            Console.WriteLine(z2);

        }
    }
}
