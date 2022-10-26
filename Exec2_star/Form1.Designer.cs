namespace Exec2_star
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
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
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
			this.lblRows = new System.Windows.Forms.Label();
			this.txtGenerateStar = new System.Windows.Forms.TextBox();
			this.txtInsertLine = new System.Windows.Forms.TextBox();
			this.btnLeft = new System.Windows.Forms.Button();
			this.btnRight = new System.Windows.Forms.Button();
			this.btnMiddle = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblRows
			// 
			this.lblRows.AutoSize = true;
			this.lblRows.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblRows.Location = new System.Drawing.Point(56, 52);
			this.lblRows.Name = "lblRows";
			this.lblRows.Size = new System.Drawing.Size(67, 17);
			this.lblRows.TabIndex = 0;
			this.lblRows.Text = "列數1-10:";
			// 
			// txtGenerateStar
			// 
			this.txtGenerateStar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtGenerateStar.Location = new System.Drawing.Point(58, 87);
			this.txtGenerateStar.Multiline = true;
			this.txtGenerateStar.Name = "txtGenerateStar";
			this.txtGenerateStar.ReadOnly = true;
			this.txtGenerateStar.Size = new System.Drawing.Size(440, 200);
			this.txtGenerateStar.TabIndex = 1;
			// 
			// txtInsertLine
			// 
			this.txtInsertLine.Location = new System.Drawing.Point(129, 49);
			this.txtInsertLine.Name = "txtInsertLine";
			this.txtInsertLine.Size = new System.Drawing.Size(100, 22);
			this.txtInsertLine.TabIndex = 2;
			// 
			// btnLeft
			// 
			this.btnLeft.Location = new System.Drawing.Point(261, 47);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.Size = new System.Drawing.Size(75, 23);
			this.btnLeft.TabIndex = 3;
			this.btnLeft.Text = "靠左";
			this.btnLeft.UseVisualStyleBackColor = true;
			this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
			
			// 
			// btnRight
			// 
			this.btnRight.Location = new System.Drawing.Point(342, 47);
			this.btnRight.Name = "btnRight";
			this.btnRight.Size = new System.Drawing.Size(75, 23);
			this.btnRight.TabIndex = 3;
			this.btnRight.Text = "靠右";
			this.btnRight.UseVisualStyleBackColor = true;
			this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
			// 
			// btnMiddle
			// 
			this.btnMiddle.Location = new System.Drawing.Point(423, 47);
			this.btnMiddle.Name = "btnMiddle";
			this.btnMiddle.Size = new System.Drawing.Size(75, 23);
			this.btnMiddle.TabIndex = 3;
			this.btnMiddle.Text = "等腰";
			this.btnMiddle.UseVisualStyleBackColor = true;
			this.btnMiddle.Click += new System.EventHandler(this.btnMiddle_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(567, 323);
			this.Controls.Add(this.btnMiddle);
			this.Controls.Add(this.btnRight);
			this.Controls.Add(this.btnLeft);
			this.Controls.Add(this.txtInsertLine);
			this.Controls.Add(this.txtGenerateStar);
			this.Controls.Add(this.lblRows);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblRows;
		private System.Windows.Forms.TextBox txtGenerateStar;
		private System.Windows.Forms.TextBox txtInsertLine;
		private System.Windows.Forms.Button btnLeft;
		private System.Windows.Forms.Button btnRight;
		private System.Windows.Forms.Button btnMiddle;
	}
}

