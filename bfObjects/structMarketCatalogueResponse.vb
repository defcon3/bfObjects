Public Structure structMarketCatalogueResponse
    Public Property jsorpc As String
    Public result As List(Of structMarketCatalogue)
    Public id As Integer
    Public Structure structMarketCatalogue
        Public marketID As String
        Public marketName As String
        Public marketStartTime As Date
        Public description As structMarketDescription

        Public Structure structMarketDescription
            Public persistenceEnabled As Boolean
            Public bspMarket As Boolean
            Public marketTime As Date
            Public suspendTime As Date
            Public settleTime As Date
            Public bettingType As MarketBettingType
            Public turnInPlayEnabled As Boolean
            Public marketType As String
            Public regulator As String
            Public marketBaseRate As Double
            Public discountAllowed As Boolean
            Public wallet As String
            Public rules As String
            Public rulesHasDate As Boolean
            Public eachWayDivisor As Double
            Public clarifications As String
        End Structure

        Public totalMatched As Double
        Public runners As List(Of structRunnerCatalog)
        Public eventType As structEventType
        Public competition As structCompetition
        Public [event] As structEvent


        Public Structure structRunnerCatalog
            Public selectionId As Long
            Public runnerName As String
            Public handicap As Double
            Public sortPriority As Integer
            Public metadata As Object 'hier kann für Pferderennen noch mal nachegeschärft werden
        End Structure

        Public Structure structEventType
            Public id As String
            Public [name] As String
        End Structure

        Public Structure structCompetition
            Public id As String
            Public [name] As String
        End Structure

        Public Structure structEvent
            Public id As String
            Public [name] As String
            Public countryCode As String
            Public timezone As String
            Public venue As String
            Public openDate As Date
        End Structure
    End Structure
End Structure

