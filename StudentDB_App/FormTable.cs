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
	public partial class FormTable : Form
	{
		public FormTable()
		{
			InitializeComponent();
		}

		private void FormTable_FormClosed(object sender, FormClosedEventArgs e)
		{
			Owner.Show();
		}

		private void FormTable_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			Search_BTN.Image = (Image)(new Bitmap(Search_BTN.Image, new Size(16, 16)));
			Student_DBEntities S = new Student_DBEntities();
			dataGridView.DataSource = S.Students.ToList();
			DGV_PostProcessing();
		}

		private void Search_BTN_Click(object sender, EventArgs e)
		{
			Student_DBEntities S = new Student_DBEntities();
			//dataGridView.DataSource = null;
			if (Search_TB.Text == "")
			{
				dataGridView.DataSource = S.Students.ToList();
			}
			else
			{
				switch (SearchType_CB.GetItemText(SearchType_CB.SelectedItem))
				{
					case "الاسم":
						dataGridView.DataSource = S.Students.Where(x => x.Name.Contains(Search_TB.Text)).OrderBy(x=>x.Name).ToList();
						break;
					case "التلفون":
						dataGridView.DataSource = S.Students.Where(x => x.Phone.Contains(Search_TB.Text)).OrderBy(x => x.Phone).ToList();
						break;
					case "البريد":
						dataGridView.DataSource = S.Students.Where(x => x.Email.Contains(Search_TB.Text)).OrderBy(x => x.Email).ToList();
						break;
					case "الدورات التدريبيه":
						dataGridView.DataSource = S.Students.Where(x => x.Courses.Contains(Search_TB.Text)).OrderBy(x => x.Courses).ToList();
						break;
					case "الشعبه":
						dataGridView.DataSource = S.Students.Where(x => x.division.Contains(Search_TB.Text)).OrderBy(x => x.division).ToList();
						break;
					case "التقدير":
						dataGridView.DataSource = S.Students.Where(x => x.Score.Contains(Search_TB.Text)).OrderBy(x => x.Score).ToList();
						break;
					case "الوظيفه":
						dataGridView.DataSource = S.Students.Where(x => x.Job.Contains(Search_TB.Text)).OrderBy(x => x.Job).ToList();
						break;
					case "سنة التخرج":
						int i;
						Int32.TryParse(Search_TB.Text,out i);
						dataGridView.DataSource = S.Students.Where(x => x.Graduation_Year == i).OrderBy(x => x.Graduation_Year).ToList();
						break;
					case "الدرجة العلمية":
						dataGridView.DataSource = S.Students.Where(x => x.Degree.Contains(Search_TB.Text)).OrderBy(x => x.Degree).ToList();
						break;
					default:
						dataGridView.DataSource = S.Students.ToList();
						break;
				}
			}
			DGV_PostProcessing();
			dataGridView.Refresh();
		}

		private void DGV_PostProcessing()
		{
			if (!dataGridView.Columns.Contains("Delete"))
			{
				dataGridView.Columns.Add("Delete", "");
				dataGridView.Columns["Delete"].DefaultCellStyle.NullValue = "حذف";
			}
			foreach (DataGridViewColumn c in dataGridView.Columns)
			{
				switch (c.Name)
				{
					case "Id":
						c.Visible = false;
						break;
					case "Name":
						c.HeaderText = "الاسم";
						break;
					case "Phone":
						c.HeaderText = "التلفون";
						break;
					case "Email":
						c.HeaderText = "البريد";
						c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
						break;
					case "Courses":
						c.HeaderText = "الدورات التدريبيه";
						break;
					case "division":
						c.HeaderText = "الشعبه";
						break;
					case "Score":
						c.HeaderText = "التقدير";
						break;
					case "Job":
						c.HeaderText = "الوظيفه";
						c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
						break;
					case "Graduation_Year":
						c.HeaderText = "سنة التخرج";
						break;
					case "Degree":
						c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
						c.HeaderText = "الدرجة العلمية";
						break;
					default:
						break;
				}
			}
		}

		private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			int id;
			Int32.TryParse(dataGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out id);
			if (dataGridView.Columns[e.ColumnIndex].Name == "Delete")
			{
				Student_DBEntities S = new Student_DBEntities();
				Student student = S.Students.FirstOrDefault(x => x.Id == id);
				S.Students.Remove(student);
				S.SaveChanges();
				Form T = new FormTable();
				T.Owner = this.Owner;
				T.Show();
				this.Dispose(false);
			}
			else
			{
				Form T = new FormAdd(id);
				T.Owner = this;
				T.Show();
				this.Hide();
			}
		}

		private void Back_BTN_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
