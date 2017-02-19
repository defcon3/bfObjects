Public Class clsEventTypeResult
    Public Property eventType As List(Of clsEventType)
    Public Property marketCount As Long

    Sub New()
        eventType = New List(Of clsEventType)
    End Sub

End Class
