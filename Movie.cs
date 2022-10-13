namespace MovieGalleryAPI
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Genre { get; set; } = string.Empty;
        public double Ratings { get; set; }
        public DateTime DateReleased { get; set; }

    }
}
