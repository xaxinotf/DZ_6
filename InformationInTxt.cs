

using System.Text.Json.Serialization;

namespace DZ_6
{

    internal class InformationInTxt
    {
        //[JsonIgnore] 
        public int PublishingHouseId { get; set; }
        //[JsonPropertyName("Name")] 
        public string? Title { get; set; }

        public House? PublishingHouse { get; set; }
    }
}
