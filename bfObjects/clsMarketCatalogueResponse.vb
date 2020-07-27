Imports System.Net.Http.Headers
Imports System.Xml
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

    Public Property tabs As New Data.DataTable

    Public Sub gettables()
        Dim dt As New System.Data.DataTable("clsMarketCatalogueResponse")
        Dim dt_temp As New System.Data.DataTable

        If result.Count > 0 Then

            For Each tab As ABEresponses.MarketCatalogue In Me.result
                dt_temp = tab.gettable.Copy
                dt.Merge(dt_temp.Copy, True, MissingSchemaAction.Add)
            Next

        End If

        'Dim dr As DataRow
        'dr = dt.NewRow

        'dt.Rows.Add(dr)

        tabs = dt



    End Sub


End Class
