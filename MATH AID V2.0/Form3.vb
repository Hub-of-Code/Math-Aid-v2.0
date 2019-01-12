Public Class Form3

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        MsgBox("This software is a product of BTC CORP Community. Members of the team are; Edinyanga Ottoho (CEO/Software Manager), Victory Zibril (Asst. CEO/Software Informant) and Imikan Umoinyang (Secretary/Information Manager)", MsgBoxStyle.Information, "ABOUT US")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next ctl
        ListBox1.Items.Clear()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        MsgBox("Provide the values of the variable and it solves for you. This software uses Quadratic formula method. Thanks for your cooperation.", MsgBoxStyle.Information, "HELP AND INFO")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If a.Text = "" Then
            a.Text = "1"
            a.ForeColor = Color.White
        End If
        If b.Text = "" Then
            b.Text = "1"
            b.ForeColor = Color.White
        End If
        ListBox1.Items.Add("____________________________________________________________________________________________________")
        ListBox1.Items.Add("Using the Quadratic formula; ")
        Dim bb As String = ope1.Text & b.Text
        Dim bbb As String = (Val(bb) * -1)
        Dim cc As String = ope2.Text & c.Text
        Dim aa As String = a.Text
        If bb.Contains("+") Then
            bb = Val(bb) * -1
            bb = Val(bb) * -1
        Else : bb = Val(bb) * -1
            bb = Val(bb) * -1
        End If
        If cc.Contains("+") Then
            cc = Val(cc) * -1
            cc = Val(cc) * -1
        Else : cc = Val(cc) * -1
            cc = "-" & cc
        End If
        ListBox1.Items.Add("  x = -b +- SQRT(b^2 - 4ac) / 2a")
        ListBox1.Items.Add("  " & x.Text & " = " & bbb & "+- SQRT((" & bb & ") ^2" & " - 4 * " & aa & " * " & cc & ") / " & "2 * " & aa)
        ListBox1.Items.Add("  " & x.Text & " = " & bbb & " +- SQRT (" & (Val(bb) ^ 2) & " - " & "(" & (Val(aa) * Val(cc) * 4) & ")) / " & (Val(aa) * 2))
        ListBox1.Items.Add("  " & x.Text & " = " & bbb & " +- SQRT (" & ((Val(bb) ^ 2)) - ((Val(aa) * Val(cc) * 4)) & ") / " & (Val(aa) * 2))
        Dim o As String = ((Val(bb) ^ 2)) - ((Val(aa) * Val(cc) * 4))
        Dim p As String = (Val(aa) * 2)
        ListBox1.Items.Add("  " & x.Text & " = " & "(" & bbb & " +- " & CStr(Math.Sqrt(Val(o))) & ")" & " / " & p)
        ListBox1.Items.Add("Either " & x.Text & " = " & "(" & bbb & " + " & CStr(Math.Sqrt(Val(o))) & ")" & " / " & p & " Or " & x.Text & " = " & "(" & bbb & " - " & CStr(Math.Sqrt(Val(o))) & ")" & " / " & p)
        Dim h As String = (Val(bbb) + CStr(Math.Sqrt(Val(o))))
        Dim i As String = (Val(bbb) - CStr(Math.Sqrt(Val(o))))
        ListBox1.Items.Add("  " & x.Text & " = " & h & " / " & p & " Or " & x.Text & " = " & i & " / " & p)
        ListBox1.Items.Add("  " & x.Text & " = " & Val(h) / Val(p) & " Or " & x.Text & " = " & Val(i) / Val(p))
        ListBox1.Items.Add("Therefore; " & x.Text & " = " & Val(h) / Val(p) & " Or " & x.Text & " = " & Val(i) / Val(p))
    End Sub

    Private Sub b_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b.TextChanged
        b.ForeColor = Color.Black
    End Sub
    Private Sub a_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a.TextChanged
        a.ForeColor = Color.Black
    End Sub
End Class