using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniExplorer.Controls
{
    public partial class StatusBar : UserControl
    {
        /*
         * **************************************************************************************
         * *                                 INSTANCE VARIABLES                                 *
         * **************************************************************************************
         */
        int elementCount;


        /*
         * **************************************************************************************
         * *                                    CONSTRUCTORS                                    *
         * **************************************************************************************
        */
        public StatusBar()
        {
            InitializeComponent();
        }

        /*
         * **************************************************************************************
         * *                                    PROPERTIES                                      *
         * **************************************************************************************
        */
        public int ElementCount
        {
            get => elementCount;
            set
            {
                elementCount = value;
                this.elementCountLabel.Text = $"{value} element(s)";
            }
        }
    }
}
