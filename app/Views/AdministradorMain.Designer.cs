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
            associarContaPjTxBox = new TextBox();
            associarContaPjBtn = new Button();
            pesquisarPfBtn = new Button();
            pesquisarPjTxBox = new TextBox();
            tabelaClientesPJ = new DataGridView();
            associarContaPfTxBox = new TextBox();
            pesquisarPjBtn = new Button();
            pesquisarPfTxBox = new TextBox();
            button2 = new Button();
            associarContaPfBtn = new Button();
            label3 = new Label();
            tabelaClientesPF = new DataGridView();
            CadastrarCliente = new TabPage();
            groupBox5 = new GroupBox();
            numInstalacaoCadastramentoTxBox = new TextBox();
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
            tabControl1.SuspendLayout();
            Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaClientesPJ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabelaClientesPF).BeginInit();
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
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(698, 553);
            tabControl1.TabIndex = 0;
            // 
            // Clientes
            // 
            Clientes.BackColor = Color.FromArgb(187, 218, 119);
            Clientes.Controls.Add(associarContaPjTxBox);
            Clientes.Controls.Add(associarContaPjBtn);
            Clientes.Controls.Add(pesquisarPfBtn);
            Clientes.Controls.Add(pesquisarPjTxBox);
            Clientes.Controls.Add(tabelaClientesPJ);
            Clientes.Controls.Add(associarContaPfTxBox);
            Clientes.Controls.Add(pesquisarPjBtn);
            Clientes.Controls.Add(pesquisarPfTxBox);
            Clientes.Controls.Add(button2);
            Clientes.Controls.Add(associarContaPfBtn);
            Clientes.Controls.Add(label3);
            Clientes.Controls.Add(tabelaClientesPF);
            Clientes.Location = new Point(4, 24);
            Clientes.Name = "Clientes";
            Clientes.Padding = new Padding(3);
            Clientes.Size = new Size(690, 525);
            Clientes.TabIndex = 0;
            Clientes.Text = "Clientes";
            // 
            // associarContaPjTxBox
            // 
            associarContaPjTxBox.Location = new Point(571, 338);
            associarContaPjTxBox.MaxLength = 20;
            associarContaPjTxBox.Name = "associarContaPjTxBox";
            associarContaPjTxBox.Size = new Size(108, 23);
            associarContaPjTxBox.TabIndex = 21;
            // 
            // associarContaPjBtn
            // 
            associarContaPjBtn.BackColor = Color.Green;
            associarContaPjBtn.FlatStyle = FlatStyle.Popup;
            associarContaPjBtn.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            associarContaPjBtn.ForeColor = SystemColors.ButtonHighlight;
            associarContaPjBtn.Location = new Point(572, 367);
            associarContaPjBtn.Name = "associarContaPjBtn";
            associarContaPjBtn.Size = new Size(107, 23);
            associarContaPjBtn.TabIndex = 20;
            associarContaPjBtn.Text = "Associar conta";
            associarContaPjBtn.UseVisualStyleBackColor = false;
            associarContaPjBtn.Click += associarContaPjBtn_Click;
            // 
            // pesquisarPfBtn
            // 
            pesquisarPfBtn.BackColor = Color.Green;
            pesquisarPfBtn.FlatStyle = FlatStyle.Popup;
            pesquisarPfBtn.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pesquisarPfBtn.ForeColor = SystemColors.ButtonHighlight;
            pesquisarPfBtn.ImageAlign = ContentAlignment.TopCenter;
            pesquisarPfBtn.Location = new Point(454, 73);
            pesquisarPfBtn.Name = "pesquisarPfBtn";
            pesquisarPfBtn.Size = new Size(107, 23);
            pesquisarPfBtn.TabIndex = 19;
            pesquisarPfBtn.Text = "Pesquisar";
            pesquisarPfBtn.UseVisualStyleBackColor = false;
            pesquisarPfBtn.Click += pesquisarPfBtn_Click;
            // 
            // pesquisarPjTxBox
            // 
            pesquisarPjTxBox.Location = new Point(21, 299);
            pesquisarPjTxBox.Name = "pesquisarPjTxBox";
            pesquisarPjTxBox.Size = new Size(427, 23);
            pesquisarPjTxBox.TabIndex = 18;
            // 
            // tabelaClientesPJ
            // 
            tabelaClientesPJ.BackgroundColor = Color.White;
            tabelaClientesPJ.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaClientesPJ.Location = new Point(21, 338);
            tabelaClientesPJ.Name = "tabelaClientesPJ";
            tabelaClientesPJ.RowHeadersWidth = 51;
            tabelaClientesPJ.RowTemplate.Height = 25;
            tabelaClientesPJ.Size = new Size(545, 171);
            tabelaClientesPJ.TabIndex = 17;
            // 
            // associarContaPfTxBox
            // 
            associarContaPfTxBox.Location = new Point(571, 102);
            associarContaPfTxBox.MaxLength = 20;
            associarContaPfTxBox.Name = "associarContaPfTxBox";
            associarContaPfTxBox.Size = new Size(108, 23);
            associarContaPfTxBox.TabIndex = 16;
            // 
            // pesquisarPjBtn
            // 
            pesquisarPjBtn.BackColor = Color.Green;
            pesquisarPjBtn.FlatStyle = FlatStyle.Popup;
            pesquisarPjBtn.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pesquisarPjBtn.ForeColor = SystemColors.ButtonHighlight;
            pesquisarPjBtn.ImageAlign = ContentAlignment.TopCenter;
            pesquisarPjBtn.Location = new Point(459, 299);
            pesquisarPjBtn.Name = "pesquisarPjBtn";
            pesquisarPjBtn.Size = new Size(107, 23);
            pesquisarPjBtn.TabIndex = 5;
            pesquisarPjBtn.Text = "Pesquisar";
            pesquisarPjBtn.UseVisualStyleBackColor = false;
            pesquisarPjBtn.Click += pesquisarPjBtn_Click;
            // 
            // pesquisarPfTxBox
            // 
            pesquisarPfTxBox.Location = new Point(21, 73);
            pesquisarPfTxBox.Name = "pesquisarPfTxBox";
            pesquisarPfTxBox.Size = new Size(427, 23);
            pesquisarPfTxBox.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(575, 474);
            button2.Name = "button2";
            button2.Size = new Size(107, 23);
            button2.TabIndex = 3;
            button2.Text = "Remover cliente";
            button2.UseVisualStyleBackColor = false;
            // 
            // associarContaPfBtn
            // 
            associarContaPfBtn.BackColor = Color.Green;
            associarContaPfBtn.FlatStyle = FlatStyle.Popup;
            associarContaPfBtn.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            associarContaPfBtn.ForeColor = SystemColors.ButtonHighlight;
            associarContaPfBtn.Location = new Point(572, 131);
            associarContaPfBtn.Name = "associarContaPfBtn";
            associarContaPfBtn.Size = new Size(107, 23);
            associarContaPfBtn.TabIndex = 15;
            associarContaPfBtn.Text = "Associar conta";
            associarContaPfBtn.UseVisualStyleBackColor = false;
            associarContaPfBtn.Click += associarContaPfBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(220, 13);
            label3.Name = "label3";
            label3.Size = new Size(220, 28);
            label3.TabIndex = 1;
            label3.Text = "LISTA DE CLIENTES";
            // 
            // tabelaClientesPF
            // 
            tabelaClientesPF.BackgroundColor = Color.White;
            tabelaClientesPF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaClientesPF.Location = new Point(21, 102);
            tabelaClientesPF.Name = "tabelaClientesPF";
            tabelaClientesPF.RowHeadersWidth = 51;
            tabelaClientesPF.RowTemplate.Height = 25;
            tabelaClientesPF.Size = new Size(545, 171);
            tabelaClientesPF.TabIndex = 0;
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
            CadastrarCliente.Location = new Point(4, 24);
            CadastrarCliente.Name = "CadastrarCliente";
            CadastrarCliente.Padding = new Padding(3);
            CadastrarCliente.Size = new Size(690, 525);
            CadastrarCliente.TabIndex = 1;
            CadastrarCliente.Text = "Cadastrar Cliente";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(numInstalacaoCadastramentoTxBox);
            groupBox5.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(355, 240);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(209, 72);
            groupBox5.TabIndex = 16;
            groupBox5.TabStop = false;
            groupBox5.Text = "Número de registro";
            // 
            // numInstalacaoCadastramentoTxBox
            // 
            numInstalacaoCadastramentoTxBox.Location = new Point(6, 28);
            numInstalacaoCadastramentoTxBox.MaxLength = 20;
            numInstalacaoCadastramentoTxBox.Name = "numInstalacaoCadastramentoTxBox";
            numInstalacaoCadastramentoTxBox.Size = new Size(165, 22);
            numInstalacaoCadastramentoTxBox.TabIndex = 0;
            // 
            // cadastrarPessoaBtn
            // 
            cadastrarPessoaBtn.BackColor = Color.Green;
            cadastrarPessoaBtn.FlatStyle = FlatStyle.Popup;
            cadastrarPessoaBtn.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cadastrarPessoaBtn.ForeColor = SystemColors.ButtonHighlight;
            cadastrarPessoaBtn.Location = new Point(298, 342);
            cadastrarPessoaBtn.Name = "cadastrarPessoaBtn";
            cadastrarPessoaBtn.Size = new Size(107, 23);
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
            label2.Location = new Point(232, 15);
            label2.Name = "label2";
            label2.Size = new Size(214, 28);
            label2.TabIndex = 14;
            label2.Text = "CADASTRAMENTO";
            // 
            // nomeRzSocialGB
            // 
            nomeRzSocialGB.Controls.Add(nomeRzSocialTxBox);
            nomeRzSocialGB.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nomeRzSocialGB.Location = new Point(131, 223);
            nomeRzSocialGB.Name = "nomeRzSocialGB";
            nomeRzSocialGB.Size = new Size(209, 78);
            nomeRzSocialGB.TabIndex = 11;
            nomeRzSocialGB.TabStop = false;
            nomeRzSocialGB.Text = "Nome/Razão Social";
            // 
            // nomeRzSocialTxBox
            // 
            nomeRzSocialTxBox.Location = new Point(6, 32);
            nomeRzSocialTxBox.MaxLength = 80;
            nomeRzSocialTxBox.Name = "nomeRzSocialTxBox";
            nomeRzSocialTxBox.Size = new Size(165, 22);
            nomeRzSocialTxBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(dddTelefoneTxBox);
            groupBox4.Controls.Add(telefoneTxBox);
            groupBox4.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(355, 139);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(209, 95);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Telefone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(31, 14);
            label1.TabIndex = 2;
            label1.Text = "DDD";
            // 
            // dddTelefoneTxBox
            // 
            dddTelefoneTxBox.Location = new Point(43, 27);
            dddTelefoneTxBox.MaxLength = 2;
            dddTelefoneTxBox.Name = "dddTelefoneTxBox";
            dddTelefoneTxBox.Size = new Size(32, 22);
            dddTelefoneTxBox.TabIndex = 1;
            // 
            // telefoneTxBox
            // 
            telefoneTxBox.Location = new Point(6, 56);
            telefoneTxBox.MaxLength = 9;
            telefoneTxBox.Name = "telefoneTxBox";
            telefoneTxBox.Size = new Size(165, 22);
            telefoneTxBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(emailTxBox);
            groupBox3.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(131, 139);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(209, 78);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Email";
            // 
            // emailTxBox
            // 
            emailTxBox.Location = new Point(6, 32);
            emailTxBox.MaxLength = 50;
            emailTxBox.Name = "emailTxBox";
            emailTxBox.Size = new Size(165, 22);
            emailTxBox.TabIndex = 0;
            // 
            // documentoGB
            // 
            documentoGB.Controls.Add(documentoTxBox);
            documentoGB.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            documentoGB.Location = new Point(355, 50);
            documentoGB.Name = "documentoGB";
            documentoGB.Size = new Size(209, 83);
            documentoGB.TabIndex = 9;
            documentoGB.TabStop = false;
            documentoGB.Text = "Documento";
            // 
            // documentoTxBox
            // 
            documentoTxBox.Location = new Point(6, 32);
            documentoTxBox.Name = "documentoTxBox";
            documentoTxBox.Size = new Size(165, 22);
            documentoTxBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tipoPessoaOptions);
            groupBox1.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(131, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(209, 83);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo";
            // 
            // tipoPessoaOptions
            // 
            tipoPessoaOptions.AllowDrop = true;
            tipoPessoaOptions.Items.AddRange(new object[] { "Pessoa Física", "Pessoa Jurídica" });
            tipoPessoaOptions.Location = new Point(6, 31);
            tipoPessoaOptions.Name = "tipoPessoaOptions";
            tipoPessoaOptions.Size = new Size(165, 22);
            tipoPessoaOptions.TabIndex = 0;
            tipoPessoaOptions.TabStop = false;
            tipoPessoaOptions.SelectedIndexChanged += tipoPessoaOptions_SelectedIndexChanged;
            // 
            // AdministradorMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 553);
            Controls.Add(tabControl1);
            Name = "AdministradorMain";
            Text = "AdministradorMain";
            tabControl1.ResumeLayout(false);
            Clientes.ResumeLayout(false);
            Clientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaClientesPJ).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabelaClientesPF).EndInit();
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
        private DataGridView tabelaClientesPF;
        private GroupBox groupBox5;
        private TextBox numInstalacaoCadastramentoTxBox;
        private Button associarContaPfBtn;
        private Label label3;
        private Button button2;
        private Button associarContaPjBtn;
        private Button pesquisarPjBtn;
        private TextBox pesquisarPfTxBox;
        private FontDialog fontDialog1;
        private TextBox associarContaPfTxBox;
        private Button pesquisarPfBtn;
        private TextBox pesquisarPjTxBox;
        private DataGridView tabelaClientesPJ;
        private TextBox associarContaPjTxBox;
    }
}