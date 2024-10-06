using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechStore_BackEnd.Models;

[Table("Brands")]
public class Brand
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("brand_id")]
    public int Brand_id {get; set;}
    
    [Column("brand_name")]
    public required string Brand_name {get; set;}
    
    [Column("brand_description")]
    public required string Brand_description {get; set;}

    public Brand(string Brand_name, string Brand_description)
    {
        this.Brand_name = Brand_name;
        this.Brand_description = Brand_description;
    }
}