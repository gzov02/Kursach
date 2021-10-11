using System;
using System.Collections;
using System.Windows.Forms;
using static System.Collections.Generic.Stack<string>;

namespace cursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public FixedStack<string> stack = new FixedStack<string>(100); 

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            stack.Push(textAdd.Text);
            listBox1.Items.Insert(0, textAdd.Text);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxPoyasn.Text = $"{listBox1.Items[0]} ------> {listBox1.Items[1]}";
                stack.Pop();
                listBox1.Items.RemoveAt(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                textBoxPoyasn.Text = "Надо добавить элемент!";
            }

        }
    }
}
