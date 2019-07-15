namespace StudentDB_App
{
	partial class FormReport
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Count_LBL = new System.Windows.Forms.Label();
			this.Total_Count_LBL = new System.Windows.Forms.Label();
			this.Ratio_LBL = new System.Windows.Forms.Label();
			this.Year_CB = new System.Windows.Forms.ComboBox();
			this.Back_BTN = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(232, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "عدد الطلبه";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(195, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "اجمالي عدد الطلبه";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(219, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "النسبه المئوية";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Count_LBL
			// 
			this.Count_LBL.AutoSize = true;
			this.Count_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Count_LBL.Location = new System.Drawing.Point(45, 54);
			this.Count_LBL.Name = "Count_LBL";
			this.Count_LBL.Size = new System.Drawing.Size(51, 20);
			this.Count_LBL.TabIndex = 3;
			this.Count_LBL.Text = "label4";
			// 
			// Total_Count_LBL
			// 
			this.Total_Count_LBL.AutoSize = true;
			this.Total_Count_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Total_Count_LBL.Location = new System.Drawing.Point(45, 92);
			this.Total_Count_LBL.Name = "Total_Count_LBL";
			this.Total_Count_LBL.Size = new System.Drawing.Size(51, 20);
			this.Total_Count_LBL.TabIndex = 4;
			this.Total_Count_LBL.Text = "label5";
			// 
			// Ratio_LBL
			// 
			this.Ratio_LBL.AutoSize = true;
			this.Ratio_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Ratio_LBL.Location = new System.Drawing.Point(45, 135);
			this.Ratio_LBL.Name = "Ratio_LBL";
			this.Ratio_LBL.Size = new System.Drawing.Size(51, 20);
			this.Ratio_LBL.TabIndex = 5;
			this.Ratio_LBL.Text = "label6";
			// 
			// Year_CB
			// 
			this.Year_CB.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Year_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Year_CB.FormattingEnabled = true;
			this.Year_CB.Location = new System.Drawing.Point(100, 12);
			this.Year_CB.Name = "Year_CB";
			this.Year_CB.Size = new System.Drawing.Size(121, 21);
			this.Year_CB.TabIndex = 6;
			this.Year_CB.SelectedIndexChanged += new System.EventHandler(this.Year_CB_SelectedIndexChanged);
			// 
			// Back_BTN
			// 
			this.Back_BTN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.Back_BTN.Location = new System.Drawing.Point(124, 156);
			this.Back_BTN.Name = "Back_BTN";
			this.Back_BTN.Size = new System.Drawing.Size(75, 23);
			this.Back_BTN.TabIndex = 25;
			this.Back_BTN.Text = "عوده";
			this.Back_BTN.UseVisualStyleBackColor = true;
			this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
			// 
			// FormReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(337, 191);
			this.Controls.Add(this.Back_BTN);
			this.Controls.Add(this.Year_CB);
			this.Controls.Add(this.Ratio_LBL);
			this.Controls.Add(this.Total_Count_LBL);
			this.Controls.Add(this.Count_LBL);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormReport";
			this.Text = "التقرير";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReport_FormClosed);
			this.Load += new System.EventHandler(this.FormReport_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label Count_LBL;
		private System.Windows.Forms.Label Total_Count_LBL;
		private System.Windows.Forms.Label Ratio_LBL;
		private System.Windows.Forms.ComboBox Year_CB;
		private System.Windows.Forms.Button Back_BTN;
	}
}