<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBoxMultiline = New System.Windows.Forms.TextBox()
        Me.ButtonChercher = New System.Windows.Forms.Button()
        Me.TextBoxChercher = New System.Windows.Forms.TextBox()
        Me.ButtonRemplacer = New System.Windows.Forms.Button()
        Me.TextBoxRemplacer = New System.Windows.Forms.TextBox()
        Me.TextBoxRemplacerPar = New System.Windows.Forms.TextBox()
        Me.ButtonCompter = New System.Windows.Forms.Button()
        Me.TextBoxCompter = New System.Windows.Forms.TextBox()
        Me.ButtonPlusLong = New System.Windows.Forms.Button()
        Me.ButtonTaille = New System.Windows.Forms.Button()
        Me.ButtonMajuscule = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxMultiline
        '
        Me.TextBoxMultiline.Location = New System.Drawing.Point(12, 31)
        Me.TextBoxMultiline.Multiline = True
        Me.TextBoxMultiline.Name = "TextBoxMultiline"
        Me.TextBoxMultiline.Size = New System.Drawing.Size(409, 210)
        Me.TextBoxMultiline.TabIndex = 0
        '
        'ButtonChercher
        '
        Me.ButtonChercher.Location = New System.Drawing.Point(12, 247)
        Me.ButtonChercher.Name = "ButtonChercher"
        Me.ButtonChercher.Size = New System.Drawing.Size(147, 23)
        Me.ButtonChercher.TabIndex = 1
        Me.ButtonChercher.Text = "Chercher"
        Me.ButtonChercher.UseVisualStyleBackColor = True
        '
        'TextBoxChercher
        '
        Me.TextBoxChercher.Location = New System.Drawing.Point(164, 248)
        Me.TextBoxChercher.Name = "TextBoxChercher"
        Me.TextBoxChercher.Size = New System.Drawing.Size(257, 22)
        Me.TextBoxChercher.TabIndex = 2
        '
        'ButtonRemplacer
        '
        Me.ButtonRemplacer.Location = New System.Drawing.Point(11, 276)
        Me.ButtonRemplacer.Name = "ButtonRemplacer"
        Me.ButtonRemplacer.Size = New System.Drawing.Size(148, 23)
        Me.ButtonRemplacer.TabIndex = 3
        Me.ButtonRemplacer.Text = "Remplacer X par Y"
        Me.ButtonRemplacer.UseVisualStyleBackColor = True
        '
        'TextBoxRemplacer
        '
        Me.TextBoxRemplacer.Location = New System.Drawing.Point(164, 276)
        Me.TextBoxRemplacer.Name = "TextBoxRemplacer"
        Me.TextBoxRemplacer.Size = New System.Drawing.Size(257, 22)
        Me.TextBoxRemplacer.TabIndex = 4
        '
        'TextBoxRemplacerPar
        '
        Me.TextBoxRemplacerPar.Location = New System.Drawing.Point(164, 304)
        Me.TextBoxRemplacerPar.Name = "TextBoxRemplacerPar"
        Me.TextBoxRemplacerPar.Size = New System.Drawing.Size(257, 22)
        Me.TextBoxRemplacerPar.TabIndex = 5
        '
        'ButtonCompter
        '
        Me.ButtonCompter.Location = New System.Drawing.Point(11, 333)
        Me.ButtonCompter.Name = "ButtonCompter"
        Me.ButtonCompter.Size = New System.Drawing.Size(148, 23)
        Me.ButtonCompter.TabIndex = 6
        Me.ButtonCompter.Text = "Compter"
        Me.ButtonCompter.UseVisualStyleBackColor = True
        '
        'TextBoxCompter
        '
        Me.TextBoxCompter.Location = New System.Drawing.Point(164, 333)
        Me.TextBoxCompter.Name = "TextBoxCompter"
        Me.TextBoxCompter.Size = New System.Drawing.Size(257, 22)
        Me.TextBoxCompter.TabIndex = 7
        '
        'ButtonPlusLong
        '
        Me.ButtonPlusLong.Location = New System.Drawing.Point(12, 362)
        Me.ButtonPlusLong.Name = "ButtonPlusLong"
        Me.ButtonPlusLong.Size = New System.Drawing.Size(148, 23)
        Me.ButtonPlusLong.TabIndex = 8
        Me.ButtonPlusLong.Text = "Mot le plus long"
        Me.ButtonPlusLong.UseVisualStyleBackColor = True
        '
        'ButtonTaille
        '
        Me.ButtonTaille.Location = New System.Drawing.Point(12, 391)
        Me.ButtonTaille.Name = "ButtonTaille"
        Me.ButtonTaille.Size = New System.Drawing.Size(148, 23)
        Me.ButtonTaille.TabIndex = 9
        Me.ButtonTaille.Text = "Taille"
        Me.ButtonTaille.UseVisualStyleBackColor = True
        '
        'ButtonMajuscule
        '
        Me.ButtonMajuscule.Location = New System.Drawing.Point(12, 420)
        Me.ButtonMajuscule.Name = "ButtonMajuscule"
        Me.ButtonMajuscule.Size = New System.Drawing.Size(148, 23)
        Me.ButtonMajuscule.TabIndex = 10
        Me.ButtonMajuscule.Text = "Majuscules!"
        Me.ButtonMajuscule.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(433, 28)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.toolStripSeparator, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.toolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(178, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 455)
        Me.Controls.Add(Me.ButtonMajuscule)
        Me.Controls.Add(Me.ButtonTaille)
        Me.Controls.Add(Me.ButtonPlusLong)
        Me.Controls.Add(Me.TextBoxCompter)
        Me.Controls.Add(Me.ButtonCompter)
        Me.Controls.Add(Me.TextBoxRemplacerPar)
        Me.Controls.Add(Me.TextBoxRemplacer)
        Me.Controls.Add(Me.ButtonRemplacer)
        Me.Controls.Add(Me.TextBoxChercher)
        Me.Controls.Add(Me.ButtonChercher)
        Me.Controls.Add(Me.TextBoxMultiline)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxMultiline As TextBox
    Friend WithEvents ButtonChercher As Button
    Friend WithEvents TextBoxChercher As TextBox
    Friend WithEvents ButtonRemplacer As Button
    Friend WithEvents TextBoxRemplacer As TextBox
    Friend WithEvents TextBoxRemplacerPar As TextBox
    Friend WithEvents ButtonCompter As Button
    Friend WithEvents TextBoxCompter As TextBox
    Friend WithEvents ButtonPlusLong As Button
    Friend WithEvents ButtonTaille As Button
    Friend WithEvents ButtonMajuscule As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
