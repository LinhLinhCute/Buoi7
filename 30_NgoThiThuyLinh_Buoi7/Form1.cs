using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_NgoThiThuyLinh_Buoi7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> sinhvien = new List<string>()
        {
            "Ngo Thi Thuy Linh"
        };
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Vui long nhap");
            else
                this.errorProvider1.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (sinhvien.Contains(textBox1.Text))
            {
                MessageBox.Show("Da co sinh vien nay trong list!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                sinhvien.Add(textBox1.Text);
                MessageBox.Show("Them thanh cong list ne!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (sinhvien.Contains(textBox1.Text))
            {
                MessageBox.Show("Sinh vien nay co trong list!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Chu co sinh vien nay trong list!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban co muon thoat!", "Cảnh báo",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
