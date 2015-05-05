Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Reflection

Namespace sqlCms
    Public Class SampleClass
        Private db As Systemdb

        ' The table
        Private table As String

        ' The primary key of the table
        Private pk As String

        ' The prefix used to distinguish certain properties as columns
        Protected c_prefix As Char = "_"c

        Public WriteOnly Property table_() As String
            Set(value As String)
                Me.table = value
            End Set
        End Property

        Public WriteOnly Property pk_() As String
            Set(value As String)
                Me.pk = value
            End Set
        End Property

        Private internProperties As List(Of String)

        Public Properties As Dictionary(Of String, String)

        Public Sub New()
            db = New Systemdb()
            Properties = New Dictionary(Of String, String)()
            internProperties = New List(Of String)()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns></returns>
        Public Function find(Optional id As Integer = 0) As SampleClass
            If id <> 0 Then
                Dim sql As String = (Convert.ToString((Convert.ToString("SELECT * FROM ") & Me.table) + " WHERE ") & Me.pk) + "= @pk LIMIT 1"

                Dim d As DataTable = Me.db.query(sql, New String() {"pk", id.ToString()})

                Dim row As New Dictionary(Of String, String)()

                If d.Rows.Count > 0 Then
                    For i As Integer = 0 To d.Columns.Count - 1
                        row.Add(Me.c_prefix + d.Columns(i).ColumnName.ToLower(), d.Rows(0)(i).ToString())
                    Next
                End If

                For Each pi As PropertyInfo In Me.[GetType]().GetProperties()
                    Dim propertyName As String = pi.Name

                    If pi IsNot Nothing AndAlso pi.CanWrite Then
                        If row.ContainsKey(propertyName) Then
                            If pi.PropertyType = GetType(String) Then
                                pi.SetValue(Me, row(propertyName))
                            End If
                            If pi.PropertyType = GetType(Integer) Then
                                pi.SetValue(Me, Integer.Parse(row(propertyName)))
                            End If
                        End If
                    End If
                Next

                Me.internProperties.Clear()
                Me.Properties.Clear()
            End If

            Return Me
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns>Number of affacted rows</returns>
        Public Function save(Optional id As Integer = 0) As Integer
            bindProperties(Me)

            If Me.Properties.Count > 0 Then
                If id <> 0 Then
                    Me.Properties(Me.pk) = id.ToString()
                End If

                Dim update As String = String.Empty

                For Each column As String In Me.Properties.Keys
                    If column <> Me.pk Then
                        update += (Convert.ToString(column & Convert.ToString(" =@")) & column) + " , "
                    End If
                Next

                update = update.Trim()
                update = update.Substring(0, update.Length - 1)

                Dim sql As String = (Convert.ToString((Convert.ToString((Convert.ToString("UPDATE ") & Me.table) + " SET ") & update) + " WHERE ") & Me.pk) + "= @pk LIMIT 1"

                Dim pk_index_intern As Integer = Me.internProperties.IndexOf(Me.pk)

                Me.internProperties.RemoveAt(pk_index_intern)
                Me.internProperties.RemoveAt(pk_index_intern)

                Me.internProperties.Add("@pk")
                Me.internProperties.Add(Me.Properties(Me.pk))

                Return Me.db.nQuery(sql, Me.internProperties.ToArray())
            End If

            Return 0
        End Function

        ''' <summary>
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns>Number of affacted rows</returns>
        Public Function delete(Optional id As Integer = 0) As Integer
            If id > 0 Then

                Dim sql As String = (Convert.ToString((Convert.ToString("DELETE FROM ") & Me.table) + " WHERE ") & Me.pk) + "= @pk LIMIT 1"
                Return Me.db.nQuery(sql, New String() {"pk", id.ToString()})
            End If

            Return 0
        End Function

        ''' <summary>
        ''' To-do : test
        ''' </summary>
        ''' <returns>Number of affacted rows</returns>
        Public Function create() As Integer
            If Me.Properties.Count = 0 Then
                bindProperties(Me)
            End If

            If Me.Properties.Count > 0 Then
                ' The column names
                Dim fields As List(Of String) = Me.Properties.Keys.ToList()

                ' The value of the columns
                Dim fieldsvals As List(Of String) = Me.Properties.Values.ToList()

                Dim pk_index As Integer = fields.IndexOf(Me.pk)
                Dim pk_index_intern As Integer = Me.internProperties.IndexOf(Me.pk)

                ' Remove the primary key, we don't need that in an insert query
                fields.RemoveAt(pk_index)
                fieldsvals.RemoveAt(pk_index)

                Me.internProperties.RemoveAt(pk_index_intern)
                Me.internProperties.RemoveAt(pk_index_intern)

                Dim sFields As String = [String].Join(",", fields)

                For i As Integer = 0 To fieldsvals.Count - 1
                    fields(i) = "@" + fields(i)
                Next

                Dim sql As String = (Convert.ToString((Convert.ToString("INSERT INTO ") & Me.table) + "(") & sFields) + ")" + " VALUES(" + [String].Join(",", fields) + ")"

                Dim result As Integer = Me.db.nQuery(sql, Me.internProperties.ToArray())

                Me.Properties.Clear()
                Me.internProperties.Clear()

                Return result
            Else
                Dim sql As String = (Convert.ToString("INSERT INTO ") & Me.table) + "()" + " VALUES()"
                Return Me.db.nQuery(sql)
            End If
        End Function

        ''' <summary>
        ''' To-do: test
        ''' </summary>
        ''' <param name="o"></param>
        ''' <returns>Number of affacted rows</returns>
        Public Function create(obj As Object()) As Integer

            Dim rows_affected As Integer = 0

            For Each o As Object In obj
                bindProperties(o)
                rows_affected += Me.create()
            Next

            Return rows_affected
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        Public Function create(obj As List(Of Object)) As Integer
            Dim rows_affected As Integer = 0

            For Each o As Object In obj
                bindProperties(o)
                rows_affected += Me.create()
            Next

            Return rows_affected
        End Function

        ''' <summary>
        ''' </summary>
        ''' <returns>Datatable</returns>
        Public Function all() As DataTable
            Return Me.db.table(Me.table)
        End Function


        ' Aggregates methods

        Private Function aggregateInit(sql As String) As Double
            Dim value As String = db.[single](sql)

            Dim result As Double

            If value IsNot Nothing AndAlso Double.TryParse(value, result) Then
                Return Double.Parse(value)
            End If

            Return 0
        End Function

        Public Function min(field As String) As Double
            Return aggregateInit(Convert.ToString((Convert.ToString("SELECT min(") & field) + ")" + " FROM ") & Me.table)
        End Function

        Public Function max(field As String) As Double
            Return aggregateInit(Convert.ToString((Convert.ToString("SELECT max(") & field) + ")" + " FROM ") & Me.table)
        End Function

        Public Function avg(field As String) As Double
            Return [Double].Parse(aggregateInit(Convert.ToString((Convert.ToString("SELECT avg(") & field) + ")" + " FROM ") & Me.table).ToString())
        End Function

        Public Function sum(field As String) As Double
            Return aggregateInit(Convert.ToString((Convert.ToString("SELECT sum(") & field) + ")" + " FROM ") & Me.table)
        End Function

        Public Function count(field As String, Optional limit As Integer = 0) As Double
            If limit > 0 Then
                Return aggregateInit((Convert.ToString((Convert.ToString("SELECT count(") & field) + ")" + " FROM ") & Me.table) + " LIMIT " + limit.ToString())
            End If

            Return aggregateInit(Convert.ToString((Convert.ToString("SELECT count(") & field) + ")" + " FROM ") & Me.table)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="o"></param>
        Private Sub bindProperties(o As Object)
            For Each pi As PropertyInfo In o.[GetType]().GetProperties()
                ' Table column prefix
                If pi.Name(0) = Me.c_prefix Then
                    Dim [property] As Object = pi.GetValue(o, Nothing)
                    If [property] IsNot Nothing Then
                        Me.Properties(pi.Name.Substring(1)) = [property].ToString()

                        Me.internProperties.Add(pi.Name.Substring(1))
                        Me.internProperties.Add([property].ToString())
                    End If
                End If
            Next
        End Sub
    End Class
End Namespace
