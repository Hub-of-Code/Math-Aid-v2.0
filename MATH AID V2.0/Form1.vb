Public Class Form1
    Dim t As Integer = 1
    Private Sub LOADER_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOADER.Tick
        t = t + 1
        If t = 6 Then
            t = 1
        End If
        If t = 1 Then
            A.BackColor = Color.White
            B.BackColor = Color.GreenYellow
            C.BackColor = Color.GreenYellow
            D.BackColor = Color.GreenYellow
            EE.BackColor = Color.GreenYellow
        End If
        If t = 2 Then
            A.BackColor = Color.GreenYellow
            B.BackColor = Color.White
            C.BackColor = Color.GreenYellow
            D.BackColor = Color.GreenYellow
            EE.BackColor = Color.GreenYellow
        End If
        If t = 3 Then
            A.BackColor = Color.GreenYellow
            B.BackColor = Color.GreenYellow
            C.BackColor = Color.White
            D.BackColor = Color.GreenYellow
            EE.BackColor = Color.GreenYellow
        End If
        If t = 4 Then
            A.BackColor = Color.GreenYellow
            B.BackColor = Color.GreenYellow
            C.BackColor = Color.GreenYellow
            D.BackColor = Color.White
            EE.BackColor = Color.GreenYellow
        End If
        If t = 5 Then
            A.BackColor = Color.GreenYellow
            B.BackColor = Color.GreenYellow
            C.BackColor = Color.GreenYellow
            D.BackColor = Color.GreenYellow
            EE.BackColor = Color.White
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        A.BackColor = Color.White
    End Sub

    Private Sub STOPPER_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STOPPER.Tick
        A.Location = New Point(0, 0)
        A.Size = New Size(0, 0)
        A.Dispose()
        B.Location = New Point(0, 0)
        B.Size = New Size(0, 0)
        B.Dispose()
        C.Location = New Point(0, 0)
        C.Size = New Size(0, 0)
        C.Dispose()
        D.Location = New Point(0, 0)
        D.Size = New Size(0, 0)
        D.Dispose()
        EE.Location = New Point(0, 0)
        EE.Size = New Size(0, 0)
        EE.Dispose()
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Size = New Size(0, 0)
        PictureBox1.Dispose()
        LOADER.Enabled = False
        STOPPER.Enabled = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text.Contains("Simultaneous") Then
            Form2.Show()
        End If
        If ComboBox1.Text.Contains("Quadratic") Then
            Form3.Show()
        End If
        If ComboBox1.Text.Contains("Pythagoras") Then
            Form4.Show()
        End If
        If ComboBox1.Text.Contains("Squares") Then
            Form5.Show()
        End If
        If ComboBox1.Text.Contains("Monetary") Then
            Form6.Show()
        End If
        If ComboBox1.Text.Contains("Variation") Then
            Form7.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        MsgBox("This software is a product of BTC CORP Community. Members of the team are; Edinyanga Ottoho (CEO/Software Manager), Victory Zibril (Asst. CEO/Software Informant) and Imikan Umoinyang (Secretary/Information Manager)", MsgBoxStyle.Information, "ABOUT US")
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        MsgBox("Please endeavour to read the Information from the Help Tab in each packages' Menu bar", MsgBoxStyle.Information, "HELP AND INFO")
    End Sub
End Class

