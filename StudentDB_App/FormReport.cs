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
	public partial class FormReport : Form
	{
		public FormReport()
		{
			InitializeComponent();
		}

		private void FormReport_FormClosed(object sender, FormClosedEventArgs e)
		{
			Owner.Show();
		}

		private void FormReport_Load(object sender, EventArgs e)
		{
			Student_DBEntities S = new Student_DBEntities();
			var GYL = S.Students.GroupBy(x => x.Graduation_Year);
			foreach (var i in GYL)
			{
				Year_CB.Items.Add(i.Key.ToString());
			}
			Year_CB.SelectedIndex = 0;
		}

		private void Year_CB_SelectedIndexChanged(object sender, EventArgs e)
		{
			Student_DBEntities S = new Student_DBEntities();
			int Grad_year;
			Int32.TryParse(Year_CB.GetItemText(Year_CB.SelectedItem), out Grad_year);
			int year_grads_count = S.Students.ToList().Where(x => x.Graduation_Year == Grad_year).Count();
			int total_grads_count = S.Students.ToList().Count();
			float ratio = ((float)year_grads_count / (float)total_grads_count) * 100;
			Count_LBL.Text = year_grads_count.ToString();
			Total_Count_LBL.Text = total_grads_count.ToString();
			Ratio_LBL.Text = ratio.ToString()+" %";
		}

		private void Back_BTN_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
