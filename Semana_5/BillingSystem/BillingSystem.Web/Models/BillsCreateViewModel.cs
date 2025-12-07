using BillingSystem.Core.Dtos;

namespace BillingSystem.Web.Models {
	public class BillsCreateViewModel {
		public CustomerDto Customer { get; set; }
		public List<BillDetailDto> Details { get; set; }
		public float Subtotal { get; set; }
		public float Taxes { get; set; }
		public float Total { get; set; }
	}
}
