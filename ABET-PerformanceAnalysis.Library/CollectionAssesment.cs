using System.Diagnostics;

namespace ABET_PerformanceAnalysis.Library;

public class CustomStopWatch
{
    Stopwatch stopwatch = new Stopwatch();


}

public class Node(int data)
{
    public int Data { get; set; } = data;
    public Node? Left { get; set; }
    public Node? Right { get; set; }
}

public class BinaryTree
{
    public Node? Root { get; set; }

    public void InsertNode(int value)
    {
        Root = InsertNode(Root!, new Node(value));
    }
    public Node InsertNode(Node currentNode, Node newNode)
    {
        if (currentNode == null)
        {
            return newNode!;
        }

        if (newNode.Data < currentNode.Data)
        {
            currentNode.Left = InsertNode(currentNode.Left!, newNode);
        }
        else if (newNode.Data > currentNode.Data)
        {
            currentNode.Right = InsertNode(currentNode.Right!, newNode);
        }
        return currentNode;
    }

    public Node? SearchFor(int data)
    {
        return SearchFor(data, Root);
    }
    public Node? SearchFor(int data, Node? currentNode)
    {
        if (currentNode == null)
        {
            return null;
        }
        if (currentNode.Data == data)
        {
            return currentNode;
        }
        else
        {
            if (data < currentNode!.Data)
            {
                return SearchFor(data, currentNode!.Left);
            }
            else
            {
                return SearchFor(data, currentNode!.Right);
            }
        }
    }

    public bool IsBalanced()
    {
        int LeftHeight = GetHeight(Root.Left!);
        int RightHeight = GetHeight(Root.Right!);

        return Math.Abs(LeftHeight - RightHeight) <= 1 ? true : false;
    }
    public int GetHeight(Node node)
    {
        if (node == null)
        {
            return -1;
        }

        return Math.Max(GetHeight(node.Left), GetHeight(node.Right)) + 1;
    }

    public void Rebalance(Node currentNode)
    {

        bool stillBalancing = true;
        do
        {
            int LeftHeight = GetHeight(Root.Left);
            int RightHeight = GetHeight(Root.Right);
            if (LeftHeight > RightHeight)
            {
                Node oldRoot = Root;
                Node newRoot = Root.Left;
                Node newLeft = Root.Left.Left ?? Root.Left.Right;

                Root = newRoot;
                newRoot.Right = oldRoot;
                newRoot.Right.Left = null;
                oldRoot.Left = newLeft;
            }
            else
            {
                Node oldRoot = Root;
                Node newRoot = Root.Right;
                Node newRight = Root.Right.Right ?? Root.Right.Left;

                Root = newRoot;
                newRoot.Left = oldRoot;
                newRoot.Left.Right = null;
                newRoot.Right = newRight;

            }
            if (IsBalanced())
            {
                stillBalancing = false;
            }
        } while (stillBalancing);


    }
}