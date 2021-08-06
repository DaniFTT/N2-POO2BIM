
namespace N2_POO2BIM.UserControls
{
    partial class MarcasUC
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
            this.btnCriarMarca = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDescricao = new MaterialSkin.Controls.MaterialTextBox();
            this.listViewMarcas = new MaterialSkin.Controls.MaterialListView();
            this.chCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExcluir = new MaterialSkin.Controls.MaterialButton();
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
            this.btnLimpar.Location = new System.Drawing.Point(123, 212);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 36);
            this.btnLimpar.TabIndex = 33;
            this.btnLimpar.Text = "   Limpar    ";
            this.btnLimpar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpar.UseAccentColor = false;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCriarMarca
            // 
            this.btnCriarMarca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCriarMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarMarca.Depth = 0;
            this.btnCriarMarca.DrawShadows = true;
            this.btnCriarMarca.HighEmphasis = true;
            this.btnCriarMarca.Icon = null;
            this.btnCriarMarca.Location = new System.Drawing.Point(296, 212);
            this.btnCriarMarca.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCriarMarca.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCriarMarca.Name = "btnCriarMarca";
            this.btnCriarMarca.Size = new System.Drawing.Size(118, 36);
            this.btnCriarMarca.TabIndex = 32;
            this.btnCriarMarca.Text = "Criar Marca";
            this.btnCriarMarca.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCriarMarca.UseAccentColor = false;
            this.btnCriarMarca.UseVisualStyleBackColor = true;
            this.btnCriarMarca.Click += new System.EventHandler(this.btnCriarMarca_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel4.Location = new System.Drawing.Point(42, 134);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(75, 19);
            this.materialLabel4.TabIndex = 29;
            this.materialLabel4.Text = "Descrição:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel2.Location = new System.Drawing.Point(62, 60);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(55, 19);
            this.materialLabel2.TabIndex = 26;
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
            this.txtCodigo.Size = new System.Drawing.Size(291, 50);
            this.txtCodigo.TabIndex = 25;
            this.txtCodigo.Text = "";
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
            this.txtDescricao.Size = new System.Drawing.Size(291, 50);
            this.txtDescricao.TabIndex = 36;
            this.txtDescricao.Text = "";
            // 
            // listViewMarcas
            // 
            this.listViewMarcas.AutoSizeTable = false;
            this.listViewMarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewMarcas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewMarcas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCodigo,
            this.chDescricao});
            this.listViewMarcas.Depth = 0;
            this.listViewMarcas.FullRowSelect = true;
            this.listViewMarcas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewMarcas.HideSelection = false;
            this.listViewMarcas.HoverSelection = true;
            this.listViewMarcas.Location = new System.Drawing.Point(476, 44);
            this.listViewMarcas.MinimumSize = new System.Drawing.Size(200, 100);
            this.listViewMarcas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewMarcas.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewMarcas.Name = "listViewMarcas";
            this.listViewMarcas.OwnerDraw = true;
            this.listViewMarcas.Size = new System.Drawing.Size(310, 335);
            this.listViewMarcas.TabIndex = 37;
            this.listViewMarcas.UseCompatibleStateImageBehavior = false;
            this.listViewMarcas.View = System.Windows.Forms.View.Details;
            // 
            // chCodigo
            // 
            this.chCodigo.Text = "Codigo";
            this.chCodigo.Width = 105;
            // 
            // chDescricao
            // 
            this.chDescricao.Text = "Descricao";
            this.chDescricao.Width = 205;
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Depth = 0;
            this.btnExcluir.DrawShadows = true;
            this.btnExcluir.HighEmphasis = true;
            this.btnExcluir.Icon = null;
            this.btnExcluir.Location = new System.Drawing.Point(706, 402);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(80, 36);
            this.btnExcluir.TabIndex = 38;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExcluir.UseAccentColor = true;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // MarcasUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.listViewMarcas);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCriarMarca);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtCodigo);
            this.DoubleBuffered = true;
            this.Name = "MarcasUC";
            this.Size = new System.Drawing.Size(846, 474);
            this.Load += new System.EventHandler(this.MarcasUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnLimpar;
        private MaterialSkin.Controls.MaterialButton btnCriarMarca;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtCodigo;
        private MaterialSkin.Controls.MaterialTextBox txtDescricao;
        private MaterialSkin.Controls.MaterialListView listViewMarcas;
        private System.Windows.Forms.ColumnHeader chDescricao;
        private MaterialSkin.Controls.MaterialButton btnExcluir;
        private System.Windows.Forms.ColumnHeader chCodigo;
    }
}
