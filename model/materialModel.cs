using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioDigital.model
{
    internal class materialModel
    {
        public int id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Resumo { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string TipoMaterial { get; set; }
        public string Curso { get; set; }
        public string Departamento { get; set; }
        public string Supervisor { get; set; }
    }
}
