using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Labb1
{
    internal class LådaEnumerator : IEnumerator<Låda>
    {
        private LådaCollection _boxes;
        private Låda _currentBox;
        private int _currentIndex;

        public LådaEnumerator(LådaCollection boxes)
        {
            _boxes = boxes;
            _currentIndex= -1;
            _currentBox = default(Låda);
        }

        public Låda Current
        {
            get { return _currentBox; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (++_currentIndex >= _boxes.Count)
            {
                return false;
            }
            else
            {
                _currentBox = _boxes[_currentIndex];
            }
            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
