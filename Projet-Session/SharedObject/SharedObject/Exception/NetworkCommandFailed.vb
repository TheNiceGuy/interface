Public Class NetworkCommandFailed : Inherits Exception
    Dim MErr As ErrorType

    Public Sub New(ErrType As ErrorType)
        MErr = ErrType
    End Sub

    Public ReadOnly Property Err As ErrorType
        Get
            Return MErr
        End Get
    End Property
End Class


