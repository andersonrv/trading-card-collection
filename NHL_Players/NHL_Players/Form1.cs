/*
Course code: SODV2202
Term/Year: Fall/2018
Assignment code: A2
Author: Anderson Resende Viana
BVC username : a.resendeviana683
Date created : 2018-10-31
Description : Assignment 2
Repository: https://aresendeviana683@bitbucket.org/aresendeviana683/sodv2202_assignment2.git
Comments:   Since in the.csv file there was several players who played in more than one team, I manually edited it.
            I was not able to complete "Sort On Multiple keys" and "Apply both filter and sort".
            Although it is possible to add multiple sorting, only the last one takes place on the result.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Linq.Expressions;



namespace NHL_Players
{


    public partial class NHLForm : Form
    {
        List<Player> ListOfPlayers = new List<Player>();

        List<Filter> ListOfFilters = new List<Filter>();

        List<SortBy> ListOfOrderByFilters = new List<SortBy>();

        //Display all Data in table
        BindingList<Player> listBindingFiles = new BindingList<Player>();

        string[] listOfProperties = { "NAME", "TEAM", "POS", "GP", "G", "A", "P", "PlusMinus", "PIM", "PGP", "PPG", "PPP", "SHG", "SHP", "GWG", "OTG", "S", "SPERCENT", "TOIGP", "SHIFTS", "FOW" };

        string[] listOfOperators = { "==", "<", "<=", ">=", ">" };

        string[] listOfOrders = { "ASC", "DES" };

        public NHLForm()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            BindingList<Player> initialList = new BindingList<Player>();

            string[] csvFileData = File.ReadAllLines("NHL_Player_Stats_2017-18_-_Sanitized.csv");

            foreach (string line in csvFileData) // read every line in the file, create a player and push it to the list
            {
                string[] pStat = line.Split(',');

                Player aPlayer = new Player(
                    pStat[0], // name
                    pStat[1], // team
                    pStat[2], // pos
                    Convert.ToDouble(pStat[3]), // gp
                    Convert.ToDouble(pStat[4]), // g
                    Convert.ToDouble(pStat[5]), // a
                    Convert.ToDouble(pStat[6]), // p
                    Convert.ToDouble(pStat[7]), // +/-
                    Convert.ToDouble(pStat[8]), // pim
                    Convert.ToDouble(pStat[9]), // p/gp
                    Convert.ToDouble(pStat[10]), // ppg
                    Convert.ToDouble(pStat[11]), // ppp
                    Convert.ToDouble(pStat[12]), // shg
                    Convert.ToDouble(pStat[13]), // shp
                    Convert.ToDouble(pStat[14]), // gwg
                    Convert.ToDouble(pStat[15]), // otg
                    Convert.ToDouble(pStat[16]),  // s
                    Convert.ToDouble(pStat[17]), // s
                    pStat[18], // toigp
                    Convert.ToDouble(pStat[19]), // shifts
                    Convert.ToDouble(pStat[20]) // fow
                    );

                ListOfPlayers.Add(aPlayer);
            }

            foreach (var item in ListOfPlayers)
            {
                listBindingFiles.Add(item);
            }

            UpdateResult(listBindingFiles);
        }

        private void UpdateResult(BindingList<Player> updatedList)
        {
            NHLDataView.DataSource = updatedList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void PropertyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void OperatorBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        BindingList<Player> QueryStringProperty(string Property, string SoughtResult, BindingList<Player> InputList)
        {
            var outputBindingList = new BindingList<Player>();

            // Focing case insensitive input... (Optional) Just need to supress foreach below and remove ToUpper() from if statements
            foreach (var item in InputList)
            {
                item.NAME = item.NAME.ToUpper();
                item.TEAM = item.TEAM.ToUpper();
                item.POS = item.POS.ToUpper();
            }

            if (Property == "NAME")
            {
                var results = InputList.Where(p => p.NAME.Contains(SoughtResult.ToUpper()));
                foreach (var item in results)
                {
                    outputBindingList.Add(item);
                }
                return outputBindingList;
            }
            else if (Property == "TEAM")
            {
                var results = InputList.Where(p => p.TEAM.Contains(SoughtResult.ToUpper()));
                foreach (var item in results)
                {
                    outputBindingList.Add(item);
                }
                return outputBindingList;
            }
            else if (Property == "POS")
            {
                var results = InputList.Where(p => p.POS.Contains(SoughtResult.ToUpper()));
                foreach (var item in results)
                {
                    outputBindingList.Add(item);
                }
                return outputBindingList;
            }
            else //if (Property == "TOIGP")
            {
                var results = InputList.Where(p => p.TOIGP.Contains(SoughtResult.ToUpper()));
                foreach (var item in results)
                {
                    outputBindingList.Add(item);
                }
                return outputBindingList;
            }
        }

        BindingList<Player> QueryDoubleProperty(string Property, string Operator, string SoughtResult, BindingList<Player> InputList)
        {
            IEnumerable<Player> result;

            var outputBindingList = new BindingList<Player>();

            BinaryExpression comparison;

            var parameter = Expression.Parameter(typeof(Player), "player");

            string playerClassType = "NHL_Players.Player";

            // Validating input to make sure the code will be executed only with a valid double 
            double check;
            bool inputIsDouble = Double.TryParse(SoughtResult, out check);
            if(inputIsDouble)
            {
                // The query is performed by Expression Tree. 
                // So the code dynamically creates the expression (builtLambda) with two parts, comparison and parameter.
                // Parameter is fixed and defined above and calls the type of object held in the list.
                // Comparison access dynamically the properties within the object. 
                // To avoid crashes due to invalid properties, the code locks the input options in the FilterPropertyBox.
                if (Operator == "<")
                {
                    comparison = Expression.LessThan(Expression.Property(parameter, Type.GetType(playerClassType).GetProperty(Property)), Expression.Constant(Convert.ToDouble(SoughtResult)));
                    Func<Player, bool> builtLambda = Expression.Lambda<Func<Player, bool>>(comparison, parameter).Compile();
                    result = InputList.Where(builtLambda);
                    foreach (var item in result)
                    {
                        outputBindingList.Add(item);
                    }
                    return outputBindingList;
                }
                else if (Operator == "<=")
                {
                    comparison = Expression.LessThanOrEqual(Expression.Property(parameter, Type.GetType(playerClassType).GetProperty(Property)), Expression.Constant(Convert.ToDouble(SoughtResult)));
                    Func<Player, bool> builtLambda = Expression.Lambda<Func<Player, bool>>(comparison, parameter).Compile();
                    result = InputList.Where(builtLambda);
                    foreach (var item in result)
                    {
                        outputBindingList.Add(item);
                    }
                    return outputBindingList;
                }
                else if (Operator == "==")
                {
                    comparison = Expression.Equal(Expression.Property(parameter, Type.GetType(playerClassType).GetProperty(Property)), Expression.Constant(Convert.ToDouble(SoughtResult)));
                    Func<Player, bool> builtLambda = Expression.Lambda<Func<Player, bool>>(comparison, parameter).Compile();
                    result = InputList.Where(builtLambda);
                    foreach (var item in result)
                    {
                        outputBindingList.Add(item);
                    }
                    return outputBindingList;
                }
                else if (Operator == ">=")
                {
                    comparison = Expression.GreaterThanOrEqual(Expression.Property(parameter, Type.GetType(playerClassType).GetProperty(Property)), Expression.Constant(Convert.ToDouble(SoughtResult)));
                    Func<Player, bool> builtLambda = Expression.Lambda<Func<Player, bool>>(comparison, parameter).Compile();
                    result = InputList.Where(builtLambda);
                    foreach (var item in result)
                    {
                        outputBindingList.Add(item);
                    }
                    return outputBindingList;
                }
                else // (Operator == ">")
                {
                    comparison = Expression.GreaterThan(Expression.Property(parameter, Type.GetType(playerClassType).GetProperty(Property)), Expression.Constant(Convert.ToDouble(SoughtResult)));
                    Func<Player, bool> builtLambda = Expression.Lambda<Func<Player, bool>>(comparison, parameter).Compile();
                    result = InputList.Where(builtLambda);
                    foreach (var item in result)
                    {
                        outputBindingList.Add(item);
                    }
                    return outputBindingList;
                }

            }
            else
            {
                return outputBindingList;

            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var initialList = listBindingFiles;

            if (FilterFlowPanel.Controls.Count > 0)
            {
                foreach (Filter item in FilterFlowPanel.Controls)
                {
                    if (item.MyPropertyBox == "NAME" ||item.MyPropertyBox == "TEAM" || item.MyPropertyBox == "POS" || item.MyPropertyBox == "TOIGP")
                    {
                        var result = QueryStringProperty(item.MyPropertyBox, item.MyValueTextBox, initialList);
                        initialList = result;
                        UpdateResult(result);
                    }
                    else
                    {
                        var result = QueryDoubleProperty(item.MyPropertyBox, item.MyOperatorBox, item.MyValueTextBox, initialList);
                        initialList = result;
                        UpdateResult(result);
                    }
                }
                if (OrderFlowPanel.Controls.Count > 0)
                {
                    foreach (SortBy item in OrderFlowPanel.Controls)
                    {
                        var orderedResult = OrderResultsBy(item.MyPropertyBox, item.MyOrderBox, initialList);
                        UpdateResult(orderedResult);
                    }
                }

            }


            // add sorting function here

        }

        BindingList<Player> OrderResultsBy(string Property, string Order, BindingList<Player> InputList)
        {
            IEnumerable<Player> result;
            string playerClassType = "NHL_Players.Player";
            var parameter = Expression.Parameter(typeof(Player), "player");

            BindingList<Player> orderedBindingList = new BindingList<Player>();

            if (OrderFlowPanel.Controls.Count > 0 && FilterFlowPanel.Controls.Count > 0)
            {
                foreach (SortBy control in OrderFlowPanel.Controls)
                {
                    if (Property == "NAME" || Property == "TEAM" || Property == "POS" || Property == "TOIGP")
                    {
                        if(Order == "ASC")
                        {
                            // .OrderBy(p => p.MyPropertyBox)
                            var comparison = Expression.Property(parameter, Type.GetType(playerClassType).GetProperty(Property));
                            Func<Player, string> builtLambda = Expression.Lambda<Func<Player, string>>(comparison, parameter).Compile();
                            result = InputList.OrderBy(builtLambda);
                            foreach (var item in result)
                            {
                                orderedBindingList.Add(item);
                            }
                            return orderedBindingList;
                        }
                        else //if (control.MyOrderBox == "DES")
                        {
                            var comparison = Expression.Property(parameter, Type.GetType(playerClassType).GetProperty(Property));
                            Func<Player, string> builtLambda = Expression.Lambda<Func<Player, string>>(comparison, parameter).Compile();
                            result = InputList.OrderByDescending(builtLambda);
                            foreach (var item in result)
                            {
                                orderedBindingList.Add(item);
                            }
                            return orderedBindingList;
                        }
                    }
                    else // other double properties
                    {
                        if (Order == "ASC")
                        {
                            var comparison = Expression.Property(parameter, Type.GetType(playerClassType).GetProperty(Property));
                            Func<Player, double> builtLambda = Expression.Lambda<Func<Player, double>>(comparison, parameter).Compile();
                            result = InputList.OrderBy(builtLambda);
                            foreach (var item in result)
                            {
                                orderedBindingList.Add(item);
                            }
                            return orderedBindingList;
                        }
                        else //if (control.MyOrderBox == "DES")
                        {
                            var comparison = Expression.Property(parameter, Type.GetType(playerClassType).GetProperty(Property));
                            Func<Player, double> builtLambda = Expression.Lambda<Func<Player, double>>(comparison, parameter).Compile();
                            result = InputList.OrderByDescending(builtLambda);
                            foreach (var item in result)
                            {
                                orderedBindingList.Add(item);
                            }
                            return orderedBindingList;
                        }
                    }

                }
            }
            else
            {
                return orderedBindingList;
            }
            return orderedBindingList;
        }



        private void NHLDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InsertFilter_Click(object sender, EventArgs e)
        {
            // get last item in the list of filters
            //var LastFilter = ListOfFilters.Last();
            // create a new filter and add it below the last one
            Filter aFilter = new Filter(listOfProperties, listOfOperators);
            aFilter.Id = ListOfFilters.Count;
            ListOfFilters.Add(aFilter);
            FilterFlowPanel.Controls.Add(aFilter);
            
            //Debugging
            Debug.WriteLine(ListOfFilters[0].Id);
            Debug.WriteLine(ListOfFilters[ListOfFilters.Count - 1].Id);
            Debug.WriteLine(ListOfFilters.Count);


        }

        private void InsertOrder_Click(object sender, EventArgs e)
        {
            SortBy anOrderFilter = new SortBy(listOfProperties, listOfOrders);
            anOrderFilter.Id = ListOfOrderByFilters.Count;
            ListOfOrderByFilters.Add(anOrderFilter);
            OrderFlowPanel.Controls.Add(anOrderFilter);
        }

        private void FiltersPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FilterFlowPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click_1(object sender, EventArgs e)
        {
            ListOfFilters.Clear();
            ListOfOrderByFilters.Clear();
            FilterFlowPanel.Controls.Clear();
            OrderFlowPanel.Controls.Clear();
        }

        //public static class LinqDynamicMultiSortingUtility
        //{
        //    /// <summary>
        //    /// 1. The sortExpressions is a list of Tuples, the first item of the 
        //    ///    tuples is the field name,
        //    ///    the second item of the tuples is the sorting order (asc/desc) case sensitive.
        //    /// 2. If the field name (case sensitive) provided for sorting does not exist 
        //    ///    in the object,
        //    ///    exception is thrown
        //    /// 3. If a property name shows up more than once in the "sortExpressions", 
        //    ///    only the first takes effect.
        //    /// </summary>
        //    /// <typeparam name="T"></typeparam>
        //    /// <param name="data"></param>
        //    /// <param name="sortExpressions"></param>
        //    /// <returns></returns>
        //    public static IEnumerable<T> MultipleSort<T>(this IEnumerable<T> data,
        //      List<Tuple<string, string>> sortExpressions)
        //    {
        //        // No sorting needed
        //        if ((sortExpressions == null) || (sortExpressions.Count <= 0))
        //        {
        //            return data;
        //        }

        //        // Let us sort it
        //        IEnumerable<T> query = from item in data select item;
        //        IOrderedEnumerable<T> orderedQuery = null;

        //        for (int i = 0; i < sortExpressions.Count; i++)
        //        {
        //            // We need to keep the loop index, not sure why it is altered by the Linq.
        //            var index = i;
        //            Func<T, object> expression = item => item.GetType()
        //                            .GetProperty(sortExpressions[index].Item1)
        //                            .GetValue(item, null);

        //            if (sortExpressions[index].Item2 == "asc")
        //            {
        //                orderedQuery = (index == 0) ? query.OrderBy(expression)
        //                  : orderedQuery.ThenBy(expression);
        //            }
        //            else
        //            {
        //                orderedQuery = (index == 0) ? query.OrderByDescending(expression)
        //                         : orderedQuery.ThenByDescending(expression);
        //            }
        //        }

        //        query = orderedQuery;

        //        return query;
        //    }
        //}
    }
}
