﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GiaoDienCuaHang.Controller;

namespace GiaoDienCuaHang
{
    public partial class fKhachHang : Form
    {
        KhachHangContronller ctrl = new KhachHangContronller();
        public fKhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            ctrl.HienThi(textBox1, textBox2, textBox3, textBox4, dataGridView1, bindingNavigator1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ctrl.Update();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                IEnumerator ie = dataGridView1.SelectedRows.GetEnumerator();

                while (ie.MoveNext())
                {
                    DataGridViewRow row = (DataGridViewRow)ie.Current;
                    dataGridView1.Rows.Remove(row);
                }
            }
        }
        private void toolStripButtonLuu_Click(object sender, EventArgs e)
        {
            ctrl.Update();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmTimKiemKhachHang tkkh = new frmTimKiemKhachHang();
            tkkh.Show();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!textBox1.Text.Substring(0, 2).Equals("KH"))
            {
                MessageBox.Show("Mã Khách hàng bị sai. Phải nhập KH đầu!!!!!!!");
                e.Cancel = true;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void labelkhachhang_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxTT_Enter(object sender, EventArgs e)
        {

        }
    }
}