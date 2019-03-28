using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHL_Players
{
    public partial class SortBy : UserControl
    {
        public SortBy(string[] ListOfProperties, string[] ListOfOrders)
        {
            InitializeComponent();
            _listOfProperties = (string[])ListOfProperties.Clone();
            _listOfOrders = (string[])ListOfOrders.Clone();
        }

        protected string[] _listOfProperties;

        protected string[] _listOfOrders;

        private int _id;

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string MyPropertyBox
        {
            get
            {
                return PropFilterBox.Text;
            }
            set
            {
                PropFilterBox.Text = value;
            }
        }

        public string MyOrderBox
        {
            get
            {
                return PropFilterOrder.Text;
            }
            set
            {
                PropFilterOrder.Text = value;
            }
        }

        private void PropFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PropFilterOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OrderByFilter_Load(object sender, EventArgs e)
        {
            // Populate Property ComboBox with options
            PropFilterBox.DataSource = _listOfProperties;


            // Populate Orders ComboBox with options
            PropFilterOrder.DataSource = _listOfOrders;
        }
    }
}
