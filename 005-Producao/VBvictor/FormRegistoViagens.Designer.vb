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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.grid1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_marca = New System.Windows.Forms.TextBox()
        Me.txt_km = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FicheiroToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FicheiroToolStripMenuItem
        '
        Me.FicheiroToolStripMenuItem.Name = "FicheiroToolStripMenuItem"
        Me.FicheiroToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.FicheiroToolStripMenuItem.Text = "Ficheiro"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_limpar_bd, Me.btn_lancar_registos, Me.btn_listar, Me.btn_limpar_grid, Me.btn_viagens2dias, Me.cmb_filtro})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_limpar_bd
        '
        Me.btn_limpar_bd.Image = CType(resources.GetObject("btn_limpar_bd.Image"), System.Drawing.Image)
        Me.btn_limpar_bd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_limpar_bd.Name = "btn_limpar_bd"
        Me.btn_limpar_bd.Size = New System.Drawing.Size(82, 22)
        Me.btn_limpar_bd.Text = "Limpar BD"
        '
        'btn_lancar_registos
        '
        Me.btn_lancar_registos.Image = CType(resources.GetObject("btn_lancar_registos.Image"), System.Drawing.Image)
        Me.btn_lancar_registos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_lancar_registos.Name = "btn_lancar_registos"
        Me.btn_lancar_registos.Size = New System.Drawing.Size(106, 22)
        Me.btn_lancar_registos.Text = "Lançar registos"
        '
        'btn_listar
        '
        Me.btn_listar.Image = CType(resources.GetObject("btn_listar.Image"), System.Drawing.Image)
        Me.btn_listar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_listar.Name = "btn_listar"
        Me.btn_listar.Size = New System.Drawing.Size(55, 22)
        Me.btn_listar.Text = "Listar"
        '
        'btn_limpar_grid
        '
        Me.btn_limpar_grid.Image = CType(resources.GetObject("btn_limpar_grid.Image"), System.Drawing.Image)
        Me.btn_limpar_grid.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_limpar_grid.Name = "btn_limpar_grid"
        Me.btn_limpar_grid.Size = New System.Drawing.Size(99, 22)
        Me.btn_limpar_grid.Text = "Limpar Janela"
        '
        'btn_viagens2dias
        '
        Me.btn_viagens2dias.Image = CType(resources.GetObject("btn_viagens2dias.Image"), System.Drawing.Image)
        Me.btn_viagens2dias.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_viagens2dias.Name = "btn_viagens2dias"
        Me.btn_viagens2dias.Size = New System.Drawing.Size(119, 22)
        Me.btn_viagens2dias.Text = "Nº Viagens 2 Dias"
        '
        'cmb_filtro
        '
        Me.cmb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_filtro.Items.AddRange(New Object() {"Mostrar todas as viagens", "Apenas viagens de 1 dia", "Apenas viagens de 2 ou mais dias"})
        Me.cmb_filtro.Name = "cmb_filtro"
        Me.cmb_filtro.Size = New System.Drawing.Size(200, 25)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 571)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'grid1
        '
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Location = New System.Drawing.Point(0, 52)
        Me.grid1.Name = "grid1"
        Me.grid1.Size = New System.Drawing.Size(553, 516)
        Me.grid1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_km)
        Me.GroupBox1.Controls.Add(Me.txt_marca)
        Me.GroupBox1.Location = New System.Drawing.Point(571, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 92)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calcular distância"
        '
        'txt_marca
        '
        Me.txt_marca.Location = New System.Drawing.Point(94, 29)
        Me.txt_marca.Name = "txt_marca"
        Me.txt_marca.Size = New System.Drawing.Size(100, 20)
        Me.txt_marca.TabIndex = 0
        '
        'txt_km
        '
        Me.txt_km.Location = New System.Drawing.Point(94, 56)
        Me.txt_km.Name = "txt_km"
        Me.txt_km.Size = New System.Drawing.Size(100, 20)
        Me.txt_km.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Marca da viatura"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Calcular km"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormRegistoViagens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 593)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormRegistoViagens"
        Me.Text = "Registo de Viagens"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
End Class
