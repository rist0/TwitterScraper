using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitterScraper
{
    public static class Filters
    {
        public static DataGridView FilterTweets(DataGridView gridIn, bool more, int count)
        {
            for(int i = 0; i < gridIn.Rows.Count; i++)
            {
                if (more)
                {
                    if (int.TryParse(gridIn.Rows[i].Cells[2].Value.ToString(), out int result) && Convert.ToInt32(gridIn.Rows[i].Cells[2].Value) < count)
                    {
                        gridIn.Rows.RemoveAt(i--);
                    }
                }
                else
                {
                    if (int.TryParse(gridIn.Rows[i].Cells[2].Value.ToString(), out int result) && Convert.ToInt32(gridIn.Rows[i].Cells[2].Value) > count)
                    {
                        gridIn.Rows.RemoveAt(i--);
                    }
                }
            }
            return gridIn;
        }

        public static DataGridView FilterFollowings(DataGridView gridIn, bool more, int count)
        {
            for (int i = 0; i < gridIn.Rows.Count; i++)
            {
                if (more)
                {
                    if (int.TryParse(gridIn.Rows[i].Cells[3].Value.ToString(), out int result) && Convert.ToInt32(gridIn.Rows[i].Cells[3].Value) < count)
                    {
                        gridIn.Rows.RemoveAt(i--);
                    }
                }
                else
                {
                    if (int.TryParse(gridIn.Rows[i].Cells[3].Value.ToString(), out int result) && Convert.ToInt32(gridIn.Rows[i].Cells[3].Value) > count)
                    {
                        gridIn.Rows.RemoveAt(i--);
                    }
                }
            }
            return gridIn;
        }

        public static DataGridView FilterFollowers(DataGridView gridIn, bool more, int count)
        {
            for (int i = 0; i < gridIn.Rows.Count; i++)
            {
                if (more)
                {
                    if (int.TryParse(gridIn.Rows[i].Cells[4].Value.ToString(), out int result) && Convert.ToInt32(gridIn.Rows[i].Cells[4].Value) < count)
                    {
                        gridIn.Rows.RemoveAt(i--);
                    }
                }
                else
                {
                    if (int.TryParse(gridIn.Rows[i].Cells[4].Value.ToString(), out int result) && Convert.ToInt32(gridIn.Rows[i].Cells[4].Value) > count)
                    {
                        gridIn.Rows.RemoveAt(i--);
                    }
                }
            }
            return gridIn;
        }

        public static DataGridView FilterLikes(DataGridView gridIn, bool more, int count)
        {
            for (int i = 0; i < gridIn.Rows.Count; i++)
            {
                if (more)
                {
                    if (int.TryParse(gridIn.Rows[i].Cells[5].Value.ToString(), out int result) && Convert.ToInt32(gridIn.Rows[i].Cells[5].Value) < count)
                    {
                        gridIn.Rows.RemoveAt(i--);
                    }
                }
                else
                {
                    if (int.TryParse(gridIn.Rows[i].Cells[5].Value.ToString(), out int result) && Convert.ToInt32(gridIn.Rows[i].Cells[5].Value) > count)
                    {
                        gridIn.Rows.RemoveAt(i--);
                    }
                }
            }
            return gridIn;
        }

        public static DataGridView FilterWebsite(DataGridView gridIn, bool hasWebsite, bool contains, string searchPattern)
        {
            for (int i = 0; i < gridIn.Rows.Count; i++)
            {
                if (hasWebsite)
                {
                    
                }
                else
                {
                    
                }
            }
            return gridIn;
        }
    }
}
