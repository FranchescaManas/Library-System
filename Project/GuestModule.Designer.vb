<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GuestModule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GuestModule))
        Me.mainPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.listData = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2GroupBox4 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.search_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.category_combo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.searchISBN_txtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.searchAuthor_txtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.searchTitle_txtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.prev_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.next_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.first_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.last_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.cart_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.abstract_txtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.author_txtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.title_txtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.isbn_lbl = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.avail_lbl = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.menu_btn = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblUserId = New System.Windows.Forms.Label()
        Me.searchAndreserve_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.transaction_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.login_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainPanel.SuspendLayout()
        CType(Me.listData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox4.SuspendLayout()
        Me.Guna2GroupBox3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainPanel
        '
        Me.mainPanel.BackColor = System.Drawing.Color.Transparent
        Me.mainPanel.Controls.Add(Me.listData)
        Me.mainPanel.Controls.Add(Me.Guna2GroupBox4)
        Me.mainPanel.Controls.Add(Me.Guna2GroupBox3)
        Me.Guna2Transition1.SetDecoration(Me.mainPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.ShadowDecoration.Parent = Me.mainPanel
        Me.mainPanel.Size = New System.Drawing.Size(1226, 624)
        Me.mainPanel.TabIndex = 1
        '
        'listData
        '
        Me.listData.AllowUserToAddRows = False
        Me.listData.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.listData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.listData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.listData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.listData.BackgroundColor = System.Drawing.Color.White
        Me.listData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.listData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.listData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.listData.ColumnHeadersHeight = 40
        Me.listData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column8, Me.Column9, Me.Column10, Me.Column7, Me.Column11})
        Me.Guna2Transition1.SetDecoration(Me.listData, Guna.UI2.AnimatorNS.DecorationType.None)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(226, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(160, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.listData.DefaultCellStyle = DataGridViewCellStyle3
        Me.listData.EnableHeadersVisualStyles = False
        Me.listData.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.listData.Location = New System.Drawing.Point(151, 421)
        Me.listData.Name = "listData"
        Me.listData.ReadOnly = True
        Me.listData.RowHeadersVisible = False
        Me.listData.RowHeadersWidth = 80
        Me.listData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.listData.Size = New System.Drawing.Size(963, 158)
        Me.listData.TabIndex = 2
        Me.listData.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Emerald
        Me.listData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.listData.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.listData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.listData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.listData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.listData.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.listData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.listData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.listData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.listData.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.listData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.listData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.listData.ThemeStyle.HeaderStyle.Height = 40
        Me.listData.ThemeStyle.ReadOnly = True
        Me.listData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.listData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.listData.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.listData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.listData.ThemeStyle.RowsStyle.Height = 22
        Me.listData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.listData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Guna2GroupBox4
        '
        Me.Guna2GroupBox4.Controls.Add(Me.search_btn)
        Me.Guna2GroupBox4.Controls.Add(Me.category_combo)
        Me.Guna2GroupBox4.Controls.Add(Me.searchISBN_txtbx)
        Me.Guna2GroupBox4.Controls.Add(Me.searchAuthor_txtbx)
        Me.Guna2GroupBox4.Controls.Add(Me.searchTitle_txtbx)
        Me.Guna2GroupBox4.Controls.Add(Me.Label19)
        Me.Guna2GroupBox4.Controls.Add(Me.Label18)
        Me.Guna2GroupBox4.Controls.Add(Me.Label17)
        Me.Guna2GroupBox4.Controls.Add(Me.Title)
        Me.Guna2GroupBox4.CustomBorderColor = System.Drawing.SystemColors.ScrollBar
        Me.Guna2GroupBox4.CustomBorderThickness = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.Guna2Transition1.SetDecoration(Me.Guna2GroupBox4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox4.Location = New System.Drawing.Point(801, 88)
        Me.Guna2GroupBox4.Name = "Guna2GroupBox4"
        Me.Guna2GroupBox4.ShadowDecoration.Parent = Me.Guna2GroupBox4
        Me.Guna2GroupBox4.Size = New System.Drawing.Size(313, 292)
        Me.Guna2GroupBox4.TabIndex = 1
        Me.Guna2GroupBox4.Text = "Filter"
        Me.Guna2GroupBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'search_btn
        '
        Me.search_btn.AutoRoundedCorners = True
        Me.search_btn.BackColor = System.Drawing.Color.Transparent
        Me.search_btn.BorderRadius = 12
        Me.search_btn.CheckedState.Parent = Me.search_btn
        Me.search_btn.CustomImages.Parent = Me.search_btn
        Me.Guna2Transition1.SetDecoration(Me.search_btn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.search_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.search_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.search_btn.ForeColor = System.Drawing.Color.White
        Me.search_btn.HoverState.Parent = Me.search_btn
        Me.search_btn.Location = New System.Drawing.Point(184, 252)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.ShadowDecoration.Parent = Me.search_btn
        Me.search_btn.Size = New System.Drawing.Size(98, 27)
        Me.search_btn.TabIndex = 10
        Me.search_btn.Text = "Search"
        '
        'category_combo
        '
        Me.category_combo.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.category_combo, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.category_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.category_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.category_combo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.category_combo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.category_combo.FocusedState.Parent = Me.category_combo
        Me.category_combo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.category_combo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.category_combo.HoverState.Parent = Me.category_combo
        Me.category_combo.ItemHeight = 18
        Me.category_combo.ItemsAppearance.Parent = Me.category_combo
        Me.category_combo.Location = New System.Drawing.Point(35, 66)
        Me.category_combo.Name = "category_combo"
        Me.category_combo.ShadowDecoration.Parent = Me.category_combo
        Me.category_combo.Size = New System.Drawing.Size(238, 24)
        Me.category_combo.TabIndex = 12
        '
        'searchISBN_txtbx
        '
        Me.searchISBN_txtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.searchISBN_txtbx, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.searchISBN_txtbx.DefaultText = ""
        Me.searchISBN_txtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.searchISBN_txtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.searchISBN_txtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchISBN_txtbx.DisabledState.Parent = Me.searchISBN_txtbx
        Me.searchISBN_txtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchISBN_txtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchISBN_txtbx.FocusedState.Parent = Me.searchISBN_txtbx
        Me.searchISBN_txtbx.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.searchISBN_txtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchISBN_txtbx.HoverState.Parent = Me.searchISBN_txtbx
        Me.searchISBN_txtbx.Location = New System.Drawing.Point(35, 217)
        Me.searchISBN_txtbx.Name = "searchISBN_txtbx"
        Me.searchISBN_txtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchISBN_txtbx.PlaceholderText = ""
        Me.searchISBN_txtbx.SelectedText = ""
        Me.searchISBN_txtbx.ShadowDecoration.Parent = Me.searchISBN_txtbx
        Me.searchISBN_txtbx.Size = New System.Drawing.Size(247, 24)
        Me.searchISBN_txtbx.TabIndex = 11
        '
        'searchAuthor_txtbx
        '
        Me.searchAuthor_txtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.searchAuthor_txtbx, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.searchAuthor_txtbx.DefaultText = ""
        Me.searchAuthor_txtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.searchAuthor_txtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.searchAuthor_txtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchAuthor_txtbx.DisabledState.Parent = Me.searchAuthor_txtbx
        Me.searchAuthor_txtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchAuthor_txtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchAuthor_txtbx.FocusedState.Parent = Me.searchAuthor_txtbx
        Me.searchAuthor_txtbx.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.searchAuthor_txtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchAuthor_txtbx.HoverState.Parent = Me.searchAuthor_txtbx
        Me.searchAuthor_txtbx.Location = New System.Drawing.Point(35, 165)
        Me.searchAuthor_txtbx.Name = "searchAuthor_txtbx"
        Me.searchAuthor_txtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchAuthor_txtbx.PlaceholderText = ""
        Me.searchAuthor_txtbx.SelectedText = ""
        Me.searchAuthor_txtbx.ShadowDecoration.Parent = Me.searchAuthor_txtbx
        Me.searchAuthor_txtbx.Size = New System.Drawing.Size(238, 24)
        Me.searchAuthor_txtbx.TabIndex = 10
        '
        'searchTitle_txtbx
        '
        Me.searchTitle_txtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.searchTitle_txtbx, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.searchTitle_txtbx.DefaultText = ""
        Me.searchTitle_txtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.searchTitle_txtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.searchTitle_txtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchTitle_txtbx.DisabledState.Parent = Me.searchTitle_txtbx
        Me.searchTitle_txtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchTitle_txtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchTitle_txtbx.FocusedState.Parent = Me.searchTitle_txtbx
        Me.searchTitle_txtbx.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.searchTitle_txtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchTitle_txtbx.HoverState.Parent = Me.searchTitle_txtbx
        Me.searchTitle_txtbx.Location = New System.Drawing.Point(35, 116)
        Me.searchTitle_txtbx.Name = "searchTitle_txtbx"
        Me.searchTitle_txtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchTitle_txtbx.PlaceholderText = ""
        Me.searchTitle_txtbx.SelectedText = ""
        Me.searchTitle_txtbx.ShadowDecoration.Parent = Me.searchTitle_txtbx
        Me.searchTitle_txtbx.Size = New System.Drawing.Size(238, 24)
        Me.searchTitle_txtbx.TabIndex = 9
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Guna2Transition1.SetDecoration(Me.Label19, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label19.Location = New System.Drawing.Point(32, 198)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 15)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "ISBN"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Guna2Transition1.SetDecoration(Me.Label18, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label18.Location = New System.Drawing.Point(32, 148)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 15)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Author"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Guna2Transition1.SetDecoration(Me.Label17, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label17.Location = New System.Drawing.Point(32, 98)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(29, 15)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Title"
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.White
        Me.Guna2Transition1.SetDecoration(Me.Title, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Title.Location = New System.Drawing.Point(32, 46)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(55, 15)
        Me.Title.TabIndex = 6
        Me.Title.Text = "Category"
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.Controls.Add(Me.prev_btn)
        Me.Guna2GroupBox3.Controls.Add(Me.next_btn)
        Me.Guna2GroupBox3.Controls.Add(Me.first_btn)
        Me.Guna2GroupBox3.Controls.Add(Me.last_btn)
        Me.Guna2GroupBox3.Controls.Add(Me.cart_btn)
        Me.Guna2GroupBox3.Controls.Add(Me.abstract_txtbx)
        Me.Guna2GroupBox3.Controls.Add(Me.author_txtbx)
        Me.Guna2GroupBox3.Controls.Add(Me.title_txtbx)
        Me.Guna2GroupBox3.Controls.Add(Me.isbn_lbl)
        Me.Guna2GroupBox3.Controls.Add(Me.Label14)
        Me.Guna2GroupBox3.Controls.Add(Me.avail_lbl)
        Me.Guna2GroupBox3.Controls.Add(Me.Label11)
        Me.Guna2GroupBox3.Controls.Add(Me.Label10)
        Me.Guna2GroupBox3.Controls.Add(Me.Label9)
        Me.Guna2GroupBox3.CustomBorderColor = System.Drawing.SystemColors.ScrollBar
        Me.Guna2GroupBox3.CustomBorderThickness = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.Guna2Transition1.SetDecoration(Me.Guna2GroupBox3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(151, 88)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.ShadowDecoration.Parent = Me.Guna2GroupBox3
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(606, 292)
        Me.Guna2GroupBox3.TabIndex = 0
        Me.Guna2GroupBox3.Text = "Book Information"
        Me.Guna2GroupBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'prev_btn
        '
        Me.prev_btn.AutoRoundedCorners = True
        Me.prev_btn.BackColor = System.Drawing.Color.Transparent
        Me.prev_btn.BorderRadius = 12
        Me.prev_btn.CheckedState.Parent = Me.prev_btn
        Me.prev_btn.CustomImages.Parent = Me.prev_btn
        Me.Guna2Transition1.SetDecoration(Me.prev_btn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.prev_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.prev_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.prev_btn.ForeColor = System.Drawing.Color.White
        Me.prev_btn.HoverState.Parent = Me.prev_btn
        Me.prev_btn.Location = New System.Drawing.Point(305, 252)
        Me.prev_btn.Name = "prev_btn"
        Me.prev_btn.ShadowDecoration.Parent = Me.prev_btn
        Me.prev_btn.Size = New System.Drawing.Size(36, 27)
        Me.prev_btn.TabIndex = 13
        Me.prev_btn.Text = "<"
        '
        'next_btn
        '
        Me.next_btn.AutoRoundedCorners = True
        Me.next_btn.BackColor = System.Drawing.Color.Transparent
        Me.next_btn.BorderRadius = 12
        Me.next_btn.CheckedState.Parent = Me.next_btn
        Me.next_btn.CustomImages.Parent = Me.next_btn
        Me.Guna2Transition1.SetDecoration(Me.next_btn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.next_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.next_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.next_btn.ForeColor = System.Drawing.Color.White
        Me.next_btn.HoverState.Parent = Me.next_btn
        Me.next_btn.Location = New System.Drawing.Point(342, 252)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.ShadowDecoration.Parent = Me.next_btn
        Me.next_btn.Size = New System.Drawing.Size(36, 27)
        Me.next_btn.TabIndex = 12
        Me.next_btn.Text = ">"
        '
        'first_btn
        '
        Me.first_btn.AutoRoundedCorners = True
        Me.first_btn.BackColor = System.Drawing.Color.Transparent
        Me.first_btn.BorderRadius = 12
        Me.first_btn.CheckedState.Parent = Me.first_btn
        Me.first_btn.CustomImages.Parent = Me.first_btn
        Me.Guna2Transition1.SetDecoration(Me.first_btn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.first_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.first_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.first_btn.ForeColor = System.Drawing.Color.White
        Me.first_btn.HoverState.Parent = Me.first_btn
        Me.first_btn.Location = New System.Drawing.Point(250, 252)
        Me.first_btn.Name = "first_btn"
        Me.first_btn.ShadowDecoration.Parent = Me.first_btn
        Me.first_btn.Size = New System.Drawing.Size(54, 27)
        Me.first_btn.TabIndex = 11
        Me.first_btn.Text = "<<"
        '
        'last_btn
        '
        Me.last_btn.AutoRoundedCorners = True
        Me.last_btn.BackColor = System.Drawing.Color.Transparent
        Me.last_btn.BorderRadius = 12
        Me.last_btn.CheckedState.Parent = Me.last_btn
        Me.last_btn.CustomImages.Parent = Me.last_btn
        Me.Guna2Transition1.SetDecoration(Me.last_btn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.last_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.last_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.last_btn.ForeColor = System.Drawing.Color.White
        Me.last_btn.HoverState.Parent = Me.last_btn
        Me.last_btn.Location = New System.Drawing.Point(379, 252)
        Me.last_btn.Name = "last_btn"
        Me.last_btn.ShadowDecoration.Parent = Me.last_btn
        Me.last_btn.Size = New System.Drawing.Size(54, 27)
        Me.last_btn.TabIndex = 10
        Me.last_btn.Text = ">>"
        '
        'cart_btn
        '
        Me.cart_btn.AutoRoundedCorners = True
        Me.cart_btn.BackColor = System.Drawing.Color.Transparent
        Me.cart_btn.BorderRadius = 12
        Me.cart_btn.CheckedState.Parent = Me.cart_btn
        Me.cart_btn.CustomImages.Parent = Me.cart_btn
        Me.Guna2Transition1.SetDecoration(Me.cart_btn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.cart_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cart_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cart_btn.ForeColor = System.Drawing.Color.White
        Me.cart_btn.HoverState.Parent = Me.cart_btn
        Me.cart_btn.Location = New System.Drawing.Point(475, 252)
        Me.cart_btn.Name = "cart_btn"
        Me.cart_btn.ShadowDecoration.Parent = Me.cart_btn
        Me.cart_btn.Size = New System.Drawing.Size(98, 27)
        Me.cart_btn.TabIndex = 9
        Me.cart_btn.Text = "Add to Cart"
        '
        'abstract_txtbx
        '
        Me.abstract_txtbx.AutoScroll = True
        Me.abstract_txtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.abstract_txtbx, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.abstract_txtbx.DefaultText = ""
        Me.abstract_txtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.abstract_txtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.abstract_txtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.abstract_txtbx.DisabledState.Parent = Me.abstract_txtbx
        Me.abstract_txtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.abstract_txtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.abstract_txtbx.FocusedState.Parent = Me.abstract_txtbx
        Me.abstract_txtbx.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.abstract_txtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.abstract_txtbx.HoverState.Parent = Me.abstract_txtbx
        Me.abstract_txtbx.Location = New System.Drawing.Point(26, 140)
        Me.abstract_txtbx.Multiline = True
        Me.abstract_txtbx.Name = "abstract_txtbx"
        Me.abstract_txtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.abstract_txtbx.PlaceholderText = ""
        Me.abstract_txtbx.SelectedText = ""
        Me.abstract_txtbx.ShadowDecoration.Parent = Me.abstract_txtbx
        Me.abstract_txtbx.Size = New System.Drawing.Size(547, 88)
        Me.abstract_txtbx.TabIndex = 8
        '
        'author_txtbx
        '
        Me.author_txtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.author_txtbx, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.author_txtbx.DefaultText = ""
        Me.author_txtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.author_txtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.author_txtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.author_txtbx.DisabledState.Parent = Me.author_txtbx
        Me.author_txtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.author_txtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.author_txtbx.FocusedState.Parent = Me.author_txtbx
        Me.author_txtbx.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.author_txtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.author_txtbx.HoverState.Parent = Me.author_txtbx
        Me.author_txtbx.Location = New System.Drawing.Point(324, 76)
        Me.author_txtbx.Name = "author_txtbx"
        Me.author_txtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.author_txtbx.PlaceholderText = ""
        Me.author_txtbx.SelectedText = ""
        Me.author_txtbx.ShadowDecoration.Parent = Me.author_txtbx
        Me.author_txtbx.Size = New System.Drawing.Size(249, 24)
        Me.author_txtbx.TabIndex = 7
        '
        'title_txtbx
        '
        Me.title_txtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.title_txtbx, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.title_txtbx.DefaultText = ""
        Me.title_txtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.title_txtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.title_txtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.title_txtbx.DisabledState.Parent = Me.title_txtbx
        Me.title_txtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.title_txtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.title_txtbx.FocusedState.Parent = Me.title_txtbx
        Me.title_txtbx.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.title_txtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.title_txtbx.HoverState.Parent = Me.title_txtbx
        Me.title_txtbx.Location = New System.Drawing.Point(26, 76)
        Me.title_txtbx.Name = "title_txtbx"
        Me.title_txtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.title_txtbx.PlaceholderText = ""
        Me.title_txtbx.SelectedText = ""
        Me.title_txtbx.ShadowDecoration.Parent = Me.title_txtbx
        Me.title_txtbx.Size = New System.Drawing.Size(278, 24)
        Me.title_txtbx.TabIndex = 6
        '
        'isbn_lbl
        '
        Me.isbn_lbl.AutoSize = True
        Me.isbn_lbl.BackColor = System.Drawing.Color.White
        Me.Guna2Transition1.SetDecoration(Me.isbn_lbl, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.isbn_lbl.Location = New System.Drawing.Point(166, 252)
        Me.isbn_lbl.Name = "isbn_lbl"
        Me.isbn_lbl.Size = New System.Drawing.Size(13, 15)
        Me.isbn_lbl.TabIndex = 5
        Me.isbn_lbl.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Guna2Transition1.SetDecoration(Me.Label14, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label14.Location = New System.Drawing.Point(111, 252)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 15)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "ISBN"
        '
        'avail_lbl
        '
        Me.avail_lbl.AutoSize = True
        Me.avail_lbl.BackColor = System.Drawing.Color.White
        Me.Guna2Transition1.SetDecoration(Me.avail_lbl, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.avail_lbl.Location = New System.Drawing.Point(27, 252)
        Me.avail_lbl.Name = "avail_lbl"
        Me.avail_lbl.Size = New System.Drawing.Size(65, 15)
        Me.avail_lbl.TabIndex = 3
        Me.avail_lbl.Text = "Availability"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Guna2Transition1.SetDecoration(Me.Label11, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label11.Location = New System.Drawing.Point(23, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 15)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Abstract"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Guna2Transition1.SetDecoration(Me.Label10, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label10.Location = New System.Drawing.Point(321, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Author"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Guna2Transition1.SetDecoration(Me.Label9, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label9.Location = New System.Drawing.Point(22, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Title"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Controls.Add(Me.menu_btn)
        Me.Guna2Transition1.SetDecoration(Me.Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(1226, 39)
        Me.Guna2Panel2.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(535, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ABC Learning Center"
        '
        'menu_btn
        '
        Me.menu_btn.CheckedState.Image = CType(resources.GetObject("menu_btn.CheckedState.Image"), System.Drawing.Image)
        Me.menu_btn.CheckedState.Parent = Me.menu_btn
        Me.Guna2Transition1.SetDecoration(Me.menu_btn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.menu_btn.HoverState.Parent = Me.menu_btn
        Me.menu_btn.Image = CType(resources.GetObject("menu_btn.Image"), System.Drawing.Image)
        Me.menu_btn.IndicateFocus = False
        Me.menu_btn.Location = New System.Drawing.Point(8, 9)
        Me.menu_btn.Name = "menu_btn"
        Me.menu_btn.PressedState.Parent = Me.menu_btn
        Me.menu_btn.Size = New System.Drawing.Size(24, 24)
        Me.menu_btn.TabIndex = 2
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.lblUserId)
        Me.Guna2Panel1.Controls.Add(Me.searchAndreserve_btn)
        Me.Guna2Panel1.Controls.Add(Me.transaction_btn)
        Me.Guna2Panel1.Controls.Add(Me.login_btn)
        Me.Guna2Transition1.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 39)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(42, 585)
        Me.Guna2Panel1.TabIndex = 9
        '
        'Guna2PictureBox1
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(54, 38)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(112, 106)
        Me.Guna2PictureBox1.TabIndex = 3
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.Visible = False
        '
        'lblUserId
        '
        Me.lblUserId.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.lblUserId, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lblUserId.Font = New System.Drawing.Font("Segoe UI Historic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserId.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblUserId.Location = New System.Drawing.Point(70, 147)
        Me.lblUserId.Name = "lblUserId"
        Me.lblUserId.Size = New System.Drawing.Size(60, 25)
        Me.lblUserId.TabIndex = 2
        Me.lblUserId.Text = "Guest"
        '
        'searchAndreserve_btn
        '
        Me.searchAndreserve_btn.CheckedState.Parent = Me.searchAndreserve_btn
        Me.searchAndreserve_btn.CustomImages.Parent = Me.searchAndreserve_btn
        Me.Guna2Transition1.SetDecoration(Me.searchAndreserve_btn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.searchAndreserve_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.searchAndreserve_btn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchAndreserve_btn.ForeColor = System.Drawing.Color.Black
        Me.searchAndreserve_btn.HoverState.Parent = Me.searchAndreserve_btn
        Me.searchAndreserve_btn.Image = CType(resources.GetObject("searchAndreserve_btn.Image"), System.Drawing.Image)
        Me.searchAndreserve_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.searchAndreserve_btn.Location = New System.Drawing.Point(3, 206)
        Me.searchAndreserve_btn.Name = "searchAndreserve_btn"
        Me.searchAndreserve_btn.ShadowDecoration.Parent = Me.searchAndreserve_btn
        Me.searchAndreserve_btn.Size = New System.Drawing.Size(196, 36)
        Me.searchAndreserve_btn.TabIndex = 5
        Me.searchAndreserve_btn.Text = "Search and Borrow"
        Me.searchAndreserve_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.searchAndreserve_btn.TextOffset = New System.Drawing.Point(-3, 0)
        '
        'transaction_btn
        '
        Me.transaction_btn.CheckedState.Parent = Me.transaction_btn
        Me.transaction_btn.CustomImages.Parent = Me.transaction_btn
        Me.Guna2Transition1.SetDecoration(Me.transaction_btn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.transaction_btn.Enabled = False
        Me.transaction_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.transaction_btn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transaction_btn.ForeColor = System.Drawing.Color.Black
        Me.transaction_btn.HoverState.Parent = Me.transaction_btn
        Me.transaction_btn.Image = CType(resources.GetObject("transaction_btn.Image"), System.Drawing.Image)
        Me.transaction_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.transaction_btn.Location = New System.Drawing.Point(3, 260)
        Me.transaction_btn.Name = "transaction_btn"
        Me.transaction_btn.ShadowDecoration.Parent = Me.transaction_btn
        Me.transaction_btn.Size = New System.Drawing.Size(196, 36)
        Me.transaction_btn.TabIndex = 4
        Me.transaction_btn.Text = "Transaction Record"
        Me.transaction_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.transaction_btn.TextOffset = New System.Drawing.Point(-3, 0)
        '
        'login_btn
        '
        Me.login_btn.CheckedState.Parent = Me.login_btn
        Me.login_btn.CustomImages.Parent = Me.login_btn
        Me.Guna2Transition1.SetDecoration(Me.login_btn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.login_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.login_btn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_btn.ForeColor = System.Drawing.Color.Black
        Me.login_btn.HoverState.Parent = Me.login_btn
        Me.login_btn.Image = CType(resources.GetObject("login_btn.Image"), System.Drawing.Image)
        Me.login_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.login_btn.Location = New System.Drawing.Point(5, 546)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.ShadowDecoration.Parent = Me.login_btn
        Me.login_btn.Size = New System.Drawing.Size(194, 36)
        Me.login_btn.TabIndex = 2
        Me.login_btn.Text = "Login"
        Me.login_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.login_btn.TextOffset = New System.Drawing.Point(-33, 0)
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation1
        '
        'Column1
        '
        Me.Column1.HeaderText = "ISBN"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Title"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 75.0!
        Me.Column3.HeaderText = "Author"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.FillWeight = 80.0!
        Me.Column4.HeaderText = "Abstract"
        Me.Column4.MinimumWidth = 80
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column5
        '
        Me.Column5.HeaderText = "Description"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Publisher"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.FillWeight = 55.0!
        Me.Column8.HeaderText = "Copy Right Year"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Category"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.FillWeight = 50.0!
        Me.Column10.HeaderText = "Unit Price"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.FillWeight = 55.0!
        Me.Column7.HeaderText = "Quantity"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.FillWeight = 50.0!
        Me.Column11.HeaderText = "In Stock"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(1226, 624)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.mainPanel)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guest Module"
        Me.mainPanel.ResumeLayout(False)
        CType(Me.listData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox4.ResumeLayout(False)
        Me.Guna2GroupBox4.PerformLayout()
        Me.Guna2GroupBox3.ResumeLayout(False)
        Me.Guna2GroupBox3.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents headerPanel As Guna.UI2.WinForms.Guna2Panel

    Friend WithEvents Label13 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents search_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents prev_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents next_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents first_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents last_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents mainPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2GroupBox4 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents category_combo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents searchISBN_txtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents searchAuthor_txtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents searchTitle_txtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Title As Label
    Friend WithEvents abstract_txtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents author_txtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents title_txtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents isbn_lbl As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents avail_lbl As Label
    Friend WithEvents cart_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents listData As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents menu_btn As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblUserId As Label
    Friend WithEvents searchAndreserve_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents transaction_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents login_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
End Class
