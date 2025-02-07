<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Heading = New Label()
        loginbtn = New Button()
        registrationbtn = New Button()
        SuspendLayout()
        ' 
        ' Heading
        ' 
        Heading.AutoSize = True
        Heading.Location = New Point(311, 31)
        Heading.Name = "Heading"
        Heading.Size = New Size(144, 20)
        Heading.TabIndex = 0
        Heading.Text = "Welcome to the app"
        ' 
        ' loginbtn
        ' 
        loginbtn.Location = New Point(107, 280)
        loginbtn.Name = "loginbtn"
        loginbtn.Size = New Size(94, 29)
        loginbtn.TabIndex = 1
        loginbtn.Text = "Login"
        loginbtn.UseVisualStyleBackColor = True
        ' 
        ' registrationbtn
        ' 
        registrationbtn.Location = New Point(511, 280)
        registrationbtn.Name = "registrationbtn"
        registrationbtn.Size = New Size(94, 29)
        registrationbtn.TabIndex = 2
        registrationbtn.Text = "Register"
        registrationbtn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(registrationbtn)
        Controls.Add(loginbtn)
        Controls.Add(Heading)
        Name = "Form1"
        Text = "Accounts Manager"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Heading As Label
    Friend WithEvents loginbtn As Button
    Friend WithEvents registrationbtn As Button

End Class
