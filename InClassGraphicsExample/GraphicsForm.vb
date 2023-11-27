'Zachary Christensen
'RCET 2265
'Fall 2023
'In Class Graphics Example
'https://github.com/Minidude140/InClassGraphicsExample.git

Option Strict On
Option Explicit On

Public Class GraphicsForm
    'Custom Methods
    Sub SetDefaults()
        DrawingPictureBox.BackColor = Color.LightBlue
    End Sub

    'Event Handlers
    Private Sub GraphicsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
