using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniExplorer.Utils
{
    public class ListViewItemComparer : IComparer
    {
        /*
         * **************************************************************************************
         * *                                 INSTANCE VARIABLES                                 *
         * **************************************************************************************
         */
        private int column;
        private SortOrder order;


        /*
         * **************************************************************************************
         * *                                    CONSTRUCTORS                                    *
         * **************************************************************************************
        */
        public ListViewItemComparer()
        {
            column = 0;
            order = SortOrder.Ascending;
        }

        public ListViewItemComparer(int column, SortOrder order)
        {
            this.column = column;
            this.order = order;
        }

        /*
         * **************************************************************************************
         * *                                       METHODS                                      *
         * **************************************************************************************
        */
        public int Compare(object? x, object? y)
        {
            if (x is not ListViewItem item1 || y is not ListViewItem item2)
                return 0;

            string text1 = item1.SubItems.Count > column ? item1.SubItems[column].Text : string.Empty;
            string text2 = item2.SubItems.Count > column ? item2.SubItems[column].Text : string.Empty;
            int result = string.Compare(text1, text2);
            if (this.order == SortOrder.Descending)
                return -result;

            return result;
        }
    }
}
