using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using PdfiumViewer;
using Xceed.Words.NET;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;


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
                Filter = "Document Files|*.pdf;*.doc;*.docx",
                Title = "Selecione um arquivo PDF ou DOC"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoDoPDF = openFileDialog.FileName;

                // Carrega o documento PDF no PdfViewer
                pdfViewer.Document?.Dispose();  // Limpa o documento anterior, se houver
                pdfViewer.Document = PdfiumViewer.PdfDocument.Load(caminhoDoPDF);
            }

        }

        public void ConvertDocxToPdf(string inputFilePath, string outputFilePath)
        {
            // Carregar o documento DOCX
            using (DocX document = DocX.Load(inputFilePath))
            {
                // Criar um documento PDF
                using (PdfWriter writer = new PdfWriter(outputFilePath))
                {
                    using (iText.Kernel.Pdf.PdfDocument pdf = new iText.Kernel.Pdf.PdfDocument(writer))
                    {
                        Document pdfDoc = new Document(pdf);

                        // Iterar sobre os parágrafos no documento DOCX
                        foreach (var paragraph in document.Paragraphs)
                        {
                            // Adicionar cada parágrafo ao documento PDF
                            pdfDoc.Add(new Paragraph(paragraph.Text));
                        }

                        pdfDoc.Close();
                    }
                }
            }
        }
    }
}
