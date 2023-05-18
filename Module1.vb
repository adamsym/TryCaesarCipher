Module Module1

    Sub Main()
        Dim msg As String = ""
        Dim key As Integer = 0

        Console.WriteLine("what is the message?")
        msg = Console.ReadLine
        Console.WriteLine("what is the key?")
        key = Console.ReadLine

        Console.WriteLine(encryption(msg, key))

        Console.ReadLine()

    End Sub

    Function encryption(ByVal msg As String, ByVal key As Integer) As String
        encryption = ""
        Dim mychr As Char = ""
        Dim temp As String = ""

        For index = 1 To Len(msg)
            mychr = Mid(msg, index, 1)
            temp = Chr(Asc(mychr) + key)
            encryption = encryption & temp

        Next index
        Return encryption
    End Function
End Module
