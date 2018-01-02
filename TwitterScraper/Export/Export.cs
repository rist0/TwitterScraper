using System.IO;
using System.Windows.Forms;

namespace TwitterScraper.Export
{
    public class Export
    {
        public DataGridView GridIn { get; set; }
        public string SavePath { get; set; }
        public string FileName { get; set; }
        public string Delimiter { get; set; }

        private void WriteCsv(bool selected = false)
        {
            if (GridIn.RowCount > 0)
            {
                string value = "";
                DataGridViewRow row = new DataGridViewRow();
                StreamWriter swOut = new StreamWriter(SavePath + "\\" + FileName + ".csv");

                for (int i = 0; i < GridIn.Columns.Count; i++)
                {
                    if (i > 0)
                    {
                        swOut.Write(Delimiter);
                    }
                    swOut.Write("\"" + GridIn.Columns[i].HeaderText + "\"");
                }

                swOut.WriteLine();

                for (int i = 0; i < GridIn.Rows.Count; i++)
                {
                    row = GridIn.Rows[i];

                    if (i > 0)
                    {
                        if (!selected)
                        {
                            swOut.WriteLine();
                        }
                    }

                    for (int j = 0; j < GridIn.Columns.Count; j++)
                    {
                        if (j > 0 && !selected)
                        {
                            swOut.Write(Delimiter);
                        }

                        if (selected && row.Selected && j > 0)
                        {
                            swOut.Write(Delimiter);
                        }

                        if(!selected)
                        {
                            value = row.Cells[j].Value.ToString();
                            swOut.Write("\"" + value + "\"");
                        }
                        else
                        {
                            if(row.Selected)
                            {
                                value = row.Cells[j].Value.ToString();
                                swOut.Write("\"" + value + "\"");
                            }
                        }
                    }

                    if (selected & row.Selected)
                    {
                        swOut.WriteLine();
                    }

                }

                //swOut.Close();
                swOut.Dispose();
            }
        }

        public void ExportAllData()
        {
            WriteCsv();
        }

        public void ExportSelectedRows()
        {
            WriteCsv(true);
        }
    }
}
