namespace SchoolCollections
{
    public class BinTreeNode<T>
    {
        private T value;
        private BinTreeNode<T> left;
        private BinTreeNode<T> right;
        
        public BinTreeNode(T value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }
        
        public BinTreeNode(BinTreeNode<T> left, T value, BinTreeNode<T> right)
        {
            this.left = left;
            this.value = value;
            this.right = right;
        }
        
        public T GetValue()
        {
            return this.value;
        }
        
        public BinTreeNode<T> GetLeft()
        {
            return this.left;
        }
        
        public BinTreeNode<T> GetRight()
        {
            return this.right;
        }
        
        public bool HasLeft()
        {
            return (this.left != null);
        }
        
        public bool HasRight()
        {
            return (this.right != null);
        }
        
        public void SetValue(T value)
        {
            this.value = value;
        }
        
        public void SetLeft(BinTreeNode<T> left)
        {
            this.left = left;
        }
        
        public void SetRight(BinTreeNode<T> right)
        {
            this.right = right;
        }
        
        public static int NumOfNodes(BinTreeNode<T> t)
        {
            if (t == null)
                return 0;
            return NumOfNodes(t.GetLeft()) + NumOfNodes(t.GetRight()) + 1;
        }
        
        public override string ToString()
        {
            return "( " + this.left + " " + this.value + " " + this.right + " )";
        }
    }
}