using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LoadToDataTable.Data
{

    class Marvel_Characters : IMediaContent
    {

        public int Page_Id { get; set; }
        public string Name { get; set; }
        public Uri Urlslug { get; set; }

        public string ID { get; set; }
        public string Align { get; set; }
        public string Eye { get; set; }
        public string Hair { get; set; }
        public string Sex { get; set; }
        public bool IsAlive { get; set; }

        public int Appearances { get; set; }

        public string FirstAppearance { get; set; }
        public int Year { get; set; }

        public void LoadRecord(string MarvelData)
        {

            string[] MarvelCharacterData = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))").Split(MarvelData);

            Page_Id =
                Int32.TryParse(MarvelCharacterData[0], out int result1) ? result1 : 0;
            Name = !string.IsNullOrEmpty(MarvelCharacterData[1]) 
                ? MarvelCharacterData[1] 
                : "None"; //Number is a string because values can contain letters 
            Urlslug = (!string.IsNullOrEmpty(MarvelCharacterData[2])
                ? new Uri("http://marvel.fandom.com/" + MarvelCharacterData[2].Trim('\\'))
                : new Uri("https://www.google.com/search?tbm=isch&q=" + Name));
            ID = MarvelCharacterData[3];
            Align = (!string.IsNullOrEmpty(MarvelCharacterData[4]) ? MarvelCharacterData[4] : "None");
            Eye = (!string.IsNullOrEmpty(MarvelCharacterData[5]) ? MarvelCharacterData[5] : "None");
            Hair = (!string.IsNullOrEmpty(MarvelCharacterData[6]) ? MarvelCharacterData[6] : "None");
            Sex = (!string.IsNullOrEmpty(MarvelCharacterData[7]))
                ? MarvelCharacterData[7]
                : "None";
            IsAlive = (MarvelCharacterData[8] == "Living Characters");
            Appearances =
                Int32.TryParse(MarvelCharacterData[9], out int result4) ? result4 : 0;
            FirstAppearance = MarvelCharacterData[10];
            Year = (!string.IsNullOrEmpty(MarvelCharacterData[11]))
                ? Convert.ToInt32(MarvelCharacterData[11])
                : 0;
                
        }

        public DataRow FillDataRow(DataRow rowToFill)
        {
            rowToFill["Page_id"] = Page_Id;
            rowToFill["name"] = Name;
            rowToFill["urlslug"] = Urlslug;
            rowToFill["ID"] = ID;
            rowToFill["ALIGN"] = Align;
            rowToFill["Year"] = Year;
            rowToFill["Eye"] = Eye;
            rowToFill["Hair"] = Hair;
            rowToFill["Sex"] = Sex;
            rowToFill["IsAlive"] = IsAlive;
            rowToFill["Appearances"] = Appearances;
            rowToFill["FirstAppearance"] = FirstAppearance;
            rowToFill["Year"] = Year;

            return rowToFill;
        }

        public string TypeToString()
        {
            return "Marvel Characters";
        }
    }
}
