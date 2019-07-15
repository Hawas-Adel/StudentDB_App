namespace StudentDB_App
{
	partial class FormHome
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Back_BTN = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Report_BTN = new System.Windows.Forms.Button();
			this.Add_BTN = new System.Windows.Forms.Button();
			this.Table_BTN = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Back_BTN
			// 
			this.Back_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Back_BTN.Location = new System.Drawing.Point(42, 469);
			this.Back_BTN.Name = "Back_BTN";
			this.Back_BTN.Size = new System.Drawing.Size(75, 23);
			this.Back_BTN.TabIndex = 25;
			this.Back_BTN.Text = "خروج";
			this.Back_BTN.UseVisualStyleBackColor = true;
			this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.Image = global::StudentDB_App.Properties.Resources.Logo_cropped;
			this.pictureBox2.Location = new System.Drawing.Point(252, 41);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(122, 95);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 27;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::StudentDB_App.Properties.Resources.alfyoum;
			this.pictureBox1.Location = new System.Drawing.Point(42, 41);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(122, 95);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// Report_BTN
			// 
			this.Report_BTN.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Report_BTN.Image = global::StudentDB_App.Properties.Resources.report;
			this.Report_BTN.Location = new System.Drawing.Point(119, 366);
			this.Report_BTN.Name = "Report_BTN";
			this.Report_BTN.Size = new System.Drawing.Size(171, 62);
			this.Report_BTN.TabIndex = 2;
			this.Report_BTN.Text = "التقرير";
			this.Report_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Report_BTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Report_BTN.UseVisualStyleBackColor = true;
			this.Report_BTN.Click += new System.EventHandler(this.Report_BTN_Click);
			// 
			// Add_BTN
			// 
			this.Add_BTN.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Add_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Add_BTN.Image = global::StudentDB_App.Properties.Resources.add;
			this.Add_BTN.Location = new System.Drawing.Point(119, 289);
			this.Add_BTN.Name = "Add_BTN";
			this.Add_BTN.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Add_BTN.Size = new System.Drawing.Size(171, 62);
			this.Add_BTN.TabIndex = 1;
			this.Add_BTN.Text = "إضافه";
			this.Add_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Add_BTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Add_BTN.UseVisualStyleBackColor = true;
			this.Add_BTN.Click += new System.EventHandler(this.Add_BTN_Click);
			// 
			// Table_BTN
			// 
			this.Table_BTN.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Table_BTN.Image = global::StudentDB_App.Properties.Resources.Home;
			this.Table_BTN.Location = new System.Drawing.Point(119, 213);
			this.Table_BTN.Name = "Table_BTN";
			this.Table_BTN.Size = new System.Drawing.Size(171, 62);
			this.Table_BTN.TabIndex = 0;
			this.Table_BTN.Text = "القائمه";
			this.Table_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Table_BTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Table_BTN.UseVisualStyleBackColor = true;
			this.Table_BTN.Click += new System.EventHandler(this.Table_BTN_Click);
			// 
			// FormHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(413, 514);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.Back_BTN);
			this.Controls.Add(this.Report_BTN);
			this.Controls.Add(this.Add_BTN);
			this.Controls.Add(this.Table_BTN);
			this.Name = "FormHome";
			this.Text = "الصفحة الرئيسية";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHome_FormClosed);
			this.Load += new System.EventHandler(this.FormHome_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Table_BTN;
		private System.Windows.Forms.Button Add_BTN;
		private System.Windows.Forms.Button Report_BTN;
		private System.Windows.Forms.Button Back_BTN;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}

