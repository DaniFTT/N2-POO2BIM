
namespace N2_POO2BIM.UserControls
{
    partial class CadastrarVeiculoUC
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
            this.txtMarca = new MaterialSkin.Controls.MaterialTextBox();
            this.btnGerarDeCadaTipo = new MaterialSkin.Controls.MaterialButton();
            this.btnLimpar = new MaterialSkin.Controls.MaterialButton();
            this.btnCriarVeiculo = new MaterialSkin.Controls.MaterialButton();
            this.txtQteVagoes = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.cbOnibusLeito = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCargaSuportada = new MaterialSkin.Controls.MaterialTextBox();
            this.txtQteEixos = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtQtePortas = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtQtePassageiros = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.cbTipo = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cbModelo = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdentificador = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarca.Depth = 0;
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMarca.Location = new System.Drawing.Point(114, 241);
            this.txtMarca.MaxLength = 50;
            this.txtMarca.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMarca.Multiline = false;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(275, 50);
            this.txtMarca.TabIndex = 71;
            this.txtMarca.Text = "";
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // btnGerarDeCadaTipo
            // 
            this.btnGerarDeCadaTipo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGerarDeCadaTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarDeCadaTipo.Depth = 0;
            this.btnGerarDeCadaTipo.DrawShadows = true;
            this.btnGerarDeCadaTipo.HighEmphasis = true;
            this.btnGerarDeCadaTipo.Icon = null;
            this.btnGerarDeCadaTipo.Location = new System.Drawing.Point(121, 389);
            this.btnGerarDeCadaTipo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGerarDeCadaTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGerarDeCadaTipo.Name = "btnGerarDeCadaTipo";
            this.btnGerarDeCadaTipo.Size = new System.Drawing.Size(260, 36);
            this.btnGerarDeCadaTipo.TabIndex = 70;
            this.btnGerarDeCadaTipo.Text = "  Criar um veiculo de cada tipo  ";
            this.btnGerarDeCadaTipo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGerarDeCadaTipo.UseAccentColor = false;
            this.btnGerarDeCadaTipo.UseVisualStyleBackColor = true;
            this.btnGerarDeCadaTipo.Click += new System.EventHandler(this.btnGerarDeCadaTipo_Click);
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
            this.btnLimpar.Location = new System.Drawing.Point(121, 321);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 36);
            this.btnLimpar.TabIndex = 69;
            this.btnLimpar.Text = "   Limpar    ";
            this.btnLimpar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpar.UseAccentColor = false;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCriarVeiculo
            // 
            this.btnCriarVeiculo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCriarVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarVeiculo.Depth = 0;
            this.btnCriarVeiculo.DrawShadows = true;
            this.btnCriarVeiculo.HighEmphasis = true;
            this.btnCriarVeiculo.Icon = null;
            this.btnCriarVeiculo.Location = new System.Drawing.Point(255, 321);
            this.btnCriarVeiculo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCriarVeiculo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCriarVeiculo.Name = "btnCriarVeiculo";
            this.btnCriarVeiculo.Size = new System.Drawing.Size(126, 36);
            this.btnCriarVeiculo.TabIndex = 68;
            this.btnCriarVeiculo.Text = "Criar Veiculo";
            this.btnCriarVeiculo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCriarVeiculo.UseAccentColor = false;
            this.btnCriarVeiculo.UseVisualStyleBackColor = true;
            this.btnCriarVeiculo.Click += new System.EventHandler(this.btnCriarVeiculo_Click);
            // 
            // txtQteVagoes
            // 
            this.txtQteVagoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQteVagoes.Depth = 0;
            this.txtQteVagoes.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtQteVagoes.Location = new System.Drawing.Point(658, 307);
            this.txtQteVagoes.MaxLength = 50;
            this.txtQteVagoes.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQteVagoes.Multiline = false;
            this.txtQteVagoes.Name = "txtQteVagoes";
            this.txtQteVagoes.Size = new System.Drawing.Size(136, 50);
            this.txtQteVagoes.TabIndex = 67;
            this.txtQteVagoes.Text = "";
            this.txtQteVagoes.TextChanged += new System.EventHandler(this.txtQteVagoes_TextChanged);
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel11.Location = new System.Drawing.Point(483, 321);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(165, 19);
            this.materialLabel11.TabIndex = 66;
            this.materialLabel11.Text = "Quantidade de Vagões:";
            this.materialLabel11.Click += new System.EventHandler(this.materialLabel11_Click);
            // 
            // cbOnibusLeito
            // 
            this.cbOnibusLeito.AutoResize = false;
            this.cbOnibusLeito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbOnibusLeito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbOnibusLeito.Depth = 0;
            this.cbOnibusLeito.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbOnibusLeito.DropDownHeight = 174;
            this.cbOnibusLeito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOnibusLeito.DropDownWidth = 121;
            this.cbOnibusLeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbOnibusLeito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbOnibusLeito.FormattingEnabled = true;
            this.cbOnibusLeito.IntegralHeight = false;
            this.cbOnibusLeito.ItemHeight = 43;
            this.cbOnibusLeito.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbOnibusLeito.Location = new System.Drawing.Point(658, 376);
            this.cbOnibusLeito.MaxDropDownItems = 4;
            this.cbOnibusLeito.MouseState = MaterialSkin.MouseState.OUT;
            this.cbOnibusLeito.Name = "cbOnibusLeito";
            this.cbOnibusLeito.Size = new System.Drawing.Size(136, 49);
            this.cbOnibusLeito.StartIndex = 0;
            this.cbOnibusLeito.TabIndex = 65;
            this.cbOnibusLeito.SelectedIndexChanged += new System.EventHandler(this.cbOnibusLeito_SelectedIndexChanged);
            // 
            // txtCargaSuportada
            // 
            this.txtCargaSuportada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCargaSuportada.Depth = 0;
            this.txtCargaSuportada.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtCargaSuportada.Location = new System.Drawing.Point(658, 241);
            this.txtCargaSuportada.MaxLength = 50;
            this.txtCargaSuportada.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCargaSuportada.Multiline = false;
            this.txtCargaSuportada.Name = "txtCargaSuportada";
            this.txtCargaSuportada.Size = new System.Drawing.Size(136, 50);
            this.txtCargaSuportada.TabIndex = 64;
            this.txtCargaSuportada.Text = "";
            this.txtCargaSuportada.TextChanged += new System.EventHandler(this.txtCargaSuportada_TextChanged);
            // 
            // txtQteEixos
            // 
            this.txtQteEixos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQteEixos.Depth = 0;
            this.txtQteEixos.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtQteEixos.Location = new System.Drawing.Point(658, 172);
            this.txtQteEixos.MaxLength = 50;
            this.txtQteEixos.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQteEixos.Multiline = false;
            this.txtQteEixos.Name = "txtQteEixos";
            this.txtQteEixos.Size = new System.Drawing.Size(136, 50);
            this.txtQteEixos.TabIndex = 63;
            this.txtQteEixos.Text = "";
            this.txtQteEixos.TextChanged += new System.EventHandler(this.txtQteEixos_TextChanged);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel10.Location = new System.Drawing.Point(498, 189);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(150, 19);
            this.materialLabel10.TabIndex = 62;
            this.materialLabel10.Text = "Quantidade de Eixos:";
            this.materialLabel10.Click += new System.EventHandler(this.materialLabel10_Click);
            // 
            // txtQtePortas
            // 
            this.txtQtePortas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQtePortas.Depth = 0;
            this.txtQtePortas.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtQtePortas.Location = new System.Drawing.Point(658, 104);
            this.txtQtePortas.MaxLength = 50;
            this.txtQtePortas.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQtePortas.Multiline = false;
            this.txtQtePortas.Name = "txtQtePortas";
            this.txtQtePortas.Size = new System.Drawing.Size(136, 50);
            this.txtQtePortas.TabIndex = 61;
            this.txtQtePortas.Text = "";
            this.txtQtePortas.TextChanged += new System.EventHandler(this.txtQtePortas_TextChanged);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel9.Location = new System.Drawing.Point(554, 391);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(94, 19);
            this.materialLabel9.TabIndex = 60;
            this.materialLabel9.Text = "Ônibus Leito:";
            this.materialLabel9.Click += new System.EventHandler(this.materialLabel9_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel8.Location = new System.Drawing.Point(521, 257);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(125, 19);
            this.materialLabel8.TabIndex = 59;
            this.materialLabel8.Text = "Carga Suportada:";
            this.materialLabel8.Click += new System.EventHandler(this.materialLabel8_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel7.Location = new System.Drawing.Point(490, 121);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(158, 19);
            this.materialLabel7.TabIndex = 58;
            this.materialLabel7.Text = "Quantidade de Portas:";
            this.materialLabel7.Click += new System.EventHandler(this.materialLabel7_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel6.Location = new System.Drawing.Point(447, 55);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(201, 19);
            this.materialLabel6.TabIndex = 57;
            this.materialLabel6.Text = "Capacidade de Passageiros:";
            this.materialLabel6.Click += new System.EventHandler(this.materialLabel6_Click);
            // 
            // txtQtePassageiros
            // 
            this.txtQtePassageiros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQtePassageiros.Depth = 0;
            this.txtQtePassageiros.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtQtePassageiros.Location = new System.Drawing.Point(658, 39);
            this.txtQtePassageiros.MaxLength = 50;
            this.txtQtePassageiros.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQtePassageiros.Multiline = false;
            this.txtQtePassageiros.Name = "txtQtePassageiros";
            this.txtQtePassageiros.Size = new System.Drawing.Size(136, 50);
            this.txtQtePassageiros.TabIndex = 56;
            this.txtQtePassageiros.Text = "";
            this.txtQtePassageiros.TextChanged += new System.EventHandler(this.txtQtePassageiros_TextChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel5.Location = new System.Drawing.Point(71, 120);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(37, 19);
            this.materialLabel5.TabIndex = 55;
            this.materialLabel5.Text = "Tipo:";
            this.materialLabel5.Click += new System.EventHandler(this.materialLabel5_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.AutoResize = false;
            this.cbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTipo.Depth = 0;
            this.cbTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTipo.DropDownHeight = 174;
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.DropDownWidth = 121;
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.IntegralHeight = false;
            this.cbTipo.ItemHeight = 43;
            this.cbTipo.Items.AddRange(new object[] {
            "Carro",
            "Moto",
            "Caminhão",
            "Ônibus",
            "Avião",
            "Avião de Guerra",
            "Navio",
            "Navio de Guerra",
            "Trem"});
            this.cbTipo.Location = new System.Drawing.Point(114, 104);
            this.cbTipo.MaxDropDownItems = 4;
            this.cbTipo.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(275, 49);
            this.cbTipo.StartIndex = 0;
            this.cbTipo.TabIndex = 54;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel4.Location = new System.Drawing.Point(46, 188);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(62, 19);
            this.materialLabel4.TabIndex = 53;
            this.materialLabel4.Text = "Modelo: ";
            this.materialLabel4.Click += new System.EventHandler(this.materialLabel4_Click);
            // 
            // cbModelo
            // 
            this.cbModelo.AutoResize = false;
            this.cbModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbModelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbModelo.Depth = 0;
            this.cbModelo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbModelo.DropDownHeight = 174;
            this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelo.DropDownWidth = 121;
            this.cbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.IntegralHeight = false;
            this.cbModelo.ItemHeight = 43;
            this.cbModelo.Location = new System.Drawing.Point(114, 172);
            this.cbModelo.MaxDropDownItems = 4;
            this.cbModelo.MouseState = MaterialSkin.MouseState.OUT;
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(275, 49);
            this.cbModelo.StartIndex = 0;
            this.cbModelo.TabIndex = 52;
            this.cbModelo.SelectedIndexChanged += new System.EventHandler(this.cbModelo_SelectedIndexChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel3.Location = new System.Drawing.Point(58, 256);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(50, 19);
            this.materialLabel3.TabIndex = 51;
            this.materialLabel3.Text = "Marca:";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel2.Location = new System.Drawing.Point(14, 54);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(94, 19);
            this.materialLabel2.TabIndex = 50;
            this.materialLabel2.Text = "Identificador:";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentificador.Depth = 0;
            this.txtIdentificador.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtIdentificador.Location = new System.Drawing.Point(114, 39);
            this.txtIdentificador.MaxLength = 50;
            this.txtIdentificador.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdentificador.Multiline = false;
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(275, 50);
            this.txtIdentificador.TabIndex = 49;
            this.txtIdentificador.Text = "";
            this.txtIdentificador.TextChanged += new System.EventHandler(this.txtIdentificador_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.SystemColors.Window;
            this.materialLabel1.Location = new System.Drawing.Point(800, 257);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(22, 19);
            this.materialLabel1.TabIndex = 72;
            this.materialLabel1.Text = "KG";
            // 
            // CadastrarVeiculoUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.btnGerarDeCadaTipo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCriarVeiculo);
            this.Controls.Add(this.txtQteVagoes);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.cbOnibusLeito);
            this.Controls.Add(this.txtCargaSuportada);
            this.Controls.Add(this.txtQteEixos);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.txtQtePortas);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.txtQtePassageiros);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtIdentificador);
            this.Name = "CadastrarVeiculoUC";
            this.Size = new System.Drawing.Size(846, 474);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtMarca;
        private MaterialSkin.Controls.MaterialButton btnGerarDeCadaTipo;
        private MaterialSkin.Controls.MaterialButton btnLimpar;
        private MaterialSkin.Controls.MaterialButton btnCriarVeiculo;
        private MaterialSkin.Controls.MaterialTextBox txtQteVagoes;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialComboBox cbOnibusLeito;
        private MaterialSkin.Controls.MaterialTextBox txtCargaSuportada;
        private MaterialSkin.Controls.MaterialTextBox txtQteEixos;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialTextBox txtQtePortas;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox txtQtePassageiros;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialComboBox cbTipo;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        public MaterialSkin.Controls.MaterialComboBox cbModelo;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtIdentificador;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
