using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Game.Model;
using Game.CustomCollections;
namespace Game.CustomIterators
{
    class FilterIterator<T> : Iterator<T>
    {

        private ICustomCollection<T> _collection;
        private char _code;
        public FilterIterator(ICustomCollection<T> collection, char code)
        {
            _code = code;
            _collection = collection;
        }
        private IEnumerable<T> Filter
        {
            get
            {
                foreach (var e in _collection)
                {
                    if ((e as Hero).HeroName[0] == _code)
                        yield return e;
                }
                yield break;
            }
        }
        public override IEnumerator<T> GetEnumerator()
        {
            return Filter.GetEnumerator();
        }

    }
}
