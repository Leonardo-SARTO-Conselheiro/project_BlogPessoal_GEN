using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Blog_Pessoal.src.modelos
{
    [Table("tb_usuarios")] //colocando como nome da tabela "tb_usuarios"
    public class UsuarioModelo
    {
        [Key] //declarando a chave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //falando que é auto imcremente
        public int Id { get; set; }//declarando que é um int

        [Required] //colocando como campo obrigatorio, que não aceita nulo(not null)
        [StringLength(50)] //declarando que o tamanho maximo da string é 50
        public string Nome { get; set; }//declarando que é uma string
        
        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        [Required, StringLength(15)] //posso fazer dessa forma ou das formas acimas
        public string Senha { get; set; }

        public string Foto { get; set; }


        [JsonIgnore]//é para ignorar a postagem, levar em consideração somente o UsuarioModelo
        public List<PostagemModelo> MinhasPostagens { get; set; }//um usuario tem diversas postagens(uma lista de postagens)

    }
}
