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
        group_a = New ComboBox()
        group_b = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        additembtn = New Button()
        removeitembtn = New Button()
        user_selections = New ListBox()
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
        user_selections.Size = New Size(278, 344)
        user_selections.TabIndex = 6
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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
End Class
