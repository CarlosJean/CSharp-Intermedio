using BillingSystem.Core.Entities;

namespace BillingSystem.Core.Dtos {
	public class BillDetailDto {
		public Product Product { get; set; }
		public float Taxes { get; set; }
    }
}