Imports System.IO
Public Class FrmMain
    Public Shop(0) As IceCream
    Public CanSell(0) As Boolean
    Public CShop As Integer

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click


    End Sub
    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Shop(0) = New IceCream
        Shop(0).Title = "مرکزی"

        FillCombo()
        Tip1.SetToolTip(Label1, "نام فروشگاه")
        Tip1.SetToolTip(Label2, "تعداد نان های موجود")
        Tip1.SetToolTip(Label3, "تعداد قاشق های موجود")
        Tip1.SetToolTip(Label4, "تعداد لیوان های موجود")
        Tip1.SetToolTip(Label5, "مقدار بستنی های موجود")
        Tip1.SetToolTip(Label6, "موجودی فروشگاه")
        Tip1.SetToolTip(ChkNoon, "فروش نان همراه بستنی")
        CboStores.SelectedIndex = 0
    End Sub

    Private Sub FillCombo()
        CboStores.Items.Clear()
        For i As Integer = 0 To Shop.Length - 1
            Try
                CboStores.Items.Add(Shop(i).Title)
            Catch ex As Exception
            End Try
        Next
    End Sub
    Private Sub AddStore() Handles AddStoreMenu.Click
        Dim str As String = InputBox("نام فروشگاه جدید را وارد کنید")
        If str.Trim <> "" Then
            ReDim Preserve Shop(CboStores.Items.Count)
            Shop(CboStores.Items.Count) = New IceCream
            Shop(CboStores.Items.Count).Title = str.Trim
            'mGlobals.Shop.Add(New IceCream(str.Trim))
            FillCombo()
        Else
            MsgBox("نام معتبر وارد کنید")
        End If
        CboStores.SelectedIndex = CboStores.Items.Count - 1
    End Sub
    Private Sub UpdateData() Handles CboStores.SelectedIndexChanged, CboStores.Click
        CShop = CboStores.SelectedIndex
        If CShop >= 0 Then
            TBread.Value = Shop(CShop).Bread
            TSpoon.Value = Shop(CShop).Spoon
            TGlass.Value = Shop(CShop).Glass
            TIce.Value = Shop(CShop).Ice
            TCash.Text = Shop(CShop).Cash
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim str = MessageBox.Show("آیا مایل به ثبت اطلاعات جدید هستید؟", "بستنی فروشی", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If str = vbYes Then
            Shop(CShop).Bread = TBread.Value
            Shop(CShop).Spoon = TSpoon.Value
            Shop(CShop).Glass = TGlass.Value
            Shop(CShop).Ice = TIce.Value
            Shop(CShop).Cash = TCash.Text
        End If
    End Sub

    Private Sub MakeDisable()
        CanSell(CShop) = False
    End Sub

    Private Sub BtnSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSale.Click
        Shop(CShop).SaleBread()
        Shop(CShop).SaleSpoon()
        Shop(CShop).SaleGlass()
        Shop(CShop).SaleIce()
        Shop(CShop).GiveMoney()
        UpdateData()
    End Sub

    Private Sub ChangeShopTitle() Handles EditToolStripMenuItem1.Click
        Dim str As String = InputBox("نام فروشگاه جدید را وارد کنید", "فروشگاه " & Shop(CShop).Title)
        If str.Trim <> "" Then
            Shop(CShop).Title = str
            FillCombo()
        Else
            MsgBox("نام معتبر وارد کنید")
        End If
    End Sub

    Private Sub EndProgram() Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click

    End Sub

    Private Sub FrmMain_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        If MsgBox("کجا! عجله داری؟", vbYesNo + vbCritical + vbMsgBoxRight) = vbYes Then
            EndProgram()
        End If
    End Sub


End Class
