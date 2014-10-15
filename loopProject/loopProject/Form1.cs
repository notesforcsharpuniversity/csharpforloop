using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loopProject
{
    public partial class Form1 : Form
    {
        string[] yazi = { "a", "b", "c", "d", "e" };
        int[] sayi = { 1, 2, 3, 4, 5 };

        public Form1()
        {
            InitializeComponent();
        }

        public void doldur(string[] a1, int[] a2) 
        {
            for (int i = 0; i < a1.Length; i++)
            {
                for (int y = 0; y < a2.Length; y++)
                {
                    listBox1.Items.Add(a1[i] + " / " + a2[y]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doldur(yazi, sayi);
        }
    }
}
