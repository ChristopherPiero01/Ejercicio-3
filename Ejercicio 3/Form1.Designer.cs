namespace Ejercicio_3
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
            parc1 = new TextBox();
            parc2 = new TextBox();
            parc3 = new TextBox();
            exaFin = new TextBox();
            traFin = new TextBox();
            button1 = new Button();
            label6 = new Label();
            NotaFinal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 49);
            label1.Name = "label1";
            label1.Size = new Size(63, 19);
            label1.TabIndex = 0;
            label1.Text = "Parcial 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 92);
            label2.Name = "label2";
            label2.Size = new Size(67, 17);
            label2.TabIndex = 1;
            label2.Text = "Parcial 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 134);
            label3.Name = "label3";
            label3.Size = new Size(63, 19);
            label3.TabIndex = 2;
            label3.Text = "Parcial 3:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(44, 182);
            label4.Name = "label4";
            label4.Size = new Size(92, 17);
            label4.TabIndex = 3;
            label4.Text = "Examen final:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(44, 228);
            label5.Name = "label5";
            label5.Size = new Size(85, 19);
            label5.TabIndex = 4;
            label5.Text = "Trabajo final:";
            // 
            // parc1
            // 
            parc1.Location = new Point(164, 48);
            parc1.Name = "parc1";
            parc1.Size = new Size(100, 23);
            parc1.TabIndex = 5;
            // 
            // parc2
            // 
            parc2.Location = new Point(164, 90);
            parc2.Name = "parc2";
            parc2.Size = new Size(100, 23);
            parc2.TabIndex = 6;
            // 
            // parc3
            // 
            parc3.Location = new Point(164, 133);
            parc3.Name = "parc3";
            parc3.Size = new Size(100, 23);
            parc3.TabIndex = 7;
            // 
            // exaFin
            // 
            exaFin.Location = new Point(164, 180);
            exaFin.Name = "exaFin";
            exaFin.Size = new Size(100, 23);
            exaFin.TabIndex = 8;
            // 
            // traFin
            // 
            traFin.Location = new Point(164, 227);
            traFin.Name = "traFin";
            traFin.Size = new Size(100, 23);
            traFin.TabIndex = 9;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(453, 206);
            button1.Name = "button1";
            button1.Size = new Size(192, 62);
            button1.TabIndex = 10;
            button1.Text = "calcular promedio";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(378, 320);
            label6.Name = "label6";
            label6.Size = new Size(143, 25);
            label6.TabIndex = 11;
            label6.Text = "Promedio Final:";
            // 
            // NotaFinal
            // 
            NotaFinal.Location = new Point(547, 325);
            NotaFinal.Name = "NotaFinal";
            NotaFinal.Size = new Size(110, 23);
            NotaFinal.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NotaFinal);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(traFin);
            Controls.Add(exaFin);
            Controls.Add(parc3);
            Controls.Add(parc2);
            Controls.Add(parc1);
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
        private TextBox parc1;
        private TextBox parc2;
        private TextBox parc3;
        private TextBox exaFin;
        private TextBox traFin;
        private Button button1;
        private Label label6;
        private TextBox NotaFinal;
    }
}