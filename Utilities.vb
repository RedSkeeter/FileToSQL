Imports System.Data.OleDb
Imports System.IO
Imports Microsoft
Imports System.Data.SqlClient

Module Utilities

    Public Function GetCSVDataTable(ConnectionString As String, CSVFile As String) As DataTable
        Dim MyDataTable As New DataTable 'this datatable will hold the imported data
        Try
            Dim dt As New DataTable
            Using Adp As New OleDbDataAdapter("select * from [" & CSVFile & "]", ConnectionString)
                Adp.Fill(MyDataTable)
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try
        Return MyDataTable
    End Function

    ''' <summary>
    ''' Converts an Excel worksheet to a .Net DataTable
    ''' </summary>
    ''' <param name="ExcelConnectionString">ConnectionString. ConnectionString to Excel workbook</param>
    ''' <param name="WorksheetName">String.  Name of the worksheet to convert to a DataTable</param>
    ''' <returns>DataTable</returns>
    ''' <remarks></remarks>
    Public Function GetExcelDataTable(ExcelConnectionString As String, WorksheetName As String) As DataTable
        Dim ExcelDataTable As New DataTable 'this datatable will hold the imported data
        Try
            Dim Sql As String = "SELECT * FROM [" & WorksheetName & "]"
            Dim MyConnection As New OleDbConnection(ExcelConnectionString)
            MyConnection.Open()
            Dim MyCommand As New OleDbCommand(Sql, MyConnection)
            Dim MyDataAdapter As New OleDbDataAdapter(MyCommand)
            MyDataAdapter.Fill(ExcelDataTable)
            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try
        Return ExcelDataTable
    End Function

    ''' <summary>
    ''' Accepts a ConnectionString to an Excel workbook and returns a DataTable of the workbook's worksheet names.
    ''' </summary>
    ''' <param name="ExcelConnectionString">ConnectionString to the Excel workbook to process.</param>
    ''' <returns>DataTable.  A DataTable of worksheet names</returns>
    ''' <remarks></remarks>
    Public Function GetExcelWorksheets(ExcelConnectionString As String) As DataTable
        Dim ExcelWorksheetsDataTable As New DataTable
        Try
            Dim MyConnection As New OleDbConnection(ExcelConnectionString)
            MyConnection.Open()
            ExcelWorksheetsDataTable = MyConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try
        Return ExcelWorksheetsDataTable
    End Function


    ''' <summary>
    ''' Accepts a ConnectionString to a SQL Server database and a SELECT query and returns a DataTable.
    ''' </summary>
    ''' <param name="ConnectionString">ConnectionString to a SQL Server database. ConnectionString</param>
    ''' <param name="Query">SELECT query. String.</param>
    ''' <returns>DataTable</returns>
    ''' <remarks></remarks>
    Public Function GetSqlServerDataTable(ByVal ConnectionString As String, ByVal Query As String) As DataTable
        Dim MyDataTable As New DataTable
        Try
            Dim MySqlConnection As New SqlConnection(ConnectionString)
            MySqlConnection.Open()
            Dim MySqlCommand As New SqlCommand(Query, MySqlConnection)
            Dim MyDataReader As SqlDataReader = MySqlCommand.ExecuteReader
            MyDataTable.Load(MyDataReader)
            MySqlConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try
        Return MyDataTable
    End Function

    Public Function GetMetadataDataTable(InputDataTable As DataTable) As DataTable
        Dim ColumnsDataTable As New DataTable("Columns")


        'column names column
        Dim ColumnNameColumn As New DataColumn
        With ColumnNameColumn
            .DataType = System.Type.GetType("System.String")
            .Caption = "Column name"
            .ColumnName = "ColumnName"
        End With

        'data type column
        Dim DataTypeColumn As New DataColumn
        With DataTypeColumn
            .DataType = System.Type.GetType("System.String")
            .Caption = "Data type"
            .ColumnName = "DataType"
        End With

        'units column
        Dim UnitsColumn As New DataColumn
        With UnitsColumn
            .DataType = System.Type.GetType("System.String")
            .Caption = "Units"
            .ColumnName = "Units"
        End With

        'allowdbnull column
        Dim AllowDBNullColumn As New DataColumn
        With AllowDBNullColumn
            .DataType = System.Type.GetType("System.String")
            .Caption = "AllowDBNULL"
            .ColumnName = "AllowDBNull"
        End With

        'AutoIncrement column
        Dim AutoIncrementColumn As New DataColumn
        With AutoIncrementColumn
            .DataType = System.Type.GetType("System.String")
            .Caption = "AutoIncrement"
            .ColumnName = "AutoIncrement"
        End With

        'AutoIncrementSeed column
        Dim AutoIncrementSeedColumn As New DataColumn
        With AutoIncrementSeedColumn
            .DataType = System.Type.GetType("System.String")
            .Caption = "AutoIncrementSeed"
            .ColumnName = "AutoIncrementSeed"
        End With

        'AutoIncrementStep column
        Dim AutoIncrementStepColumn As New DataColumn
        With AutoIncrementStepColumn
            .DataType = System.Type.GetType("System.String")
            .Caption = "AutoIncrementStep"
            .ColumnName = "AutoIncrementStep"
        End With

        'Caption column
        Dim CaptionColumn As New DataColumn
        With CaptionColumn
            .DataType = System.Type.GetType("System.String")
            .Caption = "Caption"
            .ColumnName = "Caption"
        End With

        'ColumnMapping column
        Dim ColumnMappingColumn As New DataColumn
        With ColumnMappingColumn
            .DataType = System.Type.GetType("System.String")
            .Caption = "ColumnMapping"
            .ColumnName = "ColumnMapping"
        End With

        'DateTimeMode column
        Dim DateTimeModeColumn As New DataColumn
        With DateTimeModeColumn
            .DataType = System.Type.GetType("System.String")
            .Caption = "DateTimeMode"
            .ColumnName = "DateTimeMode"
        End With

        'DefaultValue column
        Dim DefaultValueColumn As New DataColumn
        With DefaultValueColumn
            .DataType = System.Type.GetType("System.String")
            .Caption = "DefaultValue"
            .ColumnName = "DefaultValue"
        End With

        'Expression column
        Dim ExpressionColumn As New DataColumn
        With ExpressionColumn
            .DataType = System.Type.GetType("System.String")
            .Caption = "Expression"
            .ColumnName = "Expression"
        End With

        'ExtendedProperties column
        'Dim ExtendedPropertiesColumn As New DataColumn
        'With ExtendedPropertiesColumn
        '    .DataType = System.Type.GetType("System.String")
        '    .Caption = "ExtendedProperties"
        '    .ColumnName = "ExtendedProperties"
        'End With

        'MaxLength column
        Dim MaxLengthColumn As New DataColumn
        With MaxLengthColumn
            .DataType = System.Type.GetType("System.String")
            .Caption = "MaxLength"
            .ColumnName = "MaxLength"
        End With

        'Table column
        Dim TableColumn As New DataColumn
        With TableColumn
            .DataType = System.Type.GetType("System.String")
            .Caption = "Table"
            .ColumnName = "Table"
        End With

        'Unique column
        Dim UniqueColumn As New DataColumn
        With UniqueColumn
            .DataType = System.Type.GetType("System.String")
            .Caption = "Unique"
            .ColumnName = "Unique"
        End With

        'add the columns to the datatable
        ColumnsDataTable.Columns.Add(ColumnNameColumn)
        ColumnsDataTable.Columns.Add(CaptionColumn)
        ColumnsDataTable.Columns.Add(DataTypeColumn)
        ColumnsDataTable.Columns.Add(UnitsColumn)
        ColumnsDataTable.Columns.Add(AllowDBNullColumn)
        ColumnsDataTable.Columns.Add(UniqueColumn)
        ColumnsDataTable.Columns.Add(DefaultValueColumn)
        ColumnsDataTable.Columns.Add(AutoIncrementColumn)
        ColumnsDataTable.Columns.Add(AutoIncrementSeedColumn)
        ColumnsDataTable.Columns.Add(AutoIncrementStepColumn)
        ColumnsDataTable.Columns.Add(ColumnMappingColumn)
        ColumnsDataTable.Columns.Add(ExpressionColumn)
        'ColumnsDataTable.Columns.Add(ExtendedPropertiesColumn)
        ColumnsDataTable.Columns.Add(MaxLengthColumn)
        ColumnsDataTable.Columns.Add(TableColumn)

        ColumnsDataTable.Columns.Add(DateTimeModeColumn)


        'load the columns data table with info about the input data table
        For Each Column As DataColumn In InputDataTable.Columns
            Dim NewRow As DataRow = ColumnsDataTable.NewRow
            NewRow.Item("ColumnName") = Column.ColumnName
            NewRow.Item("DataType") = Column.DataType.ToString.Replace("System.", "")
            NewRow.Item("AllowDBNull") = Column.AllowDBNull
            NewRow.Item("AutoIncrement") = Column.AutoIncrement
            NewRow.Item("AutoIncrementSeed") = Column.AutoIncrementSeed
            NewRow.Item("AutoIncrementStep") = Column.AutoIncrementStep
            NewRow.Item("Caption") = Column.Caption
            NewRow.Item("ColumnMapping") = Column.ColumnMapping
            NewRow.Item("DefaultValue") = Column.DefaultValue
            NewRow.Item("Expression") = Column.Expression
            'NewRow.Item("ExtendedProperties") = Column.ExtendedProperties
            NewRow.Item("MaxLength") = Column.MaxLength
            NewRow.Item("Table") = Column.Table
            NewRow.Item("Unique") = Column.Unique
            NewRow.Item("DateTimeMode") = Column.DateTimeMode

            'add the row to the table
            ColumnsDataTable.Rows.Add(NewRow)

        Next
        Return ColumnsDataTable
    End Function

    Public Function GetMappingsDataTable() As DataTable
        Dim MappingsDataTable As New DataTable("Mappings")

        'build a column names column
        Dim DestinationColumn As New DataColumn
        With DestinationColumn
            .DataType = System.Type.GetType("System.String")
            .Caption = "Destination column"
            .ColumnName = "DestinationColumnName"
        End With

        'build a data type column
        Dim SourceColumn As New DataColumn
        With SourceColumn
            .DataType = System.Type.GetType("System.String")
            .Caption = "Source column"
            .ColumnName = "SourceColumnName"
        End With

        'build a default value column
        Dim DefaultValueColumn As New DataColumn
        With DefaultValueColumn
            .DataType = System.Type.GetType("System.String")
            .Caption = "Default value"
            .ColumnName = "DefaultValueColumn"
        End With

        'build a boolean 'quoted' column
        Dim QuotedColumn As New DataColumn
        With QuotedColumn
            .DataType = System.Type.GetType("System.String")
            .Caption = "Quoted"
            .ColumnName = "QuotedColumn"
            .DefaultValue = False
        End With

        'add the columns to the datatable
        MappingsDataTable.Columns.Add(DestinationColumn)
        MappingsDataTable.Columns.Add(SourceColumn)
        MappingsDataTable.Columns.Add(DefaultValueColumn)
        MappingsDataTable.Columns.Add(QuotedColumn)
        Return MappingsDataTable
    End Function

    'build a database connectionstring
    Public Function GetConnectionString(Datasource As String, Database As String, Optional ConnectionString As String = "") As String
        Dim MyConnectionStringBuilder As New SqlClient.SqlConnectionStringBuilder(ConnectionString)
        Try
            With MyConnectionStringBuilder
                .DataSource = Datasource
                .InitialCatalog = Database
                .IntegratedSecurity = True
            End With
        Catch ex As Exception
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try
        ConnectionString = MyConnectionStringBuilder.ConnectionString
        Return ConnectionString
    End Function

End Module
