<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Superviseur
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelStatut = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControlMain = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanelMain = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonControl = New System.Windows.Forms.Button()
        Me.GroupBoxConfig = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanelConfig = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxChemin = New System.Windows.Forms.TextBox()
        Me.ButtonChoisirChemin = New System.Windows.Forms.Button()
        Me.LabelChemin = New System.Windows.Forms.Label()
        Me.LabelPort = New System.Windows.Forms.Label()
        Me.LabelAddresse = New System.Windows.Forms.Label()
        Me.NumericUpDownPortModif = New System.Windows.Forms.NumericUpDown()
        Me.TextBoxAddresseModif = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBoxLog = New System.Windows.Forms.TextBox()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.TabControlMain.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanelMain.SuspendLayout()
        Me.GroupBoxConfig.SuspendLayout()
        Me.TableLayoutPanelConfig.SuspendLayout()
        CType(Me.NumericUpDownPortModif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(770, 28)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(130, 26)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelStatut})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 265)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(770, 24)
        Me.StatusStrip.TabIndex = 1
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusLabelStatut
        '
        Me.ToolStripStatusLabelStatut.Name = "ToolStripStatusLabelStatut"
        Me.ToolStripStatusLabelStatut.Size = New System.Drawing.Size(0, 19)
        '
        'TabControlMain
        '
        Me.TabControlMain.Controls.Add(Me.TabPage1)
        Me.TabControlMain.Controls.Add(Me.TabPage2)
        Me.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlMain.Location = New System.Drawing.Point(0, 28)
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        Me.TabControlMain.Size = New System.Drawing.Size(770, 237)
        Me.TabControlMain.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanelMain)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(762, 208)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Contrôle"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelMain
        '
        Me.TableLayoutPanelMain.ColumnCount = 1
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 756.0!))
        Me.TableLayoutPanelMain.Controls.Add(Me.ButtonControl, 0, 1)
        Me.TableLayoutPanelMain.Controls.Add(Me.GroupBoxConfig, 0, 0)
        Me.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelMain.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanelMain.Name = "TableLayoutPanelMain"
        Me.TableLayoutPanelMain.RowCount = 2
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.72727!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273!))
        Me.TableLayoutPanelMain.Size = New System.Drawing.Size(756, 202)
        Me.TableLayoutPanelMain.TabIndex = 1
        '
        'ButtonControl
        '
        Me.ButtonControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonControl.Location = New System.Drawing.Point(3, 149)
        Me.ButtonControl.Name = "ButtonControl"
        Me.ButtonControl.Size = New System.Drawing.Size(750, 50)
        Me.ButtonControl.TabIndex = 1
        Me.ButtonControl.Text = "Démarrer"
        Me.ButtonControl.UseVisualStyleBackColor = True
        '
        'GroupBoxConfig
        '
        Me.GroupBoxConfig.Controls.Add(Me.TableLayoutPanelConfig)
        Me.GroupBoxConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxConfig.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxConfig.Name = "GroupBoxConfig"
        Me.GroupBoxConfig.Size = New System.Drawing.Size(750, 140)
        Me.GroupBoxConfig.TabIndex = 5
        Me.GroupBoxConfig.TabStop = False
        Me.GroupBoxConfig.Text = "Configuration"
        '
        'TableLayoutPanelConfig
        '
        Me.TableLayoutPanelConfig.ColumnCount = 3
        Me.TableLayoutPanelConfig.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanelConfig.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33333!))
        Me.TableLayoutPanelConfig.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TableLayoutPanelConfig.Controls.Add(Me.TextBoxChemin, 1, 3)
        Me.TableLayoutPanelConfig.Controls.Add(Me.ButtonChoisirChemin, 2, 3)
        Me.TableLayoutPanelConfig.Controls.Add(Me.LabelChemin, 0, 3)
        Me.TableLayoutPanelConfig.Controls.Add(Me.LabelPort, 0, 2)
        Me.TableLayoutPanelConfig.Controls.Add(Me.LabelAddresse, 0, 1)
        Me.TableLayoutPanelConfig.Controls.Add(Me.NumericUpDownPortModif, 1, 2)
        Me.TableLayoutPanelConfig.Controls.Add(Me.TextBoxAddresseModif, 1, 1)
        Me.TableLayoutPanelConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelConfig.Location = New System.Drawing.Point(3, 18)
        Me.TableLayoutPanelConfig.Name = "TableLayoutPanelConfig"
        Me.TableLayoutPanelConfig.RowCount = 5
        Me.TableLayoutPanelConfig.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelConfig.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelConfig.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelConfig.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelConfig.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelConfig.Size = New System.Drawing.Size(744, 119)
        Me.TableLayoutPanelConfig.TabIndex = 2
        '
        'TextBoxChemin
        '
        Me.TextBoxChemin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxChemin.Location = New System.Drawing.Point(118, 78)
        Me.TextBoxChemin.Name = "TextBoxChemin"
        Me.TextBoxChemin.Size = New System.Drawing.Size(571, 22)
        Me.TextBoxChemin.TabIndex = 3
        '
        'ButtonChoisirChemin
        '
        Me.ButtonChoisirChemin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonChoisirChemin.Location = New System.Drawing.Point(695, 77)
        Me.ButtonChoisirChemin.Name = "ButtonChoisirChemin"
        Me.ButtonChoisirChemin.Size = New System.Drawing.Size(46, 23)
        Me.ButtonChoisirChemin.TabIndex = 4
        Me.ButtonChoisirChemin.Text = "..."
        Me.ButtonChoisirChemin.UseVisualStyleBackColor = True
        '
        'LabelChemin
        '
        Me.LabelChemin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelChemin.AutoSize = True
        Me.LabelChemin.Location = New System.Drawing.Point(49, 80)
        Me.LabelChemin.Name = "LabelChemin"
        Me.LabelChemin.Size = New System.Drawing.Size(63, 17)
        Me.LabelChemin.TabIndex = 2
        Me.LabelChemin.Text = "Chemin :"
        '
        'LabelPort
        '
        Me.LabelPort.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelPort.AutoSize = True
        Me.LabelPort.Location = New System.Drawing.Point(70, 50)
        Me.LabelPort.Name = "LabelPort"
        Me.LabelPort.Size = New System.Drawing.Size(42, 17)
        Me.LabelPort.TabIndex = 6
        Me.LabelPort.Text = "Port :"
        '
        'LabelAddresse
        '
        Me.LabelAddresse.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelAddresse.AutoSize = True
        Me.LabelAddresse.Location = New System.Drawing.Point(36, 20)
        Me.LabelAddresse.Name = "LabelAddresse"
        Me.LabelAddresse.Size = New System.Drawing.Size(76, 17)
        Me.LabelAddresse.TabIndex = 5
        Me.LabelAddresse.Text = "Addresse :"
        '
        'NumericUpDownPortModif
        '
        Me.NumericUpDownPortModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDownPortModif.Location = New System.Drawing.Point(118, 48)
        Me.NumericUpDownPortModif.Maximum = New Decimal(New Integer() {65536, 0, 0, 0})
        Me.NumericUpDownPortModif.Name = "NumericUpDownPortModif"
        Me.NumericUpDownPortModif.Size = New System.Drawing.Size(571, 22)
        Me.NumericUpDownPortModif.TabIndex = 7
        '
        'TextBoxAddresseModif
        '
        Me.TextBoxAddresseModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxAddresseModif.Location = New System.Drawing.Point(118, 18)
        Me.TextBoxAddresseModif.Name = "TextBoxAddresseModif"
        Me.TextBoxAddresseModif.Size = New System.Drawing.Size(571, 22)
        Me.TextBoxAddresseModif.TabIndex = 8
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBoxLog)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(762, 208)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Log"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBoxLog
        '
        Me.TextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxLog.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxLog.Multiline = True
        Me.TextBoxLog.Name = "TextBoxLog"
        Me.TextBoxLog.Size = New System.Drawing.Size(756, 202)
        Me.TextBoxLog.TabIndex = 0
        '
        'Superviseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 289)
        Me.Controls.Add(Me.TabControlMain)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Superviseur"
        Me.Text = "Superviseur"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.TabControlMain.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanelMain.ResumeLayout(False)
        Me.GroupBoxConfig.ResumeLayout(False)
        Me.TableLayoutPanelConfig.ResumeLayout(False)
        Me.TableLayoutPanelConfig.PerformLayout()
        CType(Me.NumericUpDownPortModif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents TabControlMain As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanelMain As TableLayoutPanel
    Friend WithEvents ButtonControl As Button
    Friend WithEvents LabelChemin As Label
    Friend WithEvents TextBoxChemin As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ButtonChoisirChemin As Button
    Friend WithEvents ToolStripStatusLabelStatut As ToolStripStatusLabel
    Friend WithEvents TextBoxLog As TextBox
    Friend WithEvents GroupBoxConfig As GroupBox
    Friend WithEvents TableLayoutPanelConfig As TableLayoutPanel
    Friend WithEvents LabelPort As Label
    Friend WithEvents LabelAddresse As Label
    Friend WithEvents NumericUpDownPortModif As NumericUpDown
    Friend WithEvents TextBoxAddresseModif As TextBox
End Class
