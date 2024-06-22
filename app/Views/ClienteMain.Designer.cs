namespace app
{
    partial class ClienteMain
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            splitter1 = new Splitter();
            nomeUsuario = new Label();
            consumoUltimoMesLabel = new Label();
            valorTotalContaLabel = new Label();
            valorTotalSemImpostosLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(61, 185);
            label1.Name = "label1";
            label1.Size = new Size(254, 27);
            label1.TabIndex = 0;
            label1.Text = "Consumo no último mês:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(61, 244);
            label2.Name = "label2";
            label2.Size = new Size(208, 27);
            label2.TabIndex = 1;
            label2.Text = "Valor total da conta:\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(61, 301);
            label3.Name = "label3";
            label3.Size = new Size(260, 27);
            label3.TabIndex = 2;
            label3.Text = "Valor total sem impostos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(328, 101);
            label4.Name = "label4";
            label4.Size = new Size(133, 36);
            label4.TabIndex = 3;
            label4.Text = "RESUMO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(14, 12);
            label5.Name = "label5";
            label5.Size = new Size(49, 27);
            label5.TabIndex = 5;
            label5.Text = "Olá,";
            // 
            // splitter1
            // 
            splitter1.AccessibleRole = AccessibleRole.None;
            splitter1.BackColor = Color.White;
            splitter1.BorderStyle = BorderStyle.Fixed3D;
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 0);
            splitter1.Margin = new Padding(3, 4, 3, 4);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(806, 57);
            splitter1.TabIndex = 6;
            splitter1.TabStop = false;
            // 
            // nomeUsuario
            // 
            nomeUsuario.AutoSize = true;
            nomeUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            nomeUsuario.Location = new Point(61, 12);
            nomeUsuario.Name = "nomeUsuario";
            nomeUsuario.Size = new Size(0, 32);
            nomeUsuario.TabIndex = 7;
            // 
            // consumoUltimoMesLabel
            // 
            consumoUltimoMesLabel.AutoSize = true;
            consumoUltimoMesLabel.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            consumoUltimoMesLabel.ForeColor = Color.Green;
            consumoUltimoMesLabel.Location = new Point(380, 185);
            consumoUltimoMesLabel.Name = "consumoUltimoMesLabel";
            consumoUltimoMesLabel.Size = new Size(27, 27);
            consumoUltimoMesLabel.TabIndex = 8;
            consumoUltimoMesLabel.Text = "...";
            // 
            // valorTotalContaLabel
            // 
            valorTotalContaLabel.AutoSize = true;
            valorTotalContaLabel.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            valorTotalContaLabel.ForeColor = Color.Green;
            valorTotalContaLabel.Location = new Point(313, 244);
            valorTotalContaLabel.Name = "valorTotalContaLabel";
            valorTotalContaLabel.Size = new Size(27, 27);
            valorTotalContaLabel.TabIndex = 10;
            valorTotalContaLabel.Text = "...";
            // 
            // valorTotalSemImpostosLabel
            // 
            valorTotalSemImpostosLabel.AutoSize = true;
            valorTotalSemImpostosLabel.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            valorTotalSemImpostosLabel.ForeColor = Color.Green;
            valorTotalSemImpostosLabel.Location = new Point(380, 301);
            valorTotalSemImpostosLabel.Name = "valorTotalSemImpostosLabel";
            valorTotalSemImpostosLabel.Size = new Size(27, 27);
            valorTotalSemImpostosLabel.TabIndex = 11;
            valorTotalSemImpostosLabel.Text = "...";
            // 
            // ClienteMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(187, 218, 119);
            ClientSize = new Size(806, 556);
            Controls.Add(valorTotalSemImpostosLabel);
            Controls.Add(valorTotalContaLabel);
            Controls.Add(consumoUltimoMesLabel);
            Controls.Add(nomeUsuario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(splitter1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClienteMain";
            Text = "ClienteMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Splitter splitter1;
        private Label nomeUsuario;
        private Label consumoUltimoMesLabel;
        private Label valorTotalContaLabel;
        private Label valorTotalSemImpostosLabel;
    }
}