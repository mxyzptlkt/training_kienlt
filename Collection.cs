using System;
using System.Collections.Generic;

namespace Collection
{
    public class collectionEx
    {
        public static void Ex1()
        {
            List<int> inputList = new List<int> {10, 9, 2, 5, 4,
                                                1, 3, 7, 6, 8};
            inputList.ForEach(listElement => Console.WriteLine($"{listElement} "));
        }
        public static void Ex2(List<int> inputList)
        {
            inputList.Sort();
            inputList.ForEach(listElement => Console.WriteLine($"{listElement} "));
        }
        public static void Ex3(List<int> inputList)
        {
            inputList.Reverse();
            inputList.ForEach(listElement => Console.WriteLine($"{listElement} "));
        }
        public static void Ex4(List<int> inputList, int inputNumber)
        {
            inputList.RemoveAll(listElement => listElement < inputNumber);
            inputList.ForEach(listElement => Console.WriteLine($"{listElement} "));
        }
        public static void Ex5(List<int> inputList, int inputNumber)
        {
            inputList.RemoveAll(listElement => listElement % inputNumber == 0);
            inputList.ForEach(listElement => Console.WriteLine($"{listElement} "));
        }
        public static void Ex6(List<int> inputList, int inputNumber)
        {
            inputList.ForEach(listElement => listElement < inputNumber ? listElement += inputNumber);
            inputList.ForEach(listElement => Console.WriteLine($"{listElement} "));
        }
    }
}