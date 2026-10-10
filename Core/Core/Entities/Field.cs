using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.value_objects;

namespace Domain.Entities
{
    public record Field
    {
        public IDInt ID { get; }
        public IDInt ModelID { get; }
        public Name Name { get; }
        public Value Value { get; }

        private Field(IDInt id, Name name, Value value)
        {
            ID = id;
            Name = name;
            Value = value;
        }

        public static Field Create(
            IDInt id,
            Name name,
            Value value)
        {
            ArgumentNullException.ThrowIfNull(id);
            ArgumentNullException.ThrowIfNull(name);
            ArgumentNullException.ThrowIfNull(value);

            return new Field(id, name, value);
        }
    }
}
