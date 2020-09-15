using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_2
{
    class Enumerator
    {
        public class InventoryItemArrEnum : PictureBox, IEnumerator
        {

            // Collection of Person objects. This class
            // implements IEnumerable so that it can be used
            // with ForEach syntax.

            static Inventory_Items[] _InventoryItemArr;
            public InventoryItemArr(Inventory_Items[] inventoryItemArr)
            {
                _InventoryItemArr = new Inventory_Items[inventoryItemArr.Length];

                for (int i = 0; i < inventoryItemArr.Length; i++)
                {
                    InventoryItemArrEnum[i] = inventoryItemArr[i];
                }
            }

            // Implementation for the GetEnumerator method.
            Enumerator Enumerable.GetEnumerator()
            {
                return (Enumerator)GetEnumerator();
            }

            public InventoryItemArrEnum GetEnumerator()
            {
                return new InventoryItemArrEnum(InventoryItemArr);
            }
                
                
            public Inventory_Items[] InventoryItemArr;

            // Enumerators are positioned before the first element
            // until the first MoveNext() call.
            readonly int position = -1;

            public InventoryItemArrEnum(Inventory_Items[]InventoryItemArr)
            {
                
               return this.InventoryItemArr.Length;
        
            }

            public bool MoveNext()
            {
                position++;
                return (position < this.InventoryItemArr.Length);
            }

            public void Reset()
            {
                position = -1;
            }

            public object Enumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public Inventory_Items Current
            {
                get
                {
                    try
                    {
                        return this.InventoryItemArr[position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }

            public Inventory_Items[] InventoryItemArr { get; }
        }
    }
}

