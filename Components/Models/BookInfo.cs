using System.Text.Json;
using System.Text.Json.Serialization;

namespace LaunchQ.TakeHomeProject.Components.Models
{
    public class BookInfo
    {
        public string Title { get; set; }
        public List<int> Covers { get; set; }
        public string Description { get; set; }
    }
}
