using Blog_Pessoal.src.dtos;
using Blog_Pessoal.src.modelos;

namespace Blog_Pessoal.src.servicos
{
    public interface IAutenticacao
    {
        string CodificarSenha(string senha);
        void CriarUsuarioSemDuplicar(NovoUsuarioDTO dto);
        string GerarToken(UsuarioModelo usuario);
        AutorizacaoDTO PegarAutorizacao(AutenticarDTO dto);
    }
}
