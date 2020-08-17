using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public String first, second, third, fourth, fifth, sixth, seventh, eighth, ninth, tenth, eleventh;
        public object QB, BUQB, RB, WR, TE, K, D;
        private static int a, b, c, d;
        private void AppendTextBoxLine(string myStr)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.AppendText(Environment.NewLine);
            }
            richTextBox1.AppendText(myStr);
        }
        public void button7_Click(object sender, EventArgs e)
        {
            int QBIndex = QBList.SelectedIndex;
            QB = QBList.SelectedItem;
            int count;
            a++;
            count = a;
            if (count == 1)
            {
                first = QB.ToString();
                MessageBox.Show("Great Choice, now please choose a backup QB.");
                QBList.ClearSelected();
            }
            if (count == 2)
            {
                BUQB = QBList.SelectedItem;
                second = BUQB.ToString();
                MessageBox.Show("Great start!" + "Now, move on to a new position.");
                QBList.ClearSelected();
            }
        }
        public void button2_Click(object sender, EventArgs e)
        {
            foreach (RadioButton rb in this.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    third = rb.Text;
                    MessageBox.Show(third + " should be a solid defense, nice choice!");
                    break;
                }
            }
        }
        public void button4_Click(object sender, EventArgs e)
        {
            int TEIndex = TEList.SelectedIndex;
            TE = TEList.SelectedItem;
            int count1;
            b++;
            count1 = b;
            if (count1 == 1)
            {
                fourth = TE.ToString();
                MessageBox.Show("Wise choice, now please choose a backup TE.");
            }
            if (count1 == 2)
            {
                fifth = TEList.ToString();
                MessageBox.Show("Great, on to the next position now.");
            }
        }
        public void button5_Click(object sender, EventArgs e)
        {
            int RBIndex = RBList.SelectedIndex;
            RB = RBList.SelectedItem;
            int count2;
            c++;
            count2 = c;
            if (count2 == 1)
            {
                sixth = RB.ToString();
                MessageBox.Show("Wise choice, now please choose a backup RB.");
            }
            if (count2 == 2)
            {
                seventh = RBList.ToString();
                MessageBox.Show("Great, on to the next position now.");
            }
        }
        public void button6_Click(object sender, EventArgs e)
        {
            int KIndex = KickersList.SelectedIndex;
            K = KickersList.SelectedItem;
            eighth = K.ToString();
            MessageBox.Show(eighth + " should be a solid pick. Please move on to the next position.");
        }

        public void button3_Click(object sender, EventArgs e)
        {
            int WRIndex = WRList.SelectedIndex;
            WR = WRList.SelectedItem;
            int count3;
            d++;
            count3 = d;
            if (count3 == 1)
            {
                ninth = WR.ToString();
                MessageBox.Show("Wise choice, now please choose another WR.");
                WRList.ClearSelected();
            }
            if (count3 == 2)
            {
                tenth = RBList.ToString();
                MessageBox.Show("Great!! Now, choose a backup WR.");
            }
            if (count3 == 3)
            {
                eleventh = WR.ToString();
                MessageBox.Show("Nice job, now click the RED build team button to build your team.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AppendTextBoxLine("QB: " + first);
            AppendTextBoxLine("Reserve_QB: " + second);
            AppendTextBoxLine("RB: " + sixth);
            AppendTextBoxLine("Reserve_RB: " + seventh);
            AppendTextBoxLine("WR: " + ninth);
            AppendTextBoxLine("WR2: " + tenth);
            AppendTextBoxLine("Reserve_WR: " + eleventh);
            AppendTextBoxLine("TE: " + fourth);
            AppendTextBoxLine("Reserve_TE: " + fifth);
            AppendTextBoxLine("K: " + eighth);
            AppendTextBoxLine("Defense: " + third);
        }
    }
}
