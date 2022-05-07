using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTeste
{
    public class LerCampos
    {
        static public DataRow Registro(string[] columns, DataTable datatable) {

            DataRow dataRow = datatable.NewRow();

            for (int i = 0; i < columns.Length - 2; i++)
            {
                dataRow[i] = columns[i + 1];
            }
            return dataRow;
        }
    }
}
