namespace BillingSystem.Web.Controllers {
    public class SaveBillDto
    {
        public int CustomerId { get; set; }
		public IEnumerable<SaveBillDetailDto> Products { get; set; }
    }
}
