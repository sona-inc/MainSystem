'**************************************
'**************************************
'<<<<<<<<<<"Phat Sovathana">>>>>>>>>>>>
'<<<<<<"Sovathana.phat@mail.ru">>>>>>>>
'<<<<<<<<<<<<"@2015-2016">>>>>>>>>>>>>>
'**************************************
'**************************************
Imports System.Collections.Generic
Imports System.Data
Imports System.Threading
Imports System
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Text
Imports System.Windows
Imports System.IO
Imports System.Linq
Imports System.Web
Imports Microsoft.SqlServer, System.Management




Namespace sqlCms
    Public Class Systemdb
        Public str As String
        Public filePaths As String() = Directory.GetFiles(Directory.GetCurrentDirectory + "\dumps\", "*.sql")
        Public connect As SqlConnection
        Public command As New SqlCommand
        Public rder As SqlDataReader
        Public affected As Integer = 0
        Public bConnected As Boolean = False
        Public tb As DataTable
        Public affected_rows As Integer
        Public squery As String
        Public parameters As List(Of String)
        Public affare As Integer
        Public stype As String



        Public Sub New()
            connection()
            tb = InlineAssignHelper(tb, New DataTable())
            parameters = New List(Of String)()
        End Sub

        Public Sub connection()


            Try
                Dim strConnection As String = sqlCms.Cons.sqlConnect '/"Data Source=IPHONE\SQLEXPRESS;Initial Catalog=dbcms;Integrated Security=True"
                Dim connection As New SqlConnection(strConnection)
                connection.Open()
                connect = connection
                bConnected = True
            Catch ex As SqlException
                Dim exception As String = Convert.ToString("Exception : " + ex.Message.ToString() + vbLf & vbCr & "Application will close now. " & vbLf & vbCr) & squery
                Console.WriteLine(exception, "Uncaught SQL Server Exception")
                Debug(exception)

                Environment.[Exit](1)




            End Try

        End Sub
        Public Sub CloseConn()
            bConnected = False
            connect.Close()
            connect.Dispose()
        End Sub
        Public Sub Sqldumper()


            Dim fils As New StringBuilder()
            Try
                For i As Integer = 0 To filePaths.GetUpperBound(0)
                    Dim script As String = File.ReadAllText(filePaths(i))
                    str = fils.AppendLine(script).ToString
                Next
            Catch ex As Exception

            End Try

            Using connection As New SqlConnection(sqlCms.Cons.sqlConnect)
                connection.Open()
                Using command As SqlCommand = New SqlCommand(str, connection)
                    Try
                        command.ExecuteNonQuery()
                    Catch ex As Exception

                    End Try

                End Using
            End Using


        End Sub
        Public Sub CreateStoreProcedure(sql As String, Optional parameter As String = Nothing, Optional name As String = Nothing)

            Dim query As String = "select * from sysobjects where type='P' and name='" & name & "'"
            Dim spExists As Boolean = False
            Dim sbSP As New StringBuilder()


            If bConnected = False Then
                connection()
            End If
            Using connection As New SqlConnection(sqlCms.Cons.sqlConnect)
                Try
                    connection.Open()
                    Console.WriteLine("ServerVersion: {0}", connection.ServerVersion)
                    Console.WriteLine("Database: {0}", connection.Database)

                    'connection.ChangeDatabase("tbAdminSchema")
                    Console.WriteLine("Database: {0}", connection.Database)
                Catch ex As Exception

                End Try
                Using command As SqlCommand = New SqlCommand(query, connection)


                    Using rder = command.ExecuteReader()
                        While rder.Read()
                            spExists = True
                            Exit While
                        End While
                    End Using

                End Using
                If spExists = True Then
                Else
                    sbSP.AppendLine(Convert.ToString("Create Procedure [" & name & "]" & Convert.ToString(parameter) & Space(1) & " as" & Space(1) & "" & sql & ""))
                    Me.stype = sql.ToLower()
                    If stype.Contains("update") OrElse stype.Contains("insert") OrElse stype.Contains("delete") Then
                        Using cmd As New SqlCommand(sbSP.ToString(), connection)
                            cmd.CommandType = CommandType.Text
                            cmd.ExecuteNonQuery()
                            connect.Close()
                        End Using

                    ElseIf stype.Contains("select") Then
                        Using cmd As New SqlCommand(sbSP.ToString(), connection)
                            cmd.CommandType = CommandType.Text
                            cmd.ExecuteReader()
                            connect.Close()
                        End Using
                    End If

                End If

            End Using

        End Sub
        Private Sub Init(Query As String, Optional sonaData As String() = Nothing, Optional isbinary As Boolean = False, Optional bin As String = Nothing, Optional filebyte As Byte() = Nothing)
            ' Make connection if it's not connect yet.
            If bConnected = False Then
                connection()
            End If

            ' Automatically disposes the SQL Servercommand instance easy for use as offline


            Using command = New SqlCommand(Query, connect)

                ' 
                sona_SetData(sonaData)

                ' SQL injection
                If parameters.Count > 0 Then
                    parameters.ForEach(Sub(parameter As String)
                                           Dim sparameters As String() = parameter.ToString().Split(ChrW(127))
                                           command.Parameters.AddWithValue(sparameters(0), sparameters(1))

                                       End Sub)
                End If

                Me.squery = Query.ToLower()

                If squery.Contains("select") Then
                    Dim dt As New DataTable()
                    Try
                        rder = command.ExecuteReader()
                        dt.Load(rder)
                    Catch my As SqlException
                        Dim exception As String = Convert.ToString("Exception : " + my.Message.ToString() + vbLf & vbCr & " SQL Query : " & vbLf & vbCr) & squery

                        Console.WriteLine(exception, "Uncaught SQL Server Exception")

                        Debug(exception)
                    End Try
                    Me.tb = dt

                End If
                If squery.Contains("delete") OrElse squery.Contains("update") OrElse squery.Contains("insert") Then

                    Try
                        affected = command.ExecuteNonQuery()

                    Catch my As SqlException
                        Dim exception As String = Convert.ToString("Exception : " + my.Message.ToString() + vbLf & vbCr & " SQL Query : " & vbLf & vbCr) & squery

                        Console.WriteLine(exception, "Uncaught SQL Server Exception")

                        Debug(exception)
                    End Try
                    If isbinary = True Then
                        With command.Parameters
                            .Add(bin, SqlDbType.VarBinary, -1).Value = filebyte
                        End With

                        command.ExecuteNonQuery()
                        command.Dispose()
                    End If
                    Me.affected_rows = affected
                End If
            End Using
            If Query.Contains("InsertAdminSchema") Then

            End If

            Me.parameters.Clear()


        End Sub

        Public Sub sona_SetData(field As String, value As String)
            parameters.Add(Convert.ToString((Convert.ToString("@") & field) + ChrW(127)) & value)
        End Sub
        Public parametDate As New List(Of Date)
        Public Sub sona_SetData(field As String, value As Date)
            parameters.Add(Convert.ToString((Convert.ToString("@") & field) + ChrW(127)) & value)
        End Sub

        Public Sub sona_SetData(fields As String())
            If fields IsNot Nothing Then
                For i As Integer = 0 To fields.Length - 1
                    sona_SetData(fields(i), fields(i + 1))
                    i += 1
                Next
            End If
        End Sub


        Public Sub sona_SetMulData(fields As String())
            If fields IsNot Nothing Then
                For i As Integer = 0 To fields.Length - 1
                    sona_SetData(i.ToString(), fields(i))
                Next
            End If
        End Sub

        Private Function execDatatable() As DataTable
            Dim dt As New DataTable()
            Try
                rder = command.ExecuteReader()
                dt.Load(rder)
            Catch my As SqlException
                Dim exception As String = Convert.ToString("Exception : " + my.Message.ToString() + vbLf & vbCr & " SQL Query : " & vbLf & vbCr) & squery

                Console.WriteLine(exception, "Uncaught SQL Exception")

                Debug(exception)
            End Try

            Return dt
        End Function

        Public Function execNonquery() As Integer

            Try
                affected = command.ExecuteNonQuery()
            Catch my As SqlException
                Dim exception As String = Convert.ToString("Exception : " + my.Message.ToString() + vbLf & vbCr & " SQL Query : " & vbLf & vbCr) & squery

                Console.WriteLine(exception, "Uncaught SQL Server Exception")

                Debug(exception)
            End Try

            Return affected
        End Function

        Public Function table(tb As String, Optional sonaData As String() = Nothing) As DataTable
            Init(Convert.ToString("SELECT * FROM ") & tb, sonaData)
            Return Me.tb
        End Function
#Region "Sovathana Function "

#End Region

        Public Function Exec_reader(store As String, stores As List(Of Object)) As SqlDataReader

            If bConnected = False Then
                connection()
            End If

            Using command As New SqlCommand(store, connect)



                Try
                    command.CommandType = CommandType.StoredProcedure
                    Dim param As SqlParameter
                    If stores Is Nothing Then
                    Else
                        With command
                            ' .Parameters.Add("@ID", SqlDbType.SmallInt).Direction = ParameterDirection.ReturnValue
                            For i As Integer = 0 To stores.Count - 1
                                .Parameters.AddWithValue(stores(i), stores(i + 1))
                                i = i + 1
                            Next
                            ' .Parameters.Add("@photo", SqlDbType.VarBinary, -1).Value = ""
                        End With
                    End If
                    Try
                        rder = command.ExecuteReader()
                    Catch ex As Exception

                    End Try
                    Me.rder = rder
                Catch ex As Exception

                End Try
            End Using
            Return Me.rder
        End Function
        Public Sub Exec(store As String, stores As List(Of Object), Optional type As String = Nothing)
            If bConnected = False Then
                connection()
            End If

            Using command As New SqlCommand(store, connect)
                Dim dt As New DataTable()
                Try
                    command.CommandType = CommandType.StoredProcedure
                    Dim param As SqlParameter
                    Dim stypes As String = type.ToLower()

                    If stypes.Equals("select") Then
                        If stores Is Nothing Then
                        Else
                            With command
                                ' .Parameters.Add("@ID", SqlDbType.SmallInt).Direction = ParameterDirection.ReturnValue
                                For i As Integer = 0 To stores.Count - 1
                                    .Parameters.AddWithValue(stores(i), stores(i + 1))
                                    i = i + 1
                                Next
                                ' .Parameters.Add("@photo", SqlDbType.VarBinary, -1).Value = ""
                            End With
                        End If
                        Try
                            rder = command.ExecuteReader()
                            dt.Load(rder)
                        Catch ex As Exception

                        End Try
                        Me.tb = dt
                    End If
                    If stypes.Equals("insert") OrElse stypes.Equals("update") OrElse stypes.Equals("delete") Then
                        With command
                            .Parameters.Add("@ID", SqlDbType.SmallInt).Direction = ParameterDirection.ReturnValue
                            For i As Integer = 0 To stores.Count - 1
                                .Parameters.AddWithValue(stores(i), stores(i + 1))
                                i = i + 1
                            Next
                            ' .Parameters.Add("@photo", SqlDbType.VarBinary, -1).Value = ""
                        End With
                        Try
                            affected = command.ExecuteNonQuery()
                        Catch ex As Exception

                        End Try
                        affected_rows = affected
                    End If
                Catch ex As Exception

                End Try

            End Using

        End Sub
        Public Function Exec_Perform(store As String, stores As List(Of Object), Optional type As String = Nothing) As Integer
            Exec(store, stores, "insert")
            Return affected_rows
        End Function
        Public Function Execute(Store As String, stores As List(Of Object), Optional type As String = Nothing) As DataTable
            Exec(Store, stores, type)
            Return Me.tb
        End Function
        Public Function Execute_getColumns(Store As String, stores As List(Of Object), Optional type As String = Nothing) As List(Of String)
            Exec(Store, stores, type)
            Dim column As New List(Of String)()

            Dim i As Integer = 0
            While System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1) < tb.Rows.Count


                column.Add(tb.Rows(i)(0).ToString())
            End While

            Return column
        End Function
        Public Function Field(table As String, field__1 As String, Optional sonaData As String() = Nothing) As DataTable
            Init(Convert.ToString("SELECT * FROM") & table, sonaData)
            Return Me.tb
        End Function

        Public Function table(tb As String, t As Type) As List(Of Object)
            Return New List(Of Object)()
        End Function

        Public Function query(queries As String, Optional sonaData As String() = Nothing) As DataTable
            Init(queries, sonaData)
            Return Me.tb
        End Function
        Public Sub combo(query As String, combo As String)
            connection()

            Dim myread As SqlDataReader
            Dim cmd As New SqlCommand(query, connect)
            myread = cmd.ExecuteReader()
            While myread.Read()
                'combo.Items.Add(name);
                Dim name As String = myread.GetString("email")
            End While

        End Sub

        Public Function nQuery(query As String, Optional sonaData As String() = Nothing, Optional isBinary As Boolean = False, Optional bin As String = Nothing, Optional filebyte As Byte() = Nothing) As Integer
            Init(query, sonaData, isBinary, bin, filebyte)
            Return Me.affected_rows
        End Function

        Public Function [single](query As String, Optional sonaData As String() = Nothing) As String
            Init(query, sonaData)

            If tb.Rows.Count > 0 Then
                Return tb.Rows(0)(0).ToString()
            End If

            Return String.Empty
        End Function

        Public Function Sona_GetRow(query As String, Optional sonaData As String() = Nothing) As String()
            Init(query, sonaData)

            Dim row As String() = New String(tb.Columns.Count - 1) {}

            If tb.Rows.Count > 0 Then
                Dim i As Integer = 0
                While System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1) < tb.Columns.Count


                    row(i - 1) = tb.Rows(0)(i - 1).ToString()
                End While
            End If

            Return row
        End Function

        Public Function Sona_GetColumn(query As String, Optional sonaData As String() = Nothing) As List(Of String)
            Init(query, sonaData)

            Dim column As New List(Of String)()

            Dim i As Integer = 0
            While System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1) < tb.Rows.Count


                column.Add(tb.Rows(i)(0).ToString())
            End While

            Return column
        End Function
        Public Sub RetrievToTextbox(stp As String, lst As List(Of Object), ByVal ParamArray txtbox As List(Of Object)())
            Exec(stp, lst, "select")
            If rder.Read() Then
                For i As Integer = 0 To txtbox.GetUpperBound(0)
                    txtbox(i) = rder.Item(i - 2)
                Next
            End If
            rder.Close()
            command.Dispose()

        End Sub

        Public Sub Debug([error] As String)
            Console.WriteLine([error] & Convert.ToString("/n/r"))
        End Sub
        Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Namespace