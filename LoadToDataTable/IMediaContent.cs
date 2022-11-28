using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LoadToDataTable
{
    interface IMediaContent
    {
        void LoadRecord(string input);
        DataRow FillDataRow(DataRow rowToFill);

        string TypeToString();
    }
}
