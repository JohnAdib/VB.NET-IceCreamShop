<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.CboStores = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSale = New System.Windows.Forms.Button()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.بستنیToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.لیوانToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.قاشقToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.نانToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.کلیToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.دریافتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkNoon = New System.Windows.Forms.CheckBox()
        Me.TCash = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TIce = New System.Windows.Forms.NumericUpDown()
        Me.TGlass = New System.Windows.Forms.NumericUpDown()
        Me.TSpoon = New System.Windows.Forms.NumericUpDown()
        Me.TBread = New System.Windows.Forms.NumericUpDown()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Tip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.امکاناتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.فروشگاههاToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStoreMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContextMenu1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TIce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TGlass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSpoon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBread, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolBar1.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CboStores
        '
        Me.CboStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboStores.Font = New System.Drawing.Font("B Koodak", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CboStores.FormattingEnabled = True
        Me.CboStores.Location = New System.Drawing.Point(35, 66)
        Me.CboStores.Name = "CboStores"
        Me.CboStores.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CboStores.Size = New System.Drawing.Size(165, 29)
        Me.CboStores.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("B Koodak", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(197, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "نام فروشگاه"
        '
        'BtnSale
        '
        Me.BtnSale.ContextMenuStrip = Me.ContextMenu1
        Me.BtnSale.Font = New System.Drawing.Font("B Koodak", 10.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSale.Location = New System.Drawing.Point(35, 328)
        Me.BtnSale.Name = "BtnSale"
        Me.BtnSale.Size = New System.Drawing.Size(214, 34)
        Me.BtnSale.TabIndex = 7
        Me.BtnSale.Text = "فروش"
        Me.BtnSale.UseVisualStyleBackColor = True
        '
        'ContextMenu1
        '
        Me.ContextMenu1.Font = New System.Drawing.Font("B Koodak", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.بستنیToolStripMenuItem, Me.لیوانToolStripMenuItem, Me.قاشقToolStripMenuItem, Me.نانToolStripMenuItem, Me.ToolStripSeparator3, Me.کلیToolStripMenuItem, Me.ToolStripSeparator4, Me.دریافتToolStripMenuItem})
        Me.ContextMenu1.Name = "ContextMenu1"
        Me.ContextMenu1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextMenu1.Size = New System.Drawing.Size(130, 172)
        '
        'بستنیToolStripMenuItem
        '
        Me.بستنیToolStripMenuItem.Name = "بستنیToolStripMenuItem"
        Me.بستنیToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.بستنیToolStripMenuItem.Text = "بستنی"
        '
        'لیوانToolStripMenuItem
        '
        Me.لیوانToolStripMenuItem.Name = "لیوانToolStripMenuItem"
        Me.لیوانToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.لیوانToolStripMenuItem.Text = "لیوان"
        '
        'قاشقToolStripMenuItem
        '
        Me.قاشقToolStripMenuItem.Name = "قاشقToolStripMenuItem"
        Me.قاشقToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.قاشقToolStripMenuItem.Text = "قاشق"
        '
        'نانToolStripMenuItem
        '
        Me.نانToolStripMenuItem.Name = "نانToolStripMenuItem"
        Me.نانToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.نانToolStripMenuItem.Text = "نان"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.BackColor = System.Drawing.Color.OrangeRed
        Me.ToolStripSeparator3.ForeColor = System.Drawing.Color.OrangeRed
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(126, 6)
        '
        'کلیToolStripMenuItem
        '
        Me.کلیToolStripMenuItem.Name = "کلیToolStripMenuItem"
        Me.کلیToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.کلیToolStripMenuItem.Text = "کلی"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(126, 6)
        '
        'دریافتToolStripMenuItem
        '
        Me.دریافتToolStripMenuItem.Name = "دریافتToolStripMenuItem"
        Me.دریافتToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.دریافتToolStripMenuItem.Text = "دریافت پول "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkNoon)
        Me.GroupBox1.Controls.Add(Me.TCash)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TIce)
        Me.GroupBox1.Controls.Add(Me.TGlass)
        Me.GroupBox1.Controls.Add(Me.TSpoon)
        Me.GroupBox1.Controls.Add(Me.TBread)
        Me.GroupBox1.Font = New System.Drawing.Font("B Koodak", 10.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(214, 220)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "موجودی فروشگاه"
        '
        'ChkNoon
        '
        Me.ChkNoon.AutoSize = True
        Me.ChkNoon.Checked = True
        Me.ChkNoon.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkNoon.Location = New System.Drawing.Point(24, 39)
        Me.ChkNoon.Name = "ChkNoon"
        Me.ChkNoon.Size = New System.Drawing.Size(15, 14)
        Me.ChkNoon.TabIndex = 16
        Me.ChkNoon.UseVisualStyleBackColor = True
        '
        'TCash
        '
        Me.TCash.Font = New System.Drawing.Font("Times New Roman", 9.25!, System.Drawing.FontStyle.Bold)
        Me.TCash.Location = New System.Drawing.Point(46, 177)
        Me.TCash.Name = "TCash"
        Me.TCash.Size = New System.Drawing.Size(119, 22)
        Me.TCash.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("B Koodak", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(180, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 19)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "مبلغ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("B Koodak", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(174, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 19)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "بستنی"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("B Koodak", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(178, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 19)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "لیوان"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("B Koodak", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(177, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "قاشق"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("B Koodak", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(185, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "نان"
        '
        'TIce
        '
        Me.TIce.Font = New System.Drawing.Font("Times New Roman", 9.25!, System.Drawing.FontStyle.Bold)
        Me.TIce.Location = New System.Drawing.Point(45, 145)
        Me.TIce.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.TIce.Name = "TIce"
        Me.TIce.Size = New System.Drawing.Size(120, 22)
        Me.TIce.TabIndex = 9
        Me.TIce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TGlass
        '
        Me.TGlass.Font = New System.Drawing.Font("Times New Roman", 9.25!, System.Drawing.FontStyle.Bold)
        Me.TGlass.Location = New System.Drawing.Point(46, 108)
        Me.TGlass.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.TGlass.Name = "TGlass"
        Me.TGlass.Size = New System.Drawing.Size(120, 22)
        Me.TGlass.TabIndex = 8
        Me.TGlass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TSpoon
        '
        Me.TSpoon.Font = New System.Drawing.Font("Times New Roman", 9.25!, System.Drawing.FontStyle.Bold)
        Me.TSpoon.Location = New System.Drawing.Point(46, 71)
        Me.TSpoon.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.TSpoon.Name = "TSpoon"
        Me.TSpoon.Size = New System.Drawing.Size(120, 22)
        Me.TSpoon.TabIndex = 7
        Me.TSpoon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBread
        '
        Me.TBread.Font = New System.Drawing.Font("Times New Roman", 9.25!, System.Drawing.FontStyle.Bold)
        Me.TBread.Location = New System.Drawing.Point(45, 34)
        Me.TBread.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.TBread.Name = "TBread"
        Me.TBread.Size = New System.Drawing.Size(120, 22)
        Me.TBread.TabIndex = 6
        Me.TBread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "addons.ico")
        Me.ImageList1.Images.SetKeyName(1, "attachment.ico")
        Me.ImageList1.Images.SetKeyName(2, "iran.ico")
        Me.ImageList1.Images.SetKeyName(3, "rules.ico")
        '
        'Tip1
        '
        Me.Tip1.ShowAlways = True
        '
        'ToolBar1
        '
        Me.ToolBar1.Font = New System.Drawing.Font("B Koodak", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ToolBar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripDropDownButton1, Me.ToolStripButton3})
        Me.ToolBar1.Location = New System.Drawing.Point(0, 29)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolBar1.Size = New System.Drawing.Size(285, 28)
        Me.ToolBar1.TabIndex = 9
        Me.ToolBar1.Text = "Tool1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(51, 25)
        Me.ToolStripButton1.Text = "اضافه"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(52, 25)
        Me.ToolStripButton2.Text = "حذف"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(65, 25)
        Me.ToolStripDropDownButton1.Text = "فروش"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(46, 25)
        Me.ToolStripButton3.Text = "ثبت"
        '
        'MainMenu
        '
        Me.MainMenu.Font = New System.Drawing.Font("B Koodak", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.امکاناتToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MainMenu.Size = New System.Drawing.Size(285, 29)
        Me.MainMenu.TabIndex = 10
        Me.MainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.toolStripSeparator1, Me.PrintToolStripMenuItem, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(38, 25)
        Me.FileToolStripMenuItem.Text = "&فایل"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(150, 26)
        Me.SaveToolStripMenuItem.Text = "ذخیره"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(147, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(150, 26)
        Me.PrintToolStripMenuItem.Text = "چاپ"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(147, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(150, 26)
        Me.ExitToolStripMenuItem.Text = "خروج"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(54, 25)
        Me.EditToolStripMenuItem.Text = "&ویرایش"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(160, 26)
        Me.CutToolStripMenuItem.Text = "بریدن"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(160, 26)
        Me.CopyToolStripMenuItem.Text = "کپی"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(160, 26)
        Me.PasteToolStripMenuItem.Text = "چسباندن"
        '
        'امکاناتToolStripMenuItem
        '
        Me.امکاناتToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.فروشگاههاToolStripMenuItem})
        Me.امکاناتToolStripMenuItem.Name = "امکاناتToolStripMenuItem"
        Me.امکاناتToolStripMenuItem.Size = New System.Drawing.Size(52, 25)
        Me.امکاناتToolStripMenuItem.Text = "&امکانات"
        '
        'فروشگاههاToolStripMenuItem
        '
        Me.فروشگاههاToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStoreMenu, Me.EditToolStripMenuItem1, Me.DeleteToolStripMenuItem})
        Me.فروشگاههاToolStripMenuItem.Name = "فروشگاههاToolStripMenuItem"
        Me.فروشگاههاToolStripMenuItem.Size = New System.Drawing.Size(125, 26)
        Me.فروشگاههاToolStripMenuItem.Text = "فروشگاه ها"
        '
        'AddStoreMenu
        '
        Me.AddStoreMenu.Name = "AddStoreMenu"
        Me.AddStoreMenu.Size = New System.Drawing.Size(127, 26)
        Me.AddStoreMenu.Text = "اضافه کردن"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(127, 26)
        Me.EditToolStripMenuItem1.Text = "تغییرنام"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(127, 26)
        Me.DeleteToolStripMenuItem.Text = "حذف"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSeparator7, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(57, 25)
        Me.HelpToolStripMenuItem.Text = "&درباره ی"
        '
        'toolStripSeparator7
        '
        Me.toolStripSeparator7.Name = "toolStripSeparator7"
        Me.toolStripSeparator7.Size = New System.Drawing.Size(124, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(127, 26)
        Me.AboutToolStripMenuItem.Text = "درباره ی ..."
        '
        'BindingSource1
        '
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 370)
        Me.Controls.Add(Me.BtnSale)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CboStores)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.MainMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MainMenu
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.Opacity = 0.95R
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نرم افزار فروش بستنی"
        Me.ContextMenu1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TIce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TGlass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSpoon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBread, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolBar1.ResumeLayout(False)
        Me.ToolBar1.PerformLayout()
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CboStores As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSale As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TIce As System.Windows.Forms.NumericUpDown
    Friend WithEvents TGlass As System.Windows.Forms.NumericUpDown
    Friend WithEvents TSpoon As System.Windows.Forms.NumericUpDown
    Friend WithEvents TBread As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TCash As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents بستنیToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents لیوانToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents قاشقToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents نانToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents کلیToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents دریافتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ChkNoon As System.Windows.Forms.CheckBox
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents امکاناتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents فروشگاههاToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddStoreMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource

End Class
