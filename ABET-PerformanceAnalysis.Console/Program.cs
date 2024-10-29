// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using ABET_PerformanceAnalysis.Library;

#region Define Variables
Stopwatch SW_Binary_100 = new();
BinaryTree binaryTree100 = new();

#endregion

#region Generate Size 100 Collection
for (int i = 0; i < 100; i++)
{
    binaryTree100.InsertNode(i);
}
#endregion

SW_Binary_100.Start();
SW_Binary_100.Stop();

TimeSpan ElapsedTime = SW_Binary_100.Elapsed;

Console.WriteLine(ElapsedTime);