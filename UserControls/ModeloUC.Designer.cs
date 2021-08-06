
namespace N2_POO2BIM.UserControls
{
    partial class ModeloUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExcluir = new MaterialSkin.Controls.MaterialButton();
            this.listViewModelos = new MaterialSkin.Controls.MaterialListView();
            this.chCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDescricao = new MaterialSkin.Controls.MaterialTextBox();
            this.btnLimpar = new MaterialSkin.Controls.MaterialButton();
            this.btnCriarModelo = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cbMarca = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Depth = 0;
            this.btnExcluir.DrawShadows = true;
            this.btnExcluir.HighEmphasis = true;
            this.btnExcluir.Icon = null;
            this.btnExcluir.Location = new System.Drawing.Point(746, 410);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(80, 36);
            this.btnExcluir.TabIndex = 46;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExcluir.UseAccentColor = true;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // listViewModelos
            // 
            this.listViewModelos.AutoSizeTable = false;
            this.listViewModelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewModelos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewModelos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCodigo,
            this.chDescricao,
            this.chMarca});
            this.listViewModelos.Depth = 0;
            this.listViewModelos.FullRowSelect = true;
            this.listViewModelos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewModelos.HideSelection = false;
            this.listViewModelos.HoverSelection = true;
            this.listViewModelos.Location = new System.Drawing.Point(476, 44);
            this.listViewModelos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listViewModelos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewModelos.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewModelos.Name = "listViewModelos";
            this.listViewModelos.OwnerDraw = true;
            this.listViewModelos.Size = new System.Drawing.Size(350, 357);
            this.listViewModelos.TabIndex = 45;
            this.listViewModelos.UseCompatibleStateImageBehavior = false;
            this.listViewModelos.View = System.Windows.Forms.View.Details;
            // 
            // chCodigo
            // 
            this.chCodigo.Text = "Codigo";
            this.chCodigo.Width = 80;
            // 
            // chDescricao
            // 
            this.chDescricao.Text = "Descrição";
            this.chDescricao.Width = 135;
            // 
            // chMarca
            // 
            this.chMarca.Text = "Marca";
            this.chMarca.Width = 135;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Depth = 0;
            this.txtDescricao.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtDescricao.Location = new System.Drawing.Point(123, 119);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescricao.Multiline = false;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(299, 50);
            this.txtDescricao.TabIndex = 44;
            this.txtDescricao.Text = "";
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Depth = 0;
            this.btnLimpar.DrawShadows = true;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLimpar.FlatAppearance.BorderSize = 2;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpar.HighEmphasis = true;
            this.btnLimpar.Icon = null;
            this.btnLimpar.Location = new System.Drawing.Point(123, 290);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 36);
            this.btnLimpar.TabIndex = 43;
            this.btnLimpar.Text = "   Limpar    ";
            this.btnLimpar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpar.UseAccentColor = false;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCriarModelo
            // 
            this.btnCriarModelo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCriarModelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarModelo.Depth = 0;
            this.btnCriarModelo.DrawShadows = true;
            this.btnCriarModelo.HighEmphasis = true;
            this.btnCriarModelo.Icon = null;
            this.btnCriarModelo.Location = new System.Drawing.Point(296, 290);
            this.btnCriarModelo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCriarModelo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCriarModelo.Name = "btnCriarModelo";
            this.btnCriarModelo.Size = new System.Drawing.Size(126, 36);
            this.btnCriarModelo.TabIndex = 42;
            this.btnCriarModelo.Text = "Criar modelo";
            this.btnCriarModelo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCriarModelo.UseAccentColor = false;
            this.btnCriarModelo.UseVisualStyleBackColor = true;
            this.btnCriarModelo.Click += new System.EventHandler(this.btnCriarModelo_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel4.Location = new System.Drawing.Point(42, 135);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(75, 19);
            this.materialLabel4.TabIndex = 41;
            this.materialLabel4.Text = "Descrição:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel2.Location = new System.Drawing.Point(62, 59);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(55, 19);
            this.materialLabel2.TabIndex = 40;
            this.materialLabel2.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtCodigo.Location = new System.Drawing.Point(123, 44);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(299, 50);
            this.txtCodigo.TabIndex = 39;
            this.txtCodigo.Text = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel1.Location = new System.Drawing.Point(67, 215);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 48;
            this.materialLabel1.Text = "Marca:";
            // 
            // cbMarca
            // 
            this.cbMarca.AutoResize = false;
            this.cbMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMarca.Depth = 0;
            this.cbMarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbMarca.DropDownHeight = 174;
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.DropDownWidth = 121;
            this.cbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.IntegralHeight = false;
            this.cbMarca.ItemHeight = 43;
            this.cbMarca.Location = new System.Drawing.Point(123, 202);
            this.cbMarca.MaxDropDownItems = 4;
            this.cbMarca.MouseState = MaterialSkin.MouseState.OUT;
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(299, 49);
            this.cbMarca.StartIndex = 0;
            this.cbMarca.TabIndex = 47;
            // 
            // ModeloUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.listViewModelos);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCriarModelo);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtCodigo);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(41, 48);
            this.Name = "ModeloUC";
            this.Size = new System.Drawing.Size(846, 474);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnExcluir;
        private MaterialSkin.Controls.MaterialListView listViewModelos;
        private System.Windows.Forms.ColumnHeader chCodigo;
        private MaterialSkin.Controls.MaterialTextBox txtDescricao;
        private MaterialSkin.Controls.MaterialButton btnLimpar;
        private MaterialSkin.Controls.MaterialButton btnCriarModelo;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtCodigo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ColumnHeader chDescricao;
        private System.Windows.Forms.ColumnHeader chMarca;
        public MaterialSkin.Controls.MaterialComboBox cbMarca;
    }
}
