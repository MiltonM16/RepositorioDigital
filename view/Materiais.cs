﻿using GemBox.Document;
using PdfiumViewer;
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
using System.Windows.Controls;
using System.Windows.Forms;


namespace RepositorioDigital.view
{
    public partial class Materiais : Form
    {
        string filePath;
        private PdfViewer pdfViewer;
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

            md.Autor = txtAutor.Text;
            md.Departamento = txtDepartamento.Text;
            md.filedata = File.ReadAllBytes(filePath);
            md.filename = Path.GetFileName(filePath);
            md.filetype = Path.GetExtension(filePath);

            materialDao.InserirMaterial(md);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtTipoMaterial_TextChanged(object sender, EventArgs e)
        {

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

        private void txtCurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
