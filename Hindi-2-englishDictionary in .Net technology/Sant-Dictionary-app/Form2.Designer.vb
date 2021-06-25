<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HideDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TempDataSet = New Sant_Dictionary_app.tempDataSet()
        Me.TempDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HindiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HindiTableAdapter = New Sant_Dictionary_app.tempDataSetTableAdapters.HindiTableAdapter()
        Me.TableAdapterManager = New Sant_Dictionary_app.tempDataSetTableAdapters.TableAdapterManager()
        Me.Hindi_wordListBox = New System.Windows.Forms.ListBox()
        Me.English_wordTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TempDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TempDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HindiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button7
        '
        Me.Button7.AutoEllipsis = True
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Red
        Me.Button7.Location = New System.Drawing.Point(311, 65)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(45, 30)
        Me.Button7.TabIndex = 32
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 31)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Welcome To Sant-H2E-Dictionary_App"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.PaleGreen
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(371, 24)
        Me.MenuStrip1.TabIndex = 30
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionToolStripMenuItem
        '
        Me.OptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripSeparator5, Me.ShowDatabaseToolStripMenuItem, Me.ToolStripSeparator1, Me.HideDatabaseToolStripMenuItem, Me.ToolStripSeparator2, Me.ToolStripMenuItem3, Me.ToolStripSeparator3, Me.ToolStripMenuItem1, Me.ToolStripSeparator4, Me.ExitToolStripMenuItem1})
        Me.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem"
        Me.OptionToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.OptionToolStripMenuItem.Text = "&Option"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(209, 22)
        Me.ToolStripMenuItem2.Text = "English Dictionary"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(206, 6)
        '
        'ShowDatabaseToolStripMenuItem
        '
        Me.ShowDatabaseToolStripMenuItem.Image = CType(resources.GetObject("ShowDatabaseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ShowDatabaseToolStripMenuItem.Name = "ShowDatabaseToolStripMenuItem"
        Me.ShowDatabaseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.ShowDatabaseToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ShowDatabaseToolStripMenuItem.Text = "Add New Word"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(206, 6)
        '
        'HideDatabaseToolStripMenuItem
        '
        Me.HideDatabaseToolStripMenuItem.Image = CType(resources.GetObject("HideDatabaseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HideDatabaseToolStripMenuItem.Name = "HideDatabaseToolStripMenuItem"
        Me.HideDatabaseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.HideDatabaseToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.HideDatabaseToolStripMenuItem.Text = "Modify Word"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(206, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(209, 22)
        Me.ToolStripMenuItem3.Text = "&Help"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(206, 6)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(209, 22)
        Me.ToolStripMenuItem1.Text = "About "
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(206, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Image = CType(resources.GetObject("ExitToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(209, 22)
        Me.ExitToolStripMenuItem1.Text = "&Exit"
        '
        'TempDataSet
        '
        Me.TempDataSet.DataSetName = "tempDataSet"
        Me.TempDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TempDataSetBindingSource
        '
        Me.TempDataSetBindingSource.DataSource = Me.TempDataSet
        Me.TempDataSetBindingSource.Position = 0
        '
        'HindiBindingSource
        '
        Me.HindiBindingSource.DataMember = "Hindi"
        Me.HindiBindingSource.DataSource = Me.TempDataSet
        '
        'HindiTableAdapter
        '
        Me.HindiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DictengTableAdapter = Nothing
        Me.TableAdapterManager.DictTableAdapter = Nothing
        Me.TableAdapterManager.EnglishTableAdapter = Nothing
        Me.TableAdapterManager.HindiTableAdapter = Me.HindiTableAdapter
        Me.TableAdapterManager.shipra_voacabularyTableAdapter = Nothing
        Me.TableAdapterManager.shipradata_decriptionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sant_Dictionary_app.tempDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Hindi_wordListBox
        '
        Me.Hindi_wordListBox.BackColor = System.Drawing.Color.Thistle
        Me.Hindi_wordListBox.DataSource = Me.HindiBindingSource
        Me.Hindi_wordListBox.DisplayMember = "Hindi_word"
        Me.Hindi_wordListBox.Font = New System.Drawing.Font("Kruti Dev 010", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hindi_wordListBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Hindi_wordListBox.FormattingEnabled = True
        Me.Hindi_wordListBox.ItemHeight = 17
        Me.Hindi_wordListBox.Location = New System.Drawing.Point(12, 98)
        Me.Hindi_wordListBox.Name = "Hindi_wordListBox"
        Me.Hindi_wordListBox.Size = New System.Drawing.Size(346, 208)
        Me.Hindi_wordListBox.TabIndex = 34
        '
        'English_wordTextBox
        '
        Me.English_wordTextBox.BackColor = System.Drawing.Color.Plum
        Me.English_wordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HindiBindingSource, "English_word", True))
        Me.English_wordTextBox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.English_wordTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.English_wordTextBox.Location = New System.Drawing.Point(12, 337)
        Me.English_wordTextBox.Multiline = True
        Me.English_wordTextBox.Name = "English_wordTextBox"
        Me.English_wordTextBox.Size = New System.Drawing.Size(346, 72)
        Me.English_wordTextBox.TabIndex = 35
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Aquamarine
        Me.TextBox2.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBox2.Location = New System.Drawing.Point(12, 304)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(346, 33)
        Me.TextBox2.TabIndex = 36
        Me.TextBox2.Text = "Translation into English"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ComboBox1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 66)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(300, 27)
        Me.ComboBox1.TabIndex = 37
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(371, 432)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.English_wordTextBox)
        Me.Controls.Add(Me.Hindi_wordListBox)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sant-H2E-Dictionary-App"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TempDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TempDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HindiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HideDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TempDataSet As Sant_Dictionary_app.tempDataSet
    Friend WithEvents TempDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HindiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HindiTableAdapter As Sant_Dictionary_app.tempDataSetTableAdapters.HindiTableAdapter
    Friend WithEvents TableAdapterManager As Sant_Dictionary_app.tempDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Hindi_wordListBox As System.Windows.Forms.ListBox
    Friend WithEvents English_wordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
