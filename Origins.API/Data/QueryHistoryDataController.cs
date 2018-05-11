﻿using Origins.API.DataServices;
using Origins.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Origins.API.Data
{
    public class QueryHistoryDataController : DefaultCrudDataController<QueryHistoryModel, string>, IQueryHistoryDataService
    {
        public QueryHistoryDataController(ApplicationContext context)
    : base(context, context.QueryHistory) { }

        public async Task AddAHistoryAsync(QueryHistoryModel incompleteModel)
        {
            incompleteModel.Id = Guid.NewGuid().ToString();
            incompleteModel.Date = DateTime.UtcNow;
            Add(incompleteModel);
            await SaveChangesAsync();
        }
    }
}
