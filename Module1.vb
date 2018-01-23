Module Module1

    Sub Main()

        Dim MemberName As String = ""
        Dim MemberId As Integer = 0

        FileOpen(1, "D:\VB example\members.txt", OpenMode.Append)

        Console.WriteLine("Enter Members name:   ")
        MemberName = Console.ReadLine

        Console.WriteLine("Enter Members Id:  ")
        MemberId = Console.ReadLine

        WriteLine(1, MemberName)
        WriteLine(1, MemberId)

        Console.WriteLine(MemberName & MemberId)



        FileClose(1)

        Console.ReadKey()

    End Sub

End Module
