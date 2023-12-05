namespace Actividad_5._1
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
            Num1 = new TextBox();
            Num3 = new TextBox();
            NumC = new TextBox();
            Num2 = new TextBox();
            NumB = new TextBox();
            NumA = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            orden = new Button();
            clean = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 15);
            label1.TabIndex = 0;
            label1.Text = "Ordenar 3 numeros de mayor a menor";
            // 
            // Num1
            // 
            Num1.Location = new Point(52, 69);
            Num1.Name = "Num1";
            Num1.Size = new Size(58, 23);
            Num1.TabIndex = 1;
            // 
            // Num3
            // 
            Num3.Location = new Point(224, 69);
            Num3.Name = "Num3";
            Num3.Size = new Size(58, 23);
            Num3.TabIndex = 2;
            // 
            // NumC
            // 
            NumC.Location = new Point(224, 198);
            NumC.Name = "NumC";
            NumC.Size = new Size(58, 23);
            NumC.TabIndex = 3;
            // 
            // Num2
            // 
            Num2.Location = new Point(139, 69);
            Num2.Name = "Num2";
            Num2.Size = new Size(58, 23);
            Num2.TabIndex = 4;
            // 
            // NumB
            // 
            NumB.Location = new Point(139, 198);
            NumB.Name = "NumB";
            NumB.Size = new Size(58, 23);
            NumB.TabIndex = 5;
            // 
            // NumA
            // 
            NumA.Location = new Point(52, 198);
            NumA.Name = "NumA";
            NumA.Size = new Size(58, 23);
            NumA.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 95);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 7;
            label2.Text = "A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 95);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 8;
            label3.Text = "B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(247, 95);
            label4.Name = "label4";
            label4.Size = new Size(15, 15);
            label4.TabIndex = 9;
            label4.Text = "C";
            // 
            // orden
            // 
            orden.Location = new Point(35, 148);
            orden.Name = "orden";
            orden.Size = new Size(75, 23);
            orden.TabIndex = 10;
            orden.Text = "Ordenar";
            orden.UseVisualStyleBackColor = true;
            orden.Click += orden_Click;
            // 
            // clean
            // 
            clean.Location = new Point(122, 148);
            clean.Name = "clean";
            clean.Size = new Size(75, 23);
            clean.TabIndex = 11;
            clean.Text = "Borrar";
            clean.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            exit.Location = new Point(207, 148);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 12;
            exit.Text = "Salir";
            exit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 247);
            Controls.Add(exit);
            Controls.Add(clean);
            Controls.Add(orden);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NumA);
            Controls.Add(NumB);
            Controls.Add(Num2);
            Controls.Add(NumC);
            Controls.Add(Num3);
            Controls.Add(Num1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Num1;
        private TextBox Num3;
        private TextBox NumC;
        private TextBox Num2;
        private TextBox NumB;
        private TextBox NumA;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button orden;
        private Button clean;
        private Button exit;
    }
}