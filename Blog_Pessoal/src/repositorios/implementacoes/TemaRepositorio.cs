using Blog_Pessoal.src.data;
using Blog_Pessoal.src.dtos;
using Blog_Pessoal.src.modelos;
using System.Collections.Generic;
using System.Linq;

namespace Blog_Pessoal.src.repositorios.implementacoes
{
    public class TemaRepositorio : ITema
    {
        #region Atributos
        private readonly BlogPessoalContexto _contexto;
        #endregion Atributos

        #region Construtores
        public TemaRepositorio(BlogPessoalContexto contexto)
        {
            _contexto = contexto;
        }
        #endregion Construtores

        public void AtualizarTema(AtualizarTemaDTO tema)
        {
            var temaExistente = PegarTemaPeloId(tema.Id);
            temaExistente.Descricao = tema.Descricao;
            _contexto.Temas.Update(temaExistente);
            _contexto.SaveChanges();
        }

        #region Métodos
        public void DeletarTema(int id)
        {
            _contexto.Temas.Remove(PegarTemaPeloId(id));
            _contexto.SaveChanges();
        }

        public void NovoTema(NovoTemaDTO tema)
        {
            _contexto.Temas.Add(new TemaModelo
            {
                Descricao = tema.Descricao
            });
            _contexto.SaveChanges();
        }

        public List<TemaModelo> PegarTodosTemas()
        {
            return _contexto.Temas.ToList();
        }

        public List<TemaModelo> PegarTemasPelaDescricao(string descricao)
        {
            return _contexto.Temas.Where(t => t.Descricao.Contains(descricao)).ToList();
        }

        public TemaModelo PegarTemaPeloId(int id)
        {
            return _contexto.Temas.FirstOrDefault(t => t.Id == id);
        }
        #endregion Métodos
    }
}
