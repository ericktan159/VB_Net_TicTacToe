<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.A1 = New System.Windows.Forms.Button()
        Me.A3 = New System.Windows.Forms.Button()
        Me.A2 = New System.Windows.Forms.Button()
        Me.C2 = New System.Windows.Forms.Button()
        Me.C3 = New System.Windows.Forms.Button()
        Me.C1 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.B1 = New System.Windows.Forms.Button()
        Me.player_1_Score_lbl = New System.Windows.Forms.Label()
        Me.player_2_Score_lbl = New System.Windows.Forms.Label()
        Me.playersTurnLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'A1
        '
        Me.A1.Location = New System.Drawing.Point(4, 98)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(74, 75)
        Me.A1.TabIndex = 0
        Me.A1.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.Location = New System.Drawing.Point(164, 98)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(74, 75)
        Me.A3.TabIndex = 1
        Me.A3.UseVisualStyleBackColor = True
        '
        'A2
        '
        Me.A2.Location = New System.Drawing.Point(84, 98)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(74, 75)
        Me.A2.TabIndex = 2
        Me.A2.UseVisualStyleBackColor = True
        '
        'C2
        '
        Me.C2.Location = New System.Drawing.Point(84, 260)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(74, 75)
        Me.C2.TabIndex = 5
        Me.C2.UseVisualStyleBackColor = True
        '
        'C3
        '
        Me.C3.Location = New System.Drawing.Point(164, 260)
        Me.C3.Name = "C3"
        Me.C3.Size = New System.Drawing.Size(74, 75)
        Me.C3.TabIndex = 4
        Me.C3.UseVisualStyleBackColor = True
        '
        'C1
        '
        Me.C1.Location = New System.Drawing.Point(4, 260)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(74, 75)
        Me.C1.TabIndex = 3
        Me.C1.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.Location = New System.Drawing.Point(84, 179)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(74, 75)
        Me.B2.TabIndex = 8
        Me.B2.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.Location = New System.Drawing.Point(164, 179)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(74, 75)
        Me.B3.TabIndex = 7
        Me.B3.UseVisualStyleBackColor = True
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(4, 179)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(74, 75)
        Me.B1.TabIndex = 6
        Me.B1.UseVisualStyleBackColor = True
        '
        'player_1_Score_lbl
        '
        Me.player_1_Score_lbl.AutoSize = True
        Me.player_1_Score_lbl.Location = New System.Drawing.Point(11, 34)
        Me.player_1_Score_lbl.Name = "player_1_Score_lbl"
        Me.player_1_Score_lbl.Size = New System.Drawing.Size(41, 15)
        Me.player_1_Score_lbl.TabIndex = 9
        Me.player_1_Score_lbl.Text = "Label1"
        '
        'player_2_Score_lbl
        '
        Me.player_2_Score_lbl.AutoSize = True
        Me.player_2_Score_lbl.Location = New System.Drawing.Point(12, 57)
        Me.player_2_Score_lbl.Name = "player_2_Score_lbl"
        Me.player_2_Score_lbl.Size = New System.Drawing.Size(41, 15)
        Me.player_2_Score_lbl.TabIndex = 10
        Me.player_2_Score_lbl.Text = "Label2"
        '
        'playersTurnLabel
        '
        Me.playersTurnLabel.AutoSize = True
        Me.playersTurnLabel.Location = New System.Drawing.Point(12, 349)
        Me.playersTurnLabel.Name = "playersTurnLabel"
        Me.playersTurnLabel.Size = New System.Drawing.Size(41, 15)
        Me.playersTurnLabel.TabIndex = 11
        Me.playersTurnLabel.Text = "Label3"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(270, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.NewGameToolStripMenuItem.Text = "New Game"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 376)
        Me.Controls.Add(Me.playersTurnLabel)
        Me.Controls.Add(Me.player_2_Score_lbl)
        Me.Controls.Add(Me.player_1_Score_lbl)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.C2)
        Me.Controls.Add(Me.C3)
        Me.Controls.Add(Me.C1)
        Me.Controls.Add(Me.A2)
        Me.Controls.Add(Me.A3)
        Me.Controls.Add(Me.A1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents A1 As Button
    Friend WithEvents A3 As Button
    Friend WithEvents A2 As Button
    Friend WithEvents C2 As Button
    Friend WithEvents C3 As Button
    Friend WithEvents C1 As Button
    Friend WithEvents B2 As Button
    Friend WithEvents B3 As Button
    Friend WithEvents B1 As Button
    Friend WithEvents player_1_Score_lbl As Label
    Friend WithEvents player_2_Score_lbl As Label
    Friend WithEvents playersTurnLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
