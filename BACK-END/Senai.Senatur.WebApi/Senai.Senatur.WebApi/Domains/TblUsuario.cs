using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class TblUsuario
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "O email é obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatório!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "A Chave Extrangeira é obrigatório!")]
        public int? FkIdTipoUsuario { get; set; }

        public TblTipoUsuario FkIdTipoUsuarioNavigation { get; set; }
    }
}
