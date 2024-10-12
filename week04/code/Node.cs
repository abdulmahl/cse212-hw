// DO NOT MODIFY THIS FILE

public class Node
{
    public int Data { get; set; }
    public Node? Next { get; set; }
    public Node? Prev { get; set; }
    public int Value { get; internal set; }

    public Node(int data)
    {
        this.Data = data;
    }

    internal void Remove(int value)
    {
        throw new NotImplementedException();
    }
}