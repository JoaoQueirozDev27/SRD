using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Verifiers
{
    public static class StringVerifier
    {
        public static bool isEmpty(string value) => String.IsNullOrEmpty(value);
        public static bool isNull(string value) => value == null;
        public static bool isGreaterThan(string value, int length) => value.Length > length;
        public static bool isBetween(string value, int min,int max) => (value.Length > min && value.Length < max);

    }
}
