' EN: TableOrderForm serves as menu, order creation and handles the operations of:
' 1. Adding products from menu to order list.
' 2. Removing selected item from order list.
' 3. Marking the order as paid which resets the state of the table.
' 4. Leaving the table.
' 5. Saving the bill as a text file.
' 6. All operations for each table order are saved automatically.

' AL: TableOrderForm shërben si menu, krijim porosie dhe trajton operacionet e:
' 1. Shtimi i produkteve nga menuja në listën e porosive.
' 2. Fshirja e artikullit të përzgjedhur nga lista e porosive.
' 3. Shënimi i porosisë si të paguar, e cila rivendos gjendjen e tavolinës.
' 4. Dalja nga tavolina.
' 5. Ruajtja e faturës si një skedar teksti.
' 6. Të gjitha operacionet për secilën porosi tavoline ruhen automatikisht.

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
        SetupFormDesign()
        LoadMenuProducts()
        RefreshOrderList()
    End Sub


    ' EN: This method loads the menu products into the list box.
    ' AL: Kjo metodë ngarkon produktet e menusë në kutinë e listës.
    Private Sub LoadMenuProducts()
        menuProducts.Add(New Product("🍕 Pizza Margeritta", 8.99D, "Pizza", "Klasike"))
        menuProducts.Add(New Product("🥤 Coca-Cola", 2.5D, "Pije", "Pije e gazuar e embel"))
        menuProducts.Add(New Product("🍔 Burger", 7.49D, "Burger", "Burger me mish pule"))
        menuProducts.Add(New Product("🍟 French Fries", 3.25D, "Fast-Food", "Patate"))
        menuProducts.Add(New Product("🍰 Tiramisu", 4.75D, "Embelsire", "Embelsire Italiane me shije kafeje"))

        For Each item In menuProducts
            lstMenu.Items.Add(item)
        Next
    End Sub

    ' < -- Button Click Handlers -- >
    ' EN: This method handles the click event for adding a product to the order.
    ' AL: Kjo metodë trajton ngjarjen e klikimit për shtimin e një produkti në porosi.
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        If lstMenu.SelectedItem Is Nothing Then
            ShowStyledMessageBox("Ju lutem zgjidhni një produkt.", "Nuk ka zgjedhje", MessageBoxIcon.Warning)
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

    ' EN: This method handles the click event for removing a selected item from the order.
    ' AL: Kjo metodë trajton ngjarjen e klikimit për fshirjen e një artikulli të përzgjedhur nga porosia.
    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        If lstOrder.SelectedIndex >= 0 Then
            orderItems.RemoveAt(lstOrder.SelectedIndex)
            RefreshOrderList()
            UpdateMainFormColors()
        Else
            ShowStyledMessageBox("Zgjidh një produkt për ta fshirë.", "Nuk ka zgjedhje", MessageBoxIcon.Warning)
        End If
    End Sub

    ' EN: This method handles the click event for leaving the table.
    ' AL: Kjo metodë trajton ngjarjen e klikimit për të lënë tavolinën.
    Private Sub btnLeaveTable_Click(sender As Object, e As EventArgs) Handles btnLeaveTable.Click
        Me.Close()
    End Sub

    ' EN: This method handles the click event for marking the order as paid.
    ' AL: Kjo metodë trajton ngjarjen e klikimit për shënimin e porosisë si të paguar.
    Private Sub btnMarkAsPaid_Click(sender As Object, e As EventArgs) Handles btnMarkAsPaid.Click
        If ShowStyledMessageBox("Shenoni kete tavoline si te paguar?", "Konfirmoni Pagesen", MessageBoxIcon.Question, MessageBoxButtons.YesNo) = DialogResult.Yes Then
            orderItems.Clear()
            RefreshOrderList()
            MainForm.TableOrders(tableId) = New List(Of OrderItem)()
            ShowStyledMessageBox($"Tavolina {tableId} eshte tashme e lire.", "Pagesa u krye", MessageBoxIcon.Information)
            UpdateMainFormColors()
            Me.Close()
        End If
    End Sub

    ' EN: This method handles the click event for saving the bill to a file.
    ' AL: Kjo metodë trajton ngjarjen e klikimit për ruajtjen e faturës në një skedar.
    Private Sub btnSaveBillFile_Click(sender As Object, e As EventArgs) Handles btnSaveBillFile.Click
        If orderItems.Count = 0 Then
            ShowStyledMessageBox("Nuk ka produkte në porosi për të ruajtur faturën.", "Nuk ka artikuj", MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim timestamp As String = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")
            Dim filename As String = $"Table{tableId}_Bill_{timestamp}.txt"
            Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            Dim fullPath As String = IO.Path.Combine(desktopPath, filename)

            Dim billContent As New System.Text.StringBuilder()
            billContent.AppendLine("╔════════════════════════════════════════╗")
            billContent.AppendLine("║         🍽️ RESTAURANT POS SYSTEM 🍽️        ║")
            billContent.AppendLine("╠════════════════════════════════════════╣")
            billContent.AppendLine($"║ Table: {tableId}                              ║")
            billContent.AppendLine($"║ Date: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}                    ║")
            billContent.AppendLine("╠════════════════════════════════════════╣")
            billContent.AppendLine("║ ITEMS:                                 ║")
            billContent.AppendLine("╠════════════════════════════════════════╣")

            Dim total As Decimal = 0
            For Each item In orderItems
                Dim itemTotal As Decimal = item.Product.Price * item.Quantity
                total += itemTotal
                billContent.AppendLine($"║ • {item.Product.Name} x{item.Quantity}")
                billContent.AppendLine($"║   {item.Product.Price.ToString("C")} each = {itemTotal.ToString("C")}")
            Next

            billContent.AppendLine("╠════════════════════════════════════════╣")
            billContent.AppendLine($"║ 💰 TOTAL: {total.ToString("C").PadLeft(26)} ║")
            billContent.AppendLine("╠════════════════════════════════════════╣")
            billContent.AppendLine("║       Faleminderit qe na zgjodhet!     ║")
            billContent.AppendLine("╚════════════════════════════════════════╝")

            IO.File.WriteAllText(fullPath, billContent.ToString())

            ShowStyledMessageBox($"Fatura u ruajt me sukses në Desktop:{Environment.NewLine}📄 {filename}", "U Ruajt", MessageBoxIcon.Information)

        Catch ex As Exception
            ShowStyledMessageBox($"Gabim gjatë ruajtjes së faturës: {ex.Message}", "Error", MessageBoxIcon.Error)
        End Try
    End Sub

    ' < -- Refresh Order List Method -- >
    ' EN: This method refreshes the order list and updates the total amount.
    ' AL: Kjo metodë rifreskon listën e porosive dhe përditëson shumën totale.
    Private Sub RefreshOrderList()
        lstOrder.Items.Clear()
        Dim total As Decimal = 0

        For Each item In orderItems
            lstOrder.Items.Add($"• {item.ToString()}")
            total += item.Product.Price * item.Quantity
        Next

        lblTotal.Text = $"💰 Total: {total.ToString("C")}"

        MainForm.TableOrders(tableId) = orderItems
    End Sub

    ' < -- Styling and Design Methods -- > 
    ' EN: This method sets up the design of the form, including buttons, labels, and list boxes.
    ' AL: Kjo metodë vendos dizajnin e formës, duke përfshirë butonat, etiketat dhe kutitë e listës.
    Private Sub SetupFormDesign()

        StyleGroupBoxes()

        StyleButton(btnAddProduct, "➕ Shto Produkt", Color.FromArgb(70, 130, 180))
        StyleButton(btnRemoveItem, "❌ Hiq Artikull", Color.FromArgb(220, 90, 90))
        StyleButton(btnSaveBillFile, "💾 Ruaj Faturen", Color.FromArgb(100, 150, 100))
        StyleButton(btnLeaveTable, "🚪 Dil", Color.FromArgb(150, 150, 150))
        StyleButton(btnMarkAsPaid, "💳 Paguaj", Color.FromArgb(50, 150, 50))

        StyleListBox(lstMenu)
        StyleListBox(lstOrder)

        StyleTotalLabel()
    End Sub

    Private Sub StyleGroupBoxes()
        For Each control As Control In Me.Controls
            If TypeOf control Is GroupBox Then
                Dim gb As GroupBox = DirectCast(control, GroupBox)
                gb.Font = New Font("Segoe UI", 11, FontStyle.Bold)
                gb.ForeColor = Color.FromArgb(60, 60, 60)
            End If
        Next
    End Sub

    Private Sub StyleButton(btn As Button, text As String, color As Color)
        If btn IsNot Nothing Then
            btn.Text = text
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = color
            btn.ForeColor = Color.White
            btn.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            btn.Cursor = Cursors.Hand

            AddHandler btn.MouseEnter, Sub() btn.BackColor = Color.FromArgb(Math.Min(255, color.R + 20), Math.Min(255, color.G + 20), Math.Min(255, color.B + 20))
            AddHandler btn.MouseLeave, Sub() btn.BackColor = color
        End If
    End Sub

    Private Sub StyleListBox(lst As ListBox)
        If lst IsNot Nothing Then
            lst.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            lst.BackColor = Color.White
            lst.BorderStyle = BorderStyle.FixedSingle
        End If
    End Sub

    Private Sub StyleTotalLabel()
        If lblTotal IsNot Nothing Then
            lblTotal.Font = New Font("Segoe UI", 14, FontStyle.Bold)
            lblTotal.ForeColor = Color.FromArgb(50, 100, 50)
            lblTotal.BackColor = Color.FromArgb(240, 255, 240)
            lblTotal.BorderStyle = BorderStyle.FixedSingle
            lblTotal.TextAlign = ContentAlignment.MiddleCenter
            lblTotal.Height = 40
        End If
    End Sub

    ' EN: Helper function to show styled message boxes
    ' AL: Funksion ndihmës për të shfaqur kuti mesazhesh me stil
    Private Function ShowStyledMessageBox(text As String, caption As String, icon As MessageBoxIcon, Optional buttons As MessageBoxButtons = MessageBoxButtons.OK) As DialogResult
        Return MessageBox.Show(text, caption, buttons, icon)
    End Function

    ' EN: This method updates the main form's table colors based on the current state of orders.
    ' AL: Kjo metodë përditëson ngjyrat e tavolinave në formën kryesore në bazë të gjendjes aktuale të porosive.
    Private Sub UpdateMainFormColors()
        For Each form As Form In Application.OpenForms
            If TypeOf form Is MainForm Then
                CType(form, MainForm).UpdateTableColors()
                Exit For
            End If
        Next
    End Sub

End Class

' EN: Product and OrderItem classes to represent menu items and order details.
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