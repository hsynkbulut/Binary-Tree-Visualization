namespace BinaryTreeUygulama.src.ApplicationTree
{
    internal class TreeNode
    {
        private long value;
        private int size;
        public TreeNode? leftChild;
        public TreeNode? rightChild;

        public TreeNode(long value)
        {
            this.value = value;
            size = 1;
            leftChild = rightChild = null;
        }

        public long Value { get { return value; } set { this.value = value; } }

        public int Size { get { return size; } set { this.size = value; } }

        public void IncreaseWeight() { size += 1; }

        public void DecreaseWeight() { size -= 1; }

        public override string? ToString()
        {
            return value.ToString();
        }
    }
}
