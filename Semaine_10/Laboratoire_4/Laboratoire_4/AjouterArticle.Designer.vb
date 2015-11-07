<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjouterArticle
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
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonAjouter = New System.Windows.Forms.Button()
        Me.ButtonAnnuler = New System.Windows.Forms.Button()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.LabelPrix = New System.Windows.Forms.Label()
        Me.LabelQuantite = New System.Windows.Forms.Label()
        Me.LabelFournisseur = New System.Windows.Forms.Label()
        Me.NumericUpDownPrix = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownQuantite = New System.Windows.Forms.NumericUpDown()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.ComboBoxFournisseur = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel.SuspendLayout()
        CType(Me.NumericUpDownPrix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownQuantite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 2
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.Controls.Add(Me.ButtonAjouter, 1, 4)
        Me.TableLayoutPanel.Controls.Add(Me.ButtonAnnuler, 1, 5)
        Me.TableLayoutPanel.Controls.Add(Me.LabelNom, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.LabelPrix, 0, 1)
        Me.TableLayoutPanel.Controls.Add(Me.LabelQuantite, 0, 2)
        Me.TableLayoutPanel.Controls.Add(Me.LabelFournisseur, 0, 3)
        Me.TableLayoutPanel.Controls.Add(Me.NumericUpDownPrix, 1, 1)
        Me.TableLayoutPanel.Controls.Add(Me.NumericUpDownQuantite, 1, 2)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxNom, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.ComboBoxFournisseur, 1, 3)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 6
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(393, 220)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'ButtonAjouter
        '
        Me.ButtonAjouter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAjouter.Location = New System.Drawing.Point(199, 135)
        Me.ButtonAjouter.Name = "ButtonAjouter"
        Me.ButtonAjouter.Size = New System.Drawing.Size(191, 38)
        Me.ButtonAjouter.TabIndex = 0
        Me.ButtonAjouter.Text = "Ajouter"
        Me.ButtonAjouter.UseVisualStyleBackColor = True
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAnnuler.Location = New System.Drawing.Point(199, 179)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(191, 38)
        Me.ButtonAnnuler.TabIndex = 1
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = True
        '
        'LabelNom
        '
        Me.LabelNom.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(156, 8)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(37, 17)
        Me.LabelNom.TabIndex = 2
        Me.LabelNom.Text = "Nom"
        '
        'LabelPrix
        '
        Me.LabelPrix.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelPrix.AutoSize = True
        Me.LabelPrix.Location = New System.Drawing.Point(162, 41)
        Me.LabelPrix.Name = "LabelPrix"
        Me.LabelPrix.Size = New System.Drawing.Size(31, 17)
        Me.LabelPrix.TabIndex = 3
        Me.LabelPrix.Text = "Prix"
        '
        'LabelQuantite
        '
        Me.LabelQuantite.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelQuantite.AutoSize = True
        Me.LabelQuantite.Location = New System.Drawing.Point(131, 74)
        Me.LabelQuantite.Name = "LabelQuantite"
        Me.LabelQuantite.Size = New System.Drawing.Size(62, 17)
        Me.LabelQuantite.TabIndex = 4
        Me.LabelQuantite.Text = "Quantité"
        '
        'LabelFournisseur
        '
        Me.LabelFournisseur.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelFournisseur.AutoSize = True
        Me.LabelFournisseur.Location = New System.Drawing.Point(110, 107)
        Me.LabelFournisseur.Name = "LabelFournisseur"
        Me.LabelFournisseur.Size = New System.Drawing.Size(83, 17)
        Me.LabelFournisseur.TabIndex = 5
        Me.LabelFournisseur.Text = "Fournisseur"
        '
        'NumericUpDownPrix
        '
        Me.NumericUpDownPrix.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDownPrix.DecimalPlaces = 2
        Me.NumericUpDownPrix.Location = New System.Drawing.Point(199, 38)
        Me.NumericUpDownPrix.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumericUpDownPrix.Name = "NumericUpDownPrix"
        Me.NumericUpDownPrix.Size = New System.Drawing.Size(191, 22)
        Me.NumericUpDownPrix.TabIndex = 6
        '
        'NumericUpDownQuantite
        '
        Me.NumericUpDownQuantite.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDownQuantite.Location = New System.Drawing.Point(199, 71)
        Me.NumericUpDownQuantite.Name = "NumericUpDownQuantite"
        Me.NumericUpDownQuantite.Size = New System.Drawing.Size(191, 22)
        Me.NumericUpDownQuantite.TabIndex = 7
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNom.Location = New System.Drawing.Point(199, 5)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(191, 22)
        Me.TextBoxNom.TabIndex = 8
        '
        'ComboBoxFournisseur
        '
        Me.ComboBoxFournisseur.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxFournisseur.FormattingEnabled = True
        Me.ComboBoxFournisseur.Location = New System.Drawing.Point(199, 103)
        Me.ComboBoxFournisseur.Name = "ComboBoxFournisseur"
        Me.ComboBoxFournisseur.Size = New System.Drawing.Size(191, 24)
        Me.ComboBoxFournisseur.TabIndex = 9
        '
        'AjouterArticle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 220)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.Name = "AjouterArticle"
        Me.Text = "Ajout"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        CType(Me.NumericUpDownPrix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownQuantite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel As TableLayoutPanel
    Friend WithEvents ButtonAjouter As Button
    Friend WithEvents ButtonAnnuler As Button
    Friend WithEvents LabelNom As Label
    Friend WithEvents LabelPrix As Label
    Friend WithEvents LabelQuantite As Label
    Friend WithEvents LabelFournisseur As Label
    Friend WithEvents NumericUpDownPrix As NumericUpDown
    Friend WithEvents NumericUpDownQuantite As NumericUpDown
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents ComboBoxFournisseur As ComboBox
End Class
