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
        Me.Type = New System.Windows.Forms.GroupBox()
        Me.TypeVieux = New System.Windows.Forms.RadioButton()
        Me.TypeEtudiant = New System.Windows.Forms.RadioButton()
        Me.TypeEnfant = New System.Windows.Forms.RadioButton()
        Me.TypeAdulte = New System.Windows.Forms.RadioButton()
        Me.Options = New System.Windows.Forms.GroupBox()
        Me.OptionsEntraineur = New System.Windows.Forms.CheckBox()
        Me.OptionsKarate = New System.Windows.Forms.CheckBox()
        Me.OptionsYoga = New System.Windows.Forms.CheckBox()
        Me.Temps = New System.Windows.Forms.GroupBox()
        Me.TempsLabel2 = New System.Windows.Forms.Label()
        Me.TempsText = New System.Windows.Forms.TextBox()
        Me.TempsLabel1 = New System.Windows.Forms.Label()
        Me.Cout = New System.Windows.Forms.GroupBox()
        Me.CoutMensuelLabel = New System.Windows.Forms.Label()
        Me.CoutTotalLabel = New System.Windows.Forms.Label()
        Me.CoutMensuelText = New System.Windows.Forms.TextBox()
        Me.CoutTotalText = New System.Windows.Forms.TextBox()
        Me.ButtonCalculer = New System.Windows.Forms.Button()
        Me.ButtonEffacer = New System.Windows.Forms.Button()
        Me.Type.SuspendLayout()
        Me.Options.SuspendLayout()
        Me.Temps.SuspendLayout()
        Me.Cout.SuspendLayout()
        Me.SuspendLayout()
        '
        'Type
        '
        Me.Type.Controls.Add(Me.TypeVieux)
        Me.Type.Controls.Add(Me.TypeEtudiant)
        Me.Type.Controls.Add(Me.TypeEnfant)
        Me.Type.Controls.Add(Me.TypeAdulte)
        Me.Type.Location = New System.Drawing.Point(12, 12)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(134, 135)
        Me.Type.TabIndex = 0
        Me.Type.TabStop = False
        Me.Type.Text = "Type de membre"
        '
        'TypeVieux
        '
        Me.TypeVieux.AutoSize = True
        Me.TypeVieux.Location = New System.Drawing.Point(6, 104)
        Me.TypeVieux.Name = "TypeVieux"
        Me.TypeVieux.Size = New System.Drawing.Size(63, 21)
        Me.TypeVieux.TabIndex = 3
        Me.TypeVieux.TabStop = True
        Me.TypeVieux.Text = "Vieux"
        Me.TypeVieux.UseVisualStyleBackColor = True
        '
        'TypeEtudiant
        '
        Me.TypeEtudiant.AutoSize = True
        Me.TypeEtudiant.Location = New System.Drawing.Point(6, 76)
        Me.TypeEtudiant.Name = "TypeEtudiant"
        Me.TypeEtudiant.Size = New System.Drawing.Size(81, 21)
        Me.TypeEtudiant.TabIndex = 2
        Me.TypeEtudiant.TabStop = True
        Me.TypeEtudiant.Text = "Étudiant"
        Me.TypeEtudiant.UseVisualStyleBackColor = True
        '
        'TypeEnfant
        '
        Me.TypeEnfant.AutoSize = True
        Me.TypeEnfant.Location = New System.Drawing.Point(6, 48)
        Me.TypeEnfant.Name = "TypeEnfant"
        Me.TypeEnfant.Size = New System.Drawing.Size(70, 21)
        Me.TypeEnfant.TabIndex = 1
        Me.TypeEnfant.TabStop = True
        Me.TypeEnfant.Text = "Enfant"
        Me.TypeEnfant.UseVisualStyleBackColor = True
        '
        'TypeAdulte
        '
        Me.TypeAdulte.AutoSize = True
        Me.TypeAdulte.Location = New System.Drawing.Point(6, 21)
        Me.TypeAdulte.Name = "TypeAdulte"
        Me.TypeAdulte.Size = New System.Drawing.Size(69, 21)
        Me.TypeAdulte.TabIndex = 0
        Me.TypeAdulte.TabStop = True
        Me.TypeAdulte.Text = "Adulte"
        Me.TypeAdulte.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.Options.Controls.Add(Me.OptionsEntraineur)
        Me.Options.Controls.Add(Me.OptionsKarate)
        Me.Options.Controls.Add(Me.OptionsYoga)
        Me.Options.Location = New System.Drawing.Point(152, 12)
        Me.Options.Name = "Options"
        Me.Options.Size = New System.Drawing.Size(180, 135)
        Me.Options.TabIndex = 1
        Me.Options.TabStop = False
        Me.Options.Text = "Options"
        '
        'OptionsEntraineur
        '
        Me.OptionsEntraineur.AutoSize = True
        Me.OptionsEntraineur.Location = New System.Drawing.Point(7, 76)
        Me.OptionsEntraineur.Name = "OptionsEntraineur"
        Me.OptionsEntraineur.Size = New System.Drawing.Size(164, 21)
        Me.OptionsEntraineur.TabIndex = 2
        Me.OptionsEntraineur.Text = "Entraîneur Personnel"
        Me.OptionsEntraineur.UseVisualStyleBackColor = True
        '
        'OptionsKarate
        '
        Me.OptionsKarate.AutoSize = True
        Me.OptionsKarate.Location = New System.Drawing.Point(7, 48)
        Me.OptionsKarate.Name = "OptionsKarate"
        Me.OptionsKarate.Size = New System.Drawing.Size(72, 21)
        Me.OptionsKarate.TabIndex = 1
        Me.OptionsKarate.Text = "Karaté"
        Me.OptionsKarate.UseVisualStyleBackColor = True
        '
        'OptionsYoga
        '
        Me.OptionsYoga.AutoSize = True
        Me.OptionsYoga.Location = New System.Drawing.Point(7, 21)
        Me.OptionsYoga.Name = "OptionsYoga"
        Me.OptionsYoga.Size = New System.Drawing.Size(63, 21)
        Me.OptionsYoga.TabIndex = 0
        Me.OptionsYoga.Text = "Yoga"
        Me.OptionsYoga.UseVisualStyleBackColor = True
        '
        'Temps
        '
        Me.Temps.Controls.Add(Me.TempsLabel2)
        Me.Temps.Controls.Add(Me.TempsText)
        Me.Temps.Controls.Add(Me.TempsLabel1)
        Me.Temps.Location = New System.Drawing.Point(339, 13)
        Me.Temps.Name = "Temps"
        Me.Temps.Size = New System.Drawing.Size(176, 134)
        Me.Temps.TabIndex = 2
        Me.Temps.TabStop = False
        Me.Temps.Text = "Temps d'Adhésion"
        '
        'TempsLabel2
        '
        Me.TempsLabel2.AutoSize = True
        Me.TempsLabel2.Location = New System.Drawing.Point(97, 46)
        Me.TempsLabel2.Name = "TempsLabel2"
        Me.TempsLabel2.Size = New System.Drawing.Size(37, 17)
        Me.TempsLabel2.TabIndex = 2
        Me.TempsLabel2.Text = "mois"
        '
        'TempsText
        '
        Me.TempsText.Location = New System.Drawing.Point(7, 43)
        Me.TempsText.Name = "TempsText"
        Me.TempsText.Size = New System.Drawing.Size(84, 22)
        Me.TempsText.TabIndex = 1
        Me.TempsText.Text = "1"
        '
        'TempsLabel1
        '
        Me.TempsLabel1.AutoSize = True
        Me.TempsLabel1.Location = New System.Drawing.Point(7, 22)
        Me.TempsLabel1.Name = "TempsLabel1"
        Me.TempsLabel1.Size = New System.Drawing.Size(109, 17)
        Me.TempsLabel1.TabIndex = 0
        Me.TempsLabel1.Text = "Membre depuis:"
        '
        'Cout
        '
        Me.Cout.Controls.Add(Me.CoutTotalText)
        Me.Cout.Controls.Add(Me.CoutMensuelText)
        Me.Cout.Controls.Add(Me.CoutTotalLabel)
        Me.Cout.Controls.Add(Me.CoutMensuelLabel)
        Me.Cout.Location = New System.Drawing.Point(521, 13)
        Me.Cout.Name = "Cout"
        Me.Cout.Size = New System.Drawing.Size(222, 134)
        Me.Cout.TabIndex = 3
        Me.Cout.TabStop = False
        Me.Cout.Text = "Coût"
        '
        'CoutMensuelLabel
        '
        Me.CoutMensuelLabel.AutoSize = True
        Me.CoutMensuelLabel.Location = New System.Drawing.Point(7, 22)
        Me.CoutMensuelLabel.Name = "CoutMensuelLabel"
        Me.CoutMensuelLabel.Size = New System.Drawing.Size(98, 17)
        Me.CoutMensuelLabel.TabIndex = 0
        Me.CoutMensuelLabel.Text = "Coût Mensuel:"
        '
        'CoutTotalLabel
        '
        Me.CoutTotalLabel.AutoSize = True
        Me.CoutTotalLabel.Location = New System.Drawing.Point(28, 46)
        Me.CoutTotalLabel.Name = "CoutTotalLabel"
        Me.CoutTotalLabel.Size = New System.Drawing.Size(77, 17)
        Me.CoutTotalLabel.TabIndex = 1
        Me.CoutTotalLabel.Text = "Coût Total:"
        '
        'CoutMensuelText
        '
        Me.CoutMensuelText.Location = New System.Drawing.Point(112, 16)
        Me.CoutMensuelText.Name = "CoutMensuelText"
        Me.CoutMensuelText.Size = New System.Drawing.Size(100, 22)
        Me.CoutMensuelText.TabIndex = 2
        Me.CoutMensuelText.Text = "0"
        '
        'CoutTotalText
        '
        Me.CoutTotalText.Location = New System.Drawing.Point(112, 47)
        Me.CoutTotalText.Name = "CoutTotalText"
        Me.CoutTotalText.Size = New System.Drawing.Size(100, 22)
        Me.CoutTotalText.TabIndex = 3
        Me.CoutTotalText.Text = "0"
        '
        'ButtonCalculer
        '
        Me.ButtonCalculer.Location = New System.Drawing.Point(749, 28)
        Me.ButtonCalculer.Name = "ButtonCalculer"
        Me.ButtonCalculer.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCalculer.TabIndex = 4
        Me.ButtonCalculer.Text = "Calculer"
        Me.ButtonCalculer.UseVisualStyleBackColor = True
        '
        'ButtonEffacer
        '
        Me.ButtonEffacer.Location = New System.Drawing.Point(749, 60)
        Me.ButtonEffacer.Name = "ButtonEffacer"
        Me.ButtonEffacer.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEffacer.TabIndex = 5
        Me.ButtonEffacer.Text = "Effacer"
        Me.ButtonEffacer.UseVisualStyleBackColor = True
        '
        'Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 159)
        Me.Controls.Add(Me.ButtonEffacer)
        Me.Controls.Add(Me.ButtonCalculer)
        Me.Controls.Add(Me.Cout)
        Me.Controls.Add(Me.Temps)
        Me.Controls.Add(Me.Options)
        Me.Controls.Add(Me.Type)
        Me.Name = "Window"
        Me.Text = "Club de Santé"
        Me.Type.ResumeLayout(False)
        Me.Type.PerformLayout()
        Me.Options.ResumeLayout(False)
        Me.Options.PerformLayout()
        Me.Temps.ResumeLayout(False)
        Me.Temps.PerformLayout()
        Me.Cout.ResumeLayout(False)
        Me.Cout.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Type As GroupBox
    Friend WithEvents TypeEnfant As RadioButton
    Friend WithEvents TypeAdulte As RadioButton
    Friend WithEvents TypeVieux As RadioButton
    Friend WithEvents TypeEtudiant As RadioButton
    Friend WithEvents Options As GroupBox
    Friend WithEvents OptionsEntraineur As CheckBox
    Friend WithEvents OptionsKarate As CheckBox
    Friend WithEvents OptionsYoga As CheckBox
    Friend WithEvents Temps As GroupBox
    Friend WithEvents TempsLabel2 As Label
    Friend WithEvents TempsText As TextBox
    Friend WithEvents TempsLabel1 As Label
    Friend WithEvents Cout As GroupBox
    Friend WithEvents CoutMensuelLabel As Label
    Friend WithEvents CoutTotalLabel As Label
    Friend WithEvents CoutTotalText As TextBox
    Friend WithEvents CoutMensuelText As TextBox
    Friend WithEvents ButtonCalculer As Button
    Friend WithEvents ButtonEffacer As Button
End Class
