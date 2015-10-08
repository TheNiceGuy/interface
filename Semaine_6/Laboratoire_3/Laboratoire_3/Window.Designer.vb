<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Window
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImporterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExporterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPageAffichage = New System.Windows.Forms.TabPage()
        Me.TableLayoutAffichage = New System.Windows.Forms.TableLayoutPanel()
        Me.ListViewAfficher = New System.Windows.Forms.ListView()
        Me.ColumnHeaderANumero = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderANom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAPrix = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderACategorie = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAQuantite = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ComboBoxAfficherCategorie = New System.Windows.Forms.ComboBox()
        Me.GroupBoxAchat = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanelAchat = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelAchatQuantite = New System.Windows.Forms.Label()
        Me.TextBoxAchatQuantite = New System.Windows.Forms.TextBox()
        Me.ButtonAchatAjouter = New System.Windows.Forms.Button()
        Me.TabPagePanier = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanier = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxPanierModification = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelModificationQuantite = New System.Windows.Forms.Label()
        Me.TextBoxModificationQuantite = New System.Windows.Forms.TextBox()
        Me.ButtonPanierModification = New System.Windows.Forms.Button()
        Me.ButtonPanierEnlever = New System.Windows.Forms.Button()
        Me.ListViewPanier = New System.Windows.Forms.ListView()
        Me.ColumnHeaderPNumero = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderPArticle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderPQuantite = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderPPrix = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonEffectuerAchat = New System.Windows.Forms.Button()
        Me.TabPageLog = New System.Windows.Forms.TabPage()
        Me.ListBoxLog = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPageAffichage.SuspendLayout()
        Me.TableLayoutAffichage.SuspendLayout()
        Me.GroupBoxAchat.SuspendLayout()
        Me.TableLayoutPanelAchat.SuspendLayout()
        Me.TabPagePanier.SuspendLayout()
        Me.TableLayoutPanier.SuspendLayout()
        Me.GroupBoxPanierModification.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TabPageLog.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1083, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirToolStripMenuItem, Me.EnregistrerToolStripMenuItem, Me.ToolStripSeparator1, Me.ImporterToolStripMenuItem, Me.ExporterToolStripMenuItem, Me.ToolStripSeparator2, Me.QuitterToolStripMenuItem})
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
        'EnregistrerToolStripMenuItem
        '
        Me.EnregistrerToolStripMenuItem.Enabled = False
        Me.EnregistrerToolStripMenuItem.Name = "EnregistrerToolStripMenuItem"
        Me.EnregistrerToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.EnregistrerToolStripMenuItem.Text = "Enregistrer"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'ImporterToolStripMenuItem
        '
        Me.ImporterToolStripMenuItem.Name = "ImporterToolStripMenuItem"
        Me.ImporterToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ImporterToolStripMenuItem.Text = "Importer"
        '
        'ExporterToolStripMenuItem
        '
        Me.ExporterToolStripMenuItem.Enabled = False
        Me.ExporterToolStripMenuItem.Name = "ExporterToolStripMenuItem"
        Me.ExporterToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ExporterToolStripMenuItem.Text = "Exporter"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(178, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPageAffichage)
        Me.TabControl.Controls.Add(Me.TabPagePanier)
        Me.TabControl.Controls.Add(Me.TabPageLog)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 28)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1083, 450)
        Me.TabControl.TabIndex = 1
        '
        'TabPageAffichage
        '
        Me.TabPageAffichage.Controls.Add(Me.TableLayoutAffichage)
        Me.TabPageAffichage.Location = New System.Drawing.Point(4, 25)
        Me.TabPageAffichage.Name = "TabPageAffichage"
        Me.TabPageAffichage.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAffichage.Size = New System.Drawing.Size(1075, 421)
        Me.TabPageAffichage.TabIndex = 0
        Me.TabPageAffichage.Text = "Affichage"
        Me.TabPageAffichage.UseVisualStyleBackColor = True
        '
        'TableLayoutAffichage
        '
        Me.TableLayoutAffichage.ColumnCount = 1
        Me.TableLayoutAffichage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutAffichage.Controls.Add(Me.ListViewAfficher, 0, 1)
        Me.TableLayoutAffichage.Controls.Add(Me.ComboBoxAfficherCategorie, 0, 0)
        Me.TableLayoutAffichage.Controls.Add(Me.GroupBoxAchat, 0, 2)
        Me.TableLayoutAffichage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutAffichage.Enabled = False
        Me.TableLayoutAffichage.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutAffichage.Name = "TableLayoutAffichage"
        Me.TableLayoutAffichage.RowCount = 3
        Me.TableLayoutAffichage.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutAffichage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutAffichage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 136.0!))
        Me.TableLayoutAffichage.Size = New System.Drawing.Size(1069, 415)
        Me.TableLayoutAffichage.TabIndex = 0
        '
        'ListViewAfficher
        '
        Me.ListViewAfficher.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderANumero, Me.ColumnHeaderANom, Me.ColumnHeaderAPrix, Me.ColumnHeaderACategorie, Me.ColumnHeaderAQuantite})
        Me.ListViewAfficher.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewAfficher.FullRowSelect = True
        Me.ListViewAfficher.Location = New System.Drawing.Point(3, 33)
        Me.ListViewAfficher.Name = "ListViewAfficher"
        Me.ListViewAfficher.Size = New System.Drawing.Size(1063, 243)
        Me.ListViewAfficher.TabIndex = 0
        Me.ListViewAfficher.UseCompatibleStateImageBehavior = False
        Me.ListViewAfficher.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderANumero
        '
        Me.ColumnHeaderANumero.Text = "#"
        Me.ColumnHeaderANumero.Width = 30
        '
        'ColumnHeaderANom
        '
        Me.ColumnHeaderANom.Text = "Nom"
        Me.ColumnHeaderANom.Width = 300
        '
        'ColumnHeaderAPrix
        '
        Me.ColumnHeaderAPrix.Text = "Prix"
        Me.ColumnHeaderAPrix.Width = 80
        '
        'ColumnHeaderACategorie
        '
        Me.ColumnHeaderACategorie.Text = "Catégorie"
        Me.ColumnHeaderACategorie.Width = 200
        '
        'ColumnHeaderAQuantite
        '
        Me.ColumnHeaderAQuantite.Text = "Quantité"
        Me.ColumnHeaderAQuantite.Width = 80
        '
        'ComboBoxAfficherCategorie
        '
        Me.ComboBoxAfficherCategorie.Dock = System.Windows.Forms.DockStyle.Top
        Me.ComboBoxAfficherCategorie.FormattingEnabled = True
        Me.ComboBoxAfficherCategorie.Location = New System.Drawing.Point(3, 3)
        Me.ComboBoxAfficherCategorie.Name = "ComboBoxAfficherCategorie"
        Me.ComboBoxAfficherCategorie.Size = New System.Drawing.Size(1063, 24)
        Me.ComboBoxAfficherCategorie.TabIndex = 1
        '
        'GroupBoxAchat
        '
        Me.GroupBoxAchat.Controls.Add(Me.TableLayoutPanelAchat)
        Me.GroupBoxAchat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxAchat.Location = New System.Drawing.Point(3, 282)
        Me.GroupBoxAchat.Name = "GroupBoxAchat"
        Me.GroupBoxAchat.Size = New System.Drawing.Size(1063, 130)
        Me.GroupBoxAchat.TabIndex = 2
        Me.GroupBoxAchat.TabStop = False
        Me.GroupBoxAchat.Text = "Achat"
        '
        'TableLayoutPanelAchat
        '
        Me.TableLayoutPanelAchat.ColumnCount = 2
        Me.TableLayoutPanelAchat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanelAchat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanelAchat.Controls.Add(Me.LabelAchatQuantite, 0, 0)
        Me.TableLayoutPanelAchat.Controls.Add(Me.TextBoxAchatQuantite, 1, 0)
        Me.TableLayoutPanelAchat.Controls.Add(Me.ButtonAchatAjouter, 1, 1)
        Me.TableLayoutPanelAchat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelAchat.Location = New System.Drawing.Point(3, 18)
        Me.TableLayoutPanelAchat.Name = "TableLayoutPanelAchat"
        Me.TableLayoutPanelAchat.RowCount = 2
        Me.TableLayoutPanelAchat.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanelAchat.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanelAchat.Size = New System.Drawing.Size(1057, 109)
        Me.TableLayoutPanelAchat.TabIndex = 0
        '
        'LabelAchatQuantite
        '
        Me.LabelAchatQuantite.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelAchatQuantite.AutoSize = True
        Me.LabelAchatQuantite.Location = New System.Drawing.Point(93, 13)
        Me.LabelAchatQuantite.Name = "LabelAchatQuantite"
        Me.LabelAchatQuantite.Size = New System.Drawing.Size(62, 17)
        Me.LabelAchatQuantite.TabIndex = 0
        Me.LabelAchatQuantite.Text = "Quantité"
        '
        'TextBoxAchatQuantite
        '
        Me.TextBoxAchatQuantite.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxAchatQuantite.Location = New System.Drawing.Point(161, 10)
        Me.TextBoxAchatQuantite.Name = "TextBoxAchatQuantite"
        Me.TextBoxAchatQuantite.Size = New System.Drawing.Size(168, 22)
        Me.TextBoxAchatQuantite.TabIndex = 1
        '
        'ButtonAchatAjouter
        '
        Me.ButtonAchatAjouter.Location = New System.Drawing.Point(161, 46)
        Me.ButtonAchatAjouter.Name = "ButtonAchatAjouter"
        Me.ButtonAchatAjouter.Size = New System.Drawing.Size(168, 23)
        Me.ButtonAchatAjouter.TabIndex = 2
        Me.ButtonAchatAjouter.Text = "Ajouter au panier"
        Me.ButtonAchatAjouter.UseVisualStyleBackColor = True
        '
        'TabPagePanier
        '
        Me.TabPagePanier.Controls.Add(Me.TableLayoutPanier)
        Me.TabPagePanier.Location = New System.Drawing.Point(4, 25)
        Me.TabPagePanier.Name = "TabPagePanier"
        Me.TabPagePanier.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePanier.Size = New System.Drawing.Size(1075, 421)
        Me.TabPagePanier.TabIndex = 1
        Me.TabPagePanier.Text = "Panier"
        Me.TabPagePanier.UseVisualStyleBackColor = True
        '
        'TableLayoutPanier
        '
        Me.TableLayoutPanier.ColumnCount = 2
        Me.TableLayoutPanier.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.14312!))
        Me.TableLayoutPanier.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.85688!))
        Me.TableLayoutPanier.Controls.Add(Me.GroupBoxPanierModification, 1, 0)
        Me.TableLayoutPanier.Controls.Add(Me.ListViewPanier, 0, 0)
        Me.TableLayoutPanier.Controls.Add(Me.ButtonEffectuerAchat, 1, 1)
        Me.TableLayoutPanier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanier.Enabled = False
        Me.TableLayoutPanier.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanier.Name = "TableLayoutPanier"
        Me.TableLayoutPanier.RowCount = 2
        Me.TableLayoutPanier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 294.0!))
        Me.TableLayoutPanier.Size = New System.Drawing.Size(1069, 415)
        Me.TableLayoutPanier.TabIndex = 2
        '
        'GroupBoxPanierModification
        '
        Me.GroupBoxPanierModification.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBoxPanierModification.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxPanierModification.Location = New System.Drawing.Point(677, 3)
        Me.GroupBoxPanierModification.Name = "GroupBoxPanierModification"
        Me.GroupBoxPanierModification.Size = New System.Drawing.Size(389, 115)
        Me.GroupBoxPanierModification.TabIndex = 7
        Me.GroupBoxPanierModification.TabStop = False
        Me.GroupBoxPanierModification.Text = "Modification"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.LabelModificationQuantite, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxModificationQuantite, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonPanierModification, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonPanierEnlever, 1, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 18)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(383, 94)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'LabelModificationQuantite
        '
        Me.LabelModificationQuantite.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelModificationQuantite.AutoSize = True
        Me.LabelModificationQuantite.Location = New System.Drawing.Point(11, 10)
        Me.LabelModificationQuantite.Name = "LabelModificationQuantite"
        Me.LabelModificationQuantite.Size = New System.Drawing.Size(62, 17)
        Me.LabelModificationQuantite.TabIndex = 3
        Me.LabelModificationQuantite.Text = "Quantité"
        '
        'TextBoxModificationQuantite
        '
        Me.TextBoxModificationQuantite.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBoxModificationQuantite.Location = New System.Drawing.Point(79, 7)
        Me.TextBoxModificationQuantite.Name = "TextBoxModificationQuantite"
        Me.TextBoxModificationQuantite.Size = New System.Drawing.Size(168, 22)
        Me.TextBoxModificationQuantite.TabIndex = 4
        '
        'ButtonPanierModification
        '
        Me.ButtonPanierModification.Location = New System.Drawing.Point(79, 40)
        Me.ButtonPanierModification.Name = "ButtonPanierModification"
        Me.ButtonPanierModification.Size = New System.Drawing.Size(168, 22)
        Me.ButtonPanierModification.TabIndex = 5
        Me.ButtonPanierModification.Text = "Modifier"
        Me.ButtonPanierModification.UseVisualStyleBackColor = True
        '
        'ButtonPanierEnlever
        '
        Me.ButtonPanierEnlever.Location = New System.Drawing.Point(79, 68)
        Me.ButtonPanierEnlever.Name = "ButtonPanierEnlever"
        Me.ButtonPanierEnlever.Size = New System.Drawing.Size(168, 22)
        Me.ButtonPanierEnlever.TabIndex = 6
        Me.ButtonPanierEnlever.Text = "Enlever"
        Me.ButtonPanierEnlever.UseVisualStyleBackColor = True
        '
        'ListViewPanier
        '
        Me.ListViewPanier.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderPNumero, Me.ColumnHeaderPArticle, Me.ColumnHeaderPQuantite, Me.ColumnHeaderPPrix})
        Me.ListViewPanier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewPanier.FullRowSelect = True
        Me.ListViewPanier.Location = New System.Drawing.Point(3, 3)
        Me.ListViewPanier.Name = "ListViewPanier"
        Me.TableLayoutPanier.SetRowSpan(Me.ListViewPanier, 2)
        Me.ListViewPanier.Size = New System.Drawing.Size(668, 409)
        Me.ListViewPanier.TabIndex = 2
        Me.ListViewPanier.UseCompatibleStateImageBehavior = False
        Me.ListViewPanier.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderPNumero
        '
        Me.ColumnHeaderPNumero.Text = "#"
        Me.ColumnHeaderPNumero.Width = 30
        '
        'ColumnHeaderPArticle
        '
        Me.ColumnHeaderPArticle.Text = "Article"
        Me.ColumnHeaderPArticle.Width = 300
        '
        'ColumnHeaderPQuantite
        '
        Me.ColumnHeaderPQuantite.Text = "Quantité"
        Me.ColumnHeaderPQuantite.Width = 80
        '
        'ColumnHeaderPPrix
        '
        Me.ColumnHeaderPPrix.Text = "Prix"
        Me.ColumnHeaderPPrix.Width = 80
        '
        'ButtonEffectuerAchat
        '
        Me.ButtonEffectuerAchat.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonEffectuerAchat.Location = New System.Drawing.Point(677, 124)
        Me.ButtonEffectuerAchat.Name = "ButtonEffectuerAchat"
        Me.ButtonEffectuerAchat.Size = New System.Drawing.Size(389, 23)
        Me.ButtonEffectuerAchat.TabIndex = 4
        Me.ButtonEffectuerAchat.Text = "Acheter"
        Me.ButtonEffectuerAchat.UseVisualStyleBackColor = True
        '
        'TabPageLog
        '
        Me.TabPageLog.Controls.Add(Me.ListBoxLog)
        Me.TabPageLog.Location = New System.Drawing.Point(4, 25)
        Me.TabPageLog.Name = "TabPageLog"
        Me.TabPageLog.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageLog.Size = New System.Drawing.Size(1075, 421)
        Me.TabPageLog.TabIndex = 2
        Me.TabPageLog.Text = "Log"
        Me.TabPageLog.UseVisualStyleBackColor = True
        '
        'ListBoxLog
        '
        Me.ListBoxLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxLog.FormattingEnabled = True
        Me.ListBoxLog.ItemHeight = 16
        Me.ListBoxLog.Location = New System.Drawing.Point(3, 3)
        Me.ListBoxLog.Name = "ListBoxLog"
        Me.ListBoxLog.Size = New System.Drawing.Size(1069, 415)
        Me.ListBoxLog.TabIndex = 0
        '
        'Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 478)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Window"
        Me.Text = "Inventaire"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabPageAffichage.ResumeLayout(False)
        Me.TableLayoutAffichage.ResumeLayout(False)
        Me.GroupBoxAchat.ResumeLayout(False)
        Me.TableLayoutPanelAchat.ResumeLayout(False)
        Me.TableLayoutPanelAchat.PerformLayout()
        Me.TabPagePanier.ResumeLayout(False)
        Me.TableLayoutPanier.ResumeLayout(False)
        Me.GroupBoxPanierModification.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TabPageLog.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnregistrerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ImporterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExporterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPageAffichage As TabPage
    Friend WithEvents TabPagePanier As TabPage
    Friend WithEvents TabPageLog As TabPage
    Friend WithEvents ListBoxLog As ListBox
    Friend WithEvents TableLayoutAffichage As TableLayoutPanel
    Friend WithEvents ComboBoxAfficherCategorie As ComboBox
    Friend WithEvents ListViewAfficher As ListView
    Friend WithEvents ColumnHeaderANumero As ColumnHeader
    Friend WithEvents ColumnHeaderANom As ColumnHeader
    Friend WithEvents ColumnHeaderAPrix As ColumnHeader
    Friend WithEvents ColumnHeaderACategorie As ColumnHeader
    Friend WithEvents ColumnHeaderAQuantite As ColumnHeader
    Friend WithEvents GroupBoxAchat As GroupBox
    Friend WithEvents TableLayoutPanelAchat As TableLayoutPanel
    Friend WithEvents LabelAchatQuantite As Label
    Friend WithEvents TextBoxAchatQuantite As TextBox
    Friend WithEvents ButtonAchatAjouter As Button
    Friend WithEvents TableLayoutPanier As TableLayoutPanel
    Friend WithEvents ListViewPanier As ListView
    Friend WithEvents ColumnHeaderPArticle As ColumnHeader
    Friend WithEvents ColumnHeaderPQuantite As ColumnHeader
    Friend WithEvents ColumnHeaderPPrix As ColumnHeader
    Friend WithEvents ColumnHeaderPNumero As ColumnHeader
    Friend WithEvents GroupBoxPanierModification As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LabelModificationQuantite As Label
    Friend WithEvents TextBoxModificationQuantite As TextBox
    Friend WithEvents ButtonPanierModification As Button
    Friend WithEvents ButtonEffectuerAchat As Button
    Friend WithEvents ButtonPanierEnlever As Button
End Class
