using Blog_Pessoal.src.dtos;
using Blog_Pessoal.src.modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        Task NovoTemaAsync(NovoTemaDTO tema);
        Task AtualizarTemaAsync(AtualizarTemaDTO tema);
        Task DeletarTemaAsync(int id);
        Task <TemaModelo> PegarTemaPeloIdAsync(int id);
        Task <List<TemaModelo>> PegarTemasPelaDescricaoAsync(string descricao);
        Task <List<TemaModelo>> PegarTodosTemasAsync();
    }
}
