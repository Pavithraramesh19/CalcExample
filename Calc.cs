﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcExample
{
    public class Calc
    {
        public void Add(double n1, double n2)
        {
            Console.WriteLine("Rseult after addition \t" + (n1 + n2));
        }
        public void Sub(double n1, double n2)
        {
            Console.WriteLine("Rseult after subtraction \t " + (n1 - n2));
        }
        public void Div(double n1, double n2)
        {
            Console.WriteLine("Rseult after Division \t" + (n1 / n2));
        }
        public void Multi(double n1, double n2)
        {
            Console.WriteLine("Rseult after Multiplication \t" + (n1 * n2));
        }
        public void Avg(double n1, double n2)
        {
            Console.WriteLine("Rseult after Average \t" + (n1 / n2)/2);
        }
        public void Addthree(double n1, double n2,double n3)
        {
            Console.WriteLine("Rseult after additionthree \t" + (n1 + n2 + n3));
        }
    }
}
