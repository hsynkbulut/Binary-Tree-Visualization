namespace BinaryTreeUygulama.src.ApplicationTree
{
    internal class BinarySearchTree
    {
        public TreeNode? root;

        public BinarySearchTree()
        {
            root = null;
        }

        public BinarySearchTree(long value)
        {
            root = new TreeNode(value);
        }

        public void Insert(long value)
        {
            try
            {
                root = InsertTo(value, root);
            }
            catch (Exception)
            {
            }
        }

        public void Remove(long value)
        {
            try
            {
                root = RemoveFrom(value, root);
            }
            catch (Exception)
            {
            }
        }

        public List<NodeInfo> GetNodesInfo()
        {
            if (root == null)
            {
                return Enumerable.Empty<NodeInfo>().ToList();
            }
            var result = new List<NodeInfo>(root.Size);
            AddNodeInfosToList(root, null, result);
            return result;
        }

        private TreeNode? InsertTo(long  value, TreeNode? root)
        {
            if (root == null)
            {
                root = new TreeNode(value);
                return root;
            }
            if (value > root.Value)
            {
                root.rightChild = InsertTo(value, root.rightChild);
                root.IncreaseWeight();
            }
            else if (value < root.Value)
            {
                root.leftChild = InsertTo(value, root.leftChild);
                root.IncreaseWeight();
            }
            else if (value == root.Value)
            {
                throw new Exception();
            }
            return root;
        }

        private TreeNode? RemoveFrom(long value, TreeNode? root)
        {
            if (root == null)
            {
                throw new Exception();
            }

            if (value > root.Value)
            {
                 root.rightChild = RemoveFrom(value, root.rightChild);
                 root.DecreaseWeight();
            }
            else if (value < root.Value)
            {
                root.leftChild = RemoveFrom(value, root.leftChild);
                root.DecreaseWeight();
            }
            else
            {
                if (root.rightChild == null)
                {
                    root.DecreaseWeight();
                    return root.leftChild;
                }
                if (root.leftChild == null)
                {
                    root.DecreaseWeight();
                    return root.rightChild;
                }
                root.Value = MinValue(root.rightChild);
                root.rightChild = RemoveFrom(root.Value, root.rightChild);
                root.DecreaseWeight();
            }
            return root;
        }

        private long MinValue(TreeNode root)
        {
            long minValue = root.Value;
            while (root.leftChild != null)
            {
                minValue = root.leftChild.Value;
                root = root.leftChild;
            }
            return minValue;
        }

        private void AddNodeInfosToList(TreeNode? node, NodeInfo? parentNodeInfo, List<NodeInfo> list) 
        {
            if (node == null)
            {
                return;
            }
            var nodeInfo = NodeInfo.Create(node, parentNodeInfo);
            AddNodeInfosToList(node.leftChild, nodeInfo, list);
            AddNodeInfosToList(node.rightChild, nodeInfo, list);
            list.Add(nodeInfo);
        }

        public List<long> PreOrderTraversal()
        {
            List<long> traversal = new List<long>();
            PreOrderTraversal(root, traversal);
            return traversal;
        }

        private void PreOrderTraversal(TreeNode node, List<long> traversal)
        {
            if (node != null)
            {
                traversal.Add(node.Value);
                PreOrderTraversal(node.leftChild, traversal);
                PreOrderTraversal(node.rightChild, traversal);
            }
        }

        public List<long> InOrderTraversal()
        {
            List<long> traversal = new List<long>();
            InOrderTraversal(root, traversal);
            return traversal;
        }

        private void InOrderTraversal(TreeNode node, List<long> traversal)
        {
            if (node != null)
            {
                InOrderTraversal(node.leftChild, traversal);
                traversal.Add(node.Value);
                InOrderTraversal(node.rightChild, traversal);
            }
        }

        public List<long> PostOrderTraversal()
        {
            List<long> traversal = new List<long>();
            PostOrderTraversal(root, traversal);
            return traversal;
        }

        private void PostOrderTraversal(TreeNode node, List<long> traversal)
        {
            if (node != null)
            {
                PostOrderTraversal(node.leftChild, traversal);
                PostOrderTraversal(node.rightChild, traversal);
                traversal.Add(node.Value);
            }
        }


    }
}
