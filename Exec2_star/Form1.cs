using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_star
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnLeft_Click(object sender, EventArgs e)
		{
			int rows=0;
			try
			{
				rows = GetInt();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			//呈現星號
			string stars = GenerateStars(rows);

			//呈現結果
			stars = txtGenerateStar.Text;
		}

		private string GenerateStars(int rows)
		{
			string result=string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				result+=new string('*',i)+"\r\n";
			}
			return result;
		}

		private int GetInt()
		{//判斷rows是否為整數,不能小於零、大於10
			string input= txtInsertLine.Text;
			bool Isint = int.TryParse(input, out int rows);
			if (Isint == false)throw new Exception("請輸入列數");
			else if (rows <= 0|| rows > 10)throw new Exception("列數必需在0到10之間");	
			return rows;
		}

		private void btnRight_Click(object sender, EventArgs e)
		{
			int rows = 0;
			try
			{
				rows = GetInt();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			string stars = GenerateStarRight(rows);
			txtGenerateStar.Text= stars;
		}

		private string GenerateStarRight(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i < rows; i++)
			{
				result += new string(' ',rows-i).PadLeft(rows+i-1,' ') + "\r\n";
			}
			return result;
		}

		private void btnMiddle_Click(object sender, EventArgs e)
		{

		}

	}
}
