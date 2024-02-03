using BinaryTreeUygulama.src;
using BinaryTreeUygulama.src.ApplicationTree;

namespace BinaryTreeUygulama
{
    public partial class MainForm : Form
    {
        private BinarySearchTree tree;
        private FormEventHandler formEventHandler;

        public MainForm()
        {
            InitializeComponent();
            tree = new BinarySearchTree();
            formEventHandler = new FormEventHandler(
                drawBox, listBox, messageLabel, tree
            );
            FormEventHandler.ScrollCenter(panelForDrawBox);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ActiveControl = insertTextBox;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            formEventHandler.HandleInsert(insertTextBox);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            formEventHandler.HandleRemove(removeTextBox);
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            formEventHandler.HandleFind(findTextBox);
        }

        private void findKElementButton_Click(object sender, EventArgs e)
        {
            formEventHandler.HandleFindKElement(findKElementTextBox);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            tree = new BinarySearchTree();
            formEventHandler.tree = tree;
            drawBox.lastHighlightedNode = null;
            formEventHandler.TriggerTreePaint();
            FormEventHandler.ScrollCenter(panelForDrawBox);
        }

        private void drawBox_Paint(object sender, PaintEventArgs e)
        {
            drawBox.DrawTree(tree, e.Graphics);
        }

        private void insertTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                formEventHandler.HandleInsert(insertTextBox);
            }
        }

        private void removeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                formEventHandler.HandleRemove(removeTextBox);
            }
        }

        private void findTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                formEventHandler.HandleFind(findTextBox);
            }
        }

        private void findKElementTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                formEventHandler.HandleFindKElement(findKElementTextBox);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;

            if (listBox.SelectedIndex >= 0)
            {
                string selectedValue = listBox.SelectedItem.ToString();

                // PreOrder sonuçlarýný görüntüleme
                if (selectedValue == "PreOrder")
                {
                    List<long> traversal = tree.PreOrderTraversal();
                    string result = string.Join(", ", traversal);
                    //MessageBox.Show("PreOrder traversal: " + result);
                }

                // InOrder sonuçlarýný görüntüleme
                else if (selectedValue == "InOrder")
                {
                    List<long> traversal = tree.InOrderTraversal();
                    string result = string.Join(", ", traversal);
                    //MessageBox.Show("InOrder traversal: " + result);
                }

                // PostOrder sonuçlarýný görüntüleme
                else if (selectedValue == "PostOrder")
                {
                    List<long> traversal = tree.PostOrderTraversal();
                    string result = string.Join(", ", traversal);
                    //MessageBox.Show("PostOrder traversal: " + result);
                }
            }
        }

        private void PreOrder_Click(object sender, EventArgs e)
        {
            formEventHandler.HandlePreOrder(listBox);
        }

        private void InOrder_Click(object sender, EventArgs e)
        {
            formEventHandler.HandleInOrder(listBox);
        }

        private void PostOrder_Click(object sender, EventArgs e)
        {
            formEventHandler.HandlePostOrder(listBox);
        }
    }
}
