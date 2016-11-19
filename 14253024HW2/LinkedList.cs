using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253024HW2
{
    class LinkedList<T> where T: IComparable
    {
        Node<T> head;
        
        public void AddToFront(T val)
        {
            Node<T> newNode = new Node<T>(val);
            newNode.Next = head;
            head = newNode;
        }

        public void AddToEnd(T val)
        {
            Node<T> newNode = new Node<T>(val);
            Node<T> iterator = head;
            if (head == null)
                head = newNode;
            else
            {
                while (iterator.Next != null)
                {
                    iterator = iterator.Next;
                }
                iterator.Next = newNode;
            }
        }
        public void delete(T val)
        {
            
           if(head.Value.CompareTo(val)==0)
            {
                head = head.Next;
            }
            else
            {
                Node<T> iterator = head;
                Node<T> prev = head;
                while (iterator.Value.CompareTo(val) != 0)
                {
                    prev = iterator;
                    iterator = iterator.Next;
                }
                prev.Next = iterator.Next;
            }
                   
            
        }
        public void DeleteLast()
        {
            Node<T> iterator = head;
            Node<T> prev = head;

            if (head == null || head.Next == null)
                head = null;
            else
            {
                while (iterator.Next != null)
                {
                    prev = iterator;
                    iterator = iterator.Next;
                }
                prev.Next = null;
            }
        }

        public void Display()
        {
            Node<T> iterator = head;
            while (iterator != null)
            {
                Console.Write(iterator.Value + " ");
                iterator = iterator.Next;
            }
            Console.WriteLine();
        }
        public int searhc1(T val)//hafıza işlem sayısını hesaplamak için yeniden düzenledigim methot
        {
            int flag = 0;
            Node<T> iterator = head;
            if (head == null)
                Console.WriteLine("The linked list is empty!!!");
            else
            {
               
                while (iterator != null)
                {
                    flag++;
                    if (iterator.Value.CompareTo(val) == 0)
                    {
                        
                        break;                  
                    }
                    else
                        iterator = iterator.Next;
                  
                }
               
            }
            return flag;
        }
        public bool Search_for_control(T val)
        {
            Node<T> iterator = head;
            if (head == null)
                return false;
            else
            {
                while (iterator != null)
                {
                    if (iterator.Value.CompareTo(val) == 0)
                    {
                        return true;
                    }
                    iterator = iterator.Next;
                }
                return false;
            }
        }
        public int Search_and_modify(T val)//kendi ekledigim methot c. madde için
        {
          
            int flag = 1;
            Node<T> iterator = head;
            Node<T> prev = head;
            if (head == null)
                Console.WriteLine("The linked list is empty!!!");
            else if (head.Value.CompareTo(val) == 0)
            {

                return flag;
            }
            else
            {
                while (iterator.Next != null)
                {
                    flag++;
                    prev = iterator;
                    iterator = iterator.Next;
                    if (iterator.Value.CompareTo(val) == 0)
                    {
                        delete(val);
                        AddToFront(iterator.Value);
                        //prev.Next = iterator.Next;
                                             
                        break;
                    }
                   
                }
            }
            return flag;
        }
        public void selection_sort()//e. madde için kendi ekledigim methot
        {
           
            Node<T> iterator2 = head;
            Node<T> iterator3 = head;
            Node<T> prev = head;         
            T max;         
            int size = Count();
            int counter = 0,counter1=0;
           
            if (head == null)
                Console.WriteLine("The linked list is empty!!!");
            else
            {
                try
                {
                    while (counter<size)
                    {
                        Node<T> iterator = head;
                       while(counter1<counter)
                        {
                            iterator = iterator.Next;
                            counter1++;
                        }
                        counter1 = 0;
                        max = iterator.Value;
                      
                        while (iterator!= null)
                        {
                           
                            if (iterator != null && iterator.Value.CompareTo(max) == 1)
                            {
                                max = iterator.Value;                              
                            }
                            iterator = iterator.Next;
                        }
                     //  Display();
                        delete(max);
                        AddToFront(max);
                       if(iterator==null)
                        {
                            delete(max);
                            AddToFront(max);                        
                        }
                      //  Console.WriteLine(max);                                                             
                        counter++;
                    }
                   // Display();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex);
                }
            }
           
        }
        public void AddToOrderedList(T val)
        {
            Node<T> newNode = new Node<T>(val);
            Node<T> iterator = head;
            if (head == null)
                head = newNode;
            else
            {
                if (head.Value.CompareTo(val) > 0)
                {
                    newNode.Next = head;
                    head = newNode;
                }
                else
                {
                    while (iterator.Next != null && iterator.Next.Value.CompareTo(val) <= 0)
                    {
                        iterator = iterator.Next;
                    }
                    newNode.Next = iterator.Next;
                    iterator.Next = newNode;
                }
            }
        }
        public int Count()
        {
            int count = 0;
            Node<T> iterator = head;
            while (iterator != null)
            {
                count++;
                iterator = iterator.Next;
            }
            return count;
        }
    }
}
