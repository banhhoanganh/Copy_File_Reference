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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BTfrom = New System.Windows.Forms.Button()
        Me.BTto = New System.Windows.Forms.Button()
        Me.BTcsv = New System.Windows.Forms.Button()
        Me.TBfrom = New System.Windows.Forms.TextBox()
        Me.TBto = New System.Windows.Forms.TextBox()
        Me.TBcsv = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BTstart = New System.Windows.Forms.Button()
        Me.Note = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BTfrom
        '
        Me.BTfrom.BackColor = System.Drawing.Color.SteelBlue
        Me.BTfrom.BackgroundImage = Global.Copy_File_Reference.My.Resources.Resources.folder
        Me.BTfrom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTfrom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTfrom.FlatAppearance.BorderSize = 0
        Me.BTfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BTfrom.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BTfrom.Location = New System.Drawing.Point(7, 6)
        Me.BTfrom.Name = "BTfrom"
        Me.BTfrom.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.BTfrom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTfrom.Size = New System.Drawing.Size(96, 41)
        Me.BTfrom.TabIndex = 0
        Me.BTfrom.Text = "From"
        Me.BTfrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTfrom.UseVisualStyleBackColor = False
        '
        'BTto
        '
        Me.BTto.BackColor = System.Drawing.Color.SteelBlue
        Me.BTto.BackgroundImage = Global.Copy_File_Reference.My.Resources.Resources.folder
        Me.BTto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTto.FlatAppearance.BorderSize = 0
        Me.BTto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BTto.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BTto.Location = New System.Drawing.Point(7, 51)
        Me.BTto.Name = "BTto"
        Me.BTto.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.BTto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTto.Size = New System.Drawing.Size(96, 41)
        Me.BTto.TabIndex = 0
        Me.BTto.Text = "To"
        Me.BTto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTto.UseVisualStyleBackColor = False
        '
        'BTcsv
        '
        Me.BTcsv.BackColor = System.Drawing.Color.SteelBlue
        Me.BTcsv.BackgroundImage = Global.Copy_File_Reference.My.Resources.Resources.csv
        Me.BTcsv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTcsv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTcsv.FlatAppearance.BorderSize = 0
        Me.BTcsv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BTcsv.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BTcsv.Location = New System.Drawing.Point(7, 96)
        Me.BTcsv.Name = "BTcsv"
        Me.BTcsv.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.BTcsv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTcsv.Size = New System.Drawing.Size(96, 41)
        Me.BTcsv.TabIndex = 0
        Me.BTcsv.Text = ".csv"
        Me.BTcsv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTcsv.UseVisualStyleBackColor = False
        '
        'TBfrom
        '
        Me.TBfrom.BackColor = System.Drawing.Color.LightBlue
        Me.TBfrom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBfrom.Enabled = False
        Me.TBfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TBfrom.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TBfrom.Location = New System.Drawing.Point(112, 18)
        Me.TBfrom.Name = "TBfrom"
        Me.TBfrom.Size = New System.Drawing.Size(324, 16)
        Me.TBfrom.TabIndex = 1
        Me.TBfrom.TabStop = False
        Me.TBfrom.Text = "Link to Reference folder "
        '
        'TBto
        '
        Me.TBto.BackColor = System.Drawing.Color.LightBlue
        Me.TBto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBto.Enabled = False
        Me.TBto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TBto.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TBto.Location = New System.Drawing.Point(112, 63)
        Me.TBto.Name = "TBto"
        Me.TBto.Size = New System.Drawing.Size(324, 16)
        Me.TBto.TabIndex = 1
        Me.TBto.TabStop = False
        Me.TBto.Text = "Link to Work folder "
        '
        'TBcsv
        '
        Me.TBcsv.BackColor = System.Drawing.Color.LightBlue
        Me.TBcsv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBcsv.Enabled = False
        Me.TBcsv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TBcsv.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TBcsv.Location = New System.Drawing.Point(112, 108)
        Me.TBcsv.Name = "TBcsv"
        Me.TBcsv.Size = New System.Drawing.Size(324, 16)
        Me.TBcsv.TabIndex = 1
        Me.TBcsv.TabStop = False
        Me.TBcsv.Text = "Link to csv file"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(10, 145)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(323, 18)
        Me.ProgressBar1.TabIndex = 2
        '
        'BTstart
        '
        Me.BTstart.BackColor = System.Drawing.Color.SteelBlue
        Me.BTstart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTstart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTstart.Enabled = False
        Me.BTstart.FlatAppearance.BorderSize = 0
        Me.BTstart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BTstart.ForeColor = System.Drawing.Color.White
        Me.BTstart.Location = New System.Drawing.Point(342, 137)
        Me.BTstart.Name = "BTstart"
        Me.BTstart.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.BTstart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTstart.Size = New System.Drawing.Size(96, 32)
        Me.BTstart.TabIndex = 0
        Me.BTstart.Text = "Start"
        Me.BTstart.UseVisualStyleBackColor = False
        '
        'Note
        '
        Me.Note.BackColor = System.Drawing.Color.LightBlue
        Me.Note.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Note.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Note.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Note.Location = New System.Drawing.Point(13, 173)
        Me.Note.Name = "Note"
        Me.Note.Size = New System.Drawing.Size(420, 16)
        Me.Note.TabIndex = 3
        Me.Note.Text = "Status"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(449, 196)
        Me.Controls.Add(Me.Note)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TBcsv)
        Me.Controls.Add(Me.TBto)
        Me.Controls.Add(Me.TBfrom)
        Me.Controls.Add(Me.BTstart)
        Me.Controls.Add(Me.BTcsv)
        Me.Controls.Add(Me.BTto)
        Me.Controls.Add(Me.BTfrom)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(465, 235)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(465, 235)
        Me.Name = "Form1"
        Me.Text = "Copy File Reference"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTfrom As Button
    Friend WithEvents BTto As Button
    Friend WithEvents BTcsv As Button
    Friend WithEvents TBfrom As TextBox
    Friend WithEvents TBto As TextBox
    Friend WithEvents TBcsv As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents BTstart As Button
    Friend WithEvents Note As TextBox
End Class
