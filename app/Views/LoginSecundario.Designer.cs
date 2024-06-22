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
            btnEncerrarLogin.Location = new Point(237, 384);
            btnEncerrarLogin.Name = "btnEncerrarLogin";
            btnEncerrarLogin.Size = new Size(37, 15);
            btnEncerrarLogin.TabIndex = 13;
            btnEncerrarLogin.TabStop = true;
            btnEncerrarLogin.Text = "voltar";
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
            groupBox1.Location = new Point(237, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(227, 242);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 138);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 8;
            label4.Text = "Senha";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 156);
            textBox1.MaxLength = 15;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 7;
            textBox1.UseSystemPasswordChar = true;
            // 
            // btnEntrarLogin
            // 
            btnEntrarLogin.Location = new Point(25, 200);
            btnEntrarLogin.Name = "btnEntrarLogin";
            btnEntrarLogin.Size = new Size(165, 23);
            btnEntrarLogin.TabIndex = 6;
            btnEntrarLogin.Text = "ENTRAR";
            btnEntrarLogin.UseVisualStyleBackColor = true;
            btnEntrarLogin.Click += btnEntrarLogin_Click;
            // 
            // matriculaTxBox
            // 
            matriculaTxBox.Location = new Point(26, 102);
            matriculaTxBox.MaxLength = 6;
            matriculaTxBox.Name = "matriculaTxBox";
            matriculaTxBox.Size = new Size(165, 23);
            matriculaTxBox.TabIndex = 4;
            matriculaTxBox.KeyPress += matriculaTxBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 84);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Matrícula";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 30);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 1;
            label1.Text = "Administrador ou Leiturista";
            // 
            // optionsLogin
            // 
            optionsLogin.AllowDrop = true;
            optionsLogin.Items.AddRange(new object[] { "Administrador", "Leiturista" });
            optionsLogin.Location = new Point(26, 48);
            optionsLogin.Name = "optionsLogin";
            optionsLogin.Size = new Size(165, 23);
            optionsLogin.TabIndex = 0;
            optionsLogin.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(262, 78);
            label2.Name = "label2";
            label2.Size = new Size(166, 32);
            label2.TabIndex = 11;
            label2.Text = "FAZER LOGIN";
            // 
            // LoginSecundario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 445);
            Controls.Add(btnEncerrarLogin);
            Controls.Add(groupBox1);
            Controls.Add(label2);
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