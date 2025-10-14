Module Area
    Sub Main()
        Dim radio As Single
        Dim area As Single
        Dim circunferencia As Single
        Const pi = 3.1415926

        Console.Write("Ingrese el Radio: ")
        radio = Console.ReadLine

        area = pi * radio ^ 2
        circunferencia = 2 * pi * radio

        Console.WriteLine("el area es: {0}", area)
        Console.WriteLine("La circunferencia es: {0}", circunferencia)

        Console.ReadKey()

    End Sub
End Module