using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayCalc_Dashboard
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            pnlDashboard.Visible = true;
            pnlEmployees.Visible = false;

            btnEmployees.BackColor = Color.FromArgb(249, 249, 249);
            btnHistory.BackColor = Color.FromArgb(249, 249, 249);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlDashboard.Visible = true;
            pnlEmployees.Visible = false;

            btnDashboard.BackColor = Color.White;
            btnEmployees.BackColor = Color.FromArgb(249, 249, 249);
            btnHistory.BackColor = Color.FromArgb(249, 249, 249);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            pnlDashboard.Visible = false;
            pnlEmployees.Visible = true;

            btnEmployees.BackColor = Color.White;
            btnHistory.BackColor = Color.FromArgb(249, 249, 249);
            btnDashboard.BackColor = Color.FromArgb(249, 249, 249);
        }
        private void btnHistory_Click(object sender, EventArgs e)
        {
            pnlDashboard.Visible = false;
            pnlEmployees.Visible = false;

            btnHistory.BackColor = Color.White;
            btnDashboard.BackColor = Color.FromArgb(249, 249, 249);
            btnEmployees.BackColor = Color.FromArgb(249, 249, 249);
        }

        private void pnlEmployeeDetails_Paint(object sender, PaintEventArgs e)
        {
            Color col = Color.FromArgb(172, 172, 172); 
            ButtonBorderStyle bbs = ButtonBorderStyle.Solid; 
            int thickness = 2; 
            ControlPaint.DrawBorder(e.Graphics, this.pnlEmployeeDetails.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
        }

        private void richButton2_Click(object sender, EventArgs e)
        {

        }

        private void dgvEmployeesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlSearchEmployee_Paint(object sender, PaintEventArgs e)
        {
            Color col = Color.FromArgb(172, 172, 172);
            ButtonBorderStyle bbs = ButtonBorderStyle.Solid;
            int thickness = 2;
            ControlPaint.DrawBorder(e.Graphics, this.pnlSearchEmployee.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
        }

        private void pnlEmployeesTable_Paint(object sender, PaintEventArgs e)
        {
            Color col = Color.FromArgb(172, 172, 172);
            ButtonBorderStyle bbs = ButtonBorderStyle.Solid;
            int thickness = 2;
            ControlPaint.DrawBorder(e.Graphics, this.pnlEmployeesTable.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
        }

        private void pnlEmployeeDetails2_Paint(object sender, PaintEventArgs e)
        {
            Color col = Color.FromArgb(172, 172, 172);
            ButtonBorderStyle bbs = ButtonBorderStyle.Solid;
            int thickness = 2;
            ControlPaint.DrawBorder(e.Graphics, this.pnlEmployeeDetails2.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
        }

        private void pnlTotalSalary_Paint(object sender, PaintEventArgs e)
        {
            Color col = Color.FromArgb(172, 172, 172);
            ButtonBorderStyle bbs = ButtonBorderStyle.Solid;
            int thickness = 2;
            ControlPaint.DrawBorder(e.Graphics, this.pnlTotalSalary.ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
        }
    }
}
