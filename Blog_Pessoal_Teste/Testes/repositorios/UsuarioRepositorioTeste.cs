using Blog_Pessoal.src.data;
using Blog_Pessoal.src.dtos;
using Blog_Pessoal.src.repositorios;
using Blog_Pessoal.src.repositorios.implementacoes;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Pessoal_Teste.Testes.repositorios
{
    [TestClass]
    public class UsuarioRepositorioTeste
    {
        private BlogPessoalContexto _contexto;
        private IUsuario _repositorio;

        [TestInitialize]
        public void ConfiguracaoInicial()
        {
            var opt = new DbContextOptionsBuilder<BlogPessoalContexto>()
                .UseInMemoryDatabase(databaseName: "db_blogpessoal")
                .Options;

            _contexto = new BlogPessoalContexto(opt);

            _repositorio = new UsuarioRepositorio(_contexto);
        }

        [TestMethod]
        public void CriarCincoUsuariosNoBancoRetornaQuatroUsuarios1()
        {
            _repositorio.NovoUsuario(
                new NovoUsuarioDTO(
                    "Leonardo Sarto",
                    "leonardo@email.com",
                    "123456",
                    "url/sfudiahi35342gdsaafia"));

            _repositorio.NovoUsuario(
                new NovoUsuarioDTO(
                    "João Cesar",
                    "joaocesar@email.com",
                    "654321",
                    "url/sfudiahi352414325fia"));

            _repositorio.NovoUsuario(
                new NovoUsuarioDTO(
                    "Ana Barbara",
                    "anabarbara@email.com",
                    "456123",
                    "url/sfud242iger71t4e97131"));

            _repositorio.NovoUsuario(
                new NovoUsuarioDTO(
                    "Yasmin Lopes",
                    "yasmin@email.com",
                    "321654",
                    "url/sfudiahi242521423242afia"));

            _repositorio.NovoUsuario(
                new NovoUsuarioDTO(
                    "Liza Sarto",
                    "liza@email.com",
                    "654123",
                    "url/sfudiahia2421214fhffia"));

            Assert.AreEqual(5, _contexto.Usuarios.Count());
        }

        [TestMethod]
        public void PegarUsuarioPeloEmailRetornaNaoNulo2()
        {
            _repositorio.NovoUsuario(
            new NovoUsuarioDTO(
            "Sunny Skay",
            "sunny@email.com",
            "362514",
            "url/aihdfadg1t131de1"));

            var user = _repositorio.PegarUsuarioPeloEmail("sunny@email.com");

            Assert.IsNotNull(user);
        }

        [TestMethod]
        public void PegarUsuarioPeloIdRetornaNaoNuloENomeDoUsuario3()
        {
            _repositorio.NovoUsuario(
                new NovoUsuarioDTO(
                "Nil Dantas",
                "nil@email.com",
                "514362",
                "url/siuhfu1u4g1iude1"));

            var user = _repositorio.PegarUsuarioPeloId(7);

            Assert.IsNotNull(user);

            Assert.AreEqual("Nil Dantas", user.Nome);
        }

        [TestMethod]
        public void AtualizarUsuarioRetornaUsuarioAtualizado()
        {
            _repositorio.NovoUsuario(
                new NovoUsuarioDTO(
                "Zoe",
                "zoe@gmail.com",
                "351246",
                "url/sufgaufgu131415"));

            var antigo =
            _repositorio.PegarUsuarioPeloEmail("zoe@gmail.com");
            
            _repositorio.AtualizarUsuario(
                new AtualizarUsuarioDTO(
                    8,
                    "Zoe Sarto",
                    "351246",
                    "url/sufgaufgu131415nova"));

            Assert.AreEqual(
                "Zoe Sarto",
                _contexto.Usuarios.FirstOrDefault(u => u.Id == antigo.Id).Nome);
            
            Assert.AreEqual(
                "351246",
                _contexto.Usuarios.FirstOrDefault(u => u.Id ==
                antigo.Id).Senha);
        }
    }
}
