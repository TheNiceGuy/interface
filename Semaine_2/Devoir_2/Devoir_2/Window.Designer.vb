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
        Me.ListBoxPersonne = New System.Windows.Forms.ListBox()
        Me.ButtonAjouter = New System.Windows.Forms.Button()
        Me.ButtonModifier = New System.Windows.Forms.Button()
        Me.ButtonSupprimer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxPersonne
        '
        Me.ListBoxPersonne.FormattingEnabled = True
        Me.ListBoxPersonne.ItemHeight = 16
        Me.ListBoxPersonne.Location = New System.Drawing.Point(13, 157)
        Me.ListBoxPersonne.Name = "ListBoxPersonne"
        Me.ListBoxPersonne.Size = New System.Drawing.Size(267, 228)
        Me.ListBoxPersonne.TabIndex = 0
        '
        'ButtonAjouter
        '
        Me.ButtonAjouter.Location = New System.Drawing.Point(13, 13)
        Me.ButtonAjouter.Name = "ButtonAjouter"
        Me.ButtonAjouter.Size = New System.Drawing.Size(267, 42)
        Me.ButtonAjouter.TabIndex = 1
        Me.ButtonAjouter.Text = "Ajouter"
        Me.ButtonAjouter.UseVisualStyleBackColor = True
        '
        'ButtonModifier
        '
        Me.ButtonModifier.Enabled = False
        Me.ButtonModifier.Location = New System.Drawing.Point(12, 61)
        Me.ButtonModifier.Name = "ButtonModifier"
        Me.ButtonModifier.Size = New System.Drawing.Size(267, 42)
        Me.ButtonModifier.TabIndex = 2
        Me.ButtonModifier.Text = "Modifier"
        Me.ButtonModifier.UseVisualStyleBackColor = True
        '
        'ButtonSupprimer
        '
        Me.ButtonSupprimer.Enabled = False
        Me.ButtonSupprimer.Location = New System.Drawing.Point(13, 109)
        Me.ButtonSupprimer.Name = "ButtonSupprimer"
        Me.ButtonSupprimer.Size = New System.Drawing.Size(267, 42)
        Me.ButtonSupprimer.TabIndex = 3
        Me.ButtonSupprimer.Text = "Supprimer"
        Me.ButtonSupprimer.UseVisualStyleBackColor = True
        '
        'Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 400)
        Me.Controls.Add(Me.ButtonSupprimer)
        Me.Controls.Add(Me.ButtonModifier)
        Me.Controls.Add(Me.ButtonAjouter)
        Me.Controls.Add(Me.ListBoxPersonne)
        Me.Name = "Window"
        Me.Text = "Monde"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxPersonne As ListBox
    Friend WithEvents ButtonAjouter As Button
    Friend WithEvents ButtonModifier As Button
    Friend WithEvents ButtonSupprimer As Button
End Class
