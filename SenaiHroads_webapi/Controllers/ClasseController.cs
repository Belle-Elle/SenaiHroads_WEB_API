﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SenaiHroads_webapi.Domains;
using SenaiHroads_webapi.Interfaces;
using SenaiHroads_webapi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiHroads_webapi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClasseController : ControllerBase
    {

        private IClasseRepository _classeRepository { get; set; }

        public ClasseController()
        {
            _classeRepository = new ClasseRepository();
        }


        /// <summary>
        /// Lista todas as classes
        /// </summary>
        /// <returns>Status code Ok</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_classeRepository.Listar());
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
                throw;
            }
        }

        [HttpGet("get/all")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_classeRepository.ListarAll());
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
                throw;
            }
        }

        [HttpGet("{idClasse}")]
        public IActionResult GetById(int idClasse)
        {
            try
            {
                Classe classeBuscado = _classeRepository.BuscarPorId(idClasse);

                if (classeBuscado == null)
                {
                    return NotFound(
                            new
                            {
                                mensagem = "Classe não encontrada",
                                erro = true
                            }
                        );
                }
                return Ok(classeBuscado);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Classe novaClasse)
        {
            try
            {
                _classeRepository.Cadastrar(novaClasse);

                return StatusCode(201);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [Authorize(Roles = "1")]
        [HttpPut("{idClasse}")]
        public IActionResult UpdateByUrl(int idClasse, Classe classeAtualizada)
        {
            try
            {
                _classeRepository.Atualizar(idClasse, classeAtualizada);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }

        }

        [Authorize(Roles = "1")]
        [HttpDelete("{idClasse}")]
        public IActionResult Delete(int idClasse)
        {
            try
            {
                _classeRepository.Deletar(idClasse);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }
    }

}
