Public Class vUsuario
    Dim id_usuario As Integer
    Dim nombre_apellido, dni, telefono, direccion, login, password, acceso As String
    'metodo get sirve para guardar datos en el objeto
    'metodo set sirve para extraer datos del objeto
    Public Property gid_usuario
        Get
            Return id_usuario
        End Get
        Set(value)
            id_usuario = value
        End Set
    End Property

    Public Property gnombre_apellido
        Get
            Return nombre_apellido
        End Get
        Set(value)
            nombre_apellido = value
        End Set
    End Property

    Public Property gdni
        Get
            Return dni
        End Get
        Set(value)
            dni = value
        End Set
    End Property

    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(value)
            telefono = value
        End Set
    End Property

    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(value)
            direccion = value
        End Set
    End Property

    Public Property glogin
        Get
            Return login
        End Get
        Set(value)
            login = value
        End Set
    End Property

    Public Property gpassword
        Get
            Return password
        End Get
        Set(value)
            password = value
        End Set
    End Property

    Public Property gacceso
        Get
            Return acceso
        End Get
        Set(value)
            acceso = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal id_usuario As Integer,
                   ByVal nombre_apellido As String,
                   ByVal dni As String,
                   ByVal telefono As String,
                   ByVal direccion As String,
                   ByVal login As String,
                   ByVal password As String,
                   ByVal acceso As String)

        gid_usuario = id_usuario
        gnombre_apellido = nombre_apellido
        gdni = dni
        gtelefono = telefono
        gdireccion = direccion
        glogin = login
        gpassword = password
        gacceso = acceso
    End Sub
End Class
