<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Connexion
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonOptions = New System.Windows.Forms.Button()
        Me.ButtonInscription = New System.Windows.Forms.Button()
        Me.LabelMatricule = New System.Windows.Forms.Label()
        Me.TextBoxMatricule = New System.Windows.Forms.TextBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.ButtonConnexion = New System.Windows.Forms.Button()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelConnection = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
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
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonOptions, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonInscription, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelMatricule, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxMatricule, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelPassword, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxPassword, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonConnexion, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.StatusStrip, 0, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(342, 233)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ButtonOptions
        '
        Me.ButtonOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonOptions.Location = New System.Drawing.Point(224, 172)
        Me.ButtonOptions.Name = "ButtonOptions"
        Me.ButtonOptions.Size = New System.Drawing.Size(94, 29)
        Me.ButtonOptions.TabIndex = 6
        Me.ButtonOptions.Text = "Options"
        Me.ButtonOptions.UseVisualStyleBackColor = True
        '
        'ButtonInscription
        '
        Me.ButtonInscription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonInscription.Enabled = False
        Me.ButtonInscription.Location = New System.Drawing.Point(124, 172)
        Me.ButtonInscription.Name = "ButtonInscription"
        Me.ButtonInscription.Size = New System.Drawing.Size(94, 29)
        Me.ButtonInscription.TabIndex = 5
        Me.ButtonInscription.Text = "Inscription"
        Me.ButtonInscription.UseVisualStyleBackColor = True
        '
        'LabelMatricule
        '
        Me.LabelMatricule.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelMatricule.AutoSize = True
        Me.LabelMatricule.Location = New System.Drawing.Point(53, 38)
        Me.LabelMatricule.Name = "LabelMatricule"
        Me.LabelMatricule.Size = New System.Drawing.Size(65, 17)
        Me.LabelMatricule.TabIndex = 0
        Me.LabelMatricule.Text = "Matricule"
        '
        'TextBoxMatricule
        '
        Me.TextBoxMatricule.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBoxMatricule, 2)
        Me.TextBoxMatricule.Location = New System.Drawing.Point(124, 35)
        Me.TextBoxMatricule.Name = "TextBoxMatricule"
        Me.TextBoxMatricule.Size = New System.Drawing.Size(194, 22)
        Me.TextBoxMatricule.TabIndex = 1
        '
        'LabelPassword
        '
        Me.LabelPassword.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(49, 73)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(69, 17)
        Me.LabelPassword.TabIndex = 2
        Me.LabelPassword.Text = "Password"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBoxPassword, 2)
        Me.TextBoxPassword.Location = New System.Drawing.Point(124, 70)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(194, 22)
        Me.TextBoxPassword.TabIndex = 3
        Me.TextBoxPassword.UseSystemPasswordChar = True
        '
        'ButtonConnexion
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.ButtonConnexion, 2)
        Me.ButtonConnexion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonConnexion.Enabled = False
        Me.ButtonConnexion.Location = New System.Drawing.Point(124, 102)
        Me.ButtonConnexion.Name = "ButtonConnexion"
        Me.ButtonConnexion.Size = New System.Drawing.Size(194, 29)
        Me.ButtonConnexion.TabIndex = 4
        Me.ButtonConnexion.Text = "Connection"
        Me.ButtonConnexion.UseVisualStyleBackColor = True
        '
        'StatusStrip
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.StatusStrip, 5)
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelConnection})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 209)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(342, 24)
        Me.StatusStrip.TabIndex = 7
        '
        'ToolStripStatusLabelConnection
        '
        Me.ToolStripStatusLabelConnection.Name = "ToolStripStatusLabelConnection"
        Me.ToolStripStatusLabelConnection.Size = New System.Drawing.Size(0, 19)
        '
        'Connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 233)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Connexion"
        Me.Text = "Connection"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelMatricule As Label
    Friend WithEvents TextBoxMatricule As TextBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents ButtonOptions As Button
    Friend WithEvents ButtonInscription As Button
    Friend WithEvents ButtonConnexion As Button
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolStripStatusLabelConnection As ToolStripStatusLabel
End Class
