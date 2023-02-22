Imports System

Module Program
    Sub Main(args As String())
        'Declare Array 
        Dim array_sample As Integer()

        'Allocate Array
        array_sample = New Integer() {3, 7, 25}

        'Show values 
        Console.WriteLine(array_sample(0))

        Dim position As Integer

        For position = 0 To array_sample.GetUpperBound(0)
            Console.WriteLine(array_sample(position))
        Next

        Dim position2 As Integer

        For position2 = array_sample.GetUpperBound(0) To array_sample.GetLowerBound(0) Step -1
            Console.WriteLine(array_sample(position2))
        Next

        'Multi-dimensional Array
        Dim array_sample2 As Integer(,)

        'Allocate multi-dimensional array
        array_sample2 = New Integer(,) {{1, 2, 3}, {3, 4, 5}}

        'Show values
        Console.WriteLine("Multi-dimensional array")
        Console.WriteLine(array_sample2(1, 2))

        Dim positionRow As Integer
        Dim positionColumn As Integer

        For positionRow = 0 To array_sample2.GetUpperBound(0)
            For positionColumn = 0 To array_sample2.GetUpperBound(1)
                Console.Write("{0} ", array_sample2(positionRow, positionColumn))
            Next
            Console.WriteLine("")
        Next

        'Unregular
        Dim array_sample3 As Integer()()

        array_sample3 = New Integer(2)() {}

        array_sample3(0) = New Integer() {9, 8, 7}
        array_sample3(1) = New Integer() {3}
        array_sample3(2) = New Integer() {2, 5}

        Dim positionRow2 As Integer
        Dim positionColumn2 As Integer

        Console.WriteLine("Unregular array")
        For positionRow2 = 0 To array_sample3.GetUpperBound(0)
            For positionColumn2 = 0 To array_sample3(positionRow2).GetUpperBound(0)
                Console.Write("{0} ", array_sample3(positionRow2)(positionColumn2))
            Next
            Console.WriteLine("")
        Next

    End Sub
End Module
