using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Data;

namespace MVC4Razor.Areas.UIConfig.Model
{
    public class ConfigModel
    {
        

        public Dictionary<string, List<string>> GetExcel(string path)
        {
             OleDbConnection oledbConn = null;
             Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();
             
             try
             {
            
                if (Path.GetExtension(path) == ".xls")
                {
                    oledbConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=\"Excel                            8.0;HDR=Yes;IMEX=2\"");
                }
                else if (Path.GetExtension(path) == ".xlsx")
                {
                    oledbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
                    Data Source=" + path + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';");
                }
                oledbConn.Open();
                OleDbCommand cmd = new OleDbCommand(); ;
             
                DataSet ds = new DataSet();

                cmd.Connection = oledbConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [Sheet1$]";
                OleDbDataAdapter oleda = new OleDbDataAdapter(cmd.CommandText,oledbConn);
                oleda.Fill(ds, "[Sheet1$]");

                DataTable dt = ds.Tables[0];
                
                int rowCount = dt.Columns.Count;
        
                foreach (DataRow row in dt.AsEnumerable())
                {
                    List<string> ColumnList = new List<string>();
                    for (int i = 1; i < rowCount; i++)
                    {
                        ColumnList.Add(row[i].ToString());
                    }
                    data.Add(row[0].ToString(), ColumnList);
                }

            }
        
        catch (Exception ex)
        {
           // lblError.Text = ex.ToString();
        }
        finally
        {
            oledbConn.Close();
        }

             return data;
        }
    }
}