﻿using ANDERSONDFM.Aplicacao.Interfaces;
using ANDERSONDFM.Aplicacao.Requests;
using Microsoft.AspNetCore.Mvc;

namespace ANDERSONDFM.API.Controllers
{
    [ApiController]
    [Route("api/produto")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoAppService _produtoAppService;

        public ProdutoController(IProdutoAppService produtoAppService)
        {
            _produtoAppService = produtoAppService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _produtoAppService.ObterTodosProdutos();

            if (result == null)
                return NoContent();

            return Ok(result);
        }


    }
}