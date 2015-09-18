<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulaire
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
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.TextBoxPrenom = New System.Windows.Forms.TextBox()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.LabelTaux = New System.Windows.Forms.Label()
        Me.TextBoxTaux = New System.Windows.Forms.TextBox()
        Me.TextBoxHeure = New System.Windows.Forms.TextBox()
        Me.LabelHeure = New System.Windows.Forms.Label()
        Me.ButtonConfirmer = New System.Windows.Forms.Button()
        Me.ButtonAnnuler = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Location = New System.Drawing.Point(45, 15)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(57, 17)
        Me.LabelPrenom.TabIndex = 0
        Me.LabelPrenom.Text = "Prénom"
        '
        'TextBoxPrenom
        '
        Me.TextBoxPrenom.Location = New System.Drawing.Point(108, 12)
        Me.TextBoxPrenom.Name = "TextBoxPrenom"
        Me.TextBoxPrenom.Size = New System.Drawing.Size(194, 22)
        Me.TextBoxPrenom.TabIndex = 1
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(65, 43)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(37, 17)
        Me.LabelNom.TabIndex = 2
        Me.LabelNom.Text = "Nom"
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Location = New System.Drawing.Point(108, 40)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(194, 22)
        Me.TextBoxNom.TabIndex = 3
        '
        'LabelTaux
        '
        Me.LabelTaux.AutoSize = True
        Me.LabelTaux.Location = New System.Drawing.Point(12, 71)
        Me.LabelTaux.Name = "LabelTaux"
        Me.LabelTaux.Size = New System.Drawing.Size(90, 17)
        Me.LabelTaux.TabIndex = 4
        Me.LabelTaux.Text = "Taux Horaire"
        '
        'TextBoxTaux
        '
        Me.TextBoxTaux.Location = New System.Drawing.Point(108, 68)
        Me.TextBoxTaux.Name = "TextBoxTaux"
        Me.TextBoxTaux.Size = New System.Drawing.Size(194, 22)
        Me.TextBoxTaux.TabIndex = 5
        '
        'TextBoxHeure
        '
        Me.TextBoxHeure.Location = New System.Drawing.Point(108, 96)
        Me.TextBoxHeure.Name = "TextBoxHeure"
        Me.TextBoxHeure.Size = New System.Drawing.Size(194, 22)
        Me.TextBoxHeure.TabIndex = 6
        '
        'LabelHeure
        '
        Me.LabelHeure.AutoSize = True
        Me.LabelHeure.Location = New System.Drawing.Point(55, 99)
        Me.LabelHeure.Name = "LabelHeure"
        Me.LabelHeure.Size = New System.Drawing.Size(47, 17)
        Me.LabelHeure.TabIndex = 7
        Me.LabelHeure.Text = "Heure"
        '
        'ButtonConfirmer
        '
        Me.ButtonConfirmer.Location = New System.Drawing.Point(12, 124)
        Me.ButtonConfirmer.Name = "ButtonConfirmer"
        Me.ButtonConfirmer.Size = New System.Drawing.Size(290, 36)
        Me.ButtonConfirmer.TabIndex = 8
        Me.ButtonConfirmer.Text = "Confirmer"
        Me.ButtonConfirmer.UseVisualStyleBackColor = True
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.Location = New System.Drawing.Point(12, 166)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(290, 36)
        Me.ButtonAnnuler.TabIndex = 9
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = True
        '
        'Formulaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 215)
        Me.Controls.Add(Me.ButtonAnnuler)
        Me.Controls.Add(Me.ButtonConfirmer)
        Me.Controls.Add(Me.LabelHeure)
        Me.Controls.Add(Me.TextBoxHeure)
        Me.Controls.Add(Me.TextBoxTaux)
        Me.Controls.Add(Me.LabelTaux)
        Me.Controls.Add(Me.TextBoxNom)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.TextBoxPrenom)
        Me.Controls.Add(Me.LabelPrenom)
        Me.Name = "Formulaire"
        Me.Text = "Formulaire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelPrenom As Label
    Friend WithEvents TextBoxPrenom As TextBox
    Friend WithEvents LabelNom As Label
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents LabelTaux As Label
    Friend WithEvents TextBoxTaux As TextBox
    Friend WithEvents TextBoxHeure As TextBox
    Friend WithEvents LabelHeure As Label
    Friend WithEvents ButtonConfirmer As Button
    Friend WithEvents ButtonAnnuler As Button
End Class
