using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDB_App
{
	public partial class FormHome : Form
	{
		public FormHome()
		{
			InitializeComponent();
		}

		private void Table_BTN_Click(object sender, EventArgs e)
		{
			Form T = new FormTable();
			T.Owner = this;
			T.Show();
			this.Hide();
		}

		private void Add_BTN_Click(object sender, EventArgs e)
		{
			Form T = new FormAdd();
			T.Owner = this;
			T.Show();
			this.Hide();
		}

		private void Report_BTN_Click(object sender, EventArgs e)
		{
			Form T = new FormReport();
			T.Owner = this;
			T.Show();
			this.Hide();
		}

		private void FormHome_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void FormHome_Load(object sender, EventArgs e)
		{
			Table_BTN.Image = (Image)(new Bitmap(Table_BTN.Image, new Size(32, 32)));
			Add_BTN.Image = (Image)(new Bitmap(Add_BTN.Image, new Size(32, 32)));
			Report_BTN.Image = (Image)(new Bitmap(Report_BTN.Image, new Size(32, 32)));
		}

		private void Back_BTN_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
