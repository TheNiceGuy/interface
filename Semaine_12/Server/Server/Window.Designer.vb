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
        Me.ButtonToggle = New System.Windows.Forms.Button()
        Me.TextBoxOutput = New System.Windows.Forms.TextBox()
        Me.TextBoxInput = New System.Windows.Forms.TextBox()
        Me.ButtonSend = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonToggle, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxOutput, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxInput, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonSend, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(282, 253)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ButtonToggle
        '
        Me.ButtonToggle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonToggle.Location = New System.Drawing.Point(3, 3)
        Me.ButtonToggle.Name = "ButtonToggle"
        Me.ButtonToggle.Size = New System.Drawing.Size(276, 57)
        Me.ButtonToggle.TabIndex = 0
        Me.ButtonToggle.Text = "Start/Stop"
        Me.ButtonToggle.UseVisualStyleBackColor = True
        '
        'TextBoxOutput
        '
        Me.TextBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxOutput.Location = New System.Drawing.Point(3, 129)
        Me.TextBoxOutput.Multiline = True
        Me.TextBoxOutput.Name = "TextBoxOutput"
        Me.TextBoxOutput.Size = New System.Drawing.Size(276, 57)
        Me.TextBoxOutput.TabIndex = 1
        '
        'TextBoxInput
        '
        Me.TextBoxInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxInput.Location = New System.Drawing.Point(3, 66)
        Me.TextBoxInput.Multiline = True
        Me.TextBoxInput.Name = "TextBoxInput"
        Me.TextBoxInput.ReadOnly = True
        Me.TextBoxInput.Size = New System.Drawing.Size(276, 57)
        Me.TextBoxInput.TabIndex = 2
        '
        'ButtonSend
        '
        Me.ButtonSend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonSend.Location = New System.Drawing.Point(3, 192)
        Me.ButtonSend.Name = "ButtonSend"
        Me.ButtonSend.Size = New System.Drawing.Size(276, 58)
        Me.ButtonSend.TabIndex = 3
        Me.ButtonSend.Text = "Send"
        Me.ButtonSend.UseVisualStyleBackColor = True
        '
        'Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Window"
        Me.Text = "Server"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ButtonToggle As Button
    Friend WithEvents TextBoxOutput As TextBox
    Friend WithEvents TextBoxInput As TextBox
    Friend WithEvents ButtonSend As Button
End Class
