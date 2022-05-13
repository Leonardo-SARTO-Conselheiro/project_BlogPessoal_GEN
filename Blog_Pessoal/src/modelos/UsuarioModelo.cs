using Blog_Pessoal.src.utilidades;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Blog_Pessoal.src.modelos
{
    [Table("tb_usuarios")] 
    public class UsuarioModelo
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }

        [Required] 
        [StringLength(50)] 
        public string Nome { get; set; }
        
        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        [Required, StringLength(15)] 
        public string Senha { get; set; }

        public string Foto { get; set; }

        [Required]
        public TipoUsuario Tipo { get; set; }

        [JsonIgnore]
        public List<PostagemModelo> MinhasPostagens { get; set; }

    }
}
