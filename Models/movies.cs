using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace starto.Models;

public class Movie
{
    public int Id { get; set; }
    [Required, StringLength(60, MinimumLength = 3)]
    public string? Title { get; set; }
    [Display(Name = "Erscheinungsdatum"), DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
    public string? Genre { get; set; }
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), StringLength(5)]
    public string Bewertung { get; set; } = string.Empty;

}
