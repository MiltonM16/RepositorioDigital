namespace RepositorioDigital.view
{
    partial class Materiais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            label3 = new Label();
            txtSupervisor = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtDepartamento = new TextBox();
            label6 = new Label();
            txtCurso = new TextBox();
            label7 = new Label();
            label9 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtResumo = new RichTextBox();
            btnPublicar = new Button();
            btnEditar = new Button();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 53);
            label1.TabIndex = 0;
            label1.Text = "Material";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "Titulo";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(12, 99);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(324, 27);
            txtTitulo.TabIndex = 2;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(382, 99);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(303, 27);
            txtAutor.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 64);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 3;
            label3.Text = "Autor";
            label3.Click += label3_Click;
            // 
            // txtSupervisor
            // 
            txtSupervisor.Location = new Point(12, 199);
            txtSupervisor.Name = "txtSupervisor";
            txtSupervisor.Size = new Size(211, 27);
            txtSupervisor.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 164);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 5;
            label4.Text = "Supervisor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(275, 164);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 7;
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(250, 199);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(211, 27);
            txtDepartamento.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(250, 164);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 9;
            label6.Text = "Departamento";
            // 
            // txtCurso
            // 
            txtCurso.Location = new Point(488, 199);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(211, 27);
            txtCurso.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(488, 164);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 11;
            label7.Text = "Curso";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 268);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 15;
            label9.Text = "Resumo";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtResumo
            // 
            txtResumo.Location = new Point(12, 301);
            txtResumo.Name = "txtResumo";
            txtResumo.Size = new Size(271, 206);
            txtResumo.TabIndex = 17;
            txtResumo.Text = "";
            // 
            // btnPublicar
            // 
            btnPublicar.Location = new Point(12, 522);
            btnPublicar.Name = "btnPublicar";
            btnPublicar.Size = new Size(94, 29);
            btnPublicar.TabIndex = 18;
            btnPublicar.Text = "Publicar";
            btnPublicar.UseVisualStyleBackColor = true;
            btnPublicar.Click += btnPublicar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(129, 522);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(367, 268);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 21;
            label8.Text = "Arquivo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_Add_properties_120px_1;
            pictureBox1.Location = new Point(367, 301);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Materiais
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 563);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(btnEditar);
            Controls.Add(btnPublicar);
            Controls.Add(txtResumo);
            Controls.Add(label9);
            Controls.Add(txtCurso);
            Controls.Add(label7);
            Controls.Add(txtDepartamento);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtSupervisor);
            Controls.Add(label4);
            Controls.Add(txtAutor);
            Controls.Add(label3);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Materiais";
            Text = "Materiais";
            Load += Materiais_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private Label label3;
        private TextBox txtSupervisor;
        private Label label4;
        private Label label5;
        private TextBox txtDepartamento;
        private Label label6;
        private TextBox txtCurso;
        private Label label7;
        private Label label9;
        private ContextMenuStrip contextMenuStrip1;
        private RichTextBox txtResumo;
        private Button btnPublicar;
        private Button btnEditar;
        private Label label8;
        private PictureBox pictureBox1;
    }
}