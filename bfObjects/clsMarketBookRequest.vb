Public Class clsMarketBookRequest
    Public jsonrpc As String = "2.0"
    Public method As String = "SportsAPING/v1.0/listMarketBook"
    Public params As New clsMarketBookParams
    Public id As Integer = 1
End Class
