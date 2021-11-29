Imports System.Data
Imports System.Data.SqlClient


Public Class LoginModule

    Dim con As SqlConnection = New SqlConnection("server=localhost\sqlexpress;database=lib1;Trusted_Connection=True")
    Dim cmd As SqlCommand
    Dim SQL As String
    Dim rdr As SqlDataReader

    Dim Role As String
    Dim Fname As String
    Dim Lname As String
    Dim validity As Date
    Dim UserID As String


    Sub listUser()
        con.Open()
        cmd = New SqlCommand("SELECT * FROM tblusers where [Uname] = '" & Me.username_txtbx.Text & "' and [Password1] = '" & password_txtbx.Text & "'", con)
        rdr = cmd.ExecuteReader

        If rdr.HasRows Then
            Do While rdr.Read
                Dim arr As String() = New String(14) {}
                arr(0) = rdr("UserId")
                UserID = arr(0).ToString()
                arr(1) = rdr("Fname")
                Fname = arr(1).ToString()
                arr(2) = rdr("Lname")
                Lname = arr(2).ToString()
                arr(3) = rdr("ResAdrs")
                arr(4) = rdr("OfcAdrs")
                arr(5) = rdr("LandlineNO")
                arr(6) = rdr("MobileNo")
                arr(7) = rdr("Email")
                arr(8) = rdr("Gender")
                arr(9) = rdr("ImageLink")
                arr(10) = rdr("DateJoined")
                arr(11) = rdr("Validity")
                validity = arr(11)
                arr(12) = rdr("Role")
                Role = arr(12).ToString
                arr(13) = rdr("Uname")
                arr(14) = rdr("Password1")
            Loop
            con.Close()

            If Role.Equals("administrator") Then
                Me.Hide()
                MessageBox.Show("Welcome " + Fname, "LibSys", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim Form4 As New AdminModule
                Form4.Label2.Text = Fname.ToUpper()
                Form4.Show()
            Else
                If validity > Date.Now() Then
                    Me.Hide()
                    Dim Form3 As New StudentModule
                    MessageBox.Show("Welcome " + Fname.ToUpper + " " + Lname.ToUpper + "!", "LibSys", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Form3.Label2.Text = "Hello " + Fname.ToUpper + "! You login as " + Role.ToUpper()
                    Form3.name_lbl.Text = Fname.ToUpper + " " + Lname.ToUpper
                    Form3.lblUserId.Text = UserID
                    Form3.Show()
                Else
                    MessageBox.Show("Sorry your account is currenty inactive. Please update your membership account before you can continue.", "LibSys", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    username_txtbx.Clear()
                    password_txtbx.Clear()
                End If


            End If
        Else
            MessageBox.Show("Invalid Username/Password", "LibSys", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            username_txtbx.Clear()
            password_txtbx.Clear()
            con.Close()

        End If
    End Sub



    Private Sub Guna2ImageButton1_Click_1(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Hide()
        Dim Form1 As New GuestModule
        Form1.Show()
    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        listUser()
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub
End Class