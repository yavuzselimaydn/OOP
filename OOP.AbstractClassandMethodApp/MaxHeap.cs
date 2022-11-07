using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.AbstractClassandMethodApp
{
    internal class MaxHeap : Heap
    {
        //Extract metotu override etme
        public override int Extract()
        {
            var item = _list.Max;
            _list.Remove(item);
            return item;
        }
    }
}
