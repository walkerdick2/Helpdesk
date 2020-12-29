Imports System.Data.SqlClient
Imports System.Data
Public Class SMAIN
    Dim myCnn As SqlConnection


    Private Sub SMAIN_Load(sender As Object, e As EventArgs) Handles Me.Load
        myCnn = New SqlConnection("Data Source=IT-MINI14\SQLEXPRESS;Initial Catalog=Helpdesk;Integrated Security=True")

        Try
            myCnn.Open()
            TSS1.Text = "Connection to the server succeeded!"
            Me.BindingSource1.DataSource = myCnn
            Me.BindingSource1.DataMember = myCnn.


        Catch ex As Exception
            TSS1.Text = "Server Connection error : " + ex.Message
        End Try
    End Sub

    Public Function UpDateTickets()
        Try
            myCnn.Open()
            TSS1.Text = "Connection to the server succeeded!"
            Me.BindingSource1.DataSource = myCnn
            Me.BindingSource1.DataMember = myCnn.


        Catch ex As Exception
            TSS1.Text = "Server Connection error : " + ex.Message
        End Try

        Return 0
    End Function
End Class