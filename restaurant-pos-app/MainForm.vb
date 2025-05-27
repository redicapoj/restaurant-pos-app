'EN: Main Form is the entry-point of the application, showcasing information about the restaurant and table availability.
'Each table is represented by a button, and clicking on a table opens a form to manage orders for that table.

'AL: Forma Kryesore është pika hyrëse e aplikacionit, duke treguar informacion rreth restorantit dhe disponueshmërisë së tavolinave.
'Cdo tavolinë përfaqësohet nga një buton, dhe klikimi mbi një tavolinë hap një formë për të menaxhuar porositë për atë tavolinë.

Public Class MainForm

    Public Shared TableOrders As New Dictionary(Of Integer, List(Of OrderItem))

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetUpStatsPanel()
        SetUpLegendPanel()
        UpdateTableColors()
    End Sub

    ' < -- Setting up the stats and legend panels dynamically -- >
    ' EN: This method creates or updates the stats panel that displays the number of occupied and available tables, along with a timestamp.
    ' AL: Kjo metodë krijon ose përditëson panelin e statistikave që tregon numrin e tavolinave të zëna dhe të lira, së bashku me një kohë shënimi.
    Private Sub SetUpStatsPanel()
        Dim statsPanel As Panel = Nothing
        If Me.Controls.Find("pnlStats", True).Length = 0 Then
            statsPanel = New Panel()
            statsPanel.Name = "pnlStats"
            statsPanel.Location = New Point(450, 20)
            statsPanel.Size = New Size(280, 70)
            statsPanel.BackColor = Color.White
            statsPanel.BorderStyle = BorderStyle.FixedSingle
            Me.Controls.Add(statsPanel)
        Else
            statsPanel = DirectCast(Me.Controls.Find("pnlStats", True)(0), Panel)
        End If

        statsPanel.Controls.Clear()

        Dim occupiedCount As Integer = TableOrders.Where(Function(kvp) kvp.Value.Count > 0).Count()
        Dim availableCount As Integer = 5 - occupiedCount

        Dim lblOccupiedStat As New Label()
        lblOccupiedStat.Text = $"🔴 Te zena: {occupiedCount}"
        lblOccupiedStat.Location = New Point(10, 10)
        lblOccupiedStat.Size = New Size(120, 20)
        lblOccupiedStat.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblOccupiedStat.ForeColor = Color.FromArgb(200, 60, 60)

        Dim lblAvailableStat As New Label()
        lblAvailableStat.Text = $"🟢 Te lira: {availableCount}"
        lblAvailableStat.Location = New Point(140, 10)
        lblAvailableStat.Size = New Size(120, 20)
        lblAvailableStat.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblAvailableStat.ForeColor = Color.FromArgb(60, 150, 60)

        Dim lblTimestamp As New Label()
        lblTimestamp.Text = $"⏰ {DateTime.Now.ToString("HH:mm - dd/MM/yyyy")}"
        lblTimestamp.Location = New Point(10, 35)
        lblTimestamp.Size = New Size(250, 20)
        lblTimestamp.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        lblTimestamp.ForeColor = Color.FromArgb(100, 100, 100)

        statsPanel.Controls.AddRange({lblOccupiedStat, lblAvailableStat, lblTimestamp})
    End Sub


    ' < -- Setting up the legend panel dynamically -- >
    ' EN: This method creates or updates the legend panel that explains the color coding for table statuses.
    ' AL: Kjo metodë krijon ose përditëson panelin e legjendës që shpjegon kodimin e ngjyrave për statuset e tavolinave.
    Private Sub SetUpLegendPanel()
        Dim legendPanel As Panel = Nothing
        If Me.Controls.Find("pnlLegend", True).Length = 0 Then
            legendPanel = New Panel()
            legendPanel.Name = "pnlLegend"
            legendPanel.Location = New Point(50, 450)
            legendPanel.Size = New Size(200, 60)
            legendPanel.BackColor = Color.FromArgb(250, 250, 250)
            legendPanel.BorderStyle = BorderStyle.FixedSingle
            Me.Controls.Add(legendPanel)
        Else
            legendPanel = DirectCast(Me.Controls.Find("pnlLegend", True)(0), Panel)
        End If

        legendPanel.Controls.Clear()

        Dim lblLegendTitle As New Label()
        lblLegendTitle.Text = "Legjenda e Statusit:"
        lblLegendTitle.Location = New Point(10, 5)
        lblLegendTitle.Size = New Size(180, 20)
        lblLegendTitle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblLegendTitle.ForeColor = Color.FromArgb(60, 60, 60)

        Dim lblAvailable As New Label()
        lblAvailable.Text = "🟢 Te Lira"
        lblAvailable.Location = New Point(10, 25)
        lblAvailable.Size = New Size(85, 20)
        lblAvailable.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        lblAvailable.ForeColor = Color.FromArgb(60, 150, 60)

        Dim lblOccupied As New Label()
        lblOccupied.Text = "🔴 Te Zena"
        lblOccupied.Location = New Point(100, 25)
        lblOccupied.Size = New Size(85, 20)
        lblOccupied.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        lblOccupied.ForeColor = Color.FromArgb(200, 60, 60)

        legendPanel.Controls.AddRange({lblLegendTitle, lblAvailable, lblOccupied})
    End Sub

    ' < -- Updating the colors of the table buttons based on their status -- >
    ' EN: This method updates the colors of the table buttons based on whether they are occupied or available.
    ' AL: Kjo metodë përditëson ngjyrat e butonave të tavolinave në bazë të faktit nëse janë të zëna apo të lira.
    Public Sub UpdateTableColors()
        UpdateButtonColor(Table1, 1)
        UpdateButtonColor(Table2, 2)
        UpdateButtonColor(Table3, 3)
        UpdateButtonColor(Table4, 4)
        UpdateButtonColor(Table5, 5)
        SetUpStatsPanel()
    End Sub

    Private Sub UpdateButtonColor(button As Button, tableId As Integer)
        If TableOrders.ContainsKey(tableId) AndAlso TableOrders(tableId).Count > 0 Then
            button.BackColor = Color.FromArgb(220, 100, 100)
            button.ForeColor = Color.White
            button.FlatAppearance.BorderColor = Color.FromArgb(180, 80, 80)
            button.Text = $"Tavolina {tableId}"
        Else
            button.BackColor = Color.FromArgb(120, 200, 120)
            button.ForeColor = Color.White
            button.FlatAppearance.BorderColor = Color.FromArgb(100, 180, 100)
            button.Text = $"Tavolina {tableId}"
        End If
    End Sub


    ' < -- Event handlers for table button clicks -- >
    ' EN: These methods handle the click events for each table button, opening the order form for the respective table.
    ' AL: Këto metoda trajtojnë ngjarjet e klikimit për secilin buton tavoline, duke hapur formën e porosisë për tavolinën përkatëse.
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

    ' < -- Method to open the order form for a specific table -- >
    ' ' EN: This method creates and shows the order form for the specified table ID.
    ' ' AL: Kjo metodë krijon dhe shfaq formën e porosisë për ID-në e specifikuar të tavolinës.
    Private Sub OpenOrderForm(tableId As Integer)
        Dim orderForm As New TableOrderForm(tableId)
        orderForm.Text = $"Porosia per tavolinen {tableId} - Mom's Spaghetti Restaurant"
        orderForm.Show()
    End Sub

End Class