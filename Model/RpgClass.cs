using System.Text.Json.Serialization;


namespace NET5_rpg.Model
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight,
        Mage,
        Cleric
    }
}
