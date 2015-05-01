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
Namespace sqlCms
    Public Class Systemdb

        Public connect As SqlConnection
        Public command As New SqlCommand
        Public rder As SqlDataReader
        Public affected As Integer = 0
        Public bConnected As Boolean = False
        Public tb As DataTable
        Public affected_rows As Integer
        Public squery As String
        Public parameters As List(Of String)

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

        Private Sub Init(Query As String, Optional sonaData As String() = Nothing)
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

                    Me.affected_rows = affected
                End If
                If squery.Contains("Exc") Then
                    Try
                        command.CommandType = CommandType.StoredProcedure
                    Catch ex As Exception
                        Dim exception As String = Convert.ToString("Exception : " + squery)
                        Console.WriteLine(exception, "Uncaught Sql Exception")
                    End Try

                End If

                Me.parameters.Clear()
            End Using
        End Sub

        Public Sub sona_SetData(field As String, value As String)
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
        Public Function Exc(store As String, Optional stores As String() = Nothing) As DataTable
            Init(store, stores)
            Return Me.tb

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

        Public Function nQuery(query As String, Optional sonaData As String() = Nothing) As Integer
            Init(query, sonaData)
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


                column.Add(tb.Rows(i - 1)(0).ToString())
            End While

            Return column
        End Function


        Public Sub Debug([error] As String)
            Console.WriteLine([error] & Convert.ToString("/n/r"))
        End Sub
        Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Namespace