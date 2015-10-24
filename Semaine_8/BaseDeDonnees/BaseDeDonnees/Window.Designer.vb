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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanelMain = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonInsert = New System.Windows.Forms.Button()
        Me.NumericUpDownAge = New System.Windows.Forms.NumericUpDown()
        Me.DateTimePickerInscription = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxPrenom = New System.Windows.Forms.TextBox()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelAge = New System.Windows.Forms.Label()
        Me.ListBoxAfficher = New System.Windows.Forms.ListBox()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanelMain.SuspendLayout()
        CType(Me.NumericUpDownAge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(493, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
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
        Me.TableLayoutPanelMain.ColumnCount = 3
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.17937!))
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.82063!))
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186.0!))
        Me.TableLayoutPanelMain.Controls.Add(Me.ButtonInsert, 1, 4)
        Me.TableLayoutPanelMain.Controls.Add(Me.NumericUpDownAge, 1, 3)
        Me.TableLayoutPanelMain.Controls.Add(Me.DateTimePickerInscription, 1, 2)
        Me.TableLayoutPanelMain.Controls.Add(Me.TextBoxPrenom, 1, 1)
        Me.TableLayoutPanelMain.Controls.Add(Me.TextBoxNom, 1, 0)
        Me.TableLayoutPanelMain.Controls.Add(Me.LabelNom, 0, 0)
        Me.TableLayoutPanelMain.Controls.Add(Me.LabelPrenom, 0, 1)
        Me.TableLayoutPanelMain.Controls.Add(Me.LabelDate, 0, 2)
        Me.TableLayoutPanelMain.Controls.Add(Me.LabelAge, 0, 3)
        Me.TableLayoutPanelMain.Controls.Add(Me.ListBoxAfficher, 2, 0)
        Me.TableLayoutPanelMain.Controls.Add(Me.ButtonUpdate, 1, 5)
        Me.TableLayoutPanelMain.Controls.Add(Me.ButtonDelete, 1, 6)
        Me.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelMain.Enabled = False
        Me.TableLayoutPanelMain.Location = New System.Drawing.Point(0, 28)
        Me.TableLayoutPanelMain.Name = "TableLayoutPanelMain"
        Me.TableLayoutPanelMain.RowCount = 7
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanelMain.Size = New System.Drawing.Size(493, 213)
        Me.TableLayoutPanelMain.TabIndex = 1
        '
        'ButtonInsert
        '
        Me.ButtonInsert.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonInsert.Location = New System.Drawing.Point(64, 123)
        Me.ButtonInsert.Name = "ButtonInsert"
        Me.ButtonInsert.Size = New System.Drawing.Size(239, 24)
        Me.ButtonInsert.TabIndex = 38
        Me.ButtonInsert.Text = "Insert"
        Me.ButtonInsert.UseVisualStyleBackColor = True
        '
        'NumericUpDownAge
        '
        Me.NumericUpDownAge.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDownAge.Location = New System.Drawing.Point(64, 95)
        Me.NumericUpDownAge.Name = "NumericUpDownAge"
        Me.NumericUpDownAge.Size = New System.Drawing.Size(239, 20)
        Me.NumericUpDownAge.TabIndex = 30
        '
        'DateTimePickerInscription
        '
        Me.DateTimePickerInscription.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePickerInscription.Location = New System.Drawing.Point(64, 65)
        Me.DateTimePickerInscription.Name = "DateTimePickerInscription"
        Me.DateTimePickerInscription.Size = New System.Drawing.Size(239, 20)
        Me.DateTimePickerInscription.TabIndex = 29
        '
        'TextBoxPrenom
        '
        Me.TextBoxPrenom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPrenom.Location = New System.Drawing.Point(64, 35)
        Me.TextBoxPrenom.Name = "TextBoxPrenom"
        Me.TextBoxPrenom.Size = New System.Drawing.Size(239, 20)
        Me.TextBoxPrenom.TabIndex = 28
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNom.Location = New System.Drawing.Point(64, 5)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(239, 20)
        Me.TextBoxNom.TabIndex = 27
        '
        'LabelNom
        '
        Me.LabelNom.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(24, 7)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(34, 15)
        Me.LabelNom.TabIndex = 20
        Me.LabelNom.Text = "Nom"
        '
        'LabelPrenom
        '
        Me.LabelPrenom.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Location = New System.Drawing.Point(7, 37)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(51, 15)
        Me.LabelPrenom.TabIndex = 22
        Me.LabelPrenom.Text = "Prénom"
        '
        'LabelDate
        '
        Me.LabelDate.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Location = New System.Drawing.Point(25, 67)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(33, 15)
        Me.LabelDate.TabIndex = 23
        Me.LabelDate.Text = "Date"
        '
        'LabelAge
        '
        Me.LabelAge.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelAge.AutoSize = True
        Me.LabelAge.Location = New System.Drawing.Point(30, 97)
        Me.LabelAge.Name = "LabelAge"
        Me.LabelAge.Size = New System.Drawing.Size(28, 15)
        Me.LabelAge.TabIndex = 24
        Me.LabelAge.Text = "Age"
        '
        'ListBoxAfficher
        '
        Me.ListBoxAfficher.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxAfficher.FormattingEnabled = True
        Me.ListBoxAfficher.Location = New System.Drawing.Point(309, 3)
        Me.ListBoxAfficher.Name = "ListBoxAfficher"
        Me.TableLayoutPanelMain.SetRowSpan(Me.ListBoxAfficher, 7)
        Me.ListBoxAfficher.Size = New System.Drawing.Size(181, 207)
        Me.ListBoxAfficher.TabIndex = 43
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonDelete.Enabled = False
        Me.ButtonDelete.Location = New System.Drawing.Point(64, 183)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(239, 27)
        Me.ButtonDelete.TabIndex = 50
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonUpdate.Enabled = False
        Me.ButtonUpdate.Location = New System.Drawing.Point(64, 153)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(239, 24)
        Me.ButtonUpdate.TabIndex = 49
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 241)
        Me.Controls.Add(Me.TableLayoutPanelMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Window"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanelMain.ResumeLayout(False)
        Me.TableLayoutPanelMain.PerformLayout()
        CType(Me.NumericUpDownAge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TableLayoutPanelMain As TableLayoutPanel
    Friend WithEvents ButtonInsert As Button
    Friend WithEvents NumericUpDownAge As NumericUpDown
    Friend WithEvents DateTimePickerInscription As DateTimePicker
    Friend WithEvents TextBoxPrenom As TextBox
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents LabelNom As Label
    Friend WithEvents LabelPrenom As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents LabelAge As Label
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBoxAfficher As ListBox
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonUpdate As Button
End Class
