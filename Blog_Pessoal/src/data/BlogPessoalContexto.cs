﻿using Blog_Pessoal.src.modelos;
using Microsoft.EntityFrameworkCore;

namespace Blog_Pessoal.src.data
{
    /// <summary>
    /// <para>Resumo: Classe contexto, responsavel por carregar contexto e definir DbSets</para>
    /// <para>Criado por: Leonardo Sarto</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 12/05/2022</para>
    /// </summary>
    public class BlogPessoalContexto : DbContext
    {
        public DbSet<UsuarioModelo> Usuarios { get; set; }
        public DbSet<TemaModelo> Temas { get; set; }    
        public DbSet<PostagemModelo> Postagens { get; set; }

        public BlogPessoalContexto(DbContextOptions<BlogPessoalContexto> opt) : base(opt)
        {

        }
    }
}
