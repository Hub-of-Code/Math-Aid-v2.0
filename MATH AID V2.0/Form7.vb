Public Class Form7
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        MsgBox("Input the variables and the given values in the boxes provided at the top in form of a = x and b = y in both variations (i.e. either in direct or inverse or both). In the boxes below them, you input any of the variables' value , then click SOLVE button to find the missing corresponding variables in form of ; When a = x, b = ? and vice versa. Thanks for your cooperation", MsgBoxStyle.Information, "HELP AND INFO")
    End Sub
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        MsgBox("This software is a product of BTC CORP Community. Members of the team are; Edinyanga Ottoho (CEO/Software Manager), Victory Zibril (Asst. CEO/Software Informant) and Imikan Umoinyang (Secretary/Information Manager)", MsgBoxStyle.Information, "ABOUT US")
    End Sub

    Private Sub c2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c2.TextChanged
        ee2.Visible = True
        f2.Visible = True
        ff2.Visible = True
        ff2.Text = ", " & c2.Text & " = "
    End Sub

    Private Sub a2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a2.TextChanged
        eee2.Visible = True
        eee2.Text = "When " & a2.Text & " = "
    End Sub

    Private Sub c1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1.TextChanged
        ee1.Visible = True
        f1.Visible = True
        ff1.Visible = True
        ff1.Text = ", " & c1.Text & " = "
    End Sub

    Private Sub a1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a1.TextChanged
        eee1.Visible = True
        eee1.Text = "When " & a1.Text & " = "
    End Sub

    Private Sub CLR3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLR3.Click
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                If ctl.Name.Contains("1") Then
                    ctl.Text = ""
                    ee1.Text = ""
                    f1.Text = ""
                    ee1.Visible = False
                    f1.Visible = False
                    eee1.Visible = False
                    ff1.Visible = False
                End If
            End If
        Next
        Dim cty As Control
        For Each cty In Controls
            If TypeOf cty Is TextBox Then
                If cty.Name.Contains("1") Then
                    cty.Text = ""
                End If
            End If
        Next
        ListBox1.Items.Clear()
    End Sub

    Private Sub CLR33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLR33.Click
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                If ctl.Name.Contains("2") Then
                    ee2.Text = ""
                    f2.Text = ""
                    ctl.Text = ""
                    ee2.Visible = False
                    f2.Visible = False
                    eee2.Visible = False
                    ff2.Visible = False
                End If
            End If
        Next
        Dim cty As Control
        For Each cty In Controls
            If TypeOf cty Is TextBox Then
                If cty.Name.Contains("2") Then
                    cty.Text = ""
                End If
            End If
        Next
        ListBox2.Items.Clear()
    End Sub

    Private Sub SOLV1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SOLV1.Click
        If f1.Text = "" Then
            If ee1.Text <> "" Then
                ListBox1.Items.Add("")
                ListBox1.Items.Add("___________________________________________________________________________")
                ListBox1.Items.Add("Given that " & a1.Text & " varies directly as " & c1.Text & " And when " & a1.Text & " = " & b1.Text & ", " & c1.Text & " = " & d1.Text)
                ListBox1.Items.Add("Add the constant, K to the variation")
                ListBox1.Items.Add("        " & a1.Text & " = K " & c1.Text)
                ListBox1.Items.Add("        " & b1.Text & " = K " & d1.Text)
                ListBox1.Items.Add("        K = " & b1.Text & " / " & d1.Text)
                ListBox1.Items.Add("        K = " & Val(b1.Text) / Val(d1.Text))
                Dim b As String = Val(b1.Text) / Val(d1.Text)
                ListBox1.Items.Add("The equation connecting " & a1.Text & " and " & c1.Text & " is; " & a1.Text & " = " & b & " " & c1.Text)
                ListBox1.Items.Add("When " & a1.Text & " = " & ee1.Text & " and " & c1.Text & " = ?")
                ListBox1.Items.Add("Add the constant once more; ")
                ListBox1.Items.Add("        " & a1.Text & " = K " & c1.Text)
                ListBox1.Items.Add("        " & ee1.Text & " = " & b & " " & c1.Text)
                ListBox1.Items.Add("        " & c1.Text & " =  " & ee1.Text & " / " & b)
                ListBox1.Items.Add("        " & c1.Text & " =  " & Val(ee1.Text) / Val(b))
                Dim x As String = Val(ee1.Text) / Val(b)
                ListBox1.Items.Add("Therefore; When " & a1.Text & " = " & ee1.Text & ", " & c1.Text & " = " & x)

            End If
        End If
        If ee1.Text = "" Then
            If f1.Text <> "" Then
                ListBox1.Items.Add("")
                ListBox1.Items.Add("___________________________________________________________________________")
                ListBox1.Items.Add("Given that " & a1.Text & " varies directly as " & c1.Text & " And when " & a1.Text & " = " & b1.Text & ", " & c1.Text & " = " & d1.Text)
                ListBox1.Items.Add("Add the constant, K to the variation")
                ListBox1.Items.Add("        " & a1.Text & " = K " & c1.Text)
                ListBox1.Items.Add("        " & b1.Text & " = K " & d1.Text)
                ListBox1.Items.Add("        K = " & b1.Text & " / " & d1.Text)
                ListBox1.Items.Add("        K = " & Val(b1.Text) / Val(d1.Text))
                Dim k As String = Val(b1.Text) / Val(d1.Text)
                ListBox1.Items.Add("The equation connecting " & a1.Text & " and =" & c1.Text & " is; " & a1.Text & " = " & k & " " & c1.Text)
                ListBox1.Items.Add("When " & a1.Text & " = ? and " & c1.Text & " = " & f1.Text)
                ListBox1.Items.Add("Add the constant once more; ")
                ListBox1.Items.Add("        " & a1.Text & " = K " & c1.Text)
                ListBox1.Items.Add("        " & a1.Text & " = " & k & " * " & f1.Text)
                ListBox1.Items.Add("        " & a1.Text & " =  " & Val(f1.Text) * Val(k))
                Dim x As String = Val(f1.Text) * Val(k)
                ListBox1.Items.Add("Therefore; When " & c1.Text & " = " & f1.Text & ", " & a1.Text & " = " & x)
            End If
        End If

    End Sub

    Private Sub SOLV2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SOLV2.Click
        If f2.Text = "" Then
            If ee2.Text <> "" Then
                ListBox2.Items.Add("")
                ListBox2.Items.Add("___________________________________________________________________________________________")
                ListBox2.Items.Add("Given that " & a2.Text & " varies inversely as " & c2.Text & " And when " & a2.Text & " = " & b2.Text & ", " & c2.Text & " = " & d2.Text)
                ListBox2.Items.Add("Add the constant, K to the variation")
                ListBox2.Items.Add("        " & a2.Text & " = K" & " * 1 / " & c2.Text)
                ListBox2.Items.Add("        " & b2.Text & " = K " & "/ " & d2.Text)
                ListBox2.Items.Add("Cross Multiply")
                ListBox2.Items.Add("        " & b2.Text & " * " & d2.Text & " = " & "K")
                ListBox2.Items.Add("        K = " & Val(b2.Text) * Val(d2.Text))
                Dim k As String = Val(b2.Text) * Val(d2.Text)
                ListBox2.Items.Add("The equation connecting " & a2.Text & " and " & c2.Text & " is; " & a2.Text & " = " & k & " / " & c2.Text)
                ListBox2.Items.Add("When " & a2.Text & " = " & ee2.Text & " and " & c2.Text & " = ?")
                ListBox2.Items.Add("Add the constant once more; ")
                ListBox2.Items.Add("        " & a2.Text & " = K / " & c2.Text)
                ListBox2.Items.Add("        " & ee2.Text & " = " & k & " / " & c2.Text)
                ListBox2.Items.Add("Cross multiply")
                ListBox2.Items.Add("        " & ee2.Text & " " & c2.Text & " = " & k)
                ListBox2.Items.Add("        " & c2.Text & " = " & k & " / " & ee2.Text)
                ListBox2.Items.Add("        " & c2.Text & " = " & Val(k) / Val(ee2.Text))
                Dim x As String = Val(k) / Val(ee2.Text)
                ListBox2.Items.Add("Therefore; When " & a2.Text & " = " & ee2.Text & ", " & c2.Text & " = " & x)
            End If
        End If
        If ee2.Text = "" Then
            If f2.Text <> "" Then
                ListBox2.Items.Add("")
                ListBox2.Items.Add("___________________________________________________________________________________________")
                ListBox2.Items.Add("Given that " & a2.Text & " varies inversely as " & c2.Text & " And when " & a2.Text & " = " & b2.Text & ", " & c2.Text & " = " & d2.Text)
                ListBox2.Items.Add("Add the constant, K to the variation")
                ListBox2.Items.Add("        " & a2.Text & " = K" & " * 1 / " & c2.Text)
                ListBox2.Items.Add("        " & b2.Text & " = K " & "/ " & d2.Text)
                ListBox2.Items.Add("Cross Multiply")
                ListBox2.Items.Add("        " & b2.Text & " * " & d2.Text & " = " & "K")
                ListBox2.Items.Add("        K = " & Val(b2.Text) * Val(d2.Text))
                Dim k As String = Val(b2.Text) * Val(d2.Text)
                ListBox2.Items.Add("The equation connecting " & a2.Text & " and " & c2.Text & " is; " & a2.Text & " = " & k & " / " & c2.Text)
                ListBox2.Items.Add("When " & a2.Text & " = ? and " & c2.Text & " = " & f2.Text)
                ListBox2.Items.Add("Add the constant once more; ")
                ListBox2.Items.Add("        " & a2.Text & " = K / " & c2.Text)
                ListBox2.Items.Add("        " & a2.Text & " = " & k & " / " & d2.Text)
                ListBox2.Items.Add("        " & a2.Text & " = " & Val(k) / Val(d2.Text))
                Dim x As String = Val(k) / Val(d2.Text)
                ListBox2.Items.Add("Therefore; When " & c2.Text & " = " & f2.Text & ", " & a2.Text & " = " & x)
            End If
        End If
    End Sub
End Class