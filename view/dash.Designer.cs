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
            button1 = new Button();
            mainDash = new Button();
            userInfoPanel = new Panel();
            mainPanel = new Panel();
            sidePanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(64, 64, 64);
            sidePanel.Controls.Add(button1);
            sidePanel.Controls.Add(mainDash);
            sidePanel.Controls.Add(userInfoPanel);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(250, 626);
            sidePanel.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 144);
            button1.Name = "button1";
            button1.Size = new Size(250, 29);
            button1.TabIndex = 2;
            button1.Text = "Materiais";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // mainDash
            // 
            mainDash.Dock = DockStyle.Top;
            mainDash.Location = new Point(0, 115);
            mainDash.Name = "mainDash";
            mainDash.Size = new Size(250, 29);
            mainDash.TabIndex = 1;
            mainDash.Text = "dashBoard";
            mainDash.UseVisualStyleBackColor = true;
            mainDash.Click += mainDash_Click;
            // 
            // userInfoPanel
            // 
            userInfoPanel.BackColor = Color.Gray;
            userInfoPanel.Dock = DockStyle.Top;
            userInfoPanel.Location = new Point(0, 0);
            userInfoPanel.Name = "userInfoPanel";
            userInfoPanel.Size = new Size(250, 115);
            userInfoPanel.TabIndex = 0;
            userInfoPanel.Paint += panel1_Paint;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(250, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(881, 626);
            mainPanel.TabIndex = 1;
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
    }
}