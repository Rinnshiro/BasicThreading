namespace BasicThreading
{
	partial class FrmBasicThread
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lblStatus = new Label();
			btnRun = new Button();
			SuspendLayout();
			// 
			// lblStatus
			// 
			lblStatus.AutoSize = true;
			lblStatus.Font = new Font("Segoe UI", 18F);
			lblStatus.Location = new Point(47, 72);
			lblStatus.Name = "lblStatus";
			lblStatus.Size = new Size(267, 32);
			lblStatus.TabIndex = 0;
			lblStatus.Text = "-Before starting thread-";
			lblStatus.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnRun
			// 
			btnRun.Cursor = Cursors.Hand;
			btnRun.FlatStyle = FlatStyle.Flat;
			btnRun.Font = new Font("Segoe UI", 10F);
			btnRun.Location = new Point(128, 126);
			btnRun.Name = "btnRun";
			btnRun.Size = new Size(100, 35);
			btnRun.TabIndex = 1;
			btnRun.Text = "Run";
			btnRun.UseVisualStyleBackColor = true;
			btnRun.Click += this.btnRun_Click;
			// 
			// FrmBasicThread
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(384, 261);
			Controls.Add(btnRun);
			Controls.Add(lblStatus);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "FrmBasicThread";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "BasicThread";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblStatus;
		private Button btnRun;
	}
}