Public Class ListMarketCatalogueRequestParams
    Public Sub New(Optional ByVal _maxResults As String = "200", Optional ByVal _sort As MarketSort = MarketSort.FIRST_TO_START, Optional ByVal _marketProjection As List(Of String) = Nothing, Optional ByVal _filter As ListMarketCatalogueRequestParamsFilter = Nothing)

        maxResults = _maxResults
        sort = _sort
        If Not IsNothing(_marketProjection) Then
            marketProjection = _marketProjection
        End If
        If Not IsNothing(_filter) Then
            filter = _filter
        End If

    End Sub

    Public ReadOnly Property sort As MarketSort = MarketSort.FIRST_TO_START
    Public ReadOnly Property maxResults As String = "200"
    Public ReadOnly Property marketProjection As New List(Of String)
    Public ReadOnly Property filter As New ListMarketCatalogueRequestParamsFilter
End Class
