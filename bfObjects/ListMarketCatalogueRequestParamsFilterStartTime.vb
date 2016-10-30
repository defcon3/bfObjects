Public Class ListMarketCatalogueRequestParamsFilterStartTime
    Public Sub New(Optional ByVal from As String = vbNullString, Optional ByVal [to] As String = vbNullString)
        If Not from = vbNullString Then
            _from = from
        End If
        If Not [to] = vbNullString Then
            _to = [to]
        End If
    End Sub

    Public ReadOnly Property _from As String
    Public ReadOnly Property _to As String

End Class
