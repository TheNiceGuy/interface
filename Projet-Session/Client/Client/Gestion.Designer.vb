<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion
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
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxInformation = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelEtudiantInfo = New System.Windows.Forms.Label()
        Me.LabelEtudiantInfoModif = New System.Windows.Forms.Label()
        Me.LabelProgrammeInfo = New System.Windows.Forms.Label()
        Me.LabelNaissanceInfo = New System.Windows.Forms.Label()
        Me.LabelCourrielInfo = New System.Windows.Forms.Label()
        Me.LabelProgrammeInfoModif = New System.Windows.Forms.Label()
        Me.LabelNaissanceInfoModif = New System.Windows.Forms.Label()
        Me.LabelCourrielInfoModif = New System.Windows.Forms.Label()
        Me.GroupBoxModification = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.ButtonAccepter = New System.Windows.Forms.Button()
        Me.LabelProgrammeModif = New System.Windows.Forms.Label()
        Me.ComboBoxProgrammeModif = New System.Windows.Forms.ComboBox()
        Me.LabelPasswordModif = New System.Windows.Forms.Label()
        Me.TextBoxPasswordModif = New System.Windows.Forms.TextBox()
        Me.LabelPasswordVerificationModif = New System.Windows.Forms.Label()
        Me.TextBoxPasswordVerificationModif = New System.Windows.Forms.TextBox()
        Me.LabelCourrielModif = New System.Windows.Forms.Label()
        Me.TextBoxCourrielModif = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanelBotin = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelFiltreProgramme = New System.Windows.Forms.Label()
        Me.ListViewEtudiants = New System.Windows.Forms.ListView()
        Me.ColumnHeaderNom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderProgramme = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderCourriel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderPadding = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ComboBoxFiltreProgramme = New System.Windows.Forms.ComboBox()
        Me.ButtonActualiser = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBoxInformation.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBoxModification.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanelBotin.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(768, 28)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeToolStripMenuItem, Me.ToolStripSeparator1, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.FichierToolStripMenuItem.Text = "Menu"
        '
        'DeToolStripMenuItem
        '
        Me.DeToolStripMenuItem.Name = "DeToolStripMenuItem"
        Me.DeToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.DeToolStripMenuItem.Text = "Deconnexion"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(168, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 28)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(768, 300)
        Me.TabControl.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(760, 271)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Profil"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxInformation, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxModification, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(754, 265)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBoxInformation
        '
        Me.GroupBoxInformation.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBoxInformation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxInformation.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxInformation.Name = "GroupBoxInformation"
        Me.GroupBoxInformation.Size = New System.Drawing.Size(371, 259)
        Me.GroupBoxInformation.TabIndex = 0
        Me.GroupBoxInformation.TabStop = False
        Me.GroupBoxInformation.Text = "Information"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.LabelEtudiantInfo, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelEtudiantInfoModif, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelProgrammeInfo, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelNaissanceInfo, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelCourrielInfo, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelProgrammeInfoModif, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelNaissanceInfoModif, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelCourrielInfoModif, 2, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 18)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(365, 238)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'LabelEtudiantInfo
        '
        Me.LabelEtudiantInfo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelEtudiantInfo.AutoSize = True
        Me.LabelEtudiantInfo.Location = New System.Drawing.Point(77, 58)
        Me.LabelEtudiantInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelEtudiantInfo.Name = "LabelEtudiantInfo"
        Me.LabelEtudiantInfo.Size = New System.Drawing.Size(68, 17)
        Me.LabelEtudiantInfo.TabIndex = 9
        Me.LabelEtudiantInfo.Text = "Étudiant :"
        '
        'LabelEtudiantInfoModif
        '
        Me.LabelEtudiantInfoModif.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelEtudiantInfoModif.AutoSize = True
        Me.LabelEtudiantInfoModif.Location = New System.Drawing.Point(145, 58)
        Me.LabelEtudiantInfoModif.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelEtudiantInfoModif.Name = "LabelEtudiantInfoModif"
        Me.LabelEtudiantInfoModif.Size = New System.Drawing.Size(14, 17)
        Me.LabelEtudiantInfoModif.TabIndex = 16
        Me.LabelEtudiantInfoModif.Text = "x"
        '
        'LabelProgrammeInfo
        '
        Me.LabelProgrammeInfo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelProgrammeInfo.AutoSize = True
        Me.LabelProgrammeInfo.Location = New System.Drawing.Point(56, 93)
        Me.LabelProgrammeInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelProgrammeInfo.Name = "LabelProgrammeInfo"
        Me.LabelProgrammeInfo.Size = New System.Drawing.Size(89, 17)
        Me.LabelProgrammeInfo.TabIndex = 11
        Me.LabelProgrammeInfo.Text = "Programme :"
        '
        'LabelNaissanceInfo
        '
        Me.LabelNaissanceInfo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelNaissanceInfo.AutoSize = True
        Me.LabelNaissanceInfo.Location = New System.Drawing.Point(63, 128)
        Me.LabelNaissanceInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelNaissanceInfo.Name = "LabelNaissanceInfo"
        Me.LabelNaissanceInfo.Size = New System.Drawing.Size(82, 17)
        Me.LabelNaissanceInfo.TabIndex = 12
        Me.LabelNaissanceInfo.Text = "Naissance :"
        '
        'LabelCourrielInfo
        '
        Me.LabelCourrielInfo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelCourrielInfo.AutoSize = True
        Me.LabelCourrielInfo.Location = New System.Drawing.Point(80, 163)
        Me.LabelCourrielInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelCourrielInfo.Name = "LabelCourrielInfo"
        Me.LabelCourrielInfo.Size = New System.Drawing.Size(65, 17)
        Me.LabelCourrielInfo.TabIndex = 15
        Me.LabelCourrielInfo.Text = "Courriel :"
        '
        'LabelProgrammeInfoModif
        '
        Me.LabelProgrammeInfoModif.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelProgrammeInfoModif.AutoSize = True
        Me.LabelProgrammeInfoModif.Location = New System.Drawing.Point(145, 93)
        Me.LabelProgrammeInfoModif.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelProgrammeInfoModif.Name = "LabelProgrammeInfoModif"
        Me.LabelProgrammeInfoModif.Size = New System.Drawing.Size(14, 17)
        Me.LabelProgrammeInfoModif.TabIndex = 18
        Me.LabelProgrammeInfoModif.Text = "x"
        '
        'LabelNaissanceInfoModif
        '
        Me.LabelNaissanceInfoModif.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelNaissanceInfoModif.AutoSize = True
        Me.LabelNaissanceInfoModif.Location = New System.Drawing.Point(145, 128)
        Me.LabelNaissanceInfoModif.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelNaissanceInfoModif.Name = "LabelNaissanceInfoModif"
        Me.LabelNaissanceInfoModif.Size = New System.Drawing.Size(14, 17)
        Me.LabelNaissanceInfoModif.TabIndex = 19
        Me.LabelNaissanceInfoModif.Text = "x"
        '
        'LabelCourrielInfoModif
        '
        Me.LabelCourrielInfoModif.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelCourrielInfoModif.AutoSize = True
        Me.LabelCourrielInfoModif.Location = New System.Drawing.Point(145, 163)
        Me.LabelCourrielInfoModif.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelCourrielInfoModif.Name = "LabelCourrielInfoModif"
        Me.LabelCourrielInfoModif.Size = New System.Drawing.Size(14, 17)
        Me.LabelCourrielInfoModif.TabIndex = 20
        Me.LabelCourrielInfoModif.Text = "x"
        '
        'GroupBoxModification
        '
        Me.GroupBoxModification.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBoxModification.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxModification.Location = New System.Drawing.Point(380, 3)
        Me.GroupBoxModification.Name = "GroupBoxModification"
        Me.GroupBoxModification.Size = New System.Drawing.Size(371, 259)
        Me.GroupBoxModification.TabIndex = 1
        Me.GroupBoxModification.TabStop = False
        Me.GroupBoxModification.Text = "Modification"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonReset, 3, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonAccepter, 2, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelProgrammeModif, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.ComboBoxProgrammeModif, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelPasswordModif, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxPasswordModif, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelPasswordVerificationModif, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxPasswordVerificationModif, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelCourrielModif, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxCourrielModif, 2, 4)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 18)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 7
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(365, 238)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'ButtonReset
        '
        Me.ButtonReset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonReset.Location = New System.Drawing.Point(235, 174)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(94, 29)
        Me.ButtonReset.TabIndex = 8
        Me.ButtonReset.Text = "Réinitialiser"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'ButtonAccepter
        '
        Me.ButtonAccepter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAccepter.Location = New System.Drawing.Point(135, 174)
        Me.ButtonAccepter.Name = "ButtonAccepter"
        Me.ButtonAccepter.Size = New System.Drawing.Size(94, 29)
        Me.ButtonAccepter.TabIndex = 7
        Me.ButtonAccepter.Text = "Accepter"
        Me.ButtonAccepter.UseVisualStyleBackColor = True
        '
        'LabelProgrammeModif
        '
        Me.LabelProgrammeModif.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelProgrammeModif.AutoSize = True
        Me.LabelProgrammeModif.Location = New System.Drawing.Point(48, 40)
        Me.LabelProgrammeModif.Name = "LabelProgrammeModif"
        Me.LabelProgrammeModif.Size = New System.Drawing.Size(81, 17)
        Me.LabelProgrammeModif.TabIndex = 11
        Me.LabelProgrammeModif.Text = "Programme"
        '
        'ComboBoxProgrammeModif
        '
        Me.ComboBoxProgrammeModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.ComboBoxProgrammeModif, 2)
        Me.ComboBoxProgrammeModif.Enabled = False
        Me.ComboBoxProgrammeModif.FormattingEnabled = True
        Me.ComboBoxProgrammeModif.Location = New System.Drawing.Point(135, 36)
        Me.ComboBoxProgrammeModif.Name = "ComboBoxProgrammeModif"
        Me.ComboBoxProgrammeModif.Size = New System.Drawing.Size(194, 24)
        Me.ComboBoxProgrammeModif.TabIndex = 2
        '
        'LabelPasswordModif
        '
        Me.LabelPasswordModif.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelPasswordModif.AutoSize = True
        Me.LabelPasswordModif.Location = New System.Drawing.Point(60, 75)
        Me.LabelPasswordModif.Name = "LabelPasswordModif"
        Me.LabelPasswordModif.Size = New System.Drawing.Size(69, 17)
        Me.LabelPasswordModif.TabIndex = 13
        Me.LabelPasswordModif.Text = "Password"
        '
        'TextBoxPasswordModif
        '
        Me.TextBoxPasswordModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.TextBoxPasswordModif, 2)
        Me.TextBoxPasswordModif.Location = New System.Drawing.Point(135, 72)
        Me.TextBoxPasswordModif.Name = "TextBoxPasswordModif"
        Me.TextBoxPasswordModif.Size = New System.Drawing.Size(194, 22)
        Me.TextBoxPasswordModif.TabIndex = 4
        Me.TextBoxPasswordModif.UseSystemPasswordChar = True
        '
        'LabelPasswordVerificationModif
        '
        Me.LabelPasswordVerificationModif.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelPasswordVerificationModif.AutoSize = True
        Me.LabelPasswordVerificationModif.Location = New System.Drawing.Point(60, 110)
        Me.LabelPasswordVerificationModif.Name = "LabelPasswordVerificationModif"
        Me.LabelPasswordVerificationModif.Size = New System.Drawing.Size(69, 17)
        Me.LabelPasswordVerificationModif.TabIndex = 14
        Me.LabelPasswordVerificationModif.Text = "(Répéter)"
        '
        'TextBoxPasswordVerificationModif
        '
        Me.TextBoxPasswordVerificationModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.TextBoxPasswordVerificationModif, 2)
        Me.TextBoxPasswordVerificationModif.Location = New System.Drawing.Point(135, 107)
        Me.TextBoxPasswordVerificationModif.Name = "TextBoxPasswordVerificationModif"
        Me.TextBoxPasswordVerificationModif.Size = New System.Drawing.Size(194, 22)
        Me.TextBoxPasswordVerificationModif.TabIndex = 5
        Me.TextBoxPasswordVerificationModif.UseSystemPasswordChar = True
        '
        'LabelCourrielModif
        '
        Me.LabelCourrielModif.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelCourrielModif.AutoSize = True
        Me.LabelCourrielModif.Location = New System.Drawing.Point(72, 145)
        Me.LabelCourrielModif.Name = "LabelCourrielModif"
        Me.LabelCourrielModif.Size = New System.Drawing.Size(57, 17)
        Me.LabelCourrielModif.TabIndex = 15
        Me.LabelCourrielModif.Text = "Courriel"
        '
        'TextBoxCourrielModif
        '
        Me.TextBoxCourrielModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.TextBoxCourrielModif, 2)
        Me.TextBoxCourrielModif.Location = New System.Drawing.Point(135, 142)
        Me.TextBoxCourrielModif.Name = "TextBoxCourrielModif"
        Me.TextBoxCourrielModif.Size = New System.Drawing.Size(194, 22)
        Me.TextBoxCourrielModif.TabIndex = 6
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanelBotin)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(760, 271)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Botin"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelBotin
        '
        Me.TableLayoutPanelBotin.ColumnCount = 3
        Me.TableLayoutPanelBotin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanelBotin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelBotin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanelBotin.Controls.Add(Me.LabelFiltreProgramme, 0, 0)
        Me.TableLayoutPanelBotin.Controls.Add(Me.ListViewEtudiants, 0, 1)
        Me.TableLayoutPanelBotin.Controls.Add(Me.ComboBoxFiltreProgramme, 1, 0)
        Me.TableLayoutPanelBotin.Controls.Add(Me.ButtonActualiser, 2, 0)
        Me.TableLayoutPanelBotin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelBotin.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanelBotin.Name = "TableLayoutPanelBotin"
        Me.TableLayoutPanelBotin.RowCount = 2
        Me.TableLayoutPanelBotin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanelBotin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelBotin.Size = New System.Drawing.Size(754, 265)
        Me.TableLayoutPanelBotin.TabIndex = 0
        '
        'LabelFiltreProgramme
        '
        Me.LabelFiltreProgramme.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelFiltreProgramme.AutoSize = True
        Me.LabelFiltreProgramme.Location = New System.Drawing.Point(16, 9)
        Me.LabelFiltreProgramme.Name = "LabelFiltreProgramme"
        Me.LabelFiltreProgramme.Size = New System.Drawing.Size(81, 17)
        Me.LabelFiltreProgramme.TabIndex = 0
        Me.LabelFiltreProgramme.Text = "Programme"
        '
        'ListViewEtudiants
        '
        Me.ListViewEtudiants.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderNom, Me.ColumnHeaderProgramme, Me.ColumnHeaderCourriel, Me.ColumnHeaderPadding})
        Me.TableLayoutPanelBotin.SetColumnSpan(Me.ListViewEtudiants, 3)
        Me.ListViewEtudiants.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewEtudiants.Location = New System.Drawing.Point(3, 38)
        Me.ListViewEtudiants.Name = "ListViewEtudiants"
        Me.ListViewEtudiants.Size = New System.Drawing.Size(748, 224)
        Me.ListViewEtudiants.TabIndex = 0
        Me.ListViewEtudiants.UseCompatibleStateImageBehavior = False
        Me.ListViewEtudiants.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderNom
        '
        Me.ColumnHeaderNom.Text = "Étudiant"
        '
        'ColumnHeaderProgramme
        '
        Me.ColumnHeaderProgramme.Text = "Programme"
        Me.ColumnHeaderProgramme.Width = 83
        '
        'ColumnHeaderCourriel
        '
        Me.ColumnHeaderCourriel.Text = "Courriel"
        Me.ColumnHeaderCourriel.Width = 58
        '
        'ColumnHeaderPadding
        '
        Me.ColumnHeaderPadding.Text = ""
        Me.ColumnHeaderPadding.Width = 543
        '
        'ComboBoxFiltreProgramme
        '
        Me.ComboBoxFiltreProgramme.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxFiltreProgramme.Enabled = False
        Me.ComboBoxFiltreProgramme.FormattingEnabled = True
        Me.ComboBoxFiltreProgramme.Location = New System.Drawing.Point(103, 5)
        Me.ComboBoxFiltreProgramme.Name = "ComboBoxFiltreProgramme"
        Me.ComboBoxFiltreProgramme.Size = New System.Drawing.Size(548, 24)
        Me.ComboBoxFiltreProgramme.TabIndex = 1
        '
        'ButtonActualiser
        '
        Me.ButtonActualiser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonActualiser.Location = New System.Drawing.Point(657, 3)
        Me.ButtonActualiser.Name = "ButtonActualiser"
        Me.ButtonActualiser.Size = New System.Drawing.Size(94, 29)
        Me.ButtonActualiser.TabIndex = 2
        Me.ButtonActualiser.Text = "Actualiser"
        Me.ButtonActualiser.UseVisualStyleBackColor = True
        '
        'Gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 328)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Gestion"
        Me.Text = "Gestion"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBoxInformation.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBoxModification.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanelBotin.ResumeLayout(False)
        Me.TableLayoutPanelBotin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBoxInformation As GroupBox
    Friend WithEvents GroupBoxModification As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LabelProgrammeInfo As Label
    Friend WithEvents LabelNaissanceInfo As Label
    Friend WithEvents LabelEtudiantInfo As Label
    Friend WithEvents LabelCourrielInfo As Label
    Friend WithEvents LabelEtudiantInfoModif As Label
    Friend WithEvents LabelProgrammeInfoModif As Label
    Friend WithEvents LabelNaissanceInfoModif As Label
    Friend WithEvents LabelCourrielInfoModif As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents LabelProgrammeModif As Label
    Friend WithEvents ComboBoxProgrammeModif As ComboBox
    Friend WithEvents LabelPasswordModif As Label
    Friend WithEvents TextBoxPasswordModif As TextBox
    Friend WithEvents LabelPasswordVerificationModif As Label
    Friend WithEvents TextBoxPasswordVerificationModif As TextBox
    Friend WithEvents LabelCourrielModif As Label
    Friend WithEvents TextBoxCourrielModif As TextBox
    Friend WithEvents ButtonReset As Button
    Friend WithEvents ButtonAccepter As Button
    Friend WithEvents TableLayoutPanelBotin As TableLayoutPanel
    Friend WithEvents ListViewEtudiants As ListView
    Friend WithEvents ColumnHeaderNom As ColumnHeader
    Friend WithEvents ColumnHeaderProgramme As ColumnHeader
    Friend WithEvents ColumnHeaderCourriel As ColumnHeader
    Friend WithEvents ColumnHeaderPadding As ColumnHeader
    Friend WithEvents LabelFiltreProgramme As Label
    Friend WithEvents ComboBoxFiltreProgramme As ComboBox
    Friend WithEvents ButtonActualiser As Button
End Class
