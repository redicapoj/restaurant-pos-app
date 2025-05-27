<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Table1 = New Button()
        Table2 = New Button()
        Table3 = New Button()
        Table4 = New Button()
        Table5 = New Button()
        lblRestaurantName = New Label()
        lblSubtitle = New Label()
        pnlStats = New Panel()
        SuspendLayout()
        ' 
        ' Table1
        ' 
        Table1.Cursor = Cursors.Hand
        Table1.FlatAppearance.BorderColor = Color.Gray
        Table1.FlatAppearance.BorderSize = 2
        Table1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(220), CByte(255))
        Table1.FlatStyle = FlatStyle.Flat
        Table1.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Table1.Location = New Point(249, 243)
        Table1.Margin = New Padding(3, 4, 3, 4)
        Table1.Name = "Table1"
        Table1.Size = New Size(183, 144)
        Table1.TabIndex = 1
        Table1.Text = "1"
        Table1.UseVisualStyleBackColor = True
        ' 
        ' Table2
        ' 
        Table2.Cursor = Cursors.Hand
        Table2.FlatAppearance.BorderColor = Color.Gray
        Table2.FlatAppearance.BorderSize = 2
        Table2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(220), CByte(255))
        Table2.FlatStyle = FlatStyle.Flat
        Table2.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Table2.Location = New Point(572, 243)
        Table2.Margin = New Padding(3, 4, 3, 4)
        Table2.Name = "Table2"
        Table2.Size = New Size(183, 144)
        Table2.TabIndex = 2
        Table2.Text = "2"
        Table2.UseVisualStyleBackColor = True
        ' 
        ' Table3
        ' 
        Table3.Cursor = Cursors.Hand
        Table3.FlatAppearance.BorderColor = Color.Gray
        Table3.FlatAppearance.BorderSize = 2
        Table3.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(220), CByte(255))
        Table3.FlatStyle = FlatStyle.Flat
        Table3.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Table3.Location = New Point(910, 243)
        Table3.Margin = New Padding(3, 4, 3, 4)
        Table3.Name = "Table3"
        Table3.Size = New Size(183, 144)
        Table3.TabIndex = 3
        Table3.Text = "3"
        Table3.UseVisualStyleBackColor = True
        ' 
        ' Table4
        ' 
        Table4.Cursor = Cursors.Hand
        Table4.FlatAppearance.BorderColor = Color.Gray
        Table4.FlatAppearance.BorderSize = 2
        Table4.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(220), CByte(255))
        Table4.FlatStyle = FlatStyle.Flat
        Table4.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Table4.Location = New Point(442, 455)
        Table4.Margin = New Padding(3, 4, 3, 4)
        Table4.Name = "Table4"
        Table4.Size = New Size(183, 144)
        Table4.TabIndex = 4
        Table4.Text = "4"
        Table4.UseVisualStyleBackColor = True
        ' 
        ' Table5
        ' 
        Table5.Cursor = Cursors.Hand
        Table5.FlatAppearance.BorderColor = Color.Gray
        Table5.FlatAppearance.BorderSize = 2
        Table5.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(220), CByte(255))
        Table5.FlatStyle = FlatStyle.Flat
        Table5.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Table5.Location = New Point(769, 455)
        Table5.Margin = New Padding(3, 4, 3, 4)
        Table5.Name = "Table5"
        Table5.Size = New Size(183, 144)
        Table5.TabIndex = 5
        Table5.Text = "5"
        Table5.UseVisualStyleBackColor = True
        ' 
        ' lblRestaurantName
        ' 
        lblRestaurantName.AutoSize = True
        lblRestaurantName.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRestaurantName.ForeColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        lblRestaurantName.Location = New Point(50, 20)
        lblRestaurantName.Name = "lblRestaurantName"
        lblRestaurantName.Size = New Size(707, 54)
        lblRestaurantName.TabIndex = 6
        lblRestaurantName.Text = "🍽️ MOMS SPAGHETTI RESTAURANT"
        lblRestaurantName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSubtitle.Location = New Point(61, 74)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(386, 30)
        lblSubtitle.TabIndex = 7
        lblSubtitle.Text = "Premium Dining Experience • Est. 2020"
        ' 
        ' pnlStats
        ' 
        pnlStats.BackColor = Color.White
        pnlStats.BorderStyle = BorderStyle.FixedSingle
        pnlStats.Location = New Point(868, 34)
        pnlStats.Name = "pnlStats"
        pnlStats.Size = New Size(370, 97)
        pnlStats.TabIndex = 8
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(248))
        ClientSize = New Size(1361, 996)
        Controls.Add(pnlStats)
        Controls.Add(lblSubtitle)
        Controls.Add(lblRestaurantName)
        Controls.Add(Table5)
        Controls.Add(Table4)
        Controls.Add(Table3)
        Controls.Add(Table2)
        Controls.Add(Table1)
        Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "MainForm"
        Text = "RestaurantPOS - Menaxhimi i Tavolinave"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Table1 As Button
    Friend WithEvents Table2 As Button
    Friend WithEvents Table3 As Button
    Friend WithEvents Table4 As Button
    Friend WithEvents Table5 As Button
    Friend WithEvents lblRestaurantName As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents pnlStats As Panel
    Friend WithEvents Label1 As Label

End Class
