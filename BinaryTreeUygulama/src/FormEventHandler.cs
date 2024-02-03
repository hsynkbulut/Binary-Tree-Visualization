using BinaryTreeUygulama.properties;
using BinaryTreeUygulama.src.ApplicationTree;
using BinaryTreeUygulama.src.Components;

namespace BinaryTreeUygulama.src
{
    internal class FormEventHandler
    {
        private DrawBox drawBox;
        private Label messageLabel;
        public BinarySearchTree tree;
        private ListBox listBox;

        public FormEventHandler(
            DrawBox drawBox,
            ListBox listBox,
            Label messageLabel,
            BinarySearchTree tree
            )
        {
            this.drawBox = drawBox;
            this.listBox = listBox;
            this.messageLabel = messageLabel;
            this.tree = tree;
        }

        public static void ScrollCenter(Panel p)
        {
            using (Control c = new Control() { Parent = p, Height = 0, Left = VisualizerProperty.rootCenter.X + p.Parent.Width / 2 - p.HorizontalScroll.Value })
            {
                p.ScrollControlIntoView(c);
            }
        }

        public void HandleInsert(TextBox insertTextBox)
        {
            ResetAndHideMessageLabel();
            try
            {
                ValidateInput(insertTextBox);
                var value = long.Parse(insertTextBox.Text);
                drawBox.DrawPath(tree, value, VisualizerProperty.findInsertColor, VisualizerProperty.missingInsertColor);
                tree.Insert(value);
                Thread.Sleep(VisualizerProperty.timeGap);
                TriggerTreePaint();
            }
            catch (Exception e)
            {
                HandleException(e, insertTextBox);
            }
            RefreshTextBox(insertTextBox);
        }

        public void HandleRemove(TextBox removeTextBox)
        {
            ResetAndHideMessageLabel();
            try
            {
                ValidateInput(removeTextBox);
                var value = long.Parse(removeTextBox.Text);
                drawBox.DrawPath(tree, value, VisualizerProperty.findRemoveColor, VisualizerProperty.missingRemoveColor);
                tree.Remove(value);
                Thread.Sleep(VisualizerProperty.timeGap);
                TriggerTreePaint();
            }
            catch (Exception e)
            {
                HandleException(e, removeTextBox);
            }
            RefreshTextBox(removeTextBox);
        }

        public void HandleFind(TextBox findTextBox)
        {
            ResetAndHideMessageLabel();
            try
            {
                ValidateInput(findTextBox);
                var value = long.Parse(findTextBox.Text);
                drawBox.DrawPath(tree, value, VisualizerProperty.findFindColor, VisualizerProperty.missingFindColor);
            }
            catch (Exception e) 
            { 
                HandleException(e, findTextBox); 
            }
            RefreshTextBox(findTextBox);
        }

        public void HandleFindKElement(TextBox findKElementTextBox)
        {
            ResetAndHideMessageLabel();
            try
            {
                ValidateInput(findKElementTextBox);
                var value = long.Parse(findKElementTextBox.Text);
                drawBox.DrawFindKthElementPath(tree, value);
            }
            catch (Exception e)
            {
                HandleException(e, findKElementTextBox);
            }
            RefreshTextBox(findKElementTextBox);
        }

        public void TriggerTreePaint() => drawBox.Invalidate(true);

        private void ResetAndHideMessageLabel()
        {
            messageLabel.Text = "";
            messageLabel.BackColor = Color.White;
            messageLabel.Hide();
        }
        private void HandleException(Exception exception, TextBox textBox)
        {
            var message = exception.Message;
            messageLabel.Text = message;
            messageLabel.BackColor = Color.IndianRed;
            textBox.BackColor = Color.IndianRed;
            messageLabel.Show();
        }

        private static void RefreshTextBox(TextBox textBox)
        {
            textBox.Text = "";
            textBox.BackColor = Color.White;
            textBox.Focus();
        }
        private static void ValidateInput(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text.Trim()))
            {
                throw new Exception($"{textBox.Name.Split('T')[0]} girişi boş bırakılamaz!");
            }
            if (!long.TryParse(textBox.Text.Trim(), out long result))
            {
                throw new Exception($"{textBox.Name.Split('T')[0]} girişi rakam olmayan karakterler içeremez!");
            }
        }

        public void HandlePreOrder(ListBox listBox)
        {
            ResetAndHideMessageLabel();
            try
            {
                var traversal = tree.PreOrderTraversal();
                listBox.Items.Clear();
                listBox.Items.AddRange(traversal.Select(v => v.ToString()).ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception("HATA: ", ex);
            }
        }


        public void HandleInOrder(ListBox listBox)
        {
            ResetAndHideMessageLabel();
            try
            {
                var traversal = tree.InOrderTraversal();
                listBox.Items.Clear();
                listBox.Items.AddRange(traversal.Select(v => v.ToString()).ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception("HATA: ", ex);
            }
        }

        public void HandlePostOrder(ListBox listBox)
        {
            ResetAndHideMessageLabel();
            try
            {
                var traversal = tree.PostOrderTraversal();
                listBox.Items.Clear();
                listBox.Items.AddRange(traversal.Select(v => v.ToString()).ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception("HATA: ", ex);
            }
        }

        private void TraverseAndDrawPath(List<long> traversal, Color color)
        {
            foreach (var value in traversal)
            {
                drawBox.DrawPath(tree, value, color, VisualizerProperty.missingFindColor);
                Thread.Sleep(VisualizerProperty.timeGap);
            }
            TriggerTreePaint();
        }


    }
}
