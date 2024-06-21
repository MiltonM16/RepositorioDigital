namespace RepositorioDigital.view
{
    partial class dash
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
            sidePanel = new Panel();
            button2 = new Button();
            button1 = new Button();
            mainDash = new Button();
            userInfoPanel = new Panel();
            mainPanel = new Panel();
            sidePanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(87, 83, 178);
            sidePanel.Controls.Add(button2);
            sidePanel.Controls.Add(button1);
            sidePanel.Controls.Add(mainDash);
            sidePanel.Controls.Add(userInfoPanel);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(250, 626);
            sidePanel.TabIndex = 0;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 252);
            button2.Name = "button2";
            button2.Size = new Size(250, 67);
            button2.TabIndex = 3;
            button2.Text = "VisuaIizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 189);
            button1.Name = "button1";
            button1.Size = new Size(250, 63);
            button1.TabIndex = 2;
            button1.Text = "Materiais";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // mainDash
            // 
            mainDash.AllowDrop = true;
            mainDash.BackColor = Color.FromArgb(89, 85, 175);
            mainDash.Dock = DockStyle.Top;
            mainDash.FlatStyle = FlatStyle.Popup;
            mainDash.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainDash.ForeColor = Color.White;
            mainDash.ImageAlign = ContentAlignment.MiddleLeft;
            mainDash.Location = new Point(0, 115);
            mainDash.Name = "mainDash";
            mainDash.Size = new Size(250, 74);
            mainDash.TabIndex = 1;
            mainDash.Text = "Dashboard";
            mainDash.UseVisualStyleBackColor = false;
            mainDash.Click += mainDash_Click;
            // 
            // userInfoPanel
            // 
            userInfoPanel.BackColor = Color.WhiteSmoke;
            userInfoPanel.Dock = DockStyle.Top;
            userInfoPanel.Location = new Point(0, 0);
            userInfoPanel.Name = "userInfoPanel";
            userInfoPanel.Size = new Size(250, 115);
            userInfoPanel.TabIndex = 0;
            userInfoPanel.Paint += panel1_Paint;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(236, 240, 239);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(250, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(881, 626);
            mainPanel.TabIndex = 1;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // dash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 626);
            Controls.Add(mainPanel);
            Controls.Add(sidePanel);
            Name = "dash";
            Text = "dash";
            Load += dash_Load;
            sidePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Panel mainPanel;
        private Panel userInfoPanel;
        private Button mainDash;
        private Button button1;
        private Button button2;
    }
}