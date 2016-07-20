using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBox
{
    class Startup
    {
        static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            var boxList=new List<Box<string>>();
            //var boxList = new List<Box<int>>();
            //var boxList=new List<IComparable>();

            for (int i = 0; i < numberOfLines; i++)
            {
                var stringBox = new Box<string>(Console.ReadLine());
                boxList.Add(stringBox);
                //var intBox = new Box<int>(int.Parse(Console.ReadLine()));
                //boxList.Add(intBox);
            }

            var comparableBox = new Box<string>(Console.ReadLine());

            Console.WriteLine(GenericCount(boxList, comparableBox));

            #region Generic Swap
            //int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int firstIndex = indexes[0];
            //int secondIndex = indexes[1];

            //Swap(boxList, firstIndex, secondIndex);

            //foreach (var box in boxList)
            //{
            //    Console.WriteLine(box);
            //} 
            #endregion
        }

        public static void Swap<T>(List<T> list, int firstIndex, int secondIndex)
        {
            T temp=list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }

        public static int GenericCount<T>(List<Box<T>> boxes, Box<T> comparableBox)
            where T:IComparable<T>
        {
            int count = 0;

            foreach (var box in boxes)
            {
                if (box.Value.CompareTo(comparableBox.Value)>0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
