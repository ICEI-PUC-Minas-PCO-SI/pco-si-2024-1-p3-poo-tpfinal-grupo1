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
            groupBox1.Controls.Add(documentoTxBox);
            groupBox1.Controls.Add(documentoLabel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(optionsLogin);
            groupBox1.Location = new Point(234, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 201);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // btnEntrarLogin
            // 
            btnEntrarLogin.Location = new Point(26, 148);
            btnEntrarLogin.Name = "btnEntrarLogin";
            btnEntrarLogin.Size = new Size(165, 23);
            btnEntrarLogin.TabIndex = 6;
            btnEntrarLogin.Text = "ENTRAR";
            btnEntrarLogin.UseVisualStyleBackColor = true;
            // 
            // documentoTxBox
            // 
            documentoTxBox.Location = new Point(26, 102);
            documentoTxBox.Name = "documentoTxBox";
            documentoTxBox.Size = new Size(165, 23);
            documentoTxBox.TabIndex = 4;
            documentoTxBox.KeyPress += documentoTxBox_KeyPress;
            // 
            // documentoLabel
            // 
            documentoLabel.AutoSize = true;
            documentoLabel.Location = new Point(25, 84);
            documentoLabel.Name = "documentoLabel";
            documentoLabel.Size = new Size(70, 15);
            documentoLabel.TabIndex = 2;
            documentoLabel.Text = "Documento";
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
            optionsLogin.SelectedIndexChanged += optionsLogin_SelectedIndexChanged;
            // 
            // btnAbirLoginSecundario
            // 
            btnAbirLoginSecundario.AutoSize = true;
            btnAbirLoginSecundario.Location = new Point(234, 331);
            btnAbirLoginSecundario.Name = "btnAbirLoginSecundario";
            btnAbirLoginSecundario.Size = new Size(91, 15);
            btnAbirLoginSecundario.TabIndex = 10;
            btnAbirLoginSecundario.TabStop = true;
            btnAbirLoginSecundario.Text = "Sou funcionário";
            btnAbirLoginSecundario.LinkClicked += btnAbirLoginSecundario_LinkClicked;
            // 
            // LoginPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 450);
            Controls.Add(btnAbirLoginSecundario);
            Controls.Add(groupBox1);
            Controls.Add(label2);
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