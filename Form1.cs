using System;
using System.Collections;
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
    
        //Lines 22-38 are for clearing the text boxes 
        private void ClearInfo_Click(object sender, EventArgs e)
        {

            foreach (Control Cleartext in this.Controls)

            {

                if (Cleartext is TextBox box)

                {

                    box.Text = string.Empty;

                }

            }
        }
        //Lines 40-47 are for deleting the objects themselves instead of simply clearing them
        private void Delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items.RemoveAt(i);
            }

        }
        //Lines 49-52 closse the app
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       


        //I do not know where line 58 came from, I tried all kinds of stuff including creating a class that creates Inventory_ItemArrays from the Inventory_Items so probly is a leftover
        public object Current { get; }
        //Lines 60-65 are public instances of the information so that they can be searched through....some anyway
        public string[] array2 = new string[10];
        public string[] iArray = new string[10];
        public string[] array = new string[10];
        public string[] array3 = new string[10];
        public Inventory_Items MB3 = new Inventory_Items();
        public Inventory_Items MB2 = new Inventory_Items();
        public Inventory_Items MB4 = new Inventory_Items();
        public Inventory_Items MB5 = new Inventory_Items();
        public Inventory_Items MB6 = new Inventory_Items();
        public Inventory_Items MB7 = new Inventory_Items();
        public Inventory_Items MB8 = new Inventory_Items();
        public string[] array4 = new string[10];
        //Lines 66-119 populate the holders up above
        public void AddItem_Click(object sender, EventArgs e)
        {

            

            string ICost1 = ICost.Text;
            MB2.Name = IName.Text;
            MB2.Color = IColor.Text;
            MB2.Size = ISize.Text;
            MB2.WhereToReorder = IReorder.Text;
            MB2.IsNew = INew.Text;
            MB2.DamageTo = IDamage.Text;
            MB2.OnHandQuantity = IQTYH.Text;
            MB2.DesiredQuantity = IQTYD.Text;
            MB2.NeededQuantity = IQTYN.Text;
            MB2.Cost = ICost1;

           
            
                


            iArray = new string[] { MB3.Name, MB3.Color, MB3.Size, MB3.WhereToReorder, MB3.IsNew, MB3.DamageTo, MB3.OnHandQuantity, MB3.DesiredQuantity, MB3.NeededQuantity, MB3.Cost };
            array = new string[] { MB2.Name, MB2.Color, MB2.Size, MB2.WhereToReorder, MB2.IsNew, MB2.DamageTo, MB2.OnHandQuantity, MB2.DesiredQuantity, MB2.NeededQuantity, MB2.Cost };
            
            array2 = new string[] { MB4.Name, MB4.Color, MB4.Size, MB4.WhereToReorder, MB4.IsNew, MB4.DamageTo, MB4.OnHandQuantity, MB4.DesiredQuantity, MB4.NeededQuantity, MB4.Cost };
            
            array3 = new string[] { MB5.Name, MB5.Color, MB5.Size, MB5.WhereToReorder, MB5.IsNew, MB5.DamageTo, MB5.OnHandQuantity, MB5.DesiredQuantity, MB5.NeededQuantity, MB5.Cost };
            

            array4 = new string[] { MB6.Name, MB6.Color, MB6.Size, MB6.WhereToReorder, MB6.IsNew, MB6.DamageTo, MB6.OnHandQuantity, MB6.DesiredQuantity, MB6.NeededQuantity, MB6.Cost };
            


            

        }
        //Lines 121-136 are the search options
        private void Search_Click(object sender, EventArgs e)
        {
            string myString = SearchBox.Text;
            string l = "null";
            string s = myString;
            for (int i = 0; i < iArray.Length; i++)
            {
                if (iArray[i].Length >= array[i].Length)
                {
                    iArray[i] = l;
                }
                else
                {
                    array[i] = l;
                }
            }

        }

        private void Populate_Click(object sender, EventArgs e)
        {
            MB3.Name = "Pad";
            MB3.Color = "Blue";
            MB3.Size = "Big";
            MB3.WhereToReorder = "Anywhere";
            MB3.IsNew = "True";
            MB3.DamageTo = "False";
            MB3.OnHandQuantity = "200";
            MB3.DesiredQuantity = "300";
            MB3.NeededQuantity = "100";
            MB3.Cost = "23.56";

            MB4.Name = "Mattress Bag";
            MB4.Color = "Clear";
            MB4.Size = "Twin";
            MB4.WhereToReorder = "Anywhere";
            MB4.IsNew = "false";
            MB4.DamageTo = "True";
            MB4.OnHandQuantity = "15";
            MB4.DesiredQuantity = "30";
            MB4.NeededQuantity = "15";
            MB4.Cost = "6.00";

            MB5.Name = "Mattress Bag";
            MB5.Color = "Clear";
            MB5.Size = "Full";
            MB5.WhereToReorder = "Anywhere";
            MB5.IsNew = "True";
            MB5.DamageTo = "False";
            MB5.OnHandQuantity = "20";
            MB5.DesiredQuantity = "40";
            MB5.NeededQuantity = "20";
            MB5.Cost = "7.00";

            MB6.Name = "Mattress Bag";
            MB6.Color = "Clear";
            MB6.Size = "Queen";
            MB6.WhereToReorder = "Anywhere";
            MB6.IsNew = "False";
            MB6.DamageTo = "True";
            MB6.OnHandQuantity = "23";
            MB6.DesiredQuantity = "60";
            MB6.NeededQuantity = "37";
            MB6.Cost = "8.00";

            ListViewItem item3 = new ListViewItem(MB6.Name);
            item3.SubItems.Add(MB6.Color);
            item3.SubItems.Add(MB6.Size);
            item3.SubItems.Add(MB6.WhereToReorder);
            item3.SubItems.Add(MB6.IsNew);
            item3.SubItems.Add(MB6.DamageTo);
            item3.SubItems.Add(MB6.OnHandQuantity.ToString());
            item3.SubItems.Add(MB6.DesiredQuantity.ToString());
            item3.SubItems.Add(MB6.NeededQuantity.ToString());
            item3.SubItems.Add(MB6.Cost.ToString());
            listView1.Items.AddRange(new ListViewItem[] { item3 });



            ListViewItem item4 = new ListViewItem(MB3.Name);
            item4.SubItems.Add(MB3.Color);
            item4.SubItems.Add(MB3.Size);
            item4.SubItems.Add(MB3.WhereToReorder);
            item4.SubItems.Add(MB3.IsNew);
            item4.SubItems.Add(MB3.DamageTo);
            item4.SubItems.Add(MB3.OnHandQuantity.ToString());
            item4.SubItems.Add(MB3.DesiredQuantity.ToString());
            item4.SubItems.Add(MB3.NeededQuantity.ToString());
            item4.SubItems.Add(MB3.Cost.ToString());
            listView1.Items.AddRange(new ListViewItem[] { item4 });

            ListViewItem item5 = new ListViewItem(MB4.Name);
            item5.SubItems.Add(MB4.Color);
            item5.SubItems.Add(MB4.Size);
            item5.SubItems.Add(MB4.WhereToReorder);
            item5.SubItems.Add(MB4.IsNew);
            item5.SubItems.Add(MB4.DamageTo);
            item5.SubItems.Add(MB4.OnHandQuantity.ToString());
            item5.SubItems.Add(MB4.DesiredQuantity.ToString());
            item5.SubItems.Add(MB4.NeededQuantity.ToString());
            item5.SubItems.Add(MB4.Cost.ToString());
            listView1.Items.AddRange(new ListViewItem[] { item5 });

            ListViewItem item6 = new ListViewItem(MB5.Name);
            item6.SubItems.Add(MB5.Color);
            item6.SubItems.Add(MB5.Size);
            item6.SubItems.Add(MB5.WhereToReorder);
            item6.SubItems.Add(MB5.IsNew);
            item6.SubItems.Add(MB5.DamageTo);
            item6.SubItems.Add(MB5.OnHandQuantity.ToString());
            item6.SubItems.Add(MB5.DesiredQuantity.ToString());
            item6.SubItems.Add(MB5.NeededQuantity.ToString());
            item6.SubItems.Add(MB5.Cost.ToString());
            listView1.Items.AddRange(new ListViewItem[] { item6 });

        }
    }
}
//This was created solely by ME....Brian J Darcy. For Grand Canyon University 09/14/2020.