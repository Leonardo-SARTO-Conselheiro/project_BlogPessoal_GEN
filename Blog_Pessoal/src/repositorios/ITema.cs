using Blog_Pessoal.src.dtos;
using Blog_Pessoal.src.modelos;
using System.Collections.Generic;


namespace Blog_Pessoal.src.repositorios
{
    /// <summary>
    /// <para>Resumo: Responsavel por representar ações de CRUD de tema</para>
    /// <para>Criado por: Leonardo Sarto</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 29/04/2022</para>
    /// </summary>
    public interface ITema
    {
        void NovoTema(NovoTemaDTO tema);
        void AtualizarTema(AtualizarTemaDTO tema);
        void DeletarTema(int id);
        TemaModelo PegarTemaPeloId(int id);
        List<TemaModelo> PegarTemasPelaDescricao(string descricao);
        List<TemaModelo> PegarTodosTemas();
    }
}
