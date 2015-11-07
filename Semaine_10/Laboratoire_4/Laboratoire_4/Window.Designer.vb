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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPageAfficher = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanelAffichage = New System.Windows.Forms.TableLayoutPanel()
        Me.ListViewAffichage = New System.Windows.Forms.ListView()
        Me.ColumnHeaderAffichageNumero = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAffichageNom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAffichagePrix = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAffichageQuantite = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAffichageFournisseur = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAffichageSpace = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBoxRechercherAffichage = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanelRechercheAffichage = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBoxRechercheFournisseur = New System.Windows.Forms.CheckBox()
        Me.NumericUpDownRecherchePrixMax = New System.Windows.Forms.NumericUpDown()
        Me.LabelRechercheFournisseur = New System.Windows.Forms.Label()
        Me.TextBoxRechercheFournisseur = New System.Windows.Forms.TextBox()
        Me.CheckBoxRecherchePrix = New System.Windows.Forms.CheckBox()
        Me.LabelRecherchePrix = New System.Windows.Forms.Label()
        Me.NumericUpDownRecherchePrixMin = New System.Windows.Forms.NumericUpDown()
        Me.ButtonCommander = New System.Windows.Forms.Button()
        Me.TabPageCommande = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanelCommande = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelPrixUnitaireModif = New System.Windows.Forms.Label()
        Me.LabelPrixUnitaire = New System.Windows.Forms.Label()
        Me.LabelFournisseurModif = New System.Windows.Forms.Label()
        Me.LabelNomModif = New System.Windows.Forms.Label()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.LabelFournisseur = New System.Windows.Forms.Label()
        Me.NumericUpDownQuantite = New System.Windows.Forms.NumericUpDown()
        Me.LabelQuantite = New System.Windows.Forms.Label()
        Me.LabelPrixTotalModif = New System.Windows.Forms.Label()
        Me.LabelPrixTotal = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.DateTimePickerCommande = New System.Windows.Forms.DateTimePicker()
        Me.ButtonAnnuler = New System.Windows.Forms.Button()
        Me.ButtonConfirmer = New System.Windows.Forms.Button()
        Me.TabPageHistorique = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ListViewHistorique = New System.Windows.Forms.ListView()
        Me.ColumnHeaderHistoriqueID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderHistoriqueDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderHistoriqueArticle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderHistoriqueFournisseur = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderHistoriqueQuantite = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderHistoriquePrixUnitaire = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderHistoriquePrixTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderHistoriqueSpace = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBoxRechercherHistorique = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanelRechercherHistorique = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBoxRechercheDate = New System.Windows.Forms.CheckBox()
        Me.LabelRechercheDate = New System.Windows.Forms.Label()
        Me.DateTimePickerRecherche = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPageAfficher.SuspendLayout()
        Me.TableLayoutPanelAffichage.SuspendLayout()
        Me.GroupBoxRechercherAffichage.SuspendLayout()
        Me.TableLayoutPanelRechercheAffichage.SuspendLayout()
        CType(Me.NumericUpDownRecherchePrixMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownRecherchePrixMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCommande.SuspendLayout()
        Me.TableLayoutPanelCommande.SuspendLayout()
        CType(Me.NumericUpDownQuantite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageHistorique.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBoxRechercherHistorique.SuspendLayout()
        Me.TableLayoutPanelRechercherHistorique.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirToolStripMenuItem, Me.ArticleToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(597, 28)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirToolStripMenuItem1, Me.ToolStripSeparator1, Me.QuitterToolStripMenuItem})
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.OuvrirToolStripMenuItem.Text = "Fichier"
        '
        'OuvrirToolStripMenuItem1
        '
        Me.OuvrirToolStripMenuItem1.Name = "OuvrirToolStripMenuItem1"
        Me.OuvrirToolStripMenuItem1.Size = New System.Drawing.Size(130, 26)
        Me.OuvrirToolStripMenuItem1.Text = "Ouvrir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(127, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(130, 26)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'ArticleToolStripMenuItem
        '
        Me.ArticleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem})
        Me.ArticleToolStripMenuItem.Enabled = False
        Me.ArticleToolStripMenuItem.Name = "ArticleToolStripMenuItem"
        Me.ArticleToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.ArticleToolStripMenuItem.Text = "Article"
        '
        'AjouterToolStripMenuItem
        '
        Me.AjouterToolStripMenuItem.Name = "AjouterToolStripMenuItem"
        Me.AjouterToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.AjouterToolStripMenuItem.Text = "Ajouter"
        '
        'TabControl
        '
        Me.TabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl.Controls.Add(Me.TabPageAfficher)
        Me.TabControl.Controls.Add(Me.TabPageCommande)
        Me.TabControl.Controls.Add(Me.TabPageHistorique)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Enabled = False
        Me.TabControl.Location = New System.Drawing.Point(0, 28)
        Me.TabControl.Multiline = True
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(597, 408)
        Me.TabControl.TabIndex = 1
        '
        'TabPageAfficher
        '
        Me.TabPageAfficher.Controls.Add(Me.TableLayoutPanelAffichage)
        Me.TabPageAfficher.Location = New System.Drawing.Point(4, 4)
        Me.TabPageAfficher.Name = "TabPageAfficher"
        Me.TabPageAfficher.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAfficher.Size = New System.Drawing.Size(589, 379)
        Me.TabPageAfficher.TabIndex = 0
        Me.TabPageAfficher.Text = "Affichage"
        Me.TabPageAfficher.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelAffichage
        '
        Me.TableLayoutPanelAffichage.ColumnCount = 3
        Me.TableLayoutPanelAffichage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332!))
        Me.TableLayoutPanelAffichage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanelAffichage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanelAffichage.Controls.Add(Me.ListViewAffichage, 0, 0)
        Me.TableLayoutPanelAffichage.Controls.Add(Me.GroupBoxRechercherAffichage, 0, 1)
        Me.TableLayoutPanelAffichage.Controls.Add(Me.ButtonCommander, 2, 2)
        Me.TableLayoutPanelAffichage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelAffichage.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanelAffichage.Name = "TableLayoutPanelAffichage"
        Me.TableLayoutPanelAffichage.RowCount = 3
        Me.TableLayoutPanelAffichage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelAffichage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanelAffichage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelAffichage.Size = New System.Drawing.Size(583, 373)
        Me.TableLayoutPanelAffichage.TabIndex = 0
        '
        'ListViewAffichage
        '
        Me.ListViewAffichage.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderAffichageNumero, Me.ColumnHeaderAffichageNom, Me.ColumnHeaderAffichagePrix, Me.ColumnHeaderAffichageQuantite, Me.ColumnHeaderAffichageFournisseur, Me.ColumnHeaderAffichageSpace})
        Me.TableLayoutPanelAffichage.SetColumnSpan(Me.ListViewAffichage, 3)
        Me.ListViewAffichage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewAffichage.FullRowSelect = True
        Me.ListViewAffichage.Location = New System.Drawing.Point(3, 3)
        Me.ListViewAffichage.Name = "ListViewAffichage"
        Me.ListViewAffichage.Size = New System.Drawing.Size(577, 267)
        Me.ListViewAffichage.TabIndex = 0
        Me.ListViewAffichage.UseCompatibleStateImageBehavior = False
        Me.ListViewAffichage.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderAffichageNumero
        '
        Me.ColumnHeaderAffichageNumero.Text = "#"
        Me.ColumnHeaderAffichageNumero.Width = 31
        '
        'ColumnHeaderAffichageNom
        '
        Me.ColumnHeaderAffichageNom.Text = "Nom"
        Me.ColumnHeaderAffichageNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderAffichageNom.Width = 41
        '
        'ColumnHeaderAffichagePrix
        '
        Me.ColumnHeaderAffichagePrix.Text = "Prix"
        Me.ColumnHeaderAffichagePrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderAffichagePrix.Width = 34
        '
        'ColumnHeaderAffichageQuantite
        '
        Me.ColumnHeaderAffichageQuantite.Text = "Quantité"
        Me.ColumnHeaderAffichageQuantite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderAffichageQuantite.Width = 61
        '
        'ColumnHeaderAffichageFournisseur
        '
        Me.ColumnHeaderAffichageFournisseur.Text = "Fournisseur"
        Me.ColumnHeaderAffichageFournisseur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderAffichageFournisseur.Width = 82
        '
        'ColumnHeaderAffichageSpace
        '
        Me.ColumnHeaderAffichageSpace.Text = ""
        Me.ColumnHeaderAffichageSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderAffichageSpace.Width = 324
        '
        'GroupBoxRechercherAffichage
        '
        Me.TableLayoutPanelAffichage.SetColumnSpan(Me.GroupBoxRechercherAffichage, 2)
        Me.GroupBoxRechercherAffichage.Controls.Add(Me.TableLayoutPanelRechercheAffichage)
        Me.GroupBoxRechercherAffichage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxRechercherAffichage.Location = New System.Drawing.Point(3, 276)
        Me.GroupBoxRechercherAffichage.Name = "GroupBoxRechercherAffichage"
        Me.TableLayoutPanelAffichage.SetRowSpan(Me.GroupBoxRechercherAffichage, 2)
        Me.GroupBoxRechercherAffichage.Size = New System.Drawing.Size(382, 94)
        Me.GroupBoxRechercherAffichage.TabIndex = 4
        Me.GroupBoxRechercherAffichage.TabStop = False
        Me.GroupBoxRechercherAffichage.Text = "Recherche"
        '
        'TableLayoutPanelRechercheAffichage
        '
        Me.TableLayoutPanelRechercheAffichage.ColumnCount = 4
        Me.TableLayoutPanelRechercheAffichage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanelRechercheAffichage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanelRechercheAffichage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanelRechercheAffichage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanelRechercheAffichage.Controls.Add(Me.CheckBoxRechercheFournisseur, 0, 1)
        Me.TableLayoutPanelRechercheAffichage.Controls.Add(Me.NumericUpDownRecherchePrixMax, 3, 0)
        Me.TableLayoutPanelRechercheAffichage.Controls.Add(Me.LabelRechercheFournisseur, 1, 1)
        Me.TableLayoutPanelRechercheAffichage.Controls.Add(Me.TextBoxRechercheFournisseur, 2, 1)
        Me.TableLayoutPanelRechercheAffichage.Controls.Add(Me.CheckBoxRecherchePrix, 0, 0)
        Me.TableLayoutPanelRechercheAffichage.Controls.Add(Me.LabelRecherchePrix, 1, 0)
        Me.TableLayoutPanelRechercheAffichage.Controls.Add(Me.NumericUpDownRecherchePrixMin, 2, 0)
        Me.TableLayoutPanelRechercheAffichage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelRechercheAffichage.Location = New System.Drawing.Point(3, 18)
        Me.TableLayoutPanelRechercheAffichage.Name = "TableLayoutPanelRechercheAffichage"
        Me.TableLayoutPanelRechercheAffichage.RowCount = 2
        Me.TableLayoutPanelRechercheAffichage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelRechercheAffichage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelRechercheAffichage.Size = New System.Drawing.Size(376, 73)
        Me.TableLayoutPanelRechercheAffichage.TabIndex = 0
        '
        'CheckBoxRechercheFournisseur
        '
        Me.CheckBoxRechercheFournisseur.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CheckBoxRechercheFournisseur.AutoSize = True
        Me.CheckBoxRechercheFournisseur.Checked = True
        Me.CheckBoxRechercheFournisseur.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxRechercheFournisseur.Location = New System.Drawing.Point(16, 46)
        Me.CheckBoxRechercheFournisseur.Name = "CheckBoxRechercheFournisseur"
        Me.CheckBoxRechercheFournisseur.Size = New System.Drawing.Size(18, 17)
        Me.CheckBoxRechercheFournisseur.TabIndex = 7
        Me.CheckBoxRechercheFournisseur.UseVisualStyleBackColor = True
        '
        'NumericUpDownRecherchePrixMax
        '
        Me.NumericUpDownRecherchePrixMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDownRecherchePrixMax.DecimalPlaces = 2
        Me.NumericUpDownRecherchePrixMax.Location = New System.Drawing.Point(264, 7)
        Me.NumericUpDownRecherchePrixMax.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDownRecherchePrixMax.Name = "NumericUpDownRecherchePrixMax"
        Me.NumericUpDownRecherchePrixMax.Size = New System.Drawing.Size(109, 22)
        Me.NumericUpDownRecherchePrixMax.TabIndex = 6
        '
        'LabelRechercheFournisseur
        '
        Me.LabelRechercheFournisseur.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelRechercheFournisseur.AutoSize = True
        Me.LabelRechercheFournisseur.Location = New System.Drawing.Point(58, 46)
        Me.LabelRechercheFournisseur.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelRechercheFournisseur.Name = "LabelRechercheFournisseur"
        Me.LabelRechercheFournisseur.Size = New System.Drawing.Size(91, 17)
        Me.LabelRechercheFournisseur.TabIndex = 3
        Me.LabelRechercheFournisseur.Text = "Fournisseur :"
        '
        'TextBoxRechercheFournisseur
        '
        Me.TextBoxRechercheFournisseur.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanelRechercheAffichage.SetColumnSpan(Me.TextBoxRechercheFournisseur, 2)
        Me.TextBoxRechercheFournisseur.Location = New System.Drawing.Point(152, 43)
        Me.TextBoxRechercheFournisseur.Name = "TextBoxRechercheFournisseur"
        Me.TextBoxRechercheFournisseur.Size = New System.Drawing.Size(221, 22)
        Me.TextBoxRechercheFournisseur.TabIndex = 2
        '
        'CheckBoxRecherchePrix
        '
        Me.CheckBoxRecherchePrix.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CheckBoxRecherchePrix.AutoSize = True
        Me.CheckBoxRecherchePrix.Checked = True
        Me.CheckBoxRecherchePrix.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxRecherchePrix.Location = New System.Drawing.Point(16, 9)
        Me.CheckBoxRecherchePrix.Name = "CheckBoxRecherchePrix"
        Me.CheckBoxRecherchePrix.Size = New System.Drawing.Size(18, 17)
        Me.CheckBoxRecherchePrix.TabIndex = 5
        Me.CheckBoxRecherchePrix.UseVisualStyleBackColor = True
        '
        'LabelRecherchePrix
        '
        Me.LabelRecherchePrix.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelRecherchePrix.AutoSize = True
        Me.LabelRecherchePrix.Location = New System.Drawing.Point(55, 9)
        Me.LabelRecherchePrix.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelRecherchePrix.Name = "LabelRecherchePrix"
        Me.LabelRecherchePrix.Size = New System.Drawing.Size(94, 17)
        Me.LabelRecherchePrix.TabIndex = 4
        Me.LabelRecherchePrix.Text = "Prix min/max :"
        '
        'NumericUpDownRecherchePrixMin
        '
        Me.NumericUpDownRecherchePrixMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDownRecherchePrixMin.DecimalPlaces = 2
        Me.NumericUpDownRecherchePrixMin.Location = New System.Drawing.Point(152, 7)
        Me.NumericUpDownRecherchePrixMin.Name = "NumericUpDownRecherchePrixMin"
        Me.NumericUpDownRecherchePrixMin.Size = New System.Drawing.Size(106, 22)
        Me.NumericUpDownRecherchePrixMin.TabIndex = 5
        '
        'ButtonCommander
        '
        Me.ButtonCommander.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonCommander.Location = New System.Drawing.Point(391, 336)
        Me.ButtonCommander.Name = "ButtonCommander"
        Me.ButtonCommander.Size = New System.Drawing.Size(189, 34)
        Me.ButtonCommander.TabIndex = 1
        Me.ButtonCommander.Text = "Commander"
        Me.ButtonCommander.UseVisualStyleBackColor = True
        '
        'TabPageCommande
        '
        Me.TabPageCommande.Controls.Add(Me.TableLayoutPanelCommande)
        Me.TabPageCommande.Location = New System.Drawing.Point(4, 4)
        Me.TabPageCommande.Name = "TabPageCommande"
        Me.TabPageCommande.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCommande.Size = New System.Drawing.Size(589, 379)
        Me.TabPageCommande.TabIndex = 1
        Me.TabPageCommande.Text = "Commande"
        Me.TabPageCommande.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelCommande
        '
        Me.TableLayoutPanelCommande.ColumnCount = 3
        Me.TableLayoutPanelCommande.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332!))
        Me.TableLayoutPanelCommande.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanelCommande.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanelCommande.Controls.Add(Me.LabelPrixUnitaireModif, 1, 2)
        Me.TableLayoutPanelCommande.Controls.Add(Me.LabelPrixUnitaire, 0, 2)
        Me.TableLayoutPanelCommande.Controls.Add(Me.LabelFournisseurModif, 1, 1)
        Me.TableLayoutPanelCommande.Controls.Add(Me.LabelNomModif, 1, 0)
        Me.TableLayoutPanelCommande.Controls.Add(Me.LabelNom, 0, 0)
        Me.TableLayoutPanelCommande.Controls.Add(Me.LabelFournisseur, 0, 1)
        Me.TableLayoutPanelCommande.Controls.Add(Me.NumericUpDownQuantite, 1, 4)
        Me.TableLayoutPanelCommande.Controls.Add(Me.LabelQuantite, 0, 4)
        Me.TableLayoutPanelCommande.Controls.Add(Me.LabelPrixTotalModif, 1, 7)
        Me.TableLayoutPanelCommande.Controls.Add(Me.LabelDate, 0, 3)
        Me.TableLayoutPanelCommande.Controls.Add(Me.DateTimePickerCommande, 1, 3)
        Me.TableLayoutPanelCommande.Controls.Add(Me.ButtonAnnuler, 2, 6)
        Me.TableLayoutPanelCommande.Controls.Add(Me.ButtonConfirmer, 2, 7)
        Me.TableLayoutPanelCommande.Controls.Add(Me.LabelPrixTotal, 0, 7)
        Me.TableLayoutPanelCommande.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelCommande.Enabled = False
        Me.TableLayoutPanelCommande.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanelCommande.Name = "TableLayoutPanelCommande"
        Me.TableLayoutPanelCommande.RowCount = 7
        Me.TableLayoutPanelCommande.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelCommande.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelCommande.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelCommande.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelCommande.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelCommande.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelCommande.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelCommande.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanelCommande.Size = New System.Drawing.Size(583, 373)
        Me.TableLayoutPanelCommande.TabIndex = 0
        '
        'LabelPrixUnitaireModif
        '
        Me.LabelPrixUnitaireModif.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelPrixUnitaireModif.AutoSize = True
        Me.LabelPrixUnitaireModif.Location = New System.Drawing.Point(194, 91)
        Me.LabelPrixUnitaireModif.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelPrixUnitaireModif.Name = "LabelPrixUnitaireModif"
        Me.LabelPrixUnitaireModif.Size = New System.Drawing.Size(0, 17)
        Me.LabelPrixUnitaireModif.TabIndex = 7
        '
        'LabelPrixUnitaire
        '
        Me.LabelPrixUnitaire.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelPrixUnitaire.AutoSize = True
        Me.LabelPrixUnitaire.Location = New System.Drawing.Point(102, 91)
        Me.LabelPrixUnitaire.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelPrixUnitaire.Name = "LabelPrixUnitaire"
        Me.LabelPrixUnitaire.Size = New System.Drawing.Size(92, 17)
        Me.LabelPrixUnitaire.TabIndex = 6
        Me.LabelPrixUnitaire.Text = "Prix Unitaire :"
        '
        'LabelFournisseurModif
        '
        Me.LabelFournisseurModif.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelFournisseurModif.AutoSize = True
        Me.LabelFournisseurModif.Location = New System.Drawing.Point(194, 51)
        Me.LabelFournisseurModif.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelFournisseurModif.Name = "LabelFournisseurModif"
        Me.LabelFournisseurModif.Size = New System.Drawing.Size(0, 17)
        Me.LabelFournisseurModif.TabIndex = 5
        '
        'LabelNomModif
        '
        Me.LabelNomModif.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelNomModif.AutoSize = True
        Me.LabelNomModif.Location = New System.Drawing.Point(194, 11)
        Me.LabelNomModif.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelNomModif.Name = "LabelNomModif"
        Me.LabelNomModif.Size = New System.Drawing.Size(0, 17)
        Me.LabelNomModif.TabIndex = 4
        '
        'LabelNom
        '
        Me.LabelNom.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(149, 11)
        Me.LabelNom.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(45, 17)
        Me.LabelNom.TabIndex = 0
        Me.LabelNom.Text = "Nom :"
        '
        'LabelFournisseur
        '
        Me.LabelFournisseur.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelFournisseur.AutoSize = True
        Me.LabelFournisseur.Location = New System.Drawing.Point(103, 51)
        Me.LabelFournisseur.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelFournisseur.Name = "LabelFournisseur"
        Me.LabelFournisseur.Size = New System.Drawing.Size(91, 17)
        Me.LabelFournisseur.TabIndex = 3
        Me.LabelFournisseur.Text = "Fournisseur :"
        '
        'NumericUpDownQuantite
        '
        Me.NumericUpDownQuantite.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDownQuantite.Location = New System.Drawing.Point(197, 169)
        Me.NumericUpDownQuantite.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownQuantite.Name = "NumericUpDownQuantite"
        Me.NumericUpDownQuantite.Size = New System.Drawing.Size(188, 22)
        Me.NumericUpDownQuantite.TabIndex = 9
        Me.NumericUpDownQuantite.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LabelQuantite
        '
        Me.LabelQuantite.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelQuantite.AutoSize = True
        Me.LabelQuantite.Location = New System.Drawing.Point(124, 171)
        Me.LabelQuantite.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelQuantite.Name = "LabelQuantite"
        Me.LabelQuantite.Size = New System.Drawing.Size(70, 17)
        Me.LabelQuantite.TabIndex = 8
        Me.LabelQuantite.Text = "Quantité :"
        '
        'LabelPrixTotalModif
        '
        Me.LabelPrixTotalModif.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelPrixTotalModif.AutoSize = True
        Me.LabelPrixTotalModif.Location = New System.Drawing.Point(194, 344)
        Me.LabelPrixTotalModif.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelPrixTotalModif.Name = "LabelPrixTotalModif"
        Me.LabelPrixTotalModif.Size = New System.Drawing.Size(0, 17)
        Me.LabelPrixTotalModif.TabIndex = 11
        '
        'LabelPrixTotal
        '
        Me.LabelPrixTotal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelPrixTotal.AutoSize = True
        Me.LabelPrixTotal.Location = New System.Drawing.Point(119, 344)
        Me.LabelPrixTotal.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelPrixTotal.Name = "LabelPrixTotal"
        Me.LabelPrixTotal.Size = New System.Drawing.Size(75, 17)
        Me.LabelPrixTotal.TabIndex = 10
        Me.LabelPrixTotal.Text = "Prix Total :"
        '
        'LabelDate
        '
        Me.LabelDate.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Location = New System.Drawing.Point(148, 131)
        Me.LabelDate.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(46, 17)
        Me.LabelDate.TabIndex = 12
        Me.LabelDate.Text = "Date :"
        '
        'DateTimePickerCommande
        '
        Me.DateTimePickerCommande.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePickerCommande.Location = New System.Drawing.Point(197, 129)
        Me.DateTimePickerCommande.MinDate = New Date(2015, 11, 5, 0, 0, 0, 0)
        Me.DateTimePickerCommande.Name = "DateTimePickerCommande"
        Me.DateTimePickerCommande.Size = New System.Drawing.Size(188, 22)
        Me.DateTimePickerCommande.TabIndex = 13
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAnnuler.Location = New System.Drawing.Point(391, 296)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(189, 34)
        Me.ButtonAnnuler.TabIndex = 15
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = True
        '
        'ButtonConfirmer
        '
        Me.ButtonConfirmer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonConfirmer.Location = New System.Drawing.Point(391, 336)
        Me.ButtonConfirmer.Name = "ButtonConfirmer"
        Me.ButtonConfirmer.Size = New System.Drawing.Size(189, 34)
        Me.ButtonConfirmer.TabIndex = 14
        Me.ButtonConfirmer.Text = "Effectuer la commande"
        Me.ButtonConfirmer.UseVisualStyleBackColor = True
        '
        'TabPageHistorique
        '
        Me.TabPageHistorique.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPageHistorique.Location = New System.Drawing.Point(4, 4)
        Me.TabPageHistorique.Name = "TabPageHistorique"
        Me.TabPageHistorique.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageHistorique.Size = New System.Drawing.Size(589, 379)
        Me.TabPageHistorique.TabIndex = 2
        Me.TabPageHistorique.Text = "Historique"
        Me.TabPageHistorique.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.Controls.Add(Me.ListViewHistorique, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxRechercherHistorique, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(583, 373)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ListViewHistorique
        '
        Me.ListViewHistorique.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderHistoriqueID, Me.ColumnHeaderHistoriqueDate, Me.ColumnHeaderHistoriqueArticle, Me.ColumnHeaderHistoriqueFournisseur, Me.ColumnHeaderHistoriqueQuantite, Me.ColumnHeaderHistoriquePrixUnitaire, Me.ColumnHeaderHistoriquePrixTotal, Me.ColumnHeaderHistoriqueSpace})
        Me.TableLayoutPanel1.SetColumnSpan(Me.ListViewHistorique, 3)
        Me.ListViewHistorique.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewHistorique.FullRowSelect = True
        Me.ListViewHistorique.Location = New System.Drawing.Point(3, 3)
        Me.ListViewHistorique.Name = "ListViewHistorique"
        Me.ListViewHistorique.Size = New System.Drawing.Size(577, 267)
        Me.ListViewHistorique.TabIndex = 0
        Me.ListViewHistorique.UseCompatibleStateImageBehavior = False
        Me.ListViewHistorique.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderHistoriqueID
        '
        Me.ColumnHeaderHistoriqueID.Text = "#"
        Me.ColumnHeaderHistoriqueID.Width = 31
        '
        'ColumnHeaderHistoriqueDate
        '
        Me.ColumnHeaderHistoriqueDate.Text = "Date"
        Me.ColumnHeaderHistoriqueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderHistoriqueDate.Width = 41
        '
        'ColumnHeaderHistoriqueArticle
        '
        Me.ColumnHeaderHistoriqueArticle.Text = "Article"
        Me.ColumnHeaderHistoriqueArticle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderHistoriqueArticle.Width = 49
        '
        'ColumnHeaderHistoriqueFournisseur
        '
        Me.ColumnHeaderHistoriqueFournisseur.Text = "Fournisseur"
        Me.ColumnHeaderHistoriqueFournisseur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderHistoriqueFournisseur.Width = 82
        '
        'ColumnHeaderHistoriqueQuantite
        '
        Me.ColumnHeaderHistoriqueQuantite.Text = "Quantité"
        Me.ColumnHeaderHistoriqueQuantite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderHistoriqueQuantite.Width = 61
        '
        'ColumnHeaderHistoriquePrixUnitaire
        '
        Me.ColumnHeaderHistoriquePrixUnitaire.Text = "Prix Unitaire"
        Me.ColumnHeaderHistoriquePrixUnitaire.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderHistoriquePrixUnitaire.Width = 83
        '
        'ColumnHeaderHistoriquePrixTotal
        '
        Me.ColumnHeaderHistoriquePrixTotal.Text = "Prix Total"
        Me.ColumnHeaderHistoriquePrixTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderHistoriquePrixTotal.Width = 68
        '
        'ColumnHeaderHistoriqueSpace
        '
        Me.ColumnHeaderHistoriqueSpace.Text = ""
        Me.ColumnHeaderHistoriqueSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderHistoriqueSpace.Width = 158
        '
        'GroupBoxRechercherHistorique
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.GroupBoxRechercherHistorique, 2)
        Me.GroupBoxRechercherHistorique.Controls.Add(Me.TableLayoutPanelRechercherHistorique)
        Me.GroupBoxRechercherHistorique.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxRechercherHistorique.Location = New System.Drawing.Point(3, 276)
        Me.GroupBoxRechercherHistorique.Name = "GroupBoxRechercherHistorique"
        Me.TableLayoutPanel1.SetRowSpan(Me.GroupBoxRechercherHistorique, 2)
        Me.GroupBoxRechercherHistorique.Size = New System.Drawing.Size(382, 94)
        Me.GroupBoxRechercherHistorique.TabIndex = 1
        Me.GroupBoxRechercherHistorique.TabStop = False
        Me.GroupBoxRechercherHistorique.Text = "Recherche"
        '
        'TableLayoutPanelRechercherHistorique
        '
        Me.TableLayoutPanelRechercherHistorique.ColumnCount = 3
        Me.TableLayoutPanelRechercherHistorique.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanelRechercherHistorique.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanelRechercherHistorique.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanelRechercherHistorique.Controls.Add(Me.CheckBoxRechercheDate, 0, 0)
        Me.TableLayoutPanelRechercherHistorique.Controls.Add(Me.LabelRechercheDate, 1, 0)
        Me.TableLayoutPanelRechercherHistorique.Controls.Add(Me.DateTimePickerRecherche, 2, 0)
        Me.TableLayoutPanelRechercherHistorique.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelRechercherHistorique.Location = New System.Drawing.Point(3, 18)
        Me.TableLayoutPanelRechercherHistorique.Name = "TableLayoutPanelRechercherHistorique"
        Me.TableLayoutPanelRechercherHistorique.RowCount = 2
        Me.TableLayoutPanelRechercherHistorique.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelRechercherHistorique.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelRechercherHistorique.Size = New System.Drawing.Size(376, 73)
        Me.TableLayoutPanelRechercherHistorique.TabIndex = 0
        '
        'CheckBoxRechercheDate
        '
        Me.CheckBoxRechercheDate.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CheckBoxRechercheDate.AutoSize = True
        Me.CheckBoxRechercheDate.Location = New System.Drawing.Point(16, 9)
        Me.CheckBoxRechercheDate.Name = "CheckBoxRechercheDate"
        Me.CheckBoxRechercheDate.Size = New System.Drawing.Size(18, 17)
        Me.CheckBoxRechercheDate.TabIndex = 0
        Me.CheckBoxRechercheDate.UseVisualStyleBackColor = True
        '
        'LabelRechercheDate
        '
        Me.LabelRechercheDate.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelRechercheDate.AutoSize = True
        Me.LabelRechercheDate.Location = New System.Drawing.Point(103, 9)
        Me.LabelRechercheDate.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelRechercheDate.Name = "LabelRechercheDate"
        Me.LabelRechercheDate.Size = New System.Drawing.Size(46, 17)
        Me.LabelRechercheDate.TabIndex = 1
        Me.LabelRechercheDate.Text = "Date :"
        '
        'DateTimePickerRecherche
        '
        Me.DateTimePickerRecherche.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePickerRecherche.Location = New System.Drawing.Point(152, 7)
        Me.DateTimePickerRecherche.Name = "DateTimePickerRecherche"
        Me.DateTimePickerRecherche.Size = New System.Drawing.Size(221, 22)
        Me.DateTimePickerRecherche.TabIndex = 2
        '
        'Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 436)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Window"
        Me.Text = "Inventaire"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabPageAfficher.ResumeLayout(False)
        Me.TableLayoutPanelAffichage.ResumeLayout(False)
        Me.GroupBoxRechercherAffichage.ResumeLayout(False)
        Me.TableLayoutPanelRechercheAffichage.ResumeLayout(False)
        Me.TableLayoutPanelRechercheAffichage.PerformLayout()
        CType(Me.NumericUpDownRecherchePrixMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownRecherchePrixMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCommande.ResumeLayout(False)
        Me.TableLayoutPanelCommande.ResumeLayout(False)
        Me.TableLayoutPanelCommande.PerformLayout()
        CType(Me.NumericUpDownQuantite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageHistorique.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBoxRechercherHistorique.ResumeLayout(False)
        Me.TableLayoutPanelRechercherHistorique.ResumeLayout(False)
        Me.TableLayoutPanelRechercherHistorique.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents OuvrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArticleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPageAfficher As TabPage
    Friend WithEvents TableLayoutPanelAffichage As TableLayoutPanel
    Friend WithEvents ListViewAffichage As ListView
    Friend WithEvents TabPageCommande As TabPage
    Friend WithEvents ColumnHeaderAffichageNumero As ColumnHeader
    Friend WithEvents ColumnHeaderAffichageNom As ColumnHeader
    Friend WithEvents ColumnHeaderAffichagePrix As ColumnHeader
    Friend WithEvents ColumnHeaderAffichageQuantite As ColumnHeader
    Friend WithEvents ColumnHeaderAffichageFournisseur As ColumnHeader
    Friend WithEvents TableLayoutPanelCommande As TableLayoutPanel
    Friend WithEvents LabelNom As Label
    Friend WithEvents ButtonCommander As Button
    Friend WithEvents LabelQuantite As Label
    Friend WithEvents LabelPrixUnitaireModif As Label
    Friend WithEvents LabelPrixUnitaire As Label
    Friend WithEvents LabelFournisseurModif As Label
    Friend WithEvents LabelNomModif As Label
    Friend WithEvents LabelFournisseur As Label
    Friend WithEvents NumericUpDownQuantite As NumericUpDown
    Friend WithEvents LabelPrixTotal As Label
    Friend WithEvents LabelPrixTotalModif As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents DateTimePickerCommande As DateTimePicker
    Friend WithEvents ButtonConfirmer As Button
    Friend WithEvents TabPageHistorique As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ListViewHistorique As ListView
    Friend WithEvents ColumnHeaderHistoriqueID As ColumnHeader
    Friend WithEvents ColumnHeaderHistoriqueDate As ColumnHeader
    Friend WithEvents ColumnHeaderHistoriqueArticle As ColumnHeader
    Friend WithEvents ColumnHeaderHistoriqueFournisseur As ColumnHeader
    Friend WithEvents ColumnHeaderHistoriqueQuantite As ColumnHeader
    Friend WithEvents ColumnHeaderHistoriquePrixUnitaire As ColumnHeader
    Friend WithEvents ColumnHeaderHistoriquePrixTotal As ColumnHeader
    Friend WithEvents ButtonAnnuler As Button
    Friend WithEvents ColumnHeaderAffichageSpace As ColumnHeader
    Friend WithEvents ColumnHeaderHistoriqueSpace As ColumnHeader
    Friend WithEvents TextBoxRechercheFournisseur As TextBox
    Friend WithEvents LabelRechercheFournisseur As Label
    Friend WithEvents GroupBoxRechercherAffichage As GroupBox
    Friend WithEvents TableLayoutPanelRechercheAffichage As TableLayoutPanel
    Friend WithEvents NumericUpDownRecherchePrixMax As NumericUpDown
    Friend WithEvents LabelRecherchePrix As Label
    Friend WithEvents NumericUpDownRecherchePrixMin As NumericUpDown
    Friend WithEvents CheckBoxRechercheFournisseur As CheckBox
    Friend WithEvents CheckBoxRecherchePrix As CheckBox
    Friend WithEvents GroupBoxRechercherHistorique As GroupBox
    Friend WithEvents TableLayoutPanelRechercherHistorique As TableLayoutPanel
    Friend WithEvents CheckBoxRechercheDate As CheckBox
    Friend WithEvents LabelRechercheDate As Label
    Friend WithEvents DateTimePickerRecherche As DateTimePicker
End Class
