using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Windows.Forms;
using System.Web;
using System.Reflection;


namespace XMLEditer
{
    class ExportToExcel
    {
        public static bool CreateAdvExcel(string path, IList<Ticket> lt)
        {
            try
            {
                StringBuilder builder = new StringBuilder();
                Random rn = new Random();
                string name = rn.Next(9999) + ".xls";
                System.Reflection.PropertyInfo[] myPropertyInfo = lt.First().GetType().GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
                int i = 0, j;
                for (i = 0, j = myPropertyInfo.Length; i < j; i++)
                {
                    System.Reflection.PropertyInfo pi = myPropertyInfo[i];
                    string headname = pi.Name;//单元格头部
                    builder.Append(headname);
                    builder.Append("\t");
                }
                builder.Append("\n");
                foreach (Ticket t in lt)
                {
                    if (lt == null)
                    {
                        continue;
                    }
                    for (i = 0, j = myPropertyInfo.Length; i < j; i++)
                    {
                        System.Reflection.PropertyInfo pi = myPropertyInfo[i];
                        string str = string.Format("{0}", pi.GetValue(t, null)).Replace("\n", "");
                        if (str == "")
                        {
                            builder.Append("\t");
                        }
                        else
                        {
                            builder.Append(str + "\t");//横向跳到另一个单元格
                        }
                    }
                    builder.Append("\n");//换行
                }
                StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.GetEncoding("GB2312"));
                sw.Write(builder.ToString());//输出
                sw.Flush();
                sw.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
