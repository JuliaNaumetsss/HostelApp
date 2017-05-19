using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;

namespace HostelApplication.ReportGenerator
{
    public class WordFileCreator
    {
        public void ExportToWord(DataGridView dgv)
        {
            word.Application word = null;
            word.Document doc = null;
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";
            try
            {
                word = new word.Application();
                word.Visible = true;
                doc = word.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            if (word != null && doc != null)
            {
                word.Table newTable;
                word.Range wrdRng = doc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                newTable = doc.Tables.Add(wrdRng, 1, dgv.Columns.Count, ref oMissing, ref oMissing);
                newTable.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
                newTable.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
                newTable.AllowAutoFit = true;

                foreach (DataGridViewCell cell in dgv.Rows[0].Cells)
                {
                    newTable.Cell(newTable.Rows.Count, cell.ColumnIndex + 1).Range.Text = dgv.Columns[cell.ColumnIndex].HeaderText;
                    newTable.Cell(newTable.Rows.Count, cell.ColumnIndex + 1).Range.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray05;
                }
                newTable.Rows.Add();

                int count = 1;
                foreach (DataGridViewRow row in dgv.Rows)
                {

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        newTable.Cell(newTable.Rows.Count, cell.ColumnIndex + 1).Range.Text = cell.Value.ToString();
                        newTable.Cell(newTable.Rows.Count, cell.ColumnIndex + 1).Range.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorWhite;
                    }
                    newTable.Rows.Add();
                    count++;
                    if (count == dgv.Rows.Count)
                        break;
                }
            }
        }
    }
}

