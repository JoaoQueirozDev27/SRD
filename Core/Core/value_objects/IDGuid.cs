using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.value_objects
{
    public class IDGuid
    {
        public Guid ID { get; private set; }
        public IDGuid()
        {
            ID = new Guid();
        }
    }
}
