Imports Doge.Model
Imports System.Configuration

Public Class Service1

    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Add code here to start your service. This method should set things
        ' in motion so your service can do its work.
    End Sub

    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.
    End Sub

    Public Function GetOrders() As List(Of Order)
        Dim orders As New List(Of Order)()
        ' Get connection string to DB from Appconfig.
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("DOGEEntities").ConnectionString
        ' Conectar a la base de datos.
        Using db As New OrdersContext(connectionString)
            ' Obtener todas las órdenes de la tabla "Orders".
            orders = db.Orders.ToList()
        End Using

        Return orders
    End Function

End Class
