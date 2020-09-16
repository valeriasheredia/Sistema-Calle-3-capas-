Public Class vResultado
    Dim id_resultado, id_atleta, posicion As Integer
    Dim tiempo As String
    'metodo get sirve para guardar datos en el objeto
    'metodo set sirve para extraer datos del objeto
    Public Property gid_resultado
        Get
            Return id_resultado
        End Get
        Set(value)
            id_resultado = value
        End Set
    End Property

    Public Property gid_atleta
        Get
            Return id_atleta
        End Get
        Set(value)
            id_atleta = value
        End Set
    End Property

    Public Property gtiempo
        Get
            Return tiempo
        End Get
        Set(value)
            tiempo = value
        End Set
    End Property

    Public Property gposicion
        Get
            Return posicion
        End Get
        Set(value)
            posicion = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal id_resultado As Integer,
                    ByVal tiempo As String,
                    ByVal posicion As Integer)
        gid_resultado = id_resultado

        gtiempo = tiempo
        gposicion = posicion
    End Sub

    Dim objrxc As New fResultado

    Public Function Nuevo_Codigo_Resultado() As String
        Return objrxc.Nuevo_Codigo_Resultado
    End Function

    Public Sub insertar(ByVal objresxcomp As vResultado)
        objrxc.insertar(objresxcomp)
    End Sub
End Class
