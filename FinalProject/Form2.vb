Public Class Form2


    Private Function Cost_Of_Item() As Double
        Dim Sum As Double = 0
        Dim i As Integer = 0

        For i = 0 To DataGridView1.Rows.Count - 1

            Sum = Sum + Convert.ToDouble(DataGridView1.Rows(i).Cells(2).Value)
        Next i
        Return Sum

    End Function

    Sub AddCost()
        Dim tax, q As Double
        tax = 3.9

        If DataGridView1.Rows.Count > 0 Then
            lbltax.Text = FormatCurrency(((Cost_Of_Item() * tax) / 100).ToString("0.00"))
            lblsubtotal.Text = FormatCurrency(Cost_Of_Item().ToString("0.00"))
            q = ((Cost_Of_Item() * tax) / 100)
            lbltotal.Text = FormatCurrency(q + Cost_Of_Item().ToString("0.00"))

        End If
    End Sub

    Sub Change()
        Dim tax, q, c As Double
        tax = 3.9

        If DataGridView1.Rows.Count > 0 Then

            q = ((Cost_Of_Item() * tax) / 100) + Cost_Of_Item()
            c = Val(lblCost.Text)
            lblChange.Text = FormatCurrency((c - q).ToString("0.00"))

        End If
    End Sub
    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        lblChange.Text = ""
        lblCost.Text = ""
        lblsubtotal.Text = ""
        lbltax.Text = ""
        lbltotal.Text = ""
        cboPayment.Text = ""
        DataGridView1.Rows.Clear()
        DataGridView1.Refresh()

    End Sub

    Private Sub NumbersOnly(sender As Object, e As EventArgs) Handles Button19.Click, Button20.Click, Button21.Click, Button16.Click, Button17.Click, Button18.Click, Button15.Click, Button14.Click, Button13.Click, Button24.Click, Button23.Click
        Dim b As Button = sender

        If lblCost.Text = "0" Then
            lblCost.Text = ""
            lblCost.Text = b.Text

        ElseIf b.Text = "." Then
            If Not lblCost.Text.Contains(".") Then
                lblCost.Text = lblCost.Text + b.Text
            End If
        Else
            lblCost.Text = lblCost.Text + b.Text
        End If
    End Sub

    Private Sub cboPayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPayment.SelectedIndexChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboPayment.Items.Add("Cash")
        cboPayment.Items.Add("Direct Debit")
        cboPayment.Items.Add("Visa Card")
        cboPayment.Items.Add("Master Card")
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        lblCost.Text = "0"
        cboPayment.Text = ""
        lblChange.Text = ""
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click


        If cboPayment.Text = "Cash" Then

            Change()
        Else
            lblChange.Text = ""
            lblCost.Text = ""
        End If
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click


        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(row)
        Next
        AddCost()
        Change()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Costofitem As Double = 180
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Kobe Grinches" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value + 1)
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * Costofitem
                Exit Sub
            End If

        Next
        DataGridView1.Rows.Add("Kobe Grinches", "1", Costofitem)
        AddCost()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim Costofitem As Double = 120
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Ja 2" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value + 1)
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * Costofitem
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Ja 2", "1", Costofitem)
        AddCost()
    End Sub

    Private Sub lbltotal_Click(sender As Object, e As EventArgs) Handles lbltotal.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim Costofitem As Double = 160
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Harden Vol.8" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value + 1)
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * Costofitem
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Harden Vol.8", "1", Costofitem)
        AddCost()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Costofitem As Double = 210
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Lebron 20" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value + 1)
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * Costofitem
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Lebron 20", "1", Costofitem)
        AddCost()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim Costofitem As Double = 130
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Sabrina 2" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value + 1)
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * Costofitem
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Sabrina 2", "1", Costofitem)
        AddCost()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Costofitem As Double = 110
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Ja 1" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value + 1)
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * Costofitem
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Ja 1", "1", Costofitem)
        AddCost()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim Costofitem As Double = 100
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Adidas Samba" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value + 1)
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * Costofitem
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Adidas Samba", "1", Costofitem)
        AddCost()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim Costofitem As Double = 200
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Jordan 4" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value + 1)
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * Costofitem
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Jordan 4", "1", Costofitem)
        AddCost()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim Costofitem As Double = 190
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Jordan 1 Ts" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value + 1)
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * Costofitem
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Jordan 1 Ts", "1", Costofitem)
        AddCost()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim Costofitem As Double = 120
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Nike dunks low" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value + 1)
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * Costofitem
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Nike dunks low", "1", Costofitem)
        AddCost()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim Costofitem As Double = 150
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Airmax 1" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value + 1)
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * Costofitem
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Airmax 1", "1", Costofitem)
        AddCost()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim Costofitem As Double = 180
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Airmax 97" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value + 1)
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * Costofitem
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Airmax 97", "1", Costofitem)
        AddCost()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class