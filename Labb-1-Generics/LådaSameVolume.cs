using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Labb_1_Generics
{
    public class LådaSameVolume : EqualityComparer<Låda>

    {
        public override bool Equals([AllowNull] Låda x, [AllowNull] Låda y)
        {
            if ((x.höjd * x.längd * x.bredd) == (y.höjd * y.längd * y.bredd))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode([DisallowNull] Låda obj)
        {
            int hCode = obj.höjd ^ obj.längd ^ obj.bredd;
            Console.WriteLine("HC: {0}", hCode.GetHashCode());
            return hCode.GetHashCode();
        }
    }
}
