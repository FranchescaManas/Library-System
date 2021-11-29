Imports System.Data
Imports System.Data.SqlClient

Public Class StudentModule

    Dim con1 As SqlConnection = New SqlConnection("server=desktop-ho13apm\sqlexpress;database=lib1;Trusted_Connection=True")
    Dim cmd1 As SqlCommand
    Dim SQL1 As String
    Dim rdr1 As SqlDataReader

    Dim index1 As Integer = 0
    Dim lastindex1 As Integer
    Dim available1 As Integer
    Dim varstocks1 As Integer
    Dim varCtr As Integer = 0
    Dim varISBN As String
    Public varTNO As String
    Dim varNotes As String
    Dim varCartIndex As Integer
    Dim varSelectBook As Integer
    Dim counter As Integer = 0



    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listbooks()
        listCategory()
        listBorrow()
        lastindex1 = books_dg.Rows.Count() - 1
        count()
        listReturngrid()
        listReserved()

        Dim selectedRow As DataGridViewRow
        selectedRow = books_dg.Rows(index1)
        Me.isbn_lbl.Text = selectedRow.Cells(0).Value.ToString
        Me.title_txtbx.Text = selectedRow.Cells(1).Value.ToString
        Me.author_txtbx.Text = selectedRow.Cells(2).Value.ToString
        Me.abstract_txtbx.Text = selectedRow.Cells(3).Value.ToString
        If avail_lbl.Text = "Not Available" Then
            cart_btn.Enabled = False
        Else
            cart_btn.Enabled = True
        End If

    End Sub

    Sub listbooks()
        con1.Open()
        cmd1 = New SqlCommand("SELECT * FROM tblBooks", con1)
        rdr1 = cmd1.ExecuteReader
        books_dg.Rows.Clear()

        If rdr1.HasRows Then
            Do While rdr1.Read
                Dim arr As String() = New String(10) {}

                arr(0) = rdr1("ISBN")
                arr(1) = rdr1("Title")
                arr(2) = rdr1("Author")
                arr(3) = rdr1("Abstract")
                arr(4) = rdr1("Description")
                arr(5) = rdr1("Publisher")
                arr(6) = rdr1("CopyRightYear")
                arr(7) = rdr1("Category")
                arr(8) = rdr1("UnitPrice")
                arr(9) = rdr1("Qty")
                arr(10) = rdr1("InStock")

                books_dg.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4), arr(5), arr(6), arr(7), arr(8), arr(9), arr(10))

            Loop
        End If
        con1.Close()

    End Sub

    Private Sub books_dg_Click(sender As Object, e As EventArgs)
        Me.isbn_lbl.Text = books_dg.CurrentRow.Cells(0).Value.ToString
        Me.title_txtbx.Text = books_dg.CurrentRow.Cells(1).Value.ToString
        Me.author_txtbx.Text = books_dg.CurrentRow.Cells(2).Value.ToString
        Me.abstract_txtbx.Text = books_dg.CurrentRow.Cells(3).Value.ToString

        varstocks1 = books_dg.CurrentRow.Cells(10).Value.ToString
        If varstocks1 = "0" Then
            avail_lbl.Text = "Not Available"
            cart_btn.Enabled = False
        Else
            avail_lbl.Text = "Available"
            cart_btn.Enabled = True
        End If
    End Sub

    Sub listCategory()
        con1.Open()
        cmd1 = New SqlCommand("SELECT distinct category FROM tblBooks", con1)
        rdr1 = cmd1.ExecuteReader

        If rdr1.HasRows Then
            Do While rdr1.Read()
                Dim arr As String() = New String(0) {}
                arr(0) = rdr1("Category")
                Me.category_combo.Items.Add(arr(0))
            Loop
        End If
        con1.Close()

    End Sub
    Private Sub category_combo_Click(sender As Object, e As EventArgs)
        listCategory()

    End Sub



    Private Sub category_combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles category_combo.SelectedIndexChanged
        listCategory()

    End Sub

    Private Sub searchTitle_txtbx_TextChanged(sender As Object, e As EventArgs) Handles searchTitle_txtbx.TextChanged
        con1.Open()
        cmd1 = New SqlCommand("SELECT * FROM tblBooks where title like '%" & searchTitle_txtbx.Text & "%'", con1)
        rdr1 = cmd1.ExecuteReader
        books_dg.Rows.Clear()

        If rdr1.HasRows Then
            Do While rdr1.Read
                Dim arr As String() = New String(10) {}
                arr(0) = rdr1("ISBN")
                arr(1) = rdr1("Title")
                arr(2) = rdr1("Author")
                arr(3) = rdr1("Abstract")
                arr(4) = rdr1("Description")
                arr(5) = rdr1("Publisher")
                arr(6) = rdr1("CopyRightYear")
                arr(7) = rdr1("Category")
                arr(8) = rdr1("UnitPrice")
                arr(9) = rdr1("Qty")
                arr(10) = rdr1("InStock")
                varstocks1 = arr(10)
                books_dg.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4), arr(5), arr(6), arr(7), arr(8), arr(9), arr(10))
            Loop
            Dim selectedrow As DataGridViewRow
            selectedrow = books_dg.Rows(index1)
            Me.isbn_lbl.Text = selectedrow.Cells(0).Value.ToString
            Me.title_txtbx.Text = selectedrow.Cells(1).Value.ToString
            Me.author_txtbx.Text = selectedrow.Cells(2).Value.ToString
            Me.abstract_txtbx.Text = selectedrow.Cells(3).Value.ToString

            If varstocks1 = "0" Then
                avail_lbl.Text = "Not Available"
                cart_btn.Enabled = False
            Else
                avail_lbl.Text = "Available"
                cart_btn.Enabled = True
            End If

        End If
        con1.Close()
        lastindex1 = books_dg.Rows.Count() - 1
        index1 = 0
        If counter = 3 Then
            cart_btn.Enabled = False
        Else
            cart_btn.Enabled = True
        End If
    End Sub

    Private Sub searchAuthor_txtbx_TextChanged(sender As Object, e As EventArgs) Handles searchAuthor_txtbx.TextChanged
        con1.Open()
        cmd1 = New SqlCommand("SELECT * FROM tblBooks where author like '%" & searchAuthor_txtbx.Text & "%'", con1)
        rdr1 = cmd1.ExecuteReader
        books_dg.Rows.Clear()

        If rdr1.HasRows Then
            Do While rdr1.Read
                Dim arr As String() = New String(10) {}
                arr(0) = rdr1("ISBN")
                arr(1) = rdr1("Title")
                arr(2) = rdr1("Author")
                arr(3) = rdr1("Abstract")
                arr(4) = rdr1("Description")
                arr(5) = rdr1("Publisher")
                arr(6) = rdr1("CopyRightYear")
                arr(7) = rdr1("Category")
                arr(8) = rdr1("UnitPrice")
                arr(9) = rdr1("Qty")
                arr(10) = rdr1("InStock")
                varstocks1 = arr(10)

                books_dg.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4), arr(5), arr(6), arr(7), arr(8), arr(9), arr(10))
            Loop
            Dim selectedrow As DataGridViewRow
            selectedrow = books_dg.Rows(index1)
            Me.isbn_lbl.Text = selectedrow.Cells(0).Value.ToString
            Me.title_txtbx.Text = selectedrow.Cells(1).Value.ToString
            Me.author_txtbx.Text = selectedrow.Cells(2).Value.ToString
            Me.abstract_txtbx.Text = selectedrow.Cells(3).Value.ToString

            If varstocks1 = "0" Then
                avail_lbl.Text = "Not Available"
                cart_btn.Enabled = False
            Else
                avail_lbl.Text = "Available"
                cart_btn.Enabled = True
            End If

        End If
        con1.Close()
        lastindex1 = books_dg.Rows.Count() - 1
        index1 = 0
        If counter = 3 Then
            cart_btn.Enabled = False
        Else
            cart_btn.Enabled = True
        End If
    End Sub

    Private Sub searchISBN_txtbx_TextChanged(sender As Object, e As EventArgs) Handles searchISBN_txtbx.TextChanged
        con1.Open()
        cmd1 = New SqlCommand("SELECT * FROM tblBooks where ISBN like '%" & searchISBN_txtbx.Text & "%'", con1)
        rdr1 = cmd1.ExecuteReader
        books_dg.Rows.Clear()

        If rdr1.HasRows Then
            Do While rdr1.Read
                Dim arr As String() = New String(10) {}
                arr(0) = rdr1("ISBN")
                arr(1) = rdr1("Title")
                arr(2) = rdr1("Author")
                arr(3) = rdr1("Abstract")
                arr(4) = rdr1("Description")
                arr(5) = rdr1("Publisher")
                arr(6) = rdr1("CopyRightYear")
                arr(7) = rdr1("Category")
                arr(8) = rdr1("UnitPrice")
                arr(9) = rdr1("Qty")
                arr(10) = rdr1("InStock")
                varstocks1 = arr(10)

                books_dg.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4), arr(5), arr(6), arr(7), arr(8), arr(9), arr(10))
            Loop
            Dim selectedrow As DataGridViewRow
            selectedrow = books_dg.Rows(index1)
            Me.isbn_lbl.Text = selectedrow.Cells(0).Value.ToString
            Me.title_txtbx.Text = selectedrow.Cells(1).Value.ToString
            Me.author_txtbx.Text = selectedrow.Cells(2).Value.ToString
            Me.abstract_txtbx.Text = selectedrow.Cells(3).Value.ToString

            If varstocks1 = "0" Then
                avail_lbl.Text = "Not Available"
                cart_btn.Enabled = False
            Else
                avail_lbl.Text = "Available"
                cart_btn.Enabled = True
            End If

        End If
        con1.Close()
        lastindex1 = books_dg.Rows.Count() - 1
        index1 = 0
        If counter = 3 Then
            cart_btn.Enabled = False
        Else
            cart_btn.Enabled = True
        End If
    End Sub

    Private Sub cart_btn_Click(sender As Object, e As EventArgs) Handles cart_btn.Click
        varCtr = cart_dg.Rows.Count + 1
        If varCtr <= 3 Then
            cart_dg.Rows.Add(Me.title_txtbx.Text, Me.isbn_lbl.Text)
        Else
            MessageBox.Show("Allowed 3 books only!", "LibSys", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        counter = counter + 1
        cartAvail.Text = counter.ToString
        If counter = 3 Then
            cart_btn.Enabled = False
            MessageBox.Show("You have reached the maximum of 3 books")
        Else
            cart_btn.Enabled = True
        End If

    End Sub

    Private Sub reserve_btn_Click(sender As Object, e As EventArgs) Handles reserve_btn.Click
        varNotes = "Reserved"
        Dim DgCartRows = cart_dg.Rows.Count - 1
        Dim X As Integer = 0
        For X = 0 To DgCartRows
            SQL1 = ("insert into tblReserveTransaction ([userID], [transactionNo], [dateResreved],[isbn],[Notes])
                    values ('" & Me.lblUserId.Text & "','" & varTNO & "', '" & Date.Now & "','" & cart_dg.Rows(X).Cells(1).Value & "','" & varNotes & "')")
            con1.Open()
            cmd1 = New SqlCommand(SQL1, con1)
            cmd1.ExecuteNonQuery()
            con1.Close()
        Next
        DgCartRows = DgCartRows + 1
        MessageBox.Show("You reserved " + DgCartRows.ToString + "Book/s", "LibSys", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cart_dg.Rows.Clear()
        listReserved()
        count()
    End Sub

    Private Sub cart_dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles cart_dg.CellClick
        varSelectBook = 1
        varCartIndex = cart_dg.CurrentCell.RowIndex
        varISBN = cart_dg.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub remove_btn_Click(sender As Object, e As EventArgs) Handles remove_btn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete?", "", MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning)

        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then

            If varSelectBook = 1 Then

                cart_dg.Rows.RemoveAt(varCartIndex)
                varSelectBook = 0
            Else
                MessageBox.Show("Select a book", "LibSys", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If

            counter = counter - 1
            cartAvail.Text = counter.ToString
            If counter = 3 Then
                cart_btn.Enabled = False
            Else
                cart_btn.Enabled = True
            End If
        End If

    End Sub

    Private Sub books_dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles books_dg.CellClick
        If books_dg.SelectedRows.Count > 0 Then
            Me.isbn_lbl.Text = books_dg.CurrentRow.Cells(0).Value.ToString
            Me.title_txtbx.Text = books_dg.CurrentRow.Cells(1).Value.ToString
            Me.author_txtbx.Text = books_dg.CurrentRow.Cells(2).Value.ToString
            Me.abstract_txtbx.Text = books_dg.CurrentRow.Cells(3).Value.ToString

            varstocks1 = books_dg.CurrentRow.Cells(10).Value.ToString


            cartAvail.Text = counter.ToString
            If counter = 3 Then
                cart_btn.Enabled = False
            Else
                cart_btn.Enabled = True
            End If

            If varstocks1 = "0" Then
                avail_lbl.Text = "Not Available"
                cart_btn.Enabled = False
            Else
                avail_lbl.Text = "Available"
                cart_btn.Enabled = True
            End If

        Else
            MessageBox.Show("No Current Record.")

        End If


    End Sub

    Private Sub last_btn_Click(sender As Object, e As EventArgs) Handles last_btn.Click
        If books_dg.SelectedRows.Count > 0 Then
            index1 = books_dg.Rows.Count() - 1
            Dim selectedrow As DataGridViewRow
            selectedrow = books_dg.Rows(index1)
            Me.isbn_lbl.Text = selectedrow.Cells(0).Value.ToString
            Me.title_txtbx.Text = selectedrow.Cells(1).Value.ToString
            Me.author_txtbx.Text = selectedrow.Cells(2).Value.ToString
            Me.abstract_txtbx.Text = selectedrow.Cells(3).Value.ToString

            varstocks1 = selectedrow.Cells(10).Value.ToString
            If varstocks1 = "0" Then
                avail_lbl.Text = "Not Available"
                cart_btn.Enabled = False
            Else
                avail_lbl.Text = "Available"
                cart_btn.Enabled = True
            End If
        Else
            MessageBox.Show("No Current Record.")
        End If
    End Sub

    Private Sub next_btn_Click(sender As Object, e As EventArgs) Handles next_btn.Click
        If books_dg.SelectedRows.Count > 0 Then
            If lastindex1 = index1 Then
                MessageBox.Show("Last Record")
            Else
                index1 = index1 + 1
                Dim selectedrow As DataGridViewRow
                selectedrow = books_dg.Rows(index1)
                Me.isbn_lbl.Text = selectedrow.Cells(0).Value.ToString
                Me.title_txtbx.Text = selectedrow.Cells(1).Value.ToString
                Me.author_txtbx.Text = selectedrow.Cells(2).Value.ToString
                Me.abstract_txtbx.Text = selectedrow.Cells(3).Value.ToString

                varstocks1 = selectedrow.Cells(10).Value.ToString
                If varstocks1 = "0" Then
                    avail_lbl.Text = "Not Available"
                    cart_btn.Enabled = False
                Else
                    avail_lbl.Text = "Available"
                    cart_btn.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub prev_btn_Click(sender As Object, e As EventArgs) Handles prev_btn.Click
        If books_dg.SelectedRows.Count > 0 Then
            If index1 = 0 Then
                MessageBox.Show("First Record")
            Else
                index1 = index1 - 1
                Dim selectedrow As DataGridViewRow
                selectedrow = books_dg.Rows(index1)
                Me.isbn_lbl.Text = selectedrow.Cells(0).Value.ToString
                Me.title_txtbx.Text = selectedrow.Cells(1).Value.ToString
                Me.author_txtbx.Text = selectedrow.Cells(2).Value.ToString
                Me.abstract_txtbx.Text = selectedrow.Cells(3).Value.ToString

                varstocks1 = selectedrow.Cells(10).Value.ToString
                If varstocks1 = "0" Then
                    avail_lbl.Text = "Not Available"
                    cart_btn.Enabled = False
                Else
                    avail_lbl.Text = "Available"
                    cart_btn.Enabled = True
                End If
            End If
        Else
            MessageBox.Show("No Current Record!")
        End If
    End Sub

    Private Sub first_btn_Click(sender As Object, e As EventArgs) Handles first_btn.Click
        If books_dg.SelectedRows.Count > 0 Then
            index1 = 0
            Dim selectedrow As DataGridViewRow
            selectedrow = books_dg.Rows(index1)
            Me.isbn_lbl.Text = selectedrow.Cells(0).Value.ToString
            Me.title_txtbx.Text = selectedrow.Cells(1).Value.ToString
            Me.author_txtbx.Text = selectedrow.Cells(2).Value.ToString
            Me.abstract_txtbx.Text = selectedrow.Cells(3).Value.ToString

            varstocks1 = selectedrow.Cells(10).Value.ToString
            If varstocks1 = "0" Then
                avail_lbl.Text = "Not Available"
                cart_btn.Enabled = False
            Else
                avail_lbl.Text = "Available"
                cart_btn.Enabled = True
            End If
        Else
            MessageBox.Show("No Current Record!")
        End If
    End Sub

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        con1.Open()
        cmd1 = New SqlCommand("SELECT * FROM tblBooks where category like '%" & category_combo.Text & "%'", con1)
        rdr1 = cmd1.ExecuteReader
        books_dg.Rows.Clear()

        If rdr1.HasRows Then
            Do While rdr1.Read
                Dim arr As String() = New String(10) {}
                arr(0) = rdr1("ISBN")
                arr(1) = rdr1("Title")
                arr(2) = rdr1("Author")
                arr(3) = rdr1("Abstract")
                arr(4) = rdr1("Description")
                arr(5) = rdr1("Publisher")
                arr(6) = rdr1("CopyRightYear")
                arr(7) = rdr1("Category")
                arr(8) = rdr1("UnitPrice")
                arr(9) = rdr1("Qty")
                arr(10) = rdr1("InStock")

                books_dg.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4), arr(5), arr(6), arr(7), arr(8), arr(9), arr(10))
            Loop
        End If
        con1.Close()

        lastindex1 = books_dg.Rows.Count() - 1
        index1 = 0
        If counter = 3 Then
            cart_btn.Enabled = False
        Else
            cart_btn.Enabled = True
        End If
    End Sub

    Private Sub menu_btn_CheckedChanged(sender As Object, e As EventArgs) Handles menu_btn.CheckedChanged
        If menu_btn.Checked Then
            Guna2PictureBox1.Visible = True
            Guna2Panel1.Visible = False
            lblUserId.Visible = True
            id_lbl.Visible = True
            name_lbl.Visible = True
            Label2.Visible = True
            cartAvail.Visible = True
            Guna2Panel1.Width = 200
            Guna2Transition1.ShowSync(Guna2Panel1)
        Else
            Guna2PictureBox1.Visible = False
            Guna2Panel1.Visible = False
            lblUserId.Visible = False
            lblUserId.Visible = False
            id_lbl.Visible = False
            name_lbl.Visible = False
            Label2.Visible = False
            cartAvail.Visible = False
            Guna2Panel1.Width = 42
            Guna2Transition1.ShowSync(Guna2Panel1)
        End If
    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Me.Hide()
        Dim Form1 As New GuestModule
        Form1.Show()
    End Sub

    Private Sub searchAndreserve_btn_Click_1(sender As Object, e As EventArgs) Handles searchAndreserve_btn.Click
        serachNreservePanel.Show()
        searchAndreserve_btn.Visible = True
        transactionPanel.Hide()
        transactionPanel.Visible = False

    End Sub

    Private Sub transaction_btn_Click_1(sender As Object, e As EventArgs) Handles transaction_btn.Click
        transactionPanel.Show()
        transactionPanel.Visible = True
        serachNreservePanel.Hide()
        serachNreservePanel.Visible = False
    End Sub


    Sub count()

        con1.Open()
        cmd1 = New SqlCommand("SELECT (SELECT COUNT(UserID) FROM tblReserveTransaction WHERE UserID = '" & lblUserId.Text & "') 
        + (SELECT COUNT(UserID) from tblBorrowTran WHERE UserID = '" & lblUserId.Text & "' and IsBookReturned = 'False')
        AS SumCount", con1)
        rdr1 = cmd1.ExecuteReader
        If rdr1.HasRows Then
            Do While rdr1.Read
                Dim z As Integer
                z = rdr1("SumCount")
                counter = z
            Loop

        End If
        con1.Close()

        cartAvail.Text = counter.ToString
        If counter = 3 Then
            reserve_btn.Enabled = False
            cart_btn.Enabled = False

        Else
            reserve_btn.Enabled = True
            cart_btn.Enabled = True

        End If
    End Sub

    Sub listReturngrid()
        con1.Open()
        cmd1 = New SqlCommand("SELECT * FROM tblReturnTran where UserID = '" & Me.lblUserId.Text & "'", con1)
        rdr1 = cmd1.ExecuteReader
        return_dg.Rows.Clear()

        If rdr1.HasRows Then
            Do While rdr1.Read()
                Dim arr As String() = New String(7) {}
                arr(0) = rdr1("UserId")
                arr(1) = rdr1("TransactionNo")
                arr(2) = rdr1("DateReturned")
                arr(3) = rdr1("ISBN")
                arr(4) = rdr1("BTransactionNo")
                arr(5) = rdr1("Overdue")
                arr(6) = rdr1("Status")



                return_dg.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4), arr(5), arr(6))
            Loop

        End If
        con1.Close()
    End Sub
    Sub listBorrow()
        con1.Open()
        cmd1 = New SqlCommand("SELECT * FROM tblBorrowTran where UserID = '" & lblUserId.Text & "'", con1)
        rdr1 = cmd1.ExecuteReader
        borrow_dg.Rows.Clear()

        If rdr1.HasRows Then
            Do While rdr1.Read()
                Dim arr As String() = New String(5) {}
                arr(0) = rdr1("UserId")
                arr(1) = rdr1("TransactionNo")
                arr(2) = rdr1("DateBorrowed")
                arr(3) = rdr1("ISBN")
                arr(4) = rdr1("IsBookReturned")
                arr(5) = rdr1("Notes")

                borrow_dg.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4), arr(5))
            Loop

        End If
        con1.Close()
    End Sub


    Sub listReserved()
        con1.Open()
        cmd1 = New SqlCommand("SELECT * FROM tblReserveTransaction where userid = '" & Me.lblUserId.Text & "'", con1)
        rdr1 = cmd1.ExecuteReader
        reserve_dg.Rows.Clear()

        If rdr1.HasRows Then
            Do While rdr1.Read()
                Dim arr As String() = New String(4) {}
                arr(0) = rdr1("UserId")
                arr(1) = rdr1("TransactionNo")
                arr(2) = rdr1("DateResreved")
                arr(3) = rdr1("ISBN")
                arr(4) = rdr1("Notes")

                reserve_dg.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4))
            Loop

        End If
        con1.Close()
    End Sub

    Private Sub serachNreservePanel_Paint(sender As Object, e As PaintEventArgs) Handles serachNreservePanel.Paint

    End Sub

    Private Sub title_txtbx_TextChanged(sender As Object, e As EventArgs) Handles title_txtbx.TextChanged

    End Sub
End Class