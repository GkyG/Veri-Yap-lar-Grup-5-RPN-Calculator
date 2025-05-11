using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPN_CALCULATOR_Grup_5
{
    public class RPNCalculator
    {
        public class ExpressionTreeNode
        {
            public string Value { get; set; }
            public ExpressionTreeNode Left { get; set; }
            public ExpressionTreeNode Right { get; set; }

            public ExpressionTreeNode(string value)
            {
                Value = value;
            }
        }

        public ExpressionTreeNode BuildExpressionTree(string input)
        {
            var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Stack<ExpressionTreeNode> stack = new Stack<ExpressionTreeNode>();

            foreach (var token in tokens)
            {
                if (double.TryParse(token, out _))
                {
                    stack.Push(new ExpressionTreeNode(token));
                }
                else if (IsOperator(token))
                {
                    var right = stack.Pop();
                    var left = stack.Pop();
                    var node = new ExpressionTreeNode(token)
                    {
                        Left = left,
                        Right = right
                    };
                    stack.Push(node);
                }
            }

            return stack.Count > 0 ? stack.Pop() : null;
        }

        private bool IsOperator(string token)
        {
            return token == "+" || token == "-" || token == "*" || token == "/";
        }

        private class StackNode
        {
            public double Value { get; set; }
            public StackNode Next { get; set; }
        }

        // 2. Bağlı liste ile stack yapısı
        private StackNode _stackTop;
        private int _stackCount;

        // 3. Geçmiş işlemler için LinkedList
        private readonly LinkedList<HistoryItem> _history = new LinkedList<HistoryItem>();
        private readonly Stack<LinkedListNode<HistoryItem>> _undoStack = new Stack<LinkedListNode<HistoryItem>>();

        public void ProcessInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return;

            var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var token in tokens)
            {
                if (double.TryParse(token, out double number))
                {
                    Push(number); // Bağlı liste ile push
                    AddToHistory($"Push {number}", number);
                }
                else
                {
                    ProcessOperator(token);
                }
            }
        }

        private void Push(double value)
        {
            _stackTop = new StackNode
            {
                Value = value,
                Next = _stackTop
            };
            _stackCount++;
        }

        private double Pop()
        {
            if (_stackTop == null)
                throw new InvalidOperationException("Stack boş");

            var value = _stackTop.Value;
            _stackTop = _stackTop.Next;
            _stackCount--;
            return value;
        }

        private void ProcessOperator(string op)
        {
            if (_stackCount < 2)
                throw new InvalidOperationException("Yetersiz operand");

            double b = Pop();
            double a = Pop();
            double result = op switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                "/" => a / b,
                _ => throw new ArgumentException("Geçersiz operatör")
            };

            Push(result);
            AddToHistory($"{a} {op} {b}", result);
        }

        private void AddToHistory(string operation, double result)
        {
            _history.AddLast(new HistoryItem
            {
                Operation = operation,
                Result = result,
                Time = DateTime.Now
            });
        }

        public void Undo()
        {
            if (_history.Last == null) return;

            _undoStack.Push(_history.Last);
            _history.RemoveLast();
            RebuildStack();
        }

        public void Redo()
        {
            if (_undoStack.Count == 0) return;

            var node = _undoStack.Pop();
            _history.AddLast(node);
            RebuildStack();
        }

        private void RebuildStack()
        {
            // Stack'i temizle
            _stackTop = null;
            _stackCount = 0;

            // Sadece Push işlemlerini yeniden uygula
            foreach (var item in _history.Where(h => h.Operation.StartsWith("Push")))
            {
                Push(item.Result);
            }
        }

        public void ClearAll()
        {
            _stackTop = null;
            _stackCount = 0;
            _history.Clear();
            _undoStack.Clear();
        }

        public bool CanUndo() => _history.Count > 0;
        public bool CanRedo() => _undoStack.Count > 0;

        public IEnumerable<double> GetStack()
        {
            var values = new List<double>();
            var current = _stackTop;
            while (current != null)
            {
                values.Add(current.Value);
                current = current.Next;
            }
            values.Reverse(); // LIFO sıralaması için
            return values;
        }

        public IEnumerable<HistoryItem> GetHistory() => _history;
    }

    public class HistoryItem
    {
        public string Operation { get; set; }
        public double Result { get; set; }
        public DateTime Time { get; set; }
    }
}
