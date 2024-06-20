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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 139);
            label1.Name = "label1";
            label1.Size = new Size(234, 25);
            label1.TabIndex = 0;
            label1.Text = "Consumo no último mês:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(53, 183);
            label2.Name = "label2";
            label2.Size = new Size(192, 25);
            label2.TabIndex = 1;
            label2.Text = "Valor total da conta:\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(53, 226);
            label3.Name = "label3";
            label3.Size = new Size(236, 25);
            label3.TabIndex = 2;
            label3.Text = "Valor total sem impostos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(287, 76);
            label4.Name = "label4";
            label4.Size = new Size(114, 32);
            label4.TabIndex = 3;
            label4.Text = "RESUMO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 5;
            label5.Text = "Olá, ...";
            // 
            // splitter1
            // 
            splitter1.AccessibleRole = AccessibleRole.None;
            splitter1.BorderStyle = BorderStyle.Fixed3D;
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(705, 44);
            splitter1.TabIndex = 6;
            splitter1.TabStop = false;
            // 
            // ClienteMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 417);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(splitter1);
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
    }
}