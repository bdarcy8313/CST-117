using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_2
{
   
    public class Inventory_Items
    {
        string NameOfItem;
        public string Name   
        {
            get { return NameOfItem; }
            set 
            {
               // Console.Write("Enter name of item: ");
               // Name = Console.ReadLine();
                NameOfItem = value;
            }
        }
        string ColorOfItem;
        public string Color
        {
            get { return ColorOfItem; }
            set 
            {
               // Console.Write("Enter the color of item: ");
               // Color = Console.ReadLine();
                ColorOfItem = value; 
            }
        }
        string SizeOfItem;
        public string Size
        {
            get { return SizeOfItem; }
            set 
            {
               // Console.Write("Enter the size of item: ");
               // Size = Console.ReadLine();
                SizeOfItem = value;
            }
        }
        
        string WhereToReorderItem;
        public string WhereToReorder
        {
            get { return WhereToReorderItem; }
            set
            {
               // Console.Write("Where to reorder item? ");
               // WhereToReorder = Console.ReadLine();
                WhereToReorderItem = value;
            }
        }
        string IsNewItem;
        public string IsNew
        {
            get { return IsNewItem; }
            set 
            {
               // Console.Write("True or false that item was purchased brand new? ");
               // IsNew = Boolean.Parse(Console.ReadLine());
                IsNewItem = value; 
            }
        }
        string DamageToItem;
        public string DamageTo
        {
            get { return DamageToItem; }
            set 
            {
               // Console.Write("True or false that item is damaged? ");
               // DamageTo = Boolean.Parse(Console.ReadLine());
                DamageToItem = value;
            }
        }
        int OnHandQuantityOfItem;
        public int OnHandQuantity
        {
            get { return OnHandQuantityOfItem; }
            set 
            {
               // Console.Write("Enter the quantity of item on hand: ");
               // OnHandQuantity = int.Parse(Console.ReadLine());
                OnHandQuantityOfItem = value; 
            }
        }
        int DesiredQuantityOfItem;
        public int DesiredQuantity
        {
            get { return DesiredQuantityOfItem; }
            set 
            {
               // Console.Write("Enter the desired quantity of item: ");
               // DesiredQuantity = int.Parse(Console.ReadLine());
                DesiredQuantityOfItem = value; 
            }
        }
        int NeededQuantityOfItem;
        public int NeededQuantity
        {
            get { return NeededQuantityOfItem; }
            set 
            {
               // Console.Write("Enter the needed quantity of item: ");
               // NeededQuantity = int.Parse(Console.ReadLine());
                NeededQuantityOfItem = value;
            }
        }
        double CostOfItem;
        public double Cost
        {
            get { return CostOfItem; }
            set 
            {
               // Console.Write("Enter cost of item: ");
               // Cost = double.Parse(Console.ReadLine());
                CostOfItem = value;
            }
        }
        public Inventory_Items()
        { }
        public Inventory_Items(string a, string b, string c, string d, string e, string f, int g, int h, int i, double j)
        {
            this.Name = a;
            this.Color = b;
            this.Size = c;
            this.WhereToReorder = d;
            this.IsNew = e;
            this.DamageTo = f;
            this.OnHandQuantity = g;
            this.DesiredQuantity = h;
            this.NeededQuantity = i;
            this.Cost = j;


        }

        ~Inventory_Items()
        {
            System.Diagnostics.Trace.WriteLine("Destructor is cleaning things up.");
        }
    }
}
