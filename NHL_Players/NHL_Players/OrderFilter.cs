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
    public partial class OrderFilter : UserControl
    {
        public OrderFilter(string[] props, string[] orders)
        {
            InitializeComponent();
            _listOfProperties = props;
            _listOfOrders = orders;
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

        private void PropFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PropFilterOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OrderFilter_Load(object sender, EventArgs e)
        {
            // Populate Property ComboBox with options
            PropFilterBox.DataSource = _listOfProperties;


            // Populate Orders ComboBox with options
            PropFilterOrder.DataSource = _listOfOrders;
        }
    }
}
