Imports System.DateTime

Module Program
    Sub Main()
        Dim hora, minutos As Integer

        getFechaActual()
        Console.WriteLine("La hora actual es: " & getHoraActual(hora, minutos))


    End Sub

    Private Sub getFechaActual()
        Console.WriteLine("La fecha actual es: " & Now.Date)
    End Sub

    Private Function getHoraActual(valor1 As Integer, valor2 As Integer) As Date
        valor1 = Now.Hour
        valor2 = Now.Minute

        Return valor1 & ":" & valor2
    End Function
End Module