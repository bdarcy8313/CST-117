using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_2
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }
        int IQTYH1, IQTYD1, IQTYN1;

        private void ClearInfo_Click(object sender, EventArgs e)
        {
            
            foreach (Control Cleartext in this.Controls)

            {

                if (Cleartext is TextBox)

                {

                    ((TextBox)Cleartext).Text = string.Empty;

                }

            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {


            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(eachItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double ICost1;


        public void AddItem_Click(object sender, EventArgs e)
        {
            Inventory_Items MB2 = new Inventory_Items();

            IQTYH1 = Convert.ToInt32(IQTYH.Text);
            IQTYD1 = Convert.ToInt32(IQTYD.Text);
            IQTYN1 = Convert.ToInt32(IQTYN.Text);
            ICost1 = Convert.ToDouble(ICost.Text);
            MB2.Name = IName.Text;
            MB2.Color = IColor.Text;
            MB2.Size = ISize.Text;
            MB2.WhereToReorder = IReorder.Text;
            MB2.IsNew = INew.Text;
            MB2.DamageTo = IDamage.Text;
            MB2.OnHandQuantity = IQTYH1;
            MB2.DesiredQuantity = IQTYD1;
            MB2.NeededQuantity = IQTYN1;
            MB2.Cost = ICost1;
            


            string[] array = { MB2.Name, MB2.Color, MB2.Size, MB2.WhereToReorder, MB2.IsNew, MB2.DamageTo };
            int[] intArray = { MB2.OnHandQuantity, MB2.DesiredQuantity, MB2.NeededQuantity };
            double[] doubleArray = { MB2.Cost };
            ListViewItem item3 = new ListViewItem(MB2.Name);
            item3.SubItems.Add(MB2.Color);
            item3.SubItems.Add(MB2.Size);
            item3.SubItems.Add(MB2.WhereToReorder);
            item3.SubItems.Add(MB2.IsNew);
            item3.SubItems.Add(MB2.DamageTo);
            item3.SubItems.Add(MB2.OnHandQuantity.ToString());
            item3.SubItems.Add(MB2.DesiredQuantity.ToString());
            item3.SubItems.Add(MB2.NeededQuantity.ToString());
            item3.SubItems.Add(MB2.Cost.ToString());
            listView1.Items.AddRange(new ListViewItem[] { item3 });



        }
       

      
    }
}
