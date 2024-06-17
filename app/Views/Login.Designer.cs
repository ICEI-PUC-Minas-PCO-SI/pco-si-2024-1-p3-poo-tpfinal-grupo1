namespace app.Views
{
    partial class Login
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
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnEntrarLogin = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            optionsLogin = new ComboBox();
            label5 = new Label();
            btnCadastrarLogin = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(259, 57);
            label2.Name = "label2";
            label2.Size = new Size(166, 32);
            label2.TabIndex = 7;
            label2.Text = "FAZER LOGIN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEntrarLogin);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(optionsLogin);
            groupBox1.Location = new Point(234, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 235);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // btnEntrarLogin
            // 
            btnEntrarLogin.Location = new Point(25, 194);
            btnEntrarLogin.Name = "btnEntrarLogin";
            btnEntrarLogin.Size = new Size(165, 23);
            btnEntrarLogin.TabIndex = 6;
            btnEntrarLogin.Text = "ENTRAR";
            btnEntrarLogin.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(26, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 5;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 137);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 84);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Documento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 30);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 1;
            label1.Text = "Pessoa Física ou Jurídica";
            // 
            // optionsLogin
            // 
            optionsLogin.AllowDrop = true;
            optionsLogin.Items.AddRange(new object[] { "Pessoa Física", "Pessoa Jurídica" });
            optionsLogin.Location = new Point(26, 48);
            optionsLogin.Name = "optionsLogin";
            optionsLogin.Size = new Size(165, 23);
            optionsLogin.TabIndex = 0;
            optionsLogin.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(234, 360);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 9;
            label5.Text = "Ainda não cadastrado?";
            // 
            // btnCadastrarLogin
            // 
            btnCadastrarLogin.AutoSize = true;
            btnCadastrarLogin.Location = new Point(234, 375);
            btnCadastrarLogin.Name = "btnCadastrarLogin";
            btnCadastrarLogin.Size = new Size(57, 15);
            btnCadastrarLogin.TabIndex = 10;
            btnCadastrarLogin.TabStop = true;
            btnCadastrarLogin.Text = "Cadastrar";
            btnCadastrarLogin.LinkClicked += btnCadastrarLogin_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 450);
            Controls.Add(btnCadastrarLogin);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Name = "Login";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label1;
        private ComboBox optionsLogin;
        private Button btnEntrarLogin;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private LinkLabel btnCadastrarLogin;
    }
}