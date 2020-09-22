using System;
using System.Collections.Generic;
using Enhanced_bubble;
class Main
{
    public static void main()
    {
        List<int> list = new List<int>{4, 6, 2, 3, 7, 1, 9, 0};
        int[] classicStarter = list.ToArray();
        int[] modifiedStarter = list.ToArray();
        int[] enhancedStarter = list.ToArray();
        
        runSort(classicStarter, "Classic", BubbleSort.classic);
        runSort(modifiedStarter, "Modified", BubbleSort.modifiedClassic);
        runSort(enhancedStarter, "Enhanced", BubbleSort.enhancedBubble);
    }

    private static runSort(int[] list, string sortType, Delegate sort){
        Console.Write("Starting list: ");
        BubbleSort.printList(list);
        Console.WriteLine("{0} sort:", sortType);
        sort(list);
        Console.Write("Ending list: ");
        BubbleSort.printList(list);
    }
}
