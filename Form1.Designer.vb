<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SourceFileTextBox = New System.Windows.Forms.TextBox()
        Me.DestinationConnectionStringTextBox = New System.Windows.Forms.TextBox()
        Me.MainTabControl = New System.Windows.Forms.TabControl()
        Me.SourceTabPage = New System.Windows.Forms.TabPage()
        Me.OpenSourceDatasetButton = New System.Windows.Forms.Button()
        Me.ImportDatasetButton = New System.Windows.Forms.Button()
        Me.LoadWorksheetsButton = New System.Windows.Forms.Button()
        Me.SourceSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.SourceMetadataDataGridView = New System.Windows.Forms.DataGridView()
        Me.SourceDataGridView = New System.Windows.Forms.DataGridView()
        Me.LoadSourceDataButton = New System.Windows.Forms.Button()
        Me.WorksheetsComboBox = New System.Windows.Forms.ComboBox()
        Me.DestinationTabPage = New System.Windows.Forms.TabPage()
        Me.DestinationDatasetSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DatabaseTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DatabaseServerTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoadDestinationButton = New System.Windows.Forms.Button()
        Me.DestinationTablesComboBox = New System.Windows.Forms.ComboBox()
        Me.DestinationSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.DestinationMetadataDataGridView = New System.Windows.Forms.DataGridView()
        Me.DestinationDataGridView = New System.Windows.Forms.DataGridView()
        Me.MappingTabPage = New System.Windows.Forms.TabPage()
        Me.MappingsSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.MappingDataGridView = New System.Windows.Forms.DataGridView()
        Me.DestinationColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SourceColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DefaultValueColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuotedColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SqlTextBox = New System.Windows.Forms.TextBox()
        Me.SqlToolStrip = New System.Windows.Forms.ToolStrip()
        Me.GenerateQueriesToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GenerateInsertQueriesToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MainTabControl.SuspendLayout()
        Me.SourceTabPage.SuspendLayout()
        CType(Me.SourceSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SourceSplitContainer.Panel1.SuspendLayout()
        Me.SourceSplitContainer.Panel2.SuspendLayout()
        Me.SourceSplitContainer.SuspendLayout()
        CType(Me.SourceMetadataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DestinationTabPage.SuspendLayout()
        CType(Me.DestinationDatasetSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DestinationDatasetSplitContainer.Panel1.SuspendLayout()
        Me.DestinationDatasetSplitContainer.Panel2.SuspendLayout()
        Me.DestinationDatasetSplitContainer.SuspendLayout()
        CType(Me.DestinationSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DestinationSplitContainer.Panel1.SuspendLayout()
        Me.DestinationSplitContainer.Panel2.SuspendLayout()
        Me.DestinationSplitContainer.SuspendLayout()
        CType(Me.DestinationMetadataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MappingTabPage.SuspendLayout()
        CType(Me.MappingsSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MappingsSplitContainer.Panel1.SuspendLayout()
        Me.MappingsSplitContainer.Panel2.SuspendLayout()
        Me.MappingsSplitContainer.SuspendLayout()
        CType(Me.MappingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SqlToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'SourceFileTextBox
        '
        Me.SourceFileTextBox.Location = New System.Drawing.Point(97, 6)
        Me.SourceFileTextBox.Name = "SourceFileTextBox"
        Me.SourceFileTextBox.Size = New System.Drawing.Size(499, 20)
        Me.SourceFileTextBox.TabIndex = 0
        '
        'DestinationConnectionStringTextBox
        '
        Me.DestinationConnectionStringTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DestinationConnectionStringTextBox.Enabled = False
        Me.DestinationConnectionStringTextBox.Location = New System.Drawing.Point(345, 22)
        Me.DestinationConnectionStringTextBox.Multiline = True
        Me.DestinationConnectionStringTextBox.Name = "DestinationConnectionStringTextBox"
        Me.DestinationConnectionStringTextBox.Size = New System.Drawing.Size(521, 42)
        Me.DestinationConnectionStringTextBox.TabIndex = 1
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.SourceTabPage)
        Me.MainTabControl.Controls.Add(Me.DestinationTabPage)
        Me.MainTabControl.Controls.Add(Me.MappingTabPage)
        Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabControl.Location = New System.Drawing.Point(0, 0)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(885, 555)
        Me.MainTabControl.TabIndex = 2
        '
        'SourceTabPage
        '
        Me.SourceTabPage.Controls.Add(Me.Label6)
        Me.SourceTabPage.Controls.Add(Me.Label5)
        Me.SourceTabPage.Controls.Add(Me.OpenSourceDatasetButton)
        Me.SourceTabPage.Controls.Add(Me.ImportDatasetButton)
        Me.SourceTabPage.Controls.Add(Me.LoadWorksheetsButton)
        Me.SourceTabPage.Controls.Add(Me.SourceSplitContainer)
        Me.SourceTabPage.Controls.Add(Me.LoadSourceDataButton)
        Me.SourceTabPage.Controls.Add(Me.WorksheetsComboBox)
        Me.SourceTabPage.Controls.Add(Me.SourceFileTextBox)
        Me.SourceTabPage.Location = New System.Drawing.Point(4, 22)
        Me.SourceTabPage.Name = "SourceTabPage"
        Me.SourceTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.SourceTabPage.Size = New System.Drawing.Size(877, 529)
        Me.SourceTabPage.TabIndex = 0
        Me.SourceTabPage.Text = "Source dataset"
        Me.SourceTabPage.UseVisualStyleBackColor = True
        '
        'OpenSourceDatasetButton
        '
        Me.OpenSourceDatasetButton.Location = New System.Drawing.Point(709, 7)
        Me.OpenSourceDatasetButton.Name = "OpenSourceDatasetButton"
        Me.OpenSourceDatasetButton.Size = New System.Drawing.Size(101, 23)
        Me.OpenSourceDatasetButton.TabIndex = 8
        Me.OpenSourceDatasetButton.Text = "Open dataset..."
        Me.OpenSourceDatasetButton.UseVisualStyleBackColor = True
        '
        'ImportDatasetButton
        '
        Me.ImportDatasetButton.Location = New System.Drawing.Point(603, 6)
        Me.ImportDatasetButton.Name = "ImportDatasetButton"
        Me.ImportDatasetButton.Size = New System.Drawing.Size(100, 23)
        Me.ImportDatasetButton.TabIndex = 7
        Me.ImportDatasetButton.Text = "Import dataset..."
        Me.ImportDatasetButton.UseVisualStyleBackColor = True
        '
        'LoadWorksheetsButton
        '
        Me.LoadWorksheetsButton.Enabled = False
        Me.LoadWorksheetsButton.Location = New System.Drawing.Point(602, 33)
        Me.LoadWorksheetsButton.Name = "LoadWorksheetsButton"
        Me.LoadWorksheetsButton.Size = New System.Drawing.Size(101, 23)
        Me.LoadWorksheetsButton.TabIndex = 6
        Me.LoadWorksheetsButton.Text = "Load worksheets"
        Me.LoadWorksheetsButton.UseVisualStyleBackColor = True
        '
        'SourceSplitContainer
        '
        Me.SourceSplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SourceSplitContainer.Location = New System.Drawing.Point(8, 62)
        Me.SourceSplitContainer.Name = "SourceSplitContainer"
        '
        'SourceSplitContainer.Panel1
        '
        Me.SourceSplitContainer.Panel1.Controls.Add(Me.SourceMetadataDataGridView)
        '
        'SourceSplitContainer.Panel2
        '
        Me.SourceSplitContainer.Panel2.Controls.Add(Me.SourceDataGridView)
        Me.SourceSplitContainer.Size = New System.Drawing.Size(866, 461)
        Me.SourceSplitContainer.SplitterDistance = 288
        Me.SourceSplitContainer.TabIndex = 5
        '
        'SourceMetadataDataGridView
        '
        Me.SourceMetadataDataGridView.AllowUserToAddRows = False
        Me.SourceMetadataDataGridView.AllowUserToDeleteRows = False
        Me.SourceMetadataDataGridView.AllowUserToOrderColumns = True
        Me.SourceMetadataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SourceMetadataDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SourceMetadataDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.SourceMetadataDataGridView.Name = "SourceMetadataDataGridView"
        Me.SourceMetadataDataGridView.ReadOnly = True
        Me.SourceMetadataDataGridView.Size = New System.Drawing.Size(288, 461)
        Me.SourceMetadataDataGridView.TabIndex = 4
        '
        'SourceDataGridView
        '
        Me.SourceDataGridView.AllowUserToAddRows = False
        Me.SourceDataGridView.AllowUserToDeleteRows = False
        Me.SourceDataGridView.AllowUserToOrderColumns = True
        Me.SourceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SourceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SourceDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.SourceDataGridView.Name = "SourceDataGridView"
        Me.SourceDataGridView.ReadOnly = True
        Me.SourceDataGridView.Size = New System.Drawing.Size(574, 461)
        Me.SourceDataGridView.TabIndex = 1
        '
        'LoadSourceDataButton
        '
        Me.LoadSourceDataButton.Location = New System.Drawing.Point(709, 33)
        Me.LoadSourceDataButton.Name = "LoadSourceDataButton"
        Me.LoadSourceDataButton.Size = New System.Drawing.Size(101, 23)
        Me.LoadSourceDataButton.TabIndex = 3
        Me.LoadSourceDataButton.Text = "Import dataset"
        Me.LoadSourceDataButton.UseVisualStyleBackColor = True
        '
        'WorksheetsComboBox
        '
        Me.WorksheetsComboBox.FormattingEnabled = True
        Me.WorksheetsComboBox.Location = New System.Drawing.Point(97, 33)
        Me.WorksheetsComboBox.Name = "WorksheetsComboBox"
        Me.WorksheetsComboBox.Size = New System.Drawing.Size(499, 21)
        Me.WorksheetsComboBox.TabIndex = 2
        '
        'DestinationTabPage
        '
        Me.DestinationTabPage.Controls.Add(Me.DestinationDatasetSplitContainer)
        Me.DestinationTabPage.Location = New System.Drawing.Point(4, 22)
        Me.DestinationTabPage.Name = "DestinationTabPage"
        Me.DestinationTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DestinationTabPage.Size = New System.Drawing.Size(877, 529)
        Me.DestinationTabPage.TabIndex = 1
        Me.DestinationTabPage.Text = "Destination dataset"
        Me.DestinationTabPage.UseVisualStyleBackColor = True
        '
        'DestinationDatasetSplitContainer
        '
        Me.DestinationDatasetSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DestinationDatasetSplitContainer.Location = New System.Drawing.Point(3, 3)
        Me.DestinationDatasetSplitContainer.Name = "DestinationDatasetSplitContainer"
        Me.DestinationDatasetSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'DestinationDatasetSplitContainer.Panel1
        '
        Me.DestinationDatasetSplitContainer.Panel1.Controls.Add(Me.ConnectButton)
        Me.DestinationDatasetSplitContainer.Panel1.Controls.Add(Me.Label4)
        Me.DestinationDatasetSplitContainer.Panel1.Controls.Add(Me.DatabaseTextBox)
        Me.DestinationDatasetSplitContainer.Panel1.Controls.Add(Me.Label3)
        Me.DestinationDatasetSplitContainer.Panel1.Controls.Add(Me.DatabaseServerTextBox)
        Me.DestinationDatasetSplitContainer.Panel1.Controls.Add(Me.Label2)
        Me.DestinationDatasetSplitContainer.Panel1.Controls.Add(Me.Label1)
        Me.DestinationDatasetSplitContainer.Panel1.Controls.Add(Me.DestinationConnectionStringTextBox)
        Me.DestinationDatasetSplitContainer.Panel1.Controls.Add(Me.LoadDestinationButton)
        Me.DestinationDatasetSplitContainer.Panel1.Controls.Add(Me.DestinationTablesComboBox)
        '
        'DestinationDatasetSplitContainer.Panel2
        '
        Me.DestinationDatasetSplitContainer.Panel2.Controls.Add(Me.DestinationSplitContainer)
        Me.DestinationDatasetSplitContainer.Size = New System.Drawing.Size(871, 523)
        Me.DestinationDatasetSplitContainer.SplitterDistance = 103
        Me.DestinationDatasetSplitContainer.TabIndex = 8
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(264, 44)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(75, 23)
        Me.ConnectButton.TabIndex = 13
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Database"
        '
        'DatabaseTextBox
        '
        Me.DatabaseTextBox.Location = New System.Drawing.Point(114, 44)
        Me.DatabaseTextBox.Name = "DatabaseTextBox"
        Me.DatabaseTextBox.Size = New System.Drawing.Size(143, 20)
        Me.DatabaseTextBox.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Database server"
        '
        'DatabaseServerTextBox
        '
        Me.DatabaseServerTextBox.Location = New System.Drawing.Point(114, 22)
        Me.DatabaseServerTextBox.Name = "DatabaseServerTextBox"
        Me.DatabaseServerTextBox.Size = New System.Drawing.Size(224, 20)
        Me.DatabaseServerTextBox.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tables:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(342, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Database connection string:"
        '
        'LoadDestinationButton
        '
        Me.LoadDestinationButton.Location = New System.Drawing.Point(264, 70)
        Me.LoadDestinationButton.Name = "LoadDestinationButton"
        Me.LoadDestinationButton.Size = New System.Drawing.Size(140, 23)
        Me.LoadDestinationButton.TabIndex = 4
        Me.LoadDestinationButton.Text = "Import data and schema"
        Me.LoadDestinationButton.UseVisualStyleBackColor = True
        '
        'DestinationTablesComboBox
        '
        Me.DestinationTablesComboBox.FormattingEnabled = True
        Me.DestinationTablesComboBox.Location = New System.Drawing.Point(114, 70)
        Me.DestinationTablesComboBox.Name = "DestinationTablesComboBox"
        Me.DestinationTablesComboBox.Size = New System.Drawing.Size(143, 21)
        Me.DestinationTablesComboBox.TabIndex = 5
        '
        'DestinationSplitContainer
        '
        Me.DestinationSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DestinationSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.DestinationSplitContainer.Name = "DestinationSplitContainer"
        '
        'DestinationSplitContainer.Panel1
        '
        Me.DestinationSplitContainer.Panel1.Controls.Add(Me.DestinationMetadataDataGridView)
        '
        'DestinationSplitContainer.Panel2
        '
        Me.DestinationSplitContainer.Panel2.Controls.Add(Me.DestinationDataGridView)
        Me.DestinationSplitContainer.Size = New System.Drawing.Size(871, 416)
        Me.DestinationSplitContainer.SplitterDistance = 289
        Me.DestinationSplitContainer.TabIndex = 7
        '
        'DestinationMetadataDataGridView
        '
        Me.DestinationMetadataDataGridView.AllowUserToAddRows = False
        Me.DestinationMetadataDataGridView.AllowUserToDeleteRows = False
        Me.DestinationMetadataDataGridView.AllowUserToOrderColumns = True
        Me.DestinationMetadataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DestinationMetadataDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DestinationMetadataDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.DestinationMetadataDataGridView.Name = "DestinationMetadataDataGridView"
        Me.DestinationMetadataDataGridView.ReadOnly = True
        Me.DestinationMetadataDataGridView.Size = New System.Drawing.Size(289, 416)
        Me.DestinationMetadataDataGridView.TabIndex = 3
        '
        'DestinationDataGridView
        '
        Me.DestinationDataGridView.AllowUserToAddRows = False
        Me.DestinationDataGridView.AllowUserToDeleteRows = False
        Me.DestinationDataGridView.AllowUserToOrderColumns = True
        Me.DestinationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DestinationDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DestinationDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.DestinationDataGridView.Name = "DestinationDataGridView"
        Me.DestinationDataGridView.ReadOnly = True
        Me.DestinationDataGridView.Size = New System.Drawing.Size(578, 416)
        Me.DestinationDataGridView.TabIndex = 2
        '
        'MappingTabPage
        '
        Me.MappingTabPage.Controls.Add(Me.MappingsSplitContainer)
        Me.MappingTabPage.Location = New System.Drawing.Point(4, 22)
        Me.MappingTabPage.Name = "MappingTabPage"
        Me.MappingTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.MappingTabPage.Size = New System.Drawing.Size(877, 529)
        Me.MappingTabPage.TabIndex = 2
        Me.MappingTabPage.Text = "Column mapping"
        Me.MappingTabPage.UseVisualStyleBackColor = True
        '
        'MappingsSplitContainer
        '
        Me.MappingsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MappingsSplitContainer.Location = New System.Drawing.Point(3, 3)
        Me.MappingsSplitContainer.Name = "MappingsSplitContainer"
        '
        'MappingsSplitContainer.Panel1
        '
        Me.MappingsSplitContainer.Panel1.Controls.Add(Me.MappingDataGridView)
        '
        'MappingsSplitContainer.Panel2
        '
        Me.MappingsSplitContainer.Panel2.Controls.Add(Me.SqlTextBox)
        Me.MappingsSplitContainer.Panel2.Controls.Add(Me.SqlToolStrip)
        Me.MappingsSplitContainer.Size = New System.Drawing.Size(871, 523)
        Me.MappingsSplitContainer.SplitterDistance = 290
        Me.MappingsSplitContainer.TabIndex = 1
        '
        'MappingDataGridView
        '
        Me.MappingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MappingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MappingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DestinationColumn, Me.SourceColumn, Me.DefaultValueColumn, Me.QuotedColumn})
        Me.MappingDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MappingDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MappingDataGridView.Name = "MappingDataGridView"
        Me.MappingDataGridView.Size = New System.Drawing.Size(290, 523)
        Me.MappingDataGridView.TabIndex = 0
        '
        'DestinationColumn
        '
        Me.DestinationColumn.HeaderText = "Destination column"
        Me.DestinationColumn.Name = "DestinationColumn"
        '
        'SourceColumn
        '
        Me.SourceColumn.HeaderText = "Source column"
        Me.SourceColumn.Name = "SourceColumn"
        '
        'DefaultValueColumn
        '
        Me.DefaultValueColumn.HeaderText = "Default value"
        Me.DefaultValueColumn.Name = "DefaultValueColumn"
        '
        'QuotedColumn
        '
        Me.QuotedColumn.FalseValue = "False"
        Me.QuotedColumn.HeaderText = "Quote in SQL"
        Me.QuotedColumn.Name = "QuotedColumn"
        Me.QuotedColumn.TrueValue = "True"
        '
        'SqlTextBox
        '
        Me.SqlTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SqlTextBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SqlTextBox.Location = New System.Drawing.Point(0, 25)
        Me.SqlTextBox.Multiline = True
        Me.SqlTextBox.Name = "SqlTextBox"
        Me.SqlTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.SqlTextBox.Size = New System.Drawing.Size(577, 498)
        Me.SqlTextBox.TabIndex = 0
        Me.SqlTextBox.WordWrap = False
        '
        'SqlToolStrip
        '
        Me.SqlToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerateQueriesToolStripButton, Me.ToolStripSeparator1, Me.GenerateInsertQueriesToolStripButton})
        Me.SqlToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.SqlToolStrip.Name = "SqlToolStrip"
        Me.SqlToolStrip.Size = New System.Drawing.Size(577, 25)
        Me.SqlToolStrip.TabIndex = 1
        Me.SqlToolStrip.Text = "ToolStrip1"
        '
        'GenerateQueriesToolStripButton
        '
        Me.GenerateQueriesToolStripButton.Image = CType(resources.GetObject("GenerateQueriesToolStripButton.Image"), System.Drawing.Image)
        Me.GenerateQueriesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GenerateQueriesToolStripButton.Name = "GenerateQueriesToolStripButton"
        Me.GenerateQueriesToolStripButton.Size = New System.Drawing.Size(115, 22)
        Me.GenerateQueriesToolStripButton.Text = "Generate queries"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'GenerateInsertQueriesToolStripButton
        '
        Me.GenerateInsertQueriesToolStripButton.Image = CType(resources.GetObject("GenerateInsertQueriesToolStripButton.Image"), System.Drawing.Image)
        Me.GenerateInsertQueriesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GenerateInsertQueriesToolStripButton.Name = "GenerateInsertQueriesToolStripButton"
        Me.GenerateInsertQueriesToolStripButton.Size = New System.Drawing.Size(125, 22)
        Me.GenerateInsertQueriesToolStripButton.Text = "Export SQL script..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Source dataset:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Worksheet:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 555)
        Me.Controls.Add(Me.MainTabControl)
        Me.Name = "Form1"
        Me.Text = "File to SQL"
        Me.MainTabControl.ResumeLayout(False)
        Me.SourceTabPage.ResumeLayout(False)
        Me.SourceTabPage.PerformLayout()
        Me.SourceSplitContainer.Panel1.ResumeLayout(False)
        Me.SourceSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.SourceSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SourceSplitContainer.ResumeLayout(False)
        CType(Me.SourceMetadataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DestinationTabPage.ResumeLayout(False)
        Me.DestinationDatasetSplitContainer.Panel1.ResumeLayout(False)
        Me.DestinationDatasetSplitContainer.Panel1.PerformLayout()
        Me.DestinationDatasetSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.DestinationDatasetSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DestinationDatasetSplitContainer.ResumeLayout(False)
        Me.DestinationSplitContainer.Panel1.ResumeLayout(False)
        Me.DestinationSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.DestinationSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DestinationSplitContainer.ResumeLayout(False)
        CType(Me.DestinationMetadataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MappingTabPage.ResumeLayout(False)
        Me.MappingsSplitContainer.Panel1.ResumeLayout(False)
        Me.MappingsSplitContainer.Panel2.ResumeLayout(False)
        Me.MappingsSplitContainer.Panel2.PerformLayout()
        CType(Me.MappingsSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MappingsSplitContainer.ResumeLayout(False)
        CType(Me.MappingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SqlToolStrip.ResumeLayout(False)
        Me.SqlToolStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SourceFileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DestinationConnectionStringTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MainTabControl As System.Windows.Forms.TabControl
    Friend WithEvents SourceTabPage As System.Windows.Forms.TabPage
    Friend WithEvents SourceDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DestinationTabPage As System.Windows.Forms.TabPage
    Friend WithEvents WorksheetsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LoadSourceDataButton As System.Windows.Forms.Button
    Friend WithEvents SourceMetadataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents LoadDestinationButton As System.Windows.Forms.Button
    Friend WithEvents DestinationMetadataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DestinationDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DestinationTablesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SourceSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents DestinationSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents MappingTabPage As System.Windows.Forms.TabPage
    Friend WithEvents MappingDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MappingsSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents SqlTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SqlToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents GenerateQueriesToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents LoadWorksheetsButton As System.Windows.Forms.Button
    Friend WithEvents ImportDatasetButton As System.Windows.Forms.Button
    Friend WithEvents DestinationDatasetSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DestinationColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SourceColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DefaultValueColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuotedColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GenerateInsertQueriesToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenSourceDatasetButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DatabaseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DatabaseServerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConnectButton As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
