using BinaryTreeUygulama.src.ApplicationTree;

namespace BinaryTreeUygulama.src
{
    internal static class GraphicUtils
    {
        public static Pen TreeNodePen()
        {
            return new Pen(Color.Salmon, 4); // Düğümün (Dairenin dış rengi) kenarlık rengi
        }

        public static Pen ConnectionPen()
        {   
            return new Pen(Color.Orange, 3); // Düğümleri birbirine bağlayan köprü rengi
        }

        public static Font TreeNodeContentFont()
        {
            return SystemFonts.DefaultFont;
        }

        public static void HighlightNode(NodeInfo? nodeInfo, Graphics graphics, Color color)
        {
            if (nodeInfo == null)
            {
                return;
            }
            int xTopLeft = nodeInfo.CenterX - nodeInfo.Radius;
            int yTopLeft = nodeInfo.CenterY - nodeInfo.Radius;
            int diameter = nodeInfo.Radius * 2;
            graphics.DrawEllipse(new Pen(color, 4), xTopLeft, yTopLeft, diameter, diameter);
        }

        public static void DrawNode(NodeInfo nodeInfo, Graphics graphics)
        {
            DrawNodeCircle(nodeInfo, graphics);
            DrawNumber(nodeInfo, graphics);
            DrawSize(nodeInfo, graphics);
        }

        public static void DrawNodeCircle(NodeInfo? nodeInfo, Graphics graphics)
        {
            if (nodeInfo == null)
            {
                return;
            }
            int xTopLeft = nodeInfo.CenterX - nodeInfo.Radius;
            int yTopLeft = nodeInfo.CenterY - nodeInfo.Radius;
            int diameter = nodeInfo.Radius * 2;
            graphics.FillEllipse(Brushes.LightCyan, xTopLeft, yTopLeft, diameter, diameter); // Düğümün (Dairenin iç rengi) rengi
            graphics.DrawEllipse(TreeNodePen(), xTopLeft, yTopLeft, diameter, diameter);
        }

        public static void DrawNumber(NodeInfo nodeInfo, Graphics graphics)
        {
            var value = nodeInfo.Node.Value.ToString();
            var size = graphics.MeasureString(value, TreeNodeContentFont());
            var point = new PointF(
                nodeInfo.CenterX - size.Width / 2,
                nodeInfo.CenterY - size.Height / 2);
            graphics.DrawString(value, TreeNodeContentFont(), Brushes.Black, point); //Düğümün içindeki değerin rengi
        }

        public static void DrawSize(NodeInfo nodeInfo, Graphics graphics)
        {
            var value = nodeInfo.Node.Size.ToString();
            var size = graphics.MeasureString(value, TreeNodeContentFont());
            var point = new PointF(
                nodeInfo.CenterX - size.Width / 2,
                nodeInfo.CenterY - nodeInfo.Radius - size.Height);
            graphics.DrawString(value, TreeNodeContentFont(), Brushes.Blue, point); //Düğümün üstündeki index no rengi
        }

        public static void DrawConnectionToParent(NodeInfo nodeInfo, Graphics graphics)
            {
            if (nodeInfo.ParentNodeInfo != null)
            {
                graphics.DrawLine(ConnectionPen(),
                nodeInfo.CenterX, nodeInfo.CenterY,
                nodeInfo.ParentNodeInfo.CenterX, nodeInfo.ParentNodeInfo.CenterY
                );
            }
        }
    }
}
