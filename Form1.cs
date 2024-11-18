namespace Pilas
{
    public partial class Form1 : Form
    {
        private int[] stack;
        private int top;
        private int size;
        public Form1()
        {
            InitializeComponent();
            size = 5; // Tamaño de la pila
            stack = new int[size];
            top = -1;
        }

        private void UpdateListBox()
        {
            lstStack.Items.Clear();
            for (int i = top; i >= 0; i--)
            {
                lstStack.Items.Add(stack[i]);
            }
        }
        private void btnPush_Click(object sender, EventArgs e)
        {
            if (top == size - 1)
            {
                MessageBox.Show("Stack Overflow. Cannot push more elements.");
            }
            else
            {
                if (int.TryParse(txtValue.Text, out int value))
                {
                    stack[++top] = value;
                    UpdateListBox();
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.");
                }
            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (top == -1)
            {
                MessageBox.Show("Stack Underflow. No elements to pop.");
            }
            else
            {
                MessageBox.Show($"Popped: {stack[top]}");
                top--;
                UpdateListBox();
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (top == -1)
            {
                MessageBox.Show("Stack is empty.");
            }
            else
            {
                MessageBox.Show($"Top element: {stack[top]}");
            }
        }
    }
    
}

