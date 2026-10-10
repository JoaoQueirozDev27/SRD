using Domain.value_objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Slot
    {
        public IDInt ModelID { get; private set; }
        public IDInt ID { get; private set; }
        public Name Name { get; private set; }
        private readonly List<Field> _fields = new();
        public IReadOnlyCollection<Field> Fields => _fields;
        public Slot(IDInt ID, Name Name, IDInt modelID)
        {
            this.ID = ID;
            this.Name = Name;
            ModelID = modelID;
        }

        public void AddField(Field field)
        {
            ArgumentNullException.ThrowIfNull(field);
            _fields.Add(field);
        }
    }
}
