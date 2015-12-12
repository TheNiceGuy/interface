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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelJeu = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LabelJeu, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ProgressBar, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NumericUpDown, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(459, 114)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LabelJeu
        '
        Me.LabelJeu.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelJeu.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.LabelJeu, 2)
        Me.LabelJeu.Location = New System.Drawing.Point(3, 10)
        Me.LabelJeu.Name = "LabelJeu"
        Me.LabelJeu.Size = New System.Drawing.Size(453, 17)
        Me.LabelJeu.TabIndex = 0
        Me.LabelJeu.Text = "Ceci est une bombe, veuillez trouver le bon nombre."
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.ProgressBar, 2)
        Me.ProgressBar.Location = New System.Drawing.Point(3, 44)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(453, 23)
        Me.ProgressBar.TabIndex = 1
        '
        'NumericUpDown
        '
        Me.NumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown.Location = New System.Drawing.Point(3, 83)
        Me.NumericUpDown.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NumericUpDown.Name = "NumericUpDown"
        Me.NumericUpDown.Size = New System.Drawing.Size(223, 22)
        Me.NumericUpDown.TabIndex = 2
        '
        'Button
        '
        Me.Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button.Location = New System.Drawing.Point(232, 82)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(224, 23)
        Me.Button.TabIndex = 3
        Me.Button.Text = "Soumettre"
        Me.Button.UseVisualStyleBackColor = True
        '
        'Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 114)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Window"
        Me.Text = "Form"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelJeu As Label
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents NumericUpDown As NumericUpDown
    Friend WithEvents Button As Button
End Class
