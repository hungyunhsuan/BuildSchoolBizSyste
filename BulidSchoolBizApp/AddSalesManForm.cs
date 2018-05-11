using BulidSchoolBizApp.Services;
using BulidSchoolBizApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulidSchoolBizApp
{
    public partial class AddSalesManForm : Form
    {
        public AddSalesManForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("銷售人員姓名不可為空白");
            }
            else
            {
                SalesManViewModel viewModel = new SalesManViewModel();
                viewModel.Name = textBox1.Text;
                SalesManService service = new SalesManService();
                if (service.IsNameExist(viewModel))
                {
                    MessageBox.Show("這個姓名已存在");
                }
                else
                {
                    var result = service.Create(viewModel);
                    if (result.IsSuccessful)
                    {
                        MessageBox.Show("銷售人員加入成功");
                    }
                    else
                    {
                        var path = result.WriteLog();
                        MessageBox.Show($"發生錯誤，請參考 {path}");
                    }
                }
            }
        }
    }
}
