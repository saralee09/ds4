﻿namespace Laboratorio8
{
    public partial class Coordenadas
    {
        private int x;
        private int y;

        public Coordenadas(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public partial class Coordenadas
    {
        public void VerCoordenadas()
        {
            Console.WriteLine("Coordenadas: {0}, {1}", x, y);
        }
    }
}