Public Class clsMarketBook
    Public marketId As String
    Public isMarketDataDelayed As Boolean
    Public status As String
    Public betDelay As Integer
    Public bspReconciled As Boolean
    Public complete As Boolean
    Public inplay As Boolean
    Public numberOfWinners As Integer
    Public numberOfRunners As Integer
    Public numberOfActiveRunners As Integer
    Public lastMatchTime As Date
    Public totalMatched As Double
    Public totalAvailable As Double
    Public crossMatching As Boolean
    Public runnersVoidable As Boolean
    Public version As Integer
    Public runners As New List(Of clsMarketBookRunnerClass)
End Class
