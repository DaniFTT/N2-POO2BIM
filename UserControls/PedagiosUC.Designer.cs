
namespace N2_POO2BIM.UserControls
{
    partial class PedagiosUC
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
            this.btnLimpar = new MaterialSkin.Controls.MaterialButton();
            this.btnCriarPedagio = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdentificacao = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLocalizacao = new MaterialSkin.Controls.MaterialTextBox();
            this.listViewPedagios = new MaterialSkin.Controls.MaterialListView();
            this.chIdentificador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLocalizacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValorRecebido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExcluir = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnLimpar.Location = new System.Drawing.Point(138, 182);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 36);
            this.btnLimpar.TabIndex = 34;
            this.btnLimpar.Text = "   Limpar    ";
            this.btnLimpar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpar.UseAccentColor = false;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCriarPedagio
            // 
            this.btnCriarPedagio.AutoSize = false;
            this.btnCriarPedagio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCriarPedagio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarPedagio.Depth = 0;
            this.btnCriarPedagio.DrawShadows = true;
            this.btnCriarPedagio.HighEmphasis = true;
            this.btnCriarPedagio.Icon = null;
            this.btnCriarPedagio.Location = new System.Drawing.Point(294, 182);
            this.btnCriarPedagio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCriarPedagio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCriarPedagio.Name = "btnCriarPedagio";
            this.btnCriarPedagio.Size = new System.Drawing.Size(128, 36);
            this.btnCriarPedagio.TabIndex = 33;
            this.btnCriarPedagio.Text = "Criar Pedágio";
            this.btnCriarPedagio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCriarPedagio.UseAccentColor = false;
            this.btnCriarPedagio.UseVisualStyleBackColor = true;
            this.btnCriarPedagio.Click += new System.EventHandler(this.btnCriarPedagio_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel4.Location = new System.Drawing.Point(41, 120);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(91, 19);
            this.materialLabel4.TabIndex = 29;
            this.materialLabel4.Text = "Localização:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel2.Location = new System.Drawing.Point(38, 50);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(94, 19);
            this.materialLabel2.TabIndex = 26;
            this.materialLabel2.Text = "Identificador:";
            // 
            // txtIdentificacao
            // 
            this.txtIdentificacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentificacao.Depth = 0;
            this.txtIdentificacao.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtIdentificacao.Location = new System.Drawing.Point(138, 35);
            this.txtIdentificacao.MaxLength = 50;
            this.txtIdentificacao.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdentificacao.Multiline = false;
            this.txtIdentificacao.Name = "txtIdentificacao";
            this.txtIdentificacao.Size = new System.Drawing.Size(284, 50);
            this.txtIdentificacao.TabIndex = 25;
            this.txtIdentificacao.Text = "";
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocalizacao.Depth = 0;
            this.txtLocalizacao.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtLocalizacao.Location = new System.Drawing.Point(138, 106);
            this.txtLocalizacao.MaxLength = 50;
            this.txtLocalizacao.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLocalizacao.Multiline = false;
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Size = new System.Drawing.Size(284, 50);
            this.txtLocalizacao.TabIndex = 36;
            this.txtLocalizacao.Text = "";
            // 
            // listViewPedagios
            // 
            this.listViewPedagios.AutoSizeTable = false;
            this.listViewPedagios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewPedagios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewPedagios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chIdentificador,
            this.chLocalizacao,
            this.chValorRecebido});
            this.listViewPedagios.Depth = 0;
            this.listViewPedagios.FullRowSelect = true;
            this.listViewPedagios.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewPedagios.HideSelection = false;
            this.listViewPedagios.HoverSelection = true;
            this.listViewPedagios.Location = new System.Drawing.Point(41, 241);
            this.listViewPedagios.MinimumSize = new System.Drawing.Size(200, 100);
            this.listViewPedagios.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewPedagios.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewPedagios.Name = "listViewPedagios";
            this.listViewPedagios.OwnerDraw = true;
            this.listViewPedagios.Size = new System.Drawing.Size(665, 203);
            this.listViewPedagios.TabIndex = 46;
            this.listViewPedagios.UseCompatibleStateImageBehavior = false;
            this.listViewPedagios.View = System.Windows.Forms.View.Details;
            // 
            // chIdentificador
            // 
            this.chIdentificador.Text = "Identificador";
            this.chIdentificador.Width = 275;
            // 
            // chLocalizacao
            // 
            this.chLocalizacao.Text = "Localização";
            this.chLocalizacao.Width = 235;
            // 
            // chValorRecebido
            // 
            this.chValorRecebido.Text = "Valores Recebidos";
            this.chValorRecebido.Width = 155;
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Depth = 0;
            this.btnExcluir.DrawShadows = true;
            this.btnExcluir.HighEmphasis = true;
            this.btnExcluir.Icon = null;
            this.btnExcluir.Location = new System.Drawing.Point(729, 408);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(80, 36);
            this.btnExcluir.TabIndex = 47;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExcluir.UseAccentColor = true;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblTotal);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(550, 35);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(226, 121);
            this.materialCard1.TabIndex = 50;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotal.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblTotal.Location = new System.Drawing.Point(28, 63);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(170, 41);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "R$ 1288,75";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(20, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(186, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Valor Total Recebido";
            // 
            // PedagiosUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.listViewPedagios);
            this.Controls.Add(this.txtLocalizacao);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCriarPedagio);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtIdentificacao);
            this.DoubleBuffered = true;
            this.Name = "PedagiosUC";
            this.Size = new System.Drawing.Size(846, 474);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnLimpar;
        private MaterialSkin.Controls.MaterialButton btnCriarPedagio;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtIdentificacao;
        private MaterialSkin.Controls.MaterialTextBox txtLocalizacao;
        private MaterialSkin.Controls.MaterialListView listViewPedagios;
        private System.Windows.Forms.ColumnHeader chIdentificador;
        private System.Windows.Forms.ColumnHeader chLocalizacao;
        private MaterialSkin.Controls.MaterialButton btnExcluir;
        private System.Windows.Forms.ColumnHeader chValorRecebido;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
