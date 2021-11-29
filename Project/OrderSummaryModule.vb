Imports System.Data.SqlClient
Public Class OrderSummaryModule

    Dim con As SqlConnection = New SqlConnection("server=desktop-ho13apm\sqlexpress;database=lib1;Trusted_Connection=True")
    Dim cmd As SqlCommand
    Dim SQL As String
    Dim rdr As SqlDataReader
    Public ID As String



    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listReport()

    End Sub

    Sub listReport()
        con.Open()
        cmd = New SqlCommand("Select tblBooks.Title, tblBorrowTran.ISBN, tblBorrowTran.UserID, tblBorrowTran.DateBorrowed, 
        tblBorrowTran.DateBorrowed + 3 as DueDate, tblBorrowTran.TransactionNo
        from tblBooks, tblBorrowTran, tblUsers
        where tblBorrowTran.ISBN = tblBooks.ISBN
        and tblBorrowTran.UserID = tblUsers.UserID
        and tblBorrowTran.UserID = '" & ID & "'", con)

        rdr = cmd.ExecuteReader
        print_dg.Rows.Clear()

        If rdr.HasRows Then
            Do While rdr.Read
                Dim arr As String() = New String(5) {}
                arr(0) = rdr("Title")
                arr(1) = rdr("ISBN")
                arr(2) = rdr("TransactionNo")
                arr(3) = rdr("DateBorrowed")
                Label6.Text = arr(3)
                arr(4) = rdr("DueDate")
                Label7.Text = arr(4)
                arr(5) = rdr("UserID")
                varID.Text = arr(5)


                print_dg.Rows.Add(arr(0), arr(1), arr(2), arr(5))


            Loop
        End If
        con.Close()
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Me.Hide()
        Dim Form4 As New AdminModule
        Form4.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        MessageBox.Show("Successfully Printed!")
    End Sub
End Class