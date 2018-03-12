using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tri.data.Repo;
using tri.entity;

namespace tri.business
{
    public class InvoiceBusiness
    {
        private UnitOfWork unitOfWork;
        private Repository<Invoice> invoiceRepository;


        public InvoiceBusiness()
        {
            unitOfWork = new UnitOfWork();
            invoiceRepository = unitOfWork.Repository<Invoice>();
        }


        public  IEnumerable<Invoice> GetInvoiceInfos()
        {
            return invoiceRepository.GetAll(null, null, "Account").ToList();
        }

         

    }
}
