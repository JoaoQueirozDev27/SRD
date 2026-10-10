using Domain.value_objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Rules
{
    public abstract record Rule<TreturnExecution>
    {
        private List<Field> _fields = new();
        public readonly int limit = 10;

        public IReadOnlyCollection<Field> Fields => _fields.ToArray();

        protected Rule(int limit)
        {
            if (limit < 1)
                throw new ArgumentException("Limit must be greater than zero.");
            if (limit <= this.limit)
                this.limit = limit;

        }

        public Field GetField(int index)
        {
            if (index < 0 || index >= _fields.Count)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            return _fields[index];
        }

        protected bool AddField(Field field)
        {
            if (field == null)
                throw new ArgumentNullException(nameof(field), "Field cannot be null.");

            if (_fields.Count + 1 <= limit)
            {
                _fields.Add(field);
                return true;
            }

            return false;
        }

        public abstract TreturnExecution Execute();
    }
}
