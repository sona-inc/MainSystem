Imports System
Imports System.Configuration
Imports System.Data
Imports System.Collections.Generic
Namespace sqlCms
    Partial Public Class Cons


        Private Shared sqlConn As String = ConfigurationSettings.AppSettings("SQLConnectionString")
        Public Shared ReadOnly Property sqlConnect As String
            Get
                Return sqlConn
            End Get

        End Property


    End Class

End Namespace

