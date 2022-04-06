using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceServices_ID
{
    public class InvoiceServices : IInvoiceServices
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly INotifier _notifier;

        public InvoiceServices(IInvoiceRepository invoiceRepository, INotifier notifier)
        {
            _invoiceRepository = invoiceRepository;
            _notifier = notifier;
        }
    
    public void Remove(int invoiceId)
        {
            var removed = _invoiceRepository.Remove(invoiceId);
            if ((bool)removed)
            {
                _notifier.NotifyAdmin($"Invoice {invoiceId} removed");
            }
        }
    }
}
