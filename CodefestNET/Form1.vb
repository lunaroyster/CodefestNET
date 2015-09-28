Public Class Form1

    Dim CurrentOutput As String
    Dim asciiart As String = My.Resources.asciiArt
    Dim S_Intro As String = " Welcome to Codefest 2015"

#Region "FORM CONTROLS"

    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Me.Close()
    End Sub

    Private Sub Bmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

#End Region

#Region "BASIC CONSOLE CONTROLS"

    ''' <summary>
    ''' Pretty obvious.
    ''' </summary>
    ''' <remarks>Yeah Yeah I know. Reinventing the wheel.</remarks>
    ''' 

    Private Sub ConsoleUpdate(ByVal rewrite As Boolean)

        Console.Text = CurrentOutput

    End Sub

    Private Sub cls()
        CurrentOutput = Nothing
        ConsoleUpdate(True)
    End Sub

    Private Sub Writeline(ByVal input As String)
        For Each c As Char In input
            Console.Text += c
            My.Computer.Audio.Play(My.Resources.ping, AudioPlayMode.Background)
            Threading.Thread.Sleep(5)
            Application.DoEvents()
        Next
        'Console.Focus()
        Console.Show()
    End Sub

#End Region




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Deb1.Click
        Main()
    End Sub

#Region "EXECUTION"

    Private Sub Main()
        Writeline(asciiart)
        Writeline(S_Intro)
        Select Case AwaitChoice()
            Case 1
            Case 2
            Case 3
        End Select
    End Sub
    Private Function AwaitChoice() As Byte


    End Function

#End Region

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        cls()
    End Sub
End Class
