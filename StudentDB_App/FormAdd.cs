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
	public partial class FormAdd : Form
	{
		private int ID;
		private bool Add;

		public FormAdd()
		{
			InitializeComponent();
			Add = true;
		}

		public FormAdd(int id)
		{
			InitializeComponent();
			ID = id;
			Add = false;
		}

		private void FormAdd_FormClosed(object sender, FormClosedEventArgs e)
		{
			switch (Add)
			{
				case true:
					Owner.Show();
					break;
				case false:
					Form T = new FormTable();
					T.Owner = this.Owner.Owner;
					T.Show();
					this.Hide();
					break;
			}
		}

		private void FormAdd_Load(object sender, EventArgs e)
		{
			Add_BTN.Image = (Image)(new Bitmap(Add_BTN.Image, new Size(16, 16)));
			switch(Add)
			{
				case true:
					Add_BTN.Visible = true;
					break;
				case false:
					Edit_BTN.Visible = true;
					Student_DBEntities S = new Student_DBEntities();
					Student student = S.Students.First(x => x.Id == ID);
					TB_Name.Text = student.Name;
					TB_Phone.Text = student.Phone;
					TB_Email.Text = student.Email;
					TB_Courses.Text = student.Courses;
					TB_Division.Text = student.division;
					TB_Score.Text = student.Score;
					TB_Job.Text = student.Job;
					TB_Grad_year.Text = student.Graduation_Year.ToString();
					TB_Degree.Text = student.Degree;
					break;
			}
		}

		private void Add_BTN_Click(object sender, EventArgs e)
		{
			Student_DBEntities S = new Student_DBEntities();
			Student student = new Student();
			student.Name = TB_Name.Text;
			student.Phone = TB_Phone.Text;
			student.Email = TB_Email.Text;
			student.Courses = TB_Courses.Text;
			student.division = TB_Division.Text;
			student.Score = TB_Score.Text;
			student.Job = TB_Job.Text;
			if (TB_Grad_year.Text != "")
			{
				int i;
				Int32.TryParse(TB_Grad_year.Text, out i);
				student.Graduation_Year = i;
			}
			else
			{
				student.Graduation_Year = 0;
			}
			student.Degree = TB_Degree.Text;
			S.Students.Add(student);
			S.SaveChanges();
			this.Close();
		}

		private void Edit_BTN_Click(object sender, EventArgs e)
		{
			Student_DBEntities S = new Student_DBEntities();
			Student student = S.Students.FirstOrDefault(x => x.Id == ID);
			student.Name = TB_Name.Text;
			student.Phone = TB_Phone.Text;
			student.Email = TB_Email.Text;
			student.Courses = TB_Courses.Text;
			student.division = TB_Division.Text;
			student.Score = TB_Score.Text;
			student.Job = TB_Job.Text;
			if (TB_Grad_year.Text != "")
			{
				int i;
				Int32.TryParse(TB_Grad_year.Text, out i);
				student.Graduation_Year = i;
			}
			else
			{
				student.Graduation_Year = 0;
			}
			student.Degree = TB_Degree.Text;
			S.SaveChanges();
			this.Close();
		}

		private void Back_BTN_Click(object sender, EventArgs e)
		{
			Add = true;
			this.Close();
		}
	}
}
