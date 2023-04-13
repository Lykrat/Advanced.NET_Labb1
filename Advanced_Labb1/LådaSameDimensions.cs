using System.Diagnostics.CodeAnalysis;

namespace Advanced_Labb1
{
    internal class LådaSameDimensions : EqualityComparer<Låda>
    {
        public LådaSameDimensions()
        {
        }

        public override bool Equals(Låda? x, Låda? y)
        {
            if (x.bredd==y.bredd && x.längd==y.längd && x.höjd==y.höjd)
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