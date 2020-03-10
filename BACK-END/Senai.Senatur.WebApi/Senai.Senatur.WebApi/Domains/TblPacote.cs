using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class TblPacote
    {
       
        public int IdPacote { get; set; }

        [Required(ErrorMessage = "O nome do pacote é obrigatório!")]
        public string NomePacote { get; set; }

        [Required(ErrorMessage = "A Descricao é obrigatório!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "A data de ida é obrigatório!")]
        public DateTime DataIda { get; set; }

        [Required(ErrorMessage = "O data de volta é obrigatório!")]
        public DateTime DataVolta { get; set; }

        [Required(ErrorMessage = "O valor é obrigatório!")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "O Ativo é obrigatório!")]
        public bool Ativo { get; set; }

        [Required(ErrorMessage = "O nome da cidade é obrigatório!")]
        public string NomeCidade { get; set; }
    }
}
