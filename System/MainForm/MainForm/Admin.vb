Public Class Admin : Inherits sqlCms.sqlCms.SampleClass
    Private ID As Integer
    Private username As String
    Private pass_word As String
    Private email As String
    Private phone As String
    Private reg_date As Date
    Private photo() As Byte

    Public Property _ID As Integer
        Get
            Return Me.ID
        End Get
        Set(value As Integer)
            ID = value
        End Set
    End Property
    Public Property _username As String
        Get
            Return Me.username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property
    Public Property _pass_word As String
        Get
            Return Me.pass_word
        End Get
        Set(value As String)
            pass_word = value
        End Set
    End Property
    Public Property _email As String
        Get
            Return Me.email
        End Get
        Set(value As String)
            email = value

        End Set
    End Property
    Public Property _phone As String
        Get
            Return phone
        End Get
        Set(value As String)
            phone = value
        End Set
    End Property
    Public Property _reg_date As Date
        Get
            Return reg_date
        End Get
        Set(value As Date)
            reg_date = value
        End Set
    End Property
    Public Property _photo As Byte()
        Get
            Return Me.photo
        End Get
        Set(value As Byte())
            photo = value
        End Set
    End Property

    Public Sub New()
        table_ = "tbAdminSchema"
        pk_ = "ID"
        'pk_ = 0
    End Sub
End Class
