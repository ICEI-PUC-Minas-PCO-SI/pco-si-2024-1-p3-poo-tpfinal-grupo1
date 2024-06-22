namespace app.Views
{
    partial class CadastroCliente
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
            groupBox1 = new GroupBox();
            tipoPessoaOptions = new ComboBox();
            documentoGB = new GroupBox();
            documentoTxBox = new TextBox();
            groupBox3 = new GroupBox();
            emailTxBox = new TextBox();
            groupBox4 = new GroupBox();
            label1 = new Label();
            dddTelefoneTxBox = new TextBox();
            telefoneTxBox = new TextBox();
            nomeRzSocialGB = new GroupBox();
            nomeRzSocialTxBox = new TextBox();
            label2 = new Label();
            cadastrarPessoaBtn = new Button();
            groupBox6 = new GroupBox();
            senhaTxBox = new TextBox();
            groupBox1.SuspendLayout();
            documentoGB.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            nomeRzSocialGB.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tipoPessoaOptions);
            groupBox1.Location = new Point(235, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(209, 83);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo";
            // 
            // tipoPessoaOptions
            // 
            tipoPessoaOptions.AllowDrop = true;
            tipoPessoaOptions.Items.AddRange(new object[] { "Pessoa Física", "Pessoa Jurídica" });
            tipoPessoaOptions.Location = new Point(6, 31);
            tipoPessoaOptions.Name = "tipoPessoaOptions";
            tipoPessoaOptions.Size = new Size(165, 23);
            tipoPessoaOptions.TabIndex = 0;
            tipoPessoaOptions.TabStop = false;
            tipoPessoaOptions.SelectedIndexChanged += tipoPessoaOptions_SelectedIndexChanged;
            // 
            // documentoGB
            // 
            documentoGB.Controls.Add(documentoTxBox);
            documentoGB.Location = new Point(235, 152);
            documentoGB.Name = "documentoGB";
            documentoGB.Size = new Size(209, 78);
            documentoGB.TabIndex = 3;
            documentoGB.TabStop = false;
            documentoGB.Text = "Documento";
            // 
            // documentoTxBox
            // 
            documentoTxBox.Location = new Point(6, 32);
            documentoTxBox.Name = "documentoTxBox";
            documentoTxBox.Size = new Size(165, 23);
            documentoTxBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(emailTxBox);
            groupBox3.Location = new Point(235, 236);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(209, 78);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Email";
            // 
            // emailTxBox
            // 
            emailTxBox.Location = new Point(6, 32);
            emailTxBox.MaxLength = 50;
            emailTxBox.Name = "emailTxBox";
            emailTxBox.Size = new Size(165, 23);
            emailTxBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(dddTelefoneTxBox);
            groupBox4.Controls.Add(telefoneTxBox);
            groupBox4.Location = new Point(235, 320);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(209, 107);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Telefone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "DDD";
            // 
            // dddTelefoneTxBox
            // 
            dddTelefoneTxBox.Location = new Point(43, 27);
            dddTelefoneTxBox.MaxLength = 2;
            dddTelefoneTxBox.Name = "dddTelefoneTxBox";
            dddTelefoneTxBox.Size = new Size(32, 23);
            dddTelefoneTxBox.TabIndex = 1;
            // 
            // telefoneTxBox
            // 
            telefoneTxBox.Location = new Point(6, 56);
            telefoneTxBox.MaxLength = 9;
            telefoneTxBox.Name = "telefoneTxBox";
            telefoneTxBox.Size = new Size(165, 23);
            telefoneTxBox.TabIndex = 0;
            // 
            // nomeRzSocialGB
            // 
            nomeRzSocialGB.Controls.Add(nomeRzSocialTxBox);
            nomeRzSocialGB.Location = new Point(235, 433);
            nomeRzSocialGB.Name = "nomeRzSocialGB";
            nomeRzSocialGB.Size = new Size(209, 78);
            nomeRzSocialGB.TabIndex = 5;
            nomeRzSocialGB.TabStop = false;
            nomeRzSocialGB.Text = "Nome/Razão Social";
            // 
            // nomeRzSocialTxBox
            // 
            nomeRzSocialTxBox.Location = new Point(6, 32);
            nomeRzSocialTxBox.MaxLength = 80;
            nomeRzSocialTxBox.Name = "nomeRzSocialTxBox";
            nomeRzSocialTxBox.Size = new Size(165, 23);
            nomeRzSocialTxBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(226, 19);
            label2.Name = "label2";
            label2.Size = new Size(227, 32);
            label2.TabIndex = 6;
            label2.Text = "CADASTRAMENTO";
            // 
            // cadastrarPessoaBtn
            // 
            cadastrarPessoaBtn.Location = new Point(278, 613);
            cadastrarPessoaBtn.Name = "cadastrarPessoaBtn";
            cadastrarPessoaBtn.Size = new Size(107, 23);
            cadastrarPessoaBtn.TabIndex = 7;
            cadastrarPessoaBtn.Text = "CADASTRAR";
            cadastrarPessoaBtn.UseVisualStyleBackColor = true;
            cadastrarPessoaBtn.Click += cadastrarPessoaBtn_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(senhaTxBox);
            groupBox6.Location = new Point(235, 517);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(209, 78);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "Senha";
            // 
            // senhaTxBox
            // 
            senhaTxBox.Location = new Point(6, 32);
            senhaTxBox.MaxLength = 15;
            senhaTxBox.Name = "senhaTxBox";
            senhaTxBox.Size = new Size(165, 23);
            senhaTxBox.TabIndex = 0;
            senhaTxBox.UseSystemPasswordChar = true;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 657);
            Controls.Add(groupBox6);
            Controls.Add(cadastrarPessoaBtn);
            Controls.Add(label2);
            Controls.Add(nomeRzSocialGB);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(documentoGB);
            Controls.Add(groupBox1);
            Name = "CadastroCliente";
            Text = "CadastroCliente";
            groupBox1.ResumeLayout(false);
            documentoGB.ResumeLayout(false);
            documentoGB.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            nomeRzSocialGB.ResumeLayout(false);
            nomeRzSocialGB.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox documentoGB;
        private TextBox documentoTxBox;
        private GroupBox groupBox3;
        private TextBox emailTxBox;
        private GroupBox groupBox4;
        private TextBox telefoneTxBox;
        private Label label1;
        private TextBox dddTelefoneTxBox;
        private GroupBox nomeRzSocialGB;
        private TextBox nomeRzSocialTxBox;
        private Label label2;
        private Button cadastrarPessoaBtn;
        private GroupBox groupBox6;
        private TextBox senhaTxBox;
        private ComboBox tipoPessoaOptions;
    }
}