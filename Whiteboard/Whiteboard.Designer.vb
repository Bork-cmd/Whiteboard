<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWhiteboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.mnuTopMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrush = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushIncrease = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushDecrease = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColour = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourBlack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourBlue = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourBrown = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourGainsboro = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourGray = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourMintCream = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourOrange = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourPurple = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourRed = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourSalmon = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourWhite = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourYellow = New System.Windows.Forms.ToolStripMenuItem()
        Me.sfdSaveAs = New System.Windows.Forms.SaveFileDialog()
        Me.pbxCanvas = New System.Windows.Forms.PictureBox()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopMenu.SuspendLayout()
        CType(Me.pbxCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuTopMenu
        '
        Me.mnuTopMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuBrush})
        Me.mnuTopMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuTopMenu.Name = "mnuTopMenu"
        Me.mnuTopMenu.Size = New System.Drawing.Size(384, 24)
        Me.mnuTopMenu.TabIndex = 0
        Me.mnuTopMenu.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileSave, Me.mnuFileSaveAs, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuFileNew.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileNew.Text = "&New"
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileSaveAs.Text = "Save &As..."
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditCopy, Me.mnuEditPaste})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuEditCopy
        '
        Me.mnuEditCopy.Name = "mnuEditCopy"
        Me.mnuEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuEditCopy.Size = New System.Drawing.Size(152, 22)
        Me.mnuEditCopy.Text = "&Copy"
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuEditPaste.Size = New System.Drawing.Size(152, 22)
        Me.mnuEditPaste.Text = "&Paste"
        '
        'mnuBrush
        '
        Me.mnuBrush.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBrushIncrease, Me.mnuBrushDecrease, Me.mnuBrushColour})
        Me.mnuBrush.Name = "mnuBrush"
        Me.mnuBrush.Size = New System.Drawing.Size(49, 20)
        Me.mnuBrush.Text = "&Brush"
        '
        'mnuBrushIncrease
        '
        Me.mnuBrushIncrease.Name = "mnuBrushIncrease"
        Me.mnuBrushIncrease.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.mnuBrushIncrease.Size = New System.Drawing.Size(209, 22)
        Me.mnuBrushIncrease.Text = "&Increase Size"
        '
        'mnuBrushDecrease
        '
        Me.mnuBrushDecrease.Name = "mnuBrushDecrease"
        Me.mnuBrushDecrease.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.mnuBrushDecrease.Size = New System.Drawing.Size(209, 22)
        Me.mnuBrushDecrease.Text = "&Decrease Size"
        '
        'mnuBrushColour
        '
        Me.mnuBrushColour.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBrushColourBlack, Me.mnuBrushColourBlue, Me.mnuBrushColourBrown, Me.mnuBrushColourGainsboro, Me.mnuBrushColourGray, Me.mnuBrushColourMintCream, Me.mnuBrushColourOrange, Me.mnuBrushColourPurple, Me.mnuBrushColourRed, Me.mnuBrushColourSalmon, Me.mnuBrushColourWhite, Me.mnuBrushColourYellow})
        Me.mnuBrushColour.Name = "mnuBrushColour"
        Me.mnuBrushColour.Size = New System.Drawing.Size(209, 22)
        Me.mnuBrushColour.Text = "&Colour"
        '
        'mnuBrushColourBlack
        '
        Me.mnuBrushColourBlack.Name = "mnuBrushColourBlack"
        Me.mnuBrushColourBlack.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnuBrushColourBlack.Size = New System.Drawing.Size(152, 22)
        Me.mnuBrushColourBlack.Text = "Black"
        '
        'mnuBrushColourBlue
        '
        Me.mnuBrushColourBlue.Name = "mnuBrushColourBlue"
        Me.mnuBrushColourBlue.Size = New System.Drawing.Size(152, 22)
        Me.mnuBrushColourBlue.Text = "Blue"
        '
        'mnuBrushColourBrown
        '
        Me.mnuBrushColourBrown.Name = "mnuBrushColourBrown"
        Me.mnuBrushColourBrown.Size = New System.Drawing.Size(152, 22)
        Me.mnuBrushColourBrown.Text = "Brown"
        '
        'mnuBrushColourGainsboro
        '
        Me.mnuBrushColourGainsboro.Name = "mnuBrushColourGainsboro"
        Me.mnuBrushColourGainsboro.Size = New System.Drawing.Size(152, 22)
        Me.mnuBrushColourGainsboro.Text = "Gainsboro"
        '
        'mnuBrushColourGray
        '
        Me.mnuBrushColourGray.Name = "mnuBrushColourGray"
        Me.mnuBrushColourGray.Size = New System.Drawing.Size(152, 22)
        Me.mnuBrushColourGray.Text = "Gray"
        '
        'mnuBrushColourMintCream
        '
        Me.mnuBrushColourMintCream.Name = "mnuBrushColourMintCream"
        Me.mnuBrushColourMintCream.Size = New System.Drawing.Size(152, 22)
        Me.mnuBrushColourMintCream.Text = "MintCream"
        '
        'mnuBrushColourOrange
        '
        Me.mnuBrushColourOrange.Name = "mnuBrushColourOrange"
        Me.mnuBrushColourOrange.Size = New System.Drawing.Size(152, 22)
        Me.mnuBrushColourOrange.Text = "Orange"
        '
        'mnuBrushColourPurple
        '
        Me.mnuBrushColourPurple.Name = "mnuBrushColourPurple"
        Me.mnuBrushColourPurple.Size = New System.Drawing.Size(152, 22)
        Me.mnuBrushColourPurple.Text = "Purple"
        '
        'mnuBrushColourRed
        '
        Me.mnuBrushColourRed.Name = "mnuBrushColourRed"
        Me.mnuBrushColourRed.Size = New System.Drawing.Size(152, 22)
        Me.mnuBrushColourRed.Text = "Red"
        '
        'mnuBrushColourSalmon
        '
        Me.mnuBrushColourSalmon.Name = "mnuBrushColourSalmon"
        Me.mnuBrushColourSalmon.Size = New System.Drawing.Size(152, 22)
        Me.mnuBrushColourSalmon.Text = "Salmon"
        '
        'mnuBrushColourWhite
        '
        Me.mnuBrushColourWhite.Name = "mnuBrushColourWhite"
        Me.mnuBrushColourWhite.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.mnuBrushColourWhite.Size = New System.Drawing.Size(152, 22)
        Me.mnuBrushColourWhite.Text = "White"
        '
        'mnuBrushColourYellow
        '
        Me.mnuBrushColourYellow.Name = "mnuBrushColourYellow"
        Me.mnuBrushColourYellow.Size = New System.Drawing.Size(152, 22)
        Me.mnuBrushColourYellow.Text = "Yellow"
        '
        'pbxCanvas
        '
        Me.pbxCanvas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxCanvas.Location = New System.Drawing.Point(0, 24)
        Me.pbxCanvas.Name = "pbxCanvas"
        Me.pbxCanvas.Size = New System.Drawing.Size(384, 237)
        Me.pbxCanvas.TabIndex = 1
        Me.pbxCanvas.TabStop = False
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileSave.Text = "&Save"
        '
        'frmWhiteboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(384, 261)
        Me.Controls.Add(Me.pbxCanvas)
        Me.Controls.Add(Me.mnuTopMenu)
        Me.MainMenuStrip = Me.mnuTopMenu
        Me.Name = "frmWhiteboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kyle's Whiteboard"
        Me.mnuTopMenu.ResumeLayout(False)
        Me.mnuTopMenu.PerformLayout()
        CType(Me.pbxCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuTopMenu As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileNew As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAs As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuEditPaste As ToolStripMenuItem
    Friend WithEvents mnuBrush As ToolStripMenuItem
    Friend WithEvents mnuBrushIncrease As ToolStripMenuItem
    Friend WithEvents mnuBrushDecrease As ToolStripMenuItem
    Friend WithEvents mnuBrushColour As ToolStripMenuItem
    Friend WithEvents mnuBrushColourBlack As ToolStripMenuItem
    Friend WithEvents mnuBrushColourBlue As ToolStripMenuItem
    Friend WithEvents mnuBrushColourBrown As ToolStripMenuItem
    Friend WithEvents mnuBrushColourGainsboro As ToolStripMenuItem
    Friend WithEvents mnuBrushColourGray As ToolStripMenuItem
    Friend WithEvents mnuBrushColourMintCream As ToolStripMenuItem
    Friend WithEvents mnuBrushColourOrange As ToolStripMenuItem
    Friend WithEvents mnuBrushColourPurple As ToolStripMenuItem
    Friend WithEvents mnuBrushColourRed As ToolStripMenuItem
    Friend WithEvents mnuBrushColourSalmon As ToolStripMenuItem
    Friend WithEvents mnuBrushColourWhite As ToolStripMenuItem
    Friend WithEvents mnuBrushColourYellow As ToolStripMenuItem
    Friend WithEvents sfdSaveAs As SaveFileDialog
    Friend WithEvents mnuEditCopy As ToolStripMenuItem
    Friend WithEvents pbxCanvas As PictureBox
    Friend WithEvents mnuFileSave As ToolStripMenuItem
End Class
