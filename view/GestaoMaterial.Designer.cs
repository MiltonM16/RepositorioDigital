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
            button2 = new Button();
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
            button1.Location = new Point(553, 79);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Inserir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(672, 79);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // GestaoMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 483);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataTable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestaoMaterial";
            Text = "GestaoMaterial";
            Load += GestaoMaterial_Load;
            ((System.ComponentModel.ISupportInitialize)dataTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataTable;
        private Button button1;
        private Button button2;
    }
}