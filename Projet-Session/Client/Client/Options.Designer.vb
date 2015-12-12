<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Me.LabelAddresse = New System.Windows.Forms.Label()
        Me.LabelPort = New System.Windows.Forms.Label()
        Me.TextBoxAdresse = New System.Windows.Forms.TextBox()
        Me.NumericUpDownPort = New System.Windows.Forms.NumericUpDown()
        Me.ButtonAccepter = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.NumericUpDownPort, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonAnnuler, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelAddresse, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelPort, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxAdresse, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NumericUpDownPort, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonAccepter, 2, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(342, 198)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAnnuler.Location = New System.Drawing.Point(224, 137)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(94, 29)
        Me.ButtonAnnuler.TabIndex = 5
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = True
        '
        'LabelAddresse
        '
        Me.LabelAddresse.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelAddresse.AutoSize = True
        Me.LabelAddresse.Location = New System.Drawing.Point(50, 38)
        Me.LabelAddresse.Name = "LabelAddresse"
        Me.LabelAddresse.Size = New System.Drawing.Size(68, 17)
        Me.LabelAddresse.TabIndex = 0
        Me.LabelAddresse.Text = "Addresse"
        '
        'LabelPort
        '
        Me.LabelPort.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelPort.AutoSize = True
        Me.LabelPort.Location = New System.Drawing.Point(84, 73)
        Me.LabelPort.Name = "LabelPort"
        Me.LabelPort.Size = New System.Drawing.Size(34, 17)
        Me.LabelPort.TabIndex = 1
        Me.LabelPort.Text = "Port"
        '
        'TextBoxAdresse
        '
        Me.TextBoxAdresse.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBoxAdresse, 2)
        Me.TextBoxAdresse.Location = New System.Drawing.Point(124, 35)
        Me.TextBoxAdresse.Name = "TextBoxAdresse"
        Me.TextBoxAdresse.Size = New System.Drawing.Size(194, 22)
        Me.TextBoxAdresse.TabIndex = 2
        '
        'NumericUpDownPort
        '
        Me.NumericUpDownPort.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.NumericUpDownPort, 2)
        Me.NumericUpDownPort.Location = New System.Drawing.Point(124, 70)
        Me.NumericUpDownPort.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NumericUpDownPort.Name = "NumericUpDownPort"
        Me.NumericUpDownPort.Size = New System.Drawing.Size(194, 22)
        Me.NumericUpDownPort.TabIndex = 3
        '
        'ButtonAccepter
        '
        Me.ButtonAccepter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAccepter.Location = New System.Drawing.Point(124, 137)
        Me.ButtonAccepter.Name = "ButtonAccepter"
        Me.ButtonAccepter.Size = New System.Drawing.Size(94, 29)
        Me.ButtonAccepter.TabIndex = 4
        Me.ButtonAccepter.Text = "Accepter"
        Me.ButtonAccepter.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 198)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "Options"
        Me.Text = "Options"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.NumericUpDownPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelAddresse As Label
    Friend WithEvents LabelPort As Label
    Friend WithEvents TextBoxAdresse As TextBox
    Friend WithEvents NumericUpDownPort As NumericUpDown
    Friend WithEvents ButtonAnnuler As Button
    Friend WithEvents ButtonAccepter As Button
End Class
