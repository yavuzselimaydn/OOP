using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.AbstractClassandMethodApp
{
    internal abstract class Heap
    {
        //sıralı listeyi tanımlama
        protected SortedSet<int> _list;

        //listeyi başlatma
        public Heap()
        {
            _list = new SortedSet<int>();             
        }

        //listeye eleman ekleyen metot tanımı
        public void Insert(int item)
        {
            _list.Add(item);
        }

        //abstract metot tanımı
        public abstract int Extract();
        
    }
}
