Public Class ListMarketCatalogueRequestParamsFilter
    Public Sub New(Optional eventTypeIds As List(Of String) = Nothing, Optional ByVal marketCoutries As List(Of String) = Nothing, Optional ByVal marketTypeCodes As List(Of String) = Nothing, Optional ByVal marketStartTime As ListMarketCatalogueRequestParamsFilterStartTime = Nothing)
        If Not IsNothing(eventTypeIds) Then
            _eventTypeIds = eventTypeIds
        End If
        If Not IsNothing(marketCoutries) Then
            _marketCountries = marketCoutries
        End If
        If Not IsNothing(marketTypeCodes) Then
            _marketTypeCodes = marketTypeCodes
        End If
        If Not IsNothing(marketStartTime) Then
            _marketStartTime = marketStartTime
        End If
    End Sub

    Public ReadOnly Property _eventTypeIds As New List(Of String)
    Public ReadOnly Property _marketCountries As New List(Of String)
    Public ReadOnly Property _marketTypeCodes As New List(Of String)
    Public ReadOnly Property _marketStartTime As New ListMarketCatalogueRequestParamsFilterStartTime

End Class
