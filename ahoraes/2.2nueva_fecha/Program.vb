Imports System.DateTime

Module Program
    Sub Main()

        Dim diaingresado As Integer
        Dim fechaingresado As Date

        Console.WriteLine("Ingrese la fecha: #MM/DD/AAAA#")
        fechaingresado = Console.ReadLine()

        Console.WriteLine("Ingrese un dia: (1-31)")
        diaingresado = Console.ReadLine()

        Console.WriteLine("La fecha sumada es: " & getFechaSumar(fechaingresado, diaingresado))

    End Sub

    Private Function getFechaSumar(fechaadd As Date, diasadd As Integer) As Date
        Return fechaadd.AddDays(diasadd)
    End Function
End Module