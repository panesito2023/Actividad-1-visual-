namespace Actividad_4
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
            num = new TextBox();
            determinar = new Button();
            clean = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(98, 9);
            label1.Name = "label1";
            label1.Size = new Size(254, 25);
            label1.TabIndex = 0;
            label1.Text = "Dado como dato un numero";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(98, 53);
            label2.Name = "label2";
            label2.Size = new Size(262, 52);
            label2.TabIndex = 1;
            label2.Text = "Determinar si es par o impar y divisible por 3";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 149);
            label3.Name = "label3";
            label3.Size = new Size(226, 21);
            label3.TabIndex = 2;
            label3.Text = "Ingresa un numero cualquiera";
            // 
            // num
            // 
            num.Location = new Point(260, 147);
            num.Name = "num";
            num.Size = new Size(118, 23);
            num.TabIndex = 3;
            // 
            // determinar
            // 
            determinar.Location = new Point(98, 213);
            determinar.Name = "determinar";
            determinar.Size = new Size(75, 23);
            determinar.TabIndex = 4;
            determinar.Text = "Determinar";
            determinar.UseVisualStyleBackColor = true;
            determinar.Click += determinar_Click;
            // 
            // clean
            // 
            clean.Location = new Point(285, 213);
            clean.Name = "clean";
            clean.Size = new Size(75, 23);
            clean.TabIndex = 5;
            clean.Text = "Borrar";
            clean.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 264);
            Controls.Add(clean);
            Controls.Add(determinar);
            Controls.Add(num);
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
        private TextBox num;
        private Button determinar;
        private Button clean;
    }
}