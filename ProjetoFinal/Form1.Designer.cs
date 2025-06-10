namespace ProjetoFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtIdViagem = new TextBox();
            txtClienteId = new TextBox();
            txtMotoristaId = new TextBox();
            txtCavaloId = new TextBox();
            txtCarretaId = new TextBox();
            txtDescProdutos = new TextBox();
            txtValorFrete = new TextBox();
            txtKmTotal = new TextBox();
            buttonConsultar = new Button();
            txtClienteNome = new TextBox();
            txtMotoristaNome = new TextBox();
            txtCavaloNome = new TextBox();
            txtCarretaNome = new TextBox();
            buttonCadastrar = new Button();
            buttonExcluir = new Button();
            buttonEditar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 45);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Consultar viagens";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 89);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 133);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Motorista";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 177);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Cavalo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 221);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 4;
            label5.Text = "Carreta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(108, 265);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 5;
            label6.Text = "Produtos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(86, 309);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 6;
            label7.Text = "Valor do frete";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(80, 353);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 7;
            label8.Text = "Distância (km)";
            // 
            // txtIdViagem
            // 
            txtIdViagem.Location = new Point(187, 42);
            txtIdViagem.Name = "txtIdViagem";
            txtIdViagem.Size = new Size(48, 23);
            txtIdViagem.TabIndex = 8;
            // 
            // txtClienteId
            // 
            txtClienteId.Location = new Point(187, 86);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(82, 23);
            txtClienteId.TabIndex = 9;
            // 
            // txtMotoristaId
            // 
            txtMotoristaId.Location = new Point(187, 130);
            txtMotoristaId.Name = "txtMotoristaId";
            txtMotoristaId.Size = new Size(82, 23);
            txtMotoristaId.TabIndex = 10;
            // 
            // txtCavaloId
            // 
            txtCavaloId.Location = new Point(187, 174);
            txtCavaloId.Name = "txtCavaloId";
            txtCavaloId.Size = new Size(82, 23);
            txtCavaloId.TabIndex = 11;
            // 
            // txtCarretaId
            // 
            txtCarretaId.Location = new Point(187, 218);
            txtCarretaId.Name = "txtCarretaId";
            txtCarretaId.Size = new Size(82, 23);
            txtCarretaId.TabIndex = 12;
            // 
            // txtDescProdutos
            // 
            txtDescProdutos.Location = new Point(187, 262);
            txtDescProdutos.Name = "txtDescProdutos";
            txtDescProdutos.Size = new Size(221, 23);
            txtDescProdutos.TabIndex = 13;
            // 
            // txtValorFrete
            // 
            txtValorFrete.Location = new Point(187, 306);
            txtValorFrete.Name = "txtValorFrete";
            txtValorFrete.Size = new Size(221, 23);
            txtValorFrete.TabIndex = 14;
            // 
            // txtKmTotal
            // 
            txtKmTotal.Location = new Point(187, 350);
            txtKmTotal.Name = "txtKmTotal";
            txtKmTotal.Size = new Size(67, 23);
            txtKmTotal.TabIndex = 15;
            // 
            // buttonConsultar
            // 
            buttonConsultar.BackColor = Color.SkyBlue;
            buttonConsultar.FlatAppearance.BorderColor = Color.Red;
            buttonConsultar.FlatAppearance.BorderSize = 0;
            buttonConsultar.FlatStyle = FlatStyle.Flat;
            buttonConsultar.Location = new Point(241, 42);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(167, 23);
            buttonConsultar.TabIndex = 16;
            buttonConsultar.Text = "Consultar";
            buttonConsultar.UseVisualStyleBackColor = false;
            buttonConsultar.Click += buttonConsultar_Click;
            // 
            // txtClienteNome
            // 
            txtClienteNome.AcceptsReturn = true;
            txtClienteNome.Enabled = false;
            txtClienteNome.Location = new Point(275, 86);
            txtClienteNome.Name = "txtClienteNome";
            txtClienteNome.ReadOnly = true;
            txtClienteNome.Size = new Size(133, 23);
            txtClienteNome.TabIndex = 17;
            // 
            // txtMotoristaNome
            // 
            txtMotoristaNome.AcceptsReturn = true;
            txtMotoristaNome.Enabled = false;
            txtMotoristaNome.Location = new Point(275, 130);
            txtMotoristaNome.Name = "txtMotoristaNome";
            txtMotoristaNome.ReadOnly = true;
            txtMotoristaNome.Size = new Size(133, 23);
            txtMotoristaNome.TabIndex = 18;
            // 
            // txtCavaloNome
            // 
            txtCavaloNome.AcceptsReturn = true;
            txtCavaloNome.Enabled = false;
            txtCavaloNome.Location = new Point(275, 177);
            txtCavaloNome.Name = "txtCavaloNome";
            txtCavaloNome.ReadOnly = true;
            txtCavaloNome.Size = new Size(133, 23);
            txtCavaloNome.TabIndex = 19;
            // 
            // txtCarretaNome
            // 
            txtCarretaNome.AcceptsReturn = true;
            txtCarretaNome.Enabled = false;
            txtCarretaNome.Location = new Point(275, 218);
            txtCarretaNome.Name = "txtCarretaNome";
            txtCarretaNome.ReadOnly = true;
            txtCarretaNome.Size = new Size(133, 23);
            txtCarretaNome.TabIndex = 20;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.BackColor = Color.MediumSeaGreen;
            buttonCadastrar.BackgroundImageLayout = ImageLayout.None;
            buttonCadastrar.FlatAppearance.BorderSize = 0;
            buttonCadastrar.FlatStyle = FlatStyle.Flat;
            buttonCadastrar.Font = new Font("Segoe UI", 12F);
            buttonCadastrar.Location = new Point(3, 3);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(99, 31);
            buttonCadastrar.TabIndex = 21;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += button2_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = Color.LightCoral;
            buttonExcluir.BackgroundImageLayout = ImageLayout.None;
            buttonExcluir.FlatAppearance.BorderSize = 0;
            buttonExcluir.FlatStyle = FlatStyle.Flat;
            buttonExcluir.Font = new Font("Segoe UI", 12F);
            buttonExcluir.Location = new Point(213, 3);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(99, 31);
            buttonExcluir.TabIndex = 22;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = SystemColors.ActiveCaption;
            buttonEditar.BackgroundImageLayout = ImageLayout.None;
            buttonEditar.FlatAppearance.BorderSize = 0;
            buttonEditar.FlatStyle = FlatStyle.Flat;
            buttonEditar.Font = new Font("Segoe UI", 12F);
            buttonEditar.Location = new Point(108, 3);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(99, 31);
            buttonEditar.TabIndex = 24;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += button4_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonCadastrar);
            flowLayoutPanel1.Controls.Add(buttonEditar);
            flowLayoutPanel1.Controls.Add(buttonExcluir);
            flowLayoutPanel1.Location = new Point(80, 389);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(317, 39);
            flowLayoutPanel1.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.veiculo_na_estrada;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(470, 538);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtCarretaNome);
            Controls.Add(txtCavaloNome);
            Controls.Add(txtMotoristaNome);
            Controls.Add(txtClienteNome);
            Controls.Add(buttonConsultar);
            Controls.Add(txtKmTotal);
            Controls.Add(txtValorFrete);
            Controls.Add(txtDescProdutos);
            Controls.Add(txtCarretaId);
            Controls.Add(txtCavaloId);
            Controls.Add(txtMotoristaId);
            Controls.Add(txtClienteId);
            Controls.Add(txtIdViagem);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de viagens";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtIdViagem;
        private TextBox txtClienteId;
        private TextBox txtMotoristaId;
        private TextBox txtCavaloId;
        private TextBox txtCarretaId;
        private TextBox txtDescProdutos;
        private TextBox txtValorFrete;
        private TextBox txtKmTotal;
        private Button buttonConsultar;
        private TextBox txtClienteNome;
        private TextBox txtMotoristaNome;
        private TextBox txtCavaloNome;
        private TextBox txtCarretaNome;
        private Button buttonCadastrar;
        private Button buttonExcluir;
        private Button buttonEditar;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
