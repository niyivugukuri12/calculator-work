using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treeview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form2(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Form2 tree = new Form2();
            tree.TopLevel = false;
            panel2.Controls.Add(tree);
            tree.Show();
        }
    }
}
