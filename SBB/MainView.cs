using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;
using SwissTransport.Models;
using SwissTransport.Core;

namespace SBB
{
    public partial class MainView : Form
    {
        private readonly Transport _transportHanlder;
        private readonly Detail _FormConnectionDetails;

        public MainView()
        {
            // init new transport Handler and new Detial Form
            _transportHanlder = new Transport();
            _FormConnectionDetails = new Detail();

            // initiliazie componet
            InitializeComponent();

            // set state for the datetime picker -> will evelauate to false
            setStateTimePicker();
            inputValidation();
        }

        private void OnStaionInputChangeEffect(ComboBox c_element)
        {
            // catch unexpected errors so user can continue with the application
            try
            {
                // request stations from the API from given input
                Stations _stations = _transportHanlder.GetStations(c_element.Text);

                // clear input so there are no false values
                c_element.Items.Clear();

                // if the request returned no stations, return and cancel operation
                if (_stations.StationList.Count == 0)
                {
                    Console.WriteLine("Station count is 0");
                    return;
                }

                // loop over each station and andd it to the view
                foreach (Station station in _stations.StationList)
                {
                    // if the station is none hide
                    if (string.IsNullOrEmpty(station.Name))
                    {
                        continue;
                    }

                    c_element.Items.Add(station.Name);
                }

                // adter updating the Items the index needs to be set to the last char
                c_element.SelectionStart = c_element.Text.Length;
            }
            catch
            {
                return;
            }
        }

        private void setStateTimePicker()
        {
            // if datetimepicker is checked enable the buttons and the date input
            if (DateTimePickerChecker.Checked)
            {
                roundButtonDeparture.Enabled = true;
                roundButtonArival.Enabled = true;
                dateTimePicker.Enabled = true;
            }
            // if not enabled disable the buttons
            else
            {
                roundButtonDeparture.Enabled = false;
                roundButtonArival.Enabled = false;
                dateTimePicker.Enabled = false;
            }
        }

        private void inputValidation()
        {
            // if start station is empty set bool to true else false
            bool invalid = startLocationInputCB.Text == ""  ? true : false;

            // if invalid disable button
            searchBtn.Enabled = invalid ? false : true;
        }
        
        private void addConnectionToView(Connection connection)
        {
            // create a string array with the required column items
            string[] values = new string[]
{
                connection.From.Station.Name,
                connection.From.Departure.ToString(),
                connection.To.Station.Name,
                connection.To.Arrival.ToString(),
                (DateTime.Parse(connection.To.Arrival.ToString()) - DateTime.Parse(connection.From.Departure.ToString())).ToString()

};

            // add the values into the listview and set the connection as the tag of the row
            mainViewLsv.Items.Add(new ListViewItem(values)
            {
                // set Tag to connection so connection can later be display in detailed view
                Tag = connection
            });
        }

        private DateTime get_time(Connection connection)
        {
            // if the DateTimePicker is enabled get the preffered departure time
            if (DateTimePickerChecker.Checked)
            {
                // check if connection should be checked for departure
                if (roundButtonDeparture.Checked)
                {
                    // return date rom dateTimePicker
                    return dateTimePicker.Value.Date;

                }
                // if connection is set to 
                else
                {
                    return dateTimePicker.Value.Date;
                }
            }
            // if no input set default time to now.
            return DateTime.Now;
        }

        public void getStartConnection()
        {
            // set try catch block for user
            try
            {

                // make API call
                Station station = _transportHanlder.GetStations(startLocationInputCB.Text).StationList.ElementAt(0);
                
                // create board from stationname and it 
                StationBoardRoot Board = _transportHanlder.GetStationBoard(station.Name, station.Id);

                // set the cursor to loading so the user knows the application is working
                Cursor.Current = Cursors.WaitCursor;

                // loop over each  board
                foreach (StationBoard bord in Board.Entries)
                {
                    try
                    {
                        // get station from baoard
                        Station to_statoin = _transportHanlder.GetStations(bord.To).StationList.ElementAt(0);

                        // get connections from station
                        Connection connection = _transportHanlder.GetConnections(bord.Stop.Station.Name, to_statoin.Name, 1, DateTime.Now, DateTime.Now, 10).ConnectionList[0];

                        // add connection to View
                        addConnectionToView(connection);
                    }
                    catch
                    {
                        return;
                    }

                }
                // reset the cursor the default view
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                return;
            }


        }

        private void submitSearch()
        {
            // if num is set to 0 (defautl) api will intepret date as departure time if set to one to arrival.
            int num;

            // set set train time var;
            DateTime trainTime;

            // if dateitme picker is checked get custom user input
            if (DateTimePickerChecker.Checked)
            {
                // if roundBzttonDeparture is checked set num to 0 (time for departure)
                if (roundButtonDeparture.Checked)
                {
                    num = 0;
                    
                }
                // otherwise set to one (time for arrival)
                else
                {
                    num = 1; 
                }
                
                // get value from dateTimePiker
                trainTime = dateTimePicker.Value;

            }
            else
            {
                num = 0;
                trainTime = DateTime.Now;
            }

            // make API call and store res to _connections
            Connections _connections = _transportHanlder.GetConnections(startLocationInputCB.Text, destionationInputCB.Text, num, trainTime, trainTime, 16);

            // clear view for the new items
            mainViewLsv.Items.Clear();

            foreach (Connection connection in _connections.ConnectionList)
            {
                // add connecitons to viwe
                addConnectionToView(connection);
           
            }
        }

        
        private void startLocationInput_TextUpdate(object sender, EventArgs e)
        {
            // on text update get rec
            OnStaionInputChangeEffect(startLocationInputCB);
            inputValidation();
        }

        private void cmbDestinationLocation_TextUpdate(object sender, EventArgs e)
        {
            // on Text update call station_rec
            OnStaionInputChangeEffect(destionationInputCB);
            inputValidation();
        }

        private void chbSpecifyTime_CheckStateChanged(object sender, EventArgs e)
        {
            // refresh datetime picker
            setStateTimePicker();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // decide action that should be called
            if (destionationInputCB.Text == "")
            {
                // if destionarion is empty search for 
                getStartConnection();
            }
            else
            {
                // else search for connecitons
                submitSearch();
            }
            
        }

        private void ltvConnections_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if no Items in View break 
            if (mainViewLsv.SelectedItems.Count <= 0 || mainViewLsv.SelectedIndices[0] < 0)
            {
                return;
            }

            // get wanted list Item from view
            ListViewItem item = mainViewLsv.SelectedItems[0];
            Console.WriteLine(item.Tag);

            // assing connection on from (data transfer)
            _FormConnectionDetails.Tag = item.Tag;
            // show Form as Dialog
            _FormConnectionDetails.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // clear view items if user presses button to clear
            mainViewLsv.Items.Clear();
        }
    }
}
