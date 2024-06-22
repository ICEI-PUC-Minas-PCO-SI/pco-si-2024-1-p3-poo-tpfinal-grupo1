namespace app.Views
{
    partial class LoginPrincipal
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
            documentoTxBox = new TextBox();
            documentoLabel = new Label();
            label1 = new Label();
            optionsLogin = new ComboBox();
            btnAbirLoginSecundario = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(296, 76);
            label2.Name = "label2";
            label2.Size = new Size(197, 36);
            label2.TabIndex = 7;
            label2.Text = "FAZER LOGIN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEntrarLogin);
            groupBox1.Controls.Add(documentoTxBox);
            groupBox1.Controls.Add(documentoLabel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(optionsLogin);
            groupBox1.Location = new Point(267, 157);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(258, 268);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // btnEntrarLogin
            // 
            btnEntrarLogin.BackColor = Color.Green;
            btnEntrarLogin.FlatStyle = FlatStyle.Popup;
            btnEntrarLogin.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntrarLogin.ForeColor = SystemColors.ButtonHighlight;
            btnEntrarLogin.Location = new Point(30, 197);
            btnEntrarLogin.Margin = new Padding(3, 4, 3, 4);
            btnEntrarLogin.Name = "btnEntrarLogin";
            btnEntrarLogin.Size = new Size(189, 31);
            btnEntrarLogin.TabIndex = 6;
            btnEntrarLogin.Text = "ENTRAR";
            btnEntrarLogin.UseVisualStyleBackColor = false;
            btnEntrarLogin.Click += btnEntrarLogin_Click;
            // 
            // documentoTxBox
            // 
            documentoTxBox.Location = new Point(30, 136);
            documentoTxBox.Margin = new Padding(3, 4, 3, 4);
            documentoTxBox.Name = "documentoTxBox";
            documentoTxBox.Size = new Size(188, 27);
            documentoTxBox.TabIndex = 4;
            documentoTxBox.KeyPress += documentoTxBox_KeyPress;
            // 
            // documentoLabel
            // 
            documentoLabel.AutoSize = true;
            documentoLabel.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            documentoLabel.Location = new Point(29, 112);
            documentoLabel.Name = "documentoLabel";
            documentoLabel.Size = new Size(81, 17);
            documentoLabel.TabIndex = 2;
            documentoLabel.Text = "Documento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 40);
            label1.Name = "label1";
            label1.Size = new Size(161, 17);
            label1.TabIndex = 1;
            label1.Text = "Pessoa Física ou Jurídica";
            // 
            // optionsLogin
            // 
            optionsLogin.AllowDrop = true;
            optionsLogin.Items.AddRange(new object[] { "Pessoa Física", "Pessoa Jurídica" });
            optionsLogin.Location = new Point(30, 64);
            optionsLogin.Margin = new Padding(3, 4, 3, 4);
            optionsLogin.Name = "optionsLogin";
            optionsLogin.Size = new Size(188, 28);
            optionsLogin.TabIndex = 0;
            optionsLogin.TabStop = false;
            optionsLogin.SelectedIndexChanged += optionsLogin_SelectedIndexChanged;
            // 
            // btnAbirLoginSecundario
            // 
            btnAbirLoginSecundario.AutoSize = true;
            btnAbirLoginSecundario.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbirLoginSecundario.LinkColor = Color.Green;
            btnAbirLoginSecundario.Location = new Point(267, 441);
            btnAbirLoginSecundario.Name = "btnAbirLoginSecundario";
            btnAbirLoginSecundario.Size = new Size(107, 17);
            btnAbirLoginSecundario.TabIndex = 10;
            btnAbirLoginSecundario.TabStop = true;
            btnAbirLoginSecundario.Text = "Sou funcionário";
            btnAbirLoginSecundario.LinkClicked += btnAbirLoginSecundario_LinkClicked;
            // 
            // LoginPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(187, 218, 119);
            ClientSize = new Size(806, 600);
            Controls.Add(btnAbirLoginSecundario);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginPrincipal";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private GroupBox groupBox1;
        private Label documentoLabel;
        private Label label1;
        private ComboBox optionsLogin;
        private Button btnEntrarLogin;
        private TextBox documentoTxBox;
        private LinkLabel btnAbirLoginSecundario;
    }
}