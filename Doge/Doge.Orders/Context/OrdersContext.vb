Imports Doge.Model
Imports System.Data.Entity

Public Class OrdersContext
    Inherits DbContext

    Public Property Orders As DbSet(Of Order)

    Public Sub New(connectionString As String)
        MyBase.New(connectionString)
    End Sub
End Class
