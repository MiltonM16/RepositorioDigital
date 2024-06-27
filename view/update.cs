using RepositorioDigital.controller;
using RepositorioDigital.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace RepositorioDigital.view
{
    public partial class update : Form
    {
        string filePath;
        int idupdate;
        public update(int id)
        {
            InitializeComponent();

            idupdate = id;

            // MessageBox.Show(id.ToString());
            GetData(id);
        }

        private void GetData(int id)
        {
            MaterialDao materialDao = new MaterialDao();
            materialModel material = materialDao.ObterMaterialPorId(id);

            if (material != null)
            {
                txtTitulo.Text = material.Titulo;
                txtCurso.Text = material.Curso;
                txtResumo.Text = material.Resumo;
                txtSupervisor.Text = material.Supervisor;
                txtAutor.Text = material.Autor;
                txtDepartamento.Text = material.Departamento;
                filePath = material.filename;
                lblCaminho.Text = material.filename;

                if (material.filename != null)
                {
                    filePath = material.filename; // Armazena o nome do arquivo, você pode ajustar conforme necessário
                                                  // Se você precisar exibir o arquivo em algum controle específico, pode adicionar essa lógica aqui
                }
            }
            else
            {
                MessageBox.Show("Material não encontrado.");
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf|Word files (*.doc;*.docx)|*.doc;*.docx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                lblCaminho.Text = Path.GetFileName(filePath);
            }
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {

            materialModel md = new materialModel();
            MaterialDao materialDao = new MaterialDao();
            md.Titulo = txtTitulo.Text;
            md.Curso = txtCurso.Text;
            md.Resumo = txtResumo.Text;
            md.Supervisor = txtSupervisor.Text;
            md.Autor = txtAutor.Text;
            md.Departamento = txtDepartamento.Text;

            if (!string.IsNullOrEmpty(filePath))
            {
                md.filedata = File.ReadAllBytes(filePath);
                md.filename = Path.GetFileName(filePath);
                md.filetype = Path.GetExtension(filePath);
                md.id = idupdate;

                materialDao.AtualizarMaterial(md);
            }
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
