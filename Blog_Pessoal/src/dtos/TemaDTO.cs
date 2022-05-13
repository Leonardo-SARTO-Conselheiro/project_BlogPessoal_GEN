﻿using System.ComponentModel.DataAnnotations;

namespace Blog_Pessoal.src.dtos
{
    /// <summary>
    /// <para>Resumo: Classe espelho para criar um novo tema</para>
    /// <para>Criado por: Leonardo Sarto</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 29/04/2022</para>
    /// </summary>
    public class NovoTemaDTO
    {

        [Required, StringLength(20)]
        public string Descricao { get; set; }
        public NovoTemaDTO(string descricao)
        {
            Descricao = descricao;
        }
    }

    /// <summary>
    /// <para>Resumo: Classe espelho para alterar um tema</para>
    /// <para>Criado por: Leonardo Sarto</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 29/04/2022</para>
    /// </summary>
    public class AtualizarTemaDTO
    {
        [Required]
        public int Id { get; set; }
            
        [Required, StringLength(20)]
        public string Descricao { get; set; }
        public AtualizarTemaDTO(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
    }
}
