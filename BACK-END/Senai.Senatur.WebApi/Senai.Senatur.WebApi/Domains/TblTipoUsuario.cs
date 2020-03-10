using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class TblTipoUsuario
    {
        public TblTipoUsuario()
        {
            TblUsuario = new HashSet<TblUsuario>();
        }

        public int IdTipoUsuario { get; set; }

        [Required(ErrorMessage = "O Titulo do tipo usuário é obrigatório!")]
        public string TituloTipoUsuario { get; set; }

        public ICollection<TblUsuario> TblUsuario { get; set; }
    }
}
