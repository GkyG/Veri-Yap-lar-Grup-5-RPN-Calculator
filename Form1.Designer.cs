namespace RPN_CALCULATOR_Grup_5
{
    partial class Form1
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
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            ListViewItem listViewItem3 = new ListViewItem("");
            panel1 = new Panel();
            btnQueueRun = new Button();
            btnQueueAdd = new Button();
            btnRedo = new Button();
            btnUndo = new Button();
            btnLoad = new Button();
            textBox1 = new TextBox();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            listView1 = new ListView();
            panel4 = new Panel();
            btnEquals = new Button();
            button21 = new Button();
            button20 = new Button();
            btnClear = new Button();
            btnAC = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btn0 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            panel5 = new Panel();
            label4 = new Label();
            treeView1 = new TreeView();
            panel6 = new Panel();
            listBoxQueue = new ListBox();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(btnQueueRun);
            panel1.Controls.Add(btnQueueAdd);
            panel1.Controls.Add(btnRedo);
            panel1.Controls.Add(btnUndo);
            panel1.Controls.Add(btnLoad);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 81);
            panel1.TabIndex = 0;
            // 
            // btnQueueRun
            // 
            btnQueueRun.Location = new Point(511, 41);
            btnQueueRun.Name = "btnQueueRun";
            btnQueueRun.Size = new Size(136, 23);
            btnQueueRun.TabIndex = 5;
            btnQueueRun.Text = "SIRADAKİNİ HESAPLA";
            btnQueueRun.UseVisualStyleBackColor = true;
            btnQueueRun.Click += btnQueueRun_Click;
            // 
            // btnQueueAdd
            // 
            btnQueueAdd.Location = new Point(358, 41);
            btnQueueAdd.Name = "btnQueueAdd";
            btnQueueAdd.Size = new Size(131, 23);
            btnQueueAdd.TabIndex = 4;
            btnQueueAdd.Text = "SIRAYA EKLE";
            btnQueueAdd.UseVisualStyleBackColor = true;
            btnQueueAdd.Click += btnQueueAdd_Click;
            // 
            // btnRedo
            // 
            btnRedo.Location = new Point(572, 12);
            btnRedo.Name = "btnRedo";
            btnRedo.Size = new Size(75, 23);
            btnRedo.TabIndex = 3;
            btnRedo.Text = "REDO";
            btnRedo.UseVisualStyleBackColor = true;
            btnRedo.Click += btnRedo_Click;
            // 
            // btnUndo
            // 
            btnUndo.Location = new Point(464, 12);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(75, 23);
            btnUndo.TabIndex = 2;
            btnUndo.Text = "UNDO";
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(358, 12);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "YÜKLE";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(311, 23);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(13, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(325, 291);
            panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(14, 39);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(299, 241);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(80, 12);
            label1.Name = "label1";
            label1.Size = new Size(159, 21);
            label1.TabIndex = 0;
            label1.Text = "STACK GÖRÜNÜMÜ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCyan;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(listView1);
            panel3.Location = new Point(346, 99);
            panel3.Name = "panel3";
            panel3.Size = new Size(325, 291);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(98, 12);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 2;
            label3.Text = "İŞLEM GEÇMİŞİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 18);
            label2.Name = "label2";
            label2.Size = new Size(10, 15);
            label2.TabIndex = 1;
            label2.Text = ",";
            // 
            // listView1
            // 
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listView1.Location = new Point(14, 39);
            listView1.Name = "listView1";
            listView1.Size = new Size(299, 241);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightCyan;
            panel4.Controls.Add(btnEquals);
            panel4.Controls.Add(button21);
            panel4.Controls.Add(button20);
            panel4.Controls.Add(btnClear);
            panel4.Controls.Add(btnAC);
            panel4.Controls.Add(btnDivide);
            panel4.Controls.Add(btnMultiply);
            panel4.Controls.Add(btnMinus);
            panel4.Controls.Add(btnPlus);
            panel4.Controls.Add(btn0);
            panel4.Controls.Add(btn3);
            panel4.Controls.Add(btn2);
            panel4.Controls.Add(btn1);
            panel4.Controls.Add(btn6);
            panel4.Controls.Add(btn5);
            panel4.Controls.Add(btn4);
            panel4.Controls.Add(btn9);
            panel4.Controls.Add(btn8);
            panel4.Controls.Add(btn7);
            panel4.Location = new Point(13, 396);
            panel4.Name = "panel4";
            panel4.Size = new Size(325, 201);
            panel4.TabIndex = 2;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEquals.Location = new Point(266, 106);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(45, 92);
            btnEquals.TabIndex = 18;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // button21
            // 
            button21.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button21.Location = new Point(147, 157);
            button21.Name = "button21";
            button21.Size = new Size(45, 41);
            button21.TabIndex = 17;
            button21.Text = ",";
            button21.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            button20.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button20.Location = new Point(80, 157);
            button20.Name = "button20";
            button20.Size = new Size(45, 41);
            button20.TabIndex = 16;
            button20.Text = ".";
            button20.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnClear.Location = new Point(266, 11);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(45, 41);
            btnClear.TabIndex = 15;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAC
            // 
            btnAC.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAC.Location = new Point(266, 58);
            btnAC.Name = "btnAC";
            btnAC.Size = new Size(45, 41);
            btnAC.TabIndex = 14;
            btnAC.Text = "AC";
            btnAC.UseVisualStyleBackColor = true;
            btnAC.Click += btnAC_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDivide.Location = new Point(215, 157);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(45, 41);
            btnDivide.TabIndex = 13;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMultiply.Location = new Point(215, 59);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(45, 41);
            btnMultiply.TabIndex = 12;
            btnMultiply.Text = "X";
            btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMinus.Location = new Point(215, 106);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(45, 41);
            btnMinus.TabIndex = 11;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPlus.Location = new Point(215, 12);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(45, 41);
            btnPlus.TabIndex = 10;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn0.Location = new Point(14, 157);
            btn0.Name = "btn0";
            btn0.Size = new Size(45, 41);
            btn0.TabIndex = 9;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn3.Location = new Point(147, 106);
            btn3.Name = "btn3";
            btn3.Size = new Size(45, 41);
            btn3.TabIndex = 8;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn2.Location = new Point(80, 106);
            btn2.Name = "btn2";
            btn2.Size = new Size(45, 41);
            btn2.TabIndex = 7;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn1.Location = new Point(14, 106);
            btn1.Name = "btn1";
            btn1.Size = new Size(45, 41);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn6.Location = new Point(147, 59);
            btn6.Name = "btn6";
            btn6.Size = new Size(45, 41);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn5.Location = new Point(80, 59);
            btn5.Name = "btn5";
            btn5.Size = new Size(45, 41);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn4.Location = new Point(14, 59);
            btn4.Name = "btn4";
            btn4.Size = new Size(45, 41);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn9.Location = new Point(147, 12);
            btn9.Name = "btn9";
            btn9.Size = new Size(45, 41);
            btn9.TabIndex = 2;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn8.Location = new Point(80, 12);
            btn8.Name = "btn8";
            btn8.Size = new Size(45, 41);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn7.Location = new Point(14, 12);
            btn7.Name = "btn7";
            btn7.Size = new Size(45, 41);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightCyan;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(treeView1);
            panel5.Location = new Point(346, 395);
            panel5.Name = "panel5";
            panel5.Size = new Size(325, 202);
            panel5.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(39, 12);
            label4.Name = "label4";
            label4.Size = new Size(251, 21);
            label4.TabIndex = 3;
            label4.Text = "EXPRESSION TREE GÖRÜNTÜSÜ";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(14, 39);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(299, 158);
            treeView1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightCyan;
            panel6.Controls.Add(listBoxQueue);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(13, 603);
            panel6.Name = "panel6";
            panel6.Size = new Size(658, 137);
            panel6.TabIndex = 4;
            // 
            // listBoxQueue
            // 
            listBoxQueue.FormattingEnabled = true;
            listBoxQueue.Location = new Point(13, 48);
            listBoxQueue.Name = "listBoxQueue";
            listBoxQueue.Size = new Size(633, 79);
            listBoxQueue.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(289, 24);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 2;
            label5.Text = "İŞLEME";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 745);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "RPN HESAP MAKİNESİ - Grup 5";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRedo;
        private Button btnUndo;
        private Button btnLoad;
        private TextBox textBox1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private ListView listView1;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private Button btnClear;
        private Button btnAC;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnMinus;
        private Button btnPlus;
        private Button btn0;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button button21;
        private Button button20;
        private Button btnEquals;
        private Panel panel5;
        private Label label4;
        private TreeView treeView1;
        private Panel panel6;
        private Label label5;
        private Button btnQueueRun;
        private Button btnQueueAdd;
        private ListBox listBoxQueue;
    }
}
