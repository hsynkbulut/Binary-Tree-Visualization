using BinaryTreeUygulama.properties;
using BinaryTreeUygulama.src.Components;

namespace BinaryTreeUygulama
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            insertButton = new Button();
            insertTextBox = new TextBox();
            removeTextBox = new TextBox();
            removeButton = new Button();
            findTextBox = new TextBox();
            findButton = new Button();
            findKElementTextBox = new TextBox();
            findKElementButton = new Button();
            resetButton = new Button();
            messageLabel = new Label();
            drawBox = new DrawBox();
            panelForDrawBox = new Panel();
            preOrderButton = new Button();
            InOrder = new Button();
            PostOrder = new Button();
            listBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)drawBox).BeginInit();
            panelForDrawBox.SuspendLayout();
            SuspendLayout();
            // 
            // insertButton
            // 
            insertButton.BackColor = Color.Gold;
            insertButton.Cursor = Cursors.Hand;
            insertButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            insertButton.ForeColor = SystemColors.ControlText;
            insertButton.Location = new Point(114, 13);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(95, 29);
            insertButton.TabIndex = 0;
            insertButton.TabStop = false;
            insertButton.Text = "Ekle";
            insertButton.UseVisualStyleBackColor = false;
            insertButton.Click += insertButton_Click;
            // 
            // insertTextBox
            // 
            insertTextBox.Location = new Point(11, 12);
            insertTextBox.Name = "insertTextBox";
            insertTextBox.Size = new Size(95, 27);
            insertTextBox.TabIndex = 1;
            insertTextBox.KeyPress += insertTextBox_KeyPress;
            // 
            // removeTextBox
            // 
            removeTextBox.Location = new Point(229, 12);
            removeTextBox.Name = "removeTextBox";
            removeTextBox.Size = new Size(85, 27);
            removeTextBox.TabIndex = 3;
            removeTextBox.KeyPress += removeTextBox_KeyPress;
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.Gold;
            removeButton.Cursor = Cursors.Hand;
            removeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            removeButton.Location = new Point(319, 11);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(95, 32);
            removeButton.TabIndex = 2;
            removeButton.TabStop = false;
            removeButton.Text = "Sil";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += removeButton_Click;
            // 
            // findTextBox
            // 
            findTextBox.Location = new Point(443, 12);
            findTextBox.Name = "findTextBox";
            findTextBox.Size = new Size(85, 27);
            findTextBox.TabIndex = 5;
            findTextBox.KeyPress += findTextBox_KeyPress;
            // 
            // findButton
            // 
            findButton.BackColor = Color.Gold;
            findButton.Cursor = Cursors.Hand;
            findButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            findButton.Location = new Point(535, 11);
            findButton.Name = "findButton";
            findButton.Size = new Size(95, 32);
            findButton.TabIndex = 4;
            findButton.TabStop = false;
            findButton.Text = "Arama";
            findButton.UseVisualStyleBackColor = false;
            findButton.Click += findButton_Click;
            // 
            // findKElementTextBox
            // 
            findKElementTextBox.Location = new Point(658, 11);
            findKElementTextBox.Name = "findKElementTextBox";
            findKElementTextBox.Size = new Size(85, 27);
            findKElementTextBox.TabIndex = 7;
            findKElementTextBox.KeyPress += findKElementTextBox_KeyPress;
            // 
            // findKElementButton
            // 
            findKElementButton.BackColor = Color.PaleGreen;
            findKElementButton.Cursor = Cursors.Hand;
            findKElementButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            findKElementButton.Location = new Point(751, 11);
            findKElementButton.Name = "findKElementButton";
            findKElementButton.Size = new Size(170, 32);
            findKElementButton.TabIndex = 6;
            findKElementButton.TabStop = false;
            findKElementButton.Text = "En Küçük X.Değer";
            findKElementButton.UseVisualStyleBackColor = false;
            findKElementButton.Click += findKElementButton_Click;
            // 
            // resetButton
            // 
            resetButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            resetButton.BackColor = Color.Gold;
            resetButton.Cursor = Cursors.Hand;
            resetButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            resetButton.Location = new Point(928, 11);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(94, 29);
            resetButton.TabIndex = 8;
            resetButton.Text = "Sıfırla";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // messageLabel
            // 
            messageLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            messageLabel.AutoSize = true;
            messageLabel.BackColor = Color.Lime;
            messageLabel.Cursor = Cursors.IBeam;
            messageLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            messageLabel.ForeColor = SystemColors.ControlLightLight;
            messageLabel.Location = new Point(11, 567);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(50, 20);
            messageLabel.TabIndex = 10;
            messageLabel.Text = "Mesaj";
            // 
            // drawBox
            // 
            drawBox.BackColor = Color.PapayaWhip;
            drawBox.Location = new Point(3, 3);
            drawBox.Name = "drawBox";
            drawBox.Size = new Size(6000, 4000);
            drawBox.SizeMode = PictureBoxSizeMode.AutoSize;
            drawBox.TabIndex = 9;
            drawBox.TabStop = false;
            drawBox.Paint += drawBox_Paint;
            // 
            // panelForDrawBox
            // 
            panelForDrawBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelForDrawBox.AutoScroll = true;
            panelForDrawBox.BackColor = SystemColors.Menu;
            panelForDrawBox.BorderStyle = BorderStyle.Fixed3D;
            panelForDrawBox.Controls.Add(drawBox);
            panelForDrawBox.Location = new Point(11, 159);
            panelForDrawBox.Name = "panelForDrawBox";
            panelForDrawBox.Size = new Size(734, 395);
            panelForDrawBox.TabIndex = 11;
            // 
            // preOrderButton
            // 
            preOrderButton.BackColor = Color.LightSkyBlue;
            preOrderButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            preOrderButton.Location = new Point(11, 48);
            preOrderButton.Name = "preOrderButton";
            preOrderButton.Size = new Size(96, 28);
            preOrderButton.TabIndex = 12;
            preOrderButton.Text = "PreOrder";
            preOrderButton.UseVisualStyleBackColor = false;
            preOrderButton.Click += PreOrder_Click;
            // 
            // InOrder
            // 
            InOrder.BackColor = Color.LightSkyBlue;
            InOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            InOrder.Location = new Point(11, 81);
            InOrder.Name = "InOrder";
            InOrder.Size = new Size(96, 28);
            InOrder.TabIndex = 13;
            InOrder.Text = "InOrder";
            InOrder.UseVisualStyleBackColor = false;
            InOrder.Click += InOrder_Click;
            // 
            // PostOrder
            // 
            PostOrder.BackColor = Color.LightSkyBlue;
            PostOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PostOrder.Location = new Point(11, 115);
            PostOrder.Name = "PostOrder";
            PostOrder.Size = new Size(96, 28);
            PostOrder.TabIndex = 14;
            PostOrder.Text = "PostOrder";
            PostOrder.UseVisualStyleBackColor = false;
            PostOrder.Click += PostOrder_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.HorizontalScrollbar = true;
            listBox.ItemHeight = 20;
            listBox.Location = new Point(114, 48);
            listBox.MultiColumn = true;
            listBox.Name = "listBox";
            listBox.ScrollAlwaysVisible = true;
            listBox.Size = new Size(515, 104);
            listBox.TabIndex = 15;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1030, 604);
            Controls.Add(listBox);
            Controls.Add(PostOrder);
            Controls.Add(InOrder);
            Controls.Add(preOrderButton);
            Controls.Add(panelForDrawBox);
            Controls.Add(messageLabel);
            Controls.Add(resetButton);
            Controls.Add(findKElementTextBox);
            Controls.Add(findKElementButton);
            Controls.Add(findTextBox);
            Controls.Add(findButton);
            Controls.Add(removeTextBox);
            Controls.Add(removeButton);
            Controls.Add(insertTextBox);
            Controls.Add(insertButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1045, 640);
            Name = "MainForm";
            Text = "İkili Arama Ağacı Grafik Uygulaması";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)drawBox).EndInit();
            panelForDrawBox.ResumeLayout(false);
            panelForDrawBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DrawBox drawBox;
        private Button insertButton;
        private TextBox insertTextBox;
        private TextBox removeTextBox;
        private Button removeButton;
        private TextBox findTextBox;
        private Button findButton;
        private TextBox findKElementTextBox;
        private Button findKElementButton;
        private Button resetButton;
        private Label messageLabel;
        private Panel panelForDrawBox;
        private Button preOrderButton;
        private Button InOrder;
        private Button PostOrder;
        private ListBox listBox;
    }
}