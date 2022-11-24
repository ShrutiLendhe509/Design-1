
using System.Collections.Generic;
// Time Complexity :O(1)
// Space Complexity :O(n)
// Did this code successfully run on Leetcode :Yes
// Any problem you faced while coding this :No
public class MyHashSet
{
    int[] num;
    public MyHashSet()
    {
        num = new int[100011];
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = -1; //intializing the default array value with -1
        }
    }

    public void add(int key)
    {
        int index = GetHashIndex(key);

        if (num[index] == key) //checking if key exists in  num[]
        {
            return; 
        }
        else if (num[index] == -1)
        {
            num[index] = key; //updating the key if not exist in num[]
            return;
        }

    }

    public void remove(int key)
    {
        int index = GetHashIndex(key);
        if (num[index] == key)// if key exits
            num[index] = -1;  //assign -1 for removing.
        return;
    }

    public bool contains(int key)
    {
        int index = GetHashIndex(key);

        if (num[index] == key) // key matches with num[i] value 
            return true;    // return true         


        return false;
    }

    public int GetHashIndex(int key)
    {
        return key % num.Length;
    }

    public static void Main(String[] args)
    {
        bool val = false;
        MyHashSet hashSet = new MyHashSet();
        hashSet.add(1);
        hashSet.add(2);
        val = hashSet.contains(1);    // returns true
        Console.WriteLine(val);
        val = hashSet.contains(3);    // returns false (not found)
        Console.WriteLine(val);
        hashSet.add(2);
        val = hashSet.contains(2);    // returns true
        Console.WriteLine(val);
        hashSet.remove(2);
        val = hashSet.contains(2);    // returns false (already removed)
        Console.WriteLine(val);
        Console.ReadLine();
    }

}
