using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.AbstractClassandMethodApp
{
    internal class MinHeap : Heap
    {
        //Extract metotu override etme
        public override int Extract()
        {
            var item = _list.Min;
            _list.Remove(item);
            return item;
        }
    }
}
