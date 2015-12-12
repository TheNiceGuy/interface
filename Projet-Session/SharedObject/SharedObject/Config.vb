Public Class Config
    Shared ReadOnly Property Addresse As String
        Get
            Return "127.0.0.1"
        End Get
    End Property

    Shared ReadOnly Property Port As Integer
        Get
            Return 1420
        End Get
    End Property

    Shared ReadOnly Property TimeOut As Integer
        Get
            Return 10000
        End Get
    End Property

    Shared ReadOnly Property BufferLength As Integer
        Get
            Return 16394
        End Get
    End Property

    Shared ReadOnly Property MaxLength As Integer
        Get
            Return 255
        End Get
    End Property
End Class