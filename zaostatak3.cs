﻿using System;

class Sort
{
    public static void QuickSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);

            if (pivot > 1)
            {
                QuickSort(arr, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                QuickSort(arr, pivot + 1, right);
            }
        }
    }

    private static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[left];
        while (true)
        {
            while (arr[left] > pivot)
            {
                left++;
            }
            while (arr[right] < pivot)
            {
                right--;
            }
            if (left < right)
            {
                if (arr[left] == arr[right]) return right;

                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
            }
            else
            {
                return right;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 7, 2, 4, 1, 5, 9, 3 };

        Console.WriteLine("Nesortiran niz:");
        PrintArray(arr);

        Sort.QuickSort(arr, 0, arr.Length - 1);

        Console.WriteLine("\nSortiran niz u silaznom redoslijedu:");
        PrintArray(arr);

        Console.ReadLine();
    }

    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}



