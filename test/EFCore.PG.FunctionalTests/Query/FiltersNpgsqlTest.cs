﻿using Microsoft.EntityFrameworkCore.Query;
using Xunit.Abstractions;

namespace Npgsql.EntityFrameworkCore.PostgreSQL.Query
{
    public class FiltersNpgsqlTest : FiltersTestBase<NorthwindQueryNpgsqlFixture<NorthwindFiltersCustomizer>>
    {
        // ReSharper disable once UnusedParameter.Local
        public FiltersNpgsqlTest(NorthwindQueryNpgsqlFixture<NorthwindFiltersCustomizer> fixture, ITestOutputHelper testOutputHelper)
            : base(fixture)
            => Fixture.TestSqlLoggerFactory.Clear();
    }
}
