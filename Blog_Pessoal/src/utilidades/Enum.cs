using System.Text.Json.Serialization;

namespace Blog_Pessoal.src.utilidades
{
    /// <summary>
    /// <para>Resumo: Enum responsavel por definir Tipos de usuario do sistema</para>
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
  public enum TipoUsuario
    {
        NORMAL,
        ADMINISTRADOR
    }
}
