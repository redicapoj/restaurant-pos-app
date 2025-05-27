Public Class TableOrderForm

    Private tableId As Integer
    Private orderItems As New List(Of OrderItem)
    Private menuProducts As New List(Of Product)

    Public Sub New(tid As Integer)
        InitializeComponent()
        tableId = tid

        If MainForm.TableOrders.ContainsKey(tableId) Then
            orderItems = MainForm.TableOrders(tableId)
        Else
            orderItems = New List(Of OrderItem)()
            MainForm.TableOrders(tableId) = orderItems
        End If
    End Sub

    Private Sub TableOrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menuProducts.Add(New Product("Margherita Pizza", 8.99D, "Pizza", "Classic cheese & tomato"))
        menuProducts.Add(New Product("Coca-Cola", 2.5D, "Drinks", "Chilled soft drink"))
        menuProducts.Add(New Product("Chicken Burger", 7.49D, "Burger", "Grilled chicken with lettuce"))
        menuProducts.Add(New Product("French Fries", 3.25D, "Sides", "Crispy potato fries"))
        menuProducts.Add(New Product("Tiramisu", 4.75D, "Dessert", "Coffee-flavored Italian dessert"))

        For Each item In menuProducts
            lstMenu.Items.Add(item)
        Next

        RefreshOrderList()
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        If lstMenu.SelectedItem Is Nothing Then
            MessageBox.Show("Ju lutem zgjidhni një produkt.")
            Return
        End If

        Dim selectedProduct As Product = CType(lstMenu.SelectedItem, Product)

        Dim existing = orderItems.FirstOrDefault(Function(x) x.Product.Name = selectedProduct.Name)

        If existing IsNot Nothing Then
            existing.Quantity += 1
        Else
            orderItems.Add(New OrderItem(selectedProduct, 1))
        End If

        RefreshOrderList()
        UpdateMainFormColors()
    End Sub

    Private Sub RefreshOrderList()
        lstOrder.Items.Clear()
        Dim total As Decimal = 0

        For Each item In orderItems
            lstOrder.Items.Add(item.ToString())
            total += item.Product.Price * item.Quantity
        Next

        lblTotal.Text = $"Total: {total.ToString("C")}"

        MainForm.TableOrders(tableId) = orderItems
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        If lstOrder.SelectedIndex >= 0 Then
            orderItems.RemoveAt(lstOrder.SelectedIndex)
            RefreshOrderList()
            UpdateMainFormColors()
        Else
            MessageBox.Show("Zgjidh një produkt për ta fshirë.")
        End If
    End Sub

    Private Sub btnLeaveTable_Click(sender As Object, e As EventArgs) Handles btnLeaveTable.Click
        Me.Close()
    End Sub

    Private Sub btnMarkAsPaid_Click(sender As Object, e As EventArgs) Handles btnMarkAsPaid.Click
        If MessageBox.Show("Mark this order as paid and clear the table?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            orderItems.Clear()
            RefreshOrderList()
            MainForm.TableOrders(tableId) = New List(Of OrderItem)()
            MessageBox.Show($"Table {tableId} is now cleared.")
            UpdateMainFormColors()
            Me.Close()
        End If
    End Sub

    Private Sub UpdateMainFormColors()
        For Each form As Form In Application.OpenForms
            If TypeOf form Is MainForm Then
                CType(form, MainForm).UpdateTableColors()
                Exit For
            End If
        Next
    End Sub

End Class


Public Class Product
    Public Property Name As String
    Public Property Price As Decimal
    Public Property Category As String
    Public Property Description As String

    Public Sub New(name As String, price As Decimal, Optional category As String = "", Optional description As String = "")
        Me.Name = name
        Me.Price = price
        Me.Category = category
        Me.Description = description
    End Sub

    Public Overrides Function ToString() As String
        Return $"{Name} - {Price.ToString("C")}"
    End Function
End Class

Public Class OrderItem
    Public Property Product As Product
    Public Property Quantity As Integer

    Public Sub New(product As Product, quantity As Integer)
        Me.Product = product
        Me.Quantity = quantity
    End Sub

    Public Overrides Function ToString() As String
        Return $"{Product.Name} x{Quantity} - { (Product.Price * Quantity).ToString("C") }"
    End Function
End Class
