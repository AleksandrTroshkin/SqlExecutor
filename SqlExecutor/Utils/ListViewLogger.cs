using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SqlExecutor.Utils
{
    public class ListViewLogger
    {
        private readonly ListView List;

        public ListViewLogger(ListView list)
        {
            List = list;
        }

        public int New(string path, string filename)
        {
            if (List.InvokeRequired)
                return (int)List.Invoke(new ListInsert(New), path, filename);

            if (List.Columns.Count == 0)
            {
                List.Columns.Add("Path");
                List.Columns.Add("Filename");
                List.Columns.Add("Status");
            }

            var item = new ListViewItem(new[] { path, filename, string.Empty }); // string.Empty for Status
            List.Items.Add(item);

            return List.Items.IndexOf(item);
        }

        public void Success(int index)
        {
            if (List.InvokeRequired)
            {
                List.Invoke(new ListSuccess(Success), index);
                return;
            }
            var pos = List.Items[index].SubItems.Count - 1;
            List.Items[index].UseItemStyleForSubItems = true;
            List.Items[index].SubItems[pos].ForeColor = System.Drawing.Color.Black;
            List.Items[index].SubItems[pos].Text = "Success";
        }

        public void Fail(int index, string error)
        {
            if (List.InvokeRequired)
            {
                List.Invoke(new ListFail(Fail), index, error);
                return;
            }
            var pos = List.Items[index].SubItems.Count - 1;
            List.Items[index].UseItemStyleForSubItems = false;
            List.Items[index].SubItems[pos].ForeColor = System.Drawing.Color.Red;
            List.Items[index].SubItems[pos].Text = error;
        }

        delegate int ListInsert(string path, string filename);
        delegate void ListSuccess(int index);
        delegate void ListFail(int index, string error);
    }
}
