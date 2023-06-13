using Contracts;
using Entities;
using Entities.Helpers;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        private ISortHelper<Account> _sortHelper;
        public AccountRepository(RepositoryContext repositoryContext, ISortHelper<Account> sortHelper) : base(repositoryContext) 
        {
            _sortHelper = sortHelper;
        }
    }
}
