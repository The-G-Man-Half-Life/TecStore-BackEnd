using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechStore_BackEnd.Models;

[Table("Shipments")]
public class Shipment
{
    [Column("shipment_id")]
    public int Shipment_id  {get; set;}

    [Column("shipment_weight_kg")]
    public double Shipment_weight_kg {get; set;}

    [Column("shipment_price")]
    public double Shipment_price_usa {get; set;}

    [Column("shipment_order_date")]
    public DateOnly Shipment_order_date  {get; set;}

    [Column("shipment_arrival_date")]
    public DateOnly Shipment_arrival_date  {get; set;}

    [Column("carrier_id")]
    public int Carrier_id {get; set;}

    [ForeignKey(nameof(Carrier_id))]
    public Carrier? Carrier {get; set;}


    public Shipment(int Shipment_id, double Shipment_weight_kg, double Shipment_price_usa, DateOnly Shipment_order_date, DateOnly Shipment_arrival_date, int Carrier_id)
    {
        this.Shipment_id = Shipment_id;
        this.Shipment_weight_kg = Shipment_weight_kg;
        this.Shipment_price_usa = Shipment_price_usa;
        this.Shipment_order_date = Shipment_order_date;
        this.Shipment_arrival_date = Shipment_arrival_date;
        this.Carrier_id = Carrier_id;
    }
}
