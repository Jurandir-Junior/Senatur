using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.Repository;

namespace Senai.Senatur.WebApi.Controller
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PacoteController : ControllerBase
    {
        private IPacoteRepository _pacoteRepository;

        public PacoteController()
        {
            _pacoteRepository = new PacoteRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_pacoteRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_pacoteRepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Post(TblPacote novoPacote)
        {
            _pacoteRepository.Cadastrar(novoPacote);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, TblPacote pacoteAtualizado)
        {
            _pacoteRepository.Atualizar(id, pacoteAtualizado);

            return StatusCode(204);
        }

        [HttpGet("Ativo/{status}")]
        public IActionResult GetByActive(bool status)
        {
            return Ok(_pacoteRepository.ListarPorAtivo(status));
        }
    }
}