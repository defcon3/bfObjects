Public Class clsMarketBookRunnerClass
    Public selectionId As Integer
    Public handicap As Double
    Public status As String
    Public adjutmentFactor As Double
    Public lastPriceTraded As Double
    Public totalMatched As Double
    Public removalDate As Date
    Public ex As New clsEx
    Public orders As New List(Of clsOrder)
End Class
