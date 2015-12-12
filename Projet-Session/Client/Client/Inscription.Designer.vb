<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inscription
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonAnnuler = New System.Windows.Forms.Button()
        Me.ButtonAccepter = New System.Windows.Forms.Button()
        Me.LabelProgramme = New System.Windows.Forms.Label()
        Me.ComboBoxProgramme = New System.Windows.Forms.ComboBox()
        Me.LabelNaissance = New System.Windows.Forms.Label()
        Me.DateTimePickerNaissance = New System.Windows.Forms.DateTimePicker()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.LabelPasswordVerification = New System.Windows.Forms.Label()
        Me.TextBoxPasswordVerification = New System.Windows.Forms.TextBox()
        Me.LabelCourriel = New System.Windows.Forms.Label()
        Me.TextBoxCourriel = New System.Windows.Forms.TextBox()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.TextBoxPrenom = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonAnnuler, 3, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonAccepter, 2, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelProgramme, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBoxProgramme, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelNaissance, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePickerNaissance, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelPassword, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxPassword, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelPasswordVerification, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxPasswordVerification, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelCourriel, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxCourriel, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxNom, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelPrenom, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelNom, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxPrenom, 2, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 11
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(342, 373)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAnnuler.Location = New System.Drawing.Point(224, 312)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(94, 29)
        Me.ButtonAnnuler.TabIndex = 8
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = True
        '
        'ButtonAccepter
        '
        Me.ButtonAccepter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAccepter.Location = New System.Drawing.Point(124, 312)
        Me.ButtonAccepter.Name = "ButtonAccepter"
        Me.ButtonAccepter.Size = New System.Drawing.Size(94, 29)
        Me.ButtonAccepter.TabIndex = 7
        Me.ButtonAccepter.Text = "Accepter"
        Me.ButtonAccepter.UseVisualStyleBackColor = True
        '
        'LabelProgramme
        '
        Me.LabelProgramme.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelProgramme.AutoSize = True
        Me.LabelProgramme.Location = New System.Drawing.Point(37, 108)
        Me.LabelProgramme.Name = "LabelProgramme"
        Me.LabelProgramme.Size = New System.Drawing.Size(81, 17)
        Me.LabelProgramme.TabIndex = 11
        Me.LabelProgramme.Text = "Programme"
        '
        'ComboBoxProgramme
        '
        Me.ComboBoxProgramme.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.ComboBoxProgramme, 2)
        Me.ComboBoxProgramme.FormattingEnabled = True
        Me.ComboBoxProgramme.Location = New System.Drawing.Point(124, 104)
        Me.ComboBoxProgramme.Name = "ComboBoxProgramme"
        Me.ComboBoxProgramme.Size = New System.Drawing.Size(194, 24)
        Me.ComboBoxProgramme.TabIndex = 2
        '
        'LabelNaissance
        '
        Me.LabelNaissance.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelNaissance.AutoSize = True
        Me.LabelNaissance.Location = New System.Drawing.Point(44, 143)
        Me.LabelNaissance.Name = "LabelNaissance"
        Me.LabelNaissance.Size = New System.Drawing.Size(74, 17)
        Me.LabelNaissance.TabIndex = 12
        Me.LabelNaissance.Text = "Naissance"
        '
        'DateTimePickerNaissance
        '
        Me.DateTimePickerNaissance.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.DateTimePickerNaissance, 2)
        Me.DateTimePickerNaissance.Location = New System.Drawing.Point(124, 140)
        Me.DateTimePickerNaissance.Name = "DateTimePickerNaissance"
        Me.DateTimePickerNaissance.Size = New System.Drawing.Size(194, 22)
        Me.DateTimePickerNaissance.TabIndex = 3
        '
        'LabelPassword
        '
        Me.LabelPassword.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(49, 178)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(69, 17)
        Me.LabelPassword.TabIndex = 13
        Me.LabelPassword.Text = "Password"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBoxPassword, 2)
        Me.TextBoxPassword.Location = New System.Drawing.Point(124, 175)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(194, 22)
        Me.TextBoxPassword.TabIndex = 4
        Me.TextBoxPassword.UseSystemPasswordChar = True
        '
        'LabelPasswordVerification
        '
        Me.LabelPasswordVerification.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelPasswordVerification.AutoSize = True
        Me.LabelPasswordVerification.Location = New System.Drawing.Point(49, 213)
        Me.LabelPasswordVerification.Name = "LabelPasswordVerification"
        Me.LabelPasswordVerification.Size = New System.Drawing.Size(69, 17)
        Me.LabelPasswordVerification.TabIndex = 14
        Me.LabelPasswordVerification.Text = "(Répéter)"
        '
        'TextBoxPasswordVerification
        '
        Me.TextBoxPasswordVerification.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBoxPasswordVerification, 2)
        Me.TextBoxPasswordVerification.Location = New System.Drawing.Point(124, 210)
        Me.TextBoxPasswordVerification.Name = "TextBoxPasswordVerification"
        Me.TextBoxPasswordVerification.Size = New System.Drawing.Size(194, 22)
        Me.TextBoxPasswordVerification.TabIndex = 5
        Me.TextBoxPasswordVerification.UseSystemPasswordChar = True
        '
        'LabelCourriel
        '
        Me.LabelCourriel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelCourriel.AutoSize = True
        Me.LabelCourriel.Location = New System.Drawing.Point(61, 248)
        Me.LabelCourriel.Name = "LabelCourriel"
        Me.LabelCourriel.Size = New System.Drawing.Size(57, 17)
        Me.LabelCourriel.TabIndex = 15
        Me.LabelCourriel.Text = "Courriel"
        '
        'TextBoxCourriel
        '
        Me.TextBoxCourriel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBoxCourriel, 2)
        Me.TextBoxCourriel.Location = New System.Drawing.Point(124, 245)
        Me.TextBoxCourriel.Name = "TextBoxCourriel"
        Me.TextBoxCourriel.Size = New System.Drawing.Size(194, 22)
        Me.TextBoxCourriel.TabIndex = 6
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBoxNom, 2)
        Me.TextBoxNom.Location = New System.Drawing.Point(124, 70)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(194, 22)
        Me.TextBoxNom.TabIndex = 1
        '
        'LabelPrenom
        '
        Me.LabelPrenom.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Location = New System.Drawing.Point(61, 38)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(57, 17)
        Me.LabelPrenom.TabIndex = 9
        Me.LabelPrenom.Text = "Prénom"
        '
        'LabelNom
        '
        Me.LabelNom.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(81, 73)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(37, 17)
        Me.LabelNom.TabIndex = 10
        Me.LabelNom.Text = "Nom"
        '
        'TextBoxPrenom
        '
        Me.TextBoxPrenom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBoxPrenom, 2)
        Me.TextBoxPrenom.Location = New System.Drawing.Point(124, 35)
        Me.TextBoxPrenom.Name = "TextBoxPrenom"
        Me.TextBoxPrenom.Size = New System.Drawing.Size(194, 22)
        Me.TextBoxPrenom.TabIndex = 0
        '
        'Inscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 373)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "Inscription"
        Me.Text = "Inscription"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelNom As Label
    Friend WithEvents ButtonAccepter As Button
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents LabelPrenom As Label
    Friend WithEvents TextBoxPrenom As TextBox
    Friend WithEvents LabelProgramme As Label
    Friend WithEvents ComboBoxProgramme As ComboBox
    Friend WithEvents LabelNaissance As Label
    Friend WithEvents DateTimePickerNaissance As DateTimePicker
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents LabelPasswordVerification As Label
    Friend WithEvents TextBoxPasswordVerification As TextBox
    Friend WithEvents LabelCourriel As Label
    Friend WithEvents TextBoxCourriel As TextBox
    Friend WithEvents ButtonAnnuler As Button
End Class
