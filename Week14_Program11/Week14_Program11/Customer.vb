Public Class Customer
    'Page 794 #12
    Protected CustomerID As Integer
    Protected FirstName As String
    Protected LastName As String
    Protected TotalSpend As Double
    Protected FivePercentDiscount As Integer = 0.05
    Protected Six_Percent_Discount As Integer = 0.06
    Dim Seven_Percent_Discount As Integer = 0.07
    Dim Ten_Percent_Discount As Integer = 0.1

    ''Dim PreferredCustomer As New Customer
    'Dim PreferredCustomer1 As New Customer
    'Dim PreferredCustomer2 As New Customer

    Public Property funcCustomerID() As Integer
        Get
            Return CustomerID
        End Get
        Set(ByVal cust As Integer)
            CustomerID = cust
        End Set
    End Property

    Public Property funcFirstName() As String
        Get
            Return FirstName
        End Get
        Set(ByVal value As String)
            FirstName = value
        End Set
    End Property

    Public Property funcLastName() As String
        Get
            Return LastName
        End Get
        Set(ByVal value As String)
            LastName = value
        End Set
    End Property

    Public Property theCustumer(id As Integer, fname As String, lname As String)
        Get
            Return id & fname & lname
        End Get
        Set(value)
            CustomerID = id
            FirstName = fname
            LastName = lname
        End Set
    End Property


    Public Function FirstCustomer(id As Integer) 'As FirstCustomer()
        'id = CustomerID
        ListBox1.Items.Add("Customer ID: " & funcCustomerID)
        Return id
    End Function
    Public Function fname(fnam As String)
        Text = "First Name: " & funcFirstName()
        Return fnam
    End Function

    Public Function lname(lnam As Integer)
        Text = "Last Name: " & funcLastName
        Return lnam
    End Function

    Public Function Discount(total As Double, fiveper As Integer, sixper As Integer, sevenper As Integer, tenper As Integer)
        Dim discoun As Integer = 0
        fiveper = FivePercentDiscount
        sixper = Six_Percent_Discount
        sevenper = Seven_Percent_Discount
        tenper = Ten_Percent_Discount
        total = TotalSpend

        If total > 500 Then
            ListBox1.Items.Add("Preferred customer")
            discoun = total * 0.05
            ListBox1.Items.Add("You saved: " & discoun)
            total = discoun + total
        Else
            If TotalSpend > 1000 Then
                total += Six_Percent_Discount
            Else
                If TotalSpend > 15000 Then
                    TotalSpend += Seven_Percent_Discount
                Else
                    If TotalSpend > 2000 Then
                        TotalSpend += Ten_Percent_Discount
                    Else
                        Return total + (total * 0.05)
                    End If
                End If
            End If
        End If
        Return total 'And fiveper And sixper And sevenper And tenper
    End Function
    Private Sub Addbnt_Click(sender As Object, e As EventArgs) Handles Addbnt.Click
        'Dim PreferredCustomer As New Customer
        'Dim PreferredCustomer1 As New Customer
        'Dim PreferredCustomer2 As New Customer

        Try
            CustomerID = CustomerID_box.Text
            FirstName = FirstName_box.Text
            LastName = LastName_box.Text
            TotalSpend = TotalSpend_box.Text

            'CustomerID = CustomerID_box.Text
            'PreferredCustomer.FirstName = FirstName_box.Text
            'PreferredCustomer.LastName = LastName_box.Text

            'PreferredCustomer1.ListBox1.Items.Add("Customer ID: " & .CustomerID = "99999")
            ''ListBox1.Items.Add("First Name: " & PreferredCustomer.funcFirstName = "Mary")
            ''ListBox1.Items.Add("Last Name: " & PreferredCustomer.funcLastName = "Carlo")
            'ListBox1.Items.Add(" ")


            'PreferredCustomer2.ListBox1.Items.Add("Customer ID: " & PreferredCustomer2.CustomerID = "66674")
            'PreferredCustomer2.ListBox1.Items.Add("First Name: " & PreferredCustomer2.FirstName = "Kretty")
            'PreferredCustomer2.ListBox1.Items.Add("Last Name: " & PreferredCustomer2.LastName = "Josse")

            'ListBox1.Items.Add("Customer ID: " & PreferredCustomer.funcCustomerID)
            'ListBox1.Items.Add("First Name: " & PreferredCustomer.funcFirstName)
            'ListBox1.Items.Add("Last Name: " & PreferredCustomer.funcLastName)
            'ListBox1.Items.Add(" ")

            ListBox1.Items.Add("Customer ID: " & funcCustomerID)
            ListBox1.Items.Add("First Name: " & funcFirstName)
            ListBox1.Items.Add("Last Name: " & funcLastName
                               )
            ListBox1.Items.Add("Total Amount: " & Discount(TotalSpend, FivePercentDiscount, Six_Percent_Discount.ToString, Seven_Percent_Discount, Ten_Percent_Discount))
            ListBox1.Items.Add(" ")

            'ListBox1.Items.Add("Customer ID: " & PreferredCustomer.funcCustomerID)
            'ListBox1.Items.Add("First Name: " & PreferredCustomer.funcFirstName)
            'ListBox1.Items.Add("Last Name: " & PreferredCustomer.funcLastName)
        Catch
        End Try

    End Sub


    Private Sub Clearbnt_Click(sender As Object, e As EventArgs) Handles Clearbnt.Click
        CustomerID_box.Clear()
        FirstName_box.Clear()
        LastName_box.Clear()
        ListBox1.Items.Clear()


    End Sub

    Private Sub Exitbnt_Click(sender As Object, e As EventArgs) Handles Exitbnt.Click
        Me.Close()
    End Sub



End Class
