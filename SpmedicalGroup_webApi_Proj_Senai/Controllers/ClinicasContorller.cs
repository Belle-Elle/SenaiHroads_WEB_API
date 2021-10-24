﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using SpmedicalGroup_webApi_Proj_Senai.Domains;
using SpmedicalGroup_webApi_Proj_Senai.Interfaces;
using SpmedicalGroup_webApi_Proj_Senai.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroup_webApi_Proj_Senai.Controllers
{
    public class ClinicasContorller
    {

        [Route("api/[controller]")]
        [ApiController]
        [Authorize(Roles = "1")]
        public class ClinicasController : ControllerBase
        {
            private IClinicaRepository _clinicaRepository { get; set; }

            public ClinicasController()
            {

                _clinicaRepository = new ClinicaRepository();
            }

        }

        [HttpGet]
        public IActionResult ListarTodas()
        {
            try
            {
                if (_clinicaRepository.ListarTodas() == null)
                {
                    return NotFound(new
                    {
                        Mensagem = "Não existe nenhuma clínica cadastrada."
                    });
                }

                return Ok(_clinicaRepository.ListarTodas());
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }


        [HttpGet("{idClinica}")]
        public IActionResult BuscarPorId(int idClinica)
        {
            try
            {
                return Ok(_clinicaRepository.BuscarPorId(idClinica));
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(Clinica novaClinica)
        {
            try
            {
                if (novaClinica == null)
                {
                    return BadRequest(new
                    {
                        Mensagem = "Todos dados são obrigatórios"
                    });
                }

                _clinicaRepository.Cadastrar(novaClinica);

                return StatusCode(201);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        [HttpPut]
        public IActionResult Atualizar(Clinica clinicaAtualizada)
        {
            try
            {
                if (_clinicaRepository.BuscarPorId(clinicaAtualizada.IdClinica) == null)
                {
                    return BadRequest(new
                    {
                        mensagem = "Não foi encontrada nenhuma clinica com o id informado."
                    });
                }

                _clinicaRepository.Atualizar(clinicaAtualizada);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        [HttpDelete("{idClinica}")]
        public IActionResult Deletar(int idClinica)
        {
            try
            {
                if (_clinicaRepository.BuscarPorId(idClinica) == null)
                {
                    return BadRequest(new
                    {
                        mensagem = "Não foi encontrada nenhuma clinica com o id informado."
                    });
                }

                if (idClinica <= 0)
                {
                    return BadRequest(new
                    {
                        mensagem = "Por favor, insira um id válido."
                    });
                }
                _clinicaRepository.Deletar(idClinica);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }
    }
}
