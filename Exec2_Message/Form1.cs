using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Message
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			label1.Text=string.Empty;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnGreeting_Click(object sender, EventArgs e)
		{
			DateTime dt= DateTime.Now;
			string greeting = dt.ToString();
			string sayHi = $"Hello!{dt}";
			label1.Text= sayHi;
		}
	}
}
