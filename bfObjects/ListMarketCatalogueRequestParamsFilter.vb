Public Class ListMarketCatalogueRequestParamsFilter
    Public Sub New(Optional ByVal _eventTypeIds As List(Of String) = Nothing, Optional ByVal _marketCoutries As List(Of String) = Nothing, Optional ByVal _marketTypeCodes As List(Of String) = Nothing, Optional ByVal _marketStartTime As ListMarketCatalogueRequestParamsFilterStartTime = Nothing)
        If Not IsNothing(_eventTypeIds) Then
            eventTypeIds = _eventTypeIds
        End If
        If Not IsNothing(_marketCoutries) Then
            marketCountries = _marketCoutries
        End If
        If Not IsNothing(_marketTypeCodes) Then
            marketTypeCodes = _marketTypeCodes
        End If
        If Not IsNothing(_marketStartTime) Then
            marketStartTime = _marketStartTime
        End If
    End Sub

    Public ReadOnly Property eventTypeIds As New List(Of String)
    Public ReadOnly Property marketCountries As New List(Of String)
    Public ReadOnly Property marketTypeCodes As New List(Of String)
    Public ReadOnly Property marketStartTime As New ListMarketCatalogueRequestParamsFilterStartTime

End Class
