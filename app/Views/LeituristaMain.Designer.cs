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
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            button1 = new Button();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(229, 18);
            label1.Name = "label1";
            label1.Size = new Size(203, 32);
            label1.TabIndex = 2;
            label1.Text = "Registrar Leitura";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox2);
            groupBox5.Location = new Point(232, 79);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(209, 72);
            groupBox5.TabIndex = 17;
            groupBox5.TabStop = false;
            groupBox5.Text = "Número de registro";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(232, 157);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(209, 72);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Valor medido em KWh";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(275, 250);
            button1.Name = "button1";
            button1.Size = new Size(112, 24);
            button1.TabIndex = 19;
            button1.Text = "REGISTRAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // LeituristaMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 437);
            Controls.Add(button1);
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
        private TextBox textBox2;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Button button1;
    }
}