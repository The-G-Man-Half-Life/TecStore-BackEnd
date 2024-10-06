using System.ComponentModel.DataAnnotations;

namespace TechStore_BackEnd.DTOs.Requests;

public class BrandDTO
{
        [Required]
        [StringLength(255, ErrorMessage = "El nombre de la marca no puede exceder los 255 caracteres.")]
        public required string Brand_name { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public required string Brand_description {get; set;}
}