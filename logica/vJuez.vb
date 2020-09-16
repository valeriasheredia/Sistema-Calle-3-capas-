Public Class vJuez

    Dim id_juez As Integer
    Dim nombre_apellido, dni, telefono, mail, direccion As String
    'metodo get sirve para guardar datos en el objeto
    'metodo set sirve para extraer datos del objeto
    Public Property gid_juez
        Get
            Return id_juez
        End Get
        Set(value)
            id_juez = value
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

    Public Property gmail
        Get
            Return mail
        End Get
        Set(value)
            mail = value
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

    Public Sub New()

    End Sub

    Public Sub New(ByVal id_juez As Integer,
                    ByVal nombre_apellido As String,
                    ByVal dni As String,
                    ByVal telefono As String,
                    ByVal mail As String,
                    ByVal direccion As String)
        gid_juez = id_juez
        gnombre_apellido = nombre_apellido
        gdni = dni
        gtelefono = telefono
        gmail = mail
        gdireccion = direccion
    End Sub
End Class
