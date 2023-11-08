using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_and_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(25);
            myArrayList.Add("Sandy");
            myArrayList.Add(10);
            myArrayList.Add(100.663); 
            myArrayList.Add('A');
            myArrayList.Add(2);
            myArrayList.Add(25); 
            myArrayList.Remove(25);
            myArrayList.RemoveAt(1);
            foreach (object j in myArrayList) { Console.WriteLine(j); }
            Console.WriteLine(myArrayList.Count);
            double sum =0;
            foreach (object obj in myArrayList) 
            { 
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;   
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine(sum);
            Console.Read();
        }
    }
}
