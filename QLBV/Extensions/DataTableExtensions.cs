using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace QLBV
{
    public static class DataTableExtensions
    {
        public static DataTable CopyToDataTableOrEmpty(this IEnumerable<DataRow> rows)
        {
            if (rows == null) return new DataTable();
            var list = rows as IList<DataRow> ?? rows.ToList();
            if (!list.Any()) return new DataTable();

            // Manually build a new DataTable from the rows to avoid requiring
            // a reference to System.Data.DataSetExtensions assembly.
            var first = list[0];
            var result = first.Table.Clone(); // clone schema
            foreach (var r in list)
            {
                result.ImportRow(r);
            }
            return result;
        }
    }
}
