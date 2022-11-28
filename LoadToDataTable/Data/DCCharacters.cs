using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LoadToDataTable.Data
{
    class DC_Characters :  IMediaContent
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
        public void LoadRecord(string DCData)
        {
            string[] DCCharacterData = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))").Split(DCData);

            Page_Id =
                Int32.TryParse(DCCharacterData[0], out int result1) ? result1 : 0;
            Name = !string.IsNullOrEmpty(DCCharacterData[1])
                ? DCCharacterData[1]
                : "None"; //Number is a string because values can contain letters 
            Urlslug = (!string.IsNullOrEmpty(DCCharacterData[2])
                ? new Uri("http://dc.fandom.com/" + DCCharacterData[2].TrimStart('\\'))
                : new Uri("https://www.google.com/search?tbm=isch&q=" + Name));
            ID = DCCharacterData[3];
            Align = DCCharacterData[4];
            Eye = (!string.IsNullOrEmpty(DCCharacterData[5]) ? DCCharacterData[5] : "None");
            Hair = (!string.IsNullOrEmpty(DCCharacterData[6]) ? DCCharacterData[6] : "None");
            Sex = (!string.IsNullOrEmpty(DCCharacterData[7]))
                ? DCCharacterData[7]
                : "None";
            IsAlive = (DCCharacterData[8] == "Living Characters");
            Appearances =
                Int32.TryParse(DCCharacterData[9], out int result4) ? result4 : 0;

            //Parses FirstAppearance
            if (!string.IsNullOrEmpty(DCCharacterData[10])) 
            {
                if (DCCharacterData[10].Contains(','))
                {
                    string[] dateFlip = DCCharacterData[10].Split(','); //Flips so date isn't in year/month format

                    //Standard swap algorithm
                    string temp = dateFlip[1];
                    dateFlip[1] = dateFlip[0];
                    dateFlip[0] = temp;

                    FirstAppearance = dateFlip[0].TrimEnd('"') + ' ' + dateFlip[1].TrimStart('"');
                }
                else //DCCharacterData[10] just has the year
                {
                    FirstAppearance = DCCharacterData[10];
                }
            }
            else
            {
                FirstAppearance = "No appearances";
            }

            Year = (!string.IsNullOrEmpty(DCCharacterData[11]))
                ? Convert.ToInt32(DCCharacterData[11])
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
            return "DC Characters";
        }

        
    }
}
