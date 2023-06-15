<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Me.Addbnt = New System.Windows.Forms.Button()
        Me.Exitbnt = New System.Windows.Forms.Button()
        Me.Clearbnt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CustomerID_box = New System.Windows.Forms.TextBox()
        Me.FirstName_box = New System.Windows.Forms.TextBox()
        Me.LastName_box = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TotalSpend_box = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Addbnt
        '
        Me.Addbnt.Location = New System.Drawing.Point(355, 150)
        Me.Addbnt.Name = "Addbnt"
        Me.Addbnt.Size = New System.Drawing.Size(102, 60)
        Me.Addbnt.TabIndex = 0
        Me.Addbnt.Text = "Add"
        Me.Addbnt.UseVisualStyleBackColor = True
        '
        'Exitbnt
        '
        Me.Exitbnt.Location = New System.Drawing.Point(354, 291)
        Me.Exitbnt.Name = "Exitbnt"
        Me.Exitbnt.Size = New System.Drawing.Size(103, 60)
        Me.Exitbnt.TabIndex = 1
        Me.Exitbnt.Text = "Exit"
        Me.Exitbnt.UseVisualStyleBackColor = True
        '
        'Clearbnt
        '
        Me.Clearbnt.Location = New System.Drawing.Point(366, 228)
        Me.Clearbnt.Name = "Clearbnt"
        Me.Clearbnt.Size = New System.Drawing.Size(75, 46)
        Me.Clearbnt.TabIndex = 2
        Me.Clearbnt.Text = "Clear"
        Me.Clearbnt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Customer ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Last Name"
        '
        'CustomerID_box
        '
        Me.CustomerID_box.Location = New System.Drawing.Point(114, 19)
        Me.CustomerID_box.Name = "CustomerID_box"
        Me.CustomerID_box.Size = New System.Drawing.Size(100, 20)
        Me.CustomerID_box.TabIndex = 7
        '
        'FirstName_box
        '
        Me.FirstName_box.Location = New System.Drawing.Point(114, 47)
        Me.FirstName_box.Name = "FirstName_box"
        Me.FirstName_box.Size = New System.Drawing.Size(155, 20)
        Me.FirstName_box.TabIndex = 8
        '
        'LastName_box
        '
        Me.LastName_box.Location = New System.Drawing.Point(114, 77)
        Me.LastName_box.Name = "LastName_box"
        Me.LastName_box.Size = New System.Drawing.Size(155, 20)
        Me.LastName_box.TabIndex = 9
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(15, 152)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(333, 199)
        Me.ListBox1.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(88, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Total Spend"
        '
        'TotalSpend_box
        '
        Me.TotalSpend_box.Location = New System.Drawing.Point(190, 119)
        Me.TotalSpend_box.Name = "TotalSpend_box"
        Me.TotalSpend_box.Size = New System.Drawing.Size(155, 20)
        Me.TotalSpend_box.TabIndex = 12
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 365)
        Me.Controls.Add(Me.TotalSpend_box)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.LastName_box)
        Me.Controls.Add(Me.FirstName_box)
        Me.Controls.Add(Me.CustomerID_box)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Clearbnt)
        Me.Controls.Add(Me.Exitbnt)
        Me.Controls.Add(Me.Addbnt)
        Me.Name = "Customer"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Addbnt As System.Windows.Forms.Button
    Friend WithEvents Exitbnt As System.Windows.Forms.Button
    Friend WithEvents Clearbnt As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CustomerID_box As System.Windows.Forms.TextBox
    Friend WithEvents FirstName_box As System.Windows.Forms.TextBox
    Friend WithEvents LastName_box As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TotalSpend_box As System.Windows.Forms.TextBox

End Class
