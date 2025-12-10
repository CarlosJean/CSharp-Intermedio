using BillingSystem.Core.Entities;
using BillingSystem.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Core.Interfaces {
	public interface IBillService {
		Task<IEnumerable<Bill>> GetAll();
		Task<IEnumerable<BillDetail>> GetBillDetails(int billId);
		Task<bool> SaveBill(SaveBillDto saveBillDto);
	}
}
