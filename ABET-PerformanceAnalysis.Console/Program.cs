// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using ABET_PerformanceAnalysis.Library;

Console.Clear();

#region 100 values
Console.WriteLine(new string('-', Console.WindowWidth));
Console.WriteLine("100");
Console.WriteLine(new string('-', Console.WindowWidth));

#region Define Variables
Stopwatch SW_Binary_100 = new();
BinaryTree binaryTree100 = new();

Stopwatch SW_Dictionary_100 = new();
Dictionary<int, int> dictionary100 = new();

Stopwatch SW_Array_100 = new();
int[] Array100 = new int[100];

#endregion

#region Generate Size 100 Collection
for (int i = 0; i < 100; i++)
{
    binaryTree100.InsertNode(i);
    dictionary100.Add(i, i);
    Array100[i] = i;
}
binaryTree100.Rebalance(binaryTree100.Root);
#endregion

SW_Binary_100.Start();
binaryTree100.SearchFor(99);
SW_Binary_100.Stop();

TimeSpan binary_100_ElapsedTime = SW_Binary_100.Elapsed;
Console.WriteLine($"Binary Search: {binary_100_ElapsedTime}");


SW_Dictionary_100.Start();
int value = dictionary100[99];
SW_Dictionary_100.Stop();

TimeSpan Dictionary_100_ElapsedTime = SW_Dictionary_100.Elapsed;
Console.WriteLine($"Dictionary Search: {Dictionary_100_ElapsedTime}");


SW_Array_100.Start();
for (int i = 0; i < Array100.Length; i++)
{
    if (Array100[i] == 99)
    {
        break;
    }

}
SW_Array_100.Stop();

TimeSpan Array_100_ElapsedTime = SW_Array_100.Elapsed;
Console.WriteLine($"Array Search: {Array_100_ElapsedTime}");
#endregion

#region 1000 values
Console.WriteLine(new string('-', Console.WindowWidth));
Console.WriteLine("1000");
Console.WriteLine(new string('-', Console.WindowWidth));

#region Define Variables
Stopwatch SW_Binary_1000 = new();
BinaryTree binaryTree1000 = new();

Stopwatch SW_Dictionary_1000 = new();
Dictionary<int, int> dictionary1000 = new();

Stopwatch SW_Array_1000 = new();
int[] Array1000 = new int[1000];

#endregion

#region Generate Size 1000 Collection
for (int i = 0; i < 1000; i++)
{
    binaryTree1000.InsertNode(i);
    dictionary1000.Add(i, i);
    Array1000[i] = i;
}
binaryTree1000.Rebalance(binaryTree1000.Root);
#endregion

SW_Binary_1000.Start();
binaryTree1000.SearchFor(999);
SW_Binary_1000.Stop();

TimeSpan binary_1000_ElapsedTime = SW_Binary_1000.Elapsed;
Console.WriteLine($"Binary Search: {binary_1000_ElapsedTime}");


SW_Dictionary_1000.Start();
value = dictionary1000[999];
SW_Dictionary_1000.Stop();

TimeSpan Dictionary_1000_ElapsedTime = SW_Dictionary_1000.Elapsed;
Console.WriteLine($"Dictionary Search: {Dictionary_1000_ElapsedTime}");


SW_Array_1000.Start();
for (int i = 0; i < Array1000.Length; i++)
{
    if (Array1000[i] == 999)
    {
        break;
    }

}
SW_Array_1000.Stop();

TimeSpan Array_1000_ElapsedTime = SW_Array_1000.Elapsed;
Console.WriteLine($"Array Search: {Array_1000_ElapsedTime}");
#endregion

#region 10000 values
Console.WriteLine(new string('-', Console.WindowWidth));
Console.WriteLine("10000");
Console.WriteLine(new string('-', Console.WindowWidth));

#region Define Variables
Stopwatch SW_Binary_10000 = new();
BinaryTree binaryTree10000 = new();

Stopwatch SW_Dictionary_10000 = new();
Dictionary<int, int> dictionary10000 = new();

Stopwatch SW_Array_10000 = new();
int[] Array10000 = new int[10000];

#endregion

#region Generate Size 10000 Collection
for (int i = 0; i < 10000; i++)
{
    binaryTree10000.InsertNode(i);
    dictionary10000.Add(i, i);
    Array10000[i] = i;
}
binaryTree10000.Rebalance(binaryTree10000.Root);
#endregion

SW_Binary_10000.Start();
binaryTree10000.SearchFor(9999);
SW_Binary_10000.Stop();

TimeSpan binary_10000_ElapsedTime = SW_Binary_10000.Elapsed;
Console.WriteLine($"Binary Search: {binary_10000_ElapsedTime}");


SW_Dictionary_10000.Start();
value = dictionary10000[9999];
SW_Dictionary_10000.Stop();

TimeSpan Dictionary_10000_ElapsedTime = SW_Dictionary_10000.Elapsed;
Console.WriteLine($"Dictionary Search: {Dictionary_10000_ElapsedTime}");


SW_Array_10000.Start();
for (int i = 0; i < Array10000.Length; i++)
{
    if (Array10000[i] == 9999)
    {
        break;
    }

}
SW_Array_10000.Stop();

TimeSpan Array_10000_ElapsedTime = SW_Array_10000.Elapsed;
Console.WriteLine($"Array Search: {Array_10000_ElapsedTime}");
#endregion

#region 100000 values
Console.WriteLine(new string('-', Console.WindowWidth));
Console.WriteLine("100000");
Console.WriteLine(new string('-', Console.WindowWidth));

#region Define Variables
Stopwatch SW_Binary_100000 = new();
BinaryTree binaryTree100000 = new();

Stopwatch SW_Dictionary_100000 = new();
Dictionary<int, int> dictionary100000 = new();

Stopwatch SW_Array_100000 = new();
int[] Array100000 = new int[100000];

#endregion

#region Generate Size 100000 Collection
for (int i = 0; i < 100000; i++)
{
    binaryTree100000.InsertNode(i);
    // binaryTree100000.Rebalance(binaryTree100000.Root);
    dictionary100000.Add(i, i);
    Array100000[i] = i;
}
binaryTree100000.Rebalance(binaryTree100000.Root);
#endregion

SW_Binary_100000.Start();
binaryTree100000.SearchFor(9999);
SW_Binary_100000.Stop();

TimeSpan binary_100000_ElapsedTime = SW_Binary_100000.Elapsed;
Console.WriteLine($"Binary Search: {binary_100000_ElapsedTime}");


SW_Dictionary_100000.Start();
value = dictionary100000[9999];
SW_Dictionary_100000.Stop();

TimeSpan Dictionary_100000_ElapsedTime = SW_Dictionary_100000.Elapsed;
Console.WriteLine($"Dictionary Search: {Dictionary_100000_ElapsedTime}");


SW_Array_100000.Start();
for (int i = 0; i < Array100000.Length; i++)
{
    if (Array100000[i] == 9999)
    {
        break;
    }

}
SW_Array_100000.Stop();

TimeSpan Array_100000_ElapsedTime = SW_Array_100000.Elapsed;
Console.WriteLine($"Array Search: {Array_100000_ElapsedTime}");
#endregion