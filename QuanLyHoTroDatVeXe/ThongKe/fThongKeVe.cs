using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace ThongKe
{
    public partial class fThongKeVe : Form
    {
        public SqlConnection connection;
        public fThongKeVe()
        {
            InitializeComponent();
            
            loadCboBienSo();
        }

        private void fThongKeVe_Load(object sender, EventArgs e)
        {
            
        }
       
        void loadCboBienSo()
        {
            List<Xe> dsBienSo = XeDAO.Instance.LayDsXe();
            cbBienSo.DataSource = dsBienSo;
            cbBienSo.DisplayMember = "bienSo";
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btThongKe_Click_1(object sender, EventArgs e)
        {
            ThongKeVe rpt = new ThongKeVe();

            rpt.SetDatabaseLogon("sa", "sa2012", "DESKTOP-1N4F6N4", "QuanLyBanVeXeKhach");
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            cbBienSo.ValueMember = "bienSo";
            rpt.SetParameterValue("LocBienSo", cbBienSo.SelectedValue.ToString());
        }
    }
}
