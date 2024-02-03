using BinaryTreeUygulama.properties;

namespace BinaryTreeUygulama.src.ApplicationTree
{
    internal class NodeInfo
    {
        public static NodeInfo Create(TreeNode node, NodeInfo? parentInfo)
        {
            var result = new NodeInfo(node, parentInfo);
            if (node.rightChild != null)
            {
                result.RightChildNodeInfo = new NodeInfo(node.rightChild, result);
            }
            if (node.leftChild != null)
            {
                result.LeftChildNodeInfo = new NodeInfo(node.leftChild, result);
            }
            result.DetermineCoordinates();
            return result;
        }
        
        private int NodeOffset = VisualizerProperty.nodeOffset;

        public NodeInfo(TreeNode node, NodeInfo? parentNodeInfo) 
        {
            Node = node;
            ParentNodeInfo = parentNodeInfo;
            LeftChildNodeInfo = null;
            RightChildNodeInfo = null;
            DetermineWhatChild();
        }

        public TreeNode Node { get; private set; }
        public NodeInfo? ParentNodeInfo { get; private set; }
        public NodeInfo? LeftChildNodeInfo { get; set; }
        public NodeInfo? RightChildNodeInfo { get; set; }
        private bool IsRightChild {  get; set; }
        private bool IsLeftChild {  get; set; }
        private bool IsRoot {  get; set; }
        public int CenterX { get; private set; }
        public int CenterY { get; private set; }
        public int Radius { get { return VisualizerProperty.nodeRadius; } }

        public void DetermineCoordinates()
        {
            if (IsRoot)
            {
                CenterX = VisualizerProperty.rootCenter.X;
                CenterY = VisualizerProperty.rootCenter.Y;
            }
            else if (IsLeftChild)
            {
                var nodeCountOffset = RightChildNodeInfo?.Node?.Size ?? 0;
                CenterX = ParentNodeInfo!.CenterX - (NodeOffset * (nodeCountOffset + 1));
                CenterY = ParentNodeInfo.CenterY + NodeOffset;
            }
            else if (IsRightChild)
            {
                var nodeCountOffset = LeftChildNodeInfo?.Node?.Size ?? 0;
                CenterX = ParentNodeInfo!.CenterX + (NodeOffset * (nodeCountOffset + 1));
                CenterY = ParentNodeInfo.CenterY + NodeOffset;
            } 
        }

        private void DetermineWhatChild()
        {
            IsRightChild = false;
            IsLeftChild = false;
            IsRoot = false;
            if (ParentNodeInfo == null)
            {
                IsRoot = true;
                return;
            }
            var thisNode = Node; 
            var parentNode = ParentNodeInfo.Node;
            if (parentNode.rightChild == thisNode)
            {
                IsRightChild = true;              
            }
            else if (parentNode.leftChild == thisNode)
            {
                IsLeftChild = true;
            }
        } 

        public override string ToString()
        {
            return $"node {Node.ToString()}\n" +
                $"x: {CenterX}; y: {CenterY}\n" +
                $"root: {IsRoot}\n" +
                $"left: {IsLeftChild}";
        }
    }
}
