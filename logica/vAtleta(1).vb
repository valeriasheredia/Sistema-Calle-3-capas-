Public Class vAtleta
    Dim id_atleta As Integer
    Dim nombre_apellido, dni, sexo, provincia, telefono, mail, direccion As String
    Dim fecha_nacimiento As Date
    'metodo get sirve para guardar datos en el objeto
    'metodo set sirve para extraer datos del objeto
    Public Property gid_atleta
        Get
            Return id_atleta
        End Get
        Set(value)
            id_atleta = value
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

    Public Property gfecha_nacimiento
        Get
            Return fecha_nacimiento
        End Get
        Set(value)
            fecha_nacimiento = value
        End Set
    End Property

    Public Property gsexo
        Get
            Return sexo
        End Get
        Set(value)
            sexo = value
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

    Public Property gprovincia
        Get
            Return provincia
        End Get
        Set(value)
            provincia = value
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

    Public Sub New(ByVal id_atleta As Integer,
                   ByVal nombre_apellido As String,
                   ByVal dni As String,
                   ByVal fecha_nacimiento As Date,
                   ByVal sexo As String,
                   ByVal provincia As String,
                   ByVal telefono As String,
                   ByVal mail As String,
                   ByVal direccion As String)

        gid_atleta = id_atleta
        gnombre_apellido = nombre_apellido
        gdni = dni
        gfecha_nacimiento = fecha_nacimiento
        gsexo = sexo
        gprovincia = provincia
        gtelefono = telefono
        gmail = mail
        gdireccion = direccion

    End Sub
End Class
