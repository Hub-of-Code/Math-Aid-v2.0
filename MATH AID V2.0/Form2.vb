Public Class Form2

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
        MsgBox("Input the variables the in the appropriate boxes for the first and second equation in form of ax + by = c and it solves it accordingly for you. Thanks for your cooperation.", MsgBoxStyle.Information, "HELP AND INFO")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If val1.Text = "" Then
            val1.Text = "1"
            val1.ForeColor = Color.White
        End If
        If bal1.Text = "" Then
            bal1.Text = "1"
            bal1.ForeColor = Color.White
        End If
        If val4.Text = "" Then
            val4.Text = "1"
            val4.ForeColor = Color.White
        End If
        If bal4.Text = "" Then
            bal4.Text = "1"
            bal4.ForeColor = Color.White
        End If
        If val1.Text = bal1.Text Then
            If val4.Text <> bal4.Text Then
                ListBox1.Items.Add("____________________________________________________________________________________________")
                ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val3.Text & " " & val4.Text & val5.Text & " " & val6.Text & " " & val7.Text & " -------- (1)")
                ListBox1.Items.Add("       " & bal1.Text & bal2.Text & " " & bal3.Text & " " & bal4.Text & bal5.Text & " " & bal6.Text & " " & bal7.Text & " -------- (2)")
                Dim x As String = Val(bal1.Text) - Val(val1.Text)
                Dim y1 As String = val3.Text & val4.Text
                Dim y2 As String = bal3.Text & bal4.Text
                Dim y As String = (Val(y2) - Val(y1))
                Dim z As String = (Val(bal7.Text) - Val(val7.Text))
                If y.Contains("-") Then
                    y = (Val(y) * -1)
                    y = "- " & y
                Else : y = "+ " & y
                End If
                ListBox1.Items.Add("Subtract Equation (1) from Equation (2)")
                ListBox1.Items.Add("       " & x & " " & y & val5.Text & " " & val6.Text & " " & z)
                ListBox1.Items.Add("       " & val5.Text & " " & val6.Text & " " & z & " / " & Val(y))
                ListBox1.Items.Add("       " & val5.Text & " " & val6.Text & " " & (Val(z) / Val(y)))
                ListBox1.Items.Add("Substitute " & val5.Text & " " & val6.Text & " " & (Val(z) / Val(y)) & " into Equation (1)")
                Dim t As String = (Val(z) / Val(y))
                ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val3.Text & " " & val4.Text & val5.Text & " " & val6.Text & " " & val7.Text)
                ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val3.Text & " " & val4.Text & " (" & t & ") " & val6.Text & " " & val7.Text)
                Dim u As String = Val(y1) * Val(t)
                If u.Contains("-") Then
                    u = (Val(u) * -1)
                    u = "- " & u
                Else : u = "+ " & u
                End If
                ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & u & " " & val6.Text & " " & val7.Text)
                If u.Contains("-") Then
                    u = (Val(u) * -1)
                    u = "+ " & u
                Else : u = (Val(u) * -1)
                    u = (Val(u) * -1)
                    u = "- " & u
                End If
                ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val6.Text & " " & val7.Text & " " & u)
                ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val6.Text & " " & (Val(val7.Text) + Val(u)))
                Dim s As String = Val(val7.Text) + Val(u)
                ListBox1.Items.Add("       " & val2.Text & " " & val6.Text & " " & s & " / " & Val(val1.Text))
                ListBox1.Items.Add("       " & val2.Text & " " & val6.Text & " " & Val(s) / Val(val1.Text))
                ListBox1.Items.Add("Therefore; " & val5.Text & " " & val6.Text & " " & (Val(z) / Val(y)))
                ListBox1.Items.Add("       and " & val2.Text & " " & val6.Text & " " & Val(s) / Val(val1.Text))
            End If
        End If
        If val1.Text = bal1.Text Then
            If val4.Text = bal4.Text Then
                If val3.Text <> bal3.Text Then
                    ListBox1.Items.Add("____________________________________________________________________________________________")
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val3.Text & " " & val4.Text & val5.Text & " " & val6.Text & " " & val7.Text & " -------- (1)")
                    ListBox1.Items.Add("       " & bal1.Text & bal2.Text & " " & bal3.Text & " " & bal4.Text & bal5.Text & " " & bal6.Text & " " & bal7.Text & " -------- (2)")
                    Dim x As String = Val(bal1.Text) - Val(val1.Text)
                    Dim y1 As String = val3.Text & val4.Text
                    Dim y2 As String = bal3.Text & bal4.Text
                    Dim y As String = (Val(y2) - Val(y1))
                    Dim z As String = (Val(bal7.Text) - Val(val7.Text))
                    If y.Contains("-") Then
                        y = (Val(y) * -1)
                        y = "- " & y
                    Else : y = "+ " & y
                    End If
                    ListBox1.Items.Add("Subtract Equation (1) from Equation (2)")
                    ListBox1.Items.Add("       " & x & " " & y & val5.Text & " " & val6.Text & " " & z)
                    ListBox1.Items.Add("       " & val5.Text & " " & val6.Text & " " & z & " / " & Val(y))
                    ListBox1.Items.Add("       " & val5.Text & " " & val6.Text & " " & (Val(z) / Val(y)))
                    ListBox1.Items.Add("Substitute " & val5.Text & " " & val6.Text & " " & (Val(z) / Val(y)) & " into Equation (1)")
                    Dim t As String = (Val(z) / Val(y))
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val3.Text & " " & val4.Text & val5.Text & " " & val6.Text & " " & val7.Text)
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val3.Text & " " & val4.Text & " (" & t & ") " & val6.Text & " " & val7.Text)
                    Dim u As String = Val(y1) * Val(t)
                    If u.Contains("-") Then
                        u = (Val(u) * -1)
                        u = "- " & u
                    Else : u = "+ " & u
                    End If
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & u & " " & val6.Text & " " & val7.Text)
                    If u.Contains("-") Then
                        u = (Val(u) * -1)
                        u = "+ " & u
                    Else : u = (Val(u) * -1)
                        u = (Val(u) * -1)
                        u = "- " & u
                    End If
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val6.Text & " " & val7.Text & " " & u)
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val6.Text & " " & (Val(val7.Text) + Val(u)))
                    Dim s As String = Val(val7.Text) + Val(u)
                    ListBox1.Items.Add("       " & val2.Text & " " & val6.Text & " " & s & " / " & Val(val1.Text))
                    ListBox1.Items.Add("       " & val2.Text & " " & val6.Text & " " & Val(s) / Val(val1.Text))
                    ListBox1.Items.Add("Therefore; " & val5.Text & " " & val6.Text & " " & (Val(z) / Val(y)))
                    ListBox1.Items.Add("       and " & val2.Text & " " & val6.Text & " " & Val(s) / Val(val1.Text))
                End If
            End If
        End If
        If val3.Text = bal3.Text Then
            If val1.Text <> bal1.Text Then
                If val4.Text = bal4.Text Then
                    ListBox1.Items.Add("_________________________________________________________________________________________")
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val3.Text & " " & val4.Text & val5.Text & " " & val6.Text & " " & val7.Text & " -------- (1)")
                    ListBox1.Items.Add("       " & bal1.Text & bal2.Text & " " & bal3.Text & " " & bal4.Text & bal5.Text & " " & bal6.Text & " " & bal7.Text & " -------- (2)")
                    Dim x As String = Val(bal1.Text) - Val(val1.Text)
                    Dim y1 As String = val3.Text & val4.Text
                    Dim y2 As String = bal3.Text & bal4.Text
                    Dim y As String = Val(y2) - Val(y1)
                    Dim z As String = Val(bal7.Text) - Val(val7.Text)
                    If y.Contains("-") Then
                        y = (Val(y) * -1)
                        y = "- " & y
                    Else : y = "+ " & y
                    End If
                    ListBox1.Items.Add("Subtract Equation (1) from Equation (2)")
                    ListBox1.Items.Add("       " & x & val2.Text & " " & y & " " & val6.Text & " " & z)
                    ListBox1.Items.Add("       " & val2.Text & " " & val6.Text & " " & z & " / " & Val(x))
                    ListBox1.Items.Add("       " & val2.Text & " " & val6.Text & " " & (Val(z) / Val(x)))
                    ListBox1.Items.Add("Substitute " & val2.Text & " " & val6.Text & " " & (Val(z) / Val(x)) & " into Equation (1)")
                    Dim u As String = (Val(z) / Val(x))
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val3.Text & " " & val4.Text & val5.Text & " " & val6.Text & " " & val7.Text)
                    ListBox1.Items.Add("       " & val1.Text & " (" & u & ") " & val3.Text & " " & val4.Text & val5.Text & " " & val6.Text & " " & val7.Text)
                    Dim s As String = Val(val1.Text) * Val(u)
                    Dim s1 As String = val3.Text & val4.Text
                    If s1.Contains("-") Then
                        s1 = s1
                    Else : s1 = Val(s1) * -1
                        s1 = Val(s1) * -1
                    End If
                    ListBox1.Items.Add("       " & s & " " & val3.Text & " " & val4.Text & val5.Text & " " & val6.Text & " " & val7.Text)
                    If s.Contains("-") Then
                        s = Val(s) * -1
                        s = "+ " & s
                    Else : s = Val(s) * -1
                        s = Val(s) * -1
                        s = "- " & s
                    End If
                    ListBox1.Items.Add("       " & s1 & val5.Text & " " & val6.Text & " " & val7.Text & " " & s)
                    ListBox1.Items.Add("       " & s1 & val5.Text & " " & val6.Text & " " & Val(val7.Text) + Val(s))
                    Dim o As String = Val(val7.Text) + Val(s)
                    If s1.Contains("-") Then
                        s1 = Val(s1) * -1
                        s1 = "- " & s1
                    Else : s1 = s1
                    End If
                    ListBox1.Items.Add("       " & val5.Text & " " & val6.Text & " " & " " & o & " / " & Val(s1))
                    ListBox1.Items.Add("       " & val5.Text & " " & val6.Text & " " & Val(o) / Val(s1))
                    ListBox1.Items.Add("Therefore; " & val2.Text & " " & val6.Text & " " & (Val(z) / Val(x)))
                    ListBox1.Items.Add("       and " & val5.Text & " " & val6.Text & " " & Val(o) / Val(s1))
                End If
            End If
        End If
        If val1.Text <> bal1.Text Then
            If val4.Text <> bal4.Text Then
                If val3.Text <> bal3.Text Then
                    ListBox1.Items.Add("__________________________________________________________________________")
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val3.Text & " " & val4.Text & val5.Text & " " & val6.Text & " " & val7.Text & " -------- (1)")
                    ListBox1.Items.Add("       " & bal1.Text & bal2.Text & " " & bal3.Text & " " & bal4.Text & bal5.Text & " " & bal6.Text & " " & bal7.Text & " -------- (2)")
                    ListBox1.Items.Add("Multiply Equation (1) by " & bal1.Text & " and Equation (2) by " & val1.Text)
                    Dim x1 As String = val3.Text & val4.Text
                    Dim y1 As String = bal3.Text & bal4.Text
                    Dim x As String = Val(x1) * Val(bal1.Text)
                    Dim y As String = Val(y1) * Val(val1.Text)
                    If x.Contains("-") Then
                        x = Val(x) * -1
                        x = "- " & x
                    Else : x = "+ " & x
                    End If
                    If y.Contains("-") Then
                        y = Val(y) * -1
                        y = "- " & y
                    Else : y = "+ " & y
                    End If
                    ListBox1.Items.Add("       " & (Val(val1.Text) * Val(bal1.Text)) & val2.Text & " " & x & val5.Text & " " & val6.Text & " " & (Val(val7.Text) * Val(bal1.Text)) & " -------- (3)")
                    ListBox1.Items.Add("       " & (Val(bal1.Text) * Val(val1.Text)) & bal2.Text & " " & y & bal5.Text & " " & val6.Text & " " & (Val(bal7.Text) * Val(val1.Text)) & " -------- (4)")
                    ListBox1.Items.Add("Subtract Equation (1) from Equation (2)")
                    Dim xx As String = (Val(val1.Text) * Val(bal1.Text))
                    Dim yy As String = (Val(bal1.Text) * Val(val1.Text))
                    Dim xxx As String = (Val(val7.Text) * Val(bal1.Text))
                    Dim yyy As String = (Val(bal7.Text) * Val(val1.Text))
                    Dim z1 As String = Val(yy) - Val(xx)
                    Dim z2 As String = Val(y) - Val(x)
                    Dim z3 As String = Val(yyy) - Val(xxx)
                    If z2.Contains("-") Then
                        z2 = Val(z2) * -1
                        z2 = "- " & z2
                    Else : z2 = "+ " & z2
                    End If
                    ListBox1.Items.Add("       " & z1 & " " & z2 & val5.Text & " " & val6.Text & " " & z3)
                    ListBox1.Items.Add("       " & val5.Text & " " & val6.Text & " " & z3 & " / " & Val(z2))
                    ListBox1.Items.Add("       " & val5.Text & " " & val6.Text & " " & Val(z3) / Val(z2))
                    ListBox1.Items.Add("Substitute " & val5.Text & " " & val6.Text & " " & Val(z3) / Val(z2) & " into Equation (1)")
                    Dim u As String = Val(z3) / Val(z2)
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val3.Text & " " & val4.Text & val5.Text & " " & val6.Text & " " & val7.Text)
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val3.Text & " " & val4.Text & " (" & u & ") " & val6.Text & " " & val7.Text)
                    Dim t As String = val3.Text & val4.Text
                    Dim o As String = Val(t) * Val(u)
                    If o.Contains("-") Then
                        o = Val(o) * -1
                        o = "- " & o
                    Else : o = "+ " & o
                    End If
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & o & " " & val6.Text & " " & val7.Text)
                    If o.Contains("-") Then
                        o = Val(o) * -1
                        o = "+ " & o
                    Else : o = Val(o) * -1
                        o = Val(o) * -1
                        o = "- " & o
                    End If
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val6.Text & " " & val7.Text & " " & o)
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val6.Text & " " & (Val(val7.Text) + Val(o)))
                    Dim l As String = (Val(val7.Text) + Val(o))
                    ListBox1.Items.Add("       " & val2.Text & " " & val6.Text & " " & l & " / " & Val(val1.Text))
                    ListBox1.Items.Add("       " & val2.Text & " " & val6.Text & " " & (Val(l) / Val(val1.Text)))
                    ListBox1.Items.Add("Therefore; " & val5.Text & " " & val6.Text & " " & Val(z3) / Val(z2))
                    ListBox1.Items.Add("       and " & val2.Text & " " & val6.Text & " " & (Val(l) / Val(val1.Text)))
                End If
            End If
        End If
        If val3.Text <> bal3.Text Then
            If val4.Text = bal4.Text Then
                If val1.Text <> bal1.Text Then
                    ListBox1.Items.Add("__________________________________________________________________________")
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val3.Text & " " & val4.Text & val5.Text & " " & val6.Text & " " & val7.Text & " -------- (1)")
                    ListBox1.Items.Add("       " & bal1.Text & bal2.Text & " " & bal3.Text & " " & bal4.Text & bal5.Text & " " & bal6.Text & " " & bal7.Text & " -------- (2)")
                    ListBox1.Items.Add("Multiply Equation (1) by " & bal1.Text & " and Equation (2) by " & val1.Text)
                    Dim x1 As String = val3.Text & val4.Text
                    Dim y1 As String = bal3.Text & bal4.Text
                    Dim x As String = Val(x1) * Val(bal1.Text)
                    Dim y As String = Val(y1) * Val(val1.Text)
                    If x.Contains("-") Then
                        x = Val(x) * -1
                        x = "- " & x
                    Else : x = "+ " & x
                    End If
                    If y.Contains("-") Then
                        y = Val(y) * -1
                        y = "- " & y
                    Else : y = "+ " & y
                    End If
                    ListBox1.Items.Add("       " & (Val(val1.Text) * Val(bal1.Text)) & val2.Text & " " & x & val5.Text & " " & val6.Text & " " & (Val(val7.Text) * Val(bal1.Text)) & " -------- (3)")
                    ListBox1.Items.Add("       " & (Val(bal1.Text) * Val(val1.Text)) & bal2.Text & " " & y & bal5.Text & " " & val6.Text & " " & (Val(bal7.Text) * Val(val1.Text)) & " -------- (4)")
                    ListBox1.Items.Add("Subtract Equation (1) from Equation (2)")
                    Dim xx As String = (Val(val1.Text) * Val(bal1.Text))
                    Dim yy As String = (Val(bal1.Text) * Val(val1.Text))
                    Dim xxx As String = (Val(val7.Text) * Val(bal1.Text))
                    Dim yyy As String = (Val(bal7.Text) * Val(val1.Text))
                    Dim z1 As String = Val(yy) - Val(xx)
                    Dim z2 As String = Val(y) - Val(x)
                    Dim z3 As String = Val(yyy) - Val(xxx)
                    If z2.Contains("-") Then
                        z2 = Val(z2) * -1
                        z2 = "- " & z2
                    Else : z2 = "+ " & z2
                    End If
                    ListBox1.Items.Add("       " & z1 & " " & z2 & val5.Text & " " & val6.Text & " " & z3)
                    ListBox1.Items.Add("       " & val5.Text & " " & val6.Text & " " & z3 & " / " & Val(z2))
                    ListBox1.Items.Add("       " & val5.Text & " " & val6.Text & " " & Val(z3) / Val(z2))
                    ListBox1.Items.Add("Substitute " & val5.Text & " " & val6.Text & " " & Val(z3) / Val(z2) & " into Equation (1)")
                    Dim u As String = Val(z3) / Val(z2)
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val3.Text & " " & val4.Text & val5.Text & " " & val6.Text & " " & val7.Text)
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val3.Text & " " & val4.Text & " (" & u & ") " & val6.Text & " " & val7.Text)
                    Dim t As String = val3.Text & val4.Text
                    Dim o As String = Val(t) * Val(u)
                    If o.Contains("-") Then
                        o = Val(o) * -1
                        o = "- " & o
                    Else : o = "+ " & o
                    End If
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & o & " " & val6.Text & " " & val7.Text)
                    If o.Contains("-") Then
                        o = Val(o) * -1
                        o = "+ " & o
                    Else : o = Val(o) * -1
                        o = Val(o) * -1
                        o = "- " & o
                    End If
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val6.Text & " " & val7.Text & " " & o)
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val6.Text & " " & (Val(val7.Text) + Val(o)))
                    Dim l As String = (Val(val7.Text) + Val(o))
                    ListBox1.Items.Add("       " & val2.Text & " " & val6.Text & " " & l & " / " & val1.Text)
                    ListBox1.Items.Add("       " & val2.Text & " " & val6.Text & " " & (Val(l) / Val(val1.Text)))
                    ListBox1.Items.Add("Therefore; " & val5.Text & " " & val6.Text & " " & Val(z3) / Val(z2))
                    ListBox1.Items.Add("       and " & val2.Text & " " & val6.Text & " " & (Val(l) / Val(val1.Text)))
                End If
            End If
        End If
        If val1.Text <> bal1.Text Then
            If val4.Text <> bal4.Text Then
                If val3.Text = bal3.Text Then
                    ListBox1.Items.Add("__________________________________________________________________________")
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val3.Text & " " & val4.Text & val5.Text & " " & val6.Text & " " & val7.Text & " -------- (1)")
                    ListBox1.Items.Add("       " & bal1.Text & bal2.Text & " " & bal3.Text & " " & bal4.Text & bal5.Text & " " & bal6.Text & " " & bal7.Text & " -------- (2)")
                    ListBox1.Items.Add("Multiply Equation (1) by " & bal1.Text & " and Equation (2) by " & val1.Text)
                    Dim x1 As String = val3.Text & val4.Text
                    Dim y1 As String = bal3.Text & bal4.Text
                    Dim x As String = Val(x1) * Val(bal1.Text)
                    Dim y As String = Val(y1) * Val(val1.Text)
                    If x.Contains("-") Then
                        x = Val(x) * -1
                        x = "- " & x
                    Else : x = "+ " & x
                    End If
                    If y.Contains("-") Then
                        y = Val(y) * -1
                        y = "- " & y
                    Else : y = "+ " & y
                    End If
                    ListBox1.Items.Add("       " & (Val(val1.Text) * Val(bal1.Text)) & val2.Text & " " & x & val5.Text & " " & val6.Text & " " & (Val(val7.Text) * Val(bal1.Text)) & " -------- (3)")
                    ListBox1.Items.Add("       " & (Val(bal1.Text) * Val(val1.Text)) & bal2.Text & " " & y & bal5.Text & " " & val6.Text & " " & (Val(bal7.Text) * Val(val1.Text)) & " -------- (4)")
                    ListBox1.Items.Add("Subtract Equation (1) from Equation (2)")
                    Dim xx As String = (Val(val1.Text) * Val(bal1.Text))
                    Dim yy As String = (Val(bal1.Text) * Val(val1.Text))
                    Dim xxx As String = (Val(val7.Text) * Val(bal1.Text))
                    Dim yyy As String = (Val(bal7.Text) * Val(val1.Text))
                    Dim z1 As String = Val(yy) - Val(xx)
                    Dim z2 As String = Val(y) - Val(x)
                    Dim z3 As String = Val(yyy) - Val(xxx)
                    If z2.Contains("-") Then
                        z2 = Val(z2) * -1
                        z2 = "- " & z2
                    Else : z2 = "+ " & z2
                    End If
                    ListBox1.Items.Add("       " & z1 & " " & z2 & val5.Text & " " & val6.Text & " " & z3)
                    ListBox1.Items.Add("       " & val5.Text & " " & val6.Text & " " & z3 & " / " & Val(z2))
                    ListBox1.Items.Add("       " & val5.Text & " " & val6.Text & " " & Val(z3) / Val(z2))
                    ListBox1.Items.Add("Substitute " & val5.Text & " " & val6.Text & " " & Val(z3) / Val(z2) & " into Equation (1)")
                    Dim u As String = Val(z3) / Val(z2)
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val3.Text & " " & val4.Text & val5.Text & " " & val6.Text & " " & val7.Text)
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val3.Text & " " & val4.Text & " (" & u & ") " & val6.Text & " " & val7.Text)
                    Dim t As String = val3.Text & val4.Text
                    Dim o As String = Val(t) * Val(u)
                    If o.Contains("-") Then
                        o = Val(o) * -1
                        o = "- " & o
                    Else : o = "+ " & o
                    End If
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & o & " " & val6.Text & " " & val7.Text)
                    If o.Contains("-") Then
                        o = Val(o) * -1
                        o = "+ " & o
                    Else : o = Val(o) * -1
                        o = Val(o) * -1
                        o = "- " & o
                    End If
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val6.Text & " " & val7.Text & " " & o)
                    ListBox1.Items.Add("       " & val1.Text & val2.Text & " " & val6.Text & " " & (Val(val7.Text) + Val(o)))
                    Dim l As String = (Val(val7.Text) + Val(o))
                    ListBox1.Items.Add("       " & val2.Text & " " & val6.Text & " " & l & " / " & Val(val1.Text))
                    ListBox1.Items.Add("       " & val2.Text & " " & val6.Text & " " & (Val(l) / Val(val1.Text)))
                    ListBox1.Items.Add("Therefore; " & val5.Text & " " & val6.Text & " " & Val(z3) / Val(z2))
                    ListBox1.Items.Add("       and " & val2.Text & " " & val6.Text & " " & (Val(l) / Val(val1.Text)))
                End If
            End If
        End If
    End Sub

    Private Sub bal4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bal4.TextChanged
        bal4.ForeColor = Color.Black
    End Sub

    Private Sub val4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles val4.TextChanged
        val4.ForeColor = Color.Black
    End Sub

    Private Sub bal1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bal1.TextChanged
        bal1.ForeColor = Color.Black
    End Sub

    Private Sub val1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles val1.TextChanged
        val1.ForeColor = Color.Black
    End Sub

End Class