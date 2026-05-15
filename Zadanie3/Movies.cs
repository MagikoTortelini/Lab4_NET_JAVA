using System.ComponentModel.DataAnnotations;

namespace Zadanie3
{
    public class Movies
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime? RelaseDate { get; set; }
        public double? Rate_avg { get; set; } = 0;
        public int rates { get; set; } = 0;
        public int rate_count { get; set; } = 0;
        public string image_url { get; set; } = "";
        public string genre { get; set; }

    }
}
