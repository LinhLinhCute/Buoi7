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
    public partial class Bai2_Trang41 : Form
    {
        int[] mang=new int[20];
        int n = 0;
        
        public Bai2_Trang41()
        {
            
            InitializeComponent();
        }

        private void txt_nhap_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Vui long nhap");
            else
                this.errorProvider1.Clear();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_nhap.Clear();
            txt_nhap.Focus();
            txt_KetQua.Clear();
            txt_AddGT.Clear();
            rdb_Giam.Checked = false;
            rdb_Tang.Checked = false;
            rdb_TimGiaTri.Checked = false;

        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            string ChuoiNhap = txt_nhap.Text;
            string[] tach = ChuoiNhap.Split(' ');
            int i=0;
            foreach (var so in tach)
            {
                mang[i] = int.Parse(so);
                i++;
            }
            n = i;
        }

        private void txt_KetQua_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void byn_ThucHien_Click(object sender, EventArgs e)
        {
            if (rdb_Tang.Checked)
            {
                
                Array.Sort(mang);
            }
            else 
            {
                Array.Sort(mang);
                Array.Reverse(mang);   
            }
            for (int i = mang.Length-n; i <mang.Length; i++)
            {
                txt_KetQua.Text += " "+ mang[i].ToString();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban co muon thoat!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}

