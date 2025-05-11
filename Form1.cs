using static RPN_CALCULATOR_Grup_5.RPNCalculator;
using System.Collections.Generic;

namespace RPN_CALCULATOR_Grup_5
{
    public partial class Form1 : Form
    {
        private readonly RPNCalculator _calculator;
        private Queue<string> operationQueue = new Queue<string>();

        public Form1()
        {
            InitializeComponent();
            _calculator = new RPNCalculator();
            SetupUI();
            SetupEventHandlers();

        }

        private void SetupUI()
        {
            // Özel buton renkleri
            btnEquals.BackColor = Color.LightGreen;
            btnClear.BackColor = Color.LightCoral;
            btnAC.BackColor = Color.Orange;
        }
        private void SetupEventHandlers()
        {
            btnPlus.Tag = "+";
            btnMinus.Tag = "-";
            btnMultiply.Tag = "*";
            btnDivide.Tag = "/";

            // Sayý butonlarý
            btn0.Click += NumberButton_Click;
            btn1.Click += NumberButton_Click;
            btn2.Click += NumberButton_Click;
            btn3.Click += NumberButton_Click;
            btn4.Click += NumberButton_Click;
            btn5.Click += NumberButton_Click;
            btn6.Click += NumberButton_Click;
            btn7.Click += NumberButton_Click;
            btn8.Click += NumberButton_Click;
            btn9.Click += NumberButton_Click;

            // Operatör butonlarý
            btnPlus.Click += OperatorButton_Click;
            btnMinus.Click += OperatorButton_Click;
            btnMultiply.Click += OperatorButton_Click;
            btnDivide.Click += OperatorButton_Click;

            // Özel butonlar
            btnEquals.Click += btnEquals_Click;
            btnClear.Click += btnClear_Click;
            btnAC.Click += btnAC_Click;
            btnUndo.Click += btnUndo_Click;
            btnRedo.Click += btnRedo_Click;
            btnQueueAdd.Click += btnQueueAdd_Click;
            btnQueueRun.Click += btnQueueRun_Click;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            string operatorSymbol = btn.Text; // butonun üstündeki yazýyý al (örneðin "+")

            _calculator.ProcessInput(textBox1.Text);
            _calculator.ProcessInput(operatorSymbol);
            UpdateUI();
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn?.Tag == null)
            {
                MessageBox.Show("Operatör tanýmlý deðil", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _calculator.ProcessInput(textBox1.Text);
            _calculator.ProcessInput(btn.Tag.ToString());
            UpdateUI();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.DrawMode = TreeViewDrawMode.OwnerDrawText;
            treeView1.DrawNode += TreeView1_DrawNode;
            treeView1.DrawMode = TreeViewDrawMode.OwnerDrawText;
            treeView1.DrawNode += TreeView1_DrawNode;
            treeView1.HideSelection = false; // Seçimi göster
            treeView1.BackColor = Color.White;
            treeView1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void TreeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            Graphics g = e.Graphics;

            bool isSelected = (e.State & TreeNodeStates.Selected) != 0;

            Color backColor = isSelected ? Color.LightSteelBlue : Color.White;
            using (Brush backgroundBrush = new SolidBrush(backColor))
            {
                g.FillRectangle(backgroundBrush, e.Bounds);
            }

            Font nodeFont = new Font("Segoe UI", 10, FontStyle.Bold);
            Brush textBrush = isSelected ? Brushes.White : Brushes.DarkSlateBlue;

            Rectangle paddedBounds = new Rectangle(e.Bounds.X, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height - 4);

            g.DrawString(e.Node.Text, nodeFont, textBrush, paddedBounds.Location);

            if (isSelected)
            {
                using (Pen borderPen = new Pen(Color.SteelBlue, 1))
                {
                    g.DrawRectangle(borderPen, paddedBounds);
                }
            }

            e.DrawDefault = false;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            _calculator.ProcessInput(textBox1.Text);
            UpdateUI();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            _calculator.ClearAll();
            textBox1.Clear();
            UpdateUI();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            _calculator.Undo();
            UpdateUI();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            _calculator.Redo();
            UpdateUI();
        }

        private void UpdateUI()
        {
            // Stack'i güncelle (flowLayoutPanel1)
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in _calculator.GetStack())
            {
                var panel = new Panel
                {
                    BackColor = Color.FromArgb(200, 230, 255),
                    Size = new Size(flowLayoutPanel1.Width - 25, 40),
                    Margin = new Padding(5),
                    BorderStyle = BorderStyle.FixedSingle
                };

                var label = new Label
                {
                    Text = item.ToString(),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 12, FontStyle.Bold)
                };

                panel.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(panel);
            }

            // Geçmiþi güncelle (listView1)
            listView1.Items.Clear();
            foreach (var item in _calculator.GetHistory())
            {
                var listItem = new ListViewItem(item.Operation);
                listItem.SubItems.Add(item.Result.ToString());
                listItem.SubItems.Add(item.Time.ToString("HH:mm:ss"));
                listView1.Items.Add(listItem);
            }

            // Buton durumlarýný güncelle
            btnUndo.Enabled = _calculator.CanUndo();
            btnRedo.Enabled = _calculator.CanRedo();
        }

        private void DisplayExpressionTree(ExpressionTreeNode root)
        {
            treeView1.Nodes.Clear();
            if (root == null) return;

            var rootNode = BuildTreeNode(root);
            treeView1.Nodes.Add(rootNode);
            treeView1.ExpandAll();
        }

        private TreeNode BuildTreeNode(ExpressionTreeNode node)
        {
            if (node == null) return null;

            var treeNode = new TreeNode(node.Value);
            if (node.Left != null)
                treeNode.Nodes.Add(BuildTreeNode(node.Left));
            if (node.Right != null)
                treeNode.Nodes.Add(BuildTreeNode(node.Right));

            return treeNode;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

        }
        private ExpressionTreeNode root;
        private void btnLoad_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            _calculator.ProcessInput(input);

            // Tree'yi oluþtur ve göster
            ExpressionTreeNode root = _calculator.BuildExpressionTree(input);
            if (root != null)
            {
                DisplayExpressionTree(root);
            }

            UpdateUI();
        }

        private void btnQueueAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                operationQueue.Enqueue(textBox1.Text);
                listBoxQueue.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void btnQueueRun_Click(object sender, EventArgs e)
        {
            if (operationQueue.Count > 0)
            {
                string nextOperation = operationQueue.Dequeue();
                _calculator.ProcessInput(nextOperation);
                listBoxQueue.Items.RemoveAt(0);
                UpdateUI();
            }
            else
            {
                MessageBox.Show("Kuyrukta iþlem yok!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

