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
        Me.lbl_hello = New System.Windows.Forms.Label()
        Me.btn_clickme = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_hello
        '
        Me.lbl_hello.AutoSize = True
        Me.lbl_hello.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hello.Location = New System.Drawing.Point(58, 48)
        Me.lbl_hello.Name = "lbl_hello"
        Me.lbl_hello.Size = New System.Drawing.Size(195, 31)
        Me.lbl_hello.TabIndex = 0
        Me.lbl_hello.Text = "Hello world!..."
        '
        'btn_clickme
        '
        Me.btn_clickme.Location = New System.Drawing.Point(90, 107)
        Me.btn_clickme.Name = "btn_clickme"
        Me.btn_clickme.Size = New System.Drawing.Size(127, 34)
        Me.btn_clickme.TabIndex = 1
        Me.btn_clickme.Text = "Click me!"
        Me.btn_clickme.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 167)
        Me.Controls.Add(Me.btn_clickme)
        Me.Controls.Add(Me.lbl_hello)
        Me.Name = "Form1"
        Me.Text = "001 Hello World App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_hello As Label
    Friend WithEvents btn_clickme As Button
End Class
