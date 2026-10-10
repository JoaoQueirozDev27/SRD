using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Verifiers
{
    public class intVerifier
    {
        static public bool isGreaterThan(int value, int limit) => value > limit;
        static public bool isLessThan(int value, int limit) => value < limit;
        static public bool isBetween(int value, int min, int max) => (value > min && value < max);
    }
}
