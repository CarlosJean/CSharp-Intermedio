namespace BillingSystem.Core.Entities;

public class BillDetail
{
    public int Id { get; set; }
    public int BillId { get; set; }
    public Bill Bill { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public float Quantity { get; set; }
    public string ProductDescription { get; set; }
    public float Taxes { get; set; }
    public float UnitPrice { get; set; }
}
