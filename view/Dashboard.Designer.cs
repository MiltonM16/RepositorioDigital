namespace RepositorioDigital.view
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            label1 = new Label();
            cbTitulo = new ComboBox();
            cbAutor = new ComboBox();
            cbData = new ComboBox();
            cbSupervisor = new ComboBox();
            cbCurso = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            dataTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 36);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // cbTitulo
            // 
            cbTitulo.BackColor = Color.FromArgb(89, 85, 179);
            cbTitulo.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbTitulo.ForeColor = Color.White;
            cbTitulo.FormattingEnabled = true;
            cbTitulo.Location = new Point(59, 285);
            cbTitulo.Name = "cbTitulo";
            cbTitulo.Size = new Size(214, 38);
            cbTitulo.TabIndex = 1;
            cbTitulo.Text = "Titulo";
            // 
            // cbAutor
            // 
            cbAutor.BackColor = Color.FromArgb(89, 85, 179);
            cbAutor.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbAutor.ForeColor = Color.White;
            cbAutor.FormattingEnabled = true;
            cbAutor.Location = new Point(278, 285);
            cbAutor.Name = "cbAutor";
            cbAutor.Size = new Size(214, 38);
            cbAutor.TabIndex = 2;
            cbAutor.Text = "Autor";
            // 
            // cbData
            // 
            cbData.BackColor = Color.FromArgb(89, 85, 179);
            cbData.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbData.ForeColor = Color.White;
            cbData.FormattingEnabled = true;
            cbData.Location = new Point(499, 285);
            cbData.Name = "cbData";
            cbData.Size = new Size(214, 38);
            cbData.TabIndex = 3;
            cbData.Text = "Data de Publicacao";
            // 
            // cbSupervisor
            // 
            cbSupervisor.BackColor = Color.FromArgb(89, 85, 179);
            cbSupervisor.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbSupervisor.ForeColor = Color.White;
            cbSupervisor.FormattingEnabled = true;
            cbSupervisor.Location = new Point(278, 344);
            cbSupervisor.Name = "cbSupervisor";
            cbSupervisor.Size = new Size(435, 38);
            cbSupervisor.TabIndex = 5;
            cbSupervisor.Text = "Supervisor";
            // 
            // cbCurso
            // 
            cbCurso.BackColor = Color.FromArgb(89, 85, 179);
            cbCurso.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbCurso.ForeColor = Color.White;
            cbCurso.FormattingEnabled = true;
            cbCurso.Location = new Point(59, 344);
            cbCurso.Name = "cbCurso";
            cbCurso.Size = new Size(214, 38);
            cbCurso.TabIndex = 4;
            cbCurso.Text = "Curso";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(59, 220);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(615, 33);
            textBox1.TabIndex = 7;
            textBox1.Text = "Filtrar";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins ExtraBold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(142, 104);
            label2.Name = "label2";
            label2.Size = new Size(381, 65);
            label2.TabIndex = 8;
            label2.Text = "Repositorio Digital";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(529, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 99);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(680, 220);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 29);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // dataTable
            // 
            dataTable.Anchor = AnchorStyles.Top;
            dataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTable.Location = new Point(0, 388);
            dataTable.Name = "dataTable";
            dataTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataTable.Size = new Size(800, 123);
            dataTable.TabIndex = 11;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 511);
            Controls.Add(dataTable);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(cbSupervisor);
            Controls.Add(cbCurso);
            Controls.Add(cbData);
            Controls.Add(cbAutor);
            Controls.Add(cbTitulo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbTitulo;
        private ComboBox cbAutor;
        private ComboBox cbData;
        private ComboBox cbSupervisor;
        private ComboBox cbCurso;
        private TextBox textBox1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView dataTable;
    }
}