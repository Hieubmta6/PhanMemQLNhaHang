﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_TinhDinhLuong : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frm_TinhDinhLuong()
        {
            InitializeComponent();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {

        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
