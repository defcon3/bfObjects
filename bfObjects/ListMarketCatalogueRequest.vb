Public Class ListMarketCatalogueRequest

    ''' <summary>
    ''' Parameter der Schnittstelle: in der Regel 2.0
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property jsonrpc As String = "2.0"
    ''' <summary>
    ''' Adresse der Anforderung
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property method As String = "SportsAPING/v1.0/listMarketCatalogue"
    ''' <summary>
    ''' Parameter der Schnittstelle: sollte immer 1 sein
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property id As Integer = 1
    Public ReadOnly Property listmarketcataloguerequestparams As New ListMarketCatalogueRequestParams

    Public Sub New(Optional ByVal _listmarketcataloguerequestparams As ListMarketCatalogueRequestParams = Nothing)

        listmarketcataloguerequestparams = _listmarketcataloguerequestparams

    End Sub
End Class
