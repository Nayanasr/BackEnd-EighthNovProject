using System;
using System.Collections.Generic;
using System.Text;

namespace EighthNov
{
    public class Practice
    {
        public void even() {
            //int i;
            //Console.Write("enter a number: ");
            //i = int.Parse(Console.ReadLine());

            //if (i % 2 == 0) {
            //    Console.Write("This is a even number");
            //}
            //else {
            //    Console.Write("This is not a even number");
            //}
            int[] numb = new[] { 4, 5, 6, 7, 8, 9, 10, 12,15,16,30,20 };
            int even = 0;
            for (int i = 0; i < numb.Length; i++) {
                var data = (numb[i] % 2 == 0) ? even = numb[i] : 0;
                Console.WriteLine(data);

            }

        }
    }
}
//write a program of sorting the array declare single dimension array accept 5 value and display in order

