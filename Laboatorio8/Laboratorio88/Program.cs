﻿using Laboratorio88;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ClaseConcreta1 concreta1 = new ClaseConcreta1();
            concreta1.printOut();
            Console.WriteLine(concreta1.prefixValor("ES_"));

            ClaseConcreta2 concreta2 = new ClaseConcreta2();
            concreta2.printOut();
            Console.WriteLine(concreta2.prefixValor("ES_"));
        }
    }
}