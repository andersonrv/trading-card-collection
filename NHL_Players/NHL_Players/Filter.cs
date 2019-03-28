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
    public partial class Filter : UserControl
    {
        public Filter(string[] ListOfProperties, string[] ListOfOperations)
        {
            InitializeComponent();
            _listOfProps = (string[])ListOfProperties.Clone();
            _listOfOps = (string[])ListOfOperations.Clone();

        }

        private int _id;

        protected string[] _listOfProps;

        protected string[] _listOfOps;

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
                return FilterPropertyBox.Text;
            }
            set
            {
                FilterPropertyBox.Text = value;
            }
        }

        public string MyOperatorBox
        {
            get
            {
                return FilterOperatorBox.Text;
            }
            set
            {
                FilterOperatorBox.Text = value;
            }
        }

        public string MyValueTextBox
        {
            get
            {
                return FilterValueTextBox.Text;
            }
            set
            {
                FilterValueTextBox.Text = value;
            }
        }

        private void Filter_Load(object sender, EventArgs e)
        {
            // Populate Property ComboBox with options
            FilterPropertyBox.DataSource =  _listOfProps;

            // Populate Operator ComboBox with options
            FilterOperatorBox.DataSource =  _listOfOps;
        }

        private void ValueTextBox_TextChanged(object sender, EventArgs e) // Locking UI for fields with strings
        {

        }

        private void FilterPropertyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterPropertyBox.Text == "NAME" || FilterPropertyBox.Text == "TEAM" || FilterPropertyBox.Text == "POS" || FilterPropertyBox.Text == "TOIGP")
            {
                FilterOperatorBox.Text = "==";
                FilterOperatorBox.Enabled = false;
            }
            else
            {
                FilterOperatorBox.Enabled = true;
            }
        }

        private void FilterOperatorBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FilterValueTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
