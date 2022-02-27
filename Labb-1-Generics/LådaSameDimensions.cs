using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Labb_1_Generics
{
    public class LådaSameDimensions : EqualityComparer<Låda>
    {
        public override bool Equals([AllowNull] Låda x, [AllowNull] Låda y)
        {
            if (x.höjd == y.höjd && x.bredd == y.bredd && x.längd == y.längd)
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
            return hCode.GetHashCode();
        }
    }
}
