<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Window
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
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SauvegarderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonPrecedent = New System.Windows.Forms.Button()
        Me.LabelCourriel = New System.Windows.Forms.Label()
        Me.TextBoxCourriel = New System.Windows.Forms.TextBox()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.TextBoxPrenom = New System.Windows.Forms.TextBox()
        Me.ButtonSuivant = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Location = New System.Drawing.Point(76, 59)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(184, 22)
        Me.TextBoxNom.TabIndex = 11
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(271, 28)
        Me.MenuStrip.TabIndex = 8
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SauvegarderToolStripMenuItem, Me.ToolStripSeparator1, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'SauvegarderToolStripMenuItem
        '
        Me.SauvegarderToolStripMenuItem.Name = "SauvegarderToolStripMenuItem"
        Me.SauvegarderToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.SauvegarderToolStripMenuItem.Text = "Ouvrir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'ButtonPrecedent
        '
        Me.ButtonPrecedent.Location = New System.Drawing.Point(76, 115)
        Me.ButtonPrecedent.Name = "ButtonPrecedent"
        Me.ButtonPrecedent.Size = New System.Drawing.Size(184, 23)
        Me.ButtonPrecedent.TabIndex = 15
        Me.ButtonPrecedent.Text = "Précedent"
        Me.ButtonPrecedent.UseVisualStyleBackColor = True
        '
        'LabelCourriel
        '
        Me.LabelCourriel.AutoSize = True
        Me.LabelCourriel.Location = New System.Drawing.Point(13, 90)
        Me.LabelCourriel.Name = "LabelCourriel"
        Me.LabelCourriel.Size = New System.Drawing.Size(57, 17)
        Me.LabelCourriel.TabIndex = 14
        Me.LabelCourriel.Text = "Courriel"
        '
        'TextBoxCourriel
        '
        Me.TextBoxCourriel.Location = New System.Drawing.Point(76, 87)
        Me.TextBoxCourriel.Name = "TextBoxCourriel"
        Me.TextBoxCourriel.Size = New System.Drawing.Size(184, 22)
        Me.TextBoxCourriel.TabIndex = 13
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(33, 62)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(37, 17)
        Me.LabelNom.TabIndex = 12
        Me.LabelNom.Text = "Nom"
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Location = New System.Drawing.Point(13, 34)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(57, 17)
        Me.LabelPrenom.TabIndex = 10
        Me.LabelPrenom.Text = "Prénom"
        '
        'TextBoxPrenom
        '
        Me.TextBoxPrenom.Location = New System.Drawing.Point(76, 31)
        Me.TextBoxPrenom.Name = "TextBoxPrenom"
        Me.TextBoxPrenom.Size = New System.Drawing.Size(184, 22)
        Me.TextBoxPrenom.TabIndex = 9
        '
        'ButtonSuivant
        '
        Me.ButtonSuivant.Location = New System.Drawing.Point(76, 144)
        Me.ButtonSuivant.Name = "ButtonSuivant"
        Me.ButtonSuivant.Size = New System.Drawing.Size(184, 23)
        Me.ButtonSuivant.TabIndex = 16
        Me.ButtonSuivant.Text = "Suivant"
        Me.ButtonSuivant.UseVisualStyleBackColor = True
        '
        'Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 178)
        Me.Controls.Add(Me.ButtonSuivant)
        Me.Controls.Add(Me.TextBoxNom)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.ButtonPrecedent)
        Me.Controls.Add(Me.LabelCourriel)
        Me.Controls.Add(Me.TextBoxCourriel)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.LabelPrenom)
        Me.Controls.Add(Me.TextBoxPrenom)
        Me.Name = "Window"
        Me.Text = "Window"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SauvegarderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonPrecedent As Button
    Friend WithEvents LabelCourriel As Label
    Friend WithEvents TextBoxCourriel As TextBox
    Friend WithEvents LabelNom As Label
    Friend WithEvents LabelPrenom As Label
    Friend WithEvents TextBoxPrenom As TextBox
    Friend WithEvents ButtonSuivant As Button
End Class
