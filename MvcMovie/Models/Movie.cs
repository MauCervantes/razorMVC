using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }//Id representa la clave
        public string? Title { get; set; }
        [Display(Name = "Realease Date")]
        [DataType(DataType.Date)] //Decorador 
        public DateTime ReleaseDate { get; set; } //Con este atributo el usuario no tiene que especificar información
        //horaria en el campo fecha

        public string? Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public string Rating { get; set; } = string.Empty;
    }
}
