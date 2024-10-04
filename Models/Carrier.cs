using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechStore_BackEnd.Models;

[Table("Carriers")]
public class Carrier
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("shipment_id")]
    public int Carrier_id {get; set;}

    [Column("carrier_name")]
    public string Carrier_name {get; set;}

    [Column("carrier_description")]
    public string Carrier_description {get; set;}

    public Carrier(string Carrier_name,string Carrier_description)
    {
        this.Carrier_name = Carrier_name;
        this.Carrier_description = Carrier_description;
    }
}