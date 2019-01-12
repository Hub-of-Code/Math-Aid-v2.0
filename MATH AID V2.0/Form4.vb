Public Class Form4

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        MsgBox("This software is a product of BTC CORP Community. Members of the team are; Edinyanga Ottoho (CEO/Software Manager), Victory Zibril (Asst. CEO/Software Informant) and Imikan Umoinyang (Secretary/Information Manager)", MsgBoxStyle.Information, "ABOUT US")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next ctl
        ListBox1.Items.Clear()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        MsgBox("Input any two values; Hypotenuse, opposite or adjacent into the appropriate boxes. Do not leave up to two boxes blank. Thanks for your cooperation", MsgBoxStyle.Information, "HELP AND INFO")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If hyp.Text = "" Then
            If opp.Text <> "" Then
                If adj.Text <> "" Then
                    ListBox1.Items.Add("______________________________________________________________________________________________")
                    ListBox1.Items.Add("Given Opposite (O) = " & opp.Text & ", Adjacent (A) =" & adj.Text & " and Hypotenuse (H) = ?")
                    ListBox1.Items.Add("Using Pythagoras Theorem;")
                    ListBox1.Items.Add("         H^2 = O^2 + A^2")
                    ListBox1.Items.Add("         H^2 = (" & opp.Text & ")^2 + (" & adj.Text & ")^2")
                    ListBox1.Items.Add("         H^2 = " & (Val(opp.Text) ^ 2) & " + " & (Val(adj.Text) ^ 2))
                    Dim x As Integer = (Val(opp.Text) ^ 2) + (Val(adj.Text) ^ 2)
                    ListBox1.Items.Add("         H^2 = " & x)
                    ListBox1.Items.Add("           H = SQRT (" & x & ")")
                    ListBox1.Items.Add("           H = " & CStr(Math.Sqrt(Val(x))))
                    ListBox1.Items.Add("Therefore; Hypotenuse (H) = " & CStr(Math.Sqrt(Val(x))))
                    Dim y As Integer = CStr(Math.Sqrt(Val(x)))
                    hyp.Text = CStr(Math.Round(y, 4))
                End If
            End If
        End If
        If opp.Text = "" Then
            If hyp.Text <> "" Then
                If adj.Text <> "" Then
                    ListBox1.Items.Add("______________________________________________________________________________________________")
                    ListBox1.Items.Add("Given Hypotenuse (H) = " & hyp.Text & ", Adjacent (A) =" & adj.Text & " and Opposite (O) = ?")
                    ListBox1.Items.Add("Using Pythagoras Theorem;")
                    ListBox1.Items.Add("         O^2 = H^2 - A^2")
                    ListBox1.Items.Add("         O^2 = (" & hyp.Text & ")^2 - (" & adj.Text & ")^2")
                    ListBox1.Items.Add("         O^2 = " & (Val(hyp.Text) ^ 2) & " - " & (Val(adj.Text) ^ 2))
                    Dim x As Integer = (Val(hyp.Text) ^ 2) - (Val(adj.Text) ^ 2)
                    ListBox1.Items.Add("         O^2 = " & x)
                    ListBox1.Items.Add("           O = SQRT (" & x & ")")
                    ListBox1.Items.Add("           O = " & CStr(Math.Sqrt(Val(x))))
                    ListBox1.Items.Add("Therefore; Opposite (O) = " & CStr(Math.Sqrt(Val(x))))
                    Dim y As Integer = CStr(Math.Sqrt(Val(x)))
                    opp.Text = CStr(Math.Round(y, 4))
                End If
            End If
        End If
        If adj.Text = "" Then
            If hyp.Text <> "" Then
                If opp.Text <> "" Then
                    ListBox1.Items.Add("______________________________________________________________________________________________")
                    ListBox1.Items.Add("Given Hypotenuse (H) = " & hyp.Text & ", Opposite (O) =" & opp.Text & " and Adjacent (A) = ?")
                    ListBox1.Items.Add("Using Pythagoras Theorem;")
                    ListBox1.Items.Add("         A^2 = H^2 - O^2")
                    ListBox1.Items.Add("         A^2 = (" & hyp.Text & ")^2 - (" & opp.Text & ")^2")
                    ListBox1.Items.Add("         A^2 = " & (Val(hyp.Text) ^ 2) & " - " & (Val(opp.Text) ^ 2))
                    Dim x As Integer = (Val(hyp.Text) ^ 2) - (Val(opp.Text) ^ 2)
                    ListBox1.Items.Add("         A^2 = " & x)
                    ListBox1.Items.Add("           A = SQRT (" & x & ")")
                    ListBox1.Items.Add("           A = " & CStr(Math.Sqrt(Val(x))))
                    ListBox1.Items.Add("Therefore; Adjacent (A) = " & CStr(Math.Sqrt(Val(x))))
                    Dim y As Integer = CStr(Math.Sqrt(Val(x)))
                    adj.Text = CStr(Math.Round(y, 4))
                End If
            End If
        End If
    End Sub
End Class