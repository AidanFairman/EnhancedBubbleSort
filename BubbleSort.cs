using System;
using System.Collections.Generic;
using System.Text;

namespace EnhancedBubbleSort{
    public static class BubbleSort{
        public static void classic<T>(IComparable<T>[] list){
            int swaps = 0;
            int comparisons = 0;
            for(int i = 0; i < list.Length; ++i){
                for(int k = 0; k < list.Length-1; ++k){
                    ++comparisons;
                    if(list[k].CompareTo((T)list[k+1]) >0){
                        swap(list, k, k+1);
                        ++swaps;
                    }
                }
                printList(list);
            }
            printComparesAndSwaps(comparisons, swaps);
        }

        public static void modifiedClassic<T>(IComparable<T>[] list){
            int swaps = 0;
            int comparisons = 0;
            for(int i = 0; i < list.Length; ++i){
                bool swapped = false;
                for(int k = 0; k < list.Length-1; ++k){
                    ++comparisons;
                    if(list[k].CompareTo((T)list[k+1]) >0){
                        swap(list, k, k+1);
                        ++swaps;
                        swapped = true;
                    }
                }
                if(!swapped){
                    break;
                }
                printList(list);
            }
            printComparesAndSwaps(comparisons, swaps);
        }

        public static void enhancedBubble<T>(IComparable<T>[] list){
            int swaps = 0;
            int comparisons = 0;
            for(int i = 0; i < list.Length; ++i){
                bool swapped = false;
                for(int k = 0; k < list.Length-(i+1); ++k){
                    ++comparisons;
                    if(list[k].CompareTo((T)list[k+1]) >0){
                        swap(list, k, k+1);
                        ++swaps;
                        swapped = true;
                    }
                }
                if(!swapped){
                    break;
                }
                printList(list);
            }
            printComparesAndSwaps(comparisons, swaps);
        }

        public static void printList<T>(IComparable<T>[] list){
            StringBuilder sb = new StringBuilder();
            sb.Append("[ ");
            foreach(IComparable item in list){
                sb.Append(item).Append(" ");
            }
            sb.Append("]");
            Console.WriteLine(sb.ToString());
        }

        public static void printComparesAndSwaps(int compares, int swaps){
            Console.WriteLine("Compares: {0}", compares);
            Console.WriteLine("Swaps:    {0}", swaps);
        }

        private static void swap<T>(IComparable<T>[] list, int from, int to){
            IComparable<T> temp = list[from];
            list[from] = list[to];
            list[to] = temp;
        }
    }
}