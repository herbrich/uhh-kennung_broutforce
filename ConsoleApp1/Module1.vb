Module Module1

    Sub Main()
        Console.ForegroundColor = ConsoleColor.Green
        HackUniHamburg()
    End Sub
    Sub HackUniHamburg()
        For id As Integer = 1000 To 9999 Step 1
            Dim kennung = "bxy" & CStr(id)
            WriteUniHamburgLogin(kennung)
            Console.WriteLine(kennung)
        Next
    End Sub
    Sub WriteUniHamburgLogin(ByVal unikennung As String)
        If (unikennung.Length = 7) Then
            My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\uni_logins.tx", unikennung & Environment.NewLine, True)
        End If
    End Sub
End Module
