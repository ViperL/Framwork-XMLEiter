using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml.Linq;

namespace XMLEditer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreat_Click(object sender, EventArgs e)
        {
            XMLHelper.CreateXmlFile();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Ticket Obj = new Ticket(Convert.ToInt32(txtID.Text), Convert.ToDouble(txtTotal.Text),Convert.ToDateTime(DTPDay.Text));
            XMLHelper.Insert(Obj);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            XMLHelper.Del(1);
            XMLHelper.Del(2);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            List<Ticket> List = XMLHelper.ReSearch(0);
            IList<Ticket> list = new List<Ticket>();
            DataView.DataSource = new BindingList<Ticket>(List);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Ticket Obj = new Ticket(Convert.ToInt32(txtID.Text), Convert.ToDouble(txtTotal.Text), Convert.ToDateTime(DTPDay.Text));
            XMLHelper.Change(Convert.ToInt32(txtID.Text), Obj);
        }

        private void DataView_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = DataView.CurrentRow.Cells[0].Value.ToString();
            txtTotal.Text = DataView.CurrentRow.Cells[1].Value.ToString();
            DTPDayRe.Text = DataView.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            //添加Excel引用
            List<Ticket> List = XMLHelper.ReSearch(0);
            SaveFileDialog File = new SaveFileDialog();
            File.Filter= "Excel文件|*.xls|全部文件 (*.*)|*.*";
            File.ShowDialog();
            if (ExportToExcel.CreateAdvExcel(File.FileName, List) == true)
                MessageBox.Show("文件路径为：" + File.FileName, "导出成功");
            else
                MessageBox.Show("导出失败，请检查后重试");
        }

        private void btnSreach_Click(object sender, EventArgs e)
        {
            List<Ticket> List;
            if (txtSreachId.Text != string.Empty)
            {
                List = XMLHelper.ReSearch(Convert.ToInt16(txtSreachId.Text));
            }
            else
            {
                List = XMLHelper.ReSearch(Convert.ToDateTime(DTPDayRe.Text));
            }
            IList<Ticket> list = new List<Ticket>();
            DataView.DataSource = new BindingList<Ticket>(List);
        }
    }
}
