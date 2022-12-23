using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.SQLite;
using Asmerald.Statements;

namespace Asmerald.SQLite
{
    public static partial class AsmeraldQuoteExtensions
    {
        public static QuoteFunction Quote(this SQLiteDSLContext stmt, ISelectExpression x)
        {
            return new QuoteFunction(x);
        }
        public static QuoteFunction Quote(this Int16 x)
        {
            return new QuoteFunction(x.Expr());
        }
        public static QuoteFunction Quote(this Int32 x)
        {
            return new QuoteFunction(x.Expr());
        }
        public static QuoteFunction Quote(this Int64 x)
        {
            return new QuoteFunction(x.Expr());
        }
        public static QuoteFunction Quote(this UInt16 x)
        {
            return new QuoteFunction(x.Expr());
        }
        public static QuoteFunction Quote(this UInt32 x)
        {
            return new QuoteFunction(x.Expr());
        }
        public static QuoteFunction Quote(this UInt64 x)
        {
            return new QuoteFunction(x.Expr());
        }
        public static QuoteFunction Quote(this Decimal x)
        {
            return new QuoteFunction(x.Expr());
        }
        public static QuoteFunction Quote(this Double x)
        {
            return new QuoteFunction(x.Expr());
        }
        public static QuoteFunction Quote(this String x)
        {
            return new QuoteFunction(x.Expr());
        }
        public static QuoteFunction Quote(this Char x)
        {
            return new QuoteFunction(x.Expr());
        }
        public static QuoteFunction Quote(this Boolean x)
        {
            return new QuoteFunction(x.Expr());
        }
        public static QuoteFunction Quote(this Byte x)
        {
            return new QuoteFunction(x.Expr());
        }
        public static QuoteFunction Quote(this DateTime x)
        {
            return new QuoteFunction(x.Expr());
        }
        public static QuoteFunction Quote(this Single x)
        {
            return new QuoteFunction(x.Expr());
        }
        public static QuoteFunction Quote(this ISelectColumn x)
        {
            return new QuoteFunction(x);
        }
    }
}
