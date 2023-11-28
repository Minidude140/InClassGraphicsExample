'Zachary Christensen
'RCET 2265
'Fall 2023
'In Class Graphics Example
'https://github.com/Minidude140/InClassGraphicsExample.git

Option Strict On
Option Explicit On

Public Class GraphicsForm
    Dim backgroundColor As Color
    Dim foregroundColor As Color
    'Custom Methods
    ''' <summary>
    ''' Sets the standard background color
    ''' </summary>
    Sub SetDefaults()
        DrawingPictureBox.BackColor = Color.BlanchedAlmond
    End Sub

    ''' <summary>
    ''' Draws a line from the first given point to the second given point
    ''' </summary>
    Sub DrawLine(x1%, y1%, x2%, y2%)
        'initialize graphics object and set drawing surface to picture box
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        'initialize pen as color black
        Dim pen As New Pen(Color.Black)
        'draws a line from given co-ordinates (x,y) to (x,y); (0,0) in upper left hand corner
        g.DrawLine(pen, x1, y1, x2, y2)
        'dispose of the pen and graphics object to clear memory
        pen.Dispose()
        g.Dispose()
    End Sub

    'Event Handlers
    Private Sub GraphicsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
        DrawLine()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub DrawingPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove
        Me.Text = $"({e.X}),({e.Y}) Button: {e.Button}"
    End Sub
    Private Sub DrawingPictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseDown
        Me.Text = $"({e.X}),({e.Y}) Button: {e.Button}"
    End Sub
    Private Sub DrawingPictureBox_MouseLeave(sender As Object, e As EventArgs) Handles DrawingPictureBox.MouseLeave
        Me.Text = "Let's Draw"
    End Sub
End Class
