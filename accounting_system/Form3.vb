Public Class Form3
    Dim selectedItems As New List(Of String)
    Dim vat_percent As Decimal = 15.5
    Dim groupASelected As Boolean = False

    Private Sub group_a_SelectedIndexChanged(sender As Object, e As EventArgs) Handles group_a.SelectedIndexChanged
        groupASelected = True

        If Not selectedItems.Contains(group_a.SelectedItem.ToString()) Then
            selectedItems.Add(group_a.SelectedItem.ToString())
        End If

        ' Clear the ListBox and add all items from the list
        user_selections.Items.Clear()
        user_selections.Items.AddRange(selectedItems.ToArray())
    End Sub

    Private Sub group_b_SelectedIndexChanged(sender As Object, e As EventArgs) Handles group_b.SelectedIndexChanged
        If groupASelected Then
            selectedItems.Add(group_b.SelectedItem.ToString())

            ' Clear the ListBox and add all items from the list
            user_selections.Items.Clear()
            user_selections.Items.AddRange(selectedItems.ToArray())
        Else
            MessageBox.Show("Please select an item from Group A first.")
        End If
    End Sub

    Private Sub removeitembtn_Click(sender As Object, e As EventArgs) Handles removeitembtn.Click
        If user_selections.SelectedIndex <> -1 Then
            ' Remove the selected item
            selectedItems.Remove(user_selections.SelectedItem.ToString())
            user_selections.Items.RemoveAt(user_selections.SelectedIndex)
        Else
            MessageBox.Show("Please select an item to remove.")
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Prices for group a
        Dim group_a_pricelist As New Dictionary(Of String, Double) From {
            {"Laptop - R7500.00", 7500.0},
            {"Phone - R5000.50", 5000.5},
            {"Tablet - R4000.00", 4000.0}
        }
        For Each vp As KeyValuePair(Of String, Double) In group_a_pricelist
            group_a.Items.Add(vp.Key)
        Next

        ' Prices for group b
        Dim group_b_pricelist As New Dictionary(Of String, Double) From {
            {"Desktop - R11500.50", 11500.5},
            {"Headphones - R5000.50", 5000.5},
            {"Console - R12000.00", 12000.0}
        }
        For Each vp As KeyValuePair(Of String, Double) In group_b_pricelist
            group_b.Items.Add(vp.Key)



        Next
    End Sub

    Private Sub additembtn_Click(sender As Object, e As EventArgs) Handles additembtn.Click
        ' Add item logic here

    End Sub

    Private Sub user_selections_SelectedIndexChanged(sender As Object, e As EventArgs) Handles user_selections.SelectedIndexChanged
        ' Logic for user selections
    End Sub
    Private Function CalculateTotal() As Decimal
        Dim total As Decimal = 0
        For Each item As String In selectedItems
            Dim priceString As String = item.Split("-"c)(1).Trim().Replace("R", "")
            Dim price As Decimal

            If Decimal.TryParse(priceString, price) Then
                total += price
            End If
        Next
        Return total
        'Dim total As Decimal = 0
        'For Each item As String In selectedItems
        '    Dim priceString As String = item.Split("-"c)(1).Trim().Replace("R", "")
        '    Dim price As Decimal

        '    'Dim price As Decimal = Decimal.Parse(priceString)




        '    priceString = Decimal.TryParse(priceString, price)

        '    priceString += total
        '    End If
        '    priceString += total

        'Next
        'Return total

    End Function

    Private Sub Display_btn_Click(sender As Object, e As EventArgs) Handles Display_btn.Click
        Total_Pricetxt.Text = CalculateTotal().ToString("C")
    End Sub
End Class
