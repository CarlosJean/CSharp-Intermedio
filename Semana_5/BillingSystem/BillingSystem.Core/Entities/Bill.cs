namespace BillingSystem.Core.Entities;

public class Bill
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public float Taxes { get; set; }
    public float Subtotal { get; set; }
    public float Total { get; set; }
    public DateTime Date { get; set; }

    public ICollection<BillDetail> BillDetails { get; set; } = [];
}