Imports System.Data.SqlClient

Public Class OrderSummary2

    Dim con As SqlConnection = New SqlConnection("server=desktop-ho13apm\sqlexpress;database=lib1;Trusted_Connection=True")
    Dim cmd As SqlCommand
    Dim SQL As String
    Dim rdr As SqlDataReader
    Public varMember As String
    Public optiontype As String
    Dim total As Double = 0
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listPrint()
    End Sub

    Sub listPrint()

        Dim tno As Integer
        Dim DglastRows = print_dg.Rows.Count - 1
        Dim X As Integer = 0
        For X = 0 To DglastRows
            cmd = New SqlCommand("Select TransactionNo from tblReturnTran where UserID = '" & varMember & "'", con)
            con.Open()
            rdr = cmd.ExecuteReader
            If rdr.HasRows Then
                Do While rdr.Read

                    tno = rdr("TransactionNo")
                Loop

            End If

            con.Close()

            total = total + print_dg.Rows(X).Cells(5).Value.ToString()
            Label2.Text = tno.ToString
            Label6.Text = Date.Now
        Next

        total_lbl.Text = total.ToString

    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Dim Form4 As New AdminModule
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles print_btn.Click
        MessageBox.Show("Successfully Printed!")
    End Sub
End Class