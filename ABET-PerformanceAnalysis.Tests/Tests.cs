using ABET_PerformanceAnalysis.Library;
using FluentAssertions;

namespace ABET_PerformanceAnalysis.Tests;

public class Tests
{
    [Fact]
    public void BinaryTreeShouldInsertFirstNewNodeAsRoot()
    {
        BinaryTree binaryTree = new();
        binaryTree.InsertNode(5);
        binaryTree.Root!.Data.Should().Be(5);
    }

    [Fact]
    public void BinaryTreeShouldInsertNodeToLeft()
    {
        // Arrange
        BinaryTree binaryTree = new();
        // Act
        binaryTree.InsertNode(5);
        binaryTree.InsertNode(3);
        // Assert
        binaryTree.Root!.Left!.Data.Should().Be(3);

    }

    [Fact]
    public void BinaryTreeShouldInsertNodeToRight()
    {
        // Arrange
        BinaryTree binaryTree = new();
        // Act
        binaryTree.InsertNode(5);
        binaryTree.InsertNode(6);
        // Assert
        binaryTree.Root!.Right!.Data.Should().Be(6);

    }

    [Fact]
    public void BinaryTreeShouldSearchAndReturnNull()
    {
        // Arrange
        BinaryTree binaryTree = new();
        // Act
        binaryTree.InsertNode(5);
        binaryTree.InsertNode(6);
        binaryTree.InsertNode(7);
        binaryTree.InsertNode(3);
        binaryTree.InsertNode(4);
        binaryTree.InsertNode(1);
        Node? returnNode = binaryTree.SearchFor(8, binaryTree.Root);
        // Assert
        returnNode.Should().BeNull();

    }

    [Fact]
    public void BinaryTreeShouldSearchAndReturnNode()
    {
        // Arrange
        BinaryTree binaryTree = new();
        // Act
        binaryTree.InsertNode(5);
        binaryTree.InsertNode(6);
        binaryTree.InsertNode(7);
        binaryTree.InsertNode(3);
        binaryTree.InsertNode(4);
        binaryTree.InsertNode(1);
        Node? returnNode = binaryTree.SearchFor(4);
        // Assert
        returnNode!.Data.Should().Be(4);
    }

    [Fact]
    public void BinaryTreeShouldBeBalanced()
    {
        // Arrange
        BinaryTree binaryTree = new();
        // Act
        binaryTree.InsertNode(2);
        binaryTree.InsertNode(1);
        binaryTree.InsertNode(3);

        // Assert
        binaryTree.IsBalanced().Should().BeTrue();
    }

    [Fact]
    public void BinaryTreeShouldNotBeBalanced()
    {
        // Arrange
        BinaryTree binaryTree = new();
        // Act
        binaryTree.InsertNode(2);
        binaryTree.InsertNode(1);
        binaryTree.InsertNode(3);
        binaryTree.InsertNode(4);
        binaryTree.InsertNode(5);

        // Assert
        binaryTree.IsBalanced().Should().BeFalse();
    }

    [Fact]
    public void BinaryTreeShouldNotBeBalancedRotateThenBeBalanced()
    {
        // Arrange
        BinaryTree binaryTree = new();
        // Act
        binaryTree.InsertNode(2);
        binaryTree.InsertNode(1);
        binaryTree.InsertNode(3);
        binaryTree.InsertNode(4);
        binaryTree.InsertNode(5);
        binaryTree.Rebalance(binaryTree.Root!);

        // Assert
        binaryTree.IsBalanced().Should().BeTrue();
    }
}
