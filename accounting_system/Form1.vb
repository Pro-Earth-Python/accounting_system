Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Ohayo Sekai Good morning world")


    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim form1 As New Form1()
        Dim form2 As New Form2()
        form2.Show()
        form1.Hide()




    End Sub
End Class
