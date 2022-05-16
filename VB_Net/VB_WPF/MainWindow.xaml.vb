Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        textBlockField.Text = DateTime.Now.DayOfWeek.ToString()
    End Sub

    Private Sub textBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles textBox.TextChanged
        textBlockField.Text = textBox.Text
    End Sub

    'Fires when touch enabled device touches text box
    Private Sub textBox_TouchEnter(sender As Object, e As TouchEventArgs) Handles textBox.TouchEnter

    End Sub
End Class
