using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace Milestone_2
{

        public class IArray : Inventory_Items, IEnumerable
        {


            static Inventory_Items[] _IArray;
            public IArray(Inventory_Items[] iArray)
            {
                _IArray = new Inventory_Items[iArray.Length];

                for (int i = 0; i < iArray.Length; i++)
                {
                    _IArray[i] = iArray[i];
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return (IEnumerator)GetEnumerator();
            }

            public IArrayEnum GetEnumerator()
            {
                return new IArrayEnum(_IArray);
            }


         
            public class IArrayEnum : IEnumerator
            {
                public Inventory_Items[] _IArray;

             
                int position = -1;

                public IArrayEnum(Inventory_Items[] list)
                {
                    this.IArray = list;
                }

            //  public IArrayEnum(Inventory_Items[] iArray)
            //  {
            //      IArray = iArray;
            //   }

            public bool MoveNext()
                {
                    position++;
                    return (position < this.IArray.Length);
                }

                public void Reset()
                {
                    position = -1;
                }

                object IEnumerator.Current
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
                            return this.IArray[position];
                        }
                        catch (IndexOutOfRangeException)
                        {
                            throw new InvalidOperationException();
                        }
                    }
                }

                public Inventory_Items[] IArray { get; }
            }
        }
    }
