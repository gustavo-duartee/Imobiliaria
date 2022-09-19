namespace Imobiliaria.view
{
    partial class Imovel
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndereço = new System.Windows.Forms.TextBox();
            this.Dgv_Imoveis = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_CEP = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbQuartos = new System.Windows.Forms.ComboBox();
            this.cmbBanheiros = new System.Windows.Forms.ComboBox();
            this.cmbGaragem = new System.Windows.Forms.ComboBox();
            this.cmbLavanderia = new System.Windows.Forms.ComboBox();
            this.cmbAndares = new System.Windows.Forms.ComboBox();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Imoveis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "IMOBILIARIA - IMÓVEL";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Aluguel",
            "Venda"});
            this.cmbTipo.Location = new System.Drawing.Point(377, 260);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(150, 29);
            this.cmbTipo.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(753, 240);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(591, 255);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblid.Location = new System.Drawing.Point(112, 92);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 24);
            this.lblid.TabIndex = 31;
            this.lblid.Visible = false;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(672, 255);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 15;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(672, 226);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 13;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(591, 226);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(25, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(602, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "CEP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(320, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(591, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBairro.Location = new System.Drawing.Point(651, 100);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(200, 29);
            this.txtBairro.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Endereço";
            // 
            // txtEndereço
            // 
            this.txtEndereço.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEndereço.Location = new System.Drawing.Point(100, 99);
            this.txtEndereço.MaxLength = 50;
            this.txtEndereço.Name = "txtEndereço";
            this.txtEndereço.Size = new System.Drawing.Size(427, 29);
            this.txtEndereço.TabIndex = 0;
            // 
            // Dgv_Imoveis
            // 
            this.Dgv_Imoveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Imoveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.Dgv_Imoveis.Location = new System.Drawing.Point(0, 295);
            this.Dgv_Imoveis.MultiSelect = false;
            this.Dgv_Imoveis.Name = "Dgv_Imoveis";
            this.Dgv_Imoveis.RowTemplate.ReadOnly = true;
            this.Dgv_Imoveis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Imoveis.Size = new System.Drawing.Size(886, 331);
            this.Dgv_Imoveis.TabIndex = 29;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CdImovel";
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // n_CEP
            // 
            this.n_CEP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n_CEP.Location = new System.Drawing.Point(651, 140);
            this.n_CEP.Mask = "00000-000";
            this.n_CEP.Name = "n_CEP";
            this.n_CEP.Size = new System.Drawing.Size(200, 29);
            this.n_CEP.TabIndex = 9;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCidade.Location = new System.Drawing.Point(100, 139);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(427, 29);
            this.txtCidade.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(19, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "Quartos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(0, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "Banheiros";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(7, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 24);
            this.label9.TabIndex = 35;
            this.label9.Text = "Garagem";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(548, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 24);
            this.label11.TabIndex = 37;
            this.label11.Text = "Lavanderia";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(260, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 24);
            this.label12.TabIndex = 38;
            this.label12.Text = "Tamanho M²";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(290, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 24);
            this.label13.TabIndex = 39;
            this.label13.Text = "Andares";
            // 
            // cmbQuartos
            // 
            this.cmbQuartos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuartos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbQuartos.FormattingEnabled = true;
            this.cmbQuartos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbQuartos.Location = new System.Drawing.Point(100, 180);
            this.cmbQuartos.Name = "cmbQuartos";
            this.cmbQuartos.Size = new System.Drawing.Size(150, 29);
            this.cmbQuartos.TabIndex = 2;
            // 
            // cmbBanheiros
            // 
            this.cmbBanheiros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBanheiros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBanheiros.FormattingEnabled = true;
            this.cmbBanheiros.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbBanheiros.Location = new System.Drawing.Point(100, 220);
            this.cmbBanheiros.Name = "cmbBanheiros";
            this.cmbBanheiros.Size = new System.Drawing.Size(150, 29);
            this.cmbBanheiros.TabIndex = 3;
            // 
            // cmbGaragem
            // 
            this.cmbGaragem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGaragem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbGaragem.FormattingEnabled = true;
            this.cmbGaragem.Items.AddRange(new object[] {
            "1 Carro",
            "2 Carros",
            "3 Carros",
            "4 Carros",
            "5 Carros",
            "6 Carros"});
            this.cmbGaragem.Location = new System.Drawing.Point(100, 260);
            this.cmbGaragem.Name = "cmbGaragem";
            this.cmbGaragem.Size = new System.Drawing.Size(150, 29);
            this.cmbGaragem.TabIndex = 4;
            // 
            // cmbLavanderia
            // 
            this.cmbLavanderia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLavanderia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbLavanderia.FormattingEnabled = true;
            this.cmbLavanderia.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cmbLavanderia.Location = new System.Drawing.Point(651, 181);
            this.cmbLavanderia.Name = "cmbLavanderia";
            this.cmbLavanderia.Size = new System.Drawing.Size(200, 29);
            this.cmbLavanderia.TabIndex = 10;
            // 
            // cmbAndares
            // 
            this.cmbAndares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAndares.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbAndares.FormattingEnabled = true;
            this.cmbAndares.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbAndares.Location = new System.Drawing.Point(377, 180);
            this.cmbAndares.Name = "cmbAndares";
            this.cmbAndares.Size = new System.Drawing.Size(150, 29);
            this.cmbAndares.TabIndex = 5;
            // 
            // txtTamanho
            // 
            this.txtTamanho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTamanho.Location = new System.Drawing.Point(377, 220);
            this.txtTamanho.MaxLength = 50;
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(150, 29);
            this.txtTamanho.TabIndex = 6;
            // 
            // Imovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(884, 626);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.cmbAndares);
            this.Controls.Add(this.cmbLavanderia);
            this.Controls.Add(this.cmbGaragem);
            this.Controls.Add(this.cmbBanheiros);
            this.Controls.Add(this.cmbQuartos);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.n_CEP);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEndereço);
            this.Controls.Add(this.Dgv_Imoveis);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label1);
            this.Name = "Imovel";
            this.Text = "IMOBILIARIA - IMOVEL";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Imoveis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cmbTipo;
        private Button btnCancelar;
        private Button btnAlterar;
        private Label lblid;
        private Button btnRemover;
        private Button btnListar;
        private Button btnSalvar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtBairro;
        private Label label2;
        private TextBox txtEndereço;
        private DataGridView Dgv_Imoveis;
        private MaskedTextBox n_CEP;
        private TextBox txtCidade;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label13;
        private ComboBox cmbQuartos;
        private ComboBox cmbBanheiros;
        private ComboBox cmbGaragem;
        private ComboBox cmbLavanderia;
        private ComboBox cmbAndares;
        private TextBox txtTamanho;
        private DataGridViewTextBoxColumn Column1;
    }
}