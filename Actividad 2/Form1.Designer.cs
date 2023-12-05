namespace Actividad_2
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
            option = new Button();
            delete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(286, 90);
            label1.TabIndex = 0;
            label1.Text = "Dado como dato el sueldo de un trabajador, el programa aplica un aumento del 15% si esl sueldo es inferior a 400000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 134);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingresar Sueldo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 235);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 2;
            label3.Text = "Nuevo Sueldo";
            // 
            // ActSueldo
            // 
            ActSueldo.Location = new Point(172, 131);
            ActSueldo.Name = "ActSueldo";
            ActSueldo.Size = new Size(100, 23);
            ActSueldo.TabIndex = 3;
            // 
            // NewSueldo
            // 
            NewSueldo.Location = new Point(172, 227);
            NewSueldo.Name = "NewSueldo";
            NewSueldo.Size = new Size(100, 23);
            NewSueldo.TabIndex = 4;
            // 
            // option
            // 
            option.Location = new Point(36, 180);
            option.Name = "option";
            option.Size = new Size(75, 23);
            option.TabIndex = 5;
            option.Text = "Decision";
            option.UseVisualStyleBackColor = true;
            option.Click += option_Click;
            // 
            // delete
            // 
            delete.Location = new Point(197, 180);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 6;
            delete.Text = "Borrar";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 293);
            Controls.Add(delete);
            Controls.Add(option);
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
        private Button option;
        private Button delete;
    }
}