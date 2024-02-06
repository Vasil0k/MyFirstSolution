using Newtonsoft.Json;

namespace Homework17.Task4
{
    internal class MyItem(int age, string name)
    {
        [JsonProperty("MyAge")]
        public int Age { get; set; } = age;
        [JsonIgnore]
        public string Name { get; set; } = name;
    }
}
