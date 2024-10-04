using System.ComponentModel.DataAnnotations;

namespace TechStore_BackEnd.DTOs.Requests;
public class CarrierDTO
{
    [Required]
    [StringLength(255, ErrorMessage = "El nombre del transportista no puede exceder los 255 caracteres.")]
    public required string Carrier_name { get; set; }
    
    [Required]
    [DataType(DataType.MultilineText)] 
    public required string Carrier_description { get; set; }
}