using Blog_Pessoal.src.dtos;
using Blog_Pessoal.src.modelos;
using System.Collections.Generic;

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
        void NovaPostagem(NovaPostagemDTO postagem);
        void AtualizarPostagem(AtualizarPostagemDTO postagem);
        void DeletarPostagem(int id);
        PostagemModelo PegarPostagemPeloId(int id);
        List<PostagemModelo> PegarTodasPostagens();
        List<PostagemModelo> PegarPostagensPeloTitulo(string titulo);
        List<PostagemModelo> PegarPostagensPelaDescricao(string descricao);
    }

}
