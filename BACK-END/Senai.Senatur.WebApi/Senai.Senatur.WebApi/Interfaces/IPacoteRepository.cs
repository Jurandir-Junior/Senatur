using Senai.Senatur.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Interfaces
{
    interface IPacoteRepository
    {
        List<TblPacote> Listar();

        TblPacote BuscarPorId(int id);

        void Cadastrar(TblPacote novoPacote);

        void Atualizar(int id, TblPacote pacoteAtualizado);

        List<TblPacote> ListarPorAtivo(bool status);
    }
}
