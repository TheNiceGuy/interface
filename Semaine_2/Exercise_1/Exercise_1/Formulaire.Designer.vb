<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formulaire
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
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.LabelAge = New System.Windows.Forms.Label()
        Me.TextBoxAge = New System.Windows.Forms.TextBox()
        Me.ButtonConfirmer = New System.Windows.Forms.Button()
        Me.ButtonAnnuler = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(13, 16)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(37, 17)
        Me.LabelNom.TabIndex = 0
        Me.LabelNom.Text = "Nom"
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Location = New System.Drawing.Point(70, 13)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(132, 22)
        Me.TextBoxNom.TabIndex = 1
        '
        'LabelAge
        '
        Me.LabelAge.AutoSize = True
        Me.LabelAge.Location = New System.Drawing.Point(13, 45)
        Me.LabelAge.Name = "LabelAge"
        Me.LabelAge.Size = New System.Drawing.Size(33, 17)
        Me.LabelAge.TabIndex = 2
        Me.LabelAge.Text = "Age"
        '
        'TextBoxAge
        '
        Me.TextBoxAge.Location = New System.Drawing.Point(70, 45)
        Me.TextBoxAge.Name = "TextBoxAge"
        Me.TextBoxAge.Size = New System.Drawing.Size(132, 22)
        Me.TextBoxAge.TabIndex = 3
        '
        'ButtonConfirmer
        '
        Me.ButtonConfirmer.Location = New System.Drawing.Point(13, 108)
        Me.ButtonConfirmer.Name = "ButtonConfirmer"
        Me.ButtonConfirmer.Size = New System.Drawing.Size(189, 29)
        Me.ButtonConfirmer.TabIndex = 4
        Me.ButtonConfirmer.Text = "Confirmer"
        Me.ButtonConfirmer.UseVisualStyleBackColor = True
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.Location = New System.Drawing.Point(13, 73)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(189, 29)
        Me.ButtonAnnuler.TabIndex = 5
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = True
        '
        'Formulaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 151)
        Me.Controls.Add(Me.ButtonAnnuler)
        Me.Controls.Add(Me.ButtonConfirmer)
        Me.Controls.Add(Me.TextBoxAge)
        Me.Controls.Add(Me.LabelAge)
        Me.Controls.Add(Me.TextBoxNom)
        Me.Controls.Add(Me.LabelNom)
        Me.Name = "Formulaire"
        Me.Text = "Formulaire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelNom As Label
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents LabelAge As Label
    Friend WithEvents TextBoxAge As TextBox
    Friend WithEvents ButtonConfirmer As Button
    Friend WithEvents ButtonAnnuler As Button
End Class
