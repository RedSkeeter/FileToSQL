Imports System.IO
Imports System.Data.SqlClient

Public Class Form1



    Private Sub LoadSourceDataButton_Click(sender As System.Object, e As System.EventArgs) Handles LoadSourceDataButton.Click
        LoadSourceDataset()
    End Sub

    Private Sub LoadWorksheetsButton_Click(sender As System.Object, e As System.EventArgs) Handles LoadWorksheetsButton.Click
        LoadWorksheetsComboBox(Me.SourceFileTextBox.Text)
    End Sub


    ''' <summary>
    ''' Extracts the worksheets from a workbook and loads them into the worksheets combobox
    ''' </summary>
    ''' <param name="Workbook">Path to Excel workbook. String.</param>
    ''' <remarks></remarks>
    Private Sub LoadWorksheetsComboBox(Workbook As String)
        If My.Computer.FileSystem.FileExists(Workbook) Then
            Try
                'clear out any existing sheets
                Me.WorksheetsComboBox.Items.Clear()

                'build a connectionstring
                Dim ExcelConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Me.SourceFileTextBox.Text & ";Extended Properties='Excel 12.0 Xml;HDR=YES';"

                'get the worksheets into a datatable
                Dim WorksheetsDataTable As DataTable = GetExcelWorksheets(ExcelConnectionString)

                'load the sheet names into the combobox
                For Each SheetRow As DataRow In WorksheetsDataTable.Rows
                    Me.WorksheetsComboBox.Items.Add(SheetRow.Item("TABLE_NAME"))
                Next

                If Me.WorksheetsComboBox.Items.Count >= 0 Then
                    Me.WorksheetsComboBox.SelectedIndex = 0
                End If
            Catch ex As Exception
                MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
            End Try

        Else
            MsgBox("Please select a workbook")
        End If
    End Sub

    Private Sub LoadSourceDataset()
        'clear things
        Me.SourceDataGridView.DataSource = Nothing
        Me.SourceMetadataDataGridView.DataSource = Nothing
        Me.WorksheetsComboBox.Items.Clear()
        Me.SqlTextBox.Text = ""

        Try
            'ensure the source file exists
            If My.Computer.FileSystem.FileExists(Me.SourceFileTextBox.Text) Then
                Me.LoadWorksheetsButton.Enabled = True

                'get a fileinfo on the source file
                Dim MyFileInfo As New FileInfo(Me.SourceFileTextBox.Text)

                'determine the file type
                If MyFileInfo.Extension = ".xls" Or MyFileInfo.Extension = ".xlsx" Then
                    'EXCEL: load the excel worksheets into a combobox
                    LoadWorksheetsComboBox(Me.SourceFileTextBox.Text) 'excel sheet

                    'if there is a worksheet available try to load it
                    If Me.WorksheetsComboBox.Text.Trim.Length > 0 Then
                        Dim ExcelConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & MyFileInfo.FullName & ";Extended Properties='Excel 12.0 Xml;HDR=YES';"

                        'try to load the worksheet's data
                        Dim ExcelDataTable As DataTable = GetExcelDataTable(ExcelConnectionString, Me.WorksheetsComboBox.Text)
                        Me.SourceDataGridView.DataSource = ExcelDataTable
                        Me.SourceMetadataDataGridView.DataSource = GetMetadataDataTable(ExcelDataTable)
                    End If
                ElseIf MyFileInfo.Extension = ".csv" Then
                    'CSV: load the data
                    Me.LoadWorksheetsButton.Enabled = False
                    Me.WorksheetsComboBox.Items.Clear()
                    Dim CSVDirectory = MyFileInfo.DirectoryName '"C:\Work\VitalSigns\ARCN Brown Bears\Data\2016 Bear Survey NOAT\Deliverable BB-01-Waypoints"
                    Dim CSVConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & CSVDirectory & ";Extended Properties=""text;HDR=YES;FMT=Delimited"";"
                    Dim CSVDataTable As DataTable = GetCSVDataTable(CSVConnectionString, MyFileInfo.Name)
                    Me.SourceDataGridView.DataSource = CSVDataTable
                    Me.SourceMetadataDataGridView.DataSource = GetMetadataDataTable(CSVDataTable)
                Else
                    Me.LoadWorksheetsButton.Enabled = False
                    Me.WorksheetsComboBox.Items.Clear()
                    MsgBox("A file import function for this file type has not yet been included")
                End If
            Else
                MsgBox("Source file not found")
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try

        'try to load the mapping grid
        If Me.DestinationDataGridView.RowCount > 0 Then
            LoadMappingGrid()
        End If
    End Sub

    Private Sub LoadDestinationButton_Click(sender As System.Object, e As System.EventArgs) Handles LoadDestinationButton.Click
        Dim Query As String = "SELECT TOP 100 * FROM " & Me.DestinationTablesComboBox.Text & ";"
        LoadDestinationDataset(Query)
    End Sub

    Private Sub LoadDestinationDataset(Query As String)
        'clear things
        Me.DestinationDataGridView.DataSource = Nothing
        Me.DestinationMetadataDataGridView.DataSource = Nothing

        'load the datatables
        Dim DestinationDataTable As DataTable = GetSqlServerDataTable(Me.DestinationConnectionStringTextBox.Text, Query)
        Me.DestinationDataGridView.DataSource = DestinationDataTable
        Me.DestinationMetadataDataGridView.DataSource = GetMetadataDataTable(DestinationDataTable)
        If Me.SourceDataGridView.RowCount > 0 Then
            LoadMappingGrid()
        End If

    End Sub

    Private Sub LoadMappingGrid()
        'crate a datatable to hold the column mappings
        Dim MappingsDataTable As DataTable = GetMappingsDataTable()
        MappingsDataTable.Clear()

        'clear out the source columns combobox's items
        Dim SourceColumn As DataGridViewComboBoxColumn = Me.MappingDataGridView.Columns("SourceColumn")
        SourceColumn.Items.Clear()

        Try
            'load the source and destination column names into the columns mapping grid
            Dim DestinationDataTable As DataTable = Me.DestinationDataGridView.DataSource
            For Each DestinationColumn As DataColumn In DestinationDataTable.Columns
                Dim NewRow As DataRow = MappingsDataTable.NewRow
                NewRow.Item("DestinationColumnName") = DestinationColumn.ColumnName
                NewRow.Item("SourceColumnName") = ""
                NewRow.Item("QuotedColumn") = False
                If DestinationColumn.DataType.ToString.Contains("String") Or DestinationColumn.DataType.ToString.Contains("Date") Then
                    NewRow.Item("QuotedColumn") = True
                Else
                    NewRow.Item("QuotedColumn") = False
                End If


                MappingsDataTable.Rows.Add(NewRow)
            Next

            'map the datagridviewcolumns to datatable columns
            Me.MappingDataGridView.Columns("DestinationColumn").DataPropertyName = "DestinationColumnName"
            Me.MappingDataGridView.Columns("DefaultValueColumn").DataPropertyName = "DefaultValueColumn"
            Me.MappingDataGridView.Columns("QuotedColumn").DataPropertyName = "QuotedColumn"

            Dim SourceMetadataDataTable As DataTable = Me.SourceMetadataDataGridView.DataSource
            With SourceColumn
                .DataPropertyName = "SourceColumnName"
                .Items.Add("")
                .Items.Add("Default value")
                For Each Row As DataRow In SourceMetadataDataTable.Rows
                    Dim SourceColumnName As String = Row.Item("ColumnName")
                    .Items.Add(SourceColumnName)
                Next
            End With
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
        Me.MappingDataGridView.DataSource = MappingsDataTable
    End Sub

    Private Sub GenerateInsertQueries()
        'close out any changes to the mappings datatable
        Me.MappingDataGridView.EndEdit()

        'build up some documentation on the script
        Dim Intro As String = "-- Data import scrip" & vbNewLine
        Intro = Intro & "-- Source file: " & Me.SourceFileTextBox.Text & vbNewLine
        Intro = Intro & "-- Generated on " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & " by " & My.User.Name & vbNewLine & vbNewLine

        Intro = Intro & "USE WRST_Caribou" & vbNewLine
        Intro = Intro & "-- Do not forget to ROLLBACK or COMMIT the transaction below or the database will be left in a hanging state" & vbNewLine
        Intro = Intro & "BEGIN TRANSACTION" & vbNewLine
        Me.SqlTextBox.Text = Intro & vbNewLine

        Try
            'the source data
            Dim SourceDataTable As DataTable = Me.SourceDataGridView.DataSource

            'the table of column mappings
            Dim MappingsDataTable As DataTable = Me.MappingDataGridView.DataSource


            'loop through each record in the source datatable
            For Each SourceRow As DataRow In SourceDataTable.Rows
                Dim Sql As String = "INSERT INTO " & Me.DestinationTablesComboBox.Text & "("
                Dim InsertColumns As String = ""
                Dim ValuesList As String = ""

                'build a list of INSERT query columns from the checked columns in the mapping table
                If MappingsDataTable.Rows.Count > 0 Then
                    For Each MappingRow As DataRow In MappingsDataTable.Rows
                        If MappingRow.Item("DestinationColumnName").ToString.Trim <> "" And MappingRow.Item("SourceColumnName").ToString.Trim <> "" Then
                            'append the insert column name 
                            InsertColumns = InsertColumns & MappingRow.Item("DestinationColumnName") & ","

                            'values list
                            Dim SourceRowColumnName As String = MappingRow.Item("SourceColumnName")


                            'get the value of the source row item
                            Dim SourceRowValue As String = ""
                            'determine if we should use the default value or not
                            If MappingRow.Item("SourceColumnName").ToString.Trim <> "Default value" Then
                                SourceRowValue = SourceRow.Item(SourceRowColumnName).ToString.Trim
                            Else
                                SourceRowValue = MappingRow.Item("DefaultValueColumn").ToString.Trim
                            End If

                            'quote or not
                            If MappingRow.Item("QuotedColumn") = True Then
                                ValuesList = ValuesList & "'" & SourceRowValue.Trim & "'" & ","
                            Else
                                ValuesList = ValuesList & SourceRowValue.Trim & ","
                            End If

                        End If
                    Next
                End If

                'trim trailing comma
                If InsertColumns.Trim.Length > 0 Then
                    InsertColumns = InsertColumns.Substring(0, Len(InsertColumns.Trim) - 1)
                End If

                'trim trailing comma
                If ValuesList.Trim.Length > 0 Then
                    ValuesList = ValuesList.Substring(0, Len(ValuesList.Trim) - 1)
                End If

                Sql = Sql & InsertColumns & ") VALUES(" & ValuesList & ");"
                Me.SqlTextBox.AppendText(Sql & vbNewLine)
            Next
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub LoadDestinationTablesComboBoxButton_Click(sender As System.Object, e As System.EventArgs)
        LoadDestinationTablesComboBox()
    End Sub

    Private Sub LoadDestinationTables()
        Try
            Dim Query As String = "Select Name, ID FROM SysObjects where xtype = 'u' and name <> 'dtproperties' order by name asc"
            Me.DestinationDataGridView.DataSource = Nothing
            Me.DestinationTablesComboBox.Items.Clear()
            Dim TablesDataTable As DataTable = GetSqlServerDataTable(Me.DestinationConnectionStringTextBox.Text, Query)

            For Each Row As DataRow In TablesDataTable.Rows
                Me.DestinationTablesComboBox.Items.Add(Row.Item("Name"))
            Next

            'show the first table name in the combobox
            If Me.DestinationTablesComboBox.Items.Count > 0 Then
                Me.DestinationTablesComboBox.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub LoadDestinationTablesComboBox()
        LoadDestinationTables()
    End Sub

    Private Sub GenerateQueriesToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles GenerateQueriesToolStripButton.Click
        GenerateInsertQueries()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.ConnectionString = Me.DestinationConnectionStringTextBox.Text
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        If My.Settings.ConnectionString.Trim.Length > 0 Then
            Me.DestinationConnectionStringTextBox.Text = My.Settings.ConnectionString
            Dim MyConnectionString As New SqlConnectionStringBuilder(My.Settings.ConnectionString)
            Me.DatabaseServerTextBox.Text = MyConnectionString.DataSource
            Me.DatabaseTextBox.Text = MyConnectionString.InitialCatalog
        End If
    End Sub


    Private Sub ImportDatasetButton_Click(sender As System.Object, e As System.EventArgs) Handles ImportDatasetButton.Click
        Dim OFD As New OpenFileDialog
        With OFD
            .CheckFileExists = True
            .CheckPathExists = True
            .Multiselect = False
            .Filter = "Dataset Files|*.csv;*.xls;*.xlsx;*.xlsm"
            .Title = "Select a dataset to import"
        End With


        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim Sourcefile As String = OFD.FileName
            Me.SourceFileTextBox.Text = Sourcefile
            LoadSourceDataset()
        End If
    End Sub



    Private Sub MappingDataGridView_RowValidated(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MappingDataGridView.RowValidated
        GenerateInsertQueries()
    End Sub

    Private Sub GenerateInsertQueriesToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles GenerateInsertQueriesToolStripButton.Click
        'get the name of the source file
        Dim SourceFilename As String = ""
        If My.Computer.FileSystem.FileExists(Me.SourceFileTextBox.Text) Then
            Dim SourcefileFileInfo = New FileInfo(Me.SourceFileTextBox.Text)
            SourceFilename = SourcefileFileInfo.Name

            'build a savefiledialog to save the file
            Dim SFD As New SaveFileDialog
            With SFD
                .AddExtension = True
                .DefaultExt = ".sql"
                .FileName = SourceFilename.Replace(SourcefileFileInfo.Extension, ".sql")
                .Filter = "SQL files|*.sql"
                .InitialDirectory = SourcefileFileInfo.DirectoryName
                .OverwritePrompt = True
                .RestoreDirectory = False
                .Title = "Save SQL script"
            End With

            'write the text to a file
            If SFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(SFD.FileName, Me.SqlTextBox.Text, False)
            End If
        Else
            MsgBox("No source data file")
        End If

    End Sub



    Private Sub OpenSourceDatasetButton_Click(sender As System.Object, e As System.EventArgs) Handles OpenSourceDatasetButton.Click
        Try
            If My.Computer.FileSystem.FileExists(Me.SourceFileTextBox.Text) Then
                Process.Start(Me.SourceFileTextBox.Text)
            Else
                MsgBox("No source dataset to open")
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try
    End Sub

    Private Sub ConnectButton_Click(sender As System.Object, e As System.EventArgs) Handles ConnectButton.Click
        'clear the tables combobox
        Me.DestinationTablesComboBox.Items.Clear()
        'update the connectionstring
        UpdateConnectionStringTextBox()
    End Sub

    Private Sub UpdateConnectionStringTextBox()
        'build a connectionstring and put it in the connectionstring textbox
        Me.DestinationConnectionStringTextBox.Text = GetConnectionString(Me.DatabaseServerTextBox.Text, Me.DatabaseTextBox.Text, Me.DestinationConnectionStringTextBox.Text)
        Try
            'load the database tables into the combobox
            LoadDestinationTablesComboBox()
        Catch ex As Exception
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try
    End Sub

    Private Sub SourceMetadataDataGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles SourceMetadataDataGridView.DataError
        MsgBox(e.Exception.Message)
    End Sub

    Private Sub SourceDataGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles SourceDataGridView.DataError
        MsgBox(e.Exception.Message)
    End Sub

    Private Sub DestinationMetadataDataGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DestinationMetadataDataGridView.DataError
        MsgBox(e.Exception.Message)
    End Sub

    Private Sub DestinationDataGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DestinationDataGridView.DataError
        'timestamp columns set off this error with a parameter is not valid error, annoying but not fatal
        If e.Exception.Message <> "Parameter is not valid." Then
            MsgBox(e.Exception.Message)
        End If
    End Sub
End Class
