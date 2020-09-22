using System;
using System.Collections.Generic;
using System.Text;

namespace Enhanced_bubble{
    public static class BubbleSort{
        public static void classic<T>(IComparable<T>[] list){
            for(int i = 0; i < list.Length; ++i){
                for(int k = 0; k < list.Length-1; ++k){
                    if(list[k].CompareTo(list[k+1]) >0){
                        swap(list, k, k+1);
                    }
                }
                printList(list);
            }
        }

        public static void modifiedClassic<T>(IComparable<T>[] list){
            for(int i = 0; i < list.Length; ++i){
                bool swapped = false;
                for(int k = 0; k < list.Length-1; ++k){
                    if(list[k].CompareTo(list[k+1]) >0){
                        swap(list, k, k+1);
                        swapped = true;
                    }
                }
                if(!swapped){
                    return list;
                }
                printList(list);
            }
        }

        public static void enhancedBubble<T>(IComparable<T>[] list){
            for(int i = 0; i < list.Length; ++i){
                bool swapped = false;
                for(int k = 0; k < list.Length-(i+1); ++k){
                    if(list[k].CompareTo(list[k+1]) >0){
                        swap(list, k, k+1);
                        swapped = true;
                    }
                }
                if(!swapped){
                    return list;
                }
                printList(list);
            }
        }

        public static void printList<T>(Comparable<T>[] list){
            StringBuilder sb = new StringBuilder();
            sb.Append("[ ");
            foreach(T item in list){
                sb.Append(item).Append(" ");
            }
            sb.Append("]");
            Console.WriteLine(sb.ToString());
        }

        private static void swap<T>(IComparable<T>[] list, int from, int to){
            T temp = list[from];
            list[from] = list[to];
            list[to] = temp;
        }
    }
}