﻿using myfinance_web_dotnet_domain.Entities;
using myfinance_web_dotnet_infra.Interfaces;

namespace myfinance_web_dotnet_infra.Repositories
{
    public class PlanoContaRepository : Repository<PlanoConta>, IPlanoContaRepository
    {
        public PlanoContaRepository(MyFinanceDBContext dbContext) : base(dbContext)
        {
        }
    }
}
