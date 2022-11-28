using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LoadToDataTable
{
    public partial class LegoSetDisplay : Form
    {
        /* Programmed by Rick Miller
         * (relayed through VoiceThread videos)
         * and Alexander Summers
         * 
         *Allows user to view data relating to a particular Lego Star Wars set.
         *
         * 4-28-2020
         */

        //Global
        private DataRow displayRow;

        private string setURL;
        /// <summary>
        /// LegoSetDisplay constructor. I made it private because I want
        /// programmers to use the other one
        /// </summary>
        private LegoSetDisplay()
        {
            InitializeComponent();
        }
        /// <summary>
        /// LegoSetDisplay form constructor
        /// </summary>
        /// <param name="rowToDisplay"></param>
        public LegoSetDisplay(DataRow rowToDisplay)
        {
            displayRow = rowToDisplay;

            InitializeComponent();
        }
        /// <summary>
        /// Sets data for LegoSetDisplay form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LegoSetDisplay_Load(object sender, EventArgs e)
        {
            chkOwned.ForeColor = Color.White;
            lblSetID.Text = displayRow.ItemArray[0].ToString();
            lblNumber.Text = displayRow.ItemArray[1].ToString();
            lblVariant.Text = displayRow.ItemArray[2].ToString();
            lblTheme.Text = displayRow.ItemArray[3].ToString();
            lblSubtheme.Text = displayRow.ItemArray[4].ToString();
            lblYear.Text = displayRow.ItemArray[5].ToString();
            lblName.Text = displayRow.ItemArray[6].ToString();
            lblMinifigures.Text = displayRow.ItemArray[7].ToString();
            lblPieces.Text = displayRow.ItemArray[8].ToString();
            lblUKPrice.Text = "\u00A3 " + string.Format("{0:N2}", displayRow.ItemArray[9]);
            lblUSPrice.Text = "$ " + string.Format("{0:N2}", displayRow.ItemArray[10]);
            lblEUPrice.Text = "$ " + string.Format("{0:N2}", displayRow.ItemArray[11]);
            lblCAPrice.Text = "\u20AC " + string.Format("{0:N2}", displayRow.ItemArray[12]);
            
            //Image URL
            setURL = displayRow.ItemArray[13].ToString();

            SetCheckBox(displayRow.ItemArray[14].ToString(), chkOwned);
            SetCheckBox(displayRow.ItemArray[15].ToString(), chkWanted);

            lblQtyOwned.Text = displayRow.ItemArray[16].ToString();
        }
        /// <summary>
        /// Sets the desired checkbox
        /// </summary>
        /// <param name="value"></param>
        /// <param name="checkBoxToSet"></param>
        private void SetCheckBox(string value, CheckBox checkBoxToSet)
        {
            checkBoxToSet.Checked = (value == "true") ? true : false;
        }

        /// <summary>
        /// Processes mouse down input while clicking to display set
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void pbxDisplaySet_MouseDown(object sender, MouseEventArgs e)
        {
            pbxDisplaySet.Size = new Size(pbxDisplaySet.Size.Width - 3, pbxDisplaySet.Size.Height - 3);
        }

        /// <summary>
        /// Processes mouse up input while clicking to display set
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxDisplaySet_MouseUp(object sender, MouseEventArgs e)
        {
            Process.Start(setURL);
            pbxDisplaySet.Size = new Size(pbxDisplaySet.Size.Width + 3, pbxDisplaySet.Size.Height + 3);
        }
    }
}
