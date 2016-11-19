using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace _14253024HW2
{
    class homework<T> where T:IComparable
    {
        LinkedList<T> list = new LinkedList<T>();            
        public void create_linkedlist(T[] array1)//linked list olusturma methodu
        {          
           
            for (int i = 0; i < array1.Length; i++)
            {
                if(!list.Search_for_control(array1[i]))
                {
                    list.AddToEnd(array1[i]);
                }
            }                    
            list.Display();
        }
        public void search(T[] array)// b. madde için araya yapıp toplam hafıza işlem sayısını geri döndüren methot
        {
            int counter = 0,counter1=0;
            float avegare = 1;
            for (int i = 0; i < array.Length; i++)
            {
                counter += list.searhc1(array[i]);
                counter1 ++;
            }
            Console.WriteLine("Toplam hafıza erişim sayısı=\t"+counter + "\n");
            //Console.WriteLine(counter1);
           
            avegare =(float)counter / counter1;
            Console.WriteLine("Ortalama hafıza erişim değeri=\t"+avegare + "\n");
        }
        public void search_and_addFfront(T[] array)// c. madde için toplam hafıza işlem sayısını geri döndüren ve buluna degeri başa eklenmesi iiçin 
            //olustudugum methodu cagırdıgım methot
        {
           
            int counter = 0, counter1 = 0;
            float avegare = 1;
            for (int i = 0; i < array.Length; i++)
            {
                counter += list.Search_and_modify(array[i]);//
                counter1++;
            }
            Console.WriteLine("Toplam hafıza erişim sayısı=\t" + counter + "\n");
           // Console.WriteLine(counter1);

            avegare = (float)counter / counter1;
            Console.WriteLine("Ortalama hafıza erişim değeri=\t" + avegare+"\n");          
            Console.WriteLine("Listenin modifiye edilmiş hali\n");
            list.Display();
            Console.WriteLine();
                
        }
        public void selection_sort()//selection sort işlemini yapacak methodu cagırdıgım methot
        {

            list.selection_sort();
            list.Display();
        }
    }
}
