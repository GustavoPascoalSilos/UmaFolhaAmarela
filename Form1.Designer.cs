namespace MeuPrimeiroForms
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btnSair = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = Color.Turquoise;
            btn1.Location = new Point(206, 101);
            btn1.Name = "btn1";
            btn1.Size = new Size(146, 107);
            btn1.TabIndex = 0;
            btn1.Text = "Azul";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            btn1.MouseLeave += mudaFundo;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Yellow;
            btn2.Location = new Point(358, 101);
            btn2.Name = "btn2";
            btn2.Size = new Size(144, 111);
            btn2.TabIndex = 1;
            btn2.Text = "Amarelo";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            btn2.MouseLeave += mudaFundo;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Green;
            btn3.Location = new Point(205, 214);
            btn3.Name = "btn3";
            btn3.Size = new Size(147, 100);
            btn3.TabIndex = 2;
            btn3.Text = "Verde";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            btn3.MouseLeave += mudaFundo;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Red;
            btn4.Location = new Point(358, 218);
            btn4.Name = "btn4";
            btn4.Size = new Size(144, 96);
            btn4.TabIndex = 3;
            btn4.Text = "Vermelho";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            btn4.MouseLeave += mudaFundo;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.LightCoral;
            btnSair.Location = new Point(656, 378);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 29);
            btnSair.TabIndex = 4;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 26);
            label1.Name = "label1";
            label1.Size = new Size(308, 20);
            label1.TabIndex = 5;
            label1.Text = "ESCOLHA UMA COR, E CLIQUE NA PROXIMA ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnSair);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Uma folha amarela";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btnSair;
        private Label label1;
    }
}