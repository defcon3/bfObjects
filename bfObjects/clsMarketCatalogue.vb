Public Class clsMarketCatalogue
    ''' <summary>
    ''' The unique identifier for the market. MarketId's are prefixed with '1.'
    ''' </summary>
    ''' <returns></returns>
    Public Property marketId As System.String

    ''' <summary>
    ''' The name of the market
    ''' </summary>
    ''' <returns></returns>
    Public Property marketName As System.String

    ''' <summary>
    ''' The time this market starts at, only returned when the MARKET_START_TIME enum is passed in the marketProjections
    ''' </summary>
    ''' <returns></returns>
    Public Property marketStartTime As System.String

    ''' <summary>
    ''' Details about the market
    ''' </summary>
    ''' <returns></returns>
    Public Property description As bfObjects.clsMarketDescription

    ''' <summary>
    ''' The total amount of money matched on the market
    ''' </summary>
    ''' <returns></returns>
    Public Property totalMatched As System.Double

    ''' <summary>
    ''' The runners (selections) contained in the market
    ''' </summary>
    ''' <returns></returns>
    Public Property runners As List(Of Object)

    ''' <summary>
    ''' The Event Type the market is contained within
    ''' </summary>
    ''' <returns></returns>
    Public Property eventType As Object

    ''' <summary>
    ''' The competition the market is contained within. Usually only applies to Football competitions
    ''' </summary>
    ''' <returns></returns>
    Public Property competition As Object

    ''' <summary>
    ''' The event the market is contained within
    ''' </summary>
    ''' <returns></returns>
    Public Property [event] As Integer
End Class
