using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.PostgreSQL
{
    public class LTrimFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public LTrimFunction() { }
        public LTrimFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
