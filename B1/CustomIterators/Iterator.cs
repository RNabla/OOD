using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.CustomIterators
{
    abstract class Iterator<T>
    {
        public abstract IEnumerator<T> GetEnumerator();
    }
}
