﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Laboratorio72
{
    internal class JuegoDeDados
    {
        private Dado dado1, dado2, dado3;
        public JuegoDeDados()
        {
            dado1 = new Dado();
            dado2 = new Dado();
            dado3 = new Dado();
        }
        public void Jugar()
        {
            dado1.Tirar();
            dado1.Imprimir();
            dado2.Tirar();
            dado2.Imprimir();
            dado3.Tirar();
            dado3.Imprimir();
            if (dado1.RetornarValor() == dado2.RetornarValor() && dado1.RetornarValor() == dado3.RetornarValor())
            {
                Console.WriteLine("Ha ganado");
            }
            else
            {
                Console.WriteLine("Ha perdido");
            }
            Console.ReadKey();
        }
    }
}