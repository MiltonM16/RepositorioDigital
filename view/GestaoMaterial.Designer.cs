namespace RepositorioDigital.view
{
    partial class GestaoMaterial
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
            dataTable = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataTable).BeginInit();
            SuspendLayout();
            // 
            // dataTable
            // 
            dataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTable.Dock = DockStyle.Bottom;
            dataTable.Location = new Point(0, 114);
            dataTable.Name = "dataTable";
            dataTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataTable.Size = new Size(841, 369);
            dataTable.TabIndex = 0;
            dataTable.CellContentClick += dataTable_CellContentClick;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(89, 85, 179);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(632, 67);
            button1.Name = "button1";
            button1.Size = new Size(150, 36);
            button1.TabIndex = 1;
            button1.Text = "Adcionar novo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.Location = new Point(70, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 74);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 3;
            label1.Text = "Filtro";
            // 
            // GestaoMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 483);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(dataTable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestaoMaterial";
            Text = "GestaoMaterial";
            Load += GestaoMaterial_Load;
            ((System.ComponentModel.ISupportInitialize)dataTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataTable;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
    }
}