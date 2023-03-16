Imports System

Module Program


    Class Playera

        Private SAM As Integer
        Private talla As String
        Private tCost(10) As Integer
        Private dCost(10) As Integer
        Private dtotalCostura, cantHilo As Integer
        Private costototal As Integer
        Private costominuto, costohilo As Integer
        Private botones, bordado As Integer
        Private cuello As String
        Private mat(2, 119)


        Public Sub New()
            Console.WriteLine("Playera creada")
            botones = 3
            bordado = 2
            cuello = "polo"
        End Sub


        'Se piden los datos de la playera creada
        Public Sub IngresarDatos()
            Console.WriteLine("¿Cuál es la talla?")
            talla = Console.ReadLine
            Console.WriteLine("¿Cuál es el Costo por minuto?")
            costominuto = Console.ReadLine
            Console.WriteLine("¿Cuál es costo del hilo por metro?")
            costohilo = Console.ReadLine

            For f = 0 To 1
                For c = 0 To 10
                    Console.WriteLine("Ingrese componente:")
                    mat(f, c) = Console.ReadLine()
                    Console.WriteLine("¿Cuál es el Tiempo de la costura " & f)
                    tCost(f) = Console.ReadLine
                Next
            Next


        End Sub

        'Muestra los datos recopilados de la playera creada
        Public Sub MostrarDatos()
            Console.WriteLine("Talla: " & talla)
            Console.WriteLine("Costo por minuto: " & costominuto)
            Console.WriteLine("Costo del hilo: " & costohilo)

            For f = 0 To 1
                For c = 0 To 10
                    Console.Write(mat(f, c))
                    Console.WriteLine("Tiempo de la costura  " & tCost(f))
                Next
            Next
            For f = 0 To 10
                Console.WriteLine("Distancia de la costura  " & dCost(f))
            Next
        End Sub


        Public Function Tiempototal()
            SAM = tCost(0) + tCost(1) + tCost(2) + tCost(3) + tCost(4) + tCost(5) + tCost(6) + tCost(7) + tCost(8) + tCost(9) + tCost(10)
            Return SAM
        End Function
        Public Function dtCostura()
            For f = 0 To 10
                dtotalCostura = dtotalCostura + dCost(f)
            Next
            Return dtotalCostura
        End Function
        Public Function cantidadHilo()
            For f = 0 To 10
                cantHilo = (dCost(f)) * 2 + (dCost(f)) * 2 * 0.05
            Next
            Return cantHilo
        End Function
        Public Function CostoTotalPlayera()
            For f = 0 To 10
                costototal = (dCost(f) * 2) + (dCost(f) * 2 * 0.05) + (tCost(f) * costominuto)
            Next

            Return costototal
        End Function

    End Class

    'Creación de nueva clase "VestidoCoctel"
    Class VestidoCoctel

        Private SAM As Integer
        Private talla As String
        Private tCost(10) As Integer
        Private dCost(10) As Integer
        Private dtotalCostura, cantHilo As Integer
        Private costototal As Integer
        Private costominuto, costohilo As Integer
        Private botones, cierres, aplicaciones As Integer
        Private mat(2, 119)


        Public Sub New()
            Console.WriteLine("Vestido terminado")
            botones = 3
            cierres = 1
            aplicaciones = 5
        End Sub

        'Se piden los datos necesarios del Vestido terminado
        Public Sub IngresarDatos()
            Console.WriteLine("¿Cuál es la talla?")
            talla = Console.ReadLine
            Console.WriteLine("¿Cuál es el Costo por minuto?")
            costominuto = Console.ReadLine
            Console.WriteLine("¿Cuál es costo del hilo por metro?")
            costohilo = Console.ReadLine

            For f = 0 To 1
                For c = 0 To 10
                    Console.WriteLine("Ingrese componente:")
                    mat(f, c) = Console.ReadLine()
                    Console.WriteLine("¿Cuál es el Tiempo de la costura " & f)
                    tCost(f) = Console.ReadLine
                Next
            Next


        End Sub

        'Se muertran los datos ya solicitados
        Public Sub MostrarDatos()
            Console.WriteLine("Talla: " & talla)
            Console.WriteLine("Costo por minuto: " & costominuto)
            Console.WriteLine("Costo del hilo: " & costohilo)

            For f = 0 To 1
                For c = 0 To 10
                    Console.Write(mat(f, c))
                    Console.WriteLine("Tiempo de la costura  " & tCost(f))
                Next
            Next
            For f = 0 To 10
                Console.WriteLine("Distancia de la costura  " & dCost(f))
            Next
        End Sub

        ' Operacion para sacar el tiempo total
        Public Function Tiempototal()
            SAM = tCost(0) + tCost(1) + tCost(2) + tCost(3) + tCost(4) + tCost(5) + tCost(6) + tCost(7) + tCost(8) + tCost(9) + tCost(10)
            Return SAM
        End Function
        Public Function dtCostura()
            For f = 0 To 10
                dtotalCostura = dtotalCostura + dCost(f)
            Next
            Return dtotalCostura
        End Function
        'solucion para la cantidad del hilo
        Public Function cantidadHilo()
            For f = 0 To 10
                cantHilo = (dCost(f)) * 2 + (dCost(f)) * 2 * 0.05
            Next
            Return cantHilo
        End Function
        'Operacion para sacar el costo total del Vestido
        Public Function CostoTotalVestido()
            For f = 0 To 10
                costototal = (dCost(f) * 2) + (dCost(f) * 2 * 0.05) + (tCost(f) * costominuto)
            Next

            Return costototal
        End Function

    End Class

    Sub Main(args As String())



        Dim tfabricacion As Integer
        Dim Costofabricacion As Integer
        Dim mhilonecesarios As Integer

        Dim playera1 As New Playera()

        playera1.IngresarDatos()


        mhilonecesarios = playera1.cantidadHilo()
        tfabricacion = playera1.Tiempototal()
        Costofabricacion = playera1.CostoTotalPlayera()


        Console.WriteLine(" ________Para este lote se obtienen los siguientes datos: ")
        Console.WriteLine("los metros de hilo necesarios son : " & mhilonecesarios)
        Console.WriteLine("El tiempo de fabricación es : " & tfabricacion)
        Console.WriteLine("El costo de fabricación es: " & Costofabricacion)




        Dim tfabricacionVestido As Integer
        Dim CostofabricacionVestido As Integer
        Dim mhilonecesariosVestido As Integer

        Dim Vestido1 As New VestidoCoctel()

        Vestido1.IngresarDatos()


        mhilonecesarios = Vestido1.cantidadHilo()
        tfabricacion = Vestido1.Tiempototal()
        Costofabricacion = Vestido1.CostoTotalVestido()


        Console.WriteLine(" ________Para este lote se obtienen los siguientes datos: ")
        Console.WriteLine("los metros de hilo necesarios son : " & mhilonecesariosVestido)
        Console.WriteLine("El tiempo de fabricación es : " & tfabricacionVestido)
        Console.WriteLine("El costo de fabricación es: " & CostofabricacionVestido)


    End Sub
End Module

