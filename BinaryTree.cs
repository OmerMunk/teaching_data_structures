namespace data_structures;

public class BinaryTree
{
    private TreeNode root;

    public BinaryTree()
    {
        root = null;
    }

    public void Insert(int value)
    {
        root = InsertRecursive(root, value);
    }

    private TreeNode InsertRecursive(TreeNode node, int value)
    {
        if (node == null)
        {
            node = new TreeNode(value);
            return node;
        }
        if (value < node.Value)
            node.Left = InsertRecursive(node.Left, value);
        else // value >= node.Value
            node.Right = InsertRecursive(node.Right, value);
        return node;
    }
    
    public bool Find(int value)
    {
        return FindRecursive(root, value);
    }

    private bool FindRecursive(TreeNode node, int value)
    {
        if (node == null)
            return false;
        if (node.Value == value)
            return true;
        
        return FindRecursive(
            value < node.Value ? node.Left : node.Right,
            value
            );
    }

    public int? getMin()
    {
        return getMin(root);
    }
    
    private int? getMin(TreeNode node)
    {
        if (node == null) return null;
        while (node.Left != null)
        {
            node = node.Left;
        }
        return node.Value;
    }
    
    // do the max alone


}