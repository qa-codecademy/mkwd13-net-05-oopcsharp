using QA.SeeSharp.RentalApp.Data.Enums;

namespace QA.SeeSharp.RentalApp.Data.Models
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public string Language { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime ReleaseDate { get; set; }
        // Length in minutes
        public int Length { get; set; }
        public int AgeRestriction { get; set; }
        public int Quantity { get; set; }
    }
}
