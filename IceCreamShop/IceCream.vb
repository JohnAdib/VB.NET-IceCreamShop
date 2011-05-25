Public Class IceCream

    Private _p1 As String
    Private mBread As Integer
    Private mIce As Integer
    Private mGlass As Integer
    Private mSpoon As Integer
    Private mCash As Integer
    Private mTitle As String

    Public Event NoBread(ByVal Sender As String)
    Public Event NoIce(ByVal Sender As String)
    Public Event NoGlass(ByVal Sender As String)
    Public Event NoSpoon(ByVal Sender As String)
    Public Event GiveCash(ByVal Sender As String)

    Public Property Title As String
        Set(ByVal value As String)
            mTitle = value
        End Set
        Get
            Return mTitle
        End Get
    End Property

    Public Property Bread As Integer
        Set(ByVal value As Integer)
            If value >= 0 Then mBread = value
            If mBread = 0 Then RaiseEvent NoBread(mTitle)
        End Set
        Get
            Return mBread
        End Get
    End Property
    Public Property Ice As Integer
        Set(ByVal value As Integer)
            mIce = value
            If mIce < 50 Then RaiseEvent NoIce(mTitle)
        End Set
        Get
            Return mIce
        End Get
    End Property
    Public Property Spoon As Integer
        Set(ByVal value As Integer)
            If value >= 0 Then mSpoon = value
            If mSpoon = 0 Then RaiseEvent NoSpoon(mTitle)
        End Set
        Get
            Return mSpoon
        End Get
    End Property
    Public Property Glass As Integer
        Set(ByVal value As Integer)
            If value >= 0 Then mGlass = value
            If mGlass = 0 Then RaiseEvent NoGlass(mTitle)
        End Set
        Get
            Return mGlass
        End Get
    End Property
    Public Property Cash As Integer
        Set(ByVal value As Integer)
            If value >= 0 Then mCash = value
            If mCash >= 1000000 Then RaiseEvent GiveCash(mTitle)
        End Set
        Get
            Return mCash
        End Get
    End Property

    Public Sub SaleBread()
        Bread -= 1
    End Sub

    Public Sub SaleGlass()
        Glass -= 1
    End Sub
    Public Sub SaleSpoon()
        Spoon -= 1
    End Sub
    Public Sub SaleIce(Optional ByVal IceSize As Integer = 50)
        Ice -= IceSize
    End Sub
    Public Sub GiveMoney(Optional ByVal CMoney As Integer = 50)
        Cash += CMoney
    End Sub



    Sub New(ByVal p1 As String)
        ' TODO: Complete member initialization 
        _p1 = p1
    End Sub

    Sub New()
        ' TODO: Complete member initialization 
        Bread = 50
        Spoon = 50
        Glass = 50
        Ice = 500
        Cash = 0
    End Sub

End Class

Public Class mGlobals
    Public Shared Shop As New Collections.ArrayList

End Class
