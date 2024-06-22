namespace app.Views
{
    partial class LoginSecundario
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
            btnEncerrarLogin = new LinkLabel();
            groupBox1 = new GroupBox();
            label4 = new Label();
            textBox1 = new TextBox();
            btnEntrarLogin = new Button();
            matriculaTxBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            optionsLogin = new ComboBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEncerrarLogin
            // 
            btnEncerrarLogin.AutoSize = true;
            btnEncerrarLogin.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEncerrarLogin.LinkColor = Color.Green;
            btnEncerrarLogin.Location = new Point(271, 523);
            btnEncerrarLogin.Name = "btnEncerrarLogin";
            btnEncerrarLogin.Size = new Size(46, 17);
            btnEncerrarLogin.TabIndex = 13;
            btnEncerrarLogin.TabStop = true;
            btnEncerrarLogin.Text = "Voltar";
            btnEncerrarLogin.LinkClicked += btnEncerrarLogin_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnEntrarLogin);
            groupBox1.Controls.Add(matriculaTxBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(optionsLogin);
            groupBox1.Location = new Point(271, 185);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(259, 323);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(29, 184);
            label4.Name = "label4";
            label4.Size = new Size(45, 17);
            label4.TabIndex = 8;
            label4.Text = "Senha";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 208);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.MaxLength = 15;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 27);
            textBox1.TabIndex = 7;
            textBox1.UseSystemPasswordChar = true;
            // 
            // btnEntrarLogin
            // 
            btnEntrarLogin.BackColor = Color.Green;
            btnEntrarLogin.FlatStyle = FlatStyle.Popup;
            btnEntrarLogin.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntrarLogin.ForeColor = SystemColors.ButtonHighlight;
            btnEntrarLogin.Location = new Point(29, 267);
            btnEntrarLogin.Margin = new Padding(3, 4, 3, 4);
            btnEntrarLogin.Name = "btnEntrarLogin";
            btnEntrarLogin.Size = new Size(189, 31);
            btnEntrarLogin.TabIndex = 6;
            btnEntrarLogin.Text = "ENTRAR";
            btnEntrarLogin.UseVisualStyleBackColor = false;
            btnEntrarLogin.Click += btnEntrarLogin_Click;
            // 
            // matriculaTxBox
            // 
            matriculaTxBox.Location = new Point(30, 136);
            matriculaTxBox.Margin = new Padding(3, 4, 3, 4);
            matriculaTxBox.MaxLength = 6;
            matriculaTxBox.Name = "matriculaTxBox";
            matriculaTxBox.Size = new Size(188, 27);
            matriculaTxBox.TabIndex = 4;
            matriculaTxBox.KeyPress += matriculaTxBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 112);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 2;
            label3.Text = "Matrícula";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 40);
            label1.Name = "label1";
            label1.Size = new Size(181, 17);
            label1.TabIndex = 1;
            label1.Text = "Administrador ou Leiturista";
            // 
            // optionsLogin
            // 
            optionsLogin.AllowDrop = true;
            optionsLogin.Items.AddRange(new object[] { "Administrador", "Leiturista" });
            optionsLogin.Location = new Point(30, 64);
            optionsLogin.Margin = new Padding(3, 4, 3, 4);
            optionsLogin.Name = "optionsLogin";
            optionsLogin.Size = new Size(188, 28);
            optionsLogin.TabIndex = 0;
            optionsLogin.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(301, 109);
            label2.Name = "label2";
            label2.Size = new Size(197, 36);
            label2.TabIndex = 11;
            label2.Text = "FAZER LOGIN";
            // 
            // LoginSecundario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(187, 218, 119);
            ClientSize = new Size(800, 593);
            Controls.Add(btnEncerrarLogin);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginSecundario";
            Text = "LoginSecundario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void MatriculaTxBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private LinkLabel btnEncerrarLogin;
        private GroupBox groupBox1;
        private Button btnEntrarLogin;
        private TextBox matriculaTxBox;
        private Label label3;
        private Label label1;
        private ComboBox optionsLogin;
        private Label label2;
        private Label label4;
        private TextBox textBox1;
    }
}