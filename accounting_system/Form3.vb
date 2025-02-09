Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Collections.Generic

Public Class Form3
    Dim selectedItems As New List(Of String)
    'The logic for addition of items is done from the 

    Private Sub group_a_SelectedIndexChanged(sender As Object, e As EventArgs) Handles group_a.SelectedIndexChanged

        If Not selectedItems.Contains(group_a.SelectedItem.ToString()) Then
            selectedItems.Add(group_a.SelectedItem.ToString())
        End If

        ' Clear the ListBox and add all items from the list
        user_selections.Items.Clear()
        user_selections.Items.AddRange(selectedItems.ToArray())

    End Sub
    Private Sub group_b_SelectedIndexChanged(sender As Object, e As EventArgs) Handles group_b.SelectedIndexChanged
        'changes is logic it must allow adding the same item on the list as many a needed
        If Not selectedItems.Contains(group_b.SelectedItem.ToString()) Then
            selectedItems.Add(group_b.SelectedItem.ToString())
        End If

        ' Clear the ListBox and add all items from the list
        user_selections.Items.Clear()
        user_selections.Items.AddRange(selectedItems.ToArray())
    End Sub

    Private Sub removeitembtn_Click(sender As Object, e As EventArgs) Handles removeitembtn.Click
        If user_selections.SelectedIndex <> -1 Then
            ' Remove the selected item
            user_selections.Items.RemoveAt(user_selections.SelectedIndex)
        Else
            MessageBox.Show("Please select an item to remove.")
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Prices for group a
        Dim group_a_pricelist As New Dictionary(Of String, Double) From {
            {"Laptop - R7500.00", 7500.0},
            {"Phone - R5000.50", 5000.5},
            {"Tablet - R4000.00", 4000.0}
        }
        'for looping through the dictionary values to 
        For Each vp As KeyValuePair(Of String, Double) In group_a_pricelist
            group_a.Items.Add(vp.Key)
        Next

        'prices for group b 
        Dim group_b_pricelist As New Dictionary(Of String, Double)() From {
            {"Desktop - R11500.50", 11500.5},
            {"Headphones - R5000.50", 5000.5},
            {"Console - R12000.00", 12000.0}
        }
        For Each vp As KeyValuePair(Of String, Double) In group_b_pricelist
            group_b.Items.Add(vp.Key)
        Next


    End Sub

    Private Sub additembtn_Click(sender As Object, e As EventArgs) Handles additembtn.Click

    End Sub
End Class