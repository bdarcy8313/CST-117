using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_2
{

    public class Inventory_Items : IEnumerator, IEnumerable
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
        string OnHandQuantityOfItem;
        public string OnHandQuantity
        {
            get { return OnHandQuantityOfItem; }
            set
            {
                // Console.Write("Enter the quantity of item on hand: ");
                // OnHandQuantity = int.Parse(Console.ReadLine());
                OnHandQuantityOfItem = value;
            }
        }
        string DesiredQuantityOfItem;
        public string DesiredQuantity
        {
            get { return DesiredQuantityOfItem; }
            set
            {
                // Console.Write("Enter the desired quantity of item: ");
                // DesiredQuantity = int.Parse(Console.ReadLine());
                DesiredQuantityOfItem = value;
            }
        }
        string NeededQuantityOfItem;
        public string NeededQuantity
        {
            get { return NeededQuantityOfItem; }
            set
            {
                // Console.Write("Enter the needed quantity of item: ");
                // NeededQuantity = int.Parse(Console.ReadLine());
                NeededQuantityOfItem = value;
            }
        }
        string CostOfItem;
        public string Cost
        {
            get { return CostOfItem; }
            set
            {
                // Console.Write("Enter cost of item: ");
                // Cost = double.Parse(Console.ReadLine());
                CostOfItem = value;
            }
        }

        public object Current { get; }
        public int Length { get; internal set; }
        object IEnumerator.Current { get; }

        public Inventory_Items(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j)
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

        public Inventory_Items()
        {
        }

        ~Inventory_Items()
        {
            System.Diagnostics.Trace.WriteLine("Destructor is cleaning things up.");
        }

        bool IEnumerator.MoveNext()
        {
            throw new NotImplementedException();
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    }

