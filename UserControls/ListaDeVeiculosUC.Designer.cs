
namespace N2_POO2BIM.UserControls
{
    partial class ListaDeVeiculosUC
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
            this.listViewVeiculos = new MaterialSkin.Controls.MaterialListView();
            this.chIdentificador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExcluir = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.txtDetalhes = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.SuspendLayout();
            // 
            // listViewVeiculos
            // 
            this.listViewVeiculos.AutoSizeTable = false;
            this.listViewVeiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewVeiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewVeiculos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chIdentificador,
            this.chTipo,
            this.chModelo,
            this.chMarca});
            this.listViewVeiculos.Depth = 0;
            this.listViewVeiculos.FullRowSelect = true;
            this.listViewVeiculos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewVeiculos.HideSelection = false;
            this.listViewVeiculos.HoverSelection = true;
            this.listViewVeiculos.Location = new System.Drawing.Point(30, 16);
            this.listViewVeiculos.MaximumSize = new System.Drawing.Size(800, 445);
            this.listViewVeiculos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listViewVeiculos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewVeiculos.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewVeiculos.MultiSelect = false;
            this.listViewVeiculos.Name = "listViewVeiculos";
            this.listViewVeiculos.OwnerDraw = true;
            this.listViewVeiculos.Size = new System.Drawing.Size(790, 242);
            this.listViewVeiculos.TabIndex = 1;
            this.listViewVeiculos.UseCompatibleStateImageBehavior = false;
            this.listViewVeiculos.View = System.Windows.Forms.View.Details;
            // 
            // chIdentificador
            // 
            this.chIdentificador.Text = "Identificador";
            this.chIdentificador.Width = 280;
            // 
            // chTipo
            // 
            this.chTipo.Text = "Tipo";
            this.chTipo.Width = 150;
            // 
            // chModelo
            // 
            this.chModelo.Text = "Modelo";
            this.chModelo.Width = 175;
            // 
            // chMarca
            // 
            this.chMarca.Text = "Marca";
            this.chMarca.Width = 185;
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Depth = 0;
            this.btnExcluir.DrawShadows = true;
            this.btnExcluir.HighEmphasis = true;
            this.btnExcluir.Icon = null;
            this.btnExcluir.Location = new System.Drawing.Point(740, 426);
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
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(461, 426);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(150, 36);
            this.materialButton1.TabIndex = 48;
            this.materialButton1.Text = "Mais Detalhes";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // txtDetalhes
            // 
            this.txtDetalhes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDetalhes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetalhes.Depth = 0;
            this.txtDetalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalhes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDetalhes.Hint = "";
            this.txtDetalhes.Location = new System.Drawing.Point(30, 278);
            this.txtDetalhes.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDetalhes.Name = "txtDetalhes";
            this.txtDetalhes.ReadOnly = true;
            this.txtDetalhes.Size = new System.Drawing.Size(424, 184);
            this.txtDetalhes.TabIndex = 49;
            this.txtDetalhes.Text = "";
            // 
            // ListaDeVeiculosUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txtDetalhes);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.listViewVeiculos);
            this.DoubleBuffered = true;
            this.Name = "ListaDeVeiculosUC";
            this.Size = new System.Drawing.Size(846, 474);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialListView listViewVeiculos;
        private System.Windows.Forms.ColumnHeader chIdentificador;
        private System.Windows.Forms.ColumnHeader chTipo;
        private System.Windows.Forms.ColumnHeader chModelo;
        private System.Windows.Forms.ColumnHeader chMarca;
        private MaterialSkin.Controls.MaterialButton btnExcluir;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtDetalhes;
    }
}
