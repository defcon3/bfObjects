Public Class ListMarketCatalogueRequest

    ''' <summary>
    ''' Parameter der Schnittstelle: in der Regel 2.0
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property _jsonrpc As String = "2.0"
    ''' <summary>
    ''' Adresse der Anforderung
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property _nomore As String = "SportsAPING/v1.0/listMarketCatalogue"
    ''' <summary>
    ''' Parameter der Schnittstelle: sollte immer 1 sein
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property _id As Integer = 1
    Public ReadOnly Property _listmarketcataloguerequestparams As New ListMarketCatalogueRequestParams

    Public Sub New(Optional ByVal listmarketcataloguerequestparams As ListMarketCatalogueRequestParams = Nothing)

        _listmarketcataloguerequestparams = listmarketcataloguerequestparams

    End Sub
End Class
