using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Labb1
{
    internal class LådaCollection : ICollection<Låda>
    {
        private List<Låda> innerLåda;

        public LådaCollection()
        {
            innerLåda = new List<Låda>();
        }
        public Låda this[int index]
        {
            get { return innerLåda[index]; }
            set { innerLåda[index] = value; }
        }
        public int Count
        {
            get { return innerLåda.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(Låda item)
        {
            if (!Contains(item))
            {
                innerLåda.Add(item);
            }
            else
            {
                Console.WriteLine("a box with theese exact measurments already exists\n");
            }
        }

        public void Clear()
        {
            innerLåda.Clear();
        }

        public bool Contains(Låda item)
        {
            bool found=false;
            foreach(var box in innerLåda)
            {
                if (box.Equals(item))
                {
                    found=true;
                }
            }
            return found;
        }
        public bool Contains(Låda? item ,LådaSameDimensions comparer)
        {
            bool found = false;
            foreach(var box in innerLåda)
            {
                if(comparer.Equals(box, item))
                {
                    found = true;
                }
            }
            return found;
        }

        public void CopyTo(Låda[] array, int arrayIndex)
        {
            if(array == null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < innerLåda.Count; i++)
            {
                array[i + arrayIndex] = innerLåda[i];
            }
        }

        public IEnumerator<Låda> GetEnumerator()
        {
            return new LådaEnumerator(this);
        }

        public bool Remove(Låda item)
        {
            bool results = false;
            for(int i =0; i < innerLåda.Count; i++)
            {
                Låda låda = innerLåda[i];
                if(new LådaSameDimensions().Equals(låda, item))
                {
                    innerLåda.RemoveAt(i);
                    results=true;
                    break;
                }
            }
            return results;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LådaEnumerator(this);
        }
    }
}
