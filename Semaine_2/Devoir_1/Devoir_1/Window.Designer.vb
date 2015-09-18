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
        Me.GroupBoxAjout = New System.Windows.Forms.GroupBox()
        Me.ButtonAjouter = New System.Windows.Forms.Button()
        Me.AjoutDepartement = New System.Windows.Forms.Label()
        Me.AjoutPrenom = New System.Windows.Forms.Label()
        Me.TextBoxAjoutDepartement = New System.Windows.Forms.TextBox()
        Me.TextBoxAjoutPrenom = New System.Windows.Forms.TextBox()
        Me.TextBoxAjoutNom = New System.Windows.Forms.TextBox()
        Me.AjoutNom = New System.Windows.Forms.Label()
        Me.GroupBoxModification = New System.Windows.Forms.GroupBox()
        Me.ButtonPrecedent = New System.Windows.Forms.Button()
        Me.ButtonSuivant = New System.Windows.Forms.Button()
        Me.ModifDepartement = New System.Windows.Forms.Label()
        Me.ModifPrenom = New System.Windows.Forms.Label()
        Me.TextBoxModifDepartement = New System.Windows.Forms.TextBox()
        Me.TextBoxModifPrenom = New System.Windows.Forms.TextBox()
        Me.TextBoxModifNom = New System.Windows.Forms.TextBox()
        Me.ModifNom = New System.Windows.Forms.Label()
        Me.LabelQuantite = New System.Windows.Forms.Label()
        Me.GroupBoxAjout.SuspendLayout()
        Me.GroupBoxModification.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxAjout
        '
        Me.GroupBoxAjout.Controls.Add(Me.ButtonAjouter)
        Me.GroupBoxAjout.Controls.Add(Me.AjoutDepartement)
        Me.GroupBoxAjout.Controls.Add(Me.AjoutPrenom)
        Me.GroupBoxAjout.Controls.Add(Me.TextBoxAjoutDepartement)
        Me.GroupBoxAjout.Controls.Add(Me.TextBoxAjoutPrenom)
        Me.GroupBoxAjout.Controls.Add(Me.TextBoxAjoutNom)
        Me.GroupBoxAjout.Controls.Add(Me.AjoutNom)
        Me.GroupBoxAjout.Location = New System.Drawing.Point(13, 13)
        Me.GroupBoxAjout.Name = "GroupBoxAjout"
        Me.GroupBoxAjout.Size = New System.Drawing.Size(450, 142)
        Me.GroupBoxAjout.TabIndex = 0
        Me.GroupBoxAjout.TabStop = False
        Me.GroupBoxAjout.Text = "Ajout"
        '
        'ButtonAjouter
        '
        Me.ButtonAjouter.Location = New System.Drawing.Point(353, 108)
        Me.ButtonAjouter.Name = "ButtonAjouter"
        Me.ButtonAjouter.Size = New System.Drawing.Size(91, 28)
        Me.ButtonAjouter.TabIndex = 6
        Me.ButtonAjouter.Text = "Ajouter"
        Me.ButtonAjouter.UseVisualStyleBackColor = True
        '
        'AjoutDepartement
        '
        Me.AjoutDepartement.AutoSize = True
        Me.AjoutDepartement.Location = New System.Drawing.Point(6, 85)
        Me.AjoutDepartement.Name = "AjoutDepartement"
        Me.AjoutDepartement.Size = New System.Drawing.Size(90, 17)
        Me.AjoutDepartement.TabIndex = 5
        Me.AjoutDepartement.Text = "Département"
        '
        'AjoutPrenom
        '
        Me.AjoutPrenom.AutoSize = True
        Me.AjoutPrenom.Location = New System.Drawing.Point(6, 56)
        Me.AjoutPrenom.Name = "AjoutPrenom"
        Me.AjoutPrenom.Size = New System.Drawing.Size(57, 17)
        Me.AjoutPrenom.TabIndex = 4
        Me.AjoutPrenom.Text = "Prénom"
        '
        'TextBoxAjoutDepartement
        '
        Me.TextBoxAjoutDepartement.Location = New System.Drawing.Point(102, 80)
        Me.TextBoxAjoutDepartement.Name = "TextBoxAjoutDepartement"
        Me.TextBoxAjoutDepartement.Size = New System.Drawing.Size(342, 22)
        Me.TextBoxAjoutDepartement.TabIndex = 3
        '
        'TextBoxAjoutPrenom
        '
        Me.TextBoxAjoutPrenom.Location = New System.Drawing.Point(102, 51)
        Me.TextBoxAjoutPrenom.Name = "TextBoxAjoutPrenom"
        Me.TextBoxAjoutPrenom.Size = New System.Drawing.Size(342, 22)
        Me.TextBoxAjoutPrenom.TabIndex = 2
        '
        'TextBoxAjoutNom
        '
        Me.TextBoxAjoutNom.Location = New System.Drawing.Point(102, 22)
        Me.TextBoxAjoutNom.Name = "TextBoxAjoutNom"
        Me.TextBoxAjoutNom.Size = New System.Drawing.Size(342, 22)
        Me.TextBoxAjoutNom.TabIndex = 1
        '
        'AjoutNom
        '
        Me.AjoutNom.AutoSize = True
        Me.AjoutNom.Location = New System.Drawing.Point(6, 25)
        Me.AjoutNom.Name = "AjoutNom"
        Me.AjoutNom.Size = New System.Drawing.Size(37, 17)
        Me.AjoutNom.TabIndex = 0
        Me.AjoutNom.Text = "Nom"
        '
        'GroupBoxModification
        '
        Me.GroupBoxModification.Controls.Add(Me.LabelQuantite)
        Me.GroupBoxModification.Controls.Add(Me.ButtonPrecedent)
        Me.GroupBoxModification.Controls.Add(Me.ButtonSuivant)
        Me.GroupBoxModification.Controls.Add(Me.ModifDepartement)
        Me.GroupBoxModification.Controls.Add(Me.ModifPrenom)
        Me.GroupBoxModification.Controls.Add(Me.TextBoxModifDepartement)
        Me.GroupBoxModification.Controls.Add(Me.TextBoxModifPrenom)
        Me.GroupBoxModification.Controls.Add(Me.TextBoxModifNom)
        Me.GroupBoxModification.Controls.Add(Me.ModifNom)
        Me.GroupBoxModification.Location = New System.Drawing.Point(13, 162)
        Me.GroupBoxModification.Name = "GroupBoxModification"
        Me.GroupBoxModification.Size = New System.Drawing.Size(450, 134)
        Me.GroupBoxModification.TabIndex = 1
        Me.GroupBoxModification.TabStop = False
        Me.GroupBoxModification.Text = "Modification"
        '
        'ButtonPrecedent
        '
        Me.ButtonPrecedent.Enabled = False
        Me.ButtonPrecedent.Location = New System.Drawing.Point(256, 101)
        Me.ButtonPrecedent.Name = "ButtonPrecedent"
        Me.ButtonPrecedent.Size = New System.Drawing.Size(91, 28)
        Me.ButtonPrecedent.TabIndex = 12
        Me.ButtonPrecedent.Text = "Précédent"
        Me.ButtonPrecedent.UseVisualStyleBackColor = True
        '
        'ButtonSuivant
        '
        Me.ButtonSuivant.Enabled = False
        Me.ButtonSuivant.Location = New System.Drawing.Point(353, 101)
        Me.ButtonSuivant.Name = "ButtonSuivant"
        Me.ButtonSuivant.Size = New System.Drawing.Size(91, 28)
        Me.ButtonSuivant.TabIndex = 7
        Me.ButtonSuivant.Text = "Suivant"
        Me.ButtonSuivant.UseVisualStyleBackColor = True
        '
        'ModifDepartement
        '
        Me.ModifDepartement.AutoSize = True
        Me.ModifDepartement.Location = New System.Drawing.Point(6, 78)
        Me.ModifDepartement.Name = "ModifDepartement"
        Me.ModifDepartement.Size = New System.Drawing.Size(90, 17)
        Me.ModifDepartement.TabIndex = 11
        Me.ModifDepartement.Text = "Département"
        '
        'ModifPrenom
        '
        Me.ModifPrenom.AutoSize = True
        Me.ModifPrenom.Location = New System.Drawing.Point(6, 47)
        Me.ModifPrenom.Name = "ModifPrenom"
        Me.ModifPrenom.Size = New System.Drawing.Size(57, 17)
        Me.ModifPrenom.TabIndex = 10
        Me.ModifPrenom.Text = "Prénom"
        '
        'TextBoxModifDepartement
        '
        Me.TextBoxModifDepartement.Location = New System.Drawing.Point(102, 73)
        Me.TextBoxModifDepartement.Name = "TextBoxModifDepartement"
        Me.TextBoxModifDepartement.Size = New System.Drawing.Size(342, 22)
        Me.TextBoxModifDepartement.TabIndex = 9
        '
        'TextBoxModifPrenom
        '
        Me.TextBoxModifPrenom.Location = New System.Drawing.Point(102, 44)
        Me.TextBoxModifPrenom.Name = "TextBoxModifPrenom"
        Me.TextBoxModifPrenom.Size = New System.Drawing.Size(342, 22)
        Me.TextBoxModifPrenom.TabIndex = 8
        '
        'TextBoxModifNom
        '
        Me.TextBoxModifNom.Location = New System.Drawing.Point(102, 15)
        Me.TextBoxModifNom.Name = "TextBoxModifNom"
        Me.TextBoxModifNom.Size = New System.Drawing.Size(342, 22)
        Me.TextBoxModifNom.TabIndex = 7
        '
        'ModifNom
        '
        Me.ModifNom.AutoSize = True
        Me.ModifNom.Location = New System.Drawing.Point(6, 18)
        Me.ModifNom.Name = "ModifNom"
        Me.ModifNom.Size = New System.Drawing.Size(37, 17)
        Me.ModifNom.TabIndex = 6
        Me.ModifNom.Text = "Nom"
        '
        'LabelQuantite
        '
        Me.LabelQuantite.AutoSize = True
        Me.LabelQuantite.Location = New System.Drawing.Point(6, 107)
        Me.LabelQuantite.Name = "LabelQuantite"
        Me.LabelQuantite.Size = New System.Drawing.Size(28, 17)
        Me.LabelQuantite.TabIndex = 13
        Me.LabelQuantite.Text = "0/0"
        '
        'Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 308)
        Me.Controls.Add(Me.GroupBoxModification)
        Me.Controls.Add(Me.GroupBoxAjout)
        Me.Name = "Window"
        Me.Text = "Form1"
        Me.GroupBoxAjout.ResumeLayout(False)
        Me.GroupBoxAjout.PerformLayout()
        Me.GroupBoxModification.ResumeLayout(False)
        Me.GroupBoxModification.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxAjout As GroupBox
    Friend WithEvents TextBoxAjoutDepartement As TextBox
    Friend WithEvents TextBoxAjoutPrenom As TextBox
    Friend WithEvents TextBoxAjoutNom As TextBox
    Friend WithEvents AjoutNom As Label
    Friend WithEvents AjoutDepartement As Label
    Friend WithEvents AjoutPrenom As Label
    Friend WithEvents ButtonAjouter As Button
    Friend WithEvents GroupBoxModification As GroupBox
    Friend WithEvents ModifDepartement As Label
    Friend WithEvents ModifPrenom As Label
    Friend WithEvents TextBoxModifDepartement As TextBox
    Friend WithEvents TextBoxModifPrenom As TextBox
    Friend WithEvents TextBoxModifNom As TextBox
    Friend WithEvents ModifNom As Label
    Friend WithEvents ButtonPrecedent As Button
    Friend WithEvents ButtonSuivant As Button
    Friend WithEvents LabelQuantite As Label
End Class
