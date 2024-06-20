using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;

namespace RepositorioDigital.view
{
    public partial class Dashboard : Form
    {
        private PdfViewer pdfViewer;
        public Dashboard()
        {
            InitializeComponent();
            // Inicializa o PdfViewer
            pdfViewer = new PdfViewer();
            pdfViewer.Dock = DockStyle.Fill;

            // Adiciona o PdfViewer ao Panel
            pdfPanel.Controls.Add(pdfViewer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Selecione um arquivo PDF"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoDoPDF = openFileDialog.FileName;

                // Carrega o documento PDF no PdfViewer
                pdfViewer.Document?.Dispose();  // Limpa o documento anterior, se houver
                pdfViewer.Document = PdfDocument.Load(caminhoDoPDF);
            }

        }
    }
}
