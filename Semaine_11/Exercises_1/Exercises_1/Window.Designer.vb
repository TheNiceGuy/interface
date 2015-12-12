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
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelTimer = New System.Windows.Forms.Label()
        Me.ButtonToggle = New System.Windows.Forms.Button()
        Me.NumericUpDownAdd = New System.Windows.Forms.NumericUpDown()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.TableLayoutPanel.SuspendLayout()
        CType(Me.NumericUpDownAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 2
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.Controls.Add(Me.ButtonAdd, 1, 1)
        Me.TableLayoutPanel.Controls.Add(Me.LabelTimer, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.ButtonToggle, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.NumericUpDownAdd, 0, 1)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 4
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(282, 253)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'LabelTimer
        '
        Me.LabelTimer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelTimer.AutoSize = True
        Me.LabelTimer.Location = New System.Drawing.Point(45, 23)
        Me.LabelTimer.Name = "LabelTimer"
        Me.LabelTimer.Size = New System.Drawing.Size(50, 17)
        Me.LabelTimer.TabIndex = 0
        Me.LabelTimer.Text = "TIMER"
        '
        'ButtonToggle
        '
        Me.ButtonToggle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonToggle.Location = New System.Drawing.Point(144, 3)
        Me.ButtonToggle.Name = "ButtonToggle"
        Me.ButtonToggle.Size = New System.Drawing.Size(135, 57)
        Me.ButtonToggle.TabIndex = 1
        Me.ButtonToggle.Text = "Start/Stop"
        Me.ButtonToggle.UseVisualStyleBackColor = True
        '
        'NumericUpDownAdd
        '
        Me.NumericUpDownAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDownAdd.Location = New System.Drawing.Point(3, 83)
        Me.NumericUpDownAdd.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumericUpDownAdd.Name = "NumericUpDownAdd"
        Me.NumericUpDownAdd.Size = New System.Drawing.Size(135, 22)
        Me.NumericUpDownAdd.TabIndex = 2
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAdd.Location = New System.Drawing.Point(144, 66)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(135, 57)
        Me.ButtonAdd.TabIndex = 3
        Me.ButtonAdd.Text = "Add Time"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.Name = "Window"
        Me.Text = "Timer"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        CType(Me.NumericUpDownAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel As TableLayoutPanel
    Friend WithEvents LabelTimer As Label
    Friend WithEvents ButtonToggle As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents NumericUpDownAdd As NumericUpDown
End Class
