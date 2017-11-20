namespace SortApp
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && ( components != null ))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.ckSort1 = new System.Windows.Forms.CheckBox();
			this.ckSort2 = new System.Windows.Forms.CheckBox();
			this.lsSort1 = new System.Windows.Forms.ListBox();
			this.lsSort2 = new System.Windows.Forms.ListBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.30238F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.69762F));
			this.tableLayoutPanel1.Controls.Add(this.ckSort1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lsSort1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.ckSort2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lsSort2, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.85742F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.14258F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(463, 519);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// ckSort1
			// 
			this.ckSort1.AutoSize = true;
			this.ckSort1.Location = new System.Drawing.Point(3, 3);
			this.ckSort1.Name = "ckSort1";
			this.ckSort1.Size = new System.Drawing.Size(66, 19);
			this.ckSort1.TabIndex = 0;
			this.ckSort1.Text = "排序1";
			this.ckSort1.UseVisualStyleBackColor = true;
			this.ckSort1.CheckedChanged += new System.EventHandler(this.ckSort1_CheckedChanged);
			// 
			// ckSort2
			// 
			this.ckSort2.AutoSize = true;
			this.ckSort2.Location = new System.Drawing.Point(3, 240);
			this.ckSort2.Name = "ckSort2";
			this.ckSort2.Size = new System.Drawing.Size(66, 19);
			this.ckSort2.TabIndex = 1;
			this.ckSort2.Text = "排序2";
			this.ckSort2.UseVisualStyleBackColor = true;
			this.ckSort2.CheckedChanged += new System.EventHandler(this.ckSort2_CheckedChanged);
			// 
			// lsSort1
			// 
			this.lsSort1.FormattingEnabled = true;
			this.lsSort1.ItemHeight = 15;
			this.lsSort1.Location = new System.Drawing.Point(96, 3);
			this.lsSort1.Name = "lsSort1";
			this.lsSort1.Size = new System.Drawing.Size(211, 229);
			this.lsSort1.TabIndex = 2;
			// 
			// lsSort2
			// 
			this.lsSort2.FormattingEnabled = true;
			this.lsSort2.ItemHeight = 15;
			this.lsSort2.Location = new System.Drawing.Point(96, 240);
			this.lsSort2.Name = "lsSort2";
			this.lsSort2.Size = new System.Drawing.Size(211, 259);
			this.lsSort2.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(463, 519);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.CheckBox ckSort1;
		private System.Windows.Forms.ListBox lsSort1;
		private System.Windows.Forms.CheckBox ckSort2;
		private System.Windows.Forms.ListBox lsSort2;
	}
}

