﻿using System.Threading.Tasks;
using Blog_Pessoal.src.dtos;
using Blog_Pessoal.src.modelos;
using Blog_Pessoal.src.repositorios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Pessoal.src.controladores
{
    [ApiController]
    [Route("api/Postagens")]
    [Produces("application/json")]
    public class PostagemControlador : ControllerBase
    {
        #region Atributos

        private readonly IPostagem _repositorio;

        #endregion


        #region Construtores

        public PostagemControlador(IPostagem repositorio)
        {
            _repositorio = repositorio;
        }

        #endregion


        #region Métodos

        /// <summary>
        /// Pegar todas postagens
        /// </summary>
        /// <returns>ActionResult</returns>
        /// <response code="200">Lista de postagens</response>
        /// <response code="204">Lista vasia</response>
        [HttpGet]
        [Authorize]
        public async Task<ActionResult> PegarTodasPostagensAsync()
        {
            var lista = await _repositorio.PegarTodasPostagensAsync();

            if (lista.Count < 1) return NoContent();

            return Ok(lista);
        }

        /// <summary>
        /// Pegar postagem pelo Id
        /// </summary>
        /// <param name="idPostagem">int</param>
        /// <returns>ActionResult</returns>
        /// <response code="200">Retorna a postagem</response>
        /// <response code="404">Postagem não existente</response>
        [HttpGet("id/{idPostagem}")]
        [Authorize]
        public async Task<ActionResult> PegarPostagemPeloIdAsync([FromRoute] int idPostagem)
        {
            var postagem = await _repositorio.PegarPostagemPeloIdAsync(idPostagem);

            if (postagem == null) return NotFound();

            return Ok(postagem);
        }

        /// <summary>
        /// Pegar postagens por Pesquisa
        /// </summary>
        /// <param name="tituloPostagem">string</param>
        /// <param name="descricaoTema">string</param>
        /// <param name="emailCriador">string</param>
        /// <returns>ActionResult</returns>
        /// <response code="200">Retorna postagens</response>
        /// <response code="204">Postagns não existe pra essa pesquisa</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TemaModelo))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpGet("pesquisa")]
        [Authorize]
        public async Task<ActionResult> PegarPostagensPorPesquisaAsync(
            [FromQuery] string tituloPostagem,
            [FromQuery] string descricaoTema,
            [FromQuery] string emailCriador)
        {
            var postagens = await _repositorio.PegarPostagensPorPesquisaAsync(tituloPostagem, descricaoTema, emailCriador);

            if (postagens.Count < 1) return NoContent();

            return Ok(postagens);
        }

        /// <summary>
        /// Criar nova Postagem
        /// </summary>
        /// <param name="postagem">NovaPostagemDTO</param>
        /// <returns>ActionResult</returns>
        /// <remarks>
        /// Exemplo de requisição:
        ///
        ///     POST /api/Postagens
        ///     {  
        ///        "titulo": "Vagas para dev jr .NET, 
        ///        "descricao": "Vaga para desenvolvedor junior buscando a primeira oportunidade",
        ///        "foto": "URLDAIMAGEM",
        ///        "emailCriador": "techrecruiter@mecontrata.com ",
        ///        "descricaoTema": "Vagas .NET"
        ///     }
        ///
        /// </remarks>
        /// <response code="201">Retorna postagem criada</response>
        /// <response code="400">Erro na requisição</response>
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(PostagemModelo))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> NovaPostagemAsync([FromBody] NovaPostagemDTO postagem)
        {
            if (!ModelState.IsValid) return BadRequest();

            await _repositorio.NovaPostagemAsync(postagem);

            return Created($"api/Postagens", postagem);
        }

        /// <summary>
        /// Atualizar Postagem
        /// </summary>
        /// <param name="postagem">AtualizarPostagemDTO</param>
        /// <returns>ActionResult</returns>
        /// <remarks>
        /// Exemplo de requisição:
        ///
        ///     PUT /api/Postagens
        ///     {
        ///        "id": 1,   
        ///        "titulo": "Como mudar a vida de um Junior", 
        ///        "descricao": "Os seniors de amanha, são os juniors de hoje, deu uma oportunidade ",
        ///        "foto": "URLDAIMAGEM",
        ///        "descricaoTema": "Vagas .NET"
        ///     }
        ///
        /// </remarks>
        /// <response code="200">Retorna postagem atualizada</response>
        /// <response code="400">Erro na requisição</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PostagemModelo))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Authorize]
        public async Task<ActionResult> AtualizarPostagemAsync([FromBody] AtualizarPostagemDTO postagem)
        {
            if (!ModelState.IsValid) return BadRequest();

            await _repositorio.AtualizarPostagemAsync(postagem);

            return Ok(postagem);
        }

        /// <summary>
        /// Deletar postagem pelo Id
        /// </summary>
        /// <param name="idPostagem">int</param>
        /// <returns>ActionResult</returns>
        /// <response code="204">Postagem deletada</response>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpDelete("deletar/{idPostagem}")]
        [Authorize]
        public async Task<ActionResult> DeletarPostagem([FromRoute] int idPostagem)
        {
            await _repositorio.DeletarPostagemAsync(idPostagem);
            return NoContent();
        }

        #endregion
    }
}