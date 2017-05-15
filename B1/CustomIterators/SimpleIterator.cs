using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.CustomCollections;
using Game.Model;
namespace Game.CustomIterators
{
    class SimpleIterator<T> : Iterator<T>
    {
        private ICustomCollection<T> _collection;
        public SimpleIterator(ICustomCollection<T> collection)
        {
            _collection = collection;
        }
        public override IEnumerator<T> GetEnumerator()
        {
            return _collection.GetEnumerator();
        }
     
    }
}
