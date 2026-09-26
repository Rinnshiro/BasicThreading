using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace BasicThreading
{
	public partial class FrmBasicThread : Form
	{
		public FrmBasicThread()
		{
			InitializeComponent();
		}

		private void btnRun_Click(object sender, EventArgs e)
		{
			Console.WriteLine("-Before starting thread-");
			Thread threadA = new Thread(MyThreadClass.Thread1);
			threadA.Name = "Thread A Process";

			Thread threadB = new Thread(MyThreadClass.Thread1);
			threadB.Name = "Thread B Process";

			threadA.Start();
			threadB.Start();

			threadA.Join();
			threadB.Join();

			lblStatus.Text = "-End of Thread-";
			Console.WriteLine("-End of Thread-");
		}
	}
}