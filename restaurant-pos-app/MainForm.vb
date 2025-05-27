Public Class MainForm

    Public Shared TableOrders As New Dictionary(Of Integer, List(Of OrderItem))

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTableColors()
    End Sub

    Private Sub Table1_Click(sender As Object, e As EventArgs) Handles Table1.Click
        OpenOrderForm(1)
    End Sub

    Private Sub Table2_Click(sender As Object, e As EventArgs) Handles Table2.Click
        OpenOrderForm(2)
    End Sub

    Private Sub Table3_Click(sender As Object, e As EventArgs) Handles Table3.Click
        OpenOrderForm(3)
    End Sub

    Private Sub Table4_Click(sender As Object, e As EventArgs) Handles Table4.Click
        OpenOrderForm(4)
    End Sub

    Private Sub Table5_Click(sender As Object, e As EventArgs) Handles Table5.Click
        OpenOrderForm(5)
    End Sub

    Private Sub OpenOrderForm(tableId As Integer)
        Dim orderForm As New TableOrderForm(tableId)
        orderForm.Text = $"Orders for Table {tableId}"
        orderForm.Show()
    End Sub

    Public Sub UpdateTableColors()
        UpdateButtonColor(Table1, 1)
        UpdateButtonColor(Table2, 2)
        UpdateButtonColor(Table3, 3)
        UpdateButtonColor(Table4, 4)
        UpdateButtonColor(Table5, 5)
    End Sub

    Private Sub UpdateButtonColor(button As Button, tableId As Integer)
        If TableOrders.ContainsKey(tableId) AndAlso TableOrders(tableId).Count > 0 Then
            button.BackColor = Color.LightCoral
            button.ForeColor = Color.White
        Else
            button.BackColor = Color.LightGreen
            button.ForeColor = Color.Black
        End If
    End Sub

End Class