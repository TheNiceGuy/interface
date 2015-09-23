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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SauvegarderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBoxInventaire = New System.Windows.Forms.GroupBox()
        Me.ButtonISuivant = New System.Windows.Forms.Button()
        Me.ButtonIPrecedent = New System.Windows.Forms.Button()
        Me.LabelIStatut = New System.Windows.Forms.Label()
        Me.CheckBoxIReserve = New System.Windows.Forms.CheckBox()
        Me.TextBoxIParution = New System.Windows.Forms.TextBox()
        Me.LabelIGenre = New System.Windows.Forms.Label()
        Me.TextBoxIGenre = New System.Windows.Forms.TextBox()
        Me.LabelITitre = New System.Windows.Forms.Label()
        Me.LabelIParution = New System.Windows.Forms.Label()
        Me.TextBoxITitre = New System.Windows.Forms.TextBox()
        Me.GroupBoxNouveau = New System.Windows.Forms.GroupBox()
        Me.ButtonNAjouter = New System.Windows.Forms.Button()
        Me.ComboBoxNGenre = New System.Windows.Forms.ComboBox()
        Me.LabelNParution = New System.Windows.Forms.Label()
        Me.LabelNGenre = New System.Windows.Forms.Label()
        Me.LabelNTitre = New System.Windows.Forms.Label()
        Me.TextBoxNParution = New System.Windows.Forms.TextBox()
        Me.TextBoxNTitre = New System.Windows.Forms.TextBox()
        Me.GroupBoxRecherche = New System.Windows.Forms.GroupBox()
        Me.ButtonRRechercher = New System.Windows.Forms.Button()
        Me.LabelRGenre = New System.Windows.Forms.Label()
        Me.ComboBoxRGenre = New System.Windows.Forms.ComboBox()
        Me.ListBoxRResultat = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBoxInventaire.SuspendLayout()
        Me.GroupBoxNouveau.SuspendLayout()
        Me.GroupBoxRecherche.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(436, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirToolStripMenuItem, Me.SauvegarderToolStripMenuItem, Me.ToolStripSeparator1, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.OuvrirToolStripMenuItem.Text = "Ouvrir"
        '
        'SauvegarderToolStripMenuItem
        '
        Me.SauvegarderToolStripMenuItem.Name = "SauvegarderToolStripMenuItem"
        Me.SauvegarderToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.SauvegarderToolStripMenuItem.Text = "Sauvegarder"
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
        'GroupBoxInventaire
        '
        Me.GroupBoxInventaire.Controls.Add(Me.ButtonISuivant)
        Me.GroupBoxInventaire.Controls.Add(Me.ButtonIPrecedent)
        Me.GroupBoxInventaire.Controls.Add(Me.LabelIStatut)
        Me.GroupBoxInventaire.Controls.Add(Me.CheckBoxIReserve)
        Me.GroupBoxInventaire.Controls.Add(Me.TextBoxIParution)
        Me.GroupBoxInventaire.Controls.Add(Me.LabelIGenre)
        Me.GroupBoxInventaire.Controls.Add(Me.TextBoxIGenre)
        Me.GroupBoxInventaire.Controls.Add(Me.LabelITitre)
        Me.GroupBoxInventaire.Controls.Add(Me.LabelIParution)
        Me.GroupBoxInventaire.Controls.Add(Me.TextBoxITitre)
        Me.GroupBoxInventaire.Location = New System.Drawing.Point(13, 32)
        Me.GroupBoxInventaire.Name = "GroupBoxInventaire"
        Me.GroupBoxInventaire.Size = New System.Drawing.Size(411, 164)
        Me.GroupBoxInventaire.TabIndex = 1
        Me.GroupBoxInventaire.TabStop = False
        Me.GroupBoxInventaire.Text = "Inventaire"
        '
        'ButtonISuivant
        '
        Me.ButtonISuivant.Enabled = False
        Me.ButtonISuivant.Location = New System.Drawing.Point(277, 133)
        Me.ButtonISuivant.Name = "ButtonISuivant"
        Me.ButtonISuivant.Size = New System.Drawing.Size(128, 23)
        Me.ButtonISuivant.TabIndex = 9
        Me.ButtonISuivant.Text = "Suivant"
        Me.ButtonISuivant.UseVisualStyleBackColor = True
        '
        'ButtonIPrecedent
        '
        Me.ButtonIPrecedent.Enabled = False
        Me.ButtonIPrecedent.Location = New System.Drawing.Point(138, 133)
        Me.ButtonIPrecedent.Name = "ButtonIPrecedent"
        Me.ButtonIPrecedent.Size = New System.Drawing.Size(128, 23)
        Me.ButtonIPrecedent.TabIndex = 8
        Me.ButtonIPrecedent.Text = "Précédent"
        Me.ButtonIPrecedent.UseVisualStyleBackColor = True
        '
        'LabelIStatut
        '
        Me.LabelIStatut.AutoSize = True
        Me.LabelIStatut.Location = New System.Drawing.Point(84, 107)
        Me.LabelIStatut.Name = "LabelIStatut"
        Me.LabelIStatut.Size = New System.Drawing.Size(45, 17)
        Me.LabelIStatut.TabIndex = 7
        Me.LabelIStatut.Text = "Statut"
        '
        'CheckBoxIReserve
        '
        Me.CheckBoxIReserve.AutoSize = True
        Me.CheckBoxIReserve.Enabled = False
        Me.CheckBoxIReserve.Location = New System.Drawing.Point(138, 106)
        Me.CheckBoxIReserve.Name = "CheckBoxIReserve"
        Me.CheckBoxIReserve.Size = New System.Drawing.Size(83, 21)
        Me.CheckBoxIReserve.TabIndex = 6
        Me.CheckBoxIReserve.Text = "Reservé"
        Me.CheckBoxIReserve.UseVisualStyleBackColor = True
        '
        'TextBoxIParution
        '
        Me.TextBoxIParution.Enabled = False
        Me.TextBoxIParution.Location = New System.Drawing.Point(138, 77)
        Me.TextBoxIParution.Name = "TextBoxIParution"
        Me.TextBoxIParution.Size = New System.Drawing.Size(267, 22)
        Me.TextBoxIParution.TabIndex = 5
        '
        'LabelIGenre
        '
        Me.LabelIGenre.AutoSize = True
        Me.LabelIGenre.Location = New System.Drawing.Point(84, 52)
        Me.LabelIGenre.Name = "LabelIGenre"
        Me.LabelIGenre.Size = New System.Drawing.Size(48, 17)
        Me.LabelIGenre.TabIndex = 4
        Me.LabelIGenre.Text = "Genre"
        '
        'TextBoxIGenre
        '
        Me.TextBoxIGenre.Enabled = False
        Me.TextBoxIGenre.Location = New System.Drawing.Point(138, 49)
        Me.TextBoxIGenre.Name = "TextBoxIGenre"
        Me.TextBoxIGenre.Size = New System.Drawing.Size(267, 22)
        Me.TextBoxIGenre.TabIndex = 3
        '
        'LabelITitre
        '
        Me.LabelITitre.AutoSize = True
        Me.LabelITitre.Location = New System.Drawing.Point(95, 24)
        Me.LabelITitre.Name = "LabelITitre"
        Me.LabelITitre.Size = New System.Drawing.Size(37, 17)
        Me.LabelITitre.TabIndex = 2
        Me.LabelITitre.Text = "Titre"
        '
        'LabelIParution
        '
        Me.LabelIParution.AutoSize = True
        Me.LabelIParution.Location = New System.Drawing.Point(7, 80)
        Me.LabelIParution.Name = "LabelIParution"
        Me.LabelIParution.Size = New System.Drawing.Size(125, 17)
        Me.LabelIParution.TabIndex = 1
        Me.LabelIParution.Text = "Année de parution"
        '
        'TextBoxITitre
        '
        Me.TextBoxITitre.Enabled = False
        Me.TextBoxITitre.Location = New System.Drawing.Point(138, 21)
        Me.TextBoxITitre.Name = "TextBoxITitre"
        Me.TextBoxITitre.Size = New System.Drawing.Size(267, 22)
        Me.TextBoxITitre.TabIndex = 0
        '
        'GroupBoxNouveau
        '
        Me.GroupBoxNouveau.Controls.Add(Me.ButtonNAjouter)
        Me.GroupBoxNouveau.Controls.Add(Me.ComboBoxNGenre)
        Me.GroupBoxNouveau.Controls.Add(Me.LabelNParution)
        Me.GroupBoxNouveau.Controls.Add(Me.LabelNGenre)
        Me.GroupBoxNouveau.Controls.Add(Me.LabelNTitre)
        Me.GroupBoxNouveau.Controls.Add(Me.TextBoxNParution)
        Me.GroupBoxNouveau.Controls.Add(Me.TextBoxNTitre)
        Me.GroupBoxNouveau.Location = New System.Drawing.Point(13, 202)
        Me.GroupBoxNouveau.Name = "GroupBoxNouveau"
        Me.GroupBoxNouveau.Size = New System.Drawing.Size(411, 134)
        Me.GroupBoxNouveau.TabIndex = 2
        Me.GroupBoxNouveau.TabStop = False
        Me.GroupBoxNouveau.Text = "Nouveau"
        '
        'ButtonNAjouter
        '
        Me.ButtonNAjouter.Location = New System.Drawing.Point(277, 103)
        Me.ButtonNAjouter.Name = "ButtonNAjouter"
        Me.ButtonNAjouter.Size = New System.Drawing.Size(128, 23)
        Me.ButtonNAjouter.TabIndex = 10
        Me.ButtonNAjouter.Text = "Ajouter"
        Me.ButtonNAjouter.UseVisualStyleBackColor = True
        '
        'ComboBoxNGenre
        '
        Me.ComboBoxNGenre.FormattingEnabled = True
        Me.ComboBoxNGenre.Items.AddRange(New Object() {"Action", "Comédie", "Horreur", "Drame"})
        Me.ComboBoxNGenre.Location = New System.Drawing.Point(138, 47)
        Me.ComboBoxNGenre.Name = "ComboBoxNGenre"
        Me.ComboBoxNGenre.Size = New System.Drawing.Size(267, 24)
        Me.ComboBoxNGenre.TabIndex = 9
        '
        'LabelNParution
        '
        Me.LabelNParution.AutoSize = True
        Me.LabelNParution.Location = New System.Drawing.Point(7, 78)
        Me.LabelNParution.Name = "LabelNParution"
        Me.LabelNParution.Size = New System.Drawing.Size(125, 17)
        Me.LabelNParution.TabIndex = 6
        Me.LabelNParution.Text = "Année de parution"
        '
        'LabelNGenre
        '
        Me.LabelNGenre.AutoSize = True
        Me.LabelNGenre.Location = New System.Drawing.Point(84, 52)
        Me.LabelNGenre.Name = "LabelNGenre"
        Me.LabelNGenre.Size = New System.Drawing.Size(48, 17)
        Me.LabelNGenre.TabIndex = 6
        Me.LabelNGenre.Text = "Genre"
        '
        'LabelNTitre
        '
        Me.LabelNTitre.AutoSize = True
        Me.LabelNTitre.Location = New System.Drawing.Point(95, 24)
        Me.LabelNTitre.Name = "LabelNTitre"
        Me.LabelNTitre.Size = New System.Drawing.Size(37, 17)
        Me.LabelNTitre.TabIndex = 6
        Me.LabelNTitre.Text = "Titre"
        '
        'TextBoxNParution
        '
        Me.TextBoxNParution.Location = New System.Drawing.Point(138, 75)
        Me.TextBoxNParution.Name = "TextBoxNParution"
        Me.TextBoxNParution.Size = New System.Drawing.Size(267, 22)
        Me.TextBoxNParution.TabIndex = 8
        '
        'TextBoxNTitre
        '
        Me.TextBoxNTitre.Location = New System.Drawing.Point(138, 21)
        Me.TextBoxNTitre.Name = "TextBoxNTitre"
        Me.TextBoxNTitre.Size = New System.Drawing.Size(267, 22)
        Me.TextBoxNTitre.TabIndex = 6
        '
        'GroupBoxRecherche
        '
        Me.GroupBoxRecherche.Controls.Add(Me.ListBoxRResultat)
        Me.GroupBoxRecherche.Controls.Add(Me.ButtonRRechercher)
        Me.GroupBoxRecherche.Controls.Add(Me.LabelRGenre)
        Me.GroupBoxRecherche.Controls.Add(Me.ComboBoxRGenre)
        Me.GroupBoxRecherche.Location = New System.Drawing.Point(13, 342)
        Me.GroupBoxRecherche.Name = "GroupBoxRecherche"
        Me.GroupBoxRecherche.Size = New System.Drawing.Size(411, 254)
        Me.GroupBoxRecherche.TabIndex = 3
        Me.GroupBoxRecherche.TabStop = False
        Me.GroupBoxRecherche.Text = "Recherche"
        '
        'ButtonRRechercher
        '
        Me.ButtonRRechercher.Location = New System.Drawing.Point(277, 51)
        Me.ButtonRRechercher.Name = "ButtonRRechercher"
        Me.ButtonRRechercher.Size = New System.Drawing.Size(128, 23)
        Me.ButtonRRechercher.TabIndex = 11
        Me.ButtonRRechercher.Text = "Rechercher"
        Me.ButtonRRechercher.UseVisualStyleBackColor = True
        '
        'LabelRGenre
        '
        Me.LabelRGenre.AutoSize = True
        Me.LabelRGenre.Location = New System.Drawing.Point(84, 24)
        Me.LabelRGenre.Name = "LabelRGenre"
        Me.LabelRGenre.Size = New System.Drawing.Size(48, 17)
        Me.LabelRGenre.TabIndex = 10
        Me.LabelRGenre.Text = "Genre"
        '
        'ComboBoxRGenre
        '
        Me.ComboBoxRGenre.FormattingEnabled = True
        Me.ComboBoxRGenre.Items.AddRange(New Object() {"Action", "Comédie", "Horreur", "Drame"})
        Me.ComboBoxRGenre.Location = New System.Drawing.Point(138, 21)
        Me.ComboBoxRGenre.Name = "ComboBoxRGenre"
        Me.ComboBoxRGenre.Size = New System.Drawing.Size(267, 24)
        Me.ComboBoxRGenre.TabIndex = 10
        '
        'ListBoxRResultat
        '
        Me.ListBoxRResultat.FormattingEnabled = True
        Me.ListBoxRResultat.ItemHeight = 16
        Me.ListBoxRResultat.Location = New System.Drawing.Point(138, 81)
        Me.ListBoxRResultat.Name = "ListBoxRResultat"
        Me.ListBoxRResultat.Size = New System.Drawing.Size(267, 164)
        Me.ListBoxRResultat.TabIndex = 12
        '
        'Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 608)
        Me.Controls.Add(Me.GroupBoxRecherche)
        Me.Controls.Add(Me.GroupBoxNouveau)
        Me.Controls.Add(Me.GroupBoxInventaire)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Window"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBoxInventaire.ResumeLayout(False)
        Me.GroupBoxInventaire.PerformLayout()
        Me.GroupBoxNouveau.ResumeLayout(False)
        Me.GroupBoxNouveau.PerformLayout()
        Me.GroupBoxRecherche.ResumeLayout(False)
        Me.GroupBoxRecherche.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SauvegarderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBoxInventaire As GroupBox
    Friend WithEvents ButtonISuivant As Button
    Friend WithEvents ButtonIPrecedent As Button
    Friend WithEvents LabelIStatut As Label
    Friend WithEvents CheckBoxIReserve As CheckBox
    Friend WithEvents TextBoxIParution As TextBox
    Friend WithEvents LabelIGenre As Label
    Friend WithEvents TextBoxIGenre As TextBox
    Friend WithEvents LabelITitre As Label
    Friend WithEvents LabelIParution As Label
    Friend WithEvents TextBoxITitre As TextBox
    Friend WithEvents GroupBoxNouveau As GroupBox
    Friend WithEvents ButtonNAjouter As Button
    Friend WithEvents ComboBoxNGenre As ComboBox
    Friend WithEvents LabelNParution As Label
    Friend WithEvents LabelNGenre As Label
    Friend WithEvents LabelNTitre As Label
    Friend WithEvents TextBoxNParution As TextBox
    Friend WithEvents TextBoxNTitre As TextBox
    Friend WithEvents GroupBoxRecherche As GroupBox
    Friend WithEvents ButtonRRechercher As Button
    Friend WithEvents LabelRGenre As Label
    Friend WithEvents ComboBoxRGenre As ComboBox
    Friend WithEvents ListBoxRResultat As ListBox
End Class
