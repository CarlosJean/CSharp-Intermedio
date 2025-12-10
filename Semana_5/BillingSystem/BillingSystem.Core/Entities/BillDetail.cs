using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BillingSystem.Core.Entities;

public class BillDetail
{
    public int Id { get; set; }
    public int BillId { get; set; }
    public Bill Bill { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }

	[DisplayName("Cantidad")]
	public float Quantity { get; set; }
	
    [DisplayName("Descripción")]
    public string ProductDescription { get; set; }

    [DisplayName("Impuestos")]
	[DisplayFormat(DataFormatString = "{0:C}")]
	public float Taxes { get; set; }

    [DisplayName("Valor")]
	[DisplayFormat(DataFormatString = "{0:C}")]
	public float UnitPrice { get; set; }
}
