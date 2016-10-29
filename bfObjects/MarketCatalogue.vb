Public Class MarketCatalogue
    Public marketID As String
    Public marketName As String
    Public marketStartTime As Date
    Public description As MarketDescription
    Public totalMatched As Double
    Public runners As List(Of RunnerCatalog)
    Public eventType As EventType
    Public competition As Competition
    Public [event] As [Event]
End Class