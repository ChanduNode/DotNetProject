using System.Text.Json.Serialization;

namespace First.Models
{
    public class RpgName
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum Rpg
        {
            Knite,
            Mage,
            Chandu
        }
    }
}