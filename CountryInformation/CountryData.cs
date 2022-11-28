using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Country_Information
{
    /*
     * Alexander Summers
     *
     * Gives coordinate information for user-selected countries
     * 3-1-2020
     *
     */
    public partial class CountryData : Form
    {
        public string[,] countryData;
        private string coords;
        private bool ShouldDisplayCoordinates = true;
        public CountryData()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Adds the countries to the internal array.
        /// </summary>
        /// <param name="emptyCountryArray"></param>
        void PopulateCountryArray(ref string[,] emptyCountryArray)
        {

            StreamReader readCountryFile = new StreamReader("CountryInfo.csv");

            string unneccessaryData = readCountryFile.ReadLine();

            for (int row = 0; row < emptyCountryArray.GetLength(0); row++)
            {
                string lineOfCSV = readCountryFile.ReadLine();

                emptyCountryArray[row, 0] = lineOfCSV.Substring(0, lineOfCSV.IndexOf(","));
                coords = lineOfCSV.Substring(lineOfCSV.IndexOf(",") + 1);

                emptyCountryArray[row, 1] = coords.Substring(0, coords.IndexOf(","));
                emptyCountryArray[row, 2] = coords.Substring(coords.IndexOf(",") + 1);
            }
            readCountryFile.Close();
        }
        /// <summary>
        /// Adds the countries to the ListBox.
        /// </summary>
        /// <param name="filledCountryArray"></param>
        void PopulateListOfCountries(ref string[,] filledCountryArray)
        {
            for (int row = 0; row < filledCountryArray.GetLength(0); row++)
            {
                lstCountries.Items.Add(filledCountryArray[row, 0]);
            }
        }
        /// <summary>
        /// Processes starting events when form is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountryData_Load(object sender, EventArgs e)
        {
            countryData = new string[243,3];
            PopulateCountryArray(ref countryData);
            PopulateListOfCountries(ref countryData); 
        }

        /// <summary>
        /// Displays the coordinates of the selected country.
        /// </summary>
        /// <param name="country"></param>
        private void DisplayCoordinates(int country)
        {
            lblLatitude.Text = countryData[country, 1];
            lblLongitude.Text = countryData[country, 2];

            //This will be un-commented in the extra credit assignment
            //DialogResult result =
                //MessageBox.Show($"Would you like to view {lstCountries.SelectedItem} in your web browser?",
                    //"View in web browser?", MessageBoxButtons.YesNo);
            //if (result == DialogResult.Yes)
           // {
               // string indexCoordinates = countryData[lstCountries.SelectedIndex, 1] + "," +
                                         // countryData[lstCountries.SelectedIndex, 2];
               //string uriAsString = "https://google.com/maps/search/?api=1&query=" + indexCoordinates;
               //Process.Start(uriAsString);
         //}
        }

        /// <summary>
        /// Handles the user input in the textbox.
        /// </summary>
        /// <param name="inputtedCountry"></param>
        void ProcessCountryInput(string inputtedCountry)
        {
            ClearOutputtedData();
            
            for (int row = 0; row < countryData.GetLength(0); row++)
            {
                if (countryData[row,0].ToLower().Contains(inputtedCountry.ToLower()))
                {
                    ShouldDisplayCoordinates = false;
                    lstCountries.SelectedIndex = row; //Disables DisplayCoordinates so this can process without showing them
                    ShouldDisplayCoordinates = true;
                    DialogResult result = MessageBox.Show("Is this the country you want?", "Correct country?", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        DisplayCoordinates(row);
                        return;
                    }

                    if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                    

                }

            }
            MessageBox.Show("Sorry, your requested country was not found.", "Country not found");
        }
        /// <summary>
        /// Processes the country input when enter is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountryData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter && txtCountryInput.Text != "")
            {
                ProcessCountryInput(txtCountryInput.Text);
            }
        }
        /// <summary>
        /// Processes the country input when the search button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)

        {
            ProcessCountryInput(txtCountryInput.Text);
        }
        /// <summary>
        /// Resets the outputted data.
        /// </summary>
        void ClearOutputtedData()
        {
            lstCountries.SelectedIndex = -1;

            lblLatitude.Text = "";
            lblLongitude.Text = "";
        }
        /// <summary>
        /// Shows the coordinates when a country item is double-clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstCountries_DoubleClick(object sender, EventArgs e)
        {
            if (ShouldDisplayCoordinates && lstCountries.SelectedIndex != -1)
            {
                DisplayCoordinates(lstCountries.SelectedIndex);
            }
        }
        /// <summary>
        /// Resets data when user enters the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCountryInput_Enter(object sender, EventArgs e)
        {
            txtCountryInput.Text = "";

            ClearOutputtedData();
        }
    }
}