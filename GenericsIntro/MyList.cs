using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{

    // T type demektir bu string de olabilir int de başka bir şeyde. List de sadece string tanılama yapabilmiştik, class ise birçok tipte eleman tanılama özgürlüğü verir.
    internal class MyList<T>
    {
        T[] items;
        //constructor - ctor tab tab
        public MyList()
        {
            items = new T[0];

        }
        public void Add(T item) 
        {
            T[] tempArray = items; //tempArray geçici dizi demektir. Referans no gitmesin diye o numarayı başkasına tutturuyorum.
            //önceki değerlerimi korumak için geçicic dizi tutuyorum!!! 
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];//tempArray e geçicic verdiğim değerleri items a geri alıyorum.


            }

            items[items.Length-1] = item;//items ın son elemanını verir - eklenmek istenen elemenı şuan ekledim

        }
        public int Length
        {
            get { return items.Length; } // eleman sayısını verir
        
        }
        public T[] Items
        {
            get { return items; } // elemanların kendisini verir

        }

    }
}
