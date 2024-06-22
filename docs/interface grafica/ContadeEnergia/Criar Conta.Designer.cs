namespace ContadeEnergia
{
    partial class Criar_Conta
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
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(277, 396);
            button2.Name = "button2";
            button2.Size = new Size(196, 42);
            button2.TabIndex = 3;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(243, 257);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(243, 329);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 27);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(243, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(268, 27);
            textBox3.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 163);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 9;
            label1.Text = "CPF/CNPJ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(243, 237);
            label2.Name = "label2";
            label2.Size = new Size(133, 17);
            label2.TabIndex = 10;
            label2.Text = "Número do Registro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(243, 309);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 11;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(243, 114);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(268, 28);
            comboBox1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(243, 83);
            label4.Name = "label4";
            label4.Size = new Size(94, 17);
            label4.TabIndex = 13;
            label4.Text = "Tipo de Conta";
            // 
            // Criar_Conta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(187, 218, 119);
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Name = "Criar_Conta";
            Text = "Criar_Conta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
    }
}