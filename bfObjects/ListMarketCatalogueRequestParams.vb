Public Class Params
    Public ReadOnly Property sort As String = MarketSort.FIRST_TO_START.ToString
    Public ReadOnly Property maxResults As String = "200"
    Public ReadOnly Property marketProjection As New List(Of String)
    Public ReadOnly Property filter As New Filter
End Class
