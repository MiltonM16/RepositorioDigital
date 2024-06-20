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

namespace RepositorioDigital.view
{
    public partial class Materiais : Form
    {
        public Materiais()
        {
            InitializeComponent();
        }

        private void Materiais_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            materialModel md = new materialModel();
            MaterialDao materialDao = new MaterialDao();
            md.Titulo = txtTitulo.Text;
            md.Curso = txtCurso.Text;
            md.Resumo = txtResumo.Text;
            md.Supervisor = txtSupervisor.Text;
            md.TipoMaterial = txtTipoMaterial.Text;
            md.Autor = txtAutor.Text;
            md.Departamento = txtDepartamento.Text;

            materialDao.InserirMaterial(md);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf|Word files (*.doc;*.docx)|*.doc;*.docx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtTipoMaterial.Text = openFileDialog.FileName;
            }
        }

        private void txtTipoMaterial_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
