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
using SwissTransport.Core;
using SwissTransport.Models;

namespace SBB
{
    public partial class Detail : Form
    {
        private Connection connection;

        public Detail()
        {
            InitializeComponent();
        }

        private void setDetails()
        {
            connection = Tag as Connection;

            deprautre_placerholder.Text = connection.From.Station.Name;
            //com
            deprautre_time_placerholder.Text = connection.To.Station.Name;
            //com
            destination_time_placerholder.Text = DateTime.Parse(connection.From.Departure.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
            //com
            arival_time_placerholder.Text = DateTime.Parse(connection.To.Arrival.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void setDataView()
        {
            void add_connection_to_table(Pass staion){
            
                string[] row = new string[]
                {
                staion.Arrival,
                staion.Station.Name,
                staion.Departure
                };

                // add the values into the listview and set the connection as the tag of the row
                ltvConnections.Items.Add(new ListViewItem(row)
                {
                    Tag = staion
                });
            }

            connection = Tag as Connection;

            // if error just add email reference
            Console.WriteLine("here");
            Console.WriteLine(connection.Sections.Count);
      
            foreach (Section section in connection.Sections)
            {
                Console.WriteLine(section.Journey.Passes);
                foreach (Pass pass in section.Journey.Passes)
                {
                    add_connection_to_table(pass);
                }
                
            }
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            ltvConnections.Items.Clear();
            setDetails();
            setDataView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = Tag as Connection;

            string targetEmail = EmailInput.Text;
            string departureTime = DateTime.Parse(connection.From.Departure.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
            string deparutreLocation = connection.From.Station.Name;
            string arrivalTime = DateTime.Parse(connection.To.Arrival.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
            string arrivatLocation = connection.To.Station.Name;

            string mailText = $"The Train will depart at {departureTime} in {deparutreLocation} and will arive at {arrivalTime} in {arrivatLocation}";

            System.Diagnostics.Process.Start($"mailto:{targetEmail}?subject=SBB Fahrplan&body={mailText}");
        }
    }
}
