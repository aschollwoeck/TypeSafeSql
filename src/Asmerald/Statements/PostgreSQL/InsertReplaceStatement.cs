using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.PostgreSQL
{
    public class InsertReplaceStatement : ReplaceStatement
    {
        public InsertReplaceStatement() { }
        public InsertReplaceStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
