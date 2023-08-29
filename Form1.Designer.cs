namespace Ejercicio09_ventana
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtnum1 = new TextBox();
            txtnum2 = new TextBox();
            txtnum3 = new TextBox();
            lblResult = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(139, 21);
            label1.Name = "label1";
            label1.Size = new Size(210, 28);
            label1.TabIndex = 0;
            label1.Text = "Inserte 3 numeros enteros:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 61);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 1;
            label2.Text = "N1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 88);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 2;
            label3.Text = "N2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 113);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 3;
            label4.Text = "N3:";
            // 
            // txtnum1
            // 
            txtnum1.Location = new Point(208, 53);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(100, 23);
            txtnum1.TabIndex = 4;
            // 
            // txtnum2
            // 
            txtnum2.Location = new Point(208, 80);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(100, 23);
            txtnum2.TabIndex = 5;
            // 
            // txtnum3
            // 
            txtnum3.Location = new Point(208, 109);
            txtnum3.Name = "txtnum3";
            txtnum3.Size = new Size(100, 23);
            txtnum3.TabIndex = 6;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(157, 184);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(76, 15);
            lblResult.TabIndex = 7;
            lblResult.Text = "El mayor es...";
            // 
            // button1
            // 
            button1.Location = new Point(184, 150);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 292);
            Controls.Add(button1);
            Controls.Add(lblResult);
            Controls.Add(txtnum3);
            Controls.Add(txtnum2);
            Controls.Add(txtnum1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtnum1;
        private TextBox txtnum2;
        private TextBox txtnum3;
        private Label lblResult;
        private Button button1;
    }
}