<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstLanguage = New System.Windows.Forms.ComboBox()
        Me.btnTranslate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTranslation = New System.Windows.Forms.Label()
        Me.radBrother = New System.Windows.Forms.RadioButton()
        Me.radSister = New System.Windows.Forms.RadioButton()
        Me.radFather = New System.Windows.Forms.RadioButton()
        Me.radMother = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "T&ranslate to:"
        '
        'lstLanguage
        '
        Me.lstLanguage.FormattingEnabled = True
        Me.lstLanguage.Items.AddRange(New Object() {"French", "Italian", "Spanish"})
        Me.lstLanguage.Location = New System.Drawing.Point(148, 31)
        Me.lstLanguage.Name = "lstLanguage"
        Me.lstLanguage.Size = New System.Drawing.Size(236, 23)
        Me.lstLanguage.TabIndex = 5
        '
        'btnTranslate
        '
        Me.btnTranslate.Location = New System.Drawing.Point(148, 113)
        Me.btnTranslate.Name = "btnTranslate"
        Me.btnTranslate.Size = New System.Drawing.Size(141, 27)
        Me.btnTranslate.TabIndex = 6
        Me.btnTranslate.Text = "&Translate"
        Me.btnTranslate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(295, 113)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 27)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTranslation
        '
        Me.lblTranslation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTranslation.Location = New System.Drawing.Point(148, 59)
        Me.lblTranslation.Name = "lblTranslation"
        Me.lblTranslation.Size = New System.Drawing.Size(236, 51)
        Me.lblTranslation.TabIndex = 8
        Me.lblTranslation.Text = " "
        Me.lblTranslation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radBrother
        '
        Me.radBrother.AutoSize = True
        Me.radBrother.Location = New System.Drawing.Point(6, 97)
        Me.radBrother.Name = "radBrother"
        Me.radBrother.Size = New System.Drawing.Size(64, 19)
        Me.radBrother.TabIndex = 3
        Me.radBrother.TabStop = True
        Me.radBrother.Text = "&Brother"
        Me.radBrother.UseVisualStyleBackColor = True
        '
        'radSister
        '
        Me.radSister.AutoSize = True
        Me.radSister.Location = New System.Drawing.Point(6, 72)
        Me.radSister.Name = "radSister"
        Me.radSister.Size = New System.Drawing.Size(53, 19)
        Me.radSister.TabIndex = 2
        Me.radSister.TabStop = True
        Me.radSister.Text = "&Sister"
        Me.radSister.UseVisualStyleBackColor = True
        '
        'radFather
        '
        Me.radFather.AutoSize = True
        Me.radFather.Location = New System.Drawing.Point(6, 47)
        Me.radFather.Name = "radFather"
        Me.radFather.Size = New System.Drawing.Size(58, 19)
        Me.radFather.TabIndex = 1
        Me.radFather.TabStop = True
        Me.radFather.Text = "&Father"
        Me.radFather.UseVisualStyleBackColor = True
        '
        'radMother
        '
        Me.radMother.AutoSize = True
        Me.radMother.Location = New System.Drawing.Point(6, 22)
        Me.radMother.Name = "radMother"
        Me.radMother.Size = New System.Drawing.Size(64, 19)
        Me.radMother.TabIndex = 0
        Me.radMother.TabStop = True
        Me.radMother.Text = "&Mother"
        Me.radMother.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radMother)
        Me.GroupBox1.Controls.Add(Me.radFather)
        Me.GroupBox1.Controls.Add(Me.radSister)
        Me.GroupBox1.Controls.Add(Me.radBrother)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 128)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "English"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 153)
        Me.Controls.Add(Me.lblTranslation)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTranslate)
        Me.Controls.Add(Me.lstLanguage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.Text = "Translator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lstLanguage As ComboBox
    Friend WithEvents btnTranslate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTranslation As Label
    Friend WithEvents radBrother As RadioButton
    Friend WithEvents radSister As RadioButton
    Friend WithEvents radFather As RadioButton
    Friend WithEvents radMother As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
End Class
