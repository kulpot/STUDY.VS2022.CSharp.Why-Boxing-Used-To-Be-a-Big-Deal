using System;
using System.Collections;
using System.Collections.Generic;

//ref link:https://www.youtube.com/watch?v=7QYX0v2KD8U&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=17
//  Generic Knowledge(new) vs boxing(oldways)



class MainClass
{
    static void Main()
    {
        // Boxing
        object [] items = new object[5];    // requires boxing cause of object
        items[0] = 5;   // box 
        items[1] = 13;  // box
        items[2] = 18;  // box
        ArrayList meList = new ArrayList(); //old
        meList.Add(5);
        meList.Add(13);
        meList.Add(18);





        // Generics
        List<int> meList2 = new List<int>(); //new
        int[] values = new int[5];  // stores directly no boxing
        values[0] = 5;   
        values[1] = 13;
        values[2] = 18;
        meList2.Add(5);
        meList2.Add(13);
        meList2.Add(18);
    }

    /*  why is list<int> going on heap when it's a value type?
     * 
     * FIrst, List<T> is itself a reference type. 
Furthermore, when you allocate an array (i.e. a List<T>) - in C# - the default is to allocate it on the heap.
The equivalent action in C would be
int* meList = (int*)malloc(100 * sizeof(int)); // malloc ^= "Memory Allocation"
Whereas an array on the stack in C is
int meList[100];
In C# you can also create arrays on the stack in an unsafe context with
int* meList = stackalloc int[100];
     */
}