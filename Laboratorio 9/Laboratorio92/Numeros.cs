﻿using System;

public class Numeros
{
    public void RecorrerNumeros()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0 || i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
