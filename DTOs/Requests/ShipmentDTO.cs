using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ShipmentDTO
{
    [Required]
    public double ShipmentWeightKG { get; set; }

    [Required]
    public double ShipmentPriceUSA { get; set; }

    [Required]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    public DateOnly ShipmentOrderDate { get; set; }

    [Required]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    public DateOnly ShipmentArrivalDate { get; set; }

    [Required]
    public int CarrierId { get; set; }
}