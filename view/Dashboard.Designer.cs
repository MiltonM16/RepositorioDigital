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
            pdfPanel = new Panel();
            button1 = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            pdfPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // pdfPanel
            // 
            pdfPanel.BackColor = SystemColors.ActiveCaption;
            pdfPanel.Controls.Add(webView21);
            pdfPanel.Dock = DockStyle.Top;
            pdfPanel.Location = new Point(0, 0);
            pdfPanel.Name = "pdfPanel";
            pdfPanel.Size = new Size(800, 464);
            pdfPanel.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(167, 470);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(0, 0);
            webView21.Name = "webView21";
            webView21.Size = new Size(800, 464);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 511);
            Controls.Add(button1);
            Controls.Add(pdfPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            pdfPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pdfPanel;
        private Button button1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}