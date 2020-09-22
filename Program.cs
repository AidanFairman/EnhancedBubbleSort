using System;
using System.Collections.Generic;

namespace EnhancedBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int count = 10;
            List<IComparable<int>> list = new List<IComparable<int>>();
            for(int i = 0; i < count; ++i){
                list.Add(rand.Next(10));
            }
            IComparable<int>[] classicStarter = list.ToArray();
            IComparable<int>[] modifiedStarter = list.ToArray();
            IComparable<int>[] enhancedStarter = list.ToArray();
        
            runSort(classicStarter, "Classic", BubbleSort.classic);
            runSort(modifiedStarter, "Modified", BubbleSort.modifiedClassic);
            runSort(enhancedStarter, "Enhanced", BubbleSort.enhancedBubble);
        }

        private static void runSort(IComparable<int>[] arr, string sortType, Action<IComparable<int>[]> sort){
            Console.Write("Starting list: ");
            BubbleSort.printList(arr);
            Console.WriteLine("{0} sort:", sortType);
            sort(arr);
            Console.Write("Ending list: ");
            BubbleSort.printList(arr);
        }
    }
}
