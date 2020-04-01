' Author: Kyle Chapman
' Date: March 31, 2020
' Description:
'   This program is a simple whiteboard or paint application.
'   A user can draw freely on a surface using singular points
'   (not shapes), with a configurable size and colour.
'   Basically functionality to Save and some clipboard
'   functionality also exists.

Option Strict On

Public Class frmWhiteboard

    ' Is the mouse button down?
    Dim isPressed As Boolean = False
    Dim filePath As String = String.Empty

    ' Indicates the current position of the cursor
    Dim xValue As Integer = 0
    Dim yValue As Integer = 0

    ' The starting/current size and color of the paintbrush
    Dim brushSize As Integer = 5
    Dim brushColour As Color = Color.Black

    ' Indicates the current draw region based on the cursor's coordinates
    Dim drawRectangle As New Rectangle(xValue, yValue, brushSize, brushSize)

    ' This actually holds the image
    Dim bitmapInstance As Bitmap

    ' Used for access to the Graphics class
    Dim graphics As Drawing.Graphics

#Region "Mouse- and Paint-Related Event Handlers"

    ''' <summary>
    ''' When the mouse button is up on the form or the canvas, indicate that it is not pressed
    ''' </summary>
    Private Sub MouseButtonUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, pbxCanvas.MouseUp

        isPressed = False

    End Sub

    ''' <summary>
    ''' When the mouse button is down on the canvas, record that it is down; also draw this single space
    ''' </summary>
    Private Sub MouseButtonDown(sender As Object, e As MouseEventArgs) Handles pbxCanvas.MouseDown

        ' The button is pressed
        isPressed = True

        ' Set current coordinates
        xValue = e.X
        yValue = e.Y

        ' Set the space to draw
        drawRectangle = New Rectangle(xValue, yValue, brushSize, brushSize)

        ' Force the canvas to re-draw itself
        pbxCanvas.Invalidate(drawRectangle)

    End Sub

    ''' <summary>
    ''' When the mouse is moved, if button is down, draw this single space
    ''' </summary>
    Private Sub MouseIsMoved(sender As Object, e As MouseEventArgs) Handles pbxCanvas.MouseMove

        ' Check if it's pressed
        If isPressed Then

            ' Set current coordinates
            xValue = e.X
            yValue = e.Y

            ' Set the space to draw
            drawRectangle = New Rectangle(xValue, yValue, brushSize, brushSize)

            ' Force the canvas to re-draw itself
            pbxCanvas.Invalidate(drawRectangle)

        End If

    End Sub

    ' When the canvas is painted (i.e. re-loaded), draw an ellipse on the current draw area
    Private Sub Repaint(sender As Object, e As PaintEventArgs) Handles pbxCanvas.Paint

        ' Check if it's pressed
        If isPressed Then

            ' Declare a solid brush
            Dim myBrush As Brush = New SolidBrush(brushColour)

            ' Fill the current space!
            graphics.FillEllipse(myBrush, drawRectangle)

        End If

    End Sub

#End Region

#Region "mnuFile Event Handlers"

    ''' <summary>
    ''' When the application is opened or when New is selected, set the default image to a white background
    ''' and set the image to be the destination for the .Graphics / .Drawing class
    ''' </summary>
    Private Sub NewFile(sender As Object, e As EventArgs) Handles mnuFileNew.Click, MyBase.Load

        ' Set the background to white
        pbxCanvas.BackColor = Color.White
        ' Set the bitmap we're working on to the size of the pictureBox
        bitmapInstance = New Bitmap(pbxCanvas.Width, pbxCanvas.Height)
        ' Set the pictureBox's Image property equal to the bitmap we're working on
        pbxCanvas.Image = bitmapInstance
        ' Set the destination for the Graphics class to be the bitmap we're working on
        graphics = Graphics.FromImage(bitmapInstance)
        ' Ensure the white background is copied into the base image
        pbxCanvas.DrawToBitmap(bitmapInstance, pbxCanvas.ClientRectangle)

        ' Unset the saved file path and update the form title
        filePath = String.Empty
        UpdateFormTitle()

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click

        If filePath = String.Empty Then

            ' We don't have a file path
            ' This is effectively now a Save As...
            mnuFileSaveAs_Click(sender, e)

        Else

            SaveImageFile(filePath)

        End If

    End Sub

    ''' <summary>
    ''' Saves the canvas to a .bmp file.
    ''' </summary>
    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click

        ' Sets the filter for the save dialog.
        sfdSaveAs.Filter = "Bitmap files (*.bmp)|*.bmp|All files (*.*)|*.*"

        ' If the user selects a file...
        If sfdSaveAs.ShowDialog() = DialogResult.OK Then

            ' Set the new filePath and update the form title
            filePath = sfdSaveAs.FileName
            UpdateFormTitle()

            ' Save the image
            SaveImageFile(filePath)

        End If

    End Sub

    ''' <summary>
    ''' Closes the application
    ''' </summary>
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click

        Me.Close()

    End Sub

#End Region

#Region "mnuEdit Event Handlers"

    ''' <summary>
    ''' Sets the clipboard's contents equal to the canvas' image.
    ''' </summary>
    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click

        Clipboard.SetImage(pbxCanvas.Image)

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Private Sub mnuEditPaste_Click(sender As Object, e As EventArgs) Handles mnuEditPaste.Click

        ' If there's an image on the clipboard, paste it.
        If Clipboard.ContainsImage Then

            pbxCanvas.Image = Clipboard.GetImage

            ' If there is text on the clipboard, write it.
        ElseIf Clipboard.ContainsText Then

            ' Draw the text to the last set cursor position
            graphics.DrawString(Clipboard.GetText, DefaultFont, Brushes.Black, xValue, yValue)
            ' Force the canvas to re-draw itself
            pbxCanvas.Invalidate(pbxCanvas.Region)

        End If

    End Sub

#End Region

#Region "mnuBrush Event Handlers"

    ''' <summary>
    ''' Increment the size of the brush
    ''' </summary>
    Private Sub mnuBrushIncrease_Click(sender As Object, e As EventArgs) Handles mnuBrushIncrease.Click
        brushSize += 1
    End Sub

    ''' <summary>
    ''' Decrement the size of the brush, to a minimum of 1
    ''' </summary>
    Private Sub mnuBrushDecrease_Click(sender As Object, e As EventArgs) Handles mnuBrushDecrease.Click

        If brushSize > 0 Then
            brushSize -= 1
        End If

    End Sub

#Region "mnuBrushColor.Event Handlers"

    ' I'm not commenting all of these.
    ' This could be much neater, probably using an enum or something, but meh.

    Private Sub mnuBrushColourBlack_Click(sender As Object, e As EventArgs) Handles mnuBrushColourBlack.Click
        brushColour = Color.Black
    End Sub

    Private Sub mnuBrushColourBlue_Click(sender As Object, e As EventArgs) Handles mnuBrushColourBlue.Click
        brushColour = Color.Blue
    End Sub

    Private Sub mnuBrushColourBrown_Click(sender As Object, e As EventArgs) Handles mnuBrushColourBrown.Click
        brushColour = Color.Brown
    End Sub

    Private Sub mnuBrushColourGainsboro_Click(sender As Object, e As EventArgs) Handles mnuBrushColourGainsboro.Click
        brushColour = Color.Gainsboro
    End Sub

    Private Sub mnuBrushColourGray_Click(sender As Object, e As EventArgs) Handles mnuBrushColourGray.Click
        brushColour = Color.Gray
    End Sub

    Private Sub mnuBrushColourMintCream_Click(sender As Object, e As EventArgs) Handles mnuBrushColourMintCream.Click
        brushColour = Color.MintCream
    End Sub

    Private Sub mnuBrushColourOrange_Click(sender As Object, e As EventArgs) Handles mnuBrushColourOrange.Click
        brushColour = Color.Orange
    End Sub

    Private Sub mnuBrushColourPurple_Click(sender As Object, e As EventArgs) Handles mnuBrushColourPurple.Click
        brushColour = Color.Purple
    End Sub

    Private Sub mnuBrushColourRed_Click(sender As Object, e As EventArgs) Handles mnuBrushColourRed.Click
        brushColour = Color.Red
    End Sub

    Private Sub mnuBrushColourSalmon_Click(sender As Object, e As EventArgs) Handles mnuBrushColourSalmon.Click
        brushColour = Color.Salmon
    End Sub

    Private Sub mnuBrushColourWhite_Click(sender As Object, e As EventArgs) Handles mnuBrushColourWhite.Click
        brushColour = Color.White
    End Sub

    Private Sub mnuBrushColourYellow_Click(sender As Object, e As EventArgs) Handles mnuBrushColourYellow.Click
        brushColour = Color.Yellow
    End Sub

#End Region
#End Region

#Region "Methods"

    ''' <summary>
    ''' Saves the image file to a specified bitmap file locally
    ''' </summary>
    ''' <param name="path">A full file path as a string</param>
    Friend Sub SaveImageFile(path As String)

        pbxCanvas.Image.Save(path, Imaging.ImageFormat.Bmp)

    End Sub

    ''' <summary>
    ''' Updates the form's title text to include the open file path (or not)
    ''' </summary>
    Friend Sub UpdateFormTitle()

        Me.Text = "Kyle's Whiteboard"

        If Not filePath = String.Empty Then

            Me.Text &= " - " & filePath

        End If

    End Sub

#End Region

End Class
