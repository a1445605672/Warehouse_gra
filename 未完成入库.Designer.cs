﻿
namespace Warehouse
{
	partial class 未完成入库
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.uiPagination1 = new Sunny.UI.UIPagination();
			this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
			this.PagePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// PagePanel
			// 
			this.PagePanel.Controls.Add(this.uiDataGridView1);
			// 
			// uiPagination1
			// 
			this.uiPagination1.ActivePage = 20;
			this.uiPagination1.CausesValidation = false;
			this.uiPagination1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.uiPagination1.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiPagination1.Location = new System.Drawing.Point(0, 415);
			this.uiPagination1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.uiPagination1.MinimumSize = new System.Drawing.Size(1, 1);
			this.uiPagination1.Name = "uiPagination1";
			this.uiPagination1.PagerCount = 11;
			this.uiPagination1.PageSize = 19;
			this.uiPagination1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
			this.uiPagination1.Size = new System.Drawing.Size(800, 35);
			this.uiPagination1.TabIndex = 3;
			this.uiPagination1.Text = "uiDataGridPage1";
			this.uiPagination1.TotalCount = 40000;
			this.uiPagination1.PageChanged += new Sunny.UI.UIPagination.OnPageChangeEventHandler(this.uiPagination1_PageChanged);
			// 
			// uiDataGridView1
			// 
			this.uiDataGridView1.AllowUserToAddRows = false;
			this.uiDataGridView1.AllowUserToResizeColumns = false;
			this.uiDataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
			this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.uiDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.uiDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.uiDataGridView1.ColumnHeadersHeight = 32;
			this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			this.uiDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.uiDataGridView1.EnableHeadersVisualStyles = false;
			this.uiDataGridView1.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
			this.uiDataGridView1.Location = new System.Drawing.Point(0, 0);
			this.uiDataGridView1.MultiSelect = false;
			this.uiDataGridView1.Name = "uiDataGridView1";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.uiDataGridView1.RowHeadersVisible = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.uiDataGridView1.RowTemplate.Height = 29;
			this.uiDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.uiDataGridView1.SelectedIndex = -1;
			this.uiDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.uiDataGridView1.ShowGridLine = true;
			this.uiDataGridView1.ShowRect = false;
			this.uiDataGridView1.Size = new System.Drawing.Size(800, 415);
			this.uiDataGridView1.TabIndex = 1;
			this.uiDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView1_CellContentClick);
			// 
			// 未完成入库
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.uiPagination1);
			this.Name = "未完成入库";
			this.Text = "未完成入库";
			this.Load += new System.EventHandler(this.未完成入库_Load);
			this.Controls.SetChildIndex(this.PagePanel, 0);
			this.Controls.SetChildIndex(this.uiPagination1, 0);
			this.PagePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Sunny.UI.UIPagination uiPagination1;
		private Sunny.UI.UIDataGridView uiDataGridView1;
	}
}