﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanLyKhachSan.module;

namespace quanLyKhachSan.view
{
    public partial class Home : Form
    {
        private int type, id_nvien;
        private string t_nv;
        public Home()
        {
            InitializeComponent();
        }

        public void getType(string h_ten, int User_type, int id_nvien)
        {
            //this.t_nv = h_ten;
            //this.type = User_type;
            //this.id_nvien = id_nvien;
            //hoten.Text = "Nhân viên: " + h_ten;
            //DateTime dt = DateTime.Now;
            //ngayThang.Text = "Hôm nay: "+ dt.ToString("dd/M/yyyy");
            //if (this.type != 1)
            //{
            //    //quanly.Enabled = false;
            //    //thongke.Enabled = false;
            //    //datphong1.setOption(1, this.id_nvien, h_ten);
            //    //datphong1.Visible = true;
            //    //nhanvien1.Visible = false;
            //    //lichsu1.Visible = false;
            //    //phong1.Visible = false;
            //    //thong_tin1.Visible = false;
            //}
            //else
            //{
            //    datphong1.Visible = false;
            //    nhanvien1.Visible = false;
            //    lichsu1.Visible = false;
            //    phong1.Visible = true;
            //    thong_tin1.Visible = false;
            //}
        }

        private void Home_Load(object sender, EventArgs e)
        {
           
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //datphong1.Visible = false;
            //nhanvien1.Visible = true;
            //lichsu1.Visible = false;
            //phong1.Visible = false;
            //thong_tin1.Visible = false;
            ////xl nhan vien


        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //datphong1.Visible = false;
            //nhanvien1.Visible = false;
            //lichsu1.Visible = false;
            //phong1.Visible = true;
            //thong_tin1.Visible = false;
        }

        private void lịchSửToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //datphong1.Visible = false;
            //nhanvien1.Visible = false;
            //lichsu1.Visible = true;
            //phong1.Visible = false;
            //thong_tin1.Visible = false;
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //datphong1.Visible = false;
            //nhanvien1.Visible = false;
            //lichsu1.Visible = false;
            //phong1.Visible = false;
            //thong_tin1.Visible = true;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
            if(dl == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btDatPhon_Click(object sender, EventArgs e)
        {

        }

        public void getStatus(int a)
        {
            MessageBox.Show("Home: "+a.ToString());
        }
    }
}
