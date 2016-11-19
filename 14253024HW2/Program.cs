using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _14253024HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            homework<int> hm = new homework<int>();
          
           
            string[] linklist;
            string[] listControl;
            string text_local = @"C:numbers.txt";
            string text_to_list, text_to_control;
            int[] link_list;
            int[] list_control;
            FileStream filestrm = new FileStream(text_local, FileMode.Open, FileAccess.Read);
            StreamReader strread = new StreamReader(filestrm);
            text_to_list = strread.ReadLine();
            text_to_control = strread.ReadLine();
            //Console.WriteLine(text_to_list);
            //Console.WriteLine(text_to_control);
            linklist = text_to_list.Split(',');
            listControl = text_to_control.Split(',');
           
            link_list = new int[linklist.Length];
            list_control = new int[listControl.Length];
            Console.WriteLine("a. madde işlemleri\n");
            Console.WriteLine("dosyadan verilerin ilk cekilmiş hali\n");
            for (int i = 0; i < linklist.Length; i++)
            {
                link_list[i] = Convert.ToInt32(linklist[i]);
                Console.Write(link_list[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < listControl.Length; i++)
            {
                list_control[i] = Convert.ToInt32(listControl[i]);
                //Console.Write(list_control[i] + " ");
            }
            Console.WriteLine();
           
            Console.WriteLine("Linkeed listin olusturulmus hali\n");
            hm.create_linkedlist(link_list);
            Console.WriteLine("*****************************************************************\n");
            Console.WriteLine("b. madde işlemleri\n");
            hm.search(list_control);
            Console.WriteLine("*****************************************************************\n");
            Console.WriteLine("c. madde işlemleri\n");
            hm.search_and_addFfront(list_control);
            Console.WriteLine("*****************************************************************\n");
            Console.WriteLine("d. madde içi değerlendirme\n");
            Console.WriteLine("---c. madde işlemleri yaparken bulunan elaman en başa atıldıgı için iki farklı durum orataya cıktı"+
                "\n--ilk durum: eger aranacak elemanların hepsi farklı ise bulunan eleman herseferinde başa atılıgı için\n"+
                "diger elemanlar hepdaha ileriye atılacaktır bu yüzden arama sırasında daha fazla hafıza işlemi yapılacaktır\n"+
                "--ikinci durum: eger sürekli aynı elemanlar aranıyorsa bu eleman ilk kez bulundugunda başa atıldıgı için\n"+
                "tekrar aranmak istediginde baglı listin en basında olacagı için az sayısa hafıza erişim işlemi gercekleşecektir.\n"+
                "--Sonuc : Birbirinden farklı elamanlar aranırken b. madde işlemleri daha verimli olacaktır.\n"+
                "aranan bir eleman sık aranan bir elemansa c. madde işlemleri daha verimli olacaktır.\n"+
                "  c. madde işlemleri özellikle bazı degerlerin sık sık sorgulandıgı veri tabanlarında büyük fayda saglayacaktır\n"+
                "ve en cok hangi degerlerin arandıgı konusunda istatistik bilgiler verecektir");  
            Console.WriteLine("*****************************************************************\n");
            Console.WriteLine("e. madde işlemleri\n");
            Console.WriteLine("Listenin sıralanmıiş hali\n");
            hm.selection_sort();
            Console.WriteLine();
            filestrm.Close();
            strread.Close();
            
            
        }
    }
}
