using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Columns;
using System.Linq;
using TypeProofSql.Statements;
using TypeProofSql.Statements.SQLite;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlCrossJoinExtensions
    {
        public static NonConditionalJoinStatement<T, J> CrossJoin<T, J>(this FromStatement<T> stmt)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new NonConditionalJoinStatement<T, J>(stmt.QueryBuilder);
        }
    }
}
