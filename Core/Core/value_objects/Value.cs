using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Domain.value_objects
{
    public record Value
    {
        private string _value { get; set; }
        private Value(string value)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(value);
            _value = value;
        }
        public static Value Create(string value) => new Value(value);
        public bool intValue(out int result) => int.TryParse(_value, out result);
    }
}
