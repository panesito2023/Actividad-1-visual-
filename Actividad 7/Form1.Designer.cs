namespace Practica_7
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
            label5 = new Label();
            Cam1 = new TextBox();
            Cam2 = new TextBox();
            Cam3 = new TextBox();
            Cam4 = new TextBox();
            comprobar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(87, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "Calificaciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(54, 68);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Calificacion 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(54, 97);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 2;
            label3.Text = "Calificacion 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(54, 126);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "Calificacion 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(54, 155);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 4;
            label5.Text = "Calificacion 4";
            // 
            // Cam1
            // 
            Cam1.Location = new Point(162, 60);
            Cam1.Name = "Cam1";
            Cam1.Size = new Size(100, 23);
            Cam1.TabIndex = 5;
            // 
            // Cam2
            // 
            Cam2.Location = new Point(162, 89);
            Cam2.Name = "Cam2";
            Cam2.Size = new Size(100, 23);
            Cam2.TabIndex = 6;
            // 
            // Cam3
            // 
            Cam3.Location = new Point(162, 118);
            Cam3.Name = "Cam3";
            Cam3.Size = new Size(100, 23);
            Cam3.TabIndex = 7;
            // 
            // Cam4
            // 
            Cam4.Location = new Point(162, 147);
            Cam4.Name = "Cam4";
            Cam4.Size = new Size(100, 23);
            Cam4.TabIndex = 8;
            // 
            // comprobar
            // 
            comprobar.AutoSize = true;
            comprobar.BackColor = Color.White;
            comprobar.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            comprobar.Location = new Point(96, 209);
            comprobar.Name = "comprobar";
            comprobar.Size = new Size(101, 29);
            comprobar.TabIndex = 9;
            comprobar.Text = "Resultado";
            comprobar.UseVisualStyleBackColor = false;
            comprobar.Click += comprobar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(302, 263);
            Controls.Add(comprobar);
            Controls.Add(Cam4);
            Controls.Add(Cam3);
            Controls.Add(Cam2);
            Controls.Add(Cam1);
            Controls.Add(label5);
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
        private Label label5;
        private TextBox Cam1;
        private TextBox Cam2;
        private TextBox Cam3;
        private TextBox Cam4;
        private Button comprobar;
    }
}