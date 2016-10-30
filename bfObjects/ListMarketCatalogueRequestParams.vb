Public Class ListMarketCatalogueRequestParams
    Public Sub New(Optional maxResults As String = "200", Optional sort As MarketSort = MarketSort.FIRST_TO_START, Optional marketProjection As List(Of String) = Nothing, Optional filter As ListMarketCatalogueRequestParamsFilter = Nothing)

        _maxResults = maxResults
        _sort = sort
        If Not IsNothing(marketProjection) Then
            _marketProjection = marketProjection
        End If
        If Not IsNothing(filter) Then
            _filter = filter
        End If

    End Sub

    Public ReadOnly Property _sort As MarketSort = MarketSort.FIRST_TO_START
    Public ReadOnly Property _maxResults As String = "200"
    Public ReadOnly Property _marketProjection As New List(Of String)
    Public ReadOnly Property _filter As New ListMarketCatalogueRequestParamsFilter
End Class
