using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoadToDataTable.Data;

namespace LoadToDataTable
{

    /* Alexander Summers
     * Allows user to access data relating to Marvel or DC characters. UI design changes slightly based on the company
     * 4-28-2020
     */
    public partial class CharacterData : Form
    {
        private DataRow displayRow;
        private string URL;

        /// <summary>
        /// LegoSetDisplay constructor. I made it private because I want
        /// programmers to use the other one
        /// </summary>
        private CharacterData()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructs CharacterData form
        /// </summary>
        /// <param name="dataRow"></param>
        /// <param name="dataType"></param>
        public CharacterData(DataRow dataRow, string dataType) //Since the type is only used for comparison,
        {                                     //I feel it to be cleaner to just check against a string
            InitializeComponent();

            displayRow = dataRow;

            switch (dataType)
            {
                case "Marvel Characters":
                    pbxLogo.Image = global::LoadToDataTable.Properties.Resources.MarvelLogo;
                    BackColor = Color.Red;
                    break;
                case "DC Characters":
                    pbxLogo.Image = global::LoadToDataTable.Properties.Resources.DCLogo;
                    BackColor = Color.Blue;
                    break;
            }
            
        }
        /// <summary>
        /// Loads resources for CharacterData form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CharacterData_Load(object sender, EventArgs e)
        {
            lblPage_ID.Text = displayRow.ItemArray[0].ToString(); 
            lblName.Text = displayRow.ItemArray[1].ToString();
            URL = displayRow.ItemArray[2].ToString(); //Image URL
            lblID.Text = displayRow.ItemArray[3].ToString();
            lblAlign.Text = displayRow.ItemArray[4].ToString();
            lblEye.Text = displayRow.ItemArray[5].ToString();
            lblHair.Text = displayRow.ItemArray[6].ToString();
            lblSex.Text = displayRow.ItemArray[7].ToString();
            chkAlive.Checked = Convert.ToBoolean(displayRow.ItemArray[8]);
            lblAppearance.Text = displayRow.ItemArray[9].ToString();
            lblFirstAppearance.Text = displayRow.ItemArray[10].ToString();
            lblYear.Text = displayRow.ItemArray[11].ToString();
        }

        /// <summary>
        /// Processes mouse down input while clicking to display set
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void pbxDisplayCharacterData_MouseDown(object sender, MouseEventArgs e)
        {
            pbxDisplayCharacterData.Size = new Size(pbxDisplayCharacterData.Size.Width - 3, pbxDisplayCharacterData.Size.Height - 3);
        }

        /// <summary>
        /// Processes mouse up input while clicking to display set
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxDisplayCharacterData_MouseUp(object sender, MouseEventArgs e)
        {
            Process.Start(URL);

            pbxDisplayCharacterData.Size = new Size(pbxDisplayCharacterData.Size.Width + 3, pbxDisplayCharacterData.Size.Height + 3);
        }
    }
}
