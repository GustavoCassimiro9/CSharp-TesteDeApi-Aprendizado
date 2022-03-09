using System.Text.Json.Serialization;


namespace AutomacaoPetStore.Models
{
    public class Get_UserName_Response
    {
        [JsonPropertyName("username")]
        public string username { get; set; }
    }
}
