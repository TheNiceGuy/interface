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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanelMain = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxMetier = New System.Windows.Forms.ComboBox()
        Me.ComboBoxSexe = New System.Windows.Forms.ComboBox()
        Me.ListBoxClient = New System.Windows.Forms.ListBox()
        Me.MenuStrip.SuspendLayout()
        Me.TableLayoutPanelMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(286, 28)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ToolStripSeparator1, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(120, 26)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(117, 6)
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(120, 26)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'TableLayoutPanelMain
        '
        Me.TableLayoutPanelMain.ColumnCount = 2
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelMain.Controls.Add(Me.ComboBoxSexe, 1, 0)
        Me.TableLayoutPanelMain.Controls.Add(Me.ComboBoxMetier, 0, 0)
        Me.TableLayoutPanelMain.Controls.Add(Me.ListBoxClient, 0, 1)
        Me.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelMain.Enabled = False
        Me.TableLayoutPanelMain.Location = New System.Drawing.Point(0, 28)
        Me.TableLayoutPanelMain.Name = "TableLayoutPanelMain"
        Me.TableLayoutPanelMain.RowCount = 2
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanelMain.Size = New System.Drawing.Size(286, 262)
        Me.TableLayoutPanelMain.TabIndex = 1
        '
        'ComboBoxMetier
        '
        Me.ComboBoxMetier.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxMetier.FormattingEnabled = True
        Me.ComboBoxMetier.Location = New System.Drawing.Point(3, 3)
        Me.ComboBoxMetier.Name = "ComboBoxMetier"
        Me.ComboBoxMetier.Size = New System.Drawing.Size(137, 21)
        Me.ComboBoxMetier.TabIndex = 0
        '
        'ComboBoxSexe
        '
        Me.ComboBoxSexe.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxSexe.FormattingEnabled = True
        Me.ComboBoxSexe.Items.AddRange(New Object() {"", "Homme", "Femme"})
        Me.ComboBoxSexe.Location = New System.Drawing.Point(146, 3)
        Me.ComboBoxSexe.Name = "ComboBoxSexe"
        Me.ComboBoxSexe.Size = New System.Drawing.Size(137, 21)
        Me.ComboBoxSexe.TabIndex = 1
        '
        'ListBoxClient
        '
        Me.TableLayoutPanelMain.SetColumnSpan(Me.ListBoxClient, 2)
        Me.ListBoxClient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxClient.FormattingEnabled = True
        Me.ListBoxClient.Location = New System.Drawing.Point(3, 29)
        Me.ListBoxClient.Name = "ListBoxClient"
        Me.ListBoxClient.Size = New System.Drawing.Size(280, 230)
        Me.ListBoxClient.TabIndex = 2
        '
        'Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 290)
        Me.Controls.Add(Me.TableLayoutPanelMain)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Window"
        Me.Text = "Form"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.TableLayoutPanelMain.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanelMain As TableLayoutPanel
    Friend WithEvents ComboBoxSexe As ComboBox
    Friend WithEvents ComboBoxMetier As ComboBox
    Friend WithEvents ListBoxClient As ListBox
End Class
