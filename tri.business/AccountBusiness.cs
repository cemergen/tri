using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tri.data.Repo;
using tri.entity;

namespace tri.business
{
    public class AccountBusiness
    {
        private UnitOfWork unitOfWork;
        private Repository<Account> accountBusiness;

        public AccountBusiness()
        {
            unitOfWork = new UnitOfWork();
            accountBusiness = unitOfWork.Repository<Account>();
        }

        public IEnumerable<Account> GetAccountInfoes()
        {
            return accountBusiness.GetAll();
        }
        
    }
}
