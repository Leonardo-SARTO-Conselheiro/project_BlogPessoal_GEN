using Blog_Pessoal.src.dtos;
using Blog_Pessoal.src.modelos;
using System.Threading.Tasks;

namespace Blog_Pessoal.src.servicos
{
    /// <summary>
    /// <para>Resumo: Interface Responsavel por representar ações de autenticação</para>
    /// <para>Criado por: Leonardo Sarto</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 13/05/2022</para>
    /// </summary>
    public interface IAutenticacao
    {
        string CodificarSenha(string senha);
        Task CriarUsuarioSemDuplicarAsync(NovoUsuarioDTO dto);
        string GerarToken(UsuarioModelo usuario);
        Task <AutorizacaoDTO> PegarAutorizacaoAsync(AutenticarDTO dto);
    }
}
