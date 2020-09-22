# EnhancedBubbleSort
Quick enhanced bubble sort. 
1. see the code. it will output the resulting list each time.
2. Time complexity of bubble sort is O(n^2) because you go through the list of n items n times for a full sort. This is the worst case complexity. The best case is O(n), but that only happens if the list is already in order. We did n-1 comparisons, traversing the n sized list. The enhanced is O(n*log n). We go one less far each time (we know the last unit is for-sure in order) so we don't even check. This reduces the work each cycle. Adding a short-circuit if we didn't do any swaps further enhances the bubble sort.
3. There are 3 methods: classic, modified (short circuit), and enhanced. Use modified for this question. Each prints the starting list, the list after each scan, the resulting list, and the number of swaps and comparisons made.
4. discussion
   1. Bubble sort takes an input of a set. That is the only way it operates.
   2. Bubble sort outputs the same set, but in a specific order.
   3. Bubble sort is a well defined algorithm. You move through the set and compare values, swapping if the first is larger than the second, repeating until ordered.
   4. As long as the comparison returns correct results, the bubble sort will also return correct results.
   5. Bubble sort is finite, in that operation time is n^2 at worst. Large n will result in incredibly large run time.
   6. Bubble sort is very effective. As long as the comparitor is good, the sort will generate correct results.
   7. Bubble sort is generic in that it can sort any SET of COMPARABLE data. As long as one can be determined to be less/smaller than the other, bubble sort works.
