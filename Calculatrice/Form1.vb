Public Class Form1
    Dim aaa As Single
    Dim bbb As Single
    Dim signe As String
    Dim ccc As Single

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bt_0_Click(sender As Object, e As EventArgs) Handles bt_0.Click
        If ccc = 0 Then
            If txt_rep.Text = "0" Then
                txt_rep.Text = 0
                ccc = 0
            Else
                txt_rep.Text = txt_rep.Text & 0
                ccc = 0
            End If
        Else
            txt_rep.Text = 0
            ccc = 0
        End If
    End Sub

    Private Sub bt_00_Click(sender As Object, e As EventArgs) Handles bt_00.Click
        If ccc = 0 Then
            If txt_rep.Text = "0" Then
                txt_rep.Text = 0
                ccc = 0
            Else
                txt_rep.Text = txt_rep.Text & "00"
                ccc = 0
            End If
        Else
            txt_rep.Text = 0
            ccc = 0
        End If
    End Sub

    Private Sub bt_1_Click(sender As Object, e As EventArgs) Handles bt_1.Click
        If ccc = 0 Then
            If txt_rep.Text = "0" Then
                txt_rep.Text = 1
                ccc = 0
            Else
                txt_rep.Text = txt_rep.Text & 1
                ccc = 0
            End If
        Else
            txt_rep.Text = 1
            ccc = 0
        End If
    End Sub

    Private Sub bt_2_Click(sender As Object, e As EventArgs) Handles bt_2.Click
        If ccc = 0 Then
            If txt_rep.Text = "0" Then
                txt_rep.Text = 2
                ccc = 0
            Else
                txt_rep.Text = txt_rep.Text & 2
                ccc = 0
            End If
        Else
            txt_rep.Text = 2
            ccc = 0
        End If
    End Sub

    Private Sub bt_3_Click(sender As Object, e As EventArgs) Handles bt_3.Click
        If ccc = 0 Then
            If txt_rep.Text = "0" Then
                txt_rep.Text = 3
                ccc = 0
            Else
                txt_rep.Text = txt_rep.Text & 3
                ccc = 0
            End If
        Else
            txt_rep.Text = 3
            ccc = 0
        End If
    End Sub

    Private Sub bt_4_Click(sender As Object, e As EventArgs) Handles bt_4.Click
        If ccc = 0 Then
            If txt_rep.Text = "0" Then
                txt_rep.Text = 4
                ccc = 0
            Else
                txt_rep.Text = txt_rep.Text & 4
                ccc = 0
            End If
        Else
            txt_rep.Text = 4
            ccc = 0
        End If
    End Sub

    Private Sub bt_5_Click(sender As Object, e As EventArgs) Handles bt_5.Click
        If ccc = 0 Then
            If txt_rep.Text = "0" Then
                txt_rep.Text = 5
                ccc = 0
            Else
                txt_rep.Text = txt_rep.Text & 5
                ccc = 0
            End If
        Else
            txt_rep.Text = 5
            ccc = 0
        End If
    End Sub

    Private Sub bt_6_Click(sender As Object, e As EventArgs) Handles bt_6.Click
        If ccc = 0 Then
            If txt_rep.Text = "0" Then
                txt_rep.Text = 6
                ccc = 0
            Else
                txt_rep.Text = txt_rep.Text & 6
                ccc = 0
            End If
        Else
            txt_rep.Text = 6
            ccc = 0
        End If
    End Sub

    Private Sub bt_7_Click(sender As Object, e As EventArgs) Handles bt_7.Click
        If ccc = 0 Then
            If txt_rep.Text = "0" Then
                txt_rep.Text = 7
                ccc = 0
            Else
                txt_rep.Text = txt_rep.Text & 7
                ccc = 0
            End If
        Else
            txt_rep.Text = 7
            ccc = 0
        End If
    End Sub

    Private Sub bt_8_Click(sender As Object, e As EventArgs) Handles bt_8.Click
        If ccc = 0 Then
            If txt_rep.Text = "0" Then
                txt_rep.Text = 8
                ccc = 0
            Else
                txt_rep.Text = txt_rep.Text & 8
                ccc = 0
            End If
        Else
            txt_rep.Text = 8
            ccc = 0
        End If
    End Sub

    Private Sub bt_9_Click(sender As Object, e As EventArgs) Handles bt_9.Click
        If ccc = 0 Then
            If txt_rep.Text = "0" Then
                txt_rep.Text = 9
                ccc = 0
            Else
                txt_rep.Text = txt_rep.Text & 9
                ccc = 0
            End If
        Else
            txt_rep.Text = 9
            ccc = 0
        End If
    End Sub

    Private Sub bt_point_Click(sender As Object, e As EventArgs) Handles bt_point.Click
        If ccc = 0 Then
            If txt_rep.Text = "0" Then
                txt_rep.Text = 0 & "."
                ccc = 0
            Else
                txt_rep.Text = txt_rep.Text & "."
                ccc = 0
            End If
        Else
            txt_rep.Text = 0 & "."
            ccc = 0
        End If
        bt_point.Enabled = False
    End Sub

    Private Sub bt_neg_Click(sender As Object, e As EventArgs) Handles bt_neg.Click
        If txt_rep.Text <> 0 Then
            If Mid(txt_rep.Text, 1, 1) = "-" Then
                txt_rep.Text = Mid(txt_rep.Text, 2, Len(txt_rep.Text))
            Else
                txt_rep.Text = "-" & txt_rep.Text
            End If
        End If
    End Sub

    Private Sub bt_eff_Click(sender As Object, e As EventArgs) Handles bt_eff.Click
        If txt_rep.Text <> 0 Then
            If Len(txt_rep.Text) = 1 Then
                txt_rep.Text = "0"
            Else
                txt_rep.Text = Mid(txt_rep.Text, 1, Len(txt_rep.Text) - 1)
            End If
        End If
    End Sub

    Private Sub bt_on_Click(sender As Object, e As EventArgs) Handles bt_on.Click
        txt_rep.Text = 0
        aaa = 0
        bbb = 0
        ccc = 0
        signe = ""
        bt_point.Enabled = True
    End Sub

    Private Sub bt_plus_Click(sender As Object, e As EventArgs) Handles bt_plus.Click
        If signe = "" Then
            aaa = Val(txt_rep.Text)
        Else
            If signe = "+" Then
                bbb = Val(txt_rep.Text)
                txt_rep.Text = aaa + bbb
                aaa = Val(txt_rep.Text)
            ElseIf signe = "-" Then
                bbb = Val(txt_rep.Text)
                txt_rep.Text = aaa - bbb
                aaa = Val(txt_rep.Text)
            ElseIf signe = "*" Then
                bbb = Val(txt_rep.Text)
                txt_rep.Text = aaa * bbb
                aaa = Val(txt_rep.Text)
            ElseIf signe = "/" Then
                bbb = Val(txt_rep.Text)
                txt_rep.Text = aaa / bbb
                aaa = Val(txt_rep.Text)
            End If
        End If
        signe = "+"
        ccc = Val(txt_rep.Text)
        bt_point.Enabled = True
    End Sub

    Private Sub bt_moin_Click(sender As Object, e As EventArgs) Handles bt_moin.Click
        If signe = "" Then
            aaa = Val(txt_rep.Text)
        Else
            If signe = "-" Then
                bbb = Val(txt_rep.Text)
                txt_rep.Text = aaa - bbb
                aaa = Val(txt_rep.Text)
            ElseIf signe = "+" Then
                bbb = Val(txt_rep.Text)
                txt_rep.Text = aaa + bbb
                aaa = Val(txt_rep.Text)
            ElseIf signe = "*" Then
                bbb = Val(txt_rep.Text)
                txt_rep.Text = aaa * bbb
                aaa = Val(txt_rep.Text)
            ElseIf signe = "/" Then
                bbb = Val(txt_rep.Text)
                txt_rep.Text = aaa / bbb
                aaa = Val(txt_rep.Text)
            End If
        End If
        signe = "-"
        ccc = Val(txt_rep.Text)
        bt_point.Enabled = True
    End Sub

    Private Sub bt_div_Click(sender As Object, e As EventArgs) Handles bt_div.Click
        If signe = "" Then
            aaa = Val(txt_rep.Text)
        Else
            If signe = "/" Then
                bbb = Val(txt_rep.Text)
                txt_rep.Text = aaa / bbb
                aaa = Val(txt_rep.Text)
            ElseIf signe = "-" Then
                bbb = Val(txt_rep.Text)
                txt_rep.Text = aaa - bbb
                aaa = Val(txt_rep.Text)
            ElseIf signe = "*" Then
                bbb = Val(txt_rep.Text)
                txt_rep.Text = aaa * bbb
                aaa = Val(txt_rep.Text)
            ElseIf signe = "+" Then
                bbb = Val(txt_rep.Text)
                txt_rep.Text = aaa + bbb
                aaa = Val(txt_rep.Text)
            End If
        End If
        signe = "/"
        ccc = Val(txt_rep.Text)
        bt_point.Enabled = True
    End Sub

    Private Sub bt_fois_Click(sender As Object, e As EventArgs) Handles bt_fois.Click
        If signe = "" Then
            aaa = Val(txt_rep.Text)
        Else
            If signe = "*" Then
                bbb = Val(txt_rep.Text)
                txt_rep.Text = aaa * bbb
                aaa = Val(txt_rep.Text)
            ElseIf signe = "-" Then
                bbb = Val(txt_rep.Text)
                txt_rep.Text = aaa - bbb
                aaa = Val(txt_rep.Text)
            ElseIf signe = "+" Then
                bbb = Val(txt_rep.Text)
                txt_rep.Text = aaa + bbb
                aaa = Val(txt_rep.Text)
            ElseIf signe = "/" Then
                bbb = Val(txt_rep.Text)
                txt_rep.Text = aaa / bbb
                aaa = Val(txt_rep.Text)
            End If
        End If
        signe = "*"
        ccc = Val(txt_rep.Text)
        bt_point.Enabled = True
    End Sub

    Private Sub bt_pour_Click(sender As Object, e As EventArgs) Handles bt_pour.Click
        txt_rep.Text = txt_rep.Text / 100
        ccc = Val(txt_rep.Text)
    End Sub

    Private Sub bt_egale_Click(sender As Object, e As EventArgs) Handles bt_egale.Click
        If signe = "*" Then
            bbb = Val(txt_rep.Text)
            txt_rep.Text = aaa * bbb
            aaa = Val(txt_rep.Text)
        ElseIf signe = "-" Then
            bbb = Val(txt_rep.Text)
            txt_rep.Text = aaa - bbb
            aaa = Val(txt_rep.Text)
        ElseIf signe = "+" Then
            bbb = Val(txt_rep.Text)
            txt_rep.Text = aaa + bbb
            aaa = Val(txt_rep.Text)
        ElseIf signe = "/" Then
            bbb = Val(txt_rep.Text)
            txt_rep.Text = aaa / bbb
            aaa = Val(txt_rep.Text)
        End If
        signe = ""
        ccc = Val(txt_rep.Text)
        bt_point.Enabled = True
    End Sub

    Private Sub bt_ms_Click(sender As Object, e As EventArgs) Handles bt_ms.Click

    End Sub

    Private Sub bt_mr_Click(sender As Object, e As EventArgs) Handles bt_mr.Click

    End Sub

    Private Sub bt_mc_Click(sender As Object, e As EventArgs) Handles bt_mc.Click

    End Sub
End Class
