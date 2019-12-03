<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestorProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestorProdutos))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FicheiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbl_status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grid1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.cmb_categorias = New System.Windows.Forms.ComboBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.grp_detalhes = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_qtd = New System.Windows.Forms.TextBox()
        Me.txt_designacao = New System.Windows.Forms.TextBox()
        Me.cmb_detalhes_categoria = New System.Windows.Forms.ComboBox()
        Me.txt_cod_produto = New System.Windows.Forms.TextBox()
        Me.lbl_unsaved_Changes = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.grp_detalhes.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FicheiroToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(802, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FicheiroToolStripMenuItem
        '
        Me.FicheiroToolStripMenuItem.Name = "FicheiroToolStripMenuItem"
        Me.FicheiroToolStripMenuItem.Size = New System.Drawing.Size(61, 22)
        Me.FicheiroToolStripMenuItem.Text = "Ficheiro"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(802, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbl_status
        '
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(16, 17)
        Me.lbl_status.Text = "..."
        '
        'grid1
        '
        Me.grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Location = New System.Drawing.Point(0, 52)
        Me.grid1.Name = "grid1"
        Me.grid1.RowHeadersWidth = 82
        Me.grid1.Size = New System.Drawing.Size(496, 368)
        Me.grid1.TabIndex = 4
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(802, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(98, 22)
        Me.ToolStripButton1.Text = "Criar Produto"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripButton2.Text = "Eliminar"
        '
        'cmb_categorias
        '
        Me.cmb_categorias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_categorias.FormattingEnabled = True
        Me.cmb_categorias.Location = New System.Drawing.Point(507, 83)
        Me.cmb_categorias.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_categorias.Name = "cmb_categorias"
        Me.cmb_categorias.Size = New System.Drawing.Size(284, 21)
        Me.cmb_categorias.TabIndex = 0
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(129, 169)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 1
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(210, 169)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 0
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'grp_detalhes
        '
        Me.grp_detalhes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_detalhes.Controls.Add(Me.lbl_unsaved_Changes)
        Me.grp_detalhes.Controls.Add(Me.txt_cod_produto)
        Me.grp_detalhes.Controls.Add(Me.Label4)
        Me.grp_detalhes.Controls.Add(Me.Label3)
        Me.grp_detalhes.Controls.Add(Me.Label2)
        Me.grp_detalhes.Controls.Add(Me.Label1)
        Me.grp_detalhes.Controls.Add(Me.txt_qtd)
        Me.grp_detalhes.Controls.Add(Me.txt_designacao)
        Me.grp_detalhes.Controls.Add(Me.cmb_detalhes_categoria)
        Me.grp_detalhes.Controls.Add(Me.btn_cancelar)
        Me.grp_detalhes.Controls.Add(Me.btn_guardar)
        Me.grp_detalhes.Location = New System.Drawing.Point(507, 222)
        Me.grp_detalhes.Name = "grp_detalhes"
        Me.grp_detalhes.Size = New System.Drawing.Size(288, 198)
        Me.grp_detalhes.TabIndex = 6
        Me.grp_detalhes.TabStop = False
        Me.grp_detalhes.Text = "Detalhes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Cód. produto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Qtd. Stock"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Categoria"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Designação"
        '
        'txt_qtd
        '
        Me.txt_qtd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_qtd.Location = New System.Drawing.Point(80, 113)
        Me.txt_qtd.Name = "txt_qtd"
        Me.txt_qtd.Size = New System.Drawing.Size(70, 20)
        Me.txt_qtd.TabIndex = 9
        '
        'txt_designacao
        '
        Me.txt_designacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_designacao.Location = New System.Drawing.Point(80, 62)
        Me.txt_designacao.Name = "txt_designacao"
        Me.txt_designacao.Size = New System.Drawing.Size(202, 20)
        Me.txt_designacao.TabIndex = 8
        '
        'cmb_detalhes_categoria
        '
        Me.cmb_detalhes_categoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_detalhes_categoria.FormattingEnabled = True
        Me.cmb_detalhes_categoria.Location = New System.Drawing.Point(80, 87)
        Me.cmb_detalhes_categoria.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_detalhes_categoria.Name = "cmb_detalhes_categoria"
        Me.cmb_detalhes_categoria.Size = New System.Drawing.Size(202, 21)
        Me.cmb_detalhes_categoria.TabIndex = 7
        '
        'txt_cod_produto
        '
        Me.txt_cod_produto.Enabled = False
        Me.txt_cod_produto.Location = New System.Drawing.Point(80, 24)
        Me.txt_cod_produto.Name = "txt_cod_produto"
        Me.txt_cod_produto.Size = New System.Drawing.Size(70, 20)
        Me.txt_cod_produto.TabIndex = 14
        '
        'lbl_unsaved_Changes
        '
        Me.lbl_unsaved_Changes.AutoSize = True
        Me.lbl_unsaved_Changes.ForeColor = System.Drawing.Color.Red
        Me.lbl_unsaved_Changes.Location = New System.Drawing.Point(77, 142)
        Me.lbl_unsaved_Changes.Name = "lbl_unsaved_Changes"
        Me.lbl_unsaved_Changes.Size = New System.Drawing.Size(140, 13)
        Me.lbl_unsaved_Changes.TabIndex = 15
        Me.lbl_unsaved_Changes.Text = "Tem alterações por guardar."
        Me.lbl_unsaved_Changes.Visible = False
        '
        'GestorProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 450)
        Me.Controls.Add(Me.grp_detalhes)
        Me.Controls.Add(Me.cmb_categorias)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GestorProdutos"
        Me.Text = "Gestor de Produtos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grp_detalhes.ResumeLayout(False)
        Me.grp_detalhes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FicheiroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lbl_status As ToolStripStatusLabel
    Friend WithEvents grid1 As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents cmb_categorias As ComboBox
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents grp_detalhes As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_qtd As TextBox
    Friend WithEvents txt_designacao As TextBox
    Friend WithEvents cmb_detalhes_categoria As ComboBox
    Friend WithEvents txt_cod_produto As TextBox
    Friend WithEvents lbl_unsaved_Changes As Label
End Class
