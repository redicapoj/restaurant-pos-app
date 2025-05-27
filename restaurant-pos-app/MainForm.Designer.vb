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
        TablesLabel = New Label()
        Table1 = New Button()
        Table2 = New Button()
        Table3 = New Button()
        Table4 = New Button()
        Table5 = New Button()
        SuspendLayout()
        ' 
        ' TablesLabel
        ' 
        TablesLabel.AutoSize = True
        TablesLabel.Font = New Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TablesLabel.Location = New Point(590, 102)
        TablesLabel.Name = "TablesLabel"
        TablesLabel.Size = New Size(149, 54)
        TablesLabel.TabIndex = 0
        TablesLabel.Text = "Tables"
        TablesLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Table1
        ' 
        Table1.FlatStyle = FlatStyle.Popup
        Table1.Font = New Font("Forte", 16F)
        Table1.Location = New Point(302, 243)
        Table1.Margin = New Padding(3, 4, 3, 4)
        Table1.Name = "Table1"
        Table1.Size = New Size(123, 99)
        Table1.TabIndex = 1
        Table1.Text = "1"
        Table1.UseVisualStyleBackColor = True
        ' 
        ' Table2
        ' 
        Table2.FlatStyle = FlatStyle.Popup
        Table2.Font = New Font("Forte", 16F)
        Table2.Location = New Point(590, 243)
        Table2.Margin = New Padding(3, 4, 3, 4)
        Table2.Name = "Table2"
        Table2.Size = New Size(123, 99)
        Table2.TabIndex = 2
        Table2.Text = "2"
        Table2.UseVisualStyleBackColor = True
        ' 
        ' Table3
        ' 
        Table3.FlatStyle = FlatStyle.Popup
        Table3.Font = New Font("Forte", 16F)
        Table3.Location = New Point(910, 243)
        Table3.Margin = New Padding(3, 4, 3, 4)
        Table3.Name = "Table3"
        Table3.Size = New Size(123, 99)
        Table3.TabIndex = 3
        Table3.Text = "3"
        Table3.UseVisualStyleBackColor = True
        ' 
        ' Table4
        ' 
        Table4.FlatStyle = FlatStyle.Popup
        Table4.Font = New Font("Forte", 16F)
        Table4.Location = New Point(442, 455)
        Table4.Margin = New Padding(3, 4, 3, 4)
        Table4.Name = "Table4"
        Table4.Size = New Size(123, 99)
        Table4.TabIndex = 4
        Table4.Text = "4"
        Table4.UseVisualStyleBackColor = True
        ' 
        ' Table5
        ' 
        Table5.FlatStyle = FlatStyle.Popup
        Table5.Font = New Font("Forte", 16F)
        Table5.Location = New Point(769, 455)
        Table5.Margin = New Padding(3, 4, 3, 4)
        Table5.Name = "Table5"
        Table5.Size = New Size(123, 99)
        Table5.TabIndex = 5
        Table5.Text = "5"
        Table5.UseVisualStyleBackColor = True
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1293, 715)
        Controls.Add(Table5)
        Controls.Add(Table4)
        Controls.Add(Table3)
        Controls.Add(Table2)
        Controls.Add(Table1)
        Controls.Add(TablesLabel)
        Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "MainForm"
        Text = "MainForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TablesLabel As Label
    Friend WithEvents Table1 As Button
    Friend WithEvents Table2 As Button
    Friend WithEvents Table3 As Button
    Friend WithEvents Table4 As Button
    Friend WithEvents Table5 As Button

End Class
