''' <summary>
''' Antwortklasse von MarketCatalogue
''' </summary>
Public Class clsMarketCatalogueResponse
    Inherits clsResponseRoot
    ''' <summary>
    ''' Auflistung der Results vom Objekt MarketCatalogue
    ''' </summary>
    ''' <returns>List von ABEresponses.MarketCatalogue</returns>
    Public Property result As List(Of ABEresponses.MarketCatalogue) = New List(Of ABEresponses.MarketCatalogue)
End Class
