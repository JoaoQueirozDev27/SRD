using Domain.Verifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.value_objects
{
    public class QtMax
    {
        private int Value { get; set; }
        private readonly int limit = 1;
        private QtMax(int value, int limit)
        {
            if (intVerifier.isLessThan(limit, 1))
                throw new ArgumentException("Limit must be greater than zero.");
            this.limit = limit;
            SetValue(value);
        }
        public static QtMax Create(int value, int limit)
        {
            return new QtMax(value, limit);
        }
        public void SetValue(int qt)
        {
            if (intVerifier.isLessThan(qt, 1))
                throw new ArgumentException("QtMax cannot be negative.");
            if (intVerifier.isLessThan(limit, qt))
                throw new ArgumentException($"QtMax cannot be greater than the limit {limit}.");
            Value = qt;
        }
        public int GetValue() => Value;

    }
}
