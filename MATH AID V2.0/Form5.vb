Public Class Form5

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        MsgBox("This software is a product of BTC CORP Community. Members of the team are; Edinyanga Ottoho (CEO/Software Manager), Victory Zibril (Asst. CEO/Software Informant) and Imikan Umoinyang (Secretary/Information Manager)", MsgBoxStyle.Information, "ABOUT US")
    End Sub

    Private Sub sqrootb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sqrootb.Click
        ListBox1.Items.Add("________________________________________________________________________________________________")
        ListBox1.Items.Add("The square root of " & Val(sqroot.Text) & " is " & CStr(Math.Sqrt(Val(sqroot.Text))))
    End Sub

    Private Sub sqrb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sqrb.Click
        ListBox1.Items.Add("________________________________________________________________________________________________")
        ListBox1.Items.Add("The square of " & Val(sqr.Text) & " is " & CStr(Math.Pow(Val(sqr.Text), 2)))
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next ctl
        ListBox1.Items.Clear()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        MsgBox("Input the value to be squared or to be square rooted into the appropriate boxes. Thank you", MsgBoxStyle.Information, "HELP AND INFO")
    End Sub
End Class