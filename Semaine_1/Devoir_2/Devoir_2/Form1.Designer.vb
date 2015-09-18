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
        Me.ProduitLabel = New System.Windows.Forms.Label()
        Me.CategorieLabel = New System.Windows.Forms.Label()
        Me.Produit = New System.Windows.Forms.TextBox()
        Me.Categorie = New System.Windows.Forms.ComboBox()
        Me.CategorieElectroniqueLabel = New System.Windows.Forms.Label()
        Me.CategorieElectronique = New System.Windows.Forms.ListBox()
        Me.CategorieInformatique = New System.Windows.Forms.ListBox()
        Me.CategorieJeux = New System.Windows.Forms.ListBox()
        Me.CategorieInformatiqueLabel = New System.Windows.Forms.Label()
        Me.CategorieJeuxLabel = New System.Windows.Forms.Label()
        Me.Ajouter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ProduitLabel
        '
        Me.ProduitLabel.AutoSize = True
        Me.ProduitLabel.Location = New System.Drawing.Point(14, 16)
        Me.ProduitLabel.Name = "ProduitLabel"
        Me.ProduitLabel.Size = New System.Drawing.Size(105, 17)
        Me.ProduitLabel.TabIndex = 0
        Me.ProduitLabel.Text = "Nom du produit"
        '
        'CategorieLabel
        '
        Me.CategorieLabel.AutoSize = True
        Me.CategorieLabel.Location = New System.Drawing.Point(50, 45)
        Me.CategorieLabel.Name = "CategorieLabel"
        Me.CategorieLabel.Size = New System.Drawing.Size(69, 17)
        Me.CategorieLabel.TabIndex = 1
        Me.CategorieLabel.Text = "Catégorie"
        '
        'Produit
        '
        Me.Produit.Location = New System.Drawing.Point(125, 13)
        Me.Produit.Name = "Produit"
        Me.Produit.Size = New System.Drawing.Size(308, 22)
        Me.Produit.TabIndex = 2
        '
        'Categorie
        '
        Me.Categorie.FormattingEnabled = True
        Me.Categorie.Items.AddRange(New Object() {"Électronique", "Informatique", "Jeux"})
        Me.Categorie.Location = New System.Drawing.Point(125, 42)
        Me.Categorie.Name = "Categorie"
        Me.Categorie.Size = New System.Drawing.Size(308, 24)
        Me.Categorie.TabIndex = 4
        '
        'CategorieElectroniqueLabel
        '
        Me.CategorieElectroniqueLabel.AutoSize = True
        Me.CategorieElectroniqueLabel.Location = New System.Drawing.Point(14, 73)
        Me.CategorieElectroniqueLabel.Name = "CategorieElectroniqueLabel"
        Me.CategorieElectroniqueLabel.Size = New System.Drawing.Size(87, 17)
        Me.CategorieElectroniqueLabel.TabIndex = 5
        Me.CategorieElectroniqueLabel.Text = "Électronique"
        '
        'CategorieElectronique
        '
        Me.CategorieElectronique.FormattingEnabled = True
        Me.CategorieElectronique.ItemHeight = 16
        Me.CategorieElectronique.Location = New System.Drawing.Point(12, 93)
        Me.CategorieElectronique.Name = "CategorieElectronique"
        Me.CategorieElectronique.Size = New System.Drawing.Size(136, 292)
        Me.CategorieElectronique.TabIndex = 6
        '
        'CategorieInformatique
        '
        Me.CategorieInformatique.FormattingEnabled = True
        Me.CategorieInformatique.ItemHeight = 16
        Me.CategorieInformatique.Location = New System.Drawing.Point(154, 93)
        Me.CategorieInformatique.Name = "CategorieInformatique"
        Me.CategorieInformatique.Size = New System.Drawing.Size(136, 292)
        Me.CategorieInformatique.TabIndex = 7
        '
        'CategorieJeux
        '
        Me.CategorieJeux.FormattingEnabled = True
        Me.CategorieJeux.ItemHeight = 16
        Me.CategorieJeux.Location = New System.Drawing.Point(296, 93)
        Me.CategorieJeux.Name = "CategorieJeux"
        Me.CategorieJeux.Size = New System.Drawing.Size(136, 292)
        Me.CategorieJeux.TabIndex = 8
        '
        'CategorieInformatiqueLabel
        '
        Me.CategorieInformatiqueLabel.AutoSize = True
        Me.CategorieInformatiqueLabel.Location = New System.Drawing.Point(151, 73)
        Me.CategorieInformatiqueLabel.Name = "CategorieInformatiqueLabel"
        Me.CategorieInformatiqueLabel.Size = New System.Drawing.Size(86, 17)
        Me.CategorieInformatiqueLabel.TabIndex = 9
        Me.CategorieInformatiqueLabel.Text = "Informatique"
        '
        'CategorieJeuxLabel
        '
        Me.CategorieJeuxLabel.AutoSize = True
        Me.CategorieJeuxLabel.Location = New System.Drawing.Point(293, 73)
        Me.CategorieJeuxLabel.Name = "CategorieJeuxLabel"
        Me.CategorieJeuxLabel.Size = New System.Drawing.Size(37, 17)
        Me.CategorieJeuxLabel.TabIndex = 10
        Me.CategorieJeuxLabel.Text = "Jeux"
        '
        'Ajouter
        '
        Me.Ajouter.Location = New System.Drawing.Point(12, 392)
        Me.Ajouter.Name = "Ajouter"
        Me.Ajouter.Size = New System.Drawing.Size(421, 24)
        Me.Ajouter.TabIndex = 11
        Me.Ajouter.Text = "Ajouter"
        Me.Ajouter.UseVisualStyleBackColor = True
        '
        'Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 428)
        Me.Controls.Add(Me.Ajouter)
        Me.Controls.Add(Me.CategorieJeuxLabel)
        Me.Controls.Add(Me.CategorieInformatiqueLabel)
        Me.Controls.Add(Me.CategorieJeux)
        Me.Controls.Add(Me.CategorieInformatique)
        Me.Controls.Add(Me.CategorieElectronique)
        Me.Controls.Add(Me.CategorieElectroniqueLabel)
        Me.Controls.Add(Me.Categorie)
        Me.Controls.Add(Me.Produit)
        Me.Controls.Add(Me.CategorieLabel)
        Me.Controls.Add(Me.ProduitLabel)
        Me.Name = "Window"
        Me.Text = "Inventaire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProduitLabel As Label
    Friend WithEvents CategorieLabel As Label
    Friend WithEvents Produit As TextBox
    Friend WithEvents Categorie As ComboBox
    Friend WithEvents CategorieElectroniqueLabel As Label
    Friend WithEvents CategorieElectronique As ListBox
    Friend WithEvents CategorieInformatique As ListBox
    Friend WithEvents CategorieJeux As ListBox
    Friend WithEvents CategorieInformatiqueLabel As Label
    Friend WithEvents CategorieJeuxLabel As Label
    Friend WithEvents Ajouter As Button
End Class
