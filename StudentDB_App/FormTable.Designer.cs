namespace StudentDB_App
{
	partial class FormTable
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
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.SearchType_CB = new System.Windows.Forms.ComboBox();
			this.Search_TB = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Search_BTN = new System.Windows.Forms.Button();
			this.Back_BTN = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(12, 58);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.Size = new System.Drawing.Size(1213, 483);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
			// 
			// SearchType_CB
			// 
			this.SearchType_CB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchType_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SearchType_CB.FormattingEnabled = true;
			this.SearchType_CB.Items.AddRange(new object[] {
            "الاسم",
            "التلفون",
            "البريد",
            "الدورات التدريبيه",
            "الشعبه",
            "التقدير",
            "الوظيفه",
            "سنة التخرج",
            "الدرجة العلمية"});
			this.SearchType_CB.Location = new System.Drawing.Point(871, 19);
			this.SearchType_CB.Name = "SearchType_CB";
			this.SearchType_CB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.SearchType_CB.Size = new System.Drawing.Size(131, 21);
			this.SearchType_CB.TabIndex = 2;
			// 
			// Search_TB
			// 
			this.Search_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Search_TB.Location = new System.Drawing.Point(1025, 19);
			this.Search_TB.Name = "Search_TB";
			this.Search_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Search_TB.Size = new System.Drawing.Size(162, 20);
			this.Search_TB.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(1193, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "بـحـث";
			// 
			// Search_BTN
			// 
			this.Search_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Search_BTN.Image = global::StudentDB_App.Properties.Resources.search;
			this.Search_BTN.Location = new System.Drawing.Point(764, 19);
			this.Search_BTN.Name = "Search_BTN";
			this.Search_BTN.Size = new System.Drawing.Size(75, 22);
			this.Search_BTN.TabIndex = 1;
			this.Search_BTN.Text = "بـحـث";
			this.Search_BTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Search_BTN.UseVisualStyleBackColor = true;
			this.Search_BTN.Click += new System.EventHandler(this.Search_BTN_Click);
			// 
			// Back_BTN
			// 
			this.Back_BTN.Location = new System.Drawing.Point(12, 17);
			this.Back_BTN.Name = "Back_BTN";
			this.Back_BTN.Size = new System.Drawing.Size(75, 23);
			this.Back_BTN.TabIndex = 25;
			this.Back_BTN.Text = "عوده";
			this.Back_BTN.UseVisualStyleBackColor = true;
			this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
			// 
			// FormTable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1237, 553);
			this.Controls.Add(this.Back_BTN);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Search_TB);
			this.Controls.Add(this.SearchType_CB);
			this.Controls.Add(this.Search_BTN);
			this.Controls.Add(this.dataGridView);
			this.Name = "FormTable";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "القائمه";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTable_FormClosed);
			this.Load += new System.EventHandler(this.FormTable_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button Search_BTN;
		private System.Windows.Forms.ComboBox SearchType_CB;
		private System.Windows.Forms.TextBox Search_TB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Back_BTN;
	}
}