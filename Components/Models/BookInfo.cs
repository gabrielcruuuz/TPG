using System.Text.Json;
using System.Text.Json.Serialization;

namespace LaunchQ.TakeHomeProject.Components.Models
{
    public class BookInfo
    {
        public string Title { get; set; }

        public List<int> Covers { get; set; }

        [JsonPropertyName("description")]
        public JsonElement? DescriptionRaw { get; set; }

        [JsonIgnore]
        public string Description
        {
            get
            {
                if (DescriptionRaw == null)
                    return null;

                if (DescriptionRaw.Value.ValueKind == JsonValueKind.String)
                    return DescriptionRaw.Value.GetString();

                if (DescriptionRaw.Value.ValueKind == JsonValueKind.Object &&
                    DescriptionRaw.Value.TryGetProperty("value", out var valueProp))
                {
                    return valueProp.GetString();
                }

                return null;
            }
        }
    }
}
