Public Class Form6

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
        MsgBox("Provide the values for any three Variables in the appropriate boxes and the last will be solved for you. Don't leave up to two boxes blank. Thanks for your cooperation", MsgBoxStyle.Information, "HELP AND INFO")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If I.Text = "" Then
            If P.Text <> "" Then
                If R.Text <> "" Then
                    If T.Text <> "" Then
                        ListBox1.Items.Add("________________________________________________________________________________________________")
                        ListBox1.Items.Add("Given Principal (P) = N" & P.Text & ", Rate (R) = " & R.Text & "%, Time (T) = " & T.Text & " years and Interest (I) = ?")
                        ListBox1.Items.Add("Using I = PTR/100")
                        ListBox1.Items.Add("   I = (" & P.Text & " * " & T.Text & " * " & R.Text & ") / 100")
                        Dim x1 As Integer = Val(P.Text) * Val(T.Text) * Val(R.Text)
                        ListBox1.Items.Add("   I = " & x1 & " / 100")
                        ListBox1.Items.Add("   I = " & (Val(P.Text) * Val(T.Text) * Val(R.Text)) / 100)
                        ListBox1.Items.Add("Therefore; Interest (I) = N" & (Val(P.Text) * Val(T.Text) * Val(R.Text)) / 100)
                        Dim x As Integer = (Val(P.Text) * Val(T.Text) * Val(R.Text)) / 100
                        I.Text = CStr(Math.Round(Val(x), 4))
                    End If
                End If
            End If
        End If
        If P.Text = "" Then
            If I.Text <> "" Then
                If R.Text <> "" Then
                    If T.Text <> "" Then
                        ListBox1.Items.Add("________________________________________________________________________________________________")
                        ListBox1.Items.Add("Given Interest (I) = N" & I.Text & ", Rate (R) = " & R.Text & "%, Time (T) = " & T.Text & " years and Principal (P) = ?")
                        ListBox1.Items.Add("Using P = 100I/TR")
                        ListBox1.Items.Add("   P = 100 * " & I.Text & " / " & "(" & T.Text & " * " & R.Text & ")")
                        Dim x1 As Integer = 100 * Val(I.Text)
                        Dim x2 As Integer = (Val(T.Text) * Val(R.Text))
                        ListBox1.Items.Add("   P = " & x1 & " / " & x2)
                        ListBox1.Items.Add("   P = " & (100 * Val(I.Text)) / (Val(T.Text) * Val(R.Text)))
                        ListBox1.Items.Add("Therefore Principal (P) = N" & (100 * Val(I.Text)) / (Val(T.Text) * Val(R.Text)))
                        Dim x As Integer = (100 * Val(I.Text)) / (Val(T.Text) * Val(R.Text))
                        P.Text = CStr(Math.Round(Val(x), 4))
                    End If
                End If
            End If
        End If
        If R.Text = "" Then
            If P.Text <> "" Then
                If I.Text <> "" Then
                    If T.Text <> "" Then
                        ListBox1.Items.Add("________________________________________________________________________________________________")
                        ListBox1.Items.Add("Given Principal (P) = N" & P.Text & ", Interest (I) = N" & I.Text & ", Time (T) = " & T.Text & " years and Rate (R) = ?")
                        ListBox1.Items.Add("Using R = 100I/PT")
                        ListBox1.Items.Add("   R = 100 * " & I.Text & " / " & "(" & P.Text & " * " & T.Text & ")")
                        Dim x1 As Integer = 100 * Val(I.Text)
                        Dim x2 As Integer = (Val(P.Text) * Val(T.Text))
                        ListBox1.Items.Add("   R = " & x1 & " / " & x2)
                        ListBox1.Items.Add("   R = " & (100 * Val(I.Text)) / (Val(P.Text) * Val(T.Text)))
                        ListBox1.Items.Add("Therefore Rate (R) = " & (100 * Val(I.Text)) / (Val(P.Text) * Val(T.Text)) & "%")
                        Dim x As Integer = (100 * Val(I.Text)) / (Val(P.Text) * Val(T.Text))
                        R.Text = CStr(Math.Round(Val(x), 4))
                    End If
                End If
            End If
        End If
        If T.Text = "" Then
            If P.Text <> "" Then
                If R.Text <> "" Then
                    If I.Text <> "" Then
                        ListBox1.Items.Add("________________________________________________________________________________________________")
                        ListBox1.Items.Add("Given Interest (I) = N" & I.Text & ", Rate (R) = " & R.Text & "%, Principal (P) = N" & P.Text & " and Time (T) = ?")
                        ListBox1.Items.Add("Using T = 100I/PR")
                        ListBox1.Items.Add("   T = 100 * " & I.Text & " / " & "(" & P.Text & " * " & R.Text & ")")
                        Dim x1 As Integer = 100 * Val(I.Text)
                        Dim x2 As Integer = (Val(P.Text) * Val(R.Text))
                        ListBox1.Items.Add("   T = " & x1 & " / " & x2)
                        ListBox1.Items.Add("   T = " & (100 * Val(I.Text)) / (Val(P.Text) * Val(R.Text)))
                        ListBox1.Items.Add("Therefore Time (T) = " & (100 * Val(I.Text)) / (Val(P.Text) * Val(R.Text)) & " years")
                        Dim x As Integer = (100 * Val(I.Text)) / (Val(P.Text) * Val(R.Text))
                        T.Text = CStr(Math.Round(Val(x), 4))
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class