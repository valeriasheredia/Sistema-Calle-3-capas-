Public Class vAtleta_x_Competencia

    Dim id_atleta_x_competencia, id_atleta, id_competencia, id_juez, id_resultado As Integer
    Dim dorsal, representacion, hora, distancia1, distancia2, distancia3 As String
    Dim fecha As Date
    'metodo get sirve para guardar datos en el objeto
    'metodo set sirve para extraer datos del objeto
    Public Property gid_atleta_x_competencia
        Get
            Return id_atleta_x_competencia
        End Get
        Set(value)
            id_atleta_x_competencia = value
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

    Public Property gid_resultado
        Get
            Return id_resultado
        End Get
        Set(value)
            id_resultado = value
        End Set
    End Property

    Public Property gid_competencia
        Get
            Return id_competencia
        End Get
        Set(value)
            id_competencia = value
        End Set
    End Property

    Public Property gid_juez
        Get
            Return id_juez
        End Get
        Set(value)
            id_juez = value
        End Set
    End Property

    Public Property gdorsal
        Get
            Return dorsal
        End Get
        Set(value)
            dorsal = value
        End Set
    End Property

    Public Property grepresentacion
        Get
            Return representacion
        End Get
        Set(value)
            representacion = value
        End Set
    End Property

    Public Property ghora
        Get
            Return hora
        End Get
        Set(value)
            hora = value
        End Set
    End Property

    Public Property gdistancia1
        Get
            Return distancia1
        End Get
        Set(value)
            distancia1 = value
        End Set
    End Property

    Public Property gdistancia2
        Get
            Return distancia2
        End Get
        Set(value)
            distancia2 = value
        End Set
    End Property


    Public Property gdistancia3
        Get
            Return distancia3
        End Get
        Set(value)
            distancia3 = value
        End Set
    End Property

    Public Property gfecha
        Get
            Return fecha
        End Get
        Set(value)
            fecha = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal id_atleta_x_competencia As Integer,
                   ByVal id_atleta As Integer,
                   ByVal id_juez As Integer,
                   ByVal dorsal As String,
                   ByVal representacion As String,
                   ByVal fecha As Date,
                   ByVal hora As String,
                   ByVal distancia1 As String,
                   ByVal distancia2 As String,
                   ByVal distancia3 As String,
                   ByVal id_resultado As Integer)
        gid_atleta_x_competencia = id_atleta_x_competencia
        gid_atleta = id_atleta
        gid_juez = id_juez
        gid_resultado = id_resultado
        gdorsal = dorsal
        grepresentacion = representacion
        gfecha = fecha
        ghora = hora
        gdistancia1 = distancia1
        gdistancia2 = distancia2
        gdistancia3 = distancia3
    End Sub

    Dim objrxc As New fAtleta_x_Competencia

    Public Function Codigo_Nuevo_Atleta_x_Competencia() As String
        Return objrxc.Codigo_Nuevo_Atleta_x_Competencia
    End Function

    Public Sub insertar(ByVal objatlxcomp As vAtleta_x_Competencia)
        objrxc.insertar(objatlxcomp)
    End Sub
End Class
