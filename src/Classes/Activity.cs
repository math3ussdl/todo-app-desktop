using Newtonsoft.Json;
using TodoApp.Classes;

namespace TodoApp.src.Classes
{
    public class Activity
    {
        public int Id { get; set; }

        public string ResponsibleEmail { get; set; }

        public User Users { get; set; }

        public string Description { get; set; }

        [JsonProperty("dt_prev")]
        public string PrevDate { get; set; }

        [JsonProperty("dt_exec")]
        public string ExecDate { get; set; }

        public StatusList Status { get; set; }
    }
}
