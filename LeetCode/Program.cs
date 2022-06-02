// See https://aka.ms/new-console-template for more information


using System.Collections;

Console.WriteLine("Hello, World!");
Console.WriteLine(SingleNumberMySolution(new[] { 4, 1, 2, 1, 2 }));

int SingleNumberMySolution(int[] nums)
{
    var hashTable = new Hashtable();

    foreach (var num in nums)
        if (hashTable.Contains(num))
            hashTable[num] = false;
        else
            hashTable.Add(num, true);

    foreach (var num in hashTable.Keys)
        if ((bool)(hashTable[num] ?? false))
            return (int)num;

    return 0;
}

int SingleNumberXor(int[] nums)
{
    var numberXor = 0;
    foreach (var num in nums) numberXor ^= num;
    return numberXor;
}