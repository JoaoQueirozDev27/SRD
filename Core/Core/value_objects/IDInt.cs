using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.value_objects
{
    public class IDInt
    {
        public int Id { get; private set; }
        public IDInt(int id)
        {
            Id = id >= 0 ? id : throw new ArgumentException("ID must greater than 0");
        }
    }
}
