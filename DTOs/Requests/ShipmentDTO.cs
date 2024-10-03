using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ShipmentDto
{
    [Required]
    public int ShipmentId { get; set; }

    [Required]
    public double ShipmentWeight { get; set; }

    [Required]
    public double ShipmentPrice { get; set; }

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