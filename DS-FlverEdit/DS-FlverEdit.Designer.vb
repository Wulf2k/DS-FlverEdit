<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DS_FlverEdit
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.txtFLVERfile = New System.Windows.Forms.TextBox()
        Me.lblGAFile = New System.Windows.Forms.Label()
        Me.tabs = New System.Windows.Forms.TabControl()
        Me.tabHitbox = New System.Windows.Forms.TabPage()
        Me.dgvHitbox = New System.Windows.Forms.DataGridView()
        Me.tabMaterial = New System.Windows.Forms.TabPage()
        Me.dgvMaterial = New System.Windows.Forms.DataGridView()
        Me.tabBone = New System.Windows.Forms.TabPage()
        Me.dgvBone = New System.Windows.Forms.DataGridView()
        Me.tabMesh = New System.Windows.Forms.TabPage()
        Me.dgvMesh = New System.Windows.Forms.DataGridView()
        Me.tabs.SuspendLayout
        Me.tabHitbox.SuspendLayout
        CType(Me.dgvHitbox,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabMaterial.SuspendLayout
        CType(Me.dgvMaterial,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabBone.SuspendLayout
        CType(Me.dgvBone,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabMesh.SuspendLayout
        CType(Me.dgvMesh,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(1074, 38)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 39
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = true
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnOpen.Location = New System.Drawing.Point(996, 38)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 38
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = true
        '
        'txtFLVERfile
        '
        Me.txtFLVERfile.AllowDrop = true
        Me.txtFLVERfile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtFLVERfile.Location = New System.Drawing.Point(40, 12)
        Me.txtFLVERfile.Name = "txtFLVERfile"
        Me.txtFLVERfile.Size = New System.Drawing.Size(1109, 20)
        Me.txtFLVERfile.TabIndex = 36
        Me.txtFLVERfile.Text = "Drag 'n Drop FLVER file here"
        '
        'lblGAFile
        '
        Me.lblGAFile.AutoSize = true
        Me.lblGAFile.Location = New System.Drawing.Point(8, 15)
        Me.lblGAFile.Name = "lblGAFile"
        Me.lblGAFile.Size = New System.Drawing.Size(26, 13)
        Me.lblGAFile.TabIndex = 37
        Me.lblGAFile.Text = "File:"
        '
        'tabs
        '
        Me.tabs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tabs.Controls.Add(Me.tabHitbox)
        Me.tabs.Controls.Add(Me.tabMaterial)
        Me.tabs.Controls.Add(Me.tabBone)
        Me.tabs.Controls.Add(Me.tabMesh)
        Me.tabs.Location = New System.Drawing.Point(12, 63)
        Me.tabs.Name = "tabs"
        Me.tabs.SelectedIndex = 0
        Me.tabs.Size = New System.Drawing.Size(1145, 569)
        Me.tabs.TabIndex = 40
        '
        'tabHitbox
        '
        Me.tabHitbox.BackColor = System.Drawing.SystemColors.Control
        Me.tabHitbox.Controls.Add(Me.dgvHitbox)
        Me.tabHitbox.Location = New System.Drawing.Point(4, 22)
        Me.tabHitbox.Name = "tabHitbox"
        Me.tabHitbox.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHitbox.Size = New System.Drawing.Size(1137, 543)
        Me.tabHitbox.TabIndex = 0
        Me.tabHitbox.Text = "Hitbox"
        '
        'dgvHitbox
        '
        Me.dgvHitbox.AllowUserToResizeRows = false
        Me.dgvHitbox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgvHitbox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvHitbox.CausesValidation = false
        Me.dgvHitbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHitbox.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHitbox.Location = New System.Drawing.Point(7, 7)
        Me.dgvHitbox.Name = "dgvHitbox"
        Me.dgvHitbox.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvHitbox.Size = New System.Drawing.Size(1124, 530)
        Me.dgvHitbox.TabIndex = 0
        '
        'tabMaterial
        '
        Me.tabMaterial.BackColor = System.Drawing.SystemColors.Control
        Me.tabMaterial.Controls.Add(Me.dgvMaterial)
        Me.tabMaterial.Location = New System.Drawing.Point(4, 22)
        Me.tabMaterial.Name = "tabMaterial"
        Me.tabMaterial.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMaterial.Size = New System.Drawing.Size(1137, 543)
        Me.tabMaterial.TabIndex = 1
        Me.tabMaterial.Text = "Material"
        '
        'dgvMaterial
        '
        Me.dgvMaterial.AllowUserToResizeRows = false
        Me.dgvMaterial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgvMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMaterial.CausesValidation = false
        Me.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMaterial.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMaterial.Location = New System.Drawing.Point(7, 7)
        Me.dgvMaterial.Name = "dgvMaterial"
        Me.dgvMaterial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvMaterial.Size = New System.Drawing.Size(1124, 530)
        Me.dgvMaterial.TabIndex = 1
        '
        'tabBone
        '
        Me.tabBone.BackColor = System.Drawing.SystemColors.Control
        Me.tabBone.Controls.Add(Me.dgvBone)
        Me.tabBone.Location = New System.Drawing.Point(4, 22)
        Me.tabBone.Name = "tabBone"
        Me.tabBone.Size = New System.Drawing.Size(1137, 543)
        Me.tabBone.TabIndex = 2
        Me.tabBone.Text = "Bone"
        '
        'dgvBone
        '
        Me.dgvBone.AllowUserToResizeRows = false
        Me.dgvBone.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgvBone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvBone.CausesValidation = false
        Me.dgvBone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.NullValue = Nothing
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBone.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBone.Location = New System.Drawing.Point(7, 7)
        Me.dgvBone.Name = "dgvBone"
        Me.dgvBone.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvBone.Size = New System.Drawing.Size(1124, 530)
        Me.dgvBone.TabIndex = 1
        '
        'tabMesh
        '
        Me.tabMesh.BackColor = System.Drawing.SystemColors.Control
        Me.tabMesh.Controls.Add(Me.dgvMesh)
        Me.tabMesh.Location = New System.Drawing.Point(4, 22)
        Me.tabMesh.Name = "tabMesh"
        Me.tabMesh.Size = New System.Drawing.Size(1137, 543)
        Me.tabMesh.TabIndex = 3
        Me.tabMesh.Text = "Mesh"
        '
        'dgvMesh
        '
        Me.dgvMesh.AllowUserToResizeRows = false
        Me.dgvMesh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgvMesh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMesh.CausesValidation = false
        Me.dgvMesh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.NullValue = Nothing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMesh.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMesh.Location = New System.Drawing.Point(7, 7)
        Me.dgvMesh.Name = "dgvMesh"
        Me.dgvMesh.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvMesh.Size = New System.Drawing.Size(1124, 530)
        Me.dgvMesh.TabIndex = 2
        '
        'DS_FlverEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 644)
        Me.Controls.Add(Me.tabs)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.txtFLVERfile)
        Me.Controls.Add(Me.lblGAFile)
        Me.Name = "DS_FlverEdit"
        Me.Text = "Wulf's FLVER Editor"
        Me.tabs.ResumeLayout(false)
        Me.tabHitbox.ResumeLayout(false)
        CType(Me.dgvHitbox,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabMaterial.ResumeLayout(false)
        CType(Me.dgvMaterial,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabBone.ResumeLayout(false)
        CType(Me.dgvBone,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabMesh.ResumeLayout(false)
        CType(Me.dgvMesh,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents btnOpen As Button
    Friend WithEvents txtFLVERfile As TextBox
    Friend WithEvents lblGAFile As Label
    Friend WithEvents tabs As TabControl
    Friend WithEvents tabHitbox As TabPage
    Friend WithEvents tabMaterial As TabPage
    Friend WithEvents dgvHitbox As DataGridView
    Friend WithEvents dgvMaterial As DataGridView
    Friend WithEvents tabBone As TabPage
    Friend WithEvents dgvBone As DataGridView
    Friend WithEvents tabMesh As TabPage
    Friend WithEvents dgvMesh As DataGridView
End Class
