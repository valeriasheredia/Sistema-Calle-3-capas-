
Public Class vCompetencia
    Dim id_competencia As Integer
    Dim nombre_competencia, lugar_competencia As String
    'metodo get sirve para guardar datos en el objeto
    'metodo set sirve para extraer datos del objeto
    Public Property gid_competencia
        Get
            Return id_competencia
        End Get
        Set(value)
            id_competencia = value
        End Set
    End Property

    Public Property gnombre_competencia
        Get
            Return nombre_competencia
        End Get
        Set(value)
            nombre_competencia = value
        End Set
    End Property

    Public Property glugar_competencia
        Get
            Return lugar_competencia
        End Get
        Set(value)
            lugar_competencia = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal id_competencia As Integer,
                   ByVal nombre_competencia As String,
                   ByVal lugar_competencia As String)

        gid_competencia = id_competencia
        gnombre_competencia = nombre_competencia
        glugar_competencia = lugar_competencia

    End Sub

End Class
