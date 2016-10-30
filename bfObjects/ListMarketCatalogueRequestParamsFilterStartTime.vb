Public Class ListMarketCatalogueRequestParamsFilterStartTime
    Public Sub New(Optional ByVal _from As String = vbNullString, Optional ByVal _to As String = vbNullString)
        If Not _from = vbNullString Then
            [from] = _from
        End If
        If Not _to = vbNullString Then
            [to] = _to
        End If
    End Sub

    Public ReadOnly Property [from] As String
    Public ReadOnly Property [to] As String

End Class
