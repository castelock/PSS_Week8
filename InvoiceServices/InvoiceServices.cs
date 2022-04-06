using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceServices
{
    public class InvoiceServices
    {
        public InvoiceServices() { }

        public void Remove(int invoiceId)
        {
            using (var invoiceRepository = new InvoiceRepository())
            {
                var removed = invoiceRepository.Remove(invoiceId);
                if ((bool)removed)
                {
                    var notifier = new EmailNotifier();
                    notifier.NotifyAdmin($"Invoice {invoiceId} removed");
                }
            }
        }
    }
}
