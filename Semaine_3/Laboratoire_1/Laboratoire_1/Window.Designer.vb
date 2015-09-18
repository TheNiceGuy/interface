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
        Me.GroupBoxNouveau = New System.Windows.Forms.GroupBox()
        Me.ComboBoxNCategorie = New System.Windows.Forms.ComboBox()
        Me.ButtonNAjouter = New System.Windows.Forms.Button()
        Me.TextBoxNQuantite = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNNom = New System.Windows.Forms.TextBox()
        Me.LabelNCategorie = New System.Windows.Forms.Label()
        Me.LabelNNom = New System.Windows.Forms.Label()
        Me.GroupBoxRecherche = New System.Windows.Forms.GroupBox()
        Me.ButtonRRechercher = New System.Windows.Forms.Button()
        Me.TextBoxRQuantite = New System.Windows.Forms.TextBox()
        Me.TextBoxRCategorie = New System.Windows.Forms.TextBox()
        Me.TextBoxRElement = New System.Windows.Forms.TextBox()
        Me.LabelRQuantite = New System.Windows.Forms.Label()
        Me.LabelRCategorie = New System.Windows.Forms.Label()
        Me.LabelRElement = New System.Windows.Forms.Label()
        Me.GroupBoxAffichage = New System.Windows.Forms.GroupBox()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.TextBoxProduit = New System.Windows.Forms.TextBox()
        Me.ButtonAAfficher = New System.Windows.Forms.Button()
        Me.ComboBoxACategorie = New System.Windows.Forms.ComboBox()
        Me.LabelACategorie = New System.Windows.Forms.Label()
        Me.GroupBoxNouveau.SuspendLayout()
        Me.GroupBoxRecherche.SuspendLayout()
        Me.GroupBoxAffichage.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxNouveau
        '
        Me.GroupBoxNouveau.Controls.Add(Me.ComboBoxNCategorie)
        Me.GroupBoxNouveau.Controls.Add(Me.ButtonNAjouter)
        Me.GroupBoxNouveau.Controls.Add(Me.TextBoxNQuantite)
        Me.GroupBoxNouveau.Controls.Add(Me.Label1)
        Me.GroupBoxNouveau.Controls.Add(Me.TextBoxNNom)
        Me.GroupBoxNouveau.Controls.Add(Me.LabelNCategorie)
        Me.GroupBoxNouveau.Controls.Add(Me.LabelNNom)
        Me.GroupBoxNouveau.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxNouveau.Name = "GroupBoxNouveau"
        Me.GroupBoxNouveau.Size = New System.Drawing.Size(447, 110)
        Me.GroupBoxNouveau.TabIndex = 0
        Me.GroupBoxNouveau.TabStop = False
        Me.GroupBoxNouveau.Text = "Nouveau"
        '
        'ComboBoxNCategorie
        '
        Me.ComboBoxNCategorie.FormattingEnabled = True
        Me.ComboBoxNCategorie.Items.AddRange(New Object() {"Alimentaire", "Informatique", "Sport", "Meuble"})
        Me.ComboBoxNCategorie.Location = New System.Drawing.Point(74, 50)
        Me.ComboBoxNCategorie.Name = "ComboBoxNCategorie"
        Me.ComboBoxNCategorie.Size = New System.Drawing.Size(193, 24)
        Me.ComboBoxNCategorie.TabIndex = 14
        '
        'ButtonNAjouter
        '
        Me.ButtonNAjouter.Location = New System.Drawing.Point(274, 22)
        Me.ButtonNAjouter.Name = "ButtonNAjouter"
        Me.ButtonNAjouter.Size = New System.Drawing.Size(166, 23)
        Me.ButtonNAjouter.TabIndex = 6
        Me.ButtonNAjouter.Text = "Ajouter"
        Me.ButtonNAjouter.UseVisualStyleBackColor = True
        '
        'TextBoxNQuantite
        '
        Me.TextBoxNQuantite.Location = New System.Drawing.Point(74, 80)
        Me.TextBoxNQuantite.Name = "TextBoxNQuantite"
        Me.TextBoxNQuantite.Size = New System.Drawing.Size(193, 22)
        Me.TextBoxNQuantite.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Quantité"
        '
        'TextBoxNNom
        '
        Me.TextBoxNNom.Location = New System.Drawing.Point(74, 22)
        Me.TextBoxNNom.Name = "TextBoxNNom"
        Me.TextBoxNNom.Size = New System.Drawing.Size(193, 22)
        Me.TextBoxNNom.TabIndex = 2
        '
        'LabelNCategorie
        '
        Me.LabelNCategorie.AutoSize = True
        Me.LabelNCategorie.Location = New System.Drawing.Point(6, 53)
        Me.LabelNCategorie.Name = "LabelNCategorie"
        Me.LabelNCategorie.Size = New System.Drawing.Size(69, 17)
        Me.LabelNCategorie.TabIndex = 1
        Me.LabelNCategorie.Text = "Catégorie"
        '
        'LabelNNom
        '
        Me.LabelNNom.AutoSize = True
        Me.LabelNNom.Location = New System.Drawing.Point(6, 25)
        Me.LabelNNom.Name = "LabelNNom"
        Me.LabelNNom.Size = New System.Drawing.Size(37, 17)
        Me.LabelNNom.TabIndex = 0
        Me.LabelNNom.Text = "Nom"
        '
        'GroupBoxRecherche
        '
        Me.GroupBoxRecherche.Controls.Add(Me.ButtonRRechercher)
        Me.GroupBoxRecherche.Controls.Add(Me.TextBoxRQuantite)
        Me.GroupBoxRecherche.Controls.Add(Me.TextBoxRCategorie)
        Me.GroupBoxRecherche.Controls.Add(Me.TextBoxRElement)
        Me.GroupBoxRecherche.Controls.Add(Me.LabelRQuantite)
        Me.GroupBoxRecherche.Controls.Add(Me.LabelRCategorie)
        Me.GroupBoxRecherche.Controls.Add(Me.LabelRElement)
        Me.GroupBoxRecherche.Location = New System.Drawing.Point(11, 128)
        Me.GroupBoxRecherche.Name = "GroupBoxRecherche"
        Me.GroupBoxRecherche.Size = New System.Drawing.Size(448, 112)
        Me.GroupBoxRecherche.TabIndex = 1
        Me.GroupBoxRecherche.TabStop = False
        Me.GroupBoxRecherche.Text = "Recherche"
        '
        'ButtonRRechercher
        '
        Me.ButtonRRechercher.Location = New System.Drawing.Point(275, 21)
        Me.ButtonRRechercher.Name = "ButtonRRechercher"
        Me.ButtonRRechercher.Size = New System.Drawing.Size(166, 23)
        Me.ButtonRRechercher.TabIndex = 7
        Me.ButtonRRechercher.Text = "Rechercher"
        Me.ButtonRRechercher.UseVisualStyleBackColor = True
        '
        'TextBoxRQuantite
        '
        Me.TextBoxRQuantite.Location = New System.Drawing.Point(75, 77)
        Me.TextBoxRQuantite.Name = "TextBoxRQuantite"
        Me.TextBoxRQuantite.ReadOnly = True
        Me.TextBoxRQuantite.Size = New System.Drawing.Size(193, 22)
        Me.TextBoxRQuantite.TabIndex = 10
        '
        'TextBoxRCategorie
        '
        Me.TextBoxRCategorie.Location = New System.Drawing.Point(75, 49)
        Me.TextBoxRCategorie.Name = "TextBoxRCategorie"
        Me.TextBoxRCategorie.ReadOnly = True
        Me.TextBoxRCategorie.Size = New System.Drawing.Size(193, 22)
        Me.TextBoxRCategorie.TabIndex = 9
        '
        'TextBoxRElement
        '
        Me.TextBoxRElement.Location = New System.Drawing.Point(75, 21)
        Me.TextBoxRElement.Name = "TextBoxRElement"
        Me.TextBoxRElement.Size = New System.Drawing.Size(193, 22)
        Me.TextBoxRElement.TabIndex = 7
        '
        'LabelRQuantite
        '
        Me.LabelRQuantite.AutoSize = True
        Me.LabelRQuantite.Location = New System.Drawing.Point(6, 80)
        Me.LabelRQuantite.Name = "LabelRQuantite"
        Me.LabelRQuantite.Size = New System.Drawing.Size(62, 17)
        Me.LabelRQuantite.TabIndex = 8
        Me.LabelRQuantite.Text = "Quantité"
        '
        'LabelRCategorie
        '
        Me.LabelRCategorie.AutoSize = True
        Me.LabelRCategorie.Location = New System.Drawing.Point(6, 52)
        Me.LabelRCategorie.Name = "LabelRCategorie"
        Me.LabelRCategorie.Size = New System.Drawing.Size(69, 17)
        Me.LabelRCategorie.TabIndex = 7
        Me.LabelRCategorie.Text = "Catégorie"
        '
        'LabelRElement
        '
        Me.LabelRElement.AutoSize = True
        Me.LabelRElement.Location = New System.Drawing.Point(6, 24)
        Me.LabelRElement.Name = "LabelRElement"
        Me.LabelRElement.Size = New System.Drawing.Size(59, 17)
        Me.LabelRElement.TabIndex = 7
        Me.LabelRElement.Text = "Élément"
        '
        'GroupBoxAffichage
        '
        Me.GroupBoxAffichage.Controls.Add(Me.TextBoxProduit)
        Me.GroupBoxAffichage.Controls.Add(Me.ButtonAAfficher)
        Me.GroupBoxAffichage.Controls.Add(Me.ComboBoxACategorie)
        Me.GroupBoxAffichage.Controls.Add(Me.LabelACategorie)
        Me.GroupBoxAffichage.Location = New System.Drawing.Point(11, 246)
        Me.GroupBoxAffichage.Name = "GroupBoxAffichage"
        Me.GroupBoxAffichage.Size = New System.Drawing.Size(448, 273)
        Me.GroupBoxAffichage.TabIndex = 2
        Me.GroupBoxAffichage.TabStop = False
        Me.GroupBoxAffichage.Text = "Affichage"
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.Location = New System.Drawing.Point(286, 525)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(173, 24)
        Me.ButtonQuitter.TabIndex = 14
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'TextBoxProduit
        '
        Me.TextBoxProduit.Location = New System.Drawing.Point(75, 52)
        Me.TextBoxProduit.Multiline = True
        Me.TextBoxProduit.Name = "TextBoxProduit"
        Me.TextBoxProduit.ReadOnly = True
        Me.TextBoxProduit.Size = New System.Drawing.Size(193, 211)
        Me.TextBoxProduit.TabIndex = 13
        '
        'ButtonAAfficher
        '
        Me.ButtonAAfficher.Enabled = False
        Me.ButtonAAfficher.Location = New System.Drawing.Point(275, 21)
        Me.ButtonAAfficher.Name = "ButtonAAfficher"
        Me.ButtonAAfficher.Size = New System.Drawing.Size(166, 24)
        Me.ButtonAAfficher.TabIndex = 11
        Me.ButtonAAfficher.Text = "Afficher"
        Me.ButtonAAfficher.UseVisualStyleBackColor = True
        '
        'ComboBoxACategorie
        '
        Me.ComboBoxACategorie.FormattingEnabled = True
        Me.ComboBoxACategorie.Items.AddRange(New Object() {"Alimentaire", "Informatique", "Sport", "Meuble"})
        Me.ComboBoxACategorie.Location = New System.Drawing.Point(75, 21)
        Me.ComboBoxACategorie.Name = "ComboBoxACategorie"
        Me.ComboBoxACategorie.Size = New System.Drawing.Size(193, 24)
        Me.ComboBoxACategorie.TabIndex = 12
        '
        'LabelACategorie
        '
        Me.LabelACategorie.AutoSize = True
        Me.LabelACategorie.Location = New System.Drawing.Point(6, 24)
        Me.LabelACategorie.Name = "LabelACategorie"
        Me.LabelACategorie.Size = New System.Drawing.Size(69, 17)
        Me.LabelACategorie.TabIndex = 11
        Me.LabelACategorie.Text = "Catégorie"
        '
        'Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 561)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.GroupBoxAffichage)
        Me.Controls.Add(Me.GroupBoxRecherche)
        Me.Controls.Add(Me.GroupBoxNouveau)
        Me.Name = "Window"
        Me.Text = "Inventaire"
        Me.GroupBoxNouveau.ResumeLayout(False)
        Me.GroupBoxNouveau.PerformLayout()
        Me.GroupBoxRecherche.ResumeLayout(False)
        Me.GroupBoxRecherche.PerformLayout()
        Me.GroupBoxAffichage.ResumeLayout(False)
        Me.GroupBoxAffichage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxNouveau As GroupBox
    Friend WithEvents ButtonNAjouter As Button
    Friend WithEvents TextBoxNQuantite As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNNom As TextBox
    Friend WithEvents LabelNCategorie As Label
    Friend WithEvents LabelNNom As Label
    Friend WithEvents GroupBoxRecherche As GroupBox
    Friend WithEvents TextBoxRQuantite As TextBox
    Friend WithEvents TextBoxRCategorie As TextBox
    Friend WithEvents TextBoxRElement As TextBox
    Friend WithEvents LabelRQuantite As Label
    Friend WithEvents LabelRCategorie As Label
    Friend WithEvents LabelRElement As Label
    Friend WithEvents GroupBoxAffichage As GroupBox
    Friend WithEvents ButtonRRechercher As Button
    Friend WithEvents ButtonAAfficher As Button
    Friend WithEvents ComboBoxACategorie As ComboBox
    Friend WithEvents LabelACategorie As Label
    Friend WithEvents ComboBoxNCategorie As ComboBox
    Friend WithEvents ButtonQuitter As Button
    Friend WithEvents TextBoxProduit As TextBox
End Class
