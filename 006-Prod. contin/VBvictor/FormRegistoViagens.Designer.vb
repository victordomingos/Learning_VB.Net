<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistoViagens
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegistoViagens))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FicheiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_limpar_bd = New System.Windows.Forms.ToolStripButton()
        Me.btn_lancar_registos = New System.Windows.Forms.ToolStripButton()
        Me.btn_listar = New System.Windows.Forms.ToolStripButton()
        Me.btn_limpar_grid = New System.Windows.Forms.ToolStripButton()
        Me.btn_viagens2dias = New System.Windows.Forms.ToolStripButton()
        Me.cmb_filtro = New System.Windows.Forms.ToolStripComboBox()
        Me.btn_atualizar_registos = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.grid1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_km = New System.Windows.Forms.TextBox()
        Me.txt_marca = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_viatura_mais_km = New System.Windows.Forms.Button()
        Me.lbx_viatura_mais_km = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FicheiroToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1686, 48)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FicheiroToolStripMenuItem
        '
        Me.FicheiroToolStripMenuItem.Name = "FicheiroToolStripMenuItem"
        Me.FicheiroToolStripMenuItem.Size = New System.Drawing.Size(119, 36)
        Me.FicheiroToolStripMenuItem.Text = "Ficheiro"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(96, 36)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_limpar_bd, Me.btn_lancar_registos, Me.btn_listar, Me.btn_limpar_grid, Me.btn_viagens2dias, Me.cmb_filtro, Me.btn_atualizar_registos})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 48)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 4, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1686, 50)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_limpar_bd
        '
        Me.btn_limpar_bd.Image = CType(resources.GetObject("btn_limpar_bd.Image"), System.Drawing.Image)
        Me.btn_limpar_bd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_limpar_bd.Name = "btn_limpar_bd"
        Me.btn_limpar_bd.Size = New System.Drawing.Size(161, 44)
        Me.btn_limpar_bd.Text = "Limpar BD"
        '
        'btn_lancar_registos
        '
        Me.btn_lancar_registos.Image = CType(resources.GetObject("btn_lancar_registos.Image"), System.Drawing.Image)
        Me.btn_lancar_registos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_lancar_registos.Name = "btn_lancar_registos"
        Me.btn_lancar_registos.Size = New System.Drawing.Size(209, 36)
        Me.btn_lancar_registos.Text = "Lançar registos"
        '
        'btn_listar
        '
        Me.btn_listar.Image = CType(resources.GetObject("btn_listar.Image"), System.Drawing.Image)
        Me.btn_listar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_listar.Name = "btn_listar"
        Me.btn_listar.Size = New System.Drawing.Size(106, 36)
        Me.btn_listar.Text = "Listar"
        '
        'btn_limpar_grid
        '
        Me.btn_limpar_grid.Image = CType(resources.GetObject("btn_limpar_grid.Image"), System.Drawing.Image)
        Me.btn_limpar_grid.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_limpar_grid.Name = "btn_limpar_grid"
        Me.btn_limpar_grid.Size = New System.Drawing.Size(196, 36)
        Me.btn_limpar_grid.Text = "Limpar Janela"
        '
        'btn_viagens2dias
        '
        Me.btn_viagens2dias.Image = CType(resources.GetObject("btn_viagens2dias.Image"), System.Drawing.Image)
        Me.btn_viagens2dias.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_viagens2dias.Name = "btn_viagens2dias"
        Me.btn_viagens2dias.Size = New System.Drawing.Size(242, 36)
        Me.btn_viagens2dias.Text = "Nº Viagens 2 Dias"
        '
        'cmb_filtro
        '
        Me.cmb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_filtro.Items.AddRange(New Object() {"Mostrar todas as viagens", "Apenas viagens de 1 dia", "Apenas viagens de 2 ou mais dias"})
        Me.cmb_filtro.Name = "cmb_filtro"
        Me.cmb_filtro.Size = New System.Drawing.Size(200, 42)
        '
        'btn_atualizar_registos
        '
        Me.btn_atualizar_registos.Image = CType(resources.GetObject("btn_atualizar_registos.Image"), System.Drawing.Image)
        Me.btn_atualizar_registos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_atualizar_registos.Name = "btn_atualizar_registos"
        Me.btn_atualizar_registos.Size = New System.Drawing.Size(238, 44)
        Me.btn_atualizar_registos.Text = "Atualizar Registos"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1118)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 28, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1686, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'grid1
        '
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Location = New System.Drawing.Point(0, 100)
        Me.grid1.Margin = New System.Windows.Forms.Padding(6)
        Me.grid1.Name = "grid1"
        Me.grid1.RowHeadersWidth = 82
        Me.grid1.Size = New System.Drawing.Size(1180, 992)
        Me.grid1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_km)
        Me.GroupBox1.Controls.Add(Me.txt_marca)
        Me.GroupBox1.Location = New System.Drawing.Point(1192, 200)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(400, 177)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calcular distância"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 102)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 44)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Calcular km"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Marca da viatura"
        '
        'txt_km
        '
        Me.txt_km.Location = New System.Drawing.Point(188, 108)
        Me.txt_km.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_km.Name = "txt_km"
        Me.txt_km.Size = New System.Drawing.Size(196, 31)
        Me.txt_km.TabIndex = 1
        '
        'txt_marca
        '
        Me.txt_marca.Location = New System.Drawing.Point(188, 56)
        Me.txt_marca.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_marca.Name = "txt_marca"
        Me.txt_marca.Size = New System.Drawing.Size(196, 31)
        Me.txt_marca.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_viatura_mais_km)
        Me.GroupBox2.Controls.Add(Me.lbx_viatura_mais_km)
        Me.GroupBox2.Location = New System.Drawing.Point(1192, 427)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Size = New System.Drawing.Size(400, 192)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Viatura com mais km"
        '
        'btn_viatura_mais_km
        '
        Me.btn_viatura_mais_km.Location = New System.Drawing.Point(18, 35)
        Me.btn_viatura_mais_km.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_viatura_mais_km.Name = "btn_viatura_mais_km"
        Me.btn_viatura_mais_km.Size = New System.Drawing.Size(370, 44)
        Me.btn_viatura_mais_km.TabIndex = 1
        Me.btn_viatura_mais_km.Text = "Atualizar"
        Me.btn_viatura_mais_km.UseVisualStyleBackColor = True
        '
        'lbx_viatura_mais_km
        '
        Me.lbx_viatura_mais_km.FormattingEnabled = True
        Me.lbx_viatura_mais_km.ItemHeight = 25
        Me.lbx_viatura_mais_km.Location = New System.Drawing.Point(18, 90)
        Me.lbx_viatura_mais_km.Margin = New System.Windows.Forms.Padding(6)
        Me.lbx_viatura_mais_km.Name = "lbx_viatura_mais_km"
        Me.lbx_viatura_mais_km.Size = New System.Drawing.Size(366, 79)
        Me.lbx_viatura_mais_km.TabIndex = 0
        '
        'FormRegistoViagens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1686, 1140)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FormRegistoViagens"
        Me.Text = "Registo de Viagens"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FicheiroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_limpar_bd As ToolStripButton
    Friend WithEvents btn_lancar_registos As ToolStripButton
    Friend WithEvents btn_listar As ToolStripButton
    Friend WithEvents btn_limpar_grid As ToolStripButton
    Friend WithEvents btn_viagens2dias As ToolStripButton
    Friend WithEvents cmb_filtro As ToolStripComboBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents grid1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_km As TextBox
    Friend WithEvents txt_marca As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_viatura_mais_km As Button
    Friend WithEvents lbx_viatura_mais_km As ListBox
    Friend WithEvents btn_atualizar_registos As ToolStripButton
End Class
