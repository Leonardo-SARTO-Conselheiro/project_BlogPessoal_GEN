using Blog_Pessoal.src.data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using Blog_Pessoal.src.modelos;
using System.Linq;

namespace Blog_Pessoal_Teste.Testes.data
{
    [TestClass]
    public class BlogPessoalContextoTeste
    {
        private BlogPessoalContexto _contexto;

        [TestInitialize]
        public void inicio()
        {
            var opt = new DbContextOptionsBuilder<BlogPessoalContexto>()
                .UseInMemoryDatabase(databaseName: "db_blogpessoal")
                .Options;

            _contexto = new BlogPessoalContexto(opt);
        }

        [TestMethod]
        [Ignore]
        public void InserirNovoUsuarioNoBancoRetornaUsuario()

        {
            UsuarioModelo usuario = new UsuarioModelo();

            usuario.Nome = "Leonardo Sarto";
            usuario.Email = "leo@email.com";
            usuario.Senha = "12345";
            usuario.Foto = "linkdafoto";

            _contexto.Usuarios.Add(usuario); // Adicionando usuario

            _contexto.SaveChanges(); // Salvando o contexto (usuario)

            Assert.IsNotNull(_contexto.Usuarios.FirstOrDefault(u => u.Email == "leo@email.com"));
            
        }
    }
}
