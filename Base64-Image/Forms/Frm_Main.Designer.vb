<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Main))
        Me.Ofd_LoadImage = New System.Windows.Forms.OpenFileDialog()
        Me.SFD_Image = New System.Windows.Forms.SaveFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Pbx_Image = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatLabel = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.Pbx_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ofd_LoadImage
        '
        Me.Ofd_LoadImage.FileName = "ImageFile"
        Me.Ofd_LoadImage.Filter = "PNG (*.png)|*.png|JPG (*.jpg)|*.jpg"
        Me.Ofd_LoadImage.Title = "Load an Image"
        '
        'SFD_Image
        '
        Me.SFD_Image.Filter = "Image (*.png)|*.png"
        Me.SFD_Image.Title = "Base64ConvertedImage.png"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(24, 274)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 25)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Convert an Image"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(513, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 25)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Convert to Image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(139, 274)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 25)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Save Image"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Pbx_Image
        '
        Me.Pbx_Image.Location = New System.Drawing.Point(12, 12)
        Me.Pbx_Image.Name = "Pbx_Image"
        Me.Pbx_Image.Size = New System.Drawing.Size(309, 256)
        Me.Pbx_Image.TabIndex = 9
        Me.Pbx_Image.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(327, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(309, 256)
        Me.RichTextBox1.TabIndex = 10
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 311)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(645, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatLabel
        '
        Me.StatLabel.Name = "StatLabel"
        Me.StatLabel.Size = New System.Drawing.Size(120, 17)
        Me.StatLabel.Text = "ToolStripStatusLabel1"
        '
        'Frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 333)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Pbx_Image)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.Pbx_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ofd_LoadImage As OpenFileDialog
    Friend WithEvents SFD_Image As SaveFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Pbx_Image As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatLabel As ToolStripStatusLabel
End Class
