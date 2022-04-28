using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog_Pessoal.src.modelos
{
    [Table("tb_postagens")]
    public class PostagemModelo
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Titulo { get; set; }

        [Required, StringLength(100)]
        public string Descricao { get; set; }

        public string Foto { get; set; }


        [ForeignKey("fk_usuario")]// é a chave estrangeira da tabela usuarios
        public UsuarioModelo Criador { get; set; } //é como se utilizarmos o reference, estamos referenciando o usuario 
                                                   // que é criador das postagens
        [ForeignKey("fk_tema")]
        public TemaModelo Tema { get; set; }


    }
}
