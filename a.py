   
    def __init__():
        root = None
       
    def Insert(int value):
        root = InsertRecursive(root, value)
    

    private TreeNode InsertRecursive(TreeNode node, int value)
    {
        if not Node:
        
            node = TreeNode(value);
            return node
        
        if value < node.Value
            node.Left = InsertRecursive(node.Left, value);
        else // value >= node.Value
            node.Right = InsertRecursive(node.Right, value);
        return node;
    }