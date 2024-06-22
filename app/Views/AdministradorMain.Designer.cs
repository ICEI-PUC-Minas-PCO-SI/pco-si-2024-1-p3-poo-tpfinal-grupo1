namespace app.Views
{
    partial class AdministradorMain
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
            tabControl1 = new TabControl();
            Clientes = new TabPage();
            button4 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            CadastrarCliente = new TabPage();
            groupBox5 = new GroupBox();
            textBox2 = new TextBox();
            cadastrarPessoaBtn = new Button();
            label2 = new Label();
            nomeRzSocialGB = new GroupBox();
            nomeRzSocialTxBox = new TextBox();
            groupBox4 = new GroupBox();
            label1 = new Label();
            dddTelefoneTxBox = new TextBox();
            telefoneTxBox = new TextBox();
            groupBox3 = new GroupBox();
            emailTxBox = new TextBox();
            documentoGB = new GroupBox();
            documentoTxBox = new TextBox();
            groupBox1 = new GroupBox();
            tipoPessoaOptions = new ComboBox();
            fontDialog1 = new FontDialog();
            tabControl1.SuspendLayout();
            Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            CadastrarCliente.SuspendLayout();
            groupBox5.SuspendLayout();
            nomeRzSocialGB.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            documentoGB.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Clientes);
            tabControl1.Controls.Add(CadastrarCliente);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(798, 677);
            tabControl1.TabIndex = 0;
            // 
            // Clientes
            // 
            Clientes.BackColor = Color.FromArgb(187, 218, 119);
            Clientes.Controls.Add(button4);
            Clientes.Controls.Add(button3);
            Clientes.Controls.Add(textBox1);
            Clientes.Controls.Add(button2);
            Clientes.Controls.Add(button1);
            Clientes.Controls.Add(label3);
            Clientes.Controls.Add(dataGridView1);
            Clientes.Location = new Point(4, 29);
            Clientes.Margin = new Padding(3, 4, 3, 4);
            Clientes.Name = "Clientes";
            Clientes.Padding = new Padding(3, 4, 3, 4);
            Clientes.Size = new Size(790, 644);
            Clientes.TabIndex = 0;
            Clientes.Text = "Clientes";
            // 
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(654, 543);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(122, 31);
            button4.TabIndex = 6;
            button4.Text = "Remover conta";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(525, 96);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(122, 31);
            button3.TabIndex = 5;
            button3.Text = "Pesquisar";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 97);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(487, 27);
            textBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(654, 504);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(122, 31);
            button2.TabIndex = 3;
            button2.Text = "Remover cliente";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(654, 287);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(122, 31);
            button1.TabIndex = 15;
            button1.Text = "Associar conta";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(251, 17);
            label3.Name = "label3";
            label3.Size = new Size(277, 36);
            label3.TabIndex = 1;
            label3.Text = "LISTA DE CLIENTES";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 136);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(623, 460);
            dataGridView1.TabIndex = 0;
            // 
            // CadastrarCliente
            // 
            CadastrarCliente.BackColor = Color.FromArgb(187, 218, 119);
            CadastrarCliente.Controls.Add(groupBox5);
            CadastrarCliente.Controls.Add(cadastrarPessoaBtn);
            CadastrarCliente.Controls.Add(label2);
            CadastrarCliente.Controls.Add(nomeRzSocialGB);
            CadastrarCliente.Controls.Add(groupBox4);
            CadastrarCliente.Controls.Add(groupBox3);
            CadastrarCliente.Controls.Add(documentoGB);
            CadastrarCliente.Controls.Add(groupBox1);
            CadastrarCliente.Location = new Point(4, 29);
            CadastrarCliente.Margin = new Padding(3, 4, 3, 4);
            CadastrarCliente.Name = "CadastrarCliente";
            CadastrarCliente.Padding = new Padding(3, 4, 3, 4);
            CadastrarCliente.Size = new Size(790, 644);
            CadastrarCliente.TabIndex = 1;
            CadastrarCliente.Text = "Cadastrar Cliente";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox2);
            groupBox5.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(406, 320);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(239, 96);
            groupBox5.TabIndex = 16;
            groupBox5.TabStop = false;
            groupBox5.Text = "Número de registro";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(7, 37);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 25);
            textBox2.TabIndex = 0;
            // 
            // cadastrarPessoaBtn
            // 
            cadastrarPessoaBtn.BackColor = Color.Green;
            cadastrarPessoaBtn.FlatStyle = FlatStyle.Popup;
            cadastrarPessoaBtn.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cadastrarPessoaBtn.ForeColor = SystemColors.ButtonHighlight;
            cadastrarPessoaBtn.Location = new Point(341, 456);
            cadastrarPessoaBtn.Margin = new Padding(3, 4, 3, 4);
            cadastrarPessoaBtn.Name = "cadastrarPessoaBtn";
            cadastrarPessoaBtn.Size = new Size(122, 31);
            cadastrarPessoaBtn.TabIndex = 15;
            cadastrarPessoaBtn.Text = "CADASTRAR";
            cadastrarPessoaBtn.UseVisualStyleBackColor = false;
            cadastrarPessoaBtn.Click += cadastrarPessoaBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(187, 218, 119);
            label2.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(265, 20);
            label2.Name = "label2";
            label2.Size = new Size(267, 36);
            label2.TabIndex = 14;
            label2.Text = "CADASTRAMENTO";
            // 
            // nomeRzSocialGB
            // 
            nomeRzSocialGB.Controls.Add(nomeRzSocialTxBox);
            nomeRzSocialGB.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nomeRzSocialGB.Location = new Point(150, 297);
            nomeRzSocialGB.Margin = new Padding(3, 4, 3, 4);
            nomeRzSocialGB.Name = "nomeRzSocialGB";
            nomeRzSocialGB.Padding = new Padding(3, 4, 3, 4);
            nomeRzSocialGB.Size = new Size(239, 104);
            nomeRzSocialGB.TabIndex = 11;
            nomeRzSocialGB.TabStop = false;
            nomeRzSocialGB.Text = "Nome/Razão Social";
            // 
            // nomeRzSocialTxBox
            // 
            nomeRzSocialTxBox.Location = new Point(7, 43);
            nomeRzSocialTxBox.Margin = new Padding(3, 4, 3, 4);
            nomeRzSocialTxBox.MaxLength = 80;
            nomeRzSocialTxBox.Name = "nomeRzSocialTxBox";
            nomeRzSocialTxBox.Size = new Size(188, 25);
            nomeRzSocialTxBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(dddTelefoneTxBox);
            groupBox4.Controls.Add(telefoneTxBox);
            groupBox4.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(406, 185);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(239, 127);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Telefone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 40);
            label1.Name = "label1";
            label1.Size = new Size(38, 17);
            label1.TabIndex = 2;
            label1.Text = "DDD";
            // 
            // dddTelefoneTxBox
            // 
            dddTelefoneTxBox.Location = new Point(49, 36);
            dddTelefoneTxBox.Margin = new Padding(3, 4, 3, 4);
            dddTelefoneTxBox.MaxLength = 2;
            dddTelefoneTxBox.Name = "dddTelefoneTxBox";
            dddTelefoneTxBox.Size = new Size(36, 25);
            dddTelefoneTxBox.TabIndex = 1;
            // 
            // telefoneTxBox
            // 
            telefoneTxBox.Location = new Point(7, 75);
            telefoneTxBox.Margin = new Padding(3, 4, 3, 4);
            telefoneTxBox.MaxLength = 9;
            telefoneTxBox.Name = "telefoneTxBox";
            telefoneTxBox.Size = new Size(188, 25);
            telefoneTxBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(emailTxBox);
            groupBox3.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(150, 185);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(239, 104);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Email";
            // 
            // emailTxBox
            // 
            emailTxBox.Location = new Point(7, 43);
            emailTxBox.Margin = new Padding(3, 4, 3, 4);
            emailTxBox.MaxLength = 50;
            emailTxBox.Name = "emailTxBox";
            emailTxBox.Size = new Size(188, 25);
            emailTxBox.TabIndex = 0;
            // 
            // documentoGB
            // 
            documentoGB.Controls.Add(documentoTxBox);
            documentoGB.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            documentoGB.Location = new Point(406, 67);
            documentoGB.Margin = new Padding(3, 4, 3, 4);
            documentoGB.Name = "documentoGB";
            documentoGB.Padding = new Padding(3, 4, 3, 4);
            documentoGB.Size = new Size(239, 111);
            documentoGB.TabIndex = 9;
            documentoGB.TabStop = false;
            documentoGB.Text = "Documento";
            // 
            // documentoTxBox
            // 
            documentoTxBox.Location = new Point(7, 43);
            documentoTxBox.Margin = new Padding(3, 4, 3, 4);
            documentoTxBox.Name = "documentoTxBox";
            documentoTxBox.Size = new Size(188, 25);
            documentoTxBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tipoPessoaOptions);
            groupBox1.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(150, 67);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(239, 111);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo";
            // 
            // tipoPessoaOptions
            // 
            tipoPessoaOptions.AllowDrop = true;
            tipoPessoaOptions.Items.AddRange(new object[] { "Pessoa Física", "Pessoa Jurídica" });
            tipoPessoaOptions.Location = new Point(7, 41);
            tipoPessoaOptions.Margin = new Padding(3, 4, 3, 4);
            tipoPessoaOptions.Name = "tipoPessoaOptions";
            tipoPessoaOptions.Size = new Size(188, 25);
            tipoPessoaOptions.TabIndex = 0;
            tipoPessoaOptions.TabStop = false;
            tipoPessoaOptions.SelectedIndexChanged += tipoPessoaOptions_SelectedIndexChanged;
            // 
            // AdministradorMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 677);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdministradorMain";
            Text = "AdministradorMain";
            tabControl1.ResumeLayout(false);
            Clientes.ResumeLayout(false);
            Clientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            CadastrarCliente.ResumeLayout(false);
            CadastrarCliente.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            nomeRzSocialGB.ResumeLayout(false);
            nomeRzSocialGB.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            documentoGB.ResumeLayout(false);
            documentoGB.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Clientes;
        private TabPage CadastrarCliente;
        private Button cadastrarPessoaBtn;
        private Label label2;
        private GroupBox nomeRzSocialGB;
        private TextBox nomeRzSocialTxBox;
        private GroupBox groupBox4;
        private Label label1;
        private TextBox dddTelefoneTxBox;
        private TextBox telefoneTxBox;
        private GroupBox groupBox3;
        private TextBox emailTxBox;
        private GroupBox documentoGB;
        private TextBox documentoTxBox;
        private GroupBox groupBox1;
        private ComboBox tipoPessoaOptions;
        private DataGridView dataGridView1;
        private GroupBox groupBox5;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private Button button2;
        private Button button4;
        private Button button3;
        private TextBox textBox1;
        private FontDialog fontDialog1;
    }
}