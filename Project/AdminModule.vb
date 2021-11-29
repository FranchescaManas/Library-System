Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Public Class AdminModule
    Dim con As SqlConnection = New SqlConnection("server=desktop-ho13apm\sqlexpress;database=lib1;Trusted_Connection=True")
    Dim cmd As SqlCommand
    Dim SQL As String
    Dim rdr As SqlDataReader
    Dim varIndex As Integer
    Dim varstock As Integer
    Dim varSelectBook As Integer
    Dim varISBN As String
    Dim varNotes As String
    Dim varTNO As Integer

    Dim index1 As Integer = 0
    Dim lastindex1 As Integer
    Dim available1 As Integer
    Dim varCtr As Integer = 0
    Dim varCartIndex As Integer
    Dim counts As String
    Dim counters As Integer = 0

    Dim table As New DataTable()
    Dim stock As Integer
    Dim returnOption As String
    Dim status As String
    Dim rTNO As Integer = 0
    Dim rID As Integer = 0

    Dim idno As Integer
    Dim lastuserindex As Integer
    Dim valid As Date
    Dim stocks As Integer
    Dim q, s As Integer
    Dim rs, n, notes, isreturn As String

    Dim bID As String


    Private Sub menu_btn_CheckedChanged(sender As Object, e As EventArgs) Handles menu_btn.CheckedChanged
        If menu_btn.Checked Then
            Guna2PictureBox1.Visible = True
            Guna2Panel1.Visible = False
            Label2.Visible = True
            Guna2Panel1.Width = 198
            Guna2Transition1.ShowSync(Guna2Panel1)
        Else
            Guna2PictureBox1.Visible = False
            Guna2Panel1.Visible = False
            Label2.Visible = False
            Guna2Panel1.Width = 42
            Guna2Transition1.ShowSync(Guna2Panel1)
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        borrowPanel.Show()
        borrowPanel.Visible = True
        transactionPanel.Hide()
        transactionPanel.Visible = False
        administrativePanel.Hide()
        administrativePanel.Visible = False
        userPanel.Hide()
        userPanel.Visible = False
        bookPanel.Hide()
        bookPanel.Visible = False



    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        transactionPanel.Show()
        transactionPanel.Visible = True
        administrativePanel.Hide()
        administrativePanel.Visible = False
        borrowPanel.Hide()
        borrowPanel.Visible = False
        userPanel.Hide()
        userPanel.Visible = False
        bookPanel.Hide()
        bookPanel.Visible = False

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        administrativePanel.Show()
        administrativePanel.Visible = True
        borrowPanel.Hide()
        borrowPanel.Visible = False
        transactionPanel.Hide()
        transactionPanel.Visible = False
        userPanel.Hide()
        userPanel.Visible = False
        bookPanel.Hide()
        bookPanel.Visible = False

    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Me.Hide()
        Dim Form1 As New GuestModule
        Form1.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listReserved()
        listBorrow()
        listReturn()
        Category()
        lastindex1 = table.Rows.Count() - 1
        listUser()
        listProcess()
        listCollection()
        collection_view()
        user_view()
        navigate(index1)





    End Sub

    Private Sub removeReservation_btn_Click(sender As Object, e As EventArgs) Handles removeReservation_btn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete?", "", MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning)

        If result = DialogResult.No Then
            umDel_rad.Checked = False
        ElseIf result = DialogResult.Yes Then
            con.Open()

            If varSelectBook = 1 Then
                cmd = New SqlCommand("DELETE FROM tblReserveTransaction where ISBN like '%" & records_dg.CurrentRow.Cells(3).Value.ToString() & "%'", con)
                rdr = cmd.ExecuteReader()
                records_dg.Rows.RemoveAt(varIndex)
                varSelectBook = 0
            Else
                MessageBox.Show("Select a book", "LibSys", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If
            con.Close()
        End If

    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        con.Open()
        cmd = New SqlCommand("SELECT tblReserveTransaction.UserID, tblReserveTransaction.DateResreved, tblBooks.Title, tblReserveTransaction.ISBN
FROM tblReserveTransaction INNER JOIN tblBooks ON tblReserveTransaction.ISBN = tblBooks.ISBN where tblReserveTransaction.UserID like '%" & userId_txtbx.Text & "%'", con)
        rdr = cmd.ExecuteReader
        records_dg.Rows.Clear()

        If rdr.HasRows Then
            Do While rdr.Read
                Dim arr As String() = New String(3) {}
                arr(0) = rdr("UserID")
                arr(1) = rdr("DateResreved")
                arr(2) = rdr("Title")
                arr(3) = rdr("ISBN")

                records_dg.Rows.Add(arr(0), arr(1), arr(2), arr(3))
            Loop
        End If
        con.Close()
    End Sub

    Private Sub lend_btn_Click(sender As Object, e As EventArgs) Handles lend_btn.Click
        If userId_txtbx.Text = Nothing Then
            MessageBox.Show("Please enter ID")
        Else
            varNotes = "Borrowed"
            Dim DgRecordsRows = records_dg.Rows.Count - 1
            Dim X As Integer = 0
            For X = 0 To DgRecordsRows



                SQL = ("Select Qty as q, InStock as s from tblBooks where isbn = '" & records_dg.Rows(X).Cells(3).Value.ToString() & "'")
                con.Open()
                cmd = New SqlCommand(SQL, con)
                rdr = cmd.ExecuteReader
                If rdr.HasRows Then
                    Do While rdr.Read
                        Dim arr As String() = New String(1) {}
                        arr(0) = rdr("q")
                        q = arr(0)
                        arr(1) = rdr("s")
                        s = arr(1)



                    Loop

                End If
                con.Close()

                If s = 0 Or s < 0 Then
                    MessageBox.Show("'" & records_dg.Rows(X).Cells(3).Value.ToString() & "' is out of stock")
                Else

                    SQL = ("insert into tblBorrowTran ([userID], [transactionNo], [DateBorrowed],[isbn], [IsBookReturned], [Notes])
                    values ('" & records_dg.Rows(X).Cells(0).Value.ToString() & "','" & varTNO & "',
                    '" & Date.Now & "','" & records_dg.Rows(X).Cells(3).Value.ToString() & "', '" & False & "' , '" & varNotes & "')")
                    con.Open()
                    cmd = New SqlCommand(SQL, con)
                    cmd.ExecuteNonQuery()
                    con.Close()

                    SQL = ("update tblBooks set InStock = (InStock - 1) where isbn = '" & records_dg.Rows(X).Cells(3).Value.ToString() & "'")
                    con.Open()
                    cmd = New SqlCommand(SQL, con)
                    cmd.ExecuteNonQuery()
                    con.Close()


                End If

            Next

            SQL = ("DELETE FROM tblReserveTransaction where userid = ('" & userId_txtbx.Text & "')")
            con.Open()
            cmd = New SqlCommand(SQL, con)
            cmd.ExecuteNonQuery()
            con.Close()

            DgRecordsRows = DgRecordsRows + 1
            MessageBox.Show("You reserved " + DgRecordsRows.ToString + "Book/s", "LibSys", MessageBoxButtons.OK, MessageBoxIcon.Information)
            records_dg.Rows.Clear()
            listBorrow()
            listReserved()
            listReturn()

            Dim Form5 As New OrderSummaryModule
            Form5.ID = userId_txtbx.Text
            Form5.Show()
        End If

    End Sub

    Sub listBorrow()
        con.Open()
        cmd = New SqlCommand("SELECT tblBorrowTran.UserID, tblBorrowTran.TransactionNo, tblBorrowTran.DateBorrowed, tblBorrowTran.IsBookReturned, tblBorrowTran.ISBN, tblBorrowTran.Notes
FROM tblBorrowTran INNER JOIN tblReserveTransaction ON tblBorrowTran.ISBN = tblReserveTransaction.ISBN", con)
        rdr = cmd.ExecuteReader
        borrow_dg.Rows.Clear()

        If rdr.HasRows Then
            Do While rdr.Read
                Dim arr As String() = New String(5) {}
                arr(0) = rdr("UserID")
                arr(1) = rdr("TransactionNo")
                arr(2) = rdr("DateBorrowed")
                arr(3) = rdr("IsBookReturned")
                arr(4) = rdr("ISBN")
                arr(5) = rdr("Notes")


                borrow_dg.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4), arr(5))
            Loop
        End If
        con.Close()

    End Sub

    Sub Category()
        con.Open()
        cmd = New SqlCommand("SELECT distinct category FROM tblBooks", con)
        rdr = cmd.ExecuteReader

        If rdr.HasRows Then
            Do While rdr.Read()
                Dim arr As String() = New String(0) {}
                arr(0) = rdr("Category")
                category_combo.Items.Add(arr(0))
            Loop
        End If
        con.Close()

    End Sub



    Sub listReserved()
        con.Open()
        cmd = New SqlCommand("SELECT tblReserveTransaction.UserID, tblReserveTransaction.DateResreved, tblBooks.Title, tblReserveTransaction.ISBN
FROM tblReserveTransaction INNER JOIN tblBooks ON tblReserveTransaction.ISBN = tblBooks.ISBN", con)
        rdr = cmd.ExecuteReader
        records_dg.Rows.Clear()

        If rdr.HasRows Then
            Do While rdr.Read
                Dim arr As String() = New String(3) {}
                arr(0) = rdr("UserID")
                arr(1) = rdr("DateResreved")
                arr(2) = rdr("Title")
                arr(3) = rdr("ISBN")

                records_dg.Rows.Add(arr(0), arr(1), arr(2), arr(3))
            Loop
        End If
        con.Close()
    End Sub


    Private Sub records_dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles records_dg.CellClick
        varSelectBook = 1
        varIndex = records_dg.CurrentCell.RowIndex
        varISBN = records_dg.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub remove_btn_Click(sender As Object, e As EventArgs) Handles remove_btn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete?", "", MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning)

        If result = DialogResult.No Then
            umDel_rad.Checked = False
        ElseIf result = DialogResult.Yes Then
            If varSelectBook = 1 Then

                manualCart_dg.Rows.RemoveAt(varCartIndex)
                varSelectBook = 0
            Else
                MessageBox.Show("Select a book", "LibSys", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If
            'listReserved()
            counters = counters - 1
            If counters < 3 Then
                cart_btn.Enabled = True
            Else
                cart_btn.Enabled = False
            End If
        End If


    End Sub


    Private Sub category_combo_Click(sender As Object, e As EventArgs)
        Category()

    End Sub

    Private Sub searchTitle_txtbx_TextChanged(sender As Object, e As EventArgs) Handles searchTitle_txtbx.TextChanged
        con.Open()
        cmd = New SqlCommand("SELECT * FROM tblBooks where title like '%" & searchTitle_txtbx.Text & "%'", con)
        rdr = cmd.ExecuteReader

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

                Me.isbn_lbl.Text = arr(0)
                Me.title_txtbx.Text = arr(1)
                Me.author_txtbx.Text = arr(2)
                Me.abstract_txtbx.Text = arr(3)
                varstock = arr(10)

            Loop

            If varstock = "0" Then
                avail_lbl.Text = "Not Available"
                cart_btn.Enabled = False
            Else
                avail_lbl.Text = "Available"
                cart_btn.Enabled = True
            End If

        End If
        con.Close()
        index1 = 0
    End Sub

    Sub listReturn()
        con.Open()
        cmd = New SqlCommand("SELECT * FROM tblBorrowTran", con)
        rdr = cmd.ExecuteReader
        borrow_dg.Rows.Clear()

        If rdr.HasRows Then
            Do While rdr.Read()
                Dim arr As String() = New String(5) {}
                arr(0) = rdr("UserId")
                arr(1) = rdr("TransactionNo")
                varTNO = arr(1) + 1
                arr(2) = rdr("DateBorrowed")
                arr(3) = rdr("ISBN")
                arr(4) = rdr("IsBookReturned")
                arr(5) = rdr("Notes")

                borrow_dg.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4), arr(5))
            Loop

        End If
        con.Close()
    End Sub

    Private Sub searchAuthor_txtbx_TextChanged(sender As Object, e As EventArgs) Handles searchAuthor_txtbx.TextChanged
        con.Open()
        cmd = New SqlCommand("SELECT * FROM tblBooks where author like '%" & searchAuthor_txtbx.Text & "%'", con)
        rdr = cmd.ExecuteReader

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

                Me.isbn_lbl.Text = arr(0)
                Me.title_txtbx.Text = arr(1)
                Me.author_txtbx.Text = arr(2)
                Me.abstract_txtbx.Text = arr(3)
                varstock = arr(10)
            Loop

            If varstock = "0" Then
                avail_lbl.Text = "Not Available"
                cart_btn.Enabled = False
            Else
                avail_lbl.Text = "Available"
                cart_btn.Enabled = True
            End If

        End If
        con.Close()
        index1 = 0
    End Sub

    Private Sub searchISBN_txtbx_TextChanged(sender As Object, e As EventArgs) Handles searchISBN_txtbx.TextChanged
        con.Open()
        cmd = New SqlCommand("SELECT * FROM tblBooks where isbn like '%" & searchISBN_txtbx.Text & "%'", con)
        rdr = cmd.ExecuteReader

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

                Me.isbn_lbl.Text = arr(0)
                Me.title_txtbx.Text = arr(1)
                Me.author_txtbx.Text = arr(2)
                Me.abstract_txtbx.Text = arr(3)
                varstock = arr(10)
            Loop

            If varstock = "0" Then
                avail_lbl.Text = "Not Available"
                cart_btn.Enabled = False
            Else
                avail_lbl.Text = "Available"
                cart_btn.Enabled = True
            End If

        End If
        con.Close()
        index1 = 0
    End Sub

    Private Sub cart_btn_Click(sender As Object, e As EventArgs) Handles cart_btn.Click
        varCtr = manualCart_dg.Rows.Count + 1
        If varCtr <= 3 Then
            manualCart_dg.Rows.Add(Me.title_txtbx.Text, Me.isbn_lbl.Text)
            counters = counters + 1
        Else
            MessageBox.Show("Allowed 3 books only!", "LibSys", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

        counters = counters + 1


    End Sub



    Private Sub manualCart_dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles manualCart_dg.CellClick
        varSelectBook = 1
        varCartIndex = manualCart_dg.CurrentCell.RowIndex
        varISBN = manualCart_dg.CurrentRow.Cells(1).Value.ToString

    End Sub

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        con.Open()
        cmd = New SqlCommand("SELECT * FROM tblBooks where category like '%" & category_combo.Text & "%'", con)
        rdr = cmd.ExecuteReader

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

                Me.isbn_lbl.Text = arr(0)
                Me.title_txtbx.Text = arr(1)
                Me.author_txtbx.Text = arr(2)
                Me.abstract_txtbx.Text = arr(3)
                varstock = arr(10)
            Loop
        End If

        If varstock = "0" Then
            avail_lbl.Text = "Not Available"
            cart_btn.Enabled = False
        Else
            avail_lbl.Text = "Available"
            cart_btn.Enabled = True
        End If
        con.Close()
        index1 = 0
    End Sub

    Private Sub reserve_btn_Click(sender As Object, e As EventArgs) Handles reserve_btn.Click
        TabControl1.SendToBack()
        memberPanel.Show()
        memberPanel.Visible = True

    End Sub

    Private Sub member_txtbx_Click(sender As Object, e As EventArgs) Handles member_txtbx.Click
        valdate()
        listCollection()
        navigate(index1)
        Me.Refresh()

    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        memberID_txtbx.Clear()
        TabControl1.BringToFront()
        memberPanel.Hide()
        memberPanel.Visible = False
    End Sub

    Public Sub navigate(position As Integer)

        cmd = New SqlCommand("SELECT Title, Author, Abstract, ISBN, InStock FROM tblBooks", con)

        Dim adapter As New SqlDataAdapter(cmd)


        adapter.Fill(table)
        title_txtbx.Text = table.Rows(position)(0).ToString()
        author_txtbx.Text = table.Rows(position)(1).ToString()
        abstract_txtbx.Text = table.Rows(position)(2).ToString()
        isbn_lbl.Text = table.Rows(position)(3).ToString()



        stock = table.Rows(position)(4)
        If stock = 0 Then
            avail_lbl.Text = "Not Available"
            cart_btn.Enabled = False
        Else
            avail_lbl.Text = "Available"
            cart_btn.Enabled = True
        End If


    End Sub



    Private Sub first_btn_Click(sender As Object, e As EventArgs) Handles first_btn.Click
        index1 = 0
        navigate(index1)


        If stock = 0 Then
            avail_lbl.Text = "Not Available"
            cart_btn.Enabled = False
        Else
            avail_lbl.Text = "Available"
            cart_btn.Enabled = True
        End If
    End Sub

    Private Sub prev_btn_Click(sender As Object, e As EventArgs) Handles prev_btn.Click
        If index1 = 0 Then
            MessageBox.Show("First Record!")
        Else
            index1 -= 1
            navigate(index1)
            If stock = 0 Then
                avail_lbl.Text = "Not Available"
                cart_btn.Enabled = False
            Else
                avail_lbl.Text = "Available"
                cart_btn.Enabled = True
            End If

        End If

    End Sub

    Private Sub next_btn_Click(sender As Object, e As EventArgs) Handles next_btn.Click
        If index1 = table.Rows.Count() - 1 Then
            MessageBox.Show("Last Record!")
        Else
            index1 += 1
            navigate(index1)
            If stock = 0 Then
                avail_lbl.Text = "Not Available"
                cart_btn.Enabled = False
            Else
                avail_lbl.Text = "Available"
                cart_btn.Enabled = True
            End If
        End If

    End Sub

    Private Sub last_btn_Click(sender As Object, e As EventArgs) Handles last_btn.Click
        index1 = table.Rows.Count() - 1
        navigate(lastindex1)
        If stock = 0 Then
            avail_lbl.Text = "Not Available"
            cart_btn.Enabled = False
        Else
            avail_lbl.Text = "Available"
            cart_btn.Enabled = True
        End If
    End Sub

    Private Sub book_btn_Click(sender As Object, e As EventArgs) Handles book_btn.Click
        administrativePanel.Hide()
        administrativePanel.Visible = False
        borrowPanel.Hide()
        borrowPanel.Visible = False
        transactionPanel.Hide()
        transactionPanel.Visible = False
        userPanel.Hide()
        userPanel.Visible = False
        bookPanel.Show()
        bookPanel.Visible = True
        listCollection()
    End Sub

    Private Sub user_btn_Click(sender As Object, e As EventArgs) Handles user_btn.Click
        administrativePanel.Hide()
        administrativePanel.Visible = False
        borrowPanel.Hide()
        borrowPanel.Visible = False
        transactionPanel.Hide()
        transactionPanel.Visible = False
        userPanel.Show()
        userPanel.Visible = True
        bookPanel.Hide()
        bookPanel.Visible = False
    End Sub


    Private Sub memberID_txtbx_TextChanged(sender As Object, e As EventArgs) Handles memberID_txtbx.TextChanged
        bID = memberID_txtbx.Text


    End Sub
    Sub valdate()
        Dim z As Integer = 0

        SQL = ("Select Validity from tblUsers where UserId = '" & memberID_txtbx.Text & "'")
        con.Open()
        cmd = New SqlCommand(SQL, con)
        rdr = cmd.ExecuteReader
        If rdr.HasRows Then
            Do While rdr.Read
                Dim arr As String() = New String(0) {}

                arr(0) = rdr("Validity")
                valid = arr(0)


            Loop
            con.Close()
        End If

        If valid < Date.Now Then

            MessageBox.Show("User's membership is expired")
            memberID_txtbx.Clear()
        Else

            Dim y As Integer
            con.Open()
            cmd = New SqlCommand("SELECT (SELECT COUNT(UserID) FROM tblReserveTransaction WHERE UserID = '" & bID & "') 
        + (SELECT COUNT(UserID) from tblBorrowTran WHERE UserID = '" & bID & "' and IsBookReturned = 'False')
        AS SumCount", con)
            rdr = cmd.ExecuteReader
            If rdr.HasRows Then
                Do While rdr.Read

                    z = rdr("SumCount")
                    y = z
                Loop

            End If
            con.Close()


            If y >= 3 Then

                MessageBox.Show("Member's cart is full. '" & y & "' used ")

            Else

                varNotes = "Borrowed"
                Dim DgManualRows = manualCart_dg.Rows.Count - 1
                Dim X As Integer = 0
                For X = 0 To DgManualRows
                    SQL = ("insert into tblBorrowTran ([userID], [transactionNo], [DateBorrowed],[isbn], [IsBookReturned], [Notes])
                    values ('" & memberID_txtbx.Text & "','" & varTNO & "',
                    '" & Date.Now & "','" & manualCart_dg.Rows(X).Cells(1).Value.ToString() & "', '" & False & "' , '" & varNotes & "')")
                    con.Open()
                    cmd = New SqlCommand(SQL, con)
                    cmd.ExecuteNonQuery()
                    con.Close()

                    SQL = ("update tblBooks set InStock = (InStock - 1) where isbn = '" & manualCart_dg.Rows(X).Cells(1).Value.ToString() & "'")
                    con.Open()
                    cmd = New SqlCommand(SQL, con)
                    cmd.ExecuteNonQuery()
                    con.Close()

                Next

                DgManualRows = DgManualRows + 1
                MessageBox.Show("You lent " + DgManualRows.ToString + "Book/s", "LibSys", MessageBoxButtons.OK, MessageBoxIcon.Information)

                listBorrow()
                listReturn()



                TabControl1.BringToFront()
                memberPanel.Hide()
                memberPanel.Visible = False
                manualCart_dg.Rows.Clear()


                OrderSummaryModule.ID = memberID_txtbx.Text
                Me.Hide()
                OrderSummaryModule.Show()
                memberID_txtbx.Clear()
                navigate(index1)
            End If
        End If


        con.Close()
        navigate(index1)

    End Sub



    Sub listProcess()

        con.Open()


        cmd = New SqlCommand("select tblBooks.Title, tblBooks.ISBN, tblBorrowTran.TransactionNo,
            tblBorrowTran.DateBorrowed, 20 * (DATEDIFF(day, tblBorrowTran.DateBorrowed + 3, GETDATE())) as overdue,
            TypeOfTransaction = '" & returnOption & "'
            from tblBorrowTran, tblBooks, tblUsers
            where tblBorrowTran.ISBN = tblBooks.ISBN
            and 
            tblBorrowTran.UserID = tblUsers.UserID
            and
            tblBorrowTran.UserID = '" & tranID_txtbx.Text & "'", con)

        rdr = cmd.ExecuteReader
        process_dg.Rows.Clear()

        If rdr.HasRows Then
            Do While rdr.Read
                Dim arr As String() = New String(6) {}
                arr(0) = rdr("Title")
                arr(1) = rdr("ISBN")
                arr(2) = rdr("TransactionNo")
                rTNO = arr(2) + 1
                arr(3) = rdr("DateBorrowed")
                arr(4) = rdr("overdue")
                If arr(4) < 0 Then
                    arr(4) = 0
                    status = "OK"
                Else
                    arr(4) = arr(4)
                    If returnOption = "Paid only" Then
                        status = "Unreturned"
                    Else
                        status = "OK"
                    End If
                End If

                arr(5) = rdr("TypeOfTransaction")

                process_dg.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4), arr(5))


            Loop
        End If
        con.Close()

    End Sub

    Private Sub process_dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles process_dg.CellClick
        varSelectBook = 1
        varIndex = process_dg.CurrentCell.RowIndex
        varISBN = process_dg.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub addSelected_btn_Click(sender As Object, e As EventArgs) Handles addSelected_btn.Click
        If tranID_txtbx.Text = Nothing Then
            MessageBox.Show("Please enter an ID")
        Else
            rID = tranID_txtbx.Text
            processPanel.Visible = True
            processPanel.BringToFront()
            If return_rad.Checked = True Then
                returnOption = "Return only"
            ElseIf pay_rad.Checked = True Then
                returnOption = "Paid only"
            ElseIf payAndreturn_rad.Checked = True Then
                returnOption = "Paid and Returned"
            End If
            listProcess()
        End If




    End Sub

    Private Sub Guna2Button20_Click(sender As Object, e As EventArgs) Handles Guna2Button20.Click
        process_dg.Rows.Clear()
        processPanel.Visible = False
        processPanel.SendToBack()
    End Sub

    Private Sub tranSearch_btn_Click(sender As Object, e As EventArgs) Handles tranSearch_btn.Click
        con.Open()
        cmd = New SqlCommand("Select * From tblBorrowTran where UserID like '%" & tranID_txtbx.Text & "%'", con)
        rdr = cmd.ExecuteReader
        borrow_dg.Rows.Clear()

        If rdr.HasRows Then
            Do While rdr.Read
                Dim arr As String() = New String(5) {}
                arr(0) = rdr("UserID")
                arr(1) = rdr("TransactionNo")
                arr(2) = rdr("DateBorrowed")
                arr(3) = rdr("ISBN")
                arr(4) = rdr("IsBookReturned")
                arr(5) = rdr("Notes")

                borrow_dg.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4), arr(5))
            Loop

        End If
        con.Close()
    End Sub

    Private Sub Guna2Button18_Click(sender As Object, e As EventArgs) Handles Guna2Button18.Click
        If varSelectBook = 1 Then

            process_dg.Rows.RemoveAt(varIndex)
            varSelectBook = 0
        Else
            MessageBox.Show("Select a book", "LibSys", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub Guna2Button19_Click(sender As Object, e As EventArgs) Handles Guna2Button19.Click

        Dim Form6 As New OrderSummary2

        Form6.varMember = rID
        Form6.varID.Text = rID
        Form6.optiontype = returnOption

        Dim DgprocessRows = process_dg.Rows.Count - 1
        Dim X As Integer = 0
        For X = 0 To DgprocessRows

            SQL = ("select IsBookReturned, Notes from tblBorrowTran where UserID = '" & rID.ToString & "' and isbn = '" & process_dg.Rows(X).Cells(1).Value.ToString() & "' ")
            con.Open()
            cmd = New SqlCommand(SQL, con)
            rdr = cmd.ExecuteReader
            If rdr.HasRows Then
                Do While rdr.Read
                    Dim arr As String() = New String(1) {}
                    arr(0) = rdr("IsBookReturned")
                    isreturn = arr(0).ToString
                    arr(1) = rdr("Notes")
                    notes = arr(1).ToString
                Loop
            End If
            con.Close()

            If isreturn = "True" And notes = "Returned" Then
                MessageBox.Show("'" & process_dg.Rows(X).Cells(1).Value.ToString() & "' has already been returned")

            ElseIf isreturn = "True" And notes = "Paid and Returned" Then
                MessageBox.Show("'" & process_dg.Rows(X).Cells(1).Value.ToString() & "' has already been returned")

            Else
                If returnOption = "Return only" Then

                    SQL = ("select InStock as stock, Qty as q from tblBooks where isbn = '" & process_dg.Rows(X).Cells(1).Value.ToString() & "' ")
                    con.Open()
                    cmd = New SqlCommand(SQL, con)
                    rdr = cmd.ExecuteReader

                    If rdr.HasRows Then
                        Do While rdr.Read
                            Dim arr As String() = New String(1) {}
                            arr(0) = rdr("stock")
                            s = arr(0)
                            arr(1) = rdr("q")
                            q = arr(1)

                        Loop
                    End If
                    con.Close()



                    If s = 5 Or s > 5 Then
                        MessageBox.Show("Stock is full.")
                    Else
                        SQL = ("insert into tblReturnTran ([userID], [transactionNo], [DateReturned],[isbn], [BTransactionNo], [overdue], [Status])
                    values ('" & rID.ToString & "','" & rTNO & "',
                    '" & Date.Now & "','" & process_dg.Rows(X).Cells(1).Value.ToString() & "', '" & process_dg.Rows(X).Cells(2).Value.ToString() & "' , '" & process_dg.Rows(X).Cells(4).Value.ToString() & "', '" & status & "')")
                        con.Open()
                        cmd = New SqlCommand(SQL, con)
                        cmd.ExecuteNonQuery()
                        con.Close()

                        SQL = ("update tblBooks set InStock = (InStock + 1) where isbn = '" & process_dg.Rows(X).Cells(1).Value.ToString() & "'")
                        con.Open()
                        cmd = New SqlCommand(SQL, con)
                        cmd.ExecuteNonQuery()
                        con.Close()

                        SQL = ("update tblBorrowTran set IsBookReturned = 'True', Notes = 'Returned' where isbn = '" & process_dg.Rows(X).Cells(1).Value.ToString() & "' 
            and UserID = '" & rID.ToString & "'")

                        con.Open()
                        cmd = New SqlCommand(SQL, con)
                        cmd.ExecuteNonQuery()
                        con.Close()


                        SQL = ("delete from tblReturnTran where Status = 'OK'")
                        con.Open()
                        cmd = New SqlCommand(SQL, con)
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End If
                ElseIf returnOption = "Paid only" Then


                    SQL = ("update tblReturnTran set Overdue = 0 where isbn = '" & process_dg.Rows(X).Cells(1).Value.ToString() & "' and 
            BTransactionNO = '" & process_dg.Rows(X).Cells(2).Value.ToString() & "' and UserID = '" & rID.ToString & "' ")
                    con.Open()
                    cmd = New SqlCommand(SQL, con)
                    cmd.ExecuteNonQuery()
                    con.Close()

                    SQL = ("update tblBorrowTran set Notes = 'Unreturned' where isbn = '" & process_dg.Rows(X).Cells(1).Value.ToString() & "' and 
            TransactionNO = '" & process_dg.Rows(X).Cells(2).Value.ToString() & "' and UserID = '" & rID.ToString & "' ")
                    con.Open()
                    cmd = New SqlCommand(SQL, con)
                    cmd.ExecuteNonQuery()
                    con.Close()


                ElseIf returnOption = "Paid and Returned" Then

                    SQL = ("select InStock as stock, Qty as q from tblBooks where isbn = '" & process_dg.Rows(X).Cells(1).Value.ToString() & "' ")
                    con.Open()
                    cmd = New SqlCommand(SQL, con)
                    rdr = cmd.ExecuteReader

                    If rdr.HasRows Then
                        Do While rdr.Read
                            Dim arr As String() = New String(1) {}
                            arr(0) = rdr("stock")
                            s = arr(0)
                            arr(1) = rdr("q")
                            q = arr(1)

                        Loop
                    End If
                    con.Close()

                    If s = 5 Or s > 5 Then
                        MessageBox.Show("Stock is full.")
                    Else
                        SQL = ("insert into tblReturnTran ([userID], [transactionNo], [DateReturned],[isbn], [BTransactionNo], [overdue], [Status])
                    values ('" & rID.ToString & "','" & rTNO & "',
                    '" & Date.Now & "','" & process_dg.Rows(X).Cells(1).Value.ToString() & "', '" & process_dg.Rows(X).Cells(2).Value.ToString() & "' , '" & process_dg.Rows(X).Cells(4).Value.ToString() & "', '" & status & "')")
                        con.Open()
                        cmd = New SqlCommand(SQL, con)
                        cmd.ExecuteNonQuery()
                        con.Close()

                        SQL = ("update tblBooks set InStock = (InStock + 1) where isbn = '" & process_dg.Rows(X).Cells(1).Value.ToString() & "'")
                        con.Open()
                        cmd = New SqlCommand(SQL, con)
                        cmd.ExecuteNonQuery()
                        con.Close()

                        SQL = ("update tblBorrowTran set IsBookReturned = 'True', Notes = 'Paid and Returned' where isbn = '" & process_dg.Rows(X).Cells(1).Value.ToString() & "' 
            and UserID = '" & rID.ToString & "'")

                        con.Open()
                        cmd = New SqlCommand(SQL, con)
                        cmd.ExecuteNonQuery()
                        con.Close()

                        SQL = ("delete from tblReturnTran where Status = 'OK'")
                        con.Open()
                        cmd = New SqlCommand(SQL, con)
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End If


                End If
            End If
            Form6.print_dg.Rows.Add(process_dg.Rows(X).Cells(0).Value.ToString(), process_dg.Rows(X).Cells(1).Value.ToString(), process_dg.Rows(X).Cells(3).Value.ToString(),
            process_dg.Rows(X).Cells(2).Value.ToString(), process_dg.Rows(X).Cells(5).Value.ToString(), process_dg.Rows(X).Cells(4).Value.ToString())

        Next

        DgprocessRows = DgprocessRows + 1
        MessageBox.Show("You returned " + DgprocessRows.ToString + "Book/s", "LibSys", MessageBoxButtons.OK, MessageBoxIcon.Information)
        processPanel.Hide()
        processPanel.Visible = False
        Me.Hide()

        Form6.Show()

    End Sub
    '=============================     USER MAINTAINANCE ============================================
    Private Sub umClose_btn_Click(sender As Object, e As EventArgs) Handles umClose_btn.Click
        Me.Close()

    End Sub


    Private Sub user_dg_Click(sender As Object, e As EventArgs) Handles user_dg.Click
        umID_txtbx.Text = user_dg.CurrentRow.Cells(0).Value.ToString
        umFname_txtbx.Text = user_dg.CurrentRow.Cells(1).Value.ToString
        umLname_txtbx.Text = user_dg.CurrentRow.Cells(2).Value.ToString
        umAdrs_txtbx.Text = user_dg.CurrentRow.Cells(3).Value.ToString
        umOfcAd_txtbx.Text = user_dg.CurrentRow.Cells(4).Value.ToString
        umLandline_txtbx.Text = user_dg.CurrentRow.Cells(5).Value.ToString
        umMobile_txtbx.Text = user_dg.CurrentRow.Cells(6).Value.ToString
        umEmail_txtbx.Text = user_dg.CurrentRow.Cells(7).Value.ToString
        umGender_txtbx.Text = user_dg.CurrentRow.Cells(8).Value.ToString
        umLink_txtbx.Text = user_dg.CurrentRow.Cells(9).Value.ToString
        umDate_txtbx.Text = user_dg.CurrentRow.Cells(10).Value.ToString
        umValidity_txtbx.Text = user_dg.CurrentRow.Cells(11).Value.ToString
        umRole_txtbx.Text = user_dg.CurrentRow.Cells(12).Value.ToString
        umUname_txtbx.Text = user_dg.CurrentRow.Cells(13).Value.ToString
        umPassword_txtbx.Text = user_dg.CurrentRow.Cells(14).Value.ToString

        umSave_btn.Enabled = True
        umCancel_btn.Enabled = True

        img_view()
    End Sub

    Sub listUser()
        con.Open()
        cmd = New SqlCommand("SELECT * FROM tblUsers", con)
        rdr = cmd.ExecuteReader
        user_dg.Rows.Clear()

        If rdr.HasRows Then
            Do While rdr.Read
                Dim arr As String() = New String(14) {}

                arr(0) = rdr("UserID")
                idno = arr(0) + 1
                arr(1) = rdr("Fname")
                arr(2) = rdr("Lname")
                arr(3) = rdr("ResAdrs")
                arr(4) = rdr("OfcAdrs")
                arr(5) = rdr("LandlineNo")
                arr(6) = rdr("MobileNo")
                arr(7) = rdr("Email")
                arr(8) = rdr("Gender")
                arr(9) = rdr("ImageLink")
                arr(10) = rdr("DateJoined")
                arr(11) = rdr("Validity")
                arr(12) = rdr("Role")
                arr(13) = rdr("Uname")
                arr(14) = rdr("Password1")

                user_dg.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4), arr(5), arr(6), arr(7), arr(8), arr(9), arr(10), arr(11), arr(12), arr(13), arr(14))

            Loop
        End If
        con.Close()
    End Sub

    Private Sub umAdd_rad_CheckedChanged(sender As Object, e As EventArgs) Handles umAdd_rad.CheckedChanged
        umAdd_rad.Enabled = False
        umEdit_rad.Enabled = False
        umDel_rad.Enabled = False
        umClose_btn.Enabled = False
        Dim no As String
        no = idno.ToString
        umID_txtbx.Text = no.ToString
        umFname_txtbx.Clear()
        umLname_txtbx.Clear()
        umAdrs_txtbx.Clear()
        umOfcAd_txtbx.Clear()
        umLandline_txtbx.Clear()
        umMobile_txtbx.Clear()
        umEmail_txtbx.Clear()
        umGender_txtbx.Clear()
        umLink_txtbx.Clear()
        umDate_txtbx.Text = Date.Now
        umValidity_txtbx.Clear()
        umRole_txtbx.Text = " "
        umUname_txtbx.Clear()
        umPassword_txtbx.Clear()
    End Sub

    Private Sub umEdit_rad_CheckedChanged(sender As Object, e As EventArgs) Handles umEdit_rad.CheckedChanged
        umID_txtbx.Enabled = False
        umAdd_rad.Enabled = False
        umEdit_rad.Enabled = False
        umDel_rad.Enabled = False
        umClose_btn.Enabled = False
    End Sub

    Private Sub umDel_rad_CheckedChanged(sender As Object, e As EventArgs) Handles umDel_rad.CheckedChanged
        umID_txtbx.Enabled = False
        umAdd_rad.Enabled = False
        umEdit_rad.Enabled = False
        umDel_rad.Enabled = False
        umClose_btn.Enabled = False
    End Sub

    Private Sub umCancel_btn_Click(sender As Object, e As EventArgs) Handles umCancel_btn.Click
        If umAdd_rad.Checked = True Then
            umAdd_rad.Checked = False
        ElseIf umEdit_rad.Checked = True Then
            umEdit_rad.Checked = False
        ElseIf umDel_rad.Checked = True Then
            umDel_rad.Checked = False
        End If
        umID_txtbx.Enabled = True
        umAdd_rad.Enabled = True
        umEdit_rad.Enabled = True
        umDel_rad.Enabled = True
        If umAdd_rad.Checked = True Then
            umAdd_rad.Checked = False
        ElseIf umEdit_rad.Checked = True Then
            umEdit_rad.Checked = False
        ElseIf umDel_rad.Checked = True Then
            umDel_rad.Checked = False
        End If


        umClose_btn.Enabled = True
    End Sub

    Private Sub umSave_btn_Click(sender As Object, e As EventArgs) Handles umSave_btn.Click
        If umAdd_rad.Checked = True Then

            Dim im As String
            If umLink_txtbx.Text = Nothing Then
                im = "NULL"
            Else
                im = umLink_txtbx.Text
            End If


            idno = umID_txtbx.Text
            con.Open()
            SQL = ("insert into tblUsers ([UserID],[Fname],[Lname],[ResAdrs],[OfcAdrs],[LandlineNo],[MobileNo],[Email],[Gender],[ImageLink],[DateJoined],[Validity],[Role],[Uname],[Password1])
        values ('" & idno & "','" & umFname_txtbx.Text & "',
                    '" & umLast_btn.Text & "','" & umAdrs_txtbx.Text & "', '" & umOfcAd_txtbx.Text & "' , '" & umLandline_txtbx.Text & "', '" & umMobile_txtbx.Text & "',
        '" & umEmail_txtbx.Text & "', '" & umGender_txtbx.Text & "', '" & im & "', '" & Date.Now & "', '" & umValidity_txtbx.Text & "', '" & umRole_txtbx.Text & "', '" & umUname_txtbx.Text & "', '" & umPassword_txtbx.Text & "')")

            cmd = New SqlCommand(SQL, con)
            cmd.ExecuteNonQuery()
            con.Close()


            MessageBox.Show("Record Added ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            listUser()

            umAdd_rad.Checked = False

        ElseIf umEdit_rad.Checked = True Then



            con.Open()
            SQL = ("UPDATE tblUsers set Fname = '" & umFname_txtbx.Text & "', Lname = '" & umLast_btn.Text & "', ResAdrs = '" & umAdrs_txtbx.Text & "',
        OfcAdrs = '" & umOfcAd_txtbx.Text & "',  LandlineNo = '" & umLandline_txtbx.Text & "', MobileNo = '" & umMobile_txtbx.Text & "',
        Email = '" & umEmail_txtbx.Text & "', Gender = '" & umGender_txtbx.Text & "', ImageLink = '" & umLink_txtbx.Text & "', DateJoined = '" & umDate_txtbx.Text & "',
        Validity = '" & umValidity_txtbx.Text & "', Role = '" & umRole_txtbx.Text & "', Uname = '" & umUname_txtbx.Text & "', Password1 = '" & umPassword_txtbx.Text & "'
        where UserID = '" & umID_txtbx.Text & "'")


            cmd = New SqlCommand(SQL, con)
            cmd.ExecuteNonQuery()
            con.Close()



            MessageBox.Show("Record Edited ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            listUser()
            umEdit_rad.Checked = False


        ElseIf umDel_rad.Checked = True Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete?", "", MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning)

            If result = DialogResult.No Then
                umDel_rad.Checked = False
            ElseIf result = DialogResult.Yes Then
                con.Open()
                SQL = ("delete from tblUsers where UserID = '" & umID_txtbx.Text & "'")


                cmd = New SqlCommand(SQL, con)
                cmd.ExecuteNonQuery()
                con.Close()

                listUser()

                MessageBox.Show("Record Deleted ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                umID_txtbx.Clear()
                umFname_txtbx.Clear()
                umLname_txtbx.Clear()
                umAdrs_txtbx.Clear()
                umOfcAd_txtbx.Clear()
                umLandline_txtbx.Clear()
                umMobile_txtbx.Clear()
                umEmail_txtbx.Clear()
                umGender_txtbx.Clear()
                umLink_txtbx.Clear()
                umDate_txtbx.Text = Date.Now
                umValidity_txtbx.Clear()
                umRole_txtbx.Text = " "
                umUname_txtbx.Clear()
                umPassword_txtbx.Clear()
                umID_txtbx.Enabled = True

                umDel_rad.Checked = False

            End If



        End If
        umAdd_rad.Enabled = True
        umEdit_rad.Enabled = True
        umDel_rad.Enabled = True



        umClose_btn.Enabled = True
        umDate_txtbx.Clear()
        umSave_btn.Enabled = False
        umCancel_btn.Enabled = False
        umID_txtbx.Enabled = True
        listUser()
    End Sub

    Private Sub browse_btn_Click(sender As Object, e As EventArgs) Handles browse_btn.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            umLink_txtbx.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub umFirst_btn_Click(sender As Object, e As EventArgs) Handles umFirst_btn.Click
        index1 = 0
        user_view()
        img_view()
    End Sub

    Private Sub umPrev_btn_Click(sender As Object, e As EventArgs) Handles umPrev_btn.Click
        If index1 = 0 Then
            MessageBox.Show("First Record")
        Else
            index1 = index1 - 1
            user_view()
        End If
        img_view()
    End Sub

    Private Sub umNext_btn_Click(sender As Object, e As EventArgs) Handles umNext_btn.Click
        If index1 = user_dg.Rows.Count() - 1 Then
            MessageBox.Show("Last Record")
        Else
            index1 = index1 + 1

            user_view()
        End If
        img_view()
    End Sub

    Private Sub umLast_btn_Click(sender As Object, e As EventArgs) Handles umLast_btn.Click
        index1 = user_dg.Rows.Count() - 1
        user_view()
        img_view()
    End Sub

    Sub img_view()

        con.Open()
        SQL = ("select ImageLink from tblUsers where UserID =  '" & umID_txtbx.Text & "'")

        cmd = New SqlCommand(SQL, con)
        Dim img As String = cmd.ExecuteScalar()
        Dim paths As String = Path.Combine(img)

        If umLink_txtbx.Text = "NULL" Then
            user_picbx.Image = Nothing
        Else
            user_picbx.Image = Image.FromFile(paths)
        End If


        con.Close()
    End Sub

    Sub user_view()

        Dim selectedRow1 As DataGridViewRow
        selectedRow1 = user_dg.Rows(index1)
        umID_txtbx.Text = selectedRow1.Cells(0).Value.ToString
        umFname_txtbx.Text = selectedRow1.Cells(1).Value.ToString
        umLname_txtbx.Text = selectedRow1.Cells(2).Value.ToString
        umAdrs_txtbx.Text = selectedRow1.Cells(3).Value.ToString
        umOfcAd_txtbx.Text = selectedRow1.Cells(4).Value.ToString
        umLandline_txtbx.Text = selectedRow1.Cells(5).Value.ToString
        umMobile_txtbx.Text = selectedRow1.Cells(6).Value.ToString
        umEmail_txtbx.Text = selectedRow1.Cells(7).Value.ToString
        umGender_txtbx.Text = selectedRow1.Cells(8).Value.ToString
        umLink_txtbx.Text = selectedRow1.Cells(9).Value.ToString
        umDate_txtbx.Text = selectedRow1.Cells(10).Value.ToString
        umValidity_txtbx.Text = selectedRow1.Cells(11).Value.ToString
        umRole_txtbx.SelectedItem = selectedRow1.Cells(12).Value.ToString
        umUname_txtbx.Text = selectedRow1.Cells(13).Value.ToString
        umPassword_txtbx.Text = selectedRow1.Cells(14).Value.ToString
    End Sub

    Sub listCollection()
        con.Open()
        cmd = New SqlCommand("SELECT * FROM tblBooks", con)
        rdr = cmd.ExecuteReader
        collection_dg.Rows.Clear()

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

                collection_dg.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4), arr(5), arr(6), arr(7), arr(8), arr(9), arr(10))

            Loop
        End If
        con.Close()
    End Sub

    Private Sub bmSave_btn_Click(sender As Object, e As EventArgs) Handles bmSave_btn.Click
        If bmAdd_rad.Checked = True Then
            con.Open()
            SQL = ("insert into tblBooks ([isbn],[Title],[Author],[Abstract],[Description],[Publisher],[CopyRightYear],[category],[unitprice],[qty],[instock])
        values ('" & bmisbn_txtbx.Text & "','" & bmtitles_txtbx.Text & "',                                                                                
                    '" & bmauthors_txtbx.Text & "','" & bmabs_txtbx.Text & "', '" & bmdescription_txtbx.Text & "' , '" & bmpublisher_txtbx.Text & "', '" & bmyear_txtbx.Text & "',
        '" & bmcategory_txtbx.Text & "', '" & bmunitprice_txtbx.Text & "', '" & bmqty_txtbx.Text & "', '" & bmstock_txtbx.Text & "')")

            cmd = New SqlCommand(SQL, con)
            cmd.ExecuteNonQuery()
            con.Close()


            MessageBox.Show("Record Added ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            listCollection()
            bmAdd_rad.Checked = False

        ElseIf bmEdit_rad.Checked = True Then


            bmisbn_txtbx.Enabled = False
            con.Open()
            SQL = ("update tblBooks set Title = '" & bmtitles_txtbx.Text & "', Author = '" & bmauthors_txtbx.Text & "', abstract = '" & bmabs_txtbx.Text & "',
        description = '" & bmdescription_txtbx.Text & "',  publisher = '" & bmpublisher_txtbx.Text & "', CopyRightYear = '" & bmyear_txtbx.Text & "',
        category = '" & bmcategory_txtbx.Text & "', UnitPrice = '" & bmunitprice_txtbx.Text & "', Qty = '" & bmqty_txtbx.Text & "', InStock = '" & bmstock_txtbx.Text & "'
        where isbn = '" & bmisbn_txtbx.Text & "' ")


            cmd = New SqlCommand(SQL, con)
            cmd.ExecuteNonQuery()
            con.Close()

            listCollection()

            MessageBox.Show("Record Edited ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            bmEdit_rad.Checked = False
            bmisbn_txtbx.Enabled = True


        ElseIf bmDel_rad.Checked = True Then



            '=====
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete?", "", MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning)

            If result = DialogResult.No Then
                bmDel_rad.Checked = False
            ElseIf result = DialogResult.Yes Then
                con.Open()
                SQL = ("delete from tblBooks where isbn = '" & bmisbn_txtbx.Text & "'")


                cmd = New SqlCommand(SQL, con)
                cmd.ExecuteNonQuery()
                con.Close()

                listCollection()

                MessageBox.Show("Record Deleted ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                bmisbn_txtbx.Clear()
                bmtitles_txtbx.Clear()
                bmauthors_txtbx.Clear()
                bmauthors_txtbx.Clear()
                bmdescription_txtbx.Clear()
                bmpublisher_txtbx.Clear()
                bmyear_txtbx.Clear()
                bmcategory_txtbx.Clear()
                bmunitprice_txtbx.Clear()
                bmqty_txtbx.Clear()
                bmstock_txtbx.Clear()

                bmDel_rad.Checked = False


            End If

        End If
        bmAdd_rad.Enabled = True
        bmEdit_rad.Enabled = True
        bmDel_rad.Enabled = True

        bmClose_btn.Enabled = True
        bmSave_btn.Enabled = False
        bmCancel_btn.Enabled = False
        bmisbn_txtbx.Enabled = True
        listCollection()

    End Sub

    Private Sub collection_dg_Click(sender As Object, e As EventArgs) Handles collection_dg.Click
        bmisbn_txtbx.Text = collection_dg.CurrentRow.Cells(0).Value.ToString
        bmtitles_txtbx.Text = collection_dg.CurrentRow.Cells(1).Value.ToString
        bmauthors_txtbx.Text = collection_dg.CurrentRow.Cells(2).Value.ToString
        bmabs_txtbx.Text = collection_dg.CurrentRow.Cells(3).Value.ToString
        bmdescription_txtbx.Text = collection_dg.CurrentRow.Cells(4).Value.ToString
        bmpublisher_txtbx.Text = collection_dg.CurrentRow.Cells(5).Value.ToString
        bmyear_txtbx.Text = collection_dg.CurrentRow.Cells(6).Value.ToString
        bmcategory_txtbx.Text = collection_dg.CurrentRow.Cells(7).Value.ToString
        bmunitprice_txtbx.Text = collection_dg.CurrentRow.Cells(8).Value.ToString
        bmqty_txtbx.Text = collection_dg.CurrentRow.Cells(9).Value.ToString
        bmstock_txtbx.Text = collection_dg.CurrentRow.Cells(10).Value.ToString
        bmSave_btn.Enabled = True
        bmCancel_btn.Enabled = True


    End Sub

    Private Sub bmCancel_btn_Click(sender As Object, e As EventArgs) Handles bmCancel_btn.Click
        If bmAdd_rad.Checked = True Then
            bmAdd_rad.Checked = False
        ElseIf bmEdit_rad.Checked = True Then
            bmEdit_rad.Checked = False
        ElseIf bmDel_rad.Checked = True Then
            bmDel_rad.Checked = False
        End If

        bmisbn_txtbx.Enabled = True
        bmAdd_rad.Enabled = True
        bmEdit_rad.Enabled = True
        bmDel_rad.Enabled = True

        bmClose_btn.Enabled = True
    End Sub

    Private Sub bmAdd_rad_CheckedChanged(sender As Object, e As EventArgs) Handles bmAdd_rad.CheckedChanged
        bmAdd_rad.Enabled = False
        bmEdit_rad.Enabled = False
        bmDel_rad.Enabled = False
        bmClose_btn.Enabled = False
        bmisbn_txtbx.Enabled = True


        bmisbn_txtbx.Clear()
        bmtitles_txtbx.Clear()
        bmauthors_txtbx.Clear()
        bmabs_txtbx.Clear()
        bmdescription_txtbx.Clear()
        bmpublisher_txtbx.Clear()
        bmyear_txtbx.Clear()
        bmcategory_txtbx.Clear()
        bmunitprice_txtbx.Clear()
        bmqty_txtbx.Clear()
        bmstock_txtbx.Clear()
    End Sub

    Private Sub bmEdit_rad_CheckedChanged(sender As Object, e As EventArgs) Handles bmEdit_rad.CheckedChanged
        bmisbn_txtbx.Enabled = False
        bmAdd_rad.Enabled = False
        bmEdit_rad.Enabled = False
        bmDel_rad.Enabled = False
        bmClose_btn.Enabled = False
    End Sub

    Private Sub bmClose_btn_Click(sender As Object, e As EventArgs) Handles bmClose_btn.Click
        Me.Close()

    End Sub

    Private Sub bmDel_rad_CheckedChanged(sender As Object, e As EventArgs) Handles bmDel_rad.CheckedChanged
        bmisbn_txtbx.Enabled = False
        bmAdd_rad.Enabled = False
        bmEdit_rad.Enabled = False
        bmDel_rad.Enabled = False
    End Sub

    Private Sub gmFirst_Click(sender As Object, e As EventArgs) Handles gmFirst.Click
        index1 = 0
        collection_view()
    End Sub

    Private Sub Guna2GroupBox3_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox3.Click

    End Sub

    Private Sub borrowPanel_Paint(sender As Object, e As PaintEventArgs) Handles borrowPanel.Paint

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint
        navigate(index1)
    End Sub

    Private Sub bmPrev_Click(sender As Object, e As EventArgs) Handles bmPrev.Click
        If index1 = 0 Then
            MessageBox.Show("First Record")
        Else
            index1 = index1 - 1
            collection_view()
        End If
    End Sub

    Private Sub bmNext_Click(sender As Object, e As EventArgs) Handles bmNext.Click
        If lastindex1 = index1 Then
            MessageBox.Show("Last Record")
        Else
            index1 = index1 + 1

            collection_view()
        End If
    End Sub

    Private Sub bmLast_Click(sender As Object, e As EventArgs) Handles bmLast.Click
        index1 = collection_dg.Rows.Count() - 1
        collection_view()
    End Sub


    Sub collection_view()
        Dim selectedRow As DataGridViewRow
        selectedRow = collection_dg.Rows(index1)
        bmisbn_txtbx.Text = selectedRow.Cells(0).Value.ToString
        bmtitles_txtbx.Text = selectedRow.Cells(1).Value.ToString
        bmauthors_txtbx.Text = selectedRow.Cells(2).Value.ToString
        bmabs_txtbx.Text = selectedRow.Cells(3).Value.ToString
        bmdescription_txtbx.Text = selectedRow.Cells(4).Value.ToString
        bmpublisher_txtbx.Text = selectedRow.Cells(5).Value.ToString
        bmyear_txtbx.Text = selectedRow.Cells(6).Value.ToString
        bmcategory_txtbx.Text = selectedRow.Cells(7).Value.ToString
        bmunitprice_txtbx.Text = selectedRow.Cells(8).Value.ToString
        bmqty_txtbx.Text = selectedRow.Cells(9).Value.ToString
        bmstock_txtbx.Text = selectedRow.Cells(10).Value.ToString
    End Sub

End Class

'================ READ ME======================
'to run the program, try downloading guna ui from the NuGet