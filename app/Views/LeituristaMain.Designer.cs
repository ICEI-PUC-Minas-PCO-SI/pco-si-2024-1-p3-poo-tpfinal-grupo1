namespace app.Views
{
    partial class LeituristaMain
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
            groupBox5 = new GroupBox();
            numInstalacaoTxBox = new TextBox();
            groupBox2 = new GroupBox();
            valorMedidoKWh = new TextBox();
            registrarKWhBtn = new Button();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(229, 18);
            label1.Name = "label1";
            label1.Size = new Size(202, 28);
            label1.TabIndex = 2;
            label1.Text = "Registrar Leitura";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(numInstalacaoTxBox);
            groupBox5.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(232, 79);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(209, 72);
            groupBox5.TabIndex = 17;
            groupBox5.TabStop = false;
            groupBox5.Text = "Número de registro";
            // 
            // numInstalacaoTxBox
            // 
            numInstalacaoTxBox.Location = new Point(6, 28);
            numInstalacaoTxBox.Name = "numInstalacaoTxBox";
            numInstalacaoTxBox.Size = new Size(165, 22);
            numInstalacaoTxBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(valorMedidoKWh);
            groupBox2.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(232, 157);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(209, 72);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Valor medido em KWh";
            // 
            // valorMedidoKWh
            // 
            valorMedidoKWh.Location = new Point(6, 28);
            valorMedidoKWh.Name = "valorMedidoKWh";
            valorMedidoKWh.Size = new Size(165, 22);
            valorMedidoKWh.TabIndex = 0;
            // 
            // registrarKWhBtn
            // 
            registrarKWhBtn.BackColor = Color.Green;
            registrarKWhBtn.FlatStyle = FlatStyle.Popup;
            registrarKWhBtn.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            registrarKWhBtn.ForeColor = SystemColors.ButtonHighlight;
            registrarKWhBtn.Location = new Point(275, 250);
            registrarKWhBtn.Name = "registrarKWhBtn";
            registrarKWhBtn.Size = new Size(112, 24);
            registrarKWhBtn.TabIndex = 19;
            registrarKWhBtn.Text = "REGISTRAR";
            registrarKWhBtn.UseVisualStyleBackColor = false;
            registrarKWhBtn.Click += registrarKWhBtn_Click;
            // 
            // LeituristaMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(187, 218, 119);
            ClientSize = new Size(660, 437);
            Controls.Add(registrarKWhBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox5);
            Controls.Add(label1);
            Name = "LeituristaMain";
            Text = "LeituristaMain";
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox groupBox5;
        private TextBox numInstalacaoTxBox;
        private GroupBox groupBox2;
        private TextBox valorMedidoKWh;
        private Button registrarKWhBtn;
    }
}