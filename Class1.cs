using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_2
{
    class Inventory_Items
    {
        protected string NameOfItem;
        protected string AbbreviationOfItem;
        protected string DescriptionOfItem;
        protected string ColorOfItem;
        protected string SizeOfItem;


        protected Boolean IsNewItem;
        protected Boolean IsUsedItem;
        protected Boolean SeperateByColor;
        protected Boolean SeperateBySize;

        protected int OnHandQuantityOfItem;
        protected int DesiredQuantityOfItem;
        protected int NeededQuantityOfItem;
    }
}
