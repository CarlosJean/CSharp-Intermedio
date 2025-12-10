using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BillingSystem.Core.Entities;

public class Product
{
    public int Id { get; set; }

    [DisplayName("Descripción")]
    public string Description { get; set; }

    [DisplayName("Precio unitario")]
	[DisplayFormat(DataFormatString = "{0:C}")]
	public float UnitPrice { get; set; } 

    [DisplayName("Existencia")]
    public float Stock { get; set; }

    [DisplayName("Porcentaje de impuestos (%)")]
	[DisplayFormat(DataFormatString = "{0:P}")]
    public float TaxRate { get; set; }
}