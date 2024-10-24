public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        // Insert to the left if value is smaller than the current node's data
        if (value < Data)
        {
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        // Insert to the right if value is greater than or equal to current node's data
        else
        {
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        // Check if the current node's data matches the target value
        if (value == Data)
            return true;
        else if (value < Data)
            return Left != null && Left.Contains(value); // Search in the left subtree
        else
            return Right != null && Right.Contains(value); // Search in the right subtree    
    }
    public int GetHeight()
    {
        // TODO Start Problem 4
        // Recursively calculate the height of left and right subtrees
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;

        // Return 1 plus the maximum height of the subtrees
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}