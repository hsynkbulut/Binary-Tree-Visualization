using BinaryTreeUygulama.properties;
using BinaryTreeUygulama.src.ApplicationTree;
using System.Drawing.Drawing2D;

namespace BinaryTreeUygulama.src.Components
{
    internal class DrawBox : PictureBox
    {
        private static readonly Color traversalColor = VisualizerProperty.traverseColor;

        private Graphics? pathGraphics = null;
        public NodeInfo? lastHighlightedNode;

        public void DrawTree(BinarySearchTree tree, Graphics graphics)
        {
            lastHighlightedNode = null;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            var nodeInfos = tree.GetNodesInfo();
            foreach (var node in nodeInfos)
            {
                GraphicUtils.DrawConnectionToParent(node, graphics);
                GraphicUtils.DrawNode(node, graphics);
            }
        }

        public void HideLastHighlight()
        {
            if (lastHighlightedNode != null)
            {
                using (pathGraphics = CreateGraphics())
                {
                    GraphicUtils.HighlightNode(lastHighlightedNode, pathGraphics!, Color.Black);
                }
                lastHighlightedNode = null;
            }
        }

        public void DrawPath(BinarySearchTree tree, long value, Color findColor, Color missingColor)
        {
            HideLastHighlight();
            if (tree == null || tree.root == null)
            {
                return;
            }
            using (pathGraphics = CreateGraphics())
            {
                pathGraphics.SmoothingMode = SmoothingMode.AntiAlias;
                DrawPath(tree.root, value, null, findColor, missingColor);
            }
        }

        public void DrawFindKthElementPath(BinarySearchTree tree, long index)
        {
            HideLastHighlight();
            if (tree == null || tree.root == null)
            {
                return;
            }
            if (index > tree.root.Size)
            {
                var size = tree.root.Size;
                throw new Exception($"Ağaçta sadece {size} düğüm var. " +
                    $"En küçük {index}.elemanı bulmanız mümkün değildir!");
            }
            if (index < 1)
            {
                throw new Exception($"En küçük {index}.elemanı bulmanız mümkün değildir!");
            }
            using (pathGraphics = CreateGraphics())
            {
                pathGraphics.SmoothingMode = SmoothingMode.AntiAlias;
                DrawFindKthElementPath(tree.root, index, null, VisualizerProperty.findFindColor);
            }
        }

        private void DrawFindKthElementPath(ApplicationTree.TreeNode? node, long index, NodeInfo? parentNodeInfo, Color findColor)
        {
            Thread.Sleep(VisualizerProperty.timeGap);
            GraphicUtils.HighlightNode(parentNodeInfo, pathGraphics!, Color.Black);

            var nodeInfo = NodeInfo.Create(node!, parentNodeInfo);
            lastHighlightedNode = nodeInfo;

            var nodeCountInLeftChild = nodeInfo.LeftChildNodeInfo?.Node.Size ?? 0;

            if (index == nodeCountInLeftChild + 1)
            {
                GraphicUtils.HighlightNode(nodeInfo, pathGraphics!, findColor);
                Thread.Sleep(VisualizerProperty.timeGap);
                return;
            }

            GraphicUtils.HighlightNode(nodeInfo, pathGraphics!, traversalColor);
            if (index <= nodeCountInLeftChild)
            {
                DrawFindKthElementPath(node!.leftChild, index, nodeInfo, findColor);
            }
            else
            {
                var newIndex = index - (nodeCountInLeftChild + 1);
                DrawFindKthElementPath(node!.rightChild, newIndex, nodeInfo, findColor);
            }
        }

        private void DrawPath(ApplicationTree.TreeNode? node, long value, NodeInfo? parentNodeInfo, Color findColor, Color missingColor)
        {
            Thread.Sleep(VisualizerProperty.timeGap);
            if (node == null)
            {
                lastHighlightedNode = parentNodeInfo;
                GraphicUtils.HighlightNode(parentNodeInfo, pathGraphics!, missingColor);
                return;
            }

            GraphicUtils.HighlightNode(parentNodeInfo, pathGraphics!, Color.Black);
            var nodeInfo = NodeInfo.Create(node, parentNodeInfo);
            lastHighlightedNode = nodeInfo;

            if (value == node.Value)
            {
                GraphicUtils.HighlightNode(nodeInfo, pathGraphics!, findColor);
                return;
            }

            GraphicUtils.HighlightNode(nodeInfo, pathGraphics!, traversalColor);
            if (value > node.Value)
            {
                DrawPath(node.rightChild, value, nodeInfo, findColor, missingColor);
            }
            else
            {
                DrawPath(node.leftChild, value, nodeInfo, findColor, missingColor);
            }
        }

        //BEN EKLEDİM
        public void ClearVisitedNodes()
        {
            HideLastHighlight();
        }


    }
}
