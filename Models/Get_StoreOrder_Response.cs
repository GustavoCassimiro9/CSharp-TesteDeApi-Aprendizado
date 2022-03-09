using System.Text.Json.Serialization;

namespace AutomacaoPetStore.Models
{
    public class Get_StoreOrder_Response
    {
    
        [JsonPropertyName("id")]
        public int id { get; set; }
            
        [JsonPropertyName("petId")]
        public int petId { get; set; }

        [JsonPropertyName("quantity")]
        public int quantity { get; set; }

        [JsonPropertyName("status")]
        public string status { get; set; }

        [JsonPropertyName("complete")]
        public bool complete { get; set; }

    }
}
