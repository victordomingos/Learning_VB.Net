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
        Me.txt_1 = New System.Windows.Forms.TextBox()
        Me.txt_2 = New System.Windows.Forms.TextBox()
        Me.lbl_sum = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_1
        '
        Me.txt_1.Location = New System.Drawing.Point(119, 31)
        Me.txt_1.Name = "txt_1"
        Me.txt_1.Size = New System.Drawing.Size(176, 20)
        Me.txt_1.TabIndex = 0
        Me.txt_1.Text = "0"
        Me.txt_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_2
        '
        Me.txt_2.Location = New System.Drawing.Point(119, 79)
        Me.txt_2.Name = "txt_2"
        Me.txt_2.Size = New System.Drawing.Size(176, 20)
        Me.txt_2.TabIndex = 1
        Me.txt_2.Text = "0"
        Me.txt_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_sum
        '
        Me.lbl_sum.AutoSize = True
        Me.lbl_sum.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sum.Location = New System.Drawing.Point(28, 138)
        Me.lbl_sum.Name = "lbl_sum"
        Me.lbl_sum.Size = New System.Drawing.Size(85, 25)
        Me.lbl_sum.TabIndex = 2
        Me.lbl_sum.Text = "Sum: 0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "First number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Second number"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 198)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_sum)
        Me.Controls.Add(Me.txt_2)
        Me.Controls.Add(Me.txt_1)
        Me.Name = "Form1"
        Me.Text = "The Simple Sum Machine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_1 As TextBox
    Friend WithEvents txt_2 As TextBox
    Friend WithEvents lbl_sum As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
