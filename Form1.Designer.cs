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
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(240, 87);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(268, 27);
            txtNome.TabIndex = 0;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(238, 174);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(270, 27);
            txtsenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 67);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 160);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(236, 240);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 5;
            label3.Text = "Permissao";
            label3.Click += label3_Click;
            // 
            // txtPemissao
            // 
            txtPemissao.Location = new Point(240, 263);
            txtPemissao.Name = "txtPemissao";
            txtPemissao.Size = new Size(268, 27);
            txtPemissao.TabIndex = 2;
            // 
            // btnAutenticar
            // 
            btnAutenticar.Location = new Point(245, 323);
            btnAutenticar.Name = "btnAutenticar";
            btnAutenticar.Size = new Size(263, 29);
            btnAutenticar.TabIndex = 6;
            btnAutenticar.Text = "button1";
            btnAutenticar.UseVisualStyleBackColor = true;
            btnAutenticar.Click += btnAutenticar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAutenticar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPemissao);
            Controls.Add(txtsenha);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Form1";
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
    }
}
