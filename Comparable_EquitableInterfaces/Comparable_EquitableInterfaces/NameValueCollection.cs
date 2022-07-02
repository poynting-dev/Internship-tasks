﻿using System;
using System.Collections;
using System.Collections.Specialized;

public class SamplesNameValueCollection
{
    public static void SamplesNameValueCollectionExample()
    {
        NameValueCollection myCol = new NameValueCollection();
        myCol.Add("red", "rojo");
        myCol.Add("green", "verde");
        myCol.Add("blue", "azul");
        myCol.Add("red", "rouge");

        // Displays the values in the NameValueCollection in two different ways.
        Console.WriteLine("Displays the elements using the AllKeys property and the Item (indexer) property:");
        PrintKeysAndValues(myCol);
        Console.WriteLine("Displays the elements using GetKey and Get:");
        PrintKeysAndValues2(myCol);

        // Gets a value either by index or by key.
        Console.WriteLine("Index 1 contains the value {0}.", myCol[1]);
        Console.WriteLine("Key \"red\" has the value {0}.", myCol["red"]);
        Console.WriteLine();

        // Copies the values to a string array and displays the string array.
        String[] myStrArr = new String[myCol.Count];
        myCol.CopyTo(myStrArr, 0);
        Console.WriteLine("The string array contains:");
        foreach (String s in myStrArr)
            Console.WriteLine("   {0}", s);
        Console.WriteLine();

        // Searches for a key and deletes it.
        myCol.Remove("green");
        Console.WriteLine("The collection contains the following elements after removing \"green\":");
        PrintKeysAndValues(myCol);

        // Clears the entire collection.
        myCol.Clear();
        Console.WriteLine("The collection contains the following elements after it is cleared:");
        PrintKeysAndValues(myCol);
    }

    public static void PrintKeysAndValues(NameValueCollection myCol)
    {
        Console.WriteLine("   KEY        VALUE");
        foreach (String s in myCol.AllKeys)
            Console.WriteLine("   {0,-10} {1}", s, myCol[s]);
        Console.WriteLine();
    }

    public static void PrintKeysAndValues2(NameValueCollection myCol)
    {
        Console.WriteLine("   [INDEX] KEY        VALUE");
        for (int i = 0; i < myCol.Count; i++)
            Console.WriteLine("   [{0}]     {1,-10} {2}", i, myCol.GetKey(i), myCol.Get(i));
        Console.WriteLine();
    }
}