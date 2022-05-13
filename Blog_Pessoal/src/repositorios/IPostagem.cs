using Blog_Pessoal.src.dtos;
using Blog_Pessoal.src.modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog_Pessoal.src.repositorios
{
    /// <summary>
    /// <para>Resumo: Responsavel por representar ações de CRUD de postagem</para>
    /// <para>Criado por: Leonardo Sarto</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 29/04/2022</para>
    /// </summary>
    public interface IPostagem
    {
        Task NovaPostagemAsync(NovaPostagemDTO postagem);
        Task AtualizarPostagemAsync(AtualizarPostagemDTO postagem);
        Task DeletarPostagemAsync(int id);
        Task <PostagemModelo> PegarPostagemPeloIdAsync(int id);
        Task <List<PostagemModelo>> PegarTodasPostagensAsync();
        Task <List<PostagemModelo>> PegarPostagensPorPesquisaAsync(string titulo, string descricaoTema, string nomeCriador);
    }

}
