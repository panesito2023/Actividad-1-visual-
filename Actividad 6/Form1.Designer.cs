namespace Practica_6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            LadoA = new TextBox();
            LadoC = new TextBox();
            Triangulo = new TextBox();
            LadoB = new TextBox();
            pictureBox1 = new PictureBox();
            Desicion = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(16, 9);
            label1.Name = "label1";
            label1.Size = new Size(486, 15);
            label1.TabIndex = 0;
            label1.Text = "Diagrama que pide los 3 lados de un triangulo y diga si es equilatero, isosceles o escaleno";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 66);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "Longitud Lado A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 113);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 2;
            label3.Text = "Longitud Lado B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 161);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 3;
            label4.Text = "Longitud Lado C";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 245);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 4;
            label5.Text = "Tipo Triangulo";
            // 
            // LadoA
            // 
            LadoA.Location = new Point(157, 63);
            LadoA.Name = "LadoA";
            LadoA.Size = new Size(100, 23);
            LadoA.TabIndex = 5;
            // 
            // LadoC
            // 
            LadoC.Location = new Point(157, 153);
            LadoC.Name = "LadoC";
            LadoC.Size = new Size(100, 23);
            LadoC.TabIndex = 6;
            // 
            // Triangulo
            // 
            Triangulo.Location = new Point(157, 237);
            Triangulo.Name = "Triangulo";
            Triangulo.Size = new Size(100, 23);
            Triangulo.TabIndex = 7;
            // 
            // LadoB
            // 
            LadoB.Location = new Point(157, 105);
            LadoB.Name = "LadoB";
            LadoB.Size = new Size(100, 23);
            LadoB.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(279, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 252);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Desicion
            // 
            Desicion.Location = new Point(20, 198);
            Desicion.Name = "Desicion";
            Desicion.Size = new Size(75, 23);
            Desicion.TabIndex = 10;
            Desicion.Text = "Decision";
            Desicion.UseVisualStyleBackColor = true;
            Desicion.Click += Desicion_Click;
            // 
            // button2
            // 
            button2.Location = new Point(101, 198);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(182, 198);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 300);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Desicion);
            Controls.Add(pictureBox1);
            Controls.Add(LadoB);
            Controls.Add(Triangulo);
            Controls.Add(LadoC);
            Controls.Add(LadoA);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox LadoA;
        private TextBox LadoC;
        private TextBox Triangulo;
        private TextBox LadoB;
        private PictureBox pictureBox1;
        private Button Desicion;
        private Button button2;
        private Button button3;
    }
}