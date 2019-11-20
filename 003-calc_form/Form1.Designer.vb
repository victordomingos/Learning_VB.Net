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
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_ano = New System.Windows.Forms.TextBox()
        Me.txt_valor_base = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chk_escalao = New System.Windows.Forms.CheckBox()
        Me.chk_desc_socio = New System.Windows.Forms.CheckBox()
        Me.chk_agravamento = New System.Windows.Forms.CheckBox()
        Me.rad_distrito_sim = New System.Windows.Forms.RadioButton()
        Me.rad_distrito_nao = New System.Windows.Forms.RadioButton()
        Me.cmb_concelho = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_resultado = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(126, 93)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(376, 20)
        Me.txt_nome.TabIndex = 0
        '
        'txt_ano
        '
        Me.txt_ano.Location = New System.Drawing.Point(126, 120)
        Me.txt_ano.Name = "txt_ano"
        Me.txt_ano.Size = New System.Drawing.Size(100, 20)
        Me.txt_ano.TabIndex = 1
        '
        'txt_valor_base
        '
        Me.txt_valor_base.Location = New System.Drawing.Point(126, 147)
        Me.txt_valor_base.Name = "txt_valor_base"
        Me.txt_valor_base.Size = New System.Drawing.Size(100, 20)
        Me.txt_valor_base.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(551, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'chk_escalao
        '
        Me.chk_escalao.AutoSize = True
        Me.chk_escalao.Location = New System.Drawing.Point(136, 274)
        Me.chk_escalao.Name = "chk_escalao"
        Me.chk_escalao.Size = New System.Drawing.Size(168, 17)
        Me.chk_escalao.TabIndex = 4
        Me.chk_escalao.Text = "Desconto de escalão (-10%)? "
        Me.chk_escalao.UseVisualStyleBackColor = True
        '
        'chk_desc_socio
        '
        Me.chk_desc_socio.AutoSize = True
        Me.chk_desc_socio.Location = New System.Drawing.Point(136, 298)
        Me.chk_desc_socio.Name = "chk_desc_socio"
        Me.chk_desc_socio.Size = New System.Drawing.Size(147, 17)
        Me.chk_desc_socio.TabIndex = 5
        Me.chk_desc_socio.Text = "Desconto de sócio (-5%)?"
        Me.chk_desc_socio.UseVisualStyleBackColor = True
        '
        'chk_agravamento
        '
        Me.chk_agravamento.AutoSize = True
        Me.chk_agravamento.Location = New System.Drawing.Point(136, 322)
        Me.chk_agravamento.Name = "chk_agravamento"
        Me.chk_agravamento.Size = New System.Drawing.Size(128, 17)
        Me.chk_agravamento.TabIndex = 6
        Me.chk_agravamento.Text = "Agravamento (+12€)?"
        Me.chk_agravamento.UseVisualStyleBackColor = True
        '
        'rad_distrito_sim
        '
        Me.rad_distrito_sim.AutoSize = True
        Me.rad_distrito_sim.Checked = True
        Me.rad_distrito_sim.Location = New System.Drawing.Point(352, 271)
        Me.rad_distrito_sim.Name = "rad_distrito_sim"
        Me.rad_distrito_sim.Size = New System.Drawing.Size(42, 17)
        Me.rad_distrito_sim.TabIndex = 7
        Me.rad_distrito_sim.TabStop = True
        Me.rad_distrito_sim.Text = "Sim"
        Me.rad_distrito_sim.UseVisualStyleBackColor = True
        '
        'rad_distrito_nao
        '
        Me.rad_distrito_nao.AutoSize = True
        Me.rad_distrito_nao.Location = New System.Drawing.Point(352, 294)
        Me.rad_distrito_nao.Name = "rad_distrito_nao"
        Me.rad_distrito_nao.Size = New System.Drawing.Size(45, 17)
        Me.rad_distrito_nao.TabIndex = 8
        Me.rad_distrito_nao.Text = "Não"
        Me.rad_distrito_nao.UseVisualStyleBackColor = True
        '
        'cmb_concelho
        '
        Me.cmb_concelho.FormattingEnabled = True
        Me.cmb_concelho.Items.AddRange(New Object() {"Braga", "Amares", "Vila Verde", "Póvoa de Lanhoso", "Guimarães"})
        Me.cmb_concelho.Location = New System.Drawing.Point(126, 173)
        Me.cmb_concelho.Name = "cmb_concelho"
        Me.cmb_concelho.Size = New System.Drawing.Size(121, 21)
        Me.cmb_concelho.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 31)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Calcular Avença"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Ano de nascimento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Valor base"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Concelho"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(123, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Descontos/agravamentos:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(339, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Reside no distrito?"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(123, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "______________________"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(339, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "_______________________"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(337, 382)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 25)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Total a pagar:"
        '
        'lbl_resultado
        '
        Me.lbl_resultado.AutoSize = True
        Me.lbl_resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_resultado.Location = New System.Drawing.Point(499, 382)
        Me.lbl_resultado.Name = "lbl_resultado"
        Me.lbl_resultado.Size = New System.Drawing.Size(45, 25)
        Me.lbl_resultado.TabIndex = 20
        Me.lbl_resultado.Text = "0 €"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 431)
        Me.Controls.Add(Me.lbl_resultado)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_concelho)
        Me.Controls.Add(Me.rad_distrito_nao)
        Me.Controls.Add(Me.rad_distrito_sim)
        Me.Controls.Add(Me.chk_agravamento)
        Me.Controls.Add(Me.chk_desc_socio)
        Me.Controls.Add(Me.chk_escalao)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_valor_base)
        Me.Controls.Add(Me.txt_ano)
        Me.Controls.Add(Me.txt_nome)
        Me.Name = "Form1"
        Me.Text = "CalcForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_ano As TextBox
    Friend WithEvents txt_valor_base As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents chk_escalao As CheckBox
    Friend WithEvents chk_desc_socio As CheckBox
    Friend WithEvents chk_agravamento As CheckBox
    Friend WithEvents rad_distrito_sim As RadioButton
    Friend WithEvents rad_distrito_nao As RadioButton
    Friend WithEvents cmb_concelho As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_resultado As Label
End Class
