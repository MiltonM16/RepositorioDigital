using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Doc;
using System.IO;
using System.Drawing.Imaging;
using Microsoft.Web.WebView2.WinForms;
using sun.swing;
using System.Diagnostics;

namespace RepositorioDigital.view
{
    public partial class Dashboard : Form
    {
        private WebView2 webView;
        public Dashboard()
        {
            InitializeComponent();

          
        }

       

        private async void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Document Files|*.pdf;*.doc;*.docx",
                Title = "Selecione um arquivo PDF ou DOC"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoDoDocumento = openFileDialog.FileName;

                // Renderizar o documento no WebView2
                await RenderizarDocumentoAsync(caminhoDoDocumento);


            }


        }

            public async Task RenderizarDocumentoAsync(string caminhoDoDocumento)
        {
            try
            {
                // Inicia o processo para abrir o documento com o aplicativo padrão
                Process.Start(new ProcessStartInfo(caminhoDoDocumento) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o documento: " + ex.Message);
            }



        }

    }
}
