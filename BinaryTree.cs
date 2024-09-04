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
        if (value < node.Value)
            return FindRecursive(node.Left, value);
        else // value >= node.Value
            return FindRecursive(node.Right, value);
    }


}