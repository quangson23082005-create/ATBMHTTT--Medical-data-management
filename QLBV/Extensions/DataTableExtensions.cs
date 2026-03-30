using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace QLBV
{
    public static class DataTableExtensions
    {
        // Extension method để chuyển IEnumerable<DataRow> thành DataTable, nếu null hoặc rỗng thì trả về DataTable trống
        public static DataTable CopyToDataTableOrEmpty(this IEnumerable<DataRow> rows)
        {
            if (rows == null) return new DataTable();
            var list = rows as IList<DataRow> ?? rows.ToList();
            if (!list.Any()) return new DataTable();


            var first = list[0];
            var result = first.Table.Clone(); 
            foreach (var r in list)
            {
                result.ImportRow(r);
            }
            return result;
        }
    }
}
