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
        Me.ImporterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MembreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ListBoxInventaire = New System.Windows.Forms.ListBox()
        Me.LabelIdentifiant = New System.Windows.Forms.Label()
        Me.TextBoxIdentifiant = New System.Windows.Forms.TextBox()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.LabelPrix = New System.Windows.Forms.Label()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.TextBoxPrix = New System.Windows.Forms.TextBox()
        Me.LabelQuantite = New System.Windows.Forms.Label()
        Me.TextBoxQuantite = New System.Windows.Forms.TextBox()
        Me.LabelSousTotal = New System.Windows.Forms.Label()
        Me.TextBoxSousTotal = New System.Windows.Forms.TextBox()
        Me.ListBoxPanier = New System.Windows.Forms.ListBox()
        Me.ButtonAjouter = New System.Windows.Forms.Button()
        Me.ButtonTerminer = New System.Windows.Forms.Button()
        Me.LabelStatut = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.MembreToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1022, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImporterToolStripMenuItem, Me.ToolStripSeparator1, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'ImporterToolStripMenuItem
        '
        Me.ImporterToolStripMenuItem.Name = "ImporterToolStripMenuItem"
        Me.ImporterToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.ImporterToolStripMenuItem.Text = "Importer"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(139, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'MembreToolStripMenuItem
        '
        Me.MembreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauToolStripMenuItem})
        Me.MembreToolStripMenuItem.Name = "MembreToolStripMenuItem"
        Me.MembreToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.MembreToolStripMenuItem.Text = "Membre"
        '
        'NouveauToolStripMenuItem
        '
        Me.NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem"
        Me.NouveauToolStripMenuItem.Size = New System.Drawing.Size(143, 26)
        Me.NouveauToolStripMenuItem.Text = "Nouveau"
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 5
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.1708!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.8292!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 378.0!))
        Me.TableLayoutPanel.Controls.Add(Me.ListBoxInventaire, 0, 1)
        Me.TableLayoutPanel.Controls.Add(Me.LabelIdentifiant, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxIdentifiant, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.LabelNom, 2, 1)
        Me.TableLayoutPanel.Controls.Add(Me.LabelPrix, 2, 2)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxNom, 3, 1)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxPrix, 3, 2)
        Me.TableLayoutPanel.Controls.Add(Me.LabelQuantite, 2, 3)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxQuantite, 3, 3)
        Me.TableLayoutPanel.Controls.Add(Me.LabelSousTotal, 2, 4)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxSousTotal, 3, 4)
        Me.TableLayoutPanel.Controls.Add(Me.ListBoxPanier, 4, 1)
        Me.TableLayoutPanel.Controls.Add(Me.ButtonAjouter, 3, 5)
        Me.TableLayoutPanel.Controls.Add(Me.ButtonTerminer, 3, 6)
        Me.TableLayoutPanel.Controls.Add(Me.LabelStatut, 2, 0)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(0, 28)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 8
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(1022, 378)
        Me.TableLayoutPanel.TabIndex = 2
        '
        'ListBoxInventaire
        '
        Me.TableLayoutPanel.SetColumnSpan(Me.ListBoxInventaire, 2)
        Me.ListBoxInventaire.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxInventaire.Enabled = False
        Me.ListBoxInventaire.FormattingEnabled = True
        Me.ListBoxInventaire.ItemHeight = 16
        Me.ListBoxInventaire.Location = New System.Drawing.Point(3, 40)
        Me.ListBoxInventaire.Name = "ListBoxInventaire"
        Me.TableLayoutPanel.SetRowSpan(Me.ListBoxInventaire, 7)
        Me.ListBoxInventaire.Size = New System.Drawing.Size(320, 335)
        Me.ListBoxInventaire.TabIndex = 0
        '
        'LabelIdentifiant
        '
        Me.LabelIdentifiant.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelIdentifiant.AutoSize = True
        Me.LabelIdentifiant.Location = New System.Drawing.Point(13, 10)
        Me.LabelIdentifiant.Name = "LabelIdentifiant"
        Me.LabelIdentifiant.Size = New System.Drawing.Size(69, 17)
        Me.LabelIdentifiant.TabIndex = 1
        Me.LabelIdentifiant.Text = "Identifiant"
        '
        'TextBoxIdentifiant
        '
        Me.TextBoxIdentifiant.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxIdentifiant.Enabled = False
        Me.TextBoxIdentifiant.Location = New System.Drawing.Point(88, 7)
        Me.TextBoxIdentifiant.Name = "TextBoxIdentifiant"
        Me.TextBoxIdentifiant.Size = New System.Drawing.Size(235, 22)
        Me.TextBoxIdentifiant.TabIndex = 2
        '
        'LabelNom
        '
        Me.LabelNom.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(391, 47)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(37, 17)
        Me.LabelNom.TabIndex = 5
        Me.LabelNom.Text = "Nom"
        '
        'LabelPrix
        '
        Me.LabelPrix.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelPrix.AutoSize = True
        Me.LabelPrix.Location = New System.Drawing.Point(397, 84)
        Me.LabelPrix.Name = "LabelPrix"
        Me.LabelPrix.Size = New System.Drawing.Size(31, 17)
        Me.LabelPrix.TabIndex = 4
        Me.LabelPrix.Text = "Prix"
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNom.Enabled = False
        Me.TextBoxNom.Location = New System.Drawing.Point(434, 44)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(206, 22)
        Me.TextBoxNom.TabIndex = 6
        '
        'TextBoxPrix
        '
        Me.TextBoxPrix.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPrix.Enabled = False
        Me.TextBoxPrix.Location = New System.Drawing.Point(434, 81)
        Me.TextBoxPrix.Name = "TextBoxPrix"
        Me.TextBoxPrix.Size = New System.Drawing.Size(206, 22)
        Me.TextBoxPrix.TabIndex = 7
        '
        'LabelQuantite
        '
        Me.LabelQuantite.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelQuantite.AutoSize = True
        Me.LabelQuantite.Location = New System.Drawing.Point(366, 121)
        Me.LabelQuantite.Name = "LabelQuantite"
        Me.LabelQuantite.Size = New System.Drawing.Size(62, 17)
        Me.LabelQuantite.TabIndex = 8
        Me.LabelQuantite.Text = "Quantité"
        '
        'TextBoxQuantite
        '
        Me.TextBoxQuantite.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxQuantite.Enabled = False
        Me.TextBoxQuantite.Location = New System.Drawing.Point(434, 118)
        Me.TextBoxQuantite.Name = "TextBoxQuantite"
        Me.TextBoxQuantite.Size = New System.Drawing.Size(206, 22)
        Me.TextBoxQuantite.TabIndex = 9
        '
        'LabelSousTotal
        '
        Me.LabelSousTotal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelSousTotal.AutoSize = True
        Me.LabelSousTotal.Location = New System.Drawing.Point(351, 158)
        Me.LabelSousTotal.Name = "LabelSousTotal"
        Me.LabelSousTotal.Size = New System.Drawing.Size(77, 17)
        Me.LabelSousTotal.TabIndex = 10
        Me.LabelSousTotal.Text = "Sous-Total"
        '
        'TextBoxSousTotal
        '
        Me.TextBoxSousTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSousTotal.Enabled = False
        Me.TextBoxSousTotal.Location = New System.Drawing.Point(434, 155)
        Me.TextBoxSousTotal.Name = "TextBoxSousTotal"
        Me.TextBoxSousTotal.Size = New System.Drawing.Size(206, 22)
        Me.TextBoxSousTotal.TabIndex = 11
        '
        'ListBoxPanier
        '
        Me.ListBoxPanier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxPanier.FormattingEnabled = True
        Me.ListBoxPanier.ItemHeight = 16
        Me.ListBoxPanier.Location = New System.Drawing.Point(646, 40)
        Me.ListBoxPanier.Name = "ListBoxPanier"
        Me.TableLayoutPanel.SetRowSpan(Me.ListBoxPanier, 7)
        Me.ListBoxPanier.Size = New System.Drawing.Size(373, 335)
        Me.ListBoxPanier.TabIndex = 12
        '
        'ButtonAjouter
        '
        Me.ButtonAjouter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAjouter.Enabled = False
        Me.ButtonAjouter.Location = New System.Drawing.Point(434, 188)
        Me.ButtonAjouter.Name = "ButtonAjouter"
        Me.ButtonAjouter.Size = New System.Drawing.Size(206, 31)
        Me.ButtonAjouter.TabIndex = 13
        Me.ButtonAjouter.Text = "Ajouter"
        Me.ButtonAjouter.UseVisualStyleBackColor = True
        '
        'ButtonTerminer
        '
        Me.ButtonTerminer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonTerminer.Enabled = False
        Me.ButtonTerminer.Location = New System.Drawing.Point(434, 225)
        Me.ButtonTerminer.Name = "ButtonTerminer"
        Me.ButtonTerminer.Size = New System.Drawing.Size(206, 31)
        Me.ButtonTerminer.TabIndex = 14
        Me.ButtonTerminer.Text = "Terminer"
        Me.ButtonTerminer.UseVisualStyleBackColor = True
        '
        'LabelStatut
        '
        Me.LabelStatut.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelStatut.AutoSize = True
        Me.LabelStatut.Location = New System.Drawing.Point(329, 10)
        Me.LabelStatut.Name = "LabelStatut"
        Me.LabelStatut.Size = New System.Drawing.Size(73, 17)
        Me.LabelStatut.TabIndex = 15
        Me.LabelStatut.Text = "ID Invalide"
        '
        'Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 406)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Window"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImporterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel As TableLayoutPanel
    Friend WithEvents ListBoxInventaire As ListBox
    Friend WithEvents MembreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NouveauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelIdentifiant As Label
    Friend WithEvents TextBoxIdentifiant As TextBox
    Friend WithEvents LabelNom As Label
    Friend WithEvents LabelPrix As Label
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents TextBoxPrix As TextBox
    Friend WithEvents LabelQuantite As Label
    Friend WithEvents TextBoxQuantite As TextBox
    Friend WithEvents LabelSousTotal As Label
    Friend WithEvents TextBoxSousTotal As TextBox
    Friend WithEvents ListBoxPanier As ListBox
    Friend WithEvents ButtonAjouter As Button
    Friend WithEvents ButtonTerminer As Button
    Friend WithEvents LabelStatut As Label
End Class
