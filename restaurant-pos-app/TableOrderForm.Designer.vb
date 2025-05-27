<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableOrderForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lstMenu = New ListBox()
        lstOrder = New ListBox()
        btnAddProduct = New Button()
        lblTotal = New Label()
        btnRemoveItem = New Button()
        btnLeaveTable = New Button()
        btnMarkAsPaid = New Button()
        btnSaveBillFile = New Button()
        SuspendLayout()
        ' 
        ' lstMenu
        ' 
        lstMenu.FormattingEnabled = True
        lstMenu.ItemHeight = 25
        lstMenu.Items.AddRange(New Object() {"Zgjidhni produktet:"})
        lstMenu.Location = New Point(158, 101)
        lstMenu.Name = "lstMenu"
        lstMenu.Size = New Size(294, 179)
        lstMenu.TabIndex = 0
        ' 
        ' lstOrder
        ' 
        lstOrder.FormattingEnabled = True
        lstOrder.ItemHeight = 25
        lstOrder.Items.AddRange(New Object() {"Fatura:"})
        lstOrder.Location = New Point(721, 101)
        lstOrder.Name = "lstOrder"
        lstOrder.Size = New Size(280, 179)
        lstOrder.TabIndex = 1
        ' 
        ' btnAddProduct
        ' 
        btnAddProduct.Location = New Point(158, 381)
        btnAddProduct.Name = "btnAddProduct"
        btnAddProduct.Size = New Size(121, 85)
        btnAddProduct.TabIndex = 2
        btnAddProduct.Text = "Shto Produkt"
        btnAddProduct.UseVisualStyleBackColor = True
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(721, 381)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(92, 25)
        lblTotal.TabIndex = 3
        lblTotal.Text = "Total: $0.0"
        ' 
        ' btnRemoveItem
        ' 
        btnRemoveItem.Location = New Point(340, 381)
        btnRemoveItem.Name = "btnRemoveItem"
        btnRemoveItem.Size = New Size(112, 85)
        btnRemoveItem.TabIndex = 4
        btnRemoveItem.Text = "Fshi Produktin"
        btnRemoveItem.UseVisualStyleBackColor = True
        ' 
        ' btnLeaveTable
        ' 
        btnLeaveTable.Location = New Point(158, 530)
        btnLeaveTable.Name = "btnLeaveTable"
        btnLeaveTable.Size = New Size(112, 65)
        btnLeaveTable.TabIndex = 5
        btnLeaveTable.Text = "Dil"
        btnLeaveTable.UseVisualStyleBackColor = True
        ' 
        ' btnMarkAsPaid
        ' 
        btnMarkAsPaid.Location = New Point(901, 530)
        btnMarkAsPaid.Name = "btnMarkAsPaid"
        btnMarkAsPaid.Size = New Size(112, 80)
        btnMarkAsPaid.TabIndex = 6
        btnMarkAsPaid.Text = "Paguaj"
        btnMarkAsPaid.UseVisualStyleBackColor = True
        ' 
        ' btnSaveBillFile
        ' 
        btnSaveBillFile.Location = New Point(731, 530)
        btnSaveBillFile.Name = "btnSaveBillFile"
        btnSaveBillFile.Size = New Size(112, 80)
        btnSaveBillFile.TabIndex = 7
        btnSaveBillFile.Text = "Ruaj Faturen"
        btnSaveBillFile.UseVisualStyleBackColor = True
        ' 
        ' TableOrderForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(252))
        ClientSize = New Size(1174, 675)
        Controls.Add(btnSaveBillFile)
        Controls.Add(btnMarkAsPaid)
        Controls.Add(btnLeaveTable)
        Controls.Add(btnRemoveItem)
        Controls.Add(lblTotal)
        Controls.Add(btnAddProduct)
        Controls.Add(lstOrder)
        Controls.Add(lstMenu)
        Name = "TableOrderForm"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstMenu As ListBox
    Friend WithEvents lstOrder As ListBox
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents btnLeaveTable As Button
    Friend WithEvents btnMarkAsPaid As Button
    Friend WithEvents btnSaveBillFile As Button
End Class
