using System.Text.Json.Serialization;

namespace Blog_Pessoal.src.utilidades
{
  [JsonConverter(typeof(JsonStringEnumConverter))]
  public enum TipoUsuario
    {
        NORMAL,
        ADMINISTRADOR
    }
}
