using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repository
{
    public class PacoteRepository : IPacoteRepository
    {
        SenaturContext ctx = new SenaturContext();

        public void Atualizar(int id, TblPacote pacoteAtualizado)
        {
            TblPacote pacoteBuscado = ctx.TblPacote.Find(id);

            pacoteBuscado.NomePacote = pacoteAtualizado.NomePacote;
            pacoteBuscado.Descricao = pacoteAtualizado.Descricao;
            pacoteBuscado.DataIda = pacoteAtualizado.DataIda;
            pacoteBuscado.DataVolta = pacoteAtualizado.DataVolta;
            pacoteBuscado.Valor = pacoteAtualizado.Valor;
            pacoteBuscado.Ativo = pacoteAtualizado.Ativo;
            pacoteBuscado.NomeCidade = pacoteAtualizado.NomeCidade;

            ctx.TblPacote.Update(pacoteBuscado);

            ctx.SaveChanges();
        }

        public TblPacote BuscarPorId(int id)
        {
            return ctx.TblPacote.FirstOrDefault(p => p.IdPacote == id);
        }

        public void Cadastrar(TblPacote novoPacote)
        {
            ctx.TblPacote.Add(novoPacote);

            ctx.SaveChanges();
        }

        public List<TblPacote> Listar()
        {
            return ctx.TblPacote.ToList();
        }

        public List<TblPacote> ListarPorAtivo(bool status)
        {
            return ctx.TblPacote.ToList().FindAll(p => p.Ativo == status);
        }
    }
}
