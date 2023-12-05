namespace Actividad_1
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
            desicion = new Button();
            label1 = new Label();
            cal = new TextBox();
            SuspendLayout();
            // 
            // desicion
            // 
            desicion.Location = new Point(73, 196);
            desicion.Name = "desicion";
            desicion.Size = new Size(150, 47);
            desicion.TabIndex = 0;
            desicion.Text = "Decision";
            desicion.UseVisualStyleBackColor = true;
            desicion.Click += desicion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 77);
            label1.Name = "label1";
            label1.Size = new Size(199, 25);
            label1.TabIndex = 1;
            label1.Text = "Ingresa la Calificacion";
            label1.Click += label1_Click;
            // 
            // cal
            // 
            cal.Location = new Point(53, 125);
            cal.Name = "cal";
            cal.Size = new Size(186, 23);
            cal.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 267);
            Controls.Add(cal);
            Controls.Add(label1);
            Controls.Add(desicion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button desicion;
        private Label label1;
        private TextBox cal;
    }
}