namespace RepositorioDigital
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
            txtNome = new TextBox();
            txtsenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPemissao = new TextBox();
            btnAutenticar = new Button();
            panel1 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ControlLightLight;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Location = new Point(437, 94);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(268, 20);
            txtNome.TabIndex = 0;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(435, 181);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(270, 27);
            txtsenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(433, 74);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(437, 167);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(433, 247);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 5;
            label3.Text = "Permissao";
            label3.Click += label3_Click;
            // 
            // txtPemissao
            // 
            txtPemissao.Location = new Point(437, 270);
            txtPemissao.Name = "txtPemissao";
            txtPemissao.Size = new Size(268, 27);
            txtPemissao.TabIndex = 2;
            // 
            // btnAutenticar
            // 
            btnAutenticar.Location = new Point(442, 319);
            btnAutenticar.Name = "btnAutenticar";
            btnAutenticar.Size = new Size(263, 40);
            btnAutenticar.TabIndex = 6;
            btnAutenticar.Text = "button1";
            btnAutenticar.UseVisualStyleBackColor = true;
            btnAutenticar.Click += btnAutenticar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(89, 85, 179);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-2, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 463);
            panel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins SemiBold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(55, 150);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(229, 120);
            label4.TabIndex = 0;
            label4.Text = "Repositorio \r\nDigital\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 244, 254);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnAutenticar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPemissao);
            Controls.Add(txtsenha);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtsenha;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPemissao;
        private Button btnAutenticar;
        private Panel panel1;
        private Label label4;
    }
}
