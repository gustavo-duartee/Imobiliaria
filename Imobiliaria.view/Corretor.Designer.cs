namespace Imobiliaria.view
{
    partial class Corretor
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
            this.n_TelefoneCorretor = new System.Windows.Forms.MaskedTextBox();
            this.n_CPFCorretor = new System.Windows.Forms.MaskedTextBox();
            this.dt_NascimentoCorretor = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelarCorretor = new System.Windows.Forms.Button();
            this.btnAlterarCorretor = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.btnRemoverCorretor = new System.Windows.Forms.Button();
            this.btnListarCorretor = new System.Windows.Forms.Button();
            this.btnSalvarCorretor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailCorretor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCorretor = new System.Windows.Forms.TextBox();
            this.Dgv_Corretor = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Corretor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "IMOBILIARIA - CORRETOR";
            // 
            // n_TelefoneCorretor
            // 
            this.n_TelefoneCorretor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n_TelefoneCorretor.Location = new System.Drawing.Point(226, 178);
            this.n_TelefoneCorretor.Mask = "(99) 00000-0000";
            this.n_TelefoneCorretor.Name = "n_TelefoneCorretor";
            this.n_TelefoneCorretor.Size = new System.Drawing.Size(200, 29);
            this.n_TelefoneCorretor.TabIndex = 17;
            // 
            // n_CPFCorretor
            // 
            this.n_CPFCorretor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n_CPFCorretor.Location = new System.Drawing.Point(226, 213);
            this.n_CPFCorretor.Mask = "000-000-000-00";
            this.n_CPFCorretor.Name = "n_CPFCorretor";
            this.n_CPFCorretor.Size = new System.Drawing.Size(200, 29);
            this.n_CPFCorretor.TabIndex = 18;
            // 
            // dt_NascimentoCorretor
            // 
            this.dt_NascimentoCorretor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_NascimentoCorretor.Location = new System.Drawing.Point(226, 248);
            this.dt_NascimentoCorretor.Mask = "00/00/0000";
            this.dt_NascimentoCorretor.Name = "dt_NascimentoCorretor";
            this.dt_NascimentoCorretor.Size = new System.Drawing.Size(200, 29);
            this.dt_NascimentoCorretor.TabIndex = 20;
            this.dt_NascimentoCorretor.ValidatingType = typeof(System.DateTime);
            // 
            // btnCancelarCorretor
            // 
            this.btnCancelarCorretor.Location = new System.Drawing.Point(515, 333);
            this.btnCancelarCorretor.Name = "btnCancelarCorretor";
            this.btnCancelarCorretor.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCorretor.TabIndex = 27;
            this.btnCancelarCorretor.Text = "Cancelar";
            this.btnCancelarCorretor.UseVisualStyleBackColor = true;
            this.btnCancelarCorretor.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterarCorretor
            // 
            this.btnAlterarCorretor.Location = new System.Drawing.Point(434, 333);
            this.btnAlterarCorretor.Name = "btnAlterarCorretor";
            this.btnAlterarCorretor.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCorretor.TabIndex = 25;
            this.btnAlterarCorretor.Text = "Alterar";
            this.btnAlterarCorretor.UseVisualStyleBackColor = true;
            this.btnAlterarCorretor.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblid.Location = new System.Drawing.Point(226, 81);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 24);
            this.lblid.TabIndex = 31;
            this.lblid.Visible = false;
            // 
            // btnRemoverCorretor
            // 
            this.btnRemoverCorretor.Location = new System.Drawing.Point(353, 333);
            this.btnRemoverCorretor.Name = "btnRemoverCorretor";
            this.btnRemoverCorretor.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverCorretor.TabIndex = 23;
            this.btnRemoverCorretor.Text = "Remover";
            this.btnRemoverCorretor.UseVisualStyleBackColor = true;
            this.btnRemoverCorretor.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnListarCorretor
            // 
            this.btnListarCorretor.Location = new System.Drawing.Point(272, 333);
            this.btnListarCorretor.Name = "btnListarCorretor";
            this.btnListarCorretor.Size = new System.Drawing.Size(75, 23);
            this.btnListarCorretor.TabIndex = 22;
            this.btnListarCorretor.Text = "Listar";
            this.btnListarCorretor.UseVisualStyleBackColor = true;
            this.btnListarCorretor.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnSalvarCorretor
            // 
            this.btnSalvarCorretor.Location = new System.Drawing.Point(191, 333);
            this.btnSalvarCorretor.Name = "btnSalvarCorretor";
            this.btnSalvarCorretor.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarCorretor.TabIndex = 21;
            this.btnSalvarCorretor.Text = "Salvar";
            this.btnSalvarCorretor.UseVisualStyleBackColor = true;
            this.btnSalvarCorretor.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(41, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Data de Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(173, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(135, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(163, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Email";
            // 
            // txtEmailCorretor
            // 
            this.txtEmailCorretor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmailCorretor.Location = new System.Drawing.Point(226, 143);
            this.txtEmailCorretor.MaxLength = 50;
            this.txtEmailCorretor.Name = "txtEmailCorretor";
            this.txtEmailCorretor.Size = new System.Drawing.Size(400, 29);
            this.txtEmailCorretor.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(158, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome";
            // 
            // txtNomeCorretor
            // 
            this.txtNomeCorretor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomeCorretor.Location = new System.Drawing.Point(226, 108);
            this.txtNomeCorretor.MaxLength = 50;
            this.txtNomeCorretor.Name = "txtNomeCorretor";
            this.txtNomeCorretor.Size = new System.Drawing.Size(400, 29);
            this.txtNomeCorretor.TabIndex = 15;
            // 
            // Dgv_Corretor
            // 
            this.Dgv_Corretor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Corretor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.Dgv_Corretor.Location = new System.Drawing.Point(-1, 361);
            this.Dgv_Corretor.MultiSelect = false;
            this.Dgv_Corretor.Name = "Dgv_Corretor";
            this.Dgv_Corretor.RowTemplate.ReadOnly = true;
            this.Dgv_Corretor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Corretor.Size = new System.Drawing.Size(886, 266);
            this.Dgv_Corretor.TabIndex = 29;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "cdCorretor";
            this.Column2.HeaderText = "Código";
            this.Column2.Name = "Column2";
            this.Column2.Width = 102;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NmCorretor";
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            this.Column1.Width = 180;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "email";
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Telefone";
            this.Column4.HeaderText = "Telefone";
            this.Column4.Name = "Column4";
            this.Column4.Width = 115;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Cpf";
            this.Column5.HeaderText = "CPF";
            this.Column5.Name = "Column5";
            this.Column5.Width = 115;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DataNascimento";
            this.Column6.HeaderText = "Data de Nascimento";
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Corretor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(884, 626);
            this.Controls.Add(this.n_TelefoneCorretor);
            this.Controls.Add(this.n_CPFCorretor);
            this.Controls.Add(this.dt_NascimentoCorretor);
            this.Controls.Add(this.btnCancelarCorretor);
            this.Controls.Add(this.btnAlterarCorretor);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnRemoverCorretor);
            this.Controls.Add(this.btnListarCorretor);
            this.Controls.Add(this.btnSalvarCorretor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmailCorretor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeCorretor);
            this.Controls.Add(this.Dgv_Corretor);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Corretor";
            this.Text = "IMOBILIARIA - CORRETOR";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Corretor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MaskedTextBox n_TelefoneCorretor;
        private MaskedTextBox n_CPFCorretor;
        private MaskedTextBox dt_NascimentoCorretor;
        private Button btnCancelarCorretor;
        private Button btnAlterarCorretor;
        private Label lblid;
        private Button btnRemoverCorretor;
        private Button btnListarCorretor;
        private Button btnSalvarCorretor;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtEmailCorretor;
        private Label label2;
        private TextBox txtNomeCorretor;
        private DataGridView Dgv_Corretor;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}