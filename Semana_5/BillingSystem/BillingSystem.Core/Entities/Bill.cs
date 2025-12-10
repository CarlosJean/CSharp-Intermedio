using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BillingSystem.Core.Entities;

public class Bill
{
    public int Id { get; set; }
    public int CustomerId { get; set; }


	[DisplayName("Cliente")]
    public Customer Customer { get; set; }

	[DisplayName("Impuestos")]
	[DisplayFormat(DataFormatString = "{0:C}")]
	public float Taxes { get; set; }

	[DisplayFormat(DataFormatString = "{0:C}")]
	public float Subtotal { get; set; }

	[DisplayFormat(DataFormatString = "{0:C}")]
    public float Total { get; set; }

	[DisplayName("Fecha")]
    public DateTime Date { get; set; }

    public ICollection<BillDetail> BillDetails { get; set; } = [];
}