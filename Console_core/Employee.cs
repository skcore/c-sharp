using System.Text.Json.Serialization;

namespace Json_ignore
{
    internal class Employee
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int ID { get; set; }
        public string? Name { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? City { get; set; }
        public int RefIdReadOnly { get; private set; } = 1013;
    }
}
