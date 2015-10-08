<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NouveauMembre
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
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.TextBoxPrenom = New System.Windows.Forms.TextBox()
        Me.ButtonAnnuler = New System.Windows.Forms.Button()
        Me.LabelAnnee = New System.Windows.Forms.Label()
        Me.ButtonAjouter = New System.Windows.Forms.Button()
        Me.TextBoxAnnee = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 2
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.47488!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.52512!))
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxAnnee, 1, 2)
        Me.TableLayoutPanel.Controls.Add(Me.LabelAnnee, 0, 2)
        Me.TableLayoutPanel.Controls.Add(Me.LabelNom, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.LabelPrenom, 0, 1)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxNom, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxPrenom, 1, 1)
        Me.TableLayoutPanel.Controls.Add(Me.ButtonAnnuler, 1, 4)
        Me.TableLayoutPanel.Controls.Add(Me.ButtonAjouter, 1, 3)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 5
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(438, 281)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'LabelNom
        '
        Me.LabelNom.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(110, 19)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(37, 17)
        Me.LabelNom.TabIndex = 0
        Me.LabelNom.Text = "Nom"
        '
        'LabelPrenom
        '
        Me.LabelPrenom.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Location = New System.Drawing.Point(90, 75)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(57, 17)
        Me.LabelPrenom.TabIndex = 1
        Me.LabelPrenom.Text = "Prénom"
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNom.Location = New System.Drawing.Point(153, 17)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(282, 22)
        Me.TextBoxNom.TabIndex = 2
        '
        'TextBoxPrenom
        '
        Me.TextBoxPrenom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPrenom.Location = New System.Drawing.Point(153, 73)
        Me.TextBoxPrenom.Name = "TextBoxPrenom"
        Me.TextBoxPrenom.Size = New System.Drawing.Size(282, 22)
        Me.TextBoxPrenom.TabIndex = 3
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAnnuler.Location = New System.Drawing.Point(153, 227)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(282, 51)
        Me.ButtonAnnuler.TabIndex = 5
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = True
        '
        'LabelAnnee
        '
        Me.LabelAnnee.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelAnnee.AutoSize = True
        Me.LabelAnnee.Location = New System.Drawing.Point(8, 131)
        Me.LabelAnnee.Name = "LabelAnnee"
        Me.LabelAnnee.Size = New System.Drawing.Size(139, 17)
        Me.LabelAnnee.TabIndex = 6
        Me.LabelAnnee.Text = "Année de Naissance"
        '
        'ButtonAjouter
        '
        Me.ButtonAjouter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAjouter.Location = New System.Drawing.Point(153, 171)
        Me.ButtonAjouter.Name = "ButtonAjouter"
        Me.ButtonAjouter.Size = New System.Drawing.Size(282, 50)
        Me.ButtonAjouter.TabIndex = 4
        Me.ButtonAjouter.Text = "Ajouter"
        Me.ButtonAjouter.UseVisualStyleBackColor = True
        '
        'TextBoxAnnee
        '
        Me.TextBoxAnnee.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxAnnee.Location = New System.Drawing.Point(153, 129)
        Me.TextBoxAnnee.Name = "TextBoxAnnee"
        Me.TextBoxAnnee.Size = New System.Drawing.Size(282, 22)
        Me.TextBoxAnnee.TabIndex = 7
        '
        'NouveauMembre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 281)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.Name = "NouveauMembre"
        Me.Text = "Nouveau Membre"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel As TableLayoutPanel
    Friend WithEvents TextBoxPrenom As TextBox
    Friend WithEvents LabelNom As Label
    Friend WithEvents LabelPrenom As Label
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents TextBoxAnnee As TextBox
    Friend WithEvents LabelAnnee As Label
    Friend WithEvents ButtonAnnuler As Button
    Friend WithEvents ButtonAjouter As Button
End Class
