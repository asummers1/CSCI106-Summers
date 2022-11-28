using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LoadToDataTable.Data
{
    class LegoSet :  IMediaContent
    {
        public int SetId { get; set; }
        public string Number { get; set; } //Some numbers include letters, so I put it in a string.
        public int Variant { get; set; }
        public string Theme { get; set; }
        public string Subtheme { get; set; }

        public int Year { get; set; }

        public string Name { get; set; }

        public int Minifigs { get; set; }

        public int Pieces { get; set; }

        public decimal UKPrice { get; set; }

        public decimal USPrice { get; set; }

        public decimal EUPrice { get; set; }

        public decimal CAPrice { get; set; }

        public Uri ImageURI { get; set; }

        public bool IsOwned { get; set; }

        public bool IsWanted { get; set; }

        public int QtyOwned { get; set; }

        public LegoSet() { }

        /// <summary>
        /// Parses a string as a data record
        /// </summary>
        /// <param name="LegoSet"></param>
        public void LoadRecord(string legoSet)
        {
            Regex CSVParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");

            string[] stringListOfLegoSets = CSVParser.Split(legoSet);


            SetId =
                Int32.TryParse(stringListOfLegoSets[0], out int result1) ? result1 : 0;
            Number = (!string.IsNullOrEmpty(stringListOfLegoSets[1])
                ? stringListOfLegoSets[1]
                : "None"); //Number is a string because values can contain letters 
            Variant =
                Int32.TryParse(stringListOfLegoSets[2], out int result2) ? result2 : 0;
            Theme = stringListOfLegoSets[3];
            Subtheme = stringListOfLegoSets[4];
            Year = Int32.TryParse(stringListOfLegoSets[5], out int result3) ? result3 : 0;
            Name = (!string.IsNullOrEmpty(stringListOfLegoSets[6]))
                ? stringListOfLegoSets[6]
                : "None";
            Minifigs = (!string.IsNullOrEmpty(stringListOfLegoSets[7]))
                ? Convert.ToInt32(stringListOfLegoSets[7])
                : 0;
            Pieces =
                Int32.TryParse(stringListOfLegoSets[8], out int result4) ? result4 : 0;
            UKPrice = (!string.IsNullOrEmpty(stringListOfLegoSets[9]))
                ? Convert.ToDecimal(stringListOfLegoSets[9])
                : 0.00M;
            USPrice = (!string.IsNullOrEmpty(stringListOfLegoSets[10]))
                ? Convert.ToDecimal(stringListOfLegoSets[10])
                : 0.00M;
            CAPrice = (!string.IsNullOrEmpty(stringListOfLegoSets[11]))
                ? Convert.ToDecimal(stringListOfLegoSets[11])
                : 0.00M;
            EUPrice = (!string.IsNullOrEmpty(stringListOfLegoSets[12]))
                ? Convert.ToDecimal(stringListOfLegoSets[12])
                : 0.00M;
            ImageURI = (!string.IsNullOrEmpty(stringListOfLegoSets[13])
                    ? new Uri(stringListOfLegoSets[13])
                    : new Uri("https://www.google.com/search?tbm=isch&q=" + Name)
                ); //If there is no image URL, make one

            IsOwned = (stringListOfLegoSets[14] == "yes");
            IsWanted = (stringListOfLegoSets[15] == "yes");

            QtyOwned =
                Int32.TryParse(stringListOfLegoSets[16], out int result5) ? result5 : 0;
        }
        public DataRow FillDataRow(DataRow rowToFill)
        {
            rowToFill["SetId"] = SetId;
            rowToFill["Number"] = Number;
            rowToFill["Variant"] = Variant;
            rowToFill["Theme"] = Theme;
            rowToFill["Subtheme"] = Subtheme;
            rowToFill["Year"] = Year;
            rowToFill["Name"] = Name;
            rowToFill["Minifigs"] = Minifigs;
            rowToFill["Pieces"] = Pieces;
            rowToFill["UKPrice"] = UKPrice;
            rowToFill["USPrice"] = USPrice;
            rowToFill["CAPrice"] = CAPrice;
            rowToFill["EUPrice"] = EUPrice;
            rowToFill["ImageURI"] = ImageURI;
            rowToFill["IsOwned"] = IsOwned;
            rowToFill["IsWanted"] = IsWanted;
            rowToFill["QtyOwned"] = QtyOwned;

            return rowToFill;
        }

        public string TypeToString()
        {
            return "Lego Set";
        }
    }
}
