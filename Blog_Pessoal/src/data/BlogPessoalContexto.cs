using Blog_Pessoal.src.modelos;
using Microsoft.EntityFrameworkCore;

namespace Blog_Pessoal.src.data
{
    public class BlogPessoalContexto : DbContext
    {
        public DbSet<UsuarioModelo> Usuarios { get; set; }
        public DbSet<TemaModelo> Temas { get; set; }    
        public DbSet<PostagemModelo> Postages { get; set; }

        public BlogPessoalContexto(DbContextOptions<BlogPessoalContexto> opt) : base(opt)
        {

        }
    }
}
