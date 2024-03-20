<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShippingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShippingForm))
        Me.RefreshLinkLabel = New NarsilWorks.DevLibWinForms.LinkLabel()
        Me.Footer1 = New NarsilWorks.DevLibWinForms.Footer()
        Me.CustomPanel1 = New NarsilWorks.DevLibWinForms.CustomPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchAll = New System.Windows.Forms.TextBox()
        Me.DataGridViewFilter1 = New NarsilWorks.DevLibWinForms.DataGridViewFilter()
        Me.DataGridView1 = New NarsilWorks.DevLibWinForms.DataGridView()
        Me.EmployeeKey = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.ImportButton = New System.Windows.Forms.Button()
        Me.ExportButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RefreshLinkLabel
        '
        Me.RefreshLinkLabel.AutoSize = True
        Me.RefreshLinkLabel.Location = New System.Drawing.Point(672, 16)
        Me.RefreshLinkLabel.Name = "RefreshLinkLabel"
        Me.RefreshLinkLabel.Size = New System.Drawing.Size(44, 13)
        Me.RefreshLinkLabel.TabIndex = 29
        Me.RefreshLinkLabel.TabStop = True
        Me.RefreshLinkLabel.Text = "Refresh"
        '
        'Footer1
        '
        Me.Footer1.AlertIconVisible = False
        Me.Footer1.AlertType = NarsilWorks.DevLibWinForms.Footer.AlertTypeStatusConstants.Info
        Me.Footer1.AutoSize = True
        Me.Footer1.DatabaseName = ""
        Me.Footer1.DatabaseUser = ""
        Me.Footer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Footer1.Location = New System.Drawing.Point(0, 425)
        Me.Footer1.LoggedOnUser = ""
        Me.Footer1.Name = "Footer1"
        Me.Footer1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks
        Me.Footer1.ProgressBarVisible = False
        Me.Footer1.ProgressValue = 0
        Me.Footer1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.Footer1.ServerName = ""
        Me.Footer1.Size = New System.Drawing.Size(800, 25)
        Me.Footer1.Status = ""
        Me.Footer1.TabIndex = 28
        '
        'CustomPanel1
        '
        Me.CustomPanel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CustomPanel1.BackColor2 = System.Drawing.SystemColors.Control
        Me.CustomPanel1.Location = New System.Drawing.Point(722, 274)
        Me.CustomPanel1.Name = "CustomPanel1"
        Me.CustomPanel1.Size = New System.Drawing.Size(66, 107)
        Me.CustomPanel1.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Search:"
        '
        'SearchAll
        '
        Me.SearchAll.Location = New System.Drawing.Point(68, 13)
        Me.SearchAll.Name = "SearchAll"
        Me.SearchAll.Size = New System.Drawing.Size(598, 20)
        Me.SearchAll.TabIndex = 25
        '
        'DataGridViewFilter1
        '
        Me.DataGridViewFilter1.AutoCompleteColumnFilters = New String(-1) {}
        Me.DataGridViewFilter1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridViewFilter1.DataGridView = Nothing
        Me.DataGridViewFilter1.DropdownColumnFilters = New String(-1) {}
        Me.DataGridViewFilter1.FieldHeight = 28
        Me.DataGridViewFilter1.FieldMargin = New System.Windows.Forms.Padding(1, 4, 1, 4)
        Me.DataGridViewFilter1.FixedFilter = ""
        Me.DataGridViewFilter1.Location = New System.Drawing.Point(12, 39)
        Me.DataGridViewFilter1.Name = "DataGridViewFilter1"
        Me.DataGridViewFilter1.Size = New System.Drawing.Size(704, 27)
        Me.DataGridViewFilter1.TabIndex = 24
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowMultiRowDrag = False
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoReflectEnableOnColumns = True
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CheckAllColumn = ""
        Me.DataGridView1.CheckAllToolTipText = ""
        Me.DataGridView1.CheckAllVisible = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeKey, Me.UserName, Me.FirstName, Me.LastName, Me.Email})
        Me.DataGridView1.CustomGroupRowPainting = False
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GroupRowBackColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.GroupRowDropShadowColor = System.Drawing.SystemColors.ControlDark
        Me.DataGridView1.GroupRowFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.GroupRowForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridView1.GroupRowHeight = 22.0!
        Me.DataGridView1.GroupRowIndicatorDataGridViewColumnName = ""
        Me.DataGridView1.GroupRowIndicatorID = ""
        Me.DataGridView1.GroupRowTextDataGridViewColumnName = ""
        Me.DataGridView1.Location = New System.Drawing.Point(12, 72)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(704, 347)
        Me.DataGridView1.TabIndex = 23
        '
        'EmployeeKey
        '
        Me.EmployeeKey.DataPropertyName = "EmployeeKey"
        Me.EmployeeKey.HeaderText = "EmployeeKey"
        Me.EmployeeKey.Name = "EmployeeKey"
        '
        'UserName
        '
        Me.UserName.DataPropertyName = "UserName"
        Me.UserName.HeaderText = "UserName"
        Me.UserName.Name = "UserName"
        '
        'FirstName
        '
        Me.FirstName.DataPropertyName = "FirstName"
        Me.FirstName.HeaderText = "FirstName"
        Me.FirstName.Name = "FirstName"
        '
        'LastName
        '
        Me.LastName.DataPropertyName = "LastName"
        Me.LastName.HeaderText = "LastName"
        Me.LastName.Name = "LastName"
        '
        'Email
        '
        Me.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        '
        'CloseButton
        '
        Me.CloseButton.AllowDrop = True
        Me.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CloseButton.Image = CType(resources.GetObject("CloseButton.Image"), System.Drawing.Image)
        Me.CloseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CloseButton.Location = New System.Drawing.Point(722, 387)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(66, 31)
        Me.CloseButton.TabIndex = 22
        Me.CloseButton.Text = "Close"
        Me.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.DeleteButton.Image = CType(resources.GetObject("DeleteButton.Image"), System.Drawing.Image)
        Me.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteButton.Location = New System.Drawing.Point(722, 237)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(66, 31)
        Me.DeleteButton.TabIndex = 21
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SaveButton.Image = CType(resources.GetObject("SaveButton.Image"), System.Drawing.Image)
        Me.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveButton.Location = New System.Drawing.Point(722, 162)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(66, 32)
        Me.SaveButton.TabIndex = 20
        Me.SaveButton.Text = "Save"
        Me.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CancelButton.Image = CType(resources.GetObject("CancelButton.Image"), System.Drawing.Image)
        Me.CancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelButton.Location = New System.Drawing.Point(722, 200)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(66, 31)
        Me.CancelButton.TabIndex = 19
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AddButton.Image = CType(resources.GetObject("AddButton.Image"), System.Drawing.Image)
        Me.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddButton.Location = New System.Drawing.Point(722, 87)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(66, 32)
        Me.AddButton.TabIndex = 18
        Me.AddButton.Text = "Add"
        Me.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.EditButton.Image = CType(resources.GetObject("EditButton.Image"), System.Drawing.Image)
        Me.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditButton.Location = New System.Drawing.Point(722, 125)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(66, 31)
        Me.EditButton.TabIndex = 17
        Me.EditButton.Text = "Edit"
        Me.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'ImportButton
        '
        Me.ImportButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ImportButton.Image = CType(resources.GetObject("ImportButton.Image"), System.Drawing.Image)
        Me.ImportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ImportButton.Location = New System.Drawing.Point(722, 12)
        Me.ImportButton.Name = "ImportButton"
        Me.ImportButton.Size = New System.Drawing.Size(66, 32)
        Me.ImportButton.TabIndex = 16
        Me.ImportButton.Text = "Import"
        Me.ImportButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ImportButton.UseVisualStyleBackColor = True
        '
        'ExportButton
        '
        Me.ExportButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ExportButton.Image = CType(resources.GetObject("ExportButton.Image"), System.Drawing.Image)
        Me.ExportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExportButton.Location = New System.Drawing.Point(722, 50)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(66, 31)
        Me.ExportButton.TabIndex = 15
        Me.ExportButton.Text = "Export"
        Me.ExportButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ExportButton.UseVisualStyleBackColor = True
        '
        'ShippingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RefreshLinkLabel)
        Me.Controls.Add(Me.Footer1)
        Me.Controls.Add(Me.CustomPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchAll)
        Me.Controls.Add(Me.DataGridViewFilter1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.ImportButton)
        Me.Controls.Add(Me.ExportButton)
        Me.Name = "ShippingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ShippingForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RefreshLinkLabel As NarsilWorks.DevLibWinForms.LinkLabel
    Friend WithEvents Footer1 As NarsilWorks.DevLibWinForms.Footer
    Friend WithEvents CustomPanel1 As NarsilWorks.DevLibWinForms.CustomPanel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents SearchAll As Windows.Forms.TextBox
    Public WithEvents DataGridViewFilter1 As NarsilWorks.DevLibWinForms.DataGridViewFilter
    Friend WithEvents DataGridView1 As NarsilWorks.DevLibWinForms.DataGridView
    Friend WithEvents EmployeeKey As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserName As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstName As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastName As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CloseButton As Windows.Forms.Button
    Friend WithEvents DeleteButton As Windows.Forms.Button
    Friend WithEvents SaveButton As Windows.Forms.Button
    Friend WithEvents CancelButton As Windows.Forms.Button
    Friend WithEvents AddButton As Windows.Forms.Button
    Friend WithEvents EditButton As Windows.Forms.Button
    Friend WithEvents ImportButton As Windows.Forms.Button
    Friend WithEvents ExportButton As Windows.Forms.Button
End Class
