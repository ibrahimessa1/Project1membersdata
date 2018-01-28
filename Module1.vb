Module Module1

    Sub Main()
        Dim MemberName As String = ""
        Dim MemberId As Integer = 0

        FileOpen(1, "D:\VB example\StudentRecord.txt", OpenMode.Input)

        While Not EOF(1)
            Input(1, MemberName)

            Input(1, MemberId)

            Console.WriteLine("Member Name : " & MemberName)
            Console.WriteLine("Member ID : " & MemberId)

        End While

        FileClose(1)

        Console.ReadKey()





    End Sub

End Module
