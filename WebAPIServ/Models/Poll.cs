using System.ComponentModel.DataAnnotations;

namespace WebAPIServ.Models
{
    public class Poll
    {
        [Key]
        public int Poll_id { get; set; }

        public string Poll_description { get; set; }

        public string options { get; set; }
        public int Votes_qty { get; set; }

        public int Visualizacao { get; set; }
    }
}