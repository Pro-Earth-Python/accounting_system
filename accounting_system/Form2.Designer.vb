<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        lgnbtn = New Button()
        Registerbtn = New Button()
        passwordtxt = New TextBox()
        usernametxt = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' lgnbtn
        ' 
        lgnbtn.Location = New Point(137, 331)
        lgnbtn.Name = "lgnbtn"
        lgnbtn.Size = New Size(94, 29)
        lgnbtn.TabIndex = 0
        lgnbtn.Text = "Login"
        lgnbtn.UseVisualStyleBackColor = True
        ' 
        ' Registerbtn
        ' 
        Registerbtn.Location = New Point(514, 331)
        Registerbtn.Name = "Registerbtn"
        Registerbtn.Size = New Size(94, 29)
        Registerbtn.TabIndex = 1
        Registerbtn.Text = "Register"
        Registerbtn.UseVisualStyleBackColor = True
        ' 
        ' passwordtxt
        ' 
        passwordtxt.Location = New Point(479, 121)
        passwordtxt.Name = "passwordtxt"
        passwordtxt.Size = New Size(190, 27)
        passwordtxt.TabIndex = 2
        ' 
        ' usernametxt
        ' 
        usernametxt.Location = New Point(94, 121)
        usernametxt.Name = "usernametxt"
        usernametxt.Size = New Size(190, 27)
        usernametxt.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 128)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 20)
        Label1.TabIndex = 4
        Label1.Text = "UserName"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(405, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 5
        Label2.Text = "Password"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(usernametxt)
        Controls.Add(passwordtxt)
        Controls.Add(Registerbtn)
        Controls.Add(lgnbtn)
        Name = "Form2"
        Text = "Login/Registration"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lgnbtn As Button
    Friend WithEvents Registerbtn As Button
    Friend WithEvents passwordtxt As TextBox
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
