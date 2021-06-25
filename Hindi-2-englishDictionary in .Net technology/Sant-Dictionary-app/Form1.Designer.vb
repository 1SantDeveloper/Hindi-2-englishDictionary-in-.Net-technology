<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.HireMeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DictengBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TempDataSet = New Sant_Dictionary_app.tempDataSet()
        Me.English_wordListBox = New System.Windows.Forms.ListBox()
        Me.Hindi_wordTextBox = New System.Windows.Forms.TextBox()
        Me.DictengTableAdapter = New Sant_Dictionary_app.tempDataSetTableAdapters.DictengTableAdapter()
        Me.TableAdapterManager = New Sant_Dictionary_app.tempDataSetTableAdapters.TableAdapterManager()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnglishwordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HindiwordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DictengBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TempDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.PaleGreen
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionToolStripMenuItem, Me.AboutUsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(409, 31)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionToolStripMenuItem
        '
        Me.OptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5, Me.ShowDatabaseToolStripMenuItem, Me.ToolStripSeparator1, Me.ToolStripSeparator2, Me.ToolStripMenuItem3, Me.ToolStripSeparator3, Me.ToolStripSeparator4, Me.ExitToolStripMenuItem1})
        Me.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem"
        Me.OptionToolStripMenuItem.Size = New System.Drawing.Size(66, 27)
        Me.OptionToolStripMenuItem.Text = "&Option"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(234, 6)
        '
        'ShowDatabaseToolStripMenuItem
        '
        Me.ShowDatabaseToolStripMenuItem.Image = CType(resources.GetObject("ShowDatabaseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ShowDatabaseToolStripMenuItem.Name = "ShowDatabaseToolStripMenuItem"
        Me.ShowDatabaseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.ShowDatabaseToolStripMenuItem.Size = New System.Drawing.Size(237, 28)
        Me.ShowDatabaseToolStripMenuItem.Text = "Add New Word"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(234, 6)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(234, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(237, 28)
        Me.ToolStripMenuItem3.Text = "&Help"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(234, 6)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(234, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Image = CType(resources.GetObject("ExitToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(237, 28)
        Me.ExitToolStripMenuItem1.Text = "&Exit"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServicesToolStripMenuItem, Me.ToolStripSeparator8, Me.HireMeToolStripMenuItem, Me.ToolStripSeparator6, Me.DonateToolStripMenuItem, Me.ToolStripSeparator7})
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(82, 27)
        Me.AboutUsToolStripMenuItem.Text = "&About Us"
        '
        'ServicesToolStripMenuItem
        '
        Me.ServicesToolStripMenuItem.Name = "ServicesToolStripMenuItem"
        Me.ServicesToolStripMenuItem.Size = New System.Drawing.Size(133, 28)
        Me.ServicesToolStripMenuItem.Text = "&Services"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(130, 6)
        '
        'HireMeToolStripMenuItem
        '
        Me.HireMeToolStripMenuItem.Name = "HireMeToolStripMenuItem"
        Me.HireMeToolStripMenuItem.Size = New System.Drawing.Size(133, 28)
        Me.HireMeToolStripMenuItem.Text = "&Hire Me"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(130, 6)
        '
        'DonateToolStripMenuItem
        '
        Me.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem"
        Me.DonateToolStripMenuItem.Size = New System.Drawing.Size(133, 28)
        Me.DonateToolStripMenuItem.Text = "&Donate"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(130, 6)
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Red
        Me.Button7.Location = New System.Drawing.Point(3, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(45, 29)
        Me.Button7.TabIndex = 28
        Me.Button7.TabStop = False
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 31)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Welcome To Sant-E2H-Dictionary_App"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Aquamarine
        Me.TextBox2.Font = New System.Drawing.Font("Kruti Dev 010", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(29, 297)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(349, 27)
        Me.TextBox2.TabIndex = 31
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = "fganh  es  vuqokn"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DictengBindingSource
        '
        Me.DictengBindingSource.DataMember = "Dicteng"
        Me.DictengBindingSource.DataSource = Me.TempDataSet
        '
        'TempDataSet
        '
        Me.TempDataSet.DataSetName = "tempDataSet"
        Me.TempDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'English_wordListBox
        '
        Me.English_wordListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.English_wordListBox.DataSource = Me.DictengBindingSource
        Me.English_wordListBox.DisplayMember = "English_word"
        Me.English_wordListBox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.English_wordListBox.ForeColor = System.Drawing.Color.Blue
        Me.English_wordListBox.FormattingEnabled = True
        Me.English_wordListBox.ItemHeight = 19
        Me.English_wordListBox.Location = New System.Drawing.Point(29, 102)
        Me.English_wordListBox.Name = "English_wordListBox"
        Me.English_wordListBox.Size = New System.Drawing.Size(349, 194)
        Me.English_wordListBox.TabIndex = 34
        Me.English_wordListBox.TabStop = False
        '
        'Hindi_wordTextBox
        '
        Me.Hindi_wordTextBox.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Hindi_wordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DictengBindingSource, "Hindi_word", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Hindi_wordTextBox.Font = New System.Drawing.Font("Kruti Dev 010", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hindi_wordTextBox.ForeColor = System.Drawing.Color.Maroon
        Me.Hindi_wordTextBox.Location = New System.Drawing.Point(29, 325)
        Me.Hindi_wordTextBox.Multiline = True
        Me.Hindi_wordTextBox.Name = "Hindi_wordTextBox"
        Me.Hindi_wordTextBox.ReadOnly = True
        Me.Hindi_wordTextBox.Size = New System.Drawing.Size(349, 135)
        Me.Hindi_wordTextBox.TabIndex = 35
        Me.Hindi_wordTextBox.TabStop = False
        Me.Hindi_wordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DictengTableAdapter
        '
        Me.DictengTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DictengTableAdapter = Me.DictengTableAdapter
        Me.TableAdapterManager.DictTableAdapter = Nothing
        Me.TableAdapterManager.EnglishTableAdapter = Nothing
        Me.TableAdapterManager.HindiTableAdapter = Nothing
        Me.TableAdapterManager.shipra_voacabularyTableAdapter = Nothing
        Me.TableAdapterManager.shipradata_decriptionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sant_Dictionary_app.tempDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ComboBox1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(46, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(300, 27)
        Me.ComboBox1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SnoDataGridViewTextBoxColumn, Me.EnglishwordDataGridViewTextBoxColumn, Me.HindiwordDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DictengBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(461, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(244, 377)
        Me.DataGridView1.TabIndex = 39
        '
        'SnoDataGridViewTextBoxColumn
        '
        Me.SnoDataGridViewTextBoxColumn.DataPropertyName = "Sno"
        Me.SnoDataGridViewTextBoxColumn.HeaderText = "Sno"
        Me.SnoDataGridViewTextBoxColumn.Name = "SnoDataGridViewTextBoxColumn"
        '
        'EnglishwordDataGridViewTextBoxColumn
        '
        Me.EnglishwordDataGridViewTextBoxColumn.DataPropertyName = "English_word"
        Me.EnglishwordDataGridViewTextBoxColumn.HeaderText = "English_word"
        Me.EnglishwordDataGridViewTextBoxColumn.Name = "EnglishwordDataGridViewTextBoxColumn"
        '
        'HindiwordDataGridViewTextBoxColumn
        '
        Me.HindiwordDataGridViewTextBoxColumn.DataPropertyName = "Hindi_word"
        Me.HindiwordDataGridViewTextBoxColumn.HeaderText = "Hindi_word"
        Me.HindiwordDataGridViewTextBoxColumn.Name = "HindiwordDataGridViewTextBoxColumn"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateBlue
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Location = New System.Drawing.Point(29, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 35)
        Me.Panel1.TabIndex = 41
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(409, 467)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Hindi_wordTextBox)
        Me.Controls.Add(Me.English_wordListBox)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sant-E2H-Dictionay-app"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DictengBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TempDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TempDataSet As Sant_Dictionary_app.tempDataSet
    Friend WithEvents DictengBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DictengTableAdapter As Sant_Dictionary_app.tempDataSetTableAdapters.DictengTableAdapter
    Friend WithEvents TableAdapterManager As Sant_Dictionary_app.tempDataSetTableAdapters.TableAdapterManager
    Friend WithEvents English_wordListBox As System.Windows.Forms.ListBox
    Friend WithEvents Hindi_wordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnglishwordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HindiwordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AboutUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HireMeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DonateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator

End Class
