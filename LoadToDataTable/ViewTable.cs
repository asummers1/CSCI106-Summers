using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoadToDataTable.Data;

namespace LoadToDataTable
{
    /*
     * Programmed by Rick Miller
    * (relayed through VoiceThread videos)
    * and Alexander Summers
     *
     * Allows user to view data relating to Lego Star Wars sets, as well as Marvel and DC characters
     *
     * 4-28-2020
     *
     */
    public partial class ViewTable : Form
    {
        //Global variables
        
        DataSet allData = new DataSet("All Data Sets:");

        private string currentTable;
        public ViewTable()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Creates an empty datatable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private DataTable CreateTable<T>()
        {
            DataTable genericDataTable = new DataTable();

            foreach (PropertyInfo propertyData in typeof(T).GetProperties())
            {
                genericDataTable.Columns.Add(propertyData.Name, propertyData.PropertyType);
            }

            return genericDataTable;
        }
        /// <summary>
        /// Loads the datatable
        /// </summary>
        /// <typeparam name="TListType"></typeparam>
        /// <param name="tableToLoad"></param>
        /// <param name="fileToLoad"></param>
        private void LoadTable<TListType>(DataTable tableToLoad, string fileToLoad) where TListType : IMediaContent, new()
        {

            using (StreamReader inputFile = new StreamReader(@"Data\" + fileToLoad))
            {
                inputFile.ReadLine(); //Reads header

                while (!inputFile.EndOfStream)
                {
                    TListType newItem = new TListType();
                    newItem.LoadRecord(inputFile.ReadLine());

                    tableToLoad.Rows.Add(newItem.FillDataRow(tableToLoad.NewRow()));

                }
            }

                
        }
        /// <summary>
        /// Initializes the data grid view of the selected type
        /// </summary>
        /// <typeparam name="Type"></typeparam>
        /// <param name="fileToLoad"></param>
        private void InitializeDataGridView<Type>(string fileToLoad) where Type: IMediaContent, new()
        {
            Type dataType = new Type();

            DataTable dataTable = CreateTable<Type>();
            

            dataTable.TableName = dataType.TypeToString();

            LoadTable<Type>(dataTable, fileToLoad);

            cbxDataTables.Items.Add(dataTable.TableName);

            allData.Tables.Add(dataTable);
        }

        /// <summary>
        /// Handles the changing of data sources
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxDataTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clears the dataGridView
            dgvInformation.DataSource = allData.Tables[cbxDataTables.SelectedItem.ToString()];

            currentTable = cbxDataTables.SelectedItem.ToString();
        }
        /// <summary>
        /// Prepares to show information based on double-clicked character
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInformation_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Which row?
            int rowIndex = dgvInformation.CurrentCell.RowIndex;

            //Extract row DataGridViewRow --> DataRowView --> DataRow
            DataGridViewRow rowClicked = dgvInformation.Rows[rowIndex];

            DataRowView rowView = (DataRowView) rowClicked.DataBoundItem;

            DataRow rowToDisplay = rowView.Row;

            switch (currentTable)
            {
                case "Lego Set":
                    LegoSetDisplay showLegoSet = new LegoSetDisplay(rowToDisplay);
                    showLegoSet.Show();
                    break;
                case "Marvel Characters":
                case "DC Characters":
                CharacterData showCharacterData = new CharacterData(rowToDisplay, currentTable);
                showCharacterData.Show();
                break;
            }
        }
        /// <summary>
        /// Sets values upon form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewTable_Load(object sender, EventArgs e)
        {
            //Makes datagridview load faster. Property is hidden by default, so we use reflection
            PropertyInfo doubleBuffer = dgvInformation.GetType()
                .GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            doubleBuffer.SetValue(dgvInformation, true, null);


            InitializeDataGridView<LegoSet>("LegoStarWars.csv");
            InitializeDataGridView<DC_Characters>("DC-Characters.csv");
            InitializeDataGridView<Marvel_Characters>("Marvel-Characters.csv");

            cbxDataTables.Enabled = true;
            cbxDataTables.SelectedIndex = 0;

            lblLoading.Text = Resources.LocalizableStrings.ENG_US.loadingDone;
        }
    }
}
