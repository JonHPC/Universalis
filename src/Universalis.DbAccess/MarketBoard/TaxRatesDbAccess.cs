﻿using Universalis.DbAccess.Queries.MarketBoard;
using Universalis.Entities.MarketBoard;

namespace Universalis.DbAccess.MarketBoard
{
    public class TaxRatesDbAccess : DbAccessService<TaxRates, TaxRatesQuery>, ITaxRatesDbAccess
    {
        public TaxRatesDbAccess() : base("universalis", "extraData") { }

        public TaxRatesDbAccess(string databaseName) : base(databaseName, "extraData") { }
    }
}