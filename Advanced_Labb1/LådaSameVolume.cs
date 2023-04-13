using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Labb1
{
    internal class LådaSameVolume : EqualityComparer<Låda>
    {
        public override bool Equals(Låda? x, Låda? y)
        {
            if(x.bredd * x.längd * x.höjd == y.bredd * y.längd * y.höjd)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode([DisallowNull] Låda obj)
        {
            throw new NotImplementedException();
        }
    }
}
