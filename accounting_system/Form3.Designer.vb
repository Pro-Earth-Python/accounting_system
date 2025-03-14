<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        components = New ComponentModel.Container()
        group_a = New ComboBox()
        group_b = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        additembtn = New Button()
        removeitembtn = New Button()
        user_selections = New ListBox()
        Label3 = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        TextBox3 = New TextBox()
        Total_Pricetxt = New TextBox()
        Label6 = New Label()
        Display_btn = New Button()
        SuspendLayout()
        ' 
        ' group_a
        ' 
        group_a.AllowDrop = True
        group_a.FormattingEnabled = True
        group_a.Location = New Point(12, 80)
        group_a.Name = "group_a"
        group_a.Size = New Size(151, 28)
        group_a.TabIndex = 0
        ' 
        ' group_b
        ' 
        group_b.FormattingEnabled = True
        group_b.Location = New Point(12, 158)
        group_b.Name = "group_b"
        group_b.Size = New Size(151, 28)
        group_b.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(50, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 2
        Label1.Text = "Group A"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Blue
        Label2.Location = New Point(50, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 20)
        Label2.TabIndex = 3
        Label2.Text = "Group B"
        ' 
        ' additembtn
        ' 
        additembtn.Location = New Point(35, 308)
        additembtn.Name = "additembtn"
        additembtn.Size = New Size(128, 29)
        additembtn.TabIndex = 4
        additembtn.Text = "Add Item"
        additembtn.UseVisualStyleBackColor = True
        ' 
        ' removeitembtn
        ' 
        removeitembtn.Location = New Point(35, 354)
        removeitembtn.Name = "removeitembtn"
        removeitembtn.Size = New Size(128, 29)
        removeitembtn.TabIndex = 5
        removeitembtn.Text = "Remove Item"
        removeitembtn.UseVisualStyleBackColor = True
        ' 
        ' user_selections
        ' 
        user_selections.FormattingEnabled = True
        user_selections.Location = New Point(488, 57)
        user_selections.Name = "user_selections"
        user_selections.Size = New Size(278, 104)
        user_selections.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(359, 254)
        Label3.Name = "Label3"
        Label3.Size = New Size(34, 20)
        Label3.TabIndex = 7
        Label3.Text = "VAT"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(488, 247)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(488, 298)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(359, 298)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 20)
        Label4.TabIndex = 11
        Label4.Text = "Discount"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(355, 359)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 20)
        Label5.TabIndex = 12
        Label5.Text = "Promotional Price"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(488, 356)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 13
        ' 
        ' Total_Pricetxt
        ' 
        Total_Pricetxt.Location = New Point(488, 389)
        Total_Pricetxt.Name = "Total_Pricetxt"
        Total_Pricetxt.Size = New Size(125, 27)
        Total_Pricetxt.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(359, 392)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 20)
        Label6.TabIndex = 15
        Label6.Text = "Total Price"
        ' 
        ' Display_btn
        ' 
        Display_btn.Location = New Point(35, 392)
        Display_btn.Name = "Display_btn"
        Display_btn.Size = New Size(128, 29)
        Display_btn.TabIndex = 16
        Display_btn.Text = "Display"
        Display_btn.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Display_btn)
        Controls.Add(Label6)
        Controls.Add(Total_Pricetxt)
        Controls.Add(TextBox3)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(user_selections)
        Controls.Add(removeitembtn)
        Controls.Add(additembtn)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(group_b)
        Controls.Add(group_a)
        Name = "Form3"
        Text = "Main App"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents group_a As ComboBox
    Friend WithEvents group_b As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents additembtn As Button
    Friend WithEvents removeitembtn As Button
    Friend WithEvents user_selections As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Total_Pricetxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Display_btn As Button
End Class
