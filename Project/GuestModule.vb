Imports System.Data
Imports System.Data.SqlClient



Public Class GuestModule

    Dim connection As SqlConnection = New SqlConnection("server=localhost\sqlexpress;database=lib1;Trusted_Connection=True")
    Dim rdr As SqlDataReader
    Dim cmd As SqlCommand
    Dim SQL As String
    Dim index As Integer = 0
    Dim lastIndex As Integer
    Dim varstocks As Integer


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        transaction_btn.Enabled = False
        cart_btn.Enabled = False


        listbooks()
        lastIndex = listData.Rows.Count() - 1


        Dim selectedRow As DataGridViewRow
        selectedRow = listData.Rows(index)
        Me.isbn_lbl.Text = selectedRow.Cells(0).Value.ToString
        Me.title_txtbx.Text = selectedRow.Cells(1).Value.ToString
        Me.author_txtbx.Text = selectedRow.Cells(2).Value.ToString
        Me.abstract_txtbx.Text = selectedRow.Cells(3).Value.ToString

    End Sub

    Sub listbooks()
        connection.Open()
        cmd = New SqlCommand("SELECT * FROM tblBooks", connection)
        rdr = cmd.ExecuteReader
        listData.Rows.Clear()

        If rdr.HasRows Then
            Do While rdr.Read
                Dim arr As String() = New String(10) {}

                arr(0) = rdr("ISBN")
                arr(1) = rdr("Title")
                arr(2) = rdr("Author")
                arr(3) = rdr("Abstract")
                arr(4) = rdr("Description")
                arr(5) = rdr("Publisher")
                arr(6) = rdr("CopyRightYear")
                arr(7) = rdr("Category")
                arr(8) = rdr("UnitPrice")
                arr(9) = rdr("Qty")
                arr(10) = rdr("InStock")

                listData.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4), arr(5), arr(6), arr(7), arr(8), arr(9), arr(10))

            Loop
        End If
        connection.Close()
    End Sub

    Private Sub first_btn_Click(sender As Object, e As EventArgs) Handles first_btn.Click
        index = 0
        Dim selectedrow As DataGridViewRow
        selectedrow = listData.Rows(index)
        Me.isbn_lbl.Text = selectedrow.Cells(0).Value.ToString
        Me.title_txtbx.Text = selectedrow.Cells(1).Value.ToString
        Me.author_txtbx.Text = selectedrow.Cells(2).Value.ToString
        Me.abstract_txtbx.Text = selectedrow.Cells(3).Value.ToString

        varstocks = selectedrow.Cells(10).Value.ToString
        If varstocks = "0" Then
            avail_lbl.Text = "Not Available"
        Else
            avail_lbl.Text = "Available"
        End If
    End Sub

    Private Sub next_btn_Click(sender As Object, e As EventArgs) Handles next_btn.Click
        If lastIndex = index Then
            MessageBox.Show("Last Record")
        Else
            index = index + 1
            Dim selectedrow As DataGridViewRow
            selectedrow = listData.Rows(index)
            Me.isbn_lbl.Text = selectedrow.Cells(0).Value.ToString
            Me.title_txtbx.Text = selectedrow.Cells(1).Value.ToString
            Me.author_txtbx.Text = selectedrow.Cells(2).Value.ToString
            Me.abstract_txtbx.Text = selectedrow.Cells(3).Value.ToString

            varstocks = selectedrow.Cells(10).Value.ToString
            If varstocks = "0" Then
                avail_lbl.Text = "Not Available"
            Else
                avail_lbl.Text = "Available"
            End If
        End If
    End Sub

    Private Sub prev_btn_Click(sender As Object, e As EventArgs) Handles prev_btn.Click
        If index = 0 Then
            MessageBox.Show("First Record")
        Else
            index = index - 1
            Dim selectedrow As DataGridViewRow
            selectedrow = listData.Rows(index)
            Me.isbn_lbl.Text = selectedrow.Cells(0).Value.ToString
            Me.title_txtbx.Text = selectedrow.Cells(1).Value.ToString
            Me.author_txtbx.Text = selectedrow.Cells(2).Value.ToString
            Me.abstract_txtbx.Text = selectedrow.Cells(3).Value.ToString

            varstocks = selectedrow.Cells(10).Value.ToString
            If varstocks = "0" Then
                avail_lbl.Text = "Not Available"
            Else
                avail_lbl.Text = "Available"
            End If
        End If
    End Sub

    Private Sub last_btn_Click(sender As Object, e As EventArgs) Handles last_btn.Click
        index = listData.Rows.Count() - 1
        Dim selectedrow As DataGridViewRow
        selectedrow = listData.Rows(index)
        Me.isbn_lbl.Text = selectedrow.Cells(0).Value.ToString
        Me.title_txtbx.Text = selectedrow.Cells(1).Value.ToString
        Me.author_txtbx.Text = selectedrow.Cells(2).Value.ToString
        Me.abstract_txtbx.Text = selectedrow.Cells(3).Value.ToString

        varstocks = selectedrow.Cells(10).Value.ToString
        If varstocks = "0" Then
            avail_lbl.Text = "Not Available"
        Else
            avail_lbl.Text = "Available"
        End If
    End Sub

    Private Sub searchTitle_txtbx_TextChanged(sender As Object, e As EventArgs) Handles searchTitle_txtbx.TextChanged
        connection.Open()
        cmd = New SqlCommand("SELECT * FROM tblBooks where title like '%" & searchTitle_txtbx.Text & "%'", connection)
        rdr = cmd.ExecuteReader
        listData.Rows.Clear()

        If rdr.HasRows Then
            Do While rdr.Read
                Dim arr As String() = New String(10) {}
                arr(0) = rdr("ISBN")
                arr(1) = rdr("Title")
                arr(2) = rdr("Author")
                arr(3) = rdr("Abstract")
                arr(4) = rdr("Description")
                arr(5) = rdr("Publisher")
                arr(6) = rdr("CopyRightYear")
                arr(7) = rdr("Category")
                arr(8) = rdr("UnitPrice")
                arr(9) = rdr("Qty")
                arr(10) = rdr("InStock")

                listData.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4), arr(5), arr(6), arr(7), arr(8), arr(9), arr(10))

            Loop
        End If
        connection.Close()
        lastIndex = listData.Rows.Count() - 1
        index = 0
    End Sub

    Private Sub listData_Click(sender As Object, e As EventArgs) Handles listData.Click
        Me.isbn_lbl.Text = listData.CurrentRow.Cells(0).Value.ToString
        Me.title_txtbx.Text = listData.CurrentRow.Cells(1).Value.ToString
        Me.author_txtbx.Text = listData.CurrentRow.Cells(2).Value.ToString
        Me.abstract_txtbx.Text = listData.CurrentRow.Cells(3).Value.ToString

        varstocks = listData.CurrentRow.Cells(10).Value.ToString
        If varstocks = "0" Then
            avail_lbl.Text = "Not Available"
        Else
            avail_lbl.Text = "Available"
        End If


    End Sub

    Private Sub searchAuthor_txtbx_TextChanged(sender As Object, e As EventArgs) Handles searchAuthor_txtbx.TextChanged
        connection.Open()
        cmd = New SqlCommand("SELECT * FROM tblBooks where author like '%" & searchAuthor_txtbx.Text & "%'", connection)
        rdr = cmd.ExecuteReader
        listData.Rows.Clear()

        If rdr.HasRows Then
            Do While rdr.Read
                Dim arr As String() = New String(10) {}
                arr(0) = rdr("ISBN")
                arr(1) = rdr("Title")
                arr(2) = rdr("Author")
                arr(3) = rdr("Abstract")
                arr(4) = rdr("Description")
                arr(5) = rdr("Publisher")
                arr(6) = rdr("CopyRightYear")
                arr(7) = rdr("Category")
                arr(8) = rdr("UnitPrice")
                arr(9) = rdr("Qty")
                arr(10) = rdr("InStock")

                listData.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4), arr(5), arr(6), arr(7), arr(8), arr(9), arr(10))
            Loop
        End If
        connection.Close()
        lastIndex = listData.Rows.Count() - 1
        index = 0
    End Sub

    Private Sub searchISBN_txtbx_TextChanged(sender As Object, e As EventArgs) Handles searchISBN_txtbx.TextChanged
        connection.Open()
        cmd = New SqlCommand("SELECT * FROM tblBooks where ISBN like '%" & searchISBN_txtbx.Text & "%'", connection)
        rdr = cmd.ExecuteReader
        listData.Rows.Clear()

        If rdr.HasRows Then
            Do While rdr.Read
                Dim arr As String() = New String(10) {}
                arr(0) = rdr("ISBN")
                arr(1) = rdr("Title")
                arr(2) = rdr("Author")
                arr(3) = rdr("Abstract")
                arr(4) = rdr("Description")
                arr(5) = rdr("Publisher")
                arr(6) = rdr("CopyRightYear")
                arr(7) = rdr("Category")
                arr(8) = rdr("UnitPrice")
                arr(9) = rdr("Qty")
                arr(10) = rdr("InStock")

                listData.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4), arr(5), arr(6), arr(7), arr(8), arr(9), arr(10))
            Loop
        End If
        connection.Close()
        lastIndex = listData.Rows.Count() - 1
        index = 0
    End Sub

    Sub listCategory()
        connection.Open()
        cmd = New SqlCommand("SELECT distinct category FROM tblBooks", connection)
        rdr = cmd.ExecuteReader

        If rdr.HasRows Then
            Do While rdr.Read()
                Dim arr As String() = New String(0) {}
                arr(0) = rdr("Category")
                Me.category_combo.Items.Add(arr(0))
            Loop
        End If
        connection.Close()

    End Sub

    Private Sub category_combo_Click(sender As Object, e As EventArgs) Handles category_combo.Click
        listCategory()
    End Sub

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        connection.Open()
        cmd = New SqlCommand("SELECT * FROM tblBooks where category like '%" & category_combo.Text & "%'", connection)
        rdr = cmd.ExecuteReader
        listData.Rows.Clear()

        If rdr.HasRows Then
            Do While rdr.Read
                Dim arr As String() = New String(10) {}
                arr(0) = rdr("ISBN")
                arr(1) = rdr("Title")
                arr(2) = rdr("Author")
                arr(3) = rdr("Abstract")
                arr(4) = rdr("Description")
                arr(5) = rdr("Publisher")
                arr(6) = rdr("CopyRightYear")
                arr(7) = rdr("Category")
                arr(8) = rdr("UnitPrice")
                arr(9) = rdr("Qty")
                arr(10) = rdr("InStock")

                listData.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4), arr(5), arr(6), arr(7), arr(8), arr(9), arr(10))
            Loop
        End If
        connection.Close()

        lastIndex = listData.Rows.Count() - 1
        index = 0
    End Sub



    Private Sub login_btn_Click_1(sender As Object, e As EventArgs) Handles login_btn.Click
        Dim Form2 As New LoginModule
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub menu_btn_CheckedChanged(sender As Object, e As EventArgs) Handles menu_btn.CheckedChanged
        If menu_btn.Checked Then
            Guna2PictureBox1.Visible = True
            Guna2Panel1.Visible = False
            lblUserId.Visible = True
            Guna2Panel1.Width = 202
            Guna2Transition1.ShowSync(Guna2Panel1)
        Else
            Guna2PictureBox1.Visible = False
            Guna2Panel1.Visible = False
            lblUserId.Visible = False
            Guna2Panel1.Width = 42
            Guna2Transition1.ShowSync(Guna2Panel1)
        End If
    End Sub

    Private Sub Guna2GroupBox4_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox4.Click

    End Sub
End Class