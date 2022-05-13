using Blog_Pessoal.src.dtos;
using Blog_Pessoal.src.modelos;
using System.Threading.Tasks;

namespace Blog_Pessoal.src.servicos
{
    public interface IAutenticacao
    {
        string CodificarSenha(string senha);
        Task CriarUsuarioSemDuplicarAsync(NovoUsuarioDTO dto);
        string GerarToken(UsuarioModelo usuario);
        Task <AutorizacaoDTO> PegarAutorizacaoAsync(AutenticarDTO dto);
    }
}
