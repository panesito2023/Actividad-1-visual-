namespace Actividad_3
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
            ActSueldo = new TextBox();
            NewSueldo = new TextBox();
            Calcular = new Button();
            Borrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(304, 82);
            label1.TabIndex = 0;
            label1.Text = "Dado como dato el sueldo de un trabajador, el programa aplica un aumento del 15% sie el sueldo es inferior a 400000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 125);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingresa Sueldo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(50, 268);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Nuevo Saldo";
            // 
            // ActSueldo
            // 
            ActSueldo.Location = new Point(203, 125);
            ActSueldo.Name = "ActSueldo";
            ActSueldo.Size = new Size(100, 23);
            ActSueldo.TabIndex = 3;
            // 
            // NewSueldo
            // 
            NewSueldo.Location = new Point(203, 268);
            NewSueldo.Name = "NewSueldo";
            NewSueldo.Size = new Size(100, 23);
            NewSueldo.TabIndex = 4;
            // 
            // Calcular
            // 
            Calcular.AutoSize = true;
            Calcular.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Calcular.Location = new Point(50, 196);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(77, 31);
            Calcular.TabIndex = 5;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Borrar
            // 
            Borrar.AutoSize = true;
            Borrar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Borrar.Location = new Point(228, 196);
            Borrar.Name = "Borrar";
            Borrar.Size = new Size(75, 30);
            Borrar.TabIndex = 6;
            Borrar.Text = "Borrar";
            Borrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 339);
            Controls.Add(Borrar);
            Controls.Add(Calcular);
            Controls.Add(NewSueldo);
            Controls.Add(ActSueldo);
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
        private TextBox ActSueldo;
        private TextBox NewSueldo;
        private Button Calcular;
        private Button Borrar;
    }
}